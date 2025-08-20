using System;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine.UI;

// Token: 0x0200010E RID: 270
[Token(Token = "0x200010E")]
public class IntroMenu : Menu
{
	// Token: 0x0600049D RID: 1181 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600049D")]
	[Address(RVA = "0x3D6560", Offset = "0x3D5760", VA = "0x1803D6560", Slot = "5")]
	protected override void OnEnter()
	{
	}

	// Token: 0x0600049E RID: 1182 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600049E")]
	[Address(RVA = "0x3D64D0", Offset = "0x3D56D0", VA = "0x1803D64D0")]
	private void Awake()
	{
	}

	// Token: 0x0600049F RID: 1183 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600049F")]
	[Address(RVA = "0x3D6560", Offset = "0x3D5760", VA = "0x1803D6560")]
	private Task RunAsync()
	{
		return null;
	}

	// Token: 0x060004A0 RID: 1184 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004A0")]
	[Address(RVA = "0x3D6630", Offset = "0x3D5830", VA = "0x1803D6630")]
	public IntroMenu()
	{
	}

	// Token: 0x040004EE RID: 1262
	[Token(Token = "0x40004EE")]
	[FieldOffset(Offset = "0x90")]
	public Image Logo;

	// Token: 0x040004EF RID: 1263
	[Token(Token = "0x40004EF")]
	[FieldOffset(Offset = "0x98")]
	public float AnimationDuration;

	// Token: 0x040004F0 RID: 1264
	[Token(Token = "0x40004F0")]
	[FieldOffset(Offset = "0x9C")]
	public float WaitTime;

	// Token: 0x040004F1 RID: 1265
	[Token(Token = "0x40004F1")]
	[FieldOffset(Offset = "0xA0")]
	public float ScaleTo;

	// Token: 0x040004F2 RID: 1266
	[Token(Token = "0x40004F2")]
	[FieldOffset(Offset = "0xA4")]
	public EasingType FadeInEase;

	// Token: 0x040004F3 RID: 1267
	[Token(Token = "0x40004F3")]
	[FieldOffset(Offset = "0xA8")]
	public EasingType FadeOutEase;
}
