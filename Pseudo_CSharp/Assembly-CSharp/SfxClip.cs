using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200016C RID: 364
[Token(Token = "0x200016C")]
[Serializable]
public class SfxClip
{
	// Token: 0x0600072D RID: 1837 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600072D")]
	[Address(RVA = "0x3FA680", Offset = "0x3F9880", VA = "0x1803FA680")]
	public SfxClip()
	{
	}

	// Token: 0x04000724 RID: 1828
	[Token(Token = "0x4000724")]
	[FieldOffset(Offset = "0x10")]
	public string Label;

	// Token: 0x04000725 RID: 1829
	[Token(Token = "0x4000725")]
	[FieldOffset(Offset = "0x18")]
	public int ServerId;

	// Token: 0x04000726 RID: 1830
	[Token(Token = "0x4000726")]
	[FieldOffset(Offset = "0x20")]
	public AudioClip[] Clips;

	// Token: 0x04000727 RID: 1831
	[Token(Token = "0x4000727")]
	[FieldOffset(Offset = "0x28")]
	public float Pitch;

	// Token: 0x04000728 RID: 1832
	[Token(Token = "0x4000728")]
	[FieldOffset(Offset = "0x2C")]
	public float Volume;

	// Token: 0x04000729 RID: 1833
	[Token(Token = "0x4000729")]
	[FieldOffset(Offset = "0x30")]
	public bool Falloff;

	// Token: 0x0400072A RID: 1834
	[Token(Token = "0x400072A")]
	[FieldOffset(Offset = "0x34")]
	public float FalloffScalar;

	// Token: 0x0400072B RID: 1835
	[Token(Token = "0x400072B")]
	[FieldOffset(Offset = "0x38")]
	public bool Loop;

	// Token: 0x0400072C RID: 1836
	[Token(Token = "0x400072C")]
	[FieldOffset(Offset = "0x3C")]
	public int MaxConcurrent;
}
