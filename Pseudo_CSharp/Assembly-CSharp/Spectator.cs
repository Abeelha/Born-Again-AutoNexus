using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001EE RID: 494
[Token(Token = "0x20001EE")]
public class Spectator : MonoBehaviour
{
	// Token: 0x06000A31 RID: 2609 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A31")]
	[Address(RVA = "0x42FDC0", Offset = "0x42EFC0", VA = "0x18042FDC0")]
	public void Setup(Transform transform)
	{
	}

	// Token: 0x06000A32 RID: 2610 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A32")]
	[Address(RVA = "0x42FDE0", Offset = "0x42EFE0", VA = "0x18042FDE0")]
	private void Update()
	{
	}

	// Token: 0x06000A33 RID: 2611 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A33")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public Spectator()
	{
	}

	// Token: 0x04000972 RID: 2418
	[Token(Token = "0x4000972")]
	[FieldOffset(Offset = "0x20")]
	public float WaveFrequency;

	// Token: 0x04000973 RID: 2419
	[Token(Token = "0x4000973")]
	[FieldOffset(Offset = "0x24")]
	public float WaveAmplitude;

	// Token: 0x04000974 RID: 2420
	[Token(Token = "0x4000974")]
	[FieldOffset(Offset = "0x28")]
	public Follow Follow;
}
