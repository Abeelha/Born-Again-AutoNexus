using AutoNexus.Configuration;
using Il2CppInterop.Runtime;
using MelonLoader;
using UnityEngine;
using Il2CppTMPro;
using UnityEngine.Events;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.UI;

namespace AutoNexus.UI
{
    public class ConfigDisplay
    {
        private readonly ModConfig _config;
        private readonly MelonLogger.Instance _logger;
        private GameObject _configPanel;
        private bool _isVisible = true;
        private bool _isInitialized = false;
        private Canvas _mainCanvas;

        private TMP_InputField _healthThresholdInput;
        private TMP_InputField _autoPotThresholdInput;
        private TMP_InputField _autoPotKeyInput;
        private TMP_InputField _autoPotToggleInput;
        private TMP_InputField _disconnectKeyInput;


        private TextMeshProUGUI _healthValueText;
        private TextMeshProUGUI _autoPotValueText;
        private TextMeshProUGUI _potKeyValueText;
        private TextMeshProUGUI _toggleValueText;
        private TextMeshProUGUI _nexusValueText;
        private Image _saveButtonImage;
        private TextMeshProUGUI _saveButtonText;


        private readonly Color PANEL_COLOR = new Color(0.08f, 0.04f, 0.16f, 0.95f);
        private readonly Color LABEL_COLOR = new Color(0.95f, 0.4f, 0.95f, 1f);
        private readonly Color VALUE_COLOR = new Color(0.4f, 0.95f, 0.95f, 1f);
        private readonly Color INPUT_BG_COLOR = new Color(0.12f, 0.08f, 0.2f, 1f);
        private readonly Color BUTTON_COLOR = new Color(0.95f, 0.2f, 0.6f, 1f);
        private readonly Color DIVIDER_COLOR = new Color(0.95f, 0.4f, 0.95f, 0.2f);
        private readonly Color SUCCESS_COLOR = new Color(0.2f, 0.95f, 0.4f, 1f);
        private readonly Color ERROR_COLOR = new Color(0.95f, 0.2f, 0.2f, 1f);


        private const float PANEL_WIDTH = 200f;
        private const float PANEL_HEIGHT = 220f;
        private const float DESIRED_SCALE = 0.5f;
        
        private const float ROW_HEIGHT = 25f;
        private const float ROW_PADDING = 4f;
        private const float HEADER_HEIGHT = 20f;
        private const float SAVE_BUTTON_HEIGHT = 20f;
        private const float SAVE_BUTTON_WIDTH = 60f;
        private const float DIVIDER_MARGIN = 1.5f;

        private Vector3 _originalScale;
        private Vector2 _originalSize;

        public ConfigDisplay(ModConfig config, MelonLogger.Instance logger)
        {
            _config = config;
            _logger = logger;
        }

        public void Initialize(Canvas canvas)
        {
            if (canvas == null)
            {
                _logger.Error("Canvas not found!");
                return;
            }

            _mainCanvas = canvas;
        }

        public void Update()
        {
            if (Input.GetKeyDown(KeyCode.Insert))
            {
                if (!_isInitialized)
                {
                    CreateUI();
                    _isInitialized = true;
                    _isVisible = true;
                }
                else
                {
                    if (_configPanel != null)
                    {
                        _isVisible = !_isVisible;
                        _configPanel.SetActive(_isVisible);
                    }
                    else
                    {
                        CreateUI();
                        _isVisible = true;
                    }
                }
            }

            if (_configPanel != null && _isVisible)
            {
                RectTransform rect = _configPanel.GetComponent<RectTransform>();
                if (rect != null)
                {
                    if (rect.localScale != Vector3.one * DESIRED_SCALE)
                    {
                        rect.localScale = Vector3.one * DESIRED_SCALE;
                    }

                    if (rect.sizeDelta != new Vector2(PANEL_WIDTH, PANEL_HEIGHT))
                    {
                        rect.sizeDelta = new Vector2(PANEL_WIDTH, PANEL_HEIGHT);
                    }
                }

                var scaler = _configPanel.GetComponent<CanvasScaler>();
                if (scaler != null && scaler.scaleFactor != DESIRED_SCALE)
                {
                    scaler.scaleFactor = DESIRED_SCALE;
                }
            }
        }

        private void CreateUI()
        {
            if (_configPanel != null)
            {
                GameObject.Destroy(_configPanel);
            }

            CreatePanel(_mainCanvas);
            CreateHeader();
            CreateConfigDisplay();
            CreateSaveButton();
            UpdateCurrentValues();
            _configPanel.SetActive(true);
        }

        public void ToggleVisibility()
        {
            if (_configPanel != null)
            {
                _isVisible = !_isVisible;
                _configPanel.SetActive(_isVisible);
            }
        }

        private void CreatePanel(Canvas canvas)
        {
            _configPanel = new GameObject("ConfigPanel");
            _configPanel.transform.SetParent(canvas.transform, false);

            Canvas panelCanvas = _configPanel.AddComponent<Canvas>();
            panelCanvas.overrideSorting = true;
            panelCanvas.sortingOrder = 100;

            CanvasScaler scaler = _configPanel.AddComponent<CanvasScaler>();
            scaler.uiScaleMode = CanvasScaler.ScaleMode.ConstantPixelSize;
            scaler.scaleFactor = DESIRED_SCALE;

            _configPanel.AddComponent<GraphicRaycaster>();

            RectTransform panelRect = _configPanel.GetComponent<RectTransform>();
            panelRect.anchorMin = new Vector2(0, 0.5f);
            panelRect.anchorMax = new Vector2(0, 0.5f);
            panelRect.pivot = new Vector2(0, 0.5f);
            panelRect.anchoredPosition = new Vector2(10, 0);
            panelRect.sizeDelta = new Vector2(PANEL_WIDTH, PANEL_HEIGHT);
            panelRect.localScale = Vector3.one * DESIRED_SCALE;

            _originalScale = panelRect.localScale;
            _originalSize = panelRect.sizeDelta;

            var background = _configPanel.AddComponent<Image>();
            background.color = PANEL_COLOR;
        }
    


        private void CreateHeader()
        {
            GameObject headerObj = new GameObject("Header");
            headerObj.transform.SetParent(_configPanel.transform, false);

            var headerText = headerObj.AddComponent<TextMeshProUGUI>();
            headerText.text = "Settings";
            headerText.fontSize = 16;
            headerText.color = LABEL_COLOR;
            headerText.alignment = TextAlignmentOptions.Center;
            headerText.fontStyle = FontStyles.Bold;

            RectTransform headerRect = headerText.rectTransform;
            headerRect.anchorMin = new Vector2(0, 1);
            headerRect.anchorMax = new Vector2(1, 1);
            headerRect.pivot = new Vector2(0.5f, 1);
            headerRect.sizeDelta = new Vector2(0, HEADER_HEIGHT);
            headerRect.anchoredPosition = new Vector2(0, -5);

            CreateDivider(headerRect.anchoredPosition.y - HEADER_HEIGHT);
        }

        private void CreateDivider(float yPosition)
        {
            GameObject divider = new GameObject("Divider");
            divider.transform.SetParent(_configPanel.transform, false);

            var dividerImage = divider.AddComponent<Image>();
            dividerImage.color = DIVIDER_COLOR;

            RectTransform dividerRect = divider.GetComponent<RectTransform>();
            dividerRect.anchorMin = new Vector2(0.05f, 1);
            dividerRect.anchorMax = new Vector2(0.95f, 1);
            dividerRect.pivot = new Vector2(0.5f, 1);
            dividerRect.sizeDelta = new Vector2(0, 1);
            dividerRect.anchoredPosition = new Vector2(0, yPosition);
        }

        private void CreateConfigDisplay()
        {
            float yOffset = -(HEADER_HEIGHT + 10);
            float totalRowHeight = ROW_HEIGHT + ROW_PADDING;

            CreateConfigRow("Health", _config.HealthThreshold.Value * 100 + "%", ref _healthThresholdInput, ref _healthValueText, yOffset);
            yOffset -= totalRowHeight;
            CreateDivider(yOffset + DIVIDER_MARGIN);

            CreateConfigRow("AutoPot", _config.AutoPotHealthThreshold.Value * 100 + "%", ref _autoPotThresholdInput, ref _autoPotValueText, yOffset);
            yOffset -= totalRowHeight;
            CreateDivider(yOffset + DIVIDER_MARGIN);

            CreateConfigRow("PotKey", _config.AutoPotKey.Value, ref _autoPotKeyInput, ref _potKeyValueText, yOffset);
            yOffset -= totalRowHeight;
            CreateDivider(yOffset + DIVIDER_MARGIN);

            CreateConfigRow("Toggle", _config.AutoPotToggleKey.Value, ref _autoPotToggleInput, ref _toggleValueText, yOffset);
            yOffset -= totalRowHeight;
            CreateDivider(yOffset + DIVIDER_MARGIN);

            CreateConfigRow("Nexus", _config.DisconnectKey.Value, ref _disconnectKeyInput, ref _nexusValueText, yOffset);
            yOffset -= totalRowHeight;
            CreateDivider(yOffset + DIVIDER_MARGIN);
        }

        private void CreateConfigRow(string label, string currentValue, ref TMP_InputField inputField, ref TextMeshProUGUI valueText, float yOffset)
        {
            GameObject row = new GameObject($"Row_{label}");
            row.transform.SetParent(_configPanel.transform, false);

            RectTransform rowRect = row.AddComponent<RectTransform>();
            rowRect.anchorMin = new Vector2(0, 1);
            rowRect.anchorMax = new Vector2(1, 1);
            rowRect.pivot = new Vector2(0.5f, 1);
            rowRect.anchoredPosition = new Vector2(0, yOffset);
            rowRect.sizeDelta = new Vector2(-20, ROW_HEIGHT);


            GameObject labelObj = new GameObject("Label");
            labelObj.transform.SetParent(row.transform, false);
            var labelText = labelObj.AddComponent<TextMeshProUGUI>();
            labelText.text = label + ":";
            labelText.fontSize = 12;
            labelText.color = LABEL_COLOR;
            labelText.alignment = TextAlignmentOptions.Left;

            RectTransform labelRect = labelText.rectTransform;
            labelRect.anchorMin = new Vector2(0, 0);
            labelRect.anchorMax = new Vector2(0.3f, 1);
            labelRect.pivot = new Vector2(0, 0.5f);
            labelRect.anchoredPosition = Vector2.zero;
            labelRect.sizeDelta = Vector2.zero;


            GameObject valueObj = new GameObject("Value");
            valueObj.transform.SetParent(row.transform, false);
            valueText = valueObj.AddComponent<TextMeshProUGUI>();
            valueText.text = currentValue;
            valueText.fontSize = 12;
            valueText.color = VALUE_COLOR;
            valueText.alignment = TextAlignmentOptions.Left;

            RectTransform valueRect = valueText.rectTransform;
            valueRect.anchorMin = new Vector2(0.3f, 0);
            valueRect.anchorMax = new Vector2(0.6f, 1);
            valueRect.pivot = new Vector2(0, 0.5f);
            valueRect.anchoredPosition = Vector2.zero;
            valueRect.sizeDelta = Vector2.zero;

            CreateInputField(row.transform, ref inputField, 0.6f, 0.95f);
        }

        private void CreateInputField(Transform parent, ref TMP_InputField inputField, float minX, float maxX)
        {
            GameObject inputObj = new GameObject("InputField");
            inputObj.transform.SetParent(parent, false);

            var bgImage = inputObj.AddComponent<Image>();
            bgImage.color = INPUT_BG_COLOR;

            inputField = inputObj.AddComponent<TMP_InputField>();
            
            GameObject textObj = new GameObject("Text");
            textObj.transform.SetParent(inputObj.transform, false);
            var inputText = textObj.AddComponent<TextMeshProUGUI>();
            inputText.fontSize = 12;
            inputText.color = VALUE_COLOR;
            inputText.alignment = TextAlignmentOptions.Left;

            RectTransform textRect = inputText.rectTransform;
            textRect.anchorMin = Vector2.zero;
            textRect.anchorMax = Vector2.one;
            textRect.sizeDelta = new Vector2(-10, -4);
            textRect.anchoredPosition = Vector2.zero;

            inputField.textComponent = inputText;
            inputField.targetGraphic = bgImage;
            inputField.textViewport = inputObj.GetComponent<RectTransform>();

            RectTransform inputRect = inputField.GetComponent<RectTransform>();
            inputRect.anchorMin = new Vector2(minX, 0);
            inputRect.anchorMax = new Vector2(maxX, 1);
            inputRect.pivot = new Vector2(0, 0.5f);
            inputRect.anchoredPosition = Vector2.zero;
            inputRect.sizeDelta = Vector2.zero;
        }

        private void CreateSaveButton()
        {
            GameObject buttonObj = new GameObject("SaveButton");
            buttonObj.transform.SetParent(_configPanel.transform, false);
            
            Button button = buttonObj.AddComponent<Button>();
            _saveButtonImage = buttonObj.AddComponent<Image>();
            _saveButtonImage.color = BUTTON_COLOR;
            
            GameObject textObj = new GameObject("Text");
            textObj.transform.SetParent(buttonObj.transform, false);
            _saveButtonText = textObj.AddComponent<TextMeshProUGUI>();
            _saveButtonText.text = "Save";
            _saveButtonText.fontSize = 14;
            _saveButtonText.color = Color.white;
            _saveButtonText.alignment = TextAlignmentOptions.Center;
            
            RectTransform buttonRect = button.GetComponent<RectTransform>();
            buttonRect.anchorMin = new Vector2(0.5f, 0);
            buttonRect.anchorMax = new Vector2(0.5f, 0);
            buttonRect.pivot = new Vector2(0.5f, 0);
            buttonRect.sizeDelta = new Vector2(SAVE_BUTTON_WIDTH, SAVE_BUTTON_HEIGHT);
            buttonRect.anchoredPosition = new Vector2(0, 15);
            
            RectTransform textRect = _saveButtonText.rectTransform;
            textRect.anchorMin = Vector2.zero;
            textRect.anchorMax = Vector2.one;
            textRect.sizeDelta = Vector2.zero;

            button.onClick.AddListener(DelegateSupport.ConvertDelegate<UnityAction>(() => SavePreferences()));
        }

        private void SavePreferences()
        {
            try
            {
                bool anyChanges = false;

                if (!string.IsNullOrEmpty(_healthThresholdInput.text) && 
                    float.TryParse(_healthThresholdInput.text, out float healthThreshold))
                {
                    float normalizedHealth = healthThreshold / 100f;
                    if (normalizedHealth >= 0.1f && normalizedHealth <= 0.9f)
                    {
                        _config.HealthThreshold.Value = normalizedHealth;
                        anyChanges = true;
                    }
                }

                if (!string.IsNullOrEmpty(_autoPotThresholdInput.text) &&
                    float.TryParse(_autoPotThresholdInput.text, out float autoPotThreshold))
                {
                    float normalizedAutoPot = autoPotThreshold / 100f;
                    if (normalizedAutoPot >= 0.1f && normalizedAutoPot <= 0.9f)
                    {
                        _config.AutoPotHealthThreshold.Value = normalizedAutoPot;
                        anyChanges = true;
                    }
                }

                if (!string.IsNullOrWhiteSpace(_autoPotKeyInput.text))
                {
                    _config.AutoPotKey.Value = _autoPotKeyInput.text;
                    anyChanges = true;
                }

                if (!string.IsNullOrWhiteSpace(_autoPotToggleInput.text))
                {
                    _config.AutoPotToggleKey.Value = _autoPotToggleInput.text;
                    anyChanges = true;
                }

                if (!string.IsNullOrWhiteSpace(_disconnectKeyInput.text))
                {
                    _config.DisconnectKey.Value = _disconnectKeyInput.text;
                    anyChanges = true;
                }

                ClearInputFields();

                if (anyChanges)
                {
                    MelonPreferences.Save();
                    ShowSaveSuccess();
                    UpdateCurrentValues();
                    _logger.Msg("Settings saved successfully!");
                }
                else
                {
                    ShowSaveWarning();
                }}
            catch (System.Exception e)
            {
                _logger.Error($"Error saving settings: {e.Message}");
                ShowSaveError();
            }
        }

        private void ShowSaveSuccess()
        {
            if (_saveButtonImage != null && _saveButtonText != null)
            {
                _saveButtonImage.color = SUCCESS_COLOR;
                _saveButtonText.text = "Saved!";
                MelonCoroutines.Start(ResetSaveButton());
            }
        }

        private void ShowSaveWarning()
        {
            if (_saveButtonImage != null && _saveButtonText != null)
            {
                _saveButtonImage.color = Color.yellow;
                _saveButtonText.text = "No Changes";
                MelonCoroutines.Start(ResetSaveButton());
            }
        }

        private void ShowSaveError()
        {
            if (_saveButtonImage != null && _saveButtonText != null)
            {
                _saveButtonImage.color = ERROR_COLOR;
                _saveButtonText.text = "Error!";
                MelonCoroutines.Start(ResetSaveButton());
            }
        }

        private IEnumerator ResetSaveButton()
        {
            yield return new WaitForSeconds(1.5f);
            
            if (_saveButtonImage != null && _saveButtonText != null)
            {
                _saveButtonImage.color = BUTTON_COLOR;
                _saveButtonText.text = "Save";
            }
        }

        private void UpdateCurrentValues()
        {
            if (_healthValueText != null)
                _healthValueText.text = (_config.HealthThreshold.Value * 100).ToString("F1") + "%";
            
            if (_autoPotValueText != null)
                _autoPotValueText.text = (_config.AutoPotHealthThreshold.Value * 100).ToString("F1") + "%";
            
            if (_potKeyValueText != null)
                _potKeyValueText.text = _config.AutoPotKey.Value;
            
            if (_toggleValueText != null)
                _toggleValueText.text = _config.AutoPotToggleKey.Value;
            
            if (_nexusValueText != null)
                _nexusValueText.text = _config.DisconnectKey.Value;
        }

        private void ClearInputFields()
        {
            if (_healthThresholdInput != null)
                _healthThresholdInput.text = "";
            if (_autoPotThresholdInput != null)
                _autoPotThresholdInput.text = "";
            if (_autoPotKeyInput != null)
                _autoPotKeyInput.text = "";
            if (_autoPotToggleInput != null)
                _autoPotToggleInput.text = "";
            if (_disconnectKeyInput != null)
                _disconnectKeyInput.text = "";
        }
    }
}