using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x020002F2 RID: 754
[Token(Token = "0x20002F2")]
public class LabelBuilder : ElementBuilder
{
	// Token: 0x060010A0 RID: 4256 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010A0")]
	[Address(RVA = "0x350940", Offset = "0x34FB40", VA = "0x180350940")]
	public LabelBuilder(GameObject gameObject)
	{
	}

	// Token: 0x060010A1 RID: 4257 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60010A1")]
	[Address(RVA = "0x350230", Offset = "0x34F430", VA = "0x180350230")]
	public LabelBuilder Align(TextAlignmentOptions alignment)
	{
		return null;
	}

	// Token: 0x060010A2 RID: 4258 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60010A2")]
	[Address(RVA = "0x350260", Offset = "0x34F460", VA = "0x180350260")]
	public LabelBuilder Color(Color color)
	{
		return null;
	}

	// Token: 0x060010A3 RID: 4259 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60010A3")]
	[Address(RVA = "0x350430", Offset = "0x34F630", VA = "0x180350430")]
	public LabelBuilder Font(FontLibrary.FontPair fontPair)
	{
		return null;
	}

	// Token: 0x060010A4 RID: 4260 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60010A4")]
	[Address(RVA = "0x3505F0", Offset = "0x34F7F0", VA = "0x1803505F0")]
	public LabelBuilder Offset(Vector2 offset)
	{
		return null;
	}

	// Token: 0x060010A5 RID: 4261 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60010A5")]
	[Address(RVA = "0x350600", Offset = "0x34F800", VA = "0x180350600")]
	public LabelBuilder RtlSupport(bool supported = true, bool align = false)
	{
		return null;
	}

	// Token: 0x060010A6 RID: 4262 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60010A6")]
	[Address(RVA = "0x3508A0", Offset = "0x34FAA0", VA = "0x1803508A0")]
	public LabelBuilder Size(float size)
	{
		return null;
	}

	// Token: 0x060010A7 RID: 4263 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60010A7")]
	[Address(RVA = "0x3508D0", Offset = "0x34FAD0", VA = "0x1803508D0")]
	public LabelBuilder Text(string text)
	{
		return null;
	}

	// Token: 0x060010A8 RID: 4264 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60010A8")]
	[Address(RVA = "0x350910", Offset = "0x34FB10", VA = "0x180350910")]
	public LabelBuilder Wrap(bool enabled)
	{
		return null;
	}

	// Token: 0x060010A9 RID: 4265 RVA: 0x00006708 File Offset: 0x00004908
	[Token(Token = "0x60010A9")]
	[Address(RVA = "0x350490", Offset = "0x34F690", VA = "0x180350490", Slot = "5")]
	public override Rect GetRect()
	{
		return default(Rect);
	}

	// Token: 0x060010AA RID: 4266 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010AA")]
	[Address(RVA = "0x3506C0", Offset = "0x34F8C0", VA = "0x1803506C0", Slot = "6")]
	protected override void SetPosition(Vector2 position)
	{
	}

	// Token: 0x060010AB RID: 4267 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010AB")]
	[Address(RVA = "0x3502A0", Offset = "0x34F4A0", VA = "0x1803502A0")]
	private static void Default(LabelBuilder builder)
	{
	}

	// Token: 0x04000DDF RID: 3551
	[Token(Token = "0x4000DDF")]
	[FieldOffset(Offset = "0x28")]
	private readonly TextMeshProUGUI _label;

	// Token: 0x04000DE0 RID: 3552
	[Token(Token = "0x4000DE0")]
	[FieldOffset(Offset = "0x30")]
	private float _xPosition;
}
