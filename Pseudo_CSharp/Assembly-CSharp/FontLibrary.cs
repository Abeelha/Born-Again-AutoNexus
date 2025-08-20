using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x020000A6 RID: 166
[Token(Token = "0x20000A6")]
public class FontLibrary : ScriptableObject
{
	// Token: 0x060002E9 RID: 745 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002E9")]
	[Address(RVA = "0x333FD0", Offset = "0x3331D0", VA = "0x180333FD0")]
	public FontLibrary()
	{
	}

	// Token: 0x040002C8 RID: 712
	[Token(Token = "0x40002C8")]
	[FieldOffset(Offset = "0x18")]
	public FontLibrary.FontPair Scroll;

	// Token: 0x040002C9 RID: 713
	[Token(Token = "0x40002C9")]
	[FieldOffset(Offset = "0x28")]
	public FontLibrary.FontPair ScrollOutline;

	// Token: 0x040002CA RID: 714
	[Token(Token = "0x40002CA")]
	[FieldOffset(Offset = "0x38")]
	public FontLibrary.FontPair Main;

	// Token: 0x040002CB RID: 715
	[Token(Token = "0x40002CB")]
	[FieldOffset(Offset = "0x48")]
	public FontLibrary.FontPair MainOutline;

	// Token: 0x020000A7 RID: 167
	[Token(Token = "0x20000A7")]
	[Serializable]
	public struct FontPair
	{
		// Token: 0x040002CC RID: 716
		[Token(Token = "0x40002CC")]
		[FieldOffset(Offset = "0x0")]
		public TMP_FontAsset Font;

		// Token: 0x040002CD RID: 717
		[Token(Token = "0x40002CD")]
		[FieldOffset(Offset = "0x8")]
		public Material Material;
	}
}
