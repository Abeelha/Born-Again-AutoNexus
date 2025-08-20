using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000A9 RID: 169
[Token(Token = "0x20000A9")]
public class LightLibrary : ScriptableObject, ILoadable
{
	// Token: 0x060002F0 RID: 752 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002F0")]
	[Address(RVA = "0x33F310", Offset = "0x33E510", VA = "0x18033F310", Slot = "4")]
	public void Load()
	{
	}

	// Token: 0x060002F1 RID: 753 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002F1")]
	[Address(RVA = "0x333FD0", Offset = "0x3331D0", VA = "0x180333FD0")]
	public LightLibrary()
	{
	}

	// Token: 0x040002D1 RID: 721
	[Token(Token = "0x40002D1")]
	[FieldOffset(Offset = "0x18")]
	public global::Light[] Lights;
}
