using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020001AA RID: 426
[Token(Token = "0x20001AA")]
public class LanguageSelector : MonoBehaviour
{
	// Token: 0x06000893 RID: 2195 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000893")]
	[Address(RVA = "0x415E60", Offset = "0x415060", VA = "0x180415E60")]
	private void Awake()
	{
	}

	// Token: 0x06000894 RID: 2196 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000894")]
	[Address(RVA = "0x415EF0", Offset = "0x4150F0", VA = "0x180415EF0")]
	public void Toggle()
	{
	}

	// Token: 0x06000895 RID: 2197 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000895")]
	[Address(RVA = "0x416090", Offset = "0x415290", VA = "0x180416090")]
	public void UpdateLocale()
	{
	}

	// Token: 0x06000896 RID: 2198 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000896")]
	[Address(RVA = "0x415EA0", Offset = "0x4150A0", VA = "0x180415EA0")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000897 RID: 2199 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000897")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public LanguageSelector()
	{
	}

	// Token: 0x04000852 RID: 2130
	[Token(Token = "0x4000852")]
	[FieldOffset(Offset = "0x20")]
	public bool Bottom;

	// Token: 0x04000853 RID: 2131
	[Token(Token = "0x4000853")]
	[FieldOffset(Offset = "0x28")]
	public Image Flag;

	// Token: 0x04000854 RID: 2132
	[Token(Token = "0x4000854")]
	[FieldOffset(Offset = "0x30")]
	public RectTransform Selections;

	// Token: 0x04000855 RID: 2133
	[Token(Token = "0x4000855")]
	[FieldOffset(Offset = "0x38")]
	private bool _toggled;
}
