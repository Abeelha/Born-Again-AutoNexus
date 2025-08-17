## 🎮 Showcase Auto-nexus

**Click thumbnails below to watch demos:**

[![AutoNexus Demo 1](https://img.youtube.com/vi/M5oGhxLV4lQ/maxresdefault.jpg)](https://youtu.be/M5oGhxLV4lQ)
*Demo 1: AutoNexus in action*

[![AutoNexus Demo 2](https://img.youtube.com/vi/OQiG1MqEyps/maxresdefault.jpg)](https://youtu.be/OQiG1MqEyps)
*Demo 2: Features showcase*

# Installation Guide
## Prerequisites

### 1. Install .NET 6.0
Download and install .NET 6.0 from the official Microsoft website:
- **Download Link**: [.NET 6.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-6.0.428-windows-x64-installer)

### 2. Install MelonLoader
1. **Download MelonLoader Installer**: [Latest Release](https://github.com/LavaGang/MelonLoader.Installer/releases/latest/download/MelonLoader.Installer.exe)
2. Open `MelonLoader.exe`
3. Select **BornAgain** and press **Install**

## Installation Steps

### Step 1: Initial Game Setup
> ⚠️ **IMPORTANT**: After installing MelonLoader, run the game at least once before proceeding.

1. Launch the game
2. Close the game after it fully loads

### Step 2: Download and Install the DLL
## 📥 Download

### Latest Release: v1.0.0
- **[Download AutoNexus.dll](https://github.com/Abeelha/Born-Again-AutoNexus/releases/download/v1.0.0/AutoNexus.dll)** (50 KB)
- **[Download Sound Pack](https://github.com/Abeelha/Born-Again-AutoNexus/releases/download/v1.0.0/sounds-nexus-again.7z)** (209 KB)
- **[View All Releases](https://github.com/Abeelha/Born-Again-AutoNexus/releases)**
2. Navigate to your game's root folder: `\Steam\steamapps\common\Born Again\Mods`
3. Place the downloaded DLL file in the `Mods` folder

---

## Configuration

### AutoNexus Configuration
1. After running the game once, a config file will be created at:
   ```
   \Steam\steamapps\common\Born Again\UserData\MelonPreferences.cfg
   ```
2. Edit the file with **Notepad**
3. Modify the health value to set your desired AutoNexus trigger point
4. Other values can be adjusted, but it's recommended to keep default settings

---

## Audio Configuration

### Adding Custom Sounds for Toggle InstaNexus/AutoPot
1. Navigate to the `sounds` folder in your installation directory
2. Add your 4 audio files to this folder
3. **Important**: Rename your audio files to match the exact default filenames
4. You can use any audio format, just ensure the filenames are identical to the originals

---

## Troubleshooting

- Ensure .NET 6.0 is properly installed before proceeding
- Make sure to run the game at least once after MelonLoader installation
- Verify that the DLL is placed in the correct `Mods` folder
- Check that audio files are named exactly as specified


# Born Again Mod - Features & Updates

## 🎯 Core Features

### 🔄 AutoNexus System
- **Intelligent health monitoring** with predictive damage tracking
- **Dynamic threshold adjustment** based on damage patterns
- **Burst damage detection** for rapid health loss scenarios
- **Optimized response time** with improved game update timing
- **Configurable health percentage** for nexus trigger

### 💊 AutoPot System
- **Automatic potion consumption** when health drops below threshold
- **Predictive potion usage** to prevent death from burst damage
- **Potion effectiveness tracking** to optimize usage timing
- **Anti-panic potting** system to prevent unnecessary multiple potions
- **Toggle functionality** with customizable keybind (default: `Ctrl + H`)

### 🎮 User Interface
<img width="417" height="454" alt="image" src="https://github.com/user-attachments/assets/20258054-6189-4981-8d36-f7041e7ec124" />

- **In-game configuration UI** for easy settings adjustment
- **PRESS "INSERT" TO OPEN UI**
- **Toggle UI with Insert key** - no more manual config file editing
- **Real-time settings updates** without game restart

### 🔧 Quality of Life Features
- **Enhanced zoom functionality** using mouse scroll wheel
- **Roof removal system** - see through all building roofs
- **Anti-AFK protection** prevents idle kick
- **Custom name changer** for streaming/recording safety
- **Sound notifications** for toggle actions

## ⚙️ Recommended Settings

### Optimal Configuration
Based on extensive testing and damage analysis:

| Feature | Recommended Value | Health Range (490-560 HP) |
|---------|------------------|---------------------------|
| **AutoNexus** | 20% | 98-112 HP |
| **AutoPot** | 35% | 171-196 HP |

### Why These Settings?
- **20% Burst Threshold**: Triggers on 98-112 damage in 3 seconds
- **Faster Reaction Time**: More sensitive burst detection
- **15% Safety Gap**: Maintains buffer between pot and nexus thresholds
- **Burst Protection**: AutoNexus activates at 40% during heavy damage

## 🎵 Audio System

### Sound Notifications
- **Toggle sound effects** for AutoNexus/AutoPot activation
- **Custom audio support** - use any audio files
- **Easy installation** - place renamed files in `sounds` folder
- **4 sound slots** for different actions

## 🔧 Configuration

### UI Configuration (Recommended)
- Press **Insert** to open/close the configuration UI
- Real-time adjustment of all settings
- No game restart required

### Manual Configuration
Config file location: `\Steam\steamapps\common\Born Again\UserData\MelonPreferences.cfg`

**Important Settings:**
- `PlayerName`: Custom name for streaming safety
- `AutoNexusHealth`: Health percentage for nexus trigger
- `AutoPotHealth`: Health percentage for potion usage
- `PotionKey`: Keybind for drinking potions (default: "1")
- `ToggleAutoPot`: Keybind for toggling AutoPot (default: "Ctrl + H")
- `ZoomKey`: Keybind for enhanced zoom (default: mouse wheel)

## 🚀 Recent Improvements

### Performance Optimizations
- **Faster nexus response** with optimized config settings
- **Improved game update timing** for better AutoNexus performance
- **Enhanced zoom function** optimization

### Intelligence Upgrades
- **MaxHealth detection** now uses in-game values instead of calculations
- **Predictive damage tracking** for sustained damage situations
- **Dynamic threshold adjustment** based on health drop patterns
- **Burst damage protection** with conservative thresholds during rapid health loss

### User Experience
- **Streamlined configuration** with UI-based settings
- **Roof transparency** for better visibility
<img width="904" height="852" alt="image" src="https://github.com/user-attachments/assets/b40a2373-30d5-43cf-b3aa-01c2b03278ce" />

- **Anti-AFK system** for continuous gameplay
- **Custom naming** for content creation safety
<img width="499" height="132" alt="image" src="https://github.com/user-attachments/assets/c529bb55-ff01-4e44-92d6-f1669d6410e3" />


## 🎯 Usage Tips

1. **Delete old config files** when updating to ensure new features work properly
2. **Run the game once** after each update to generate new config files
3. **Customize keybinds** to match your playstyle
4. **Test settings** in safe areas before entering dangerous zones
5. **Use recommended thresholds** for optimal protection

## 🔊 Audio Setup

1. Navigate to the `sounds` folder
2. Add your 4 custom audio files
3. Rename files to match default naming convention
4. Restart the game to apply changes

---

*Last Updated: July 2025 | Status: Functional but no longer in active development*
