using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000AA RID: 170
[Token(Token = "0x20000AA")]
public class MapObjectLibrary : ScriptableObject, ILoadable
{
	// Token: 0x060002F2 RID: 754 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002F2")]
	[Address(RVA = "0x33F840", Offset = "0x33EA40", VA = "0x18033F840", Slot = "4")]
	public void Load()
	{
	}

	// Token: 0x060002F3 RID: 755 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002F3")]
	[Address(RVA = "0x333FD0", Offset = "0x3331D0", VA = "0x180333FD0")]
	public MapObjectLibrary()
	{
	}

	// Token: 0x040002D2 RID: 722
	[Token(Token = "0x40002D2")]
	[FieldOffset(Offset = "0x18")]
	public GameObject[] MapObjects;
}
