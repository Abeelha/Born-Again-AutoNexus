using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.UI;

// Token: 0x020001A9 RID: 425
[Token(Token = "0x20001A9")]
public class LanguageSelection : MonoBehaviour
{
	// Token: 0x0600088F RID: 2191 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600088F")]
	[Address(RVA = "0x4159B0", Offset = "0x414BB0", VA = "0x1804159B0")]
	private void Awake()
	{
	}

	// Token: 0x06000890 RID: 2192 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000890")]
	[Address(RVA = "0x415DC0", Offset = "0x414FC0", VA = "0x180415DC0")]
	public void Select()
	{
	}

	// Token: 0x06000891 RID: 2193 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000891")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public LanguageSelection()
	{
	}

	// Token: 0x0400084D RID: 2125
	[Token(Token = "0x400084D")]
	[FieldOffset(Offset = "0x20")]
	public string LanguageCode;

	// Token: 0x0400084E RID: 2126
	[Token(Token = "0x400084E")]
	[FieldOffset(Offset = "0x28")]
	public Locale Locale;

	// Token: 0x0400084F RID: 2127
	[Token(Token = "0x400084F")]
	[FieldOffset(Offset = "0x30")]
	public TextMeshProUGUI NameLabel;

	// Token: 0x04000850 RID: 2128
	[Token(Token = "0x4000850")]
	[FieldOffset(Offset = "0x38")]
	public Image Flag;

	// Token: 0x04000851 RID: 2129
	[Token(Token = "0x4000851")]
	[FieldOffset(Offset = "0x40")]
	private Locale _locale;
}
