using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000B1 RID: 177
[Token(Token = "0x20000B1")]
public class SfxLibrary : ScriptableObject, ILoadable
{
	// Token: 0x06000309 RID: 777 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000309")]
	[Address(RVA = "0x342CF0", Offset = "0x341EF0", VA = "0x180342CF0")]
	public SfxClip Get(string label)
	{
		return null;
	}

	// Token: 0x0600030A RID: 778 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600030A")]
	[Address(RVA = "0x342C70", Offset = "0x341E70", VA = "0x180342C70")]
	public SfxClip Get(int serverId)
	{
		return null;
	}

	// Token: 0x0600030B RID: 779 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600030B")]
	[Address(RVA = "0x342D70", Offset = "0x341F70", VA = "0x180342D70", Slot = "4")]
	public void Load()
	{
	}

	// Token: 0x0600030C RID: 780 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600030C")]
	[Address(RVA = "0x3432A0", Offset = "0x3424A0", VA = "0x1803432A0")]
	public SfxLibrary()
	{
	}

	// Token: 0x040002F1 RID: 753
	[Token(Token = "0x40002F1")]
	[FieldOffset(Offset = "0x18")]
	public SfxLibrary.SfxGroup[] SfxGroups;

	// Token: 0x040002F2 RID: 754
	[Token(Token = "0x40002F2")]
	[FieldOffset(Offset = "0x20")]
	private readonly Dictionary<string, SfxClip> s_clips;

	// Token: 0x040002F3 RID: 755
	[Token(Token = "0x40002F3")]
	[FieldOffset(Offset = "0x28")]
	private readonly Dictionary<int, SfxClip> s_serverClips;

	// Token: 0x020000B2 RID: 178
	[Token(Token = "0x20000B2")]
	[Serializable]
	public struct SfxGroup
	{
		// Token: 0x040002F4 RID: 756
		[Token(Token = "0x40002F4")]
		[FieldOffset(Offset = "0x0")]
		public string Name;

		// Token: 0x040002F5 RID: 757
		[Token(Token = "0x40002F5")]
		[FieldOffset(Offset = "0x8")]
		public SfxClip[] Sfx;
	}
}
