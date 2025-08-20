using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000234 RID: 564
[Token(Token = "0x2000234")]
public class SlashEffect : BurstEffectBase
{
	// Token: 0x06000AC3 RID: 2755 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AC3")]
	[Address(RVA = "0x42F110", Offset = "0x42E310", VA = "0x18042F110")]
	public void Setup(World world, Attack attack, float opacity)
	{
	}

	// Token: 0x06000AC4 RID: 2756 RVA: 0x00004AE8 File Offset: 0x00002CE8
	[Token(Token = "0x6000AC4")]
	[Address(RVA = "0x42F0E0", Offset = "0x42E2E0", VA = "0x18042F0E0", Slot = "8")]
	protected override bool IsEffectDone()
	{
		return default(bool);
	}

	// Token: 0x06000AC5 RID: 2757 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AC5")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public SlashEffect()
	{
	}

	// Token: 0x040009B1 RID: 2481
	[Token(Token = "0x40009B1")]
	[FieldOffset(Offset = "0x50")]
	private float _startTime;

	// Token: 0x040009B2 RID: 2482
	[Token(Token = "0x40009B2")]
	[FieldOffset(Offset = "0x58")]
	public Follow Follow;

	// Token: 0x040009B3 RID: 2483
	[Token(Token = "0x40009B3")]
	[FieldOffset(Offset = "0x60")]
	public MeshFilter MeshFilter;

	// Token: 0x040009B4 RID: 2484
	[Token(Token = "0x40009B4")]
	[FieldOffset(Offset = "0x68")]
	public MeshRenderer MeshRenderer;
}
