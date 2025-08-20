using System;
using Il2CppDummyDll;
using Ronin.Model.Enums;
using Ronin.Model.Structs;
using TMPro;
using UnityEngine;

// Token: 0x020001EB RID: 491
[Token(Token = "0x20001EB")]
public class Name : MonoBehaviour
{
	// Token: 0x06000A1F RID: 2591 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000A1F")]
	[Address(RVA = "0x42B2D0", Offset = "0x42A4D0", VA = "0x18042B2D0")]
	public static string GetRichTextName(string name, BadgeType badge, RankType rank)
	{
		return null;
	}

	// Token: 0x06000A20 RID: 2592 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A20")]
	[Address(RVA = "0x4283E0", Offset = "0x4275E0", VA = "0x1804283E0")]
	public void SetHeight(float height)
	{
	}

	// Token: 0x06000A21 RID: 2593 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A21")]
	[Address(RVA = "0x42B4B0", Offset = "0x42A6B0", VA = "0x18042B4B0")]
	public void Setup(Entity entity, float height, ref String16 deathNote)
	{
	}

	// Token: 0x06000A22 RID: 2594 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A22")]
	[Address(RVA = "0x42B270", Offset = "0x42A470", VA = "0x18042B270")]
	private void Awake()
	{
	}

	// Token: 0x06000A23 RID: 2595 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A23")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public Name()
	{
	}

	// Token: 0x04000967 RID: 2407
	[Token(Token = "0x4000967")]
	[FieldOffset(Offset = "0x20")]
	public Follow Follow;

	// Token: 0x04000968 RID: 2408
	[Token(Token = "0x4000968")]
	[FieldOffset(Offset = "0x28")]
	public TextMeshPro Label;

	// Token: 0x04000969 RID: 2409
	[Token(Token = "0x4000969")]
	[FieldOffset(Offset = "0x30")]
	private Option _chatFilterOption;
}
