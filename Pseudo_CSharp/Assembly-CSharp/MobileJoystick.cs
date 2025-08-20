using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x020002D5 RID: 725
[Token(Token = "0x20002D5")]
public class MobileJoystick : MonoBehaviour, IBeginDragHandler, IEventSystemHandler
{
	// Token: 0x170001C5 RID: 453
	// (get) Token: 0x06000FB5 RID: 4021 RVA: 0x00006378 File Offset: 0x00004578
	[Token(Token = "0x170001C5")]
	private bool Fixed
	{
		[Token(Token = "0x6000FB5")]
		[Address(RVA = "0x352D00", Offset = "0x351F00", VA = "0x180352D00")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000FB6 RID: 4022 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FB6")]
	[Address(RVA = "0x352690", Offset = "0x351890", VA = "0x180352690", Slot = "4")]
	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	// Token: 0x06000FB7 RID: 4023 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FB7")]
	[Address(RVA = "0x352450", Offset = "0x351650", VA = "0x180352450")]
	private void Awake()
	{
	}

	// Token: 0x06000FB8 RID: 4024 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FB8")]
	[Address(RVA = "0x3528B0", Offset = "0x351AB0", VA = "0x1803528B0")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000FB9 RID: 4025 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FB9")]
	[Address(RVA = "0x352A40", Offset = "0x351C40", VA = "0x180352A40")]
	private void OnOptionChanged(Option option)
	{
	}

	// Token: 0x06000FBA RID: 4026 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FBA")]
	[Address(RVA = "0x352A50", Offset = "0x351C50", VA = "0x180352A50")]
	private void SetOptionValues()
	{
	}

	// Token: 0x06000FBB RID: 4027 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FBB")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public MobileJoystick()
	{
	}

	// Token: 0x04000D02 RID: 3330
	[Token(Token = "0x4000D02")]
	[FieldOffset(Offset = "0x20")]
	public RectTransform JoystickBase;

	// Token: 0x04000D03 RID: 3331
	[Token(Token = "0x4000D03")]
	[FieldOffset(Offset = "0x28")]
	public Image JoystickBaseImage;

	// Token: 0x04000D04 RID: 3332
	[Token(Token = "0x4000D04")]
	[FieldOffset(Offset = "0x30")]
	public RectTransform JoystickRegion;

	// Token: 0x04000D05 RID: 3333
	[Token(Token = "0x4000D05")]
	[FieldOffset(Offset = "0x38")]
	public Joystick Joystick;

	// Token: 0x04000D06 RID: 3334
	[Token(Token = "0x4000D06")]
	[FieldOffset(Offset = "0x40")]
	private Option _joystickSizeOption;

	// Token: 0x04000D07 RID: 3335
	[Token(Token = "0x4000D07")]
	[FieldOffset(Offset = "0x48")]
	private Option _joystickStyleOption;

	// Token: 0x04000D08 RID: 3336
	[Token(Token = "0x4000D08")]
	[FieldOffset(Offset = "0x50")]
	private Option _fixedXOption;

	// Token: 0x04000D09 RID: 3337
	[Token(Token = "0x4000D09")]
	[FieldOffset(Offset = "0x58")]
	private Option _fixedYOption;

	// Token: 0x04000D0A RID: 3338
	[Token(Token = "0x4000D0A")]
	[FieldOffset(Offset = "0x60")]
	private Option _hideWhenInactiveOption;
}
