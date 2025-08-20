using System;
using Il2CppDummyDll;
using TMPro;

// Token: 0x020001C1 RID: 449
[Token(Token = "0x20001C1")]
public class EnumOptionSetter : OptionSetter
{
	// Token: 0x06000915 RID: 2325 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000915")]
	[Address(RVA = "0x4108D0", Offset = "0x40FAD0", VA = "0x1804108D0")]
	public void Increment()
	{
	}

	// Token: 0x06000916 RID: 2326 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000916")]
	[Address(RVA = "0x410DA0", Offset = "0x40FFA0", VA = "0x180410DA0", Slot = "4")]
	protected override void OnOptionChanged()
	{
	}

	// Token: 0x06000917 RID: 2327 RVA: 0x000044A0 File Offset: 0x000026A0
	[Token(Token = "0x6000917")]
	[Address(RVA = "0x410800", Offset = "0x40FA00", VA = "0x180410800")]
	private int GetCurrentIndex()
	{
		return 0;
	}

	// Token: 0x06000918 RID: 2328 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000918")]
	[Address(RVA = "0x410A50", Offset = "0x40FC50", VA = "0x180410A50")]
	private void OnEnable()
	{
	}

	// Token: 0x06000919 RID: 2329 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000919")]
	[Address(RVA = "0x410F30", Offset = "0x410130", VA = "0x180410F30")]
	public EnumOptionSetter()
	{
	}

	// Token: 0x040008B2 RID: 2226
	[Token(Token = "0x40008B2")]
	[FieldOffset(Offset = "0x40")]
	public string EnumTypeName;

	// Token: 0x040008B3 RID: 2227
	[Token(Token = "0x40008B3")]
	[FieldOffset(Offset = "0x48")]
	public string[] Values;

	// Token: 0x040008B4 RID: 2228
	[Token(Token = "0x40008B4")]
	[FieldOffset(Offset = "0x50")]
	public TextMeshProUGUI Label;

	// Token: 0x040008B5 RID: 2229
	[Token(Token = "0x40008B5")]
	[FieldOffset(Offset = "0x58")]
	public bool IsLocalized;

	// Token: 0x040008B6 RID: 2230
	[Token(Token = "0x40008B6")]
	[FieldOffset(Offset = "0x5C")]
	private int? _index;
}
