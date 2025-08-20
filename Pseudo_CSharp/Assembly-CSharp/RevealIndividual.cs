using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Ronin.Model.Definitions;
using UnityEngine;

// Token: 0x02000270 RID: 624
[Token(Token = "0x2000270")]
public class RevealIndividual : IReveal
{
	// Token: 0x06000C13 RID: 3091 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C13")]
	[Address(RVA = "0x43EB60", Offset = "0x43DD60", VA = "0x18043EB60")]
	public RevealIndividual(Vector2Int point, CeilingDefinition definition)
	{
	}

	// Token: 0x17000125 RID: 293
	// (get) Token: 0x06000C14 RID: 3092 RVA: 0x00005040 File Offset: 0x00003240
	[Token(Token = "0x17000125")]
	public ushort Type
	{
		[Token(Token = "0x6000C14")]
		[Address(RVA = "0x43EBC0", Offset = "0x43DDC0", VA = "0x18043EBC0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000126 RID: 294
	// (get) Token: 0x06000C15 RID: 3093 RVA: 0x00005058 File Offset: 0x00003258
	// (set) Token: 0x06000C16 RID: 3094 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000126")]
	public float Time
	{
		[Token(Token = "0x6000C15")]
		[Address(RVA = "0x31B6C0", Offset = "0x31A8C0", VA = "0x18031B6C0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000C16")]
		[Address(RVA = "0x3854F0", Offset = "0x3846F0", VA = "0x1803854F0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x17000127 RID: 295
	// (get) Token: 0x06000C17 RID: 3095 RVA: 0x00005070 File Offset: 0x00003270
	// (set) Token: 0x06000C18 RID: 3096 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000127")]
	public bool Cleared
	{
		[Token(Token = "0x6000C17")]
		[Address(RVA = "0x436E80", Offset = "0x436080", VA = "0x180436E80", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000C18")]
		[Address(RVA = "0x436D50", Offset = "0x435F50", VA = "0x180436D50", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x17000128 RID: 296
	// (get) Token: 0x06000C19 RID: 3097 RVA: 0x00005088 File Offset: 0x00003288
	[Token(Token = "0x17000128")]
	public bool CanAdd
	{
		[Token(Token = "0x6000C19")]
		[Address(RVA = "0x316110", Offset = "0x315310", VA = "0x180316110", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000C1A RID: 3098 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C1A")]
	[Address(RVA = "0x316090", Offset = "0x315290", VA = "0x180316090", Slot = "10")]
	public void Add(Vector2Int point)
	{
	}

	// Token: 0x06000C1B RID: 3099 RVA: 0x000050A0 File Offset: 0x000032A0
	[Token(Token = "0x6000C1B")]
	[Address(RVA = "0x43E9B0", Offset = "0x43DBB0", VA = "0x18043E9B0", Slot = "11")]
	public float GetAlpha(Vector2 referencePoint)
	{
		return 0f;
	}

	// Token: 0x06000C1C RID: 3100 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000C1C")]
	[Address(RVA = "0x43EAE0", Offset = "0x43DCE0", VA = "0x18043EAE0", Slot = "12")]
	public IEnumerable<Vector2Int> GetPoints()
	{
		return null;
	}

	// Token: 0x06000C1D RID: 3101 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C1D")]
	[Address(RVA = "0x316090", Offset = "0x315290", VA = "0x180316090", Slot = "13")]
	public void Remove(Vector2Int point)
	{
	}

	// Token: 0x04000A9F RID: 2719
	[Token(Token = "0x4000A9F")]
	[FieldOffset(Offset = "0x10")]
	private readonly Vector2Int _point;

	// Token: 0x04000AA0 RID: 2720
	[Token(Token = "0x4000AA0")]
	[FieldOffset(Offset = "0x18")]
	private readonly CeilingDefinition _definition;
}
