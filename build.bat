@echo off
echo ================================
echo    Building AutoNexus Mod
echo ================================
echo.

echo Cleaning previous build...
dotnet clean
echo.

echo Building project...
dotnet build
echo.

if %errorlevel% equ 0 (
    echo ================================
    echo       BUILD SUCCESSFUL!
    echo ================================
    echo.
    echo Copying DLL to game folder...
    
    if exist "bin\Debug\net6.0\AutoNexus.dll" (
        copy "bin\Debug\net6.0\AutoNexus.dll" "C:\Program Files (x86)\Steam\steamapps\common\Born Again\Mods\" >nul
        if %errorlevel% equ 0 (
            echo ✓ DLL successfully copied to game Mods folder
        ) else (
            echo ⚠ Failed to copy DLL - check if game is running or permissions
        )
    ) else (
        echo ⚠ AutoNexus.dll not found in build output
    )
    
    echo.
    echo Ready to test in game!
) else (
    echo ================================
    echo        BUILD FAILED!
    echo ================================
    echo Check the error messages above.
)

echo.
echo Press any key to exit...
pause >nul