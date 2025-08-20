using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x02000006 RID: 6
[Token(Token = "0x2000006")]
public class FlexibleColorPicker : MonoBehaviour
{
	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000010 RID: 16 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x17000001")]
	private FlexibleColorPicker.AdvancedSettings avs
	{
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x327A40", Offset = "0x326C40", VA = "0x180327A40")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000002 RID: 2
	// (get) Token: 0x06000011 RID: 17 RVA: 0x00002088 File Offset: 0x00000288
	// (set) Token: 0x06000012 RID: 18 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000002")]
	public Color color
	{
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x323080", Offset = "0x322280", VA = "0x180323080")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x327A50", Offset = "0x326C50", VA = "0x180327A50")]
		set
		{
		}
	}

	// Token: 0x06000013 RID: 19 RVA: 0x000020A0 File Offset: 0x000002A0
	[Token(Token = "0x6000013")]
	[Address(RVA = "0x323080", Offset = "0x322280", VA = "0x180323080")]
	public Color GetColor()
	{
		return default(Color);
	}

	// Token: 0x06000014 RID: 20 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000014")]
	[Address(RVA = "0x326380", Offset = "0x325580", VA = "0x180326380")]
	public void SetColor(Color color)
	{
	}

	// Token: 0x06000015 RID: 21 RVA: 0x000020B8 File Offset: 0x000002B8
	[Token(Token = "0x6000015")]
	[Address(RVA = "0x323040", Offset = "0x322240", VA = "0x180323040")]
	public Color GetColorFullAlpha()
	{
		return default(Color);
	}

	// Token: 0x06000016 RID: 22 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000016")]
	[Address(RVA = "0x326330", Offset = "0x325530", VA = "0x180326330")]
	public void SetColorNoAlpha(Color color)
	{
	}

	// Token: 0x06000017 RID: 23 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000017")]
	[Address(RVA = "0x322F70", Offset = "0x322170", VA = "0x180322F70")]
	private void Awake()
	{
	}

	// Token: 0x06000018 RID: 24 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000018")]
	[Address(RVA = "0x324D60", Offset = "0x323F60", VA = "0x180324D60")]
	private void OnEnable()
	{
	}

	// Token: 0x06000019 RID: 25 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000019")]
	[Address(RVA = "0x327980", Offset = "0x326B80", VA = "0x180327980")]
	private void Update()
	{
	}

	// Token: 0x0600001A RID: 26 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001A")]
	[Address(RVA = "0x326650", Offset = "0x325850", VA = "0x180326650")]
	public void SetPointerFocus(int i)
	{
	}

	// Token: 0x0600001B RID: 27 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001B")]
	[Address(RVA = "0x325BF0", Offset = "0x324DF0", VA = "0x180325BF0")]
	public void PointerUpdate(BaseEventData e)
	{
	}

	// Token: 0x0600001C RID: 28 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001C")]
	[Address(RVA = "0x326B60", Offset = "0x325D60", VA = "0x180326B60")]
	public void TypeHex(string input)
	{
	}

	// Token: 0x0600001D RID: 29 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001D")]
	[Address(RVA = "0x323010", Offset = "0x322210", VA = "0x180323010")]
	public void FinishTypeHex(string input)
	{
	}

	// Token: 0x0600001E RID: 30 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001E")]
	[Address(RVA = "0x322FC0", Offset = "0x3221C0", VA = "0x180322FC0")]
	public void ChangeMode(int newMode)
	{
	}

	// Token: 0x0600001F RID: 31 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001F")]
	[Address(RVA = "0x322FC0", Offset = "0x3221C0", VA = "0x180322FC0")]
	public void ChangeMode(FlexibleColorPicker.MainPickingMode mode)
	{
	}

	// Token: 0x06000020 RID: 32 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000020")]
	[Address(RVA = "0x326140", Offset = "0x325340", VA = "0x180326140")]
	private void SeperateMaterials()
	{
	}

	// Token: 0x06000021 RID: 33 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000021")]
	[Address(RVA = "0x326780", Offset = "0x325980", VA = "0x180326780")]
	public void ShiftColor(int type, float delta)
	{
	}

	// Token: 0x06000022 RID: 34 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000022")]
	[Address(RVA = "0x326860", Offset = "0x325A60", VA = "0x180326860")]
	public void ShiftHue(float delta)
	{
	}

	// Token: 0x06000023 RID: 35 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000023")]
	[Address(RVA = "0x325A00", Offset = "0x324C00", VA = "0x180325A00")]
	private FlexibleColorPicker.BufferedColor PickColor(FlexibleColorPicker.BufferedColor color, FlexibleColorPicker.PickerType type, Vector2 v)
	{
		return null;
	}

	// Token: 0x06000024 RID: 36 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000024")]
	[Address(RVA = "0x3258B0", Offset = "0x324AB0", VA = "0x1803258B0")]
	private FlexibleColorPicker.BufferedColor PickColorMain(FlexibleColorPicker.BufferedColor color, Vector2 v)
	{
		return null;
	}

	// Token: 0x06000025 RID: 37 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000025")]
	[Address(RVA = "0x325670", Offset = "0x324870", VA = "0x180325670")]
	private FlexibleColorPicker.BufferedColor PickColor1D(FlexibleColorPicker.BufferedColor color, FlexibleColorPicker.PickerType type, Vector2 v)
	{
		return null;
	}

	// Token: 0x06000026 RID: 38 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000026")]
	[Address(RVA = "0x325760", Offset = "0x324960", VA = "0x180325760")]
	private FlexibleColorPicker.BufferedColor PickColorMain(FlexibleColorPicker.BufferedColor color, FlexibleColorPicker.MainPickingMode mode, Vector2 v)
	{
		return null;
	}

	// Token: 0x06000027 RID: 39 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000027")]
	[Address(RVA = "0x325720", Offset = "0x324920", VA = "0x180325720")]
	private FlexibleColorPicker.BufferedColor PickColor2D(FlexibleColorPicker.BufferedColor color, FlexibleColorPicker.PickerType type1, float value1, FlexibleColorPicker.PickerType type2, float value2)
	{
		return null;
	}

	// Token: 0x06000028 RID: 40 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000028")]
	[Address(RVA = "0x324F50", Offset = "0x324150", VA = "0x180324F50")]
	private FlexibleColorPicker.BufferedColor PickColor1D(FlexibleColorPicker.BufferedColor color, FlexibleColorPicker.PickerType type, float value)
	{
		return null;
	}

	// Token: 0x06000029 RID: 41 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000029")]
	[Address(RVA = "0x3272D0", Offset = "0x3264D0", VA = "0x1803272D0")]
	private void UpdateMarkers()
	{
	}

	// Token: 0x0600002A RID: 42 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600002A")]
	[Address(RVA = "0x327210", Offset = "0x326410", VA = "0x180327210")]
	private void UpdateMarker(FlexibleColorPicker.Picker picker, FlexibleColorPicker.PickerType type, Vector2 v)
	{
	}

	// Token: 0x0600002B RID: 43 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600002B")]
	[Address(RVA = "0x3263A0", Offset = "0x3255A0", VA = "0x1803263A0")]
	private void SetMarker(Image picker, Vector2 v, bool setX, bool setY)
	{
	}

	// Token: 0x0600002C RID: 44 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600002C")]
	[Address(RVA = "0x323140", Offset = "0x322340", VA = "0x180323140")]
	private RectTransform GetMarker(Image picker, string search)
	{
		return null;
	}

	// Token: 0x0600002D RID: 45 RVA: 0x000020D0 File Offset: 0x000002D0
	[Token(Token = "0x600002D")]
	[Address(RVA = "0x3240E0", Offset = "0x3232E0", VA = "0x1803240E0")]
	private Vector2 GetValue(FlexibleColorPicker.PickerType type)
	{
		return default(Vector2);
	}

	// Token: 0x0600002E RID: 46 RVA: 0x000020E8 File Offset: 0x000002E8
	[Token(Token = "0x600002E")]
	[Address(RVA = "0x323EA0", Offset = "0x3230A0", VA = "0x180323EA0")]
	private float GetValue1D(FlexibleColorPicker.PickerType type)
	{
		return 0f;
	}

	// Token: 0x0600002F RID: 47 RVA: 0x00002100 File Offset: 0x00000300
	[Token(Token = "0x600002F")]
	[Address(RVA = "0x324160", Offset = "0x323360", VA = "0x180324160")]
	private Vector2 GetValue(FlexibleColorPicker.MainPickingMode mode)
	{
		return default(Vector2);
	}

	// Token: 0x06000030 RID: 48 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000030")]
	[Address(RVA = "0x3276A0", Offset = "0x3268A0", VA = "0x1803276A0")]
	private void UpdateTextures()
	{
	}

	// Token: 0x06000031 RID: 49 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000031")]
	[Address(RVA = "0x327450", Offset = "0x326650", VA = "0x180327450")]
	private void UpdateStatic(FlexibleColorPicker.PickerType type)
	{
	}

	// Token: 0x06000032 RID: 50 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000032")]
	[Address(RVA = "0x326B90", Offset = "0x325D90", VA = "0x180326B90")]
	private void UpdateDynamic(FlexibleColorPicker.PickerType type)
	{
	}

	// Token: 0x06000033 RID: 51 RVA: 0x00002118 File Offset: 0x00000318
	[Token(Token = "0x6000033")]
	[Address(RVA = "0x3230B0", Offset = "0x3222B0", VA = "0x1803230B0")]
	private int GetGradientMode(FlexibleColorPicker.PickerType type)
	{
		return 0;
	}

	// Token: 0x06000034 RID: 52 RVA: 0x00002130 File Offset: 0x00000330
	[Token(Token = "0x6000034")]
	[Address(RVA = "0x3247F0", Offset = "0x3239F0", VA = "0x1803247F0")]
	private bool IsPickerAvailable(FlexibleColorPicker.PickerType type)
	{
		return default(bool);
	}

	// Token: 0x06000035 RID: 53 RVA: 0x00002148 File Offset: 0x00000348
	[Token(Token = "0x6000035")]
	[Address(RVA = "0x324800", Offset = "0x323A00", VA = "0x180324800")]
	private bool IsPickerAvailable(int index)
	{
		return default(bool);
	}

	// Token: 0x06000036 RID: 54 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000036")]
	[Address(RVA = "0x327120", Offset = "0x326320", VA = "0x180327120")]
	private void UpdateHex()
	{
	}

	// Token: 0x06000037 RID: 55 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000037")]
	[Address(RVA = "0x326980", Offset = "0x325B80", VA = "0x180326980")]
	private void TypeHex(string input, bool finish)
	{
	}

	// Token: 0x06000038 RID: 56 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000038")]
	[Address(RVA = "0x324950", Offset = "0x323B50", VA = "0x180324950")]
	private void MakeModeOptions()
	{
	}

	// Token: 0x06000039 RID: 57 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000039")]
	[Address(RVA = "0x3273A0", Offset = "0x3265A0", VA = "0x1803273A0")]
	private void UpdateMode(FlexibleColorPicker.MainPickingMode mode)
	{
	}

	// Token: 0x0600003A RID: 58 RVA: 0x00002160 File Offset: 0x00000360
	[Token(Token = "0x600003A")]
	[Address(RVA = "0x3248E0", Offset = "0x323AE0", VA = "0x1803248E0")]
	private static bool IsPreviewType(FlexibleColorPicker.PickerType type)
	{
		return default(bool);
	}

	// Token: 0x0600003B RID: 59 RVA: 0x00002178 File Offset: 0x00000378
	[Token(Token = "0x600003B")]
	[Address(RVA = "0x324790", Offset = "0x323990", VA = "0x180324790")]
	private static bool IsAlphaType(FlexibleColorPicker.PickerType type)
	{
		return default(bool);
	}

	// Token: 0x0600003C RID: 60 RVA: 0x00002190 File Offset: 0x00000390
	[Token(Token = "0x600003C")]
	[Address(RVA = "0x3247A0", Offset = "0x3239A0", VA = "0x1803247A0")]
	private static bool IsHorizontal(FlexibleColorPicker.Picker p)
	{
		return default(bool);
	}

	// Token: 0x0600003D RID: 61 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600003D")]
	[Address(RVA = "0x323C10", Offset = "0x322E10", VA = "0x180323C10")]
	public static string GetSanitizedHex(string input, bool full)
	{
		return null;
	}

	// Token: 0x0600003E RID: 62 RVA: 0x000021A8 File Offset: 0x000003A8
	[Token(Token = "0x600003E")]
	[Address(RVA = "0x3248F0", Offset = "0x323AF0", VA = "0x1803248F0")]
	private static bool IsValidHexChar(char c)
	{
		return default(bool);
	}

	// Token: 0x0600003F RID: 63 RVA: 0x000021C0 File Offset: 0x000003C0
	[Token(Token = "0x600003F")]
	[Address(RVA = "0x324E80", Offset = "0x324080", VA = "0x180324E80")]
	public static Color ParseHex(string input)
	{
		return default(Color);
	}

	// Token: 0x06000040 RID: 64 RVA: 0x000021D8 File Offset: 0x000003D8
	[Token(Token = "0x6000040")]
	[Address(RVA = "0x324EE0", Offset = "0x3240E0", VA = "0x180324EE0")]
	public static Color ParseHex(string input, Color defaultColor)
	{
		return default(Color);
	}

	// Token: 0x06000041 RID: 65 RVA: 0x000021F0 File Offset: 0x000003F0
	[Token(Token = "0x6000041")]
	[Address(RVA = "0x323A60", Offset = "0x322C60", VA = "0x180323A60")]
	private static Vector2 GetNormalizedPointerPosition(Canvas canvas, RectTransform rect, BaseEventData e)
	{
		return default(Vector2);
	}

	// Token: 0x06000042 RID: 66 RVA: 0x00002208 File Offset: 0x00000408
	[Token(Token = "0x6000042")]
	[Address(RVA = "0x323290", Offset = "0x322490", VA = "0x180323290")]
	private static Vector2 GetNormScreenSpace(RectTransform rect, BaseEventData e)
	{
		return default(Vector2);
	}

	// Token: 0x06000043 RID: 67 RVA: 0x00002220 File Offset: 0x00000420
	[Token(Token = "0x6000043")]
	[Address(RVA = "0x3234B0", Offset = "0x3226B0", VA = "0x1803234B0")]
	private static Vector2 GetNormWorldSpace(Canvas canvas, RectTransform rect, BaseEventData e)
	{
		return default(Vector2);
	}

	// Token: 0x06000044 RID: 68 RVA: 0x00002238 File Offset: 0x00000438
	[Token(Token = "0x6000044")]
	[Address(RVA = "0x324590", Offset = "0x323790", VA = "0x180324590")]
	public static Color HSVToRGB(Vector3 hsv)
	{
		return default(Color);
	}

	// Token: 0x06000045 RID: 69 RVA: 0x00002250 File Offset: 0x00000450
	[Token(Token = "0x6000045")]
	[Address(RVA = "0x3245D0", Offset = "0x3237D0", VA = "0x1803245D0")]
	public static Color HSVToRGB(float h, float s, float v)
	{
		return default(Color);
	}

	// Token: 0x06000046 RID: 70 RVA: 0x00002268 File Offset: 0x00000468
	[Token(Token = "0x6000046")]
	[Address(RVA = "0x3260F0", Offset = "0x3252F0", VA = "0x1803260F0")]
	public static Vector3 RGBToHSV(Color color)
	{
		return default(Vector3);
	}

	// Token: 0x06000047 RID: 71 RVA: 0x00002280 File Offset: 0x00000480
	[Token(Token = "0x6000047")]
	[Address(RVA = "0x325E40", Offset = "0x325040", VA = "0x180325E40")]
	public static Vector3 RGBToHSV(float r, float g, float b)
	{
		return default(Vector3);
	}

	// Token: 0x06000048 RID: 72 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000048")]
	[Address(RVA = "0x327A20", Offset = "0x326C20", VA = "0x180327A20")]
	public FlexibleColorPicker()
	{
	}

	// Token: 0x04000015 RID: 21
	[Token(Token = "0x4000015")]
	[FieldOffset(Offset = "0x20")]
	[Tooltip("Connections to the FCP's picker images, this should not be adjusted unless in advanced use cases.")]
	[SerializeField]
	private FlexibleColorPicker.Picker[] pickers;

	// Token: 0x04000016 RID: 22
	[Token(Token = "0x4000016")]
	[FieldOffset(Offset = "0x28")]
	[Tooltip("Connection to the FCP's hexadecimal input field.")]
	[SerializeField]
	private TMP_InputField hexInput;

	// Token: 0x04000017 RID: 23
	[Token(Token = "0x4000017")]
	[FieldOffset(Offset = "0x30")]
	[Tooltip("Connection to the FCP's mode dropdown menu.")]
	[SerializeField]
	private TMP_Dropdown modeDropdown;

	// Token: 0x04000018 RID: 24
	[Token(Token = "0x4000018")]
	[FieldOffset(Offset = "0x38")]
	private Canvas canvas;

	// Token: 0x04000019 RID: 25
	[Token(Token = "0x4000019")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Tooltip("The (starting) 2D picking mode, i.e. the 2 color values that can be picked with the large square picker.")]
	private FlexibleColorPicker.MainPickingMode mode;

	// Token: 0x0400001A RID: 26
	[Token(Token = "0x400001A")]
	[FieldOffset(Offset = "0x48")]
	[Tooltip("Sprites to be used in static mode on the main picker, one for each 2D mode.")]
	[SerializeField]
	private Sprite[] staticSpriteMain;

	// Token: 0x0400001B RID: 27
	[Token(Token = "0x400001B")]
	[FieldOffset(Offset = "0x50")]
	private FlexibleColorPicker.BufferedColor bufferedColor;

	// Token: 0x0400001C RID: 28
	[Token(Token = "0x400001C")]
	[FieldOffset(Offset = "0x58")]
	private FlexibleColorPicker.Picker focusedPicker;

	// Token: 0x0400001D RID: 29
	[Token(Token = "0x400001D")]
	[FieldOffset(Offset = "0x80")]
	private FlexibleColorPicker.PickerType focusedPickerType;

	// Token: 0x0400001E RID: 30
	[Token(Token = "0x400001E")]
	[FieldOffset(Offset = "0x84")]
	private FlexibleColorPicker.MainPickingMode lastUpdatedMode;

	// Token: 0x0400001F RID: 31
	[Token(Token = "0x400001F")]
	[FieldOffset(Offset = "0x88")]
	private bool typeUpdate;

	// Token: 0x04000020 RID: 32
	[Token(Token = "0x4000020")]
	[FieldOffset(Offset = "0x89")]
	private bool triggeredStaticMode;

	// Token: 0x04000021 RID: 33
	[Token(Token = "0x4000021")]
	[FieldOffset(Offset = "0x8A")]
	private bool materialsSeperated;

	// Token: 0x04000022 RID: 34
	[Token(Token = "0x4000022")]
	[FieldOffset(Offset = "0x8C")]
	[SerializeField]
	[Tooltip("Color set to the color picker on Start(). If you wish to set a starting color via script please used the standard color parameter of the FCP in stead.")]
	private Color startingColor;

	// Token: 0x04000023 RID: 35
	[Token(Token = "0x4000023")]
	[FieldOffset(Offset = "0x9C")]
	[Tooltip("Use static mode: picker images are replaced by static images in stead of adaptive Unity shaders.")]
	public bool staticMode;

	// Token: 0x04000024 RID: 36
	[Token(Token = "0x4000024")]
	[FieldOffset(Offset = "0x9D")]
	[Tooltip("Make sure FCP seperates its picker materials so that the dynamic mode works consistently, even when multiple FPCs are active at the same time. Turning this off yields a slight performance boost.")]
	public bool multiInstance;

	// Token: 0x04000025 RID: 37
	[Token(Token = "0x4000025")]
	[FieldOffset(Offset = "0xA0")]
	public FlexibleColorPicker.ColorUpdateEvent onColorChange;

	// Token: 0x04000026 RID: 38
	[Token(Token = "0x4000026")]
	private const float HUE_LOOP = 5.9999f;

	// Token: 0x04000027 RID: 39
	[Token(Token = "0x4000027")]
	private const string SHADER_MODE = "_Mode";

	// Token: 0x04000028 RID: 40
	[Token(Token = "0x4000028")]
	private const string SHADER_C1 = "_Color1";

	// Token: 0x04000029 RID: 41
	[Token(Token = "0x4000029")]
	private const string SHADER_C2 = "_Color2";

	// Token: 0x0400002A RID: 42
	[Token(Token = "0x400002A")]
	private const string SHADER_DOUBLE_MODE = "_DoubleMode";

	// Token: 0x0400002B RID: 43
	[Token(Token = "0x400002B")]
	private const string SHADER_HSV = "_HSV";

	// Token: 0x0400002C RID: 44
	[Token(Token = "0x400002C")]
	private const string SHADER_HSV_MIN = "_HSV_MIN";

	// Token: 0x0400002D RID: 45
	[Token(Token = "0x400002D")]
	private const string SHADER_HSV_MAX = "_HSV_MAX";

	// Token: 0x0400002E RID: 46
	[Token(Token = "0x400002E")]
	[FieldOffset(Offset = "0xA8")]
	[Tooltip("More specific settings for color picker. Changes are not applied immediately, but require an FCP update to trigger.")]
	public FlexibleColorPicker.AdvancedSettings advancedSettings;

	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	[Serializable]
	private struct Picker
	{
		// Token: 0x0400002F RID: 47
		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x0")]
		public Image image;

		// Token: 0x04000030 RID: 48
		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x8")]
		public Sprite dynamicSprite;

		// Token: 0x04000031 RID: 49
		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x10")]
		public Sprite staticSpriteHor;

		// Token: 0x04000032 RID: 50
		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x18")]
		public Sprite staticSpriteVer;

		// Token: 0x04000033 RID: 51
		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x20")]
		public Material dynamicMaterial;
	}

	// Token: 0x02000008 RID: 8
	[Token(Token = "0x2000008")]
	private enum PickerType
	{
		// Token: 0x04000035 RID: 53
		[Token(Token = "0x4000035")]
		Main,
		// Token: 0x04000036 RID: 54
		[Token(Token = "0x4000036")]
		R,
		// Token: 0x04000037 RID: 55
		[Token(Token = "0x4000037")]
		G,
		// Token: 0x04000038 RID: 56
		[Token(Token = "0x4000038")]
		B,
		// Token: 0x04000039 RID: 57
		[Token(Token = "0x4000039")]
		H,
		// Token: 0x0400003A RID: 58
		[Token(Token = "0x400003A")]
		S,
		// Token: 0x0400003B RID: 59
		[Token(Token = "0x400003B")]
		V,
		// Token: 0x0400003C RID: 60
		[Token(Token = "0x400003C")]
		A,
		// Token: 0x0400003D RID: 61
		[Token(Token = "0x400003D")]
		Preview,
		// Token: 0x0400003E RID: 62
		[Token(Token = "0x400003E")]
		PreviewAlpha
	}

	// Token: 0x02000009 RID: 9
	[Token(Token = "0x2000009")]
	public enum MainPickingMode
	{
		// Token: 0x04000040 RID: 64
		[Token(Token = "0x4000040")]
		HS,
		// Token: 0x04000041 RID: 65
		[Token(Token = "0x4000041")]
		HV,
		// Token: 0x04000042 RID: 66
		[Token(Token = "0x4000042")]
		SH,
		// Token: 0x04000043 RID: 67
		[Token(Token = "0x4000043")]
		SV,
		// Token: 0x04000044 RID: 68
		[Token(Token = "0x4000044")]
		VH,
		// Token: 0x04000045 RID: 69
		[Token(Token = "0x4000045")]
		VS
	}

	// Token: 0x0200000A RID: 10
	[Token(Token = "0x200000A")]
	[Serializable]
	public class ColorUpdateEvent : UnityEvent<Color>
	{
		// Token: 0x06000049 RID: 73 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x31C880", Offset = "0x31BA80", VA = "0x18031C880")]
		public ColorUpdateEvent()
		{
		}
	}

	// Token: 0x0200000B RID: 11
	[Token(Token = "0x200000B")]
	[Serializable]
	public class AdvancedSettings
	{
		// Token: 0x0600004A RID: 74 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x316B30", Offset = "0x315D30", VA = "0x180316B30")]
		public FlexibleColorPicker.AdvancedSettings.PSettings Get(int i)
		{
			return null;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x316E30", Offset = "0x316030", VA = "0x180316E30")]
		public AdvancedSettings()
		{
		}

		// Token: 0x04000046 RID: 70
		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0x10")]
		public bool mainStatic;

		// Token: 0x04000047 RID: 71
		[Token(Token = "0x4000047")]
		[FieldOffset(Offset = "0x18")]
		public FlexibleColorPicker.AdvancedSettings.PSettings r;

		// Token: 0x04000048 RID: 72
		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0x20")]
		public FlexibleColorPicker.AdvancedSettings.PSettings g;

		// Token: 0x04000049 RID: 73
		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0x28")]
		public FlexibleColorPicker.AdvancedSettings.PSettings b;

		// Token: 0x0400004A RID: 74
		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0x30")]
		public FlexibleColorPicker.AdvancedSettings.PSettings h;

		// Token: 0x0400004B RID: 75
		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0x38")]
		public FlexibleColorPicker.AdvancedSettings.PSettings s;

		// Token: 0x0400004C RID: 76
		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0x40")]
		public FlexibleColorPicker.AdvancedSettings.PSettings v;

		// Token: 0x0400004D RID: 77
		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0x48")]
		public FlexibleColorPicker.AdvancedSettings.PSettings a;

		// Token: 0x0200000C RID: 12
		[Token(Token = "0x200000C")]
		[Serializable]
		public class PSettings
		{
			// Token: 0x0600004C RID: 76 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600004C")]
			[Address(RVA = "0x328F80", Offset = "0x328180", VA = "0x180328F80")]
			public PSettings()
			{
			}

			// Token: 0x0400004E RID: 78
			[Token(Token = "0x400004E")]
			[FieldOffset(Offset = "0x10")]
			[Tooltip("Value can be used to restrict slider range")]
			public Vector2 range;

			// Token: 0x0400004F RID: 79
			[Token(Token = "0x400004F")]
			[FieldOffset(Offset = "0x18")]
			[Tooltip("Make the picker associated with this value act static, even in a dynamic color picker setup")]
			public bool overrideStatic;
		}
	}

	// Token: 0x0200000D RID: 13
	[Token(Token = "0x200000D")]
	[Serializable]
	private class BufferedColor
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600004D RID: 77 RVA: 0x00002298 File Offset: 0x00000498
		[Token(Token = "0x17000003")]
		public float r
		{
			[Token(Token = "0x600004D")]
			[Address(RVA = "0x31B6B0", Offset = "0x31A8B0", VA = "0x18031B6B0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600004E RID: 78 RVA: 0x000022B0 File Offset: 0x000004B0
		[Token(Token = "0x17000004")]
		public float g
		{
			[Token(Token = "0x600004E")]
			[Address(RVA = "0x31B690", Offset = "0x31A890", VA = "0x18031B690")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600004F RID: 79 RVA: 0x000022C8 File Offset: 0x000004C8
		[Token(Token = "0x17000005")]
		public float b
		{
			[Token(Token = "0x600004F")]
			[Address(RVA = "0x31B680", Offset = "0x31A880", VA = "0x18031B680")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000050 RID: 80 RVA: 0x000022E0 File Offset: 0x000004E0
		[Token(Token = "0x17000006")]
		public float a
		{
			[Token(Token = "0x6000050")]
			[Address(RVA = "0x31B670", Offset = "0x31A870", VA = "0x18031B670")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000051 RID: 81 RVA: 0x000022F8 File Offset: 0x000004F8
		[Token(Token = "0x17000007")]
		public float h
		{
			[Token(Token = "0x6000051")]
			[Address(RVA = "0x31B6A0", Offset = "0x31A8A0", VA = "0x18031B6A0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000052 RID: 82 RVA: 0x00002310 File Offset: 0x00000510
		[Token(Token = "0x17000008")]
		public float s
		{
			[Token(Token = "0x6000052")]
			[Address(RVA = "0x31B6C0", Offset = "0x31A8C0", VA = "0x18031B6C0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00002328 File Offset: 0x00000528
		[Token(Token = "0x17000009")]
		public float v
		{
			[Token(Token = "0x6000053")]
			[Address(RVA = "0x31B6D0", Offset = "0x31A8D0", VA = "0x18031B6D0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x31B640", Offset = "0x31A840", VA = "0x18031B640")]
		public BufferedColor()
		{
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x31B590", Offset = "0x31A790", VA = "0x18031B590")]
		public BufferedColor(Color color)
		{
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x31B4D0", Offset = "0x31A6D0", VA = "0x18031B4D0")]
		public BufferedColor(Color color, float hue, float sat)
		{
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x31B360", Offset = "0x31A560", VA = "0x18031B360")]
		public BufferedColor(Color color, FlexibleColorPicker.BufferedColor source)
		{
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000058")]
		[Address(RVA = "0x31B200", Offset = "0x31A400", VA = "0x18031B200")]
		public void Set(Color color)
		{
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x31B2B0", Offset = "0x31A4B0", VA = "0x18031B2B0")]
		public void Set(Color color, float bufferedHue, float bufferedSaturation)
		{
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600005A")]
		[Address(RVA = "0x31AE30", Offset = "0x31A030", VA = "0x18031AE30")]
		public FlexibleColorPicker.BufferedColor PickR(float value)
		{
			return null;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600005B")]
		[Address(RVA = "0x31ABE0", Offset = "0x319DE0", VA = "0x18031ABE0")]
		public FlexibleColorPicker.BufferedColor PickG(float value)
		{
			return null;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x31AB40", Offset = "0x319D40", VA = "0x18031AB40")]
		public FlexibleColorPicker.BufferedColor PickB(float value)
		{
			return null;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x31AAA0", Offset = "0x319CA0", VA = "0x18031AAA0")]
		public FlexibleColorPicker.BufferedColor PickA(float value)
		{
			return null;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x31AC80", Offset = "0x319E80", VA = "0x18031AC80")]
		public FlexibleColorPicker.BufferedColor PickH(float value)
		{
			return null;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x31AED0", Offset = "0x31A0D0", VA = "0x18031AED0")]
		public FlexibleColorPicker.BufferedColor PickS(float value)
		{
			return null;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x31B080", Offset = "0x31A280", VA = "0x18031B080")]
		public FlexibleColorPicker.BufferedColor PickV(float value)
		{
			return null;
		}

		// Token: 0x04000050 RID: 80
		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x10")]
		public Color color;

		// Token: 0x04000051 RID: 81
		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x20")]
		private float bufferedHue;

		// Token: 0x04000052 RID: 82
		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x24")]
		private float bufferedSaturation;
	}
}
