using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200017A RID: 378
[Token(Token = "0x200017A")]
public class Blink : MonoBehaviour
{
	// Token: 0x0600076C RID: 1900 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600076C")]
	[Address(RVA = "0x407390", Offset = "0x406590", VA = "0x180407390")]
	private void Awake()
	{
	}

	// Token: 0x0600076D RID: 1901 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600076D")]
	[Address(RVA = "0x407420", Offset = "0x406620", VA = "0x180407420")]
	private void LateUpdate()
	{
	}

	// Token: 0x0600076E RID: 1902 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600076E")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public Blink()
	{
	}

	// Token: 0x04000770 RID: 1904
	[Token(Token = "0x4000770")]
	[FieldOffset(Offset = "0x20")]
	public Graphic Target;

	// Token: 0x04000771 RID: 1905
	[Token(Token = "0x4000771")]
	[FieldOffset(Offset = "0x28")]
	public float Duration;

	// Token: 0x04000772 RID: 1906
	[Token(Token = "0x4000772")]
	[FieldOffset(Offset = "0x2C")]
	public float OnOffRatio;
}
