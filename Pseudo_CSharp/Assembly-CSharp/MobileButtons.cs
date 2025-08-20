using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020002D4 RID: 724
[Token(Token = "0x20002D4")]
public class MobileButtons : MonoBehaviour, IControlInput
{
	// Token: 0x170001C0 RID: 448
	// (get) Token: 0x06000FA2 RID: 4002 RVA: 0x00006300 File Offset: 0x00004500
	// (set) Token: 0x06000FA3 RID: 4003 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001C0")]
	public bool Active
	{
		[Token(Token = "0x6000FA2")]
		[Address(RVA = "0x3523F0", Offset = "0x3515F0", VA = "0x1803523F0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000FA3")]
		[Address(RVA = "0x352420", Offset = "0x351620", VA = "0x180352420")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x170001C1 RID: 449
	// (get) Token: 0x06000FA4 RID: 4004 RVA: 0x00006318 File Offset: 0x00004518
	[Token(Token = "0x170001C1")]
	public bool ActiveInHeirarchy
	{
		[Token(Token = "0x6000FA4")]
		[Address(RVA = "0x333E20", Offset = "0x333020", VA = "0x180333E20", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170001C2 RID: 450
	// (get) Token: 0x06000FA5 RID: 4005 RVA: 0x00006330 File Offset: 0x00004530
	[Token(Token = "0x170001C2")]
	public bool Aiming
	{
		[Token(Token = "0x6000FA5")]
		[Address(RVA = "0x316110", Offset = "0x315310", VA = "0x180316110", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170001C3 RID: 451
	// (get) Token: 0x06000FA6 RID: 4006 RVA: 0x00006348 File Offset: 0x00004548
	// (set) Token: 0x06000FA7 RID: 4007 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001C3")]
	public float Angle
	{
		[Token(Token = "0x6000FA6")]
		[Address(RVA = "0x352400", Offset = "0x351600", VA = "0x180352400", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000FA7")]
		[Address(RVA = "0x352430", Offset = "0x351630", VA = "0x180352430")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x170001C4 RID: 452
	// (get) Token: 0x06000FA8 RID: 4008 RVA: 0x00006360 File Offset: 0x00004560
	// (set) Token: 0x06000FA9 RID: 4009 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001C4")]
	public float Magnitude
	{
		[Token(Token = "0x6000FA8")]
		[Address(RVA = "0x352410", Offset = "0x351610", VA = "0x180352410", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000FA9")]
		[Address(RVA = "0x352440", Offset = "0x351640", VA = "0x180352440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x06000FAA RID: 4010 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FAA")]
	[Address(RVA = "0x351DC0", Offset = "0x350FC0", VA = "0x180351DC0")]
	public void HomeCancel()
	{
	}

	// Token: 0x06000FAB RID: 4011 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FAB")]
	[Address(RVA = "0x351E30", Offset = "0x351030", VA = "0x180351E30")]
	public void HomeStart()
	{
	}

	// Token: 0x06000FAC RID: 4012 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FAC")]
	[Address(RVA = "0x352030", Offset = "0x351230", VA = "0x180352030")]
	public void SetAttackAlways(bool active)
	{
	}

	// Token: 0x06000FAD RID: 4013 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FAD")]
	[Address(RVA = "0x352320", Offset = "0x351520", VA = "0x180352320")]
	public void Toggle()
	{
	}

	// Token: 0x06000FAE RID: 4014 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FAE")]
	[Address(RVA = "0x351E60", Offset = "0x351060", VA = "0x180351E60")]
	public void NewWorld()
	{
	}

	// Token: 0x06000FAF RID: 4015 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FAF")]
	[Address(RVA = "0x351B30", Offset = "0x350D30", VA = "0x180351B30")]
	private void Awake()
	{
	}

	// Token: 0x06000FB0 RID: 4016 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FB0")]
	[Address(RVA = "0x351E70", Offset = "0x351070", VA = "0x180351E70")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000FB1 RID: 4017 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FB1")]
	[Address(RVA = "0x352010", Offset = "0x351210", VA = "0x180352010")]
	private void OnOptionChanged(Option option)
	{
	}

	// Token: 0x06000FB2 RID: 4018 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FB2")]
	[Address(RVA = "0x352040", Offset = "0x351240", VA = "0x180352040")]
	private void SetOptionValues()
	{
	}

	// Token: 0x06000FB3 RID: 4019 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FB3")]
	[Address(RVA = "0x352370", Offset = "0x351570", VA = "0x180352370")]
	private void UpdateSprite()
	{
	}

	// Token: 0x06000FB4 RID: 4020 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FB4")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public MobileButtons()
	{
	}

	// Token: 0x04000CED RID: 3309
	[Token(Token = "0x4000CED")]
	[FieldOffset(Offset = "0x20")]
	public Image AttackNearImage;

	// Token: 0x04000CEE RID: 3310
	[Token(Token = "0x4000CEE")]
	[FieldOffset(Offset = "0x28")]
	public Sprite DefaultNearSprite;

	// Token: 0x04000CEF RID: 3311
	[Token(Token = "0x4000CEF")]
	[FieldOffset(Offset = "0x30")]
	public Sprite ActiveNearSprite;

	// Token: 0x04000CF0 RID: 3312
	[Token(Token = "0x4000CF0")]
	[FieldOffset(Offset = "0x38")]
	public Image AttackAlwaysImage;

	// Token: 0x04000CF1 RID: 3313
	[Token(Token = "0x4000CF1")]
	[FieldOffset(Offset = "0x40")]
	public Sprite DefaultAlwaysSprite;

	// Token: 0x04000CF2 RID: 3314
	[Token(Token = "0x4000CF2")]
	[FieldOffset(Offset = "0x48")]
	public Sprite ActiveAlwaysSprite;

	// Token: 0x04000CF3 RID: 3315
	[Token(Token = "0x4000CF3")]
	[FieldOffset(Offset = "0x50")]
	public RectTransform HomeButton;

	// Token: 0x04000CF4 RID: 3316
	[Token(Token = "0x4000CF4")]
	[FieldOffset(Offset = "0x58")]
	public RectTransform ButtonBase;

	// Token: 0x04000CF5 RID: 3317
	[Token(Token = "0x4000CF5")]
	[FieldOffset(Offset = "0x60")]
	public RectTransform ButtonRegion;

	// Token: 0x04000CF6 RID: 3318
	[Token(Token = "0x4000CF6")]
	[FieldOffset(Offset = "0x68")]
	public GameObject AttackJoystick;

	// Token: 0x04000CF7 RID: 3319
	[Token(Token = "0x4000CF7")]
	[FieldOffset(Offset = "0x70")]
	public GameObject AttackButton;

	// Token: 0x04000CF8 RID: 3320
	[Token(Token = "0x4000CF8")]
	[FieldOffset(Offset = "0x78")]
	public World World;

	// Token: 0x04000CF9 RID: 3321
	[Token(Token = "0x4000CF9")]
	[FieldOffset(Offset = "0x80")]
	private Option _attackXOption;

	// Token: 0x04000CFA RID: 3322
	[Token(Token = "0x4000CFA")]
	[FieldOffset(Offset = "0x88")]
	private Option _attackYOption;

	// Token: 0x04000CFB RID: 3323
	[Token(Token = "0x4000CFB")]
	[FieldOffset(Offset = "0x90")]
	private Option _attackSizeOption;

	// Token: 0x04000CFC RID: 3324
	[Token(Token = "0x4000CFC")]
	[FieldOffset(Offset = "0x98")]
	private Option _attackNearbyOption;

	// Token: 0x04000CFD RID: 3325
	[Token(Token = "0x4000CFD")]
	[FieldOffset(Offset = "0xA0")]
	private Option _homeStyle;

	// Token: 0x04000CFE RID: 3326
	[Token(Token = "0x4000CFE")]
	[FieldOffset(Offset = "0xA8")]
	private Option _attackTargetingOption;
}
