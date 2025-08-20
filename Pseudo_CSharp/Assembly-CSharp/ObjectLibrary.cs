using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000B0 RID: 176
[Token(Token = "0x20000B0")]
public class ObjectLibrary : ScriptableObject, ILoadable
{
	// Token: 0x06000307 RID: 775 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000307")]
	[Address(RVA = "0x341480", Offset = "0x340680", VA = "0x180341480", Slot = "4")]
	public void Load()
	{
	}

	// Token: 0x06000308 RID: 776 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000308")]
	[Address(RVA = "0x333FD0", Offset = "0x3331D0", VA = "0x180333FD0")]
	public ObjectLibrary()
	{
	}

	// Token: 0x040002F0 RID: 752
	[Token(Token = "0x40002F0")]
	[FieldOffset(Offset = "0x18")]
	public MonoBehaviour[] Objects;
}
