using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000024 RID: 36
[Token(Token = "0x2000024")]
[Serializable]
public class BackgroundDefinition
{
	// Token: 0x060000D7 RID: 215 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x316100", Offset = "0x315300", VA = "0x180316100")]
	public BackgroundDefinition()
	{
	}

	// Token: 0x040000B5 RID: 181
	[Token(Token = "0x40000B5")]
	[FieldOffset(Offset = "0x10")]
	public string Key;

	// Token: 0x040000B6 RID: 182
	[Token(Token = "0x40000B6")]
	[FieldOffset(Offset = "0x18")]
	public Texture Background;

	// Token: 0x040000B7 RID: 183
	[Token(Token = "0x40000B7")]
	[FieldOffset(Offset = "0x20")]
	public Texture BackgroundDetails;
}
