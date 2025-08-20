using System;
using Il2CppDummyDll;
using Ronin.Model.Definitions;
using UnityEngine;

// Token: 0x020001F0 RID: 496
[Token(Token = "0x20001F0")]
public class Tombstone : MonoBehaviour
{
	// Token: 0x06000A3A RID: 2618 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A3A")]
	[Address(RVA = "0x430F50", Offset = "0x430150", VA = "0x180430F50")]
	public void SetOpacity(float opacity)
	{
	}

	// Token: 0x06000A3B RID: 2619 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A3B")]
	[Address(RVA = "0x430FB0", Offset = "0x4301B0", VA = "0x180430FB0")]
	public void Setup(Transform transform, ushort type, float opacity)
	{
	}

	// Token: 0x06000A3C RID: 2620 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A3C")]
	[Address(RVA = "0x4310C0", Offset = "0x4302C0", VA = "0x1804310C0")]
	public void Setup(Transform transform, ObjectDefinition definition, float opacity)
	{
	}

	// Token: 0x06000A3D RID: 2621 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A3D")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public Tombstone()
	{
	}

	// Token: 0x04000978 RID: 2424
	[Token(Token = "0x4000978")]
	[FieldOffset(Offset = "0x20")]
	public ObjectDefinition Definition;

	// Token: 0x04000979 RID: 2425
	[Token(Token = "0x4000979")]
	[FieldOffset(Offset = "0x28")]
	public AnimationRunner Runner;

	// Token: 0x0400097A RID: 2426
	[Token(Token = "0x400097A")]
	[FieldOffset(Offset = "0x30")]
	public Follow Follow;
}
