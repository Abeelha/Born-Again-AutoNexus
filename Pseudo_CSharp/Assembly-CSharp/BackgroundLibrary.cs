using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200009C RID: 156
[Token(Token = "0x200009C")]
public class BackgroundLibrary : ScriptableObject, ILoadable
{
	// Token: 0x060002D4 RID: 724 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60002D4")]
	[Address(RVA = "0x331840", Offset = "0x330A40", VA = "0x180331840")]
	public BackgroundDefinition Get(string key)
	{
		return null;
	}

	// Token: 0x060002D5 RID: 725 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002D5")]
	[Address(RVA = "0x3318C0", Offset = "0x330AC0", VA = "0x1803318C0", Slot = "4")]
	public void Load()
	{
	}

	// Token: 0x060002D6 RID: 726 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002D6")]
	[Address(RVA = "0x331A20", Offset = "0x330C20", VA = "0x180331A20")]
	public BackgroundLibrary()
	{
	}

	// Token: 0x04000281 RID: 641
	[Token(Token = "0x4000281")]
	[FieldOffset(Offset = "0x18")]
	public BackgroundDefinition[] Backgrounds;

	// Token: 0x04000282 RID: 642
	[Token(Token = "0x4000282")]
	[FieldOffset(Offset = "0x20")]
	private BackgroundDefinition s_default;

	// Token: 0x04000283 RID: 643
	[Token(Token = "0x4000283")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<string, BackgroundDefinition> s_backgrounds;
}
