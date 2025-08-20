using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001C7 RID: 455
[Token(Token = "0x20001C7")]
public class OptionCondition : MonoBehaviour
{
	// Token: 0x06000932 RID: 2354 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000932")]
	[Address(RVA = "0x42BEB0", Offset = "0x42B0B0", VA = "0x18042BEB0")]
	private void Awake()
	{
	}

	// Token: 0x06000933 RID: 2355 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000933")]
	[Address(RVA = "0x42BFF0", Offset = "0x42B1F0", VA = "0x18042BFF0")]
	private void OnChange(Option option)
	{
	}

	// Token: 0x06000934 RID: 2356 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000934")]
	[Address(RVA = "0x42C080", Offset = "0x42B280", VA = "0x18042C080")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000935 RID: 2357 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000935")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public OptionCondition()
	{
	}

	// Token: 0x040008C3 RID: 2243
	[Token(Token = "0x40008C3")]
	[FieldOffset(Offset = "0x20")]
	public OptionType OptionType;

	// Token: 0x040008C4 RID: 2244
	[Token(Token = "0x40008C4")]
	[FieldOffset(Offset = "0x28")]
	public string TargetValue;

	// Token: 0x040008C5 RID: 2245
	[Token(Token = "0x40008C5")]
	[FieldOffset(Offset = "0x30")]
	public GameObject[] TargetGameObjects;

	// Token: 0x040008C6 RID: 2246
	[Token(Token = "0x40008C6")]
	[FieldOffset(Offset = "0x38")]
	private Option _option;
}
