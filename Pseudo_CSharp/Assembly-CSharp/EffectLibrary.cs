using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000A4 RID: 164
[Token(Token = "0x20000A4")]
public class EffectLibrary : ScriptableObject, ILoadable
{
	// Token: 0x060002E4 RID: 740 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002E4")]
	[Address(RVA = "0x33A370", Offset = "0x339570", VA = "0x18033A370", Slot = "4")]
	public void Load()
	{
	}

	// Token: 0x060002E5 RID: 741 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002E5")]
	[Address(RVA = "0x333FD0", Offset = "0x3331D0", VA = "0x180333FD0")]
	public EffectLibrary()
	{
	}

	// Token: 0x040002C5 RID: 709
	[Token(Token = "0x40002C5")]
	[FieldOffset(Offset = "0x18")]
	public EffectBase[] Effects;
}
