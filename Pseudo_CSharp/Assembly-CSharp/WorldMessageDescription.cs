using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000179 RID: 377
[Token(Token = "0x2000179")]
public struct WorldMessageDescription
{
	// Token: 0x04000769 RID: 1897
	[Token(Token = "0x4000769")]
	[FieldOffset(Offset = "0x0")]
	public string Message;

	// Token: 0x0400076A RID: 1898
	[Token(Token = "0x400076A")]
	[FieldOffset(Offset = "0x8")]
	public SfxClip Sfx;

	// Token: 0x0400076B RID: 1899
	[Token(Token = "0x400076B")]
	[FieldOffset(Offset = "0x10")]
	public float Alpha;

	// Token: 0x0400076C RID: 1900
	[Token(Token = "0x400076C")]
	[FieldOffset(Offset = "0x14")]
	public float Scale;

	// Token: 0x0400076D RID: 1901
	[Token(Token = "0x400076D")]
	[FieldOffset(Offset = "0x18")]
	public Color Color;

	// Token: 0x0400076E RID: 1902
	[Token(Token = "0x400076E")]
	[FieldOffset(Offset = "0x28")]
	public Vector3 Offset;

	// Token: 0x0400076F RID: 1903
	[Token(Token = "0x400076F")]
	[FieldOffset(Offset = "0x34")]
	public bool Important;
}
