using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x020001E9 RID: 489
[Token(Token = "0x20001E9")]
public class Level : MonoBehaviour
{
	// Token: 0x06000A16 RID: 2582 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A16")]
	[Address(RVA = "0x4283E0", Offset = "0x4275E0", VA = "0x1804283E0")]
	public void SetHeight(float height)
	{
	}

	// Token: 0x06000A17 RID: 2583 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A17")]
	[Address(RVA = "0x428410", Offset = "0x427610", VA = "0x180428410")]
	public void Setup(Transform target, float height, int level)
	{
	}

	// Token: 0x06000A18 RID: 2584 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A18")]
	[Address(RVA = "0x428300", Offset = "0x427500", VA = "0x180428300")]
	public void SetBlessing(ushort blessingType)
	{
	}

	// Token: 0x06000A19 RID: 2585 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A19")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public Level()
	{
	}

	// Token: 0x0400095F RID: 2399
	[Token(Token = "0x400095F")]
	[FieldOffset(Offset = "0x20")]
	public Follow Follow;

	// Token: 0x04000960 RID: 2400
	[Token(Token = "0x4000960")]
	[FieldOffset(Offset = "0x28")]
	public TextMeshPro Label;
}
