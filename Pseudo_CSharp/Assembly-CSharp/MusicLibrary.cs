using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000AE RID: 174
[Token(Token = "0x20000AE")]
public class MusicLibrary : ScriptableObject, ILoadable
{
	// Token: 0x06000301 RID: 769 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000301")]
	[Address(RVA = "0x340DE0", Offset = "0x33FFE0", VA = "0x180340DE0")]
	public MusicSet Get(string label)
	{
		return null;
	}

	// Token: 0x06000302 RID: 770 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000302")]
	[Address(RVA = "0x340E80", Offset = "0x340080", VA = "0x180340E80", Slot = "4")]
	public void Load()
	{
	}

	// Token: 0x06000303 RID: 771 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000303")]
	[Address(RVA = "0x340FB0", Offset = "0x3401B0", VA = "0x180340FB0")]
	public MusicLibrary()
	{
	}

	// Token: 0x040002EC RID: 748
	[Token(Token = "0x40002EC")]
	[FieldOffset(Offset = "0x18")]
	public MusicSet[] MusicSets;

	// Token: 0x040002ED RID: 749
	[Token(Token = "0x40002ED")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<string, MusicSet> s_musicSetMap;
}
