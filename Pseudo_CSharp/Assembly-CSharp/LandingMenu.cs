using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000110 RID: 272
[Token(Token = "0x2000110")]
public class LandingMenu : Menu
{
	// Token: 0x060004A3 RID: 1187 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004A3")]
	[Address(RVA = "0x3D67B0", Offset = "0x3D59B0", VA = "0x1803D67B0")]
	public void Credits()
	{
	}

	// Token: 0x060004A4 RID: 1188 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004A4")]
	[Address(RVA = "0x3D68E0", Offset = "0x3D5AE0", VA = "0x1803D68E0")]
	public void Next()
	{
	}

	// Token: 0x060004A5 RID: 1189 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004A5")]
	[Address(RVA = "0x3D69C0", Offset = "0x3D5BC0", VA = "0x1803D69C0", Slot = "5")]
	protected override void OnEnter()
	{
	}

	// Token: 0x060004A6 RID: 1190 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004A6")]
	[Address(RVA = "0x3D6C60", Offset = "0x3D5E60", VA = "0x1803D6C60", Slot = "8")]
	protected override void Update()
	{
	}

	// Token: 0x060004A7 RID: 1191 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004A7")]
	[Address(RVA = "0x3D6660", Offset = "0x3D5860", VA = "0x1803D6660")]
	private void Awake()
	{
	}

	// Token: 0x060004A8 RID: 1192 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60004A8")]
	[Address(RVA = "0x3D6810", Offset = "0x3D5A10", VA = "0x1803D6810")]
	private Task NextAsync()
	{
		return null;
	}

	// Token: 0x060004A9 RID: 1193 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004A9")]
	[Address(RVA = "0x3D6D90", Offset = "0x3D5F90", VA = "0x1803D6D90")]
	public LandingMenu()
	{
	}

	// Token: 0x040004F8 RID: 1272
	[Token(Token = "0x40004F8")]
	[FieldOffset(Offset = "0x90")]
	public RectTransform Logo;

	// Token: 0x040004F9 RID: 1273
	[Token(Token = "0x40004F9")]
	[FieldOffset(Offset = "0x98")]
	public GameObject FadeIn;

	// Token: 0x040004FA RID: 1274
	[Token(Token = "0x40004FA")]
	[FieldOffset(Offset = "0xA0")]
	public float FadeDuration;

	// Token: 0x040004FB RID: 1275
	[Token(Token = "0x40004FB")]
	[FieldOffset(Offset = "0xA4")]
	public EasingType EasingType;

	// Token: 0x040004FC RID: 1276
	[Token(Token = "0x40004FC")]
	[FieldOffset(Offset = "0xA8")]
	public Menu NextMenu;

	// Token: 0x040004FD RID: 1277
	[Token(Token = "0x40004FD")]
	[FieldOffset(Offset = "0xB0")]
	public GameObject MapEditor;

	// Token: 0x040004FE RID: 1278
	[Token(Token = "0x40004FE")]
	[FieldOffset(Offset = "0xB8")]
	private Vector2 _initialLogoPosition;

	// Token: 0x040004FF RID: 1279
	[Token(Token = "0x40004FF")]
	[FieldOffset(Offset = "0xC0")]
	private bool _going;

	// Token: 0x04000500 RID: 1280
	[Token(Token = "0x4000500")]
	[FieldOffset(Offset = "0xC8")]
	private readonly Dictionary<Graphic, float> _initialAlphas;
}
