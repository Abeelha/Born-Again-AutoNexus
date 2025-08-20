using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000A2 RID: 162
[Token(Token = "0x20000A2")]
public class CursorLibrary : ScriptableObject
{
	// Token: 0x060002E2 RID: 738 RVA: 0x000030C0 File Offset: 0x000012C0
	[Token(Token = "0x60002E2")]
	[Address(RVA = "0x333ED0", Offset = "0x3330D0", VA = "0x180333ED0")]
	public CursorLibrary.CursorDefinition Get(int index)
	{
		return default(CursorLibrary.CursorDefinition);
	}

	// Token: 0x060002E3 RID: 739 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002E3")]
	[Address(RVA = "0x333FD0", Offset = "0x3331D0", VA = "0x180333FD0")]
	public CursorLibrary()
	{
	}

	// Token: 0x040002C2 RID: 706
	[Token(Token = "0x40002C2")]
	[FieldOffset(Offset = "0x18")]
	public CursorLibrary.CursorDefinition[] Cursors;

	// Token: 0x020000A3 RID: 163
	[Token(Token = "0x20000A3")]
	[Serializable]
	public struct CursorDefinition
	{
		// Token: 0x040002C3 RID: 707
		[Token(Token = "0x40002C3")]
		[FieldOffset(Offset = "0x0")]
		public Texture2D Texture;

		// Token: 0x040002C4 RID: 708
		[Token(Token = "0x40002C4")]
		[FieldOffset(Offset = "0x8")]
		public Vector2 Hotspot;
	}
}
