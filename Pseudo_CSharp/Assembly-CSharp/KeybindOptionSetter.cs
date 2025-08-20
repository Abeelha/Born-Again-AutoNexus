using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x020001C2 RID: 450
[Token(Token = "0x20001C2")]
public class KeybindOptionSetter : OptionSetter
{
	// Token: 0x0600091C RID: 2332 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600091C")]
	[Address(RVA = "0x414CE0", Offset = "0x413EE0", VA = "0x180414CE0")]
	public void GetNewKey()
	{
	}

	// Token: 0x0600091D RID: 2333 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600091D")]
	[Address(RVA = "0x414D90", Offset = "0x413F90", VA = "0x180414D90", Slot = "4")]
	protected override void OnOptionChanged()
	{
	}

	// Token: 0x0600091E RID: 2334 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600091E")]
	[Address(RVA = "0x40D8F0", Offset = "0x40CAF0", VA = "0x18040D8F0")]
	public KeybindOptionSetter()
	{
	}

	// Token: 0x040008B7 RID: 2231
	[Token(Token = "0x40008B7")]
	[FieldOffset(Offset = "0x0")]
	private static readonly KeyCode[] s_allowedKeybinds;

	// Token: 0x040008B8 RID: 2232
	[Token(Token = "0x40008B8")]
	[FieldOffset(Offset = "0x40")]
	public TextMeshProUGUI KeybindLabel;
}
