using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001EC RID: 492
[Token(Token = "0x20001EC")]
public class Prestige : MonoBehaviour
{
	// Token: 0x06000A24 RID: 2596 RVA: 0x000049E0 File Offset: 0x00002BE0
	[Token(Token = "0x6000A24")]
	[Address(RVA = "0x42CDE0", Offset = "0x42BFE0", VA = "0x18042CDE0")]
	public static int GetPrestigeIndex(int prestige)
	{
		return 0;
	}

	// Token: 0x06000A25 RID: 2597 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A25")]
	[Address(RVA = "0x4283E0", Offset = "0x4275E0", VA = "0x1804283E0")]
	public void SetHeight(float height)
	{
	}

	// Token: 0x06000A26 RID: 2598 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A26")]
	[Address(RVA = "0x42CF60", Offset = "0x42C160", VA = "0x18042CF60")]
	public void Setup(Transform target, float height, int prestige)
	{
	}

	// Token: 0x06000A27 RID: 2599 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A27")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public Prestige()
	{
	}

	// Token: 0x0400096A RID: 2410
	[Token(Token = "0x400096A")]
	[FieldOffset(Offset = "0x20")]
	public Follow Follow;

	// Token: 0x0400096B RID: 2411
	[Token(Token = "0x400096B")]
	[FieldOffset(Offset = "0x28")]
	public SpriteRenderer SpriteRenderer;
}
