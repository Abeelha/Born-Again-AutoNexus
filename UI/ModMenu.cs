using AutoNexus.Configuration;
using Il2CppInterop.Runtime;
using MelonLoader;
using UnityEngine;
using Il2CppTMPro;
using UnityEngine.Events;
using UnityEngine.UI;
using System.Collections;
using AutoNexus.Features;
using UnityEngine.UI;
using AutoNexus.Helpers;

namespace AutoNexus.UI
{
    public class ConfigDisplay
    {
        private const float PANEL_WIDTH = 200f;
        private const float PANEL_HEIGHT = 250f;
        private const float DESIRED_SCALE = 0.5f;
        
        private const float ROW_HEIGHT = 25f;
        private const float ROW_PADDING = 4f;
        private const float HEADER_HEIGHT = 20f;
        private const float SAVE_BUTTON_HEIGHT = 20f;
        private const float SAVE_BUTTON_WIDTH = 60f;
        private const float DIVIDER_MARGIN = 1.5f;
        
        private const float INPUT_FIELD_WIDTH = 10f;

        // Colors
        private readonly Color PANEL_COLOR = new Color(0.196f, 0.251f, 0.282f, 0.95f); 
        private readonly Color LABEL_COLOR = new Color(0.863f, 0.365f, 0.322f, 1f);
        private readonly Color VALUE_COLOR = new Color(0.250f, 0.600f, 0.700f, 1f);
        private readonly Color INPUT_BG_COLOR = new Color(0.322f, 0.376f, 0.412f, 1f);
        private readonly Color BUTTON_COLOR = new Color(0.686f, 0.231f, 0.365f, 1f);
        private readonly Color DIVIDER_COLOR = new Color(0.443f, 0.443f, 0.443f, 0.5f);
        private readonly Color SUCCESS_COLOR = new Color(0.298f, 0.686f, 0.314f, 1f);
        private readonly Color ERROR_COLOR = new Color(0.914f, 0.176f, 0.235f, 1f);

        // Configuration and Logging
        private readonly ModConfig _config;
        private readonly MelonLogger.Instance _logger;
        private readonly NameChanger _nameChanger;

        // UI Components
        private GameObject _configPanel;
        private bool _isVisible = true;
        private bool _isInitialized = false;
        private Canvas _mainCanvas;

        // Input Fields
        private TMP_InputField _healthThresholdInput;
        private TMP_InputField _autoPotThresholdInput;
        private TMP_InputField _autoPotKeyInput;
        private TMP_InputField _autoPotToggleInput;
        private TMP_InputField _disconnectKeyInput;

        // Text Components
        private TextMeshProUGUI _healthValueText;
        private TextMeshProUGUI _autoPotValueText;
        private TextMeshProUGUI _potKeyValueText;
        private TextMeshProUGUI _toggleValueText;
        private TextMeshProUGUI _nexusValueText;
        private TMP_InputField _playerNameInput;
        private TextMeshProUGUI _playerNameValueText;
        
        // Save Button Components
        private Image _saveButtonImage;
        private TextMeshProUGUI _saveButtonText;

        private Vector3 _originalScale;
        private Vector2 _originalSize;
        
        public ConfigDisplay(ModConfig config, MelonLogger.Instance logger, NameChanger nameChanger)
        {
            _config = config;
            _logger = logger;
            _nameChanger = nameChanger;
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
            
            CreateConfigRow("Player Name", _config.PlayerName.Value, ref _playerNameInput, ref _playerNameValueText, yOffset);
            yOffset -= totalRowHeight;
            CreateDivider(yOffset + DIVIDER_MARGIN);
    
            CreateConfigRow("Nexus", _config.DisconnectKey.Value, ref _disconnectKeyInput, ref _nexusValueText, yOffset);
            yOffset -= totalRowHeight;
            CreateDivider(yOffset + DIVIDER_MARGIN);
            
            CreateConfigRow("On/OFF AutoPot", _config.AutoPotToggleKey.Value, ref _autoPotToggleInput, ref _toggleValueText, yOffset);
            yOffset -= totalRowHeight;
            CreateDivider(yOffset + DIVIDER_MARGIN);

            CreateConfigRow("Pot Key", _config.AutoPotKey.Value, ref _autoPotKeyInput, ref _potKeyValueText, yOffset);
            yOffset -= totalRowHeight;
            CreateDivider(yOffset + DIVIDER_MARGIN);
            
            CreateConfigRow("AutoNexus%", _config.HealthThreshold.Value * 100 + "%", ref _healthThresholdInput, ref _healthValueText, yOffset);
            yOffset -= totalRowHeight;
            CreateDivider(yOffset + DIVIDER_MARGIN);

            CreateConfigRow("AutoPot%", _config.AutoPotHealthThreshold.Value * 100 + "%", ref _autoPotThresholdInput, ref _autoPotValueText, yOffset);
            yOffset -= totalRowHeight;
            CreateDivider(yOffset + DIVIDER_MARGIN);


        }

        private void CreateConfigRow(string label, string currentValue, ref TMP_InputField inputField,
            ref TextMeshProUGUI valueText, float yOffset)
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
            labelRect.anchorMax = new Vector2(0.5f, 1);
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
            valueRect.anchorMin = new Vector2(0.5f, 0);
            valueRect.anchorMax = new Vector2(0.7f, 1);
            valueRect.pivot = new Vector2(0, 0.5f);
            valueRect.anchoredPosition = Vector2.zero;
            valueRect.sizeDelta = Vector2.zero;

            CreateInputField(row.transform, ref inputField, 0.7f, 0.95f);
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
            inputText.alignment = TextAlignmentOptions.Center;

            RectTransform textRect = inputText.rectTransform;
            textRect.anchorMin = Vector2.zero;
            textRect.anchorMax = Vector2.one;
            textRect.sizeDelta = new Vector2(-10, -4);
            textRect.anchoredPosition = Vector2.zero;

            inputField.textComponent = inputText;
            inputField.targetGraphic = bgImage;
            inputField.textViewport = inputObj.GetComponent<RectTransform>();
            
            RectTransform inputRect = inputField.GetComponent<RectTransform>();
            inputRect.anchorMin = new Vector2(minX, 0.2f);
            inputRect.anchorMax = new Vector2(maxX, 0.8f);
            inputRect.pivot = new Vector2(0, 0.5f);
            inputRect.anchoredPosition = Vector2.zero;
            inputRect.sizeDelta = new Vector2(INPUT_FIELD_WIDTH, -4);

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

                // NEXA COM QUANTOS MEU NOBRO
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

                // NAO TEM DEDO PRA TOMAR POT EM QUANTO DE HP NEGO?
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

                // AutoPot Key
                if (!string.IsNullOrWhiteSpace(_autoPotKeyInput.text))
                {
                    string potKey = KeyInputHelper.SanitizeKeyInput(_autoPotKeyInput.text);
                    if (!string.IsNullOrEmpty(potKey))
                    {
                        _config.AutoPotKey.Value = potKey;
                        anyChanges = true;
                    }
                }

                // AutoPot Toggle Key
                if (!string.IsNullOrWhiteSpace(_autoPotToggleInput.text))
                {
                    string toggleKey = KeyInputHelper.SanitizeKeyInput(_autoPotToggleInput.text);
                    if (!string.IsNullOrEmpty(toggleKey))
                    {
                        _config.AutoPotToggleKey.Value = toggleKey;
                        anyChanges = true;
                    }
                }

                // nEXUS Key
                if (!string.IsNullOrWhiteSpace(_disconnectKeyInput.text))
                {
                    string disconnectKey = KeyInputHelper.SanitizeKeyInput(_disconnectKeyInput.text);
                    if (!string.IsNullOrEmpty(disconnectKey))
                    {
                        _config.DisconnectKey.Value = disconnectKey;
                        anyChanges = true;
                    }
                }
                
                // Player Name
                if (!string.IsNullOrWhiteSpace(_playerNameInput.text))
                {
                    string playerName = _playerNameInput.text.Trim();
                    if (!string.IsNullOrEmpty(playerName))
                    {
                        _config.PlayerName.Value = playerName;
                        anyChanges = true;

                        _nameChanger?.ForceNameUpdate();
                    }
                }

                if (anyChanges)
                {
                    MelonPreferences.Save();
                    ShowSaveSuccess();
                    UpdateCurrentValues();
                    ClearInputFields();
                    _logger.Msg("Settings saved successfully!");
                }
                else
                {
                    ShowSaveWarning();
                }
            }
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
            
            if (_playerNameValueText != null)
                _playerNameValueText.text = _config.PlayerName.Value;
        }
        
        private void ClearInputFields()
        {
            _healthThresholdInput.text = "";
            _autoPotThresholdInput.text = "";
            _autoPotKeyInput.text = "";
            _autoPotToggleInput.text = "";
            _disconnectKeyInput.text = "";
            _playerNameInput.text = "";
        }
    }
}