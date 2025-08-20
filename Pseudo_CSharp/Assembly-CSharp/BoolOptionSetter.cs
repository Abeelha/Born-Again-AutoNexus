using System;
using Il2CppDummyDll;
using TMPro;

// Token: 0x020001BF RID: 447
[Token(Token = "0x20001BF")]
public class BoolOptionSetter : OptionSetter
{
	// Token: 0x0600090F RID: 2319 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600090F")]
	[Address(RVA = "0x407740", Offset = "0x406940", VA = "0x180407740")]
	public void Toggle()
	{
	}

	// Token: 0x06000910 RID: 2320 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000910")]
	[Address(RVA = "0x4075C0", Offset = "0x4067C0", VA = "0x1804075C0", Slot = "4")]
	protected override void OnOptionChanged()
	{
	}

	// Token: 0x06000911 RID: 2321 RVA: 0x00004488 File Offset: 0x00002688
	[Token(Token = "0x6000911")]
	[Address(RVA = "0x4074C0", Offset = "0x4066C0", VA = "0x1804074C0")]
	private ValueTuple<string, string> GetOptionText()
	{
		return default(ValueTuple<string, string>);
	}

	// Token: 0x06000912 RID: 2322 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000912")]
	[Address(RVA = "0x407780", Offset = "0x406980", VA = "0x180407780")]
	public BoolOptionSetter()
	{
	}

	// Token: 0x040008AE RID: 2222
	[Token(Token = "0x40008AE")]
	[FieldOffset(Offset = "0x40")]
	public TextMeshProUGUI Label;

	// Token: 0x040008AF RID: 2223
	[Token(Token = "0x40008AF")]
	[FieldOffset(Offset = "0x48")]
	public BoolOptionText OptionText;

	// Token: 0x040008B0 RID: 2224
	[Token(Token = "0x40008B0")]
	[FieldOffset(Offset = "0x50")]
	public string TrueText;

	// Token: 0x040008B1 RID: 2225
	[Token(Token = "0x40008B1")]
	[FieldOffset(Offset = "0x58")]
	public string FalseText;
}
