using ImGuiNET;
using MelonLoader;
using System.Collections.Generic;
using AutoNexus.Configuration;
using UnityEngine;
using Vector2 = System.Numerics.Vector2;

namespace AutoNexus.UI
{
    public class ModUI
    {
        private readonly ModConfig _config;
        private readonly List<string> _logMessages = new List<string>();
        private bool _showWindow = false;
        private readonly MelonLogger.Instance _logger;

        public ModUI(ModConfig config, MelonLogger.Instance logger)
        {
            _config = config;
            _logger = logger;
            
            var io = ImGui.GetIO();
            io.ConfigFlags |= ImGuiConfigFlags.DockingEnable;
            io.ConfigFlags |= ImGuiConfigFlags.ViewportsEnable;
            
        }

        public void OnGUI()
        {
            if (Input.GetKeyDown(KeyCode.Insert) || Input.GetKeyDown(KeyCode.F1))
                _showWindow = !_showWindow;

            if (!_showWindow) return;

            ImGui.SetNextWindowSize(new Vector2(500, 400), ImGuiCond.FirstUseEver);
            ImGui.Begin("AutoNexus Settings", ref _showWindow);

            if (ImGui.BeginTabBar("MainTabs"))
            {
                if (ImGui.BeginTabItem("Settings"))
                {
                    DrawSettings();
                    ImGui.EndTabItem();
                }

                if (ImGui.BeginTabItem("Logs"))
                {
                    DrawLogs();
                    ImGui.EndTabItem();
                }

                ImGui.EndTabBar();
            }

            ImGui.End();
        }

        private void DrawSettings()
        {
            if (ImGui.CollapsingHeader("Health Settings"))
            {
                float healthThreshold = _config.HealthThreshold.Value;
                if (ImGui.SliderFloat("Health Threshold", ref healthThreshold, 0.05f, 0.95f, "%.2f"))
                    _config.HealthThreshold.Value = healthThreshold;

                float autoPotThreshold = _config.AutoPotHealthThreshold.Value;
                if (ImGui.SliderFloat("AutoPot Threshold", ref autoPotThreshold, 0.05f, 0.95f, "%.2f"))
                    _config.AutoPotHealthThreshold.Value = autoPotThreshold;
            }

            if (ImGui.CollapsingHeader("Keybinds"))
            {
                string disconnectKey = _config.DisconnectKey.Value;
                if (ImGui.InputText("Disconnect Key", ref disconnectKey, 32))
                    _config.DisconnectKey.Value = disconnectKey;

                string autoPotKey = _config.AutoPotKey.Value;
                if (ImGui.InputText("AutoPot Key", ref autoPotKey, 32))
                    _config.AutoPotKey.Value = autoPotKey;

                string autoPotToggleKey = _config.AutoPotToggleKey.Value;
                if (ImGui.InputText("AutoPot Toggle", ref autoPotToggleKey, 32))
                    _config.AutoPotToggleKey.Value = autoPotToggleKey;
            }

            if (ImGui.CollapsingHeader("Camera"))
            {
                string zoomInKey = _config.ZoomInKey.Value;
                if (ImGui.InputText("Zoom In", ref zoomInKey, 32))
                    _config.ZoomInKey.Value = zoomInKey;

                string zoomOutKey = _config.ZoomOutKey.Value;
                if (ImGui.InputText("Zoom Out", ref zoomOutKey, 32))
                    _config.ZoomOutKey.Value = zoomOutKey;
            }

            if (ImGui.CollapsingHeader("Player"))
            {
                string playerName = _config.PlayerName.Value;
                if (ImGui.InputText("Name", ref playerName, 32))
                    _config.PlayerName.Value = playerName;
            }
        }

        private void DrawLogs()
        {
            if (ImGui.Button("Clear"))
                _logMessages.Clear();

            ImGui.BeginChild("ScrollingRegion", new Vector2(0, 0), ImGuiChildFlags.None);
            foreach (var log in _logMessages)
            {
                ImGui.TextUnformatted(log);
            }
            if (_logMessages.Count > 0)
                ImGui.SetScrollHereY(1.0f);
            ImGui.EndChild();
        }

        private void AddLog(string message)
        {
            _logMessages.Add(message);
            if (_logMessages.Count > 1000)
                _logMessages.RemoveAt(0);
            _logger.Msg(message);
        }
    }
}