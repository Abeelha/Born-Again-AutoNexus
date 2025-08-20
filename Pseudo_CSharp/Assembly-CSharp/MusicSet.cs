using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200013D RID: 317
[Token(Token = "0x200013D")]
[Serializable]
public class MusicSet
{
	// Token: 0x0600059A RID: 1434 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600059A")]
	[Address(RVA = "0x3F1C70", Offset = "0x3F0E70", VA = "0x1803F1C70")]
	public MusicSet()
	{
	}

	// Token: 0x0400060A RID: 1546
	[Token(Token = "0x400060A")]
	[FieldOffset(Offset = "0x10")]
	public string Label;

	// Token: 0x0400060B RID: 1547
	[Token(Token = "0x400060B")]
	[FieldOffset(Offset = "0x18")]
	public float Volume;

	// Token: 0x0400060C RID: 1548
	[Token(Token = "0x400060C")]
	[FieldOffset(Offset = "0x20")]
	public AudioClip Intro;

	// Token: 0x0400060D RID: 1549
	[Token(Token = "0x400060D")]
	[FieldOffset(Offset = "0x28")]
	public AudioClip[] LoopLayers;
}
