using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Ronin.Model.Definitions;
using UnityEngine;

// Token: 0x0200026F RID: 623
[Token(Token = "0x200026F")]
public class RevealGroup : IReveal
{
	// Token: 0x06000C08 RID: 3080 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C08")]
	[Address(RVA = "0x43E890", Offset = "0x43DA90", VA = "0x18043E890")]
	public RevealGroup(Vector2Int point, CeilingDefinition definition)
	{
	}

	// Token: 0x17000121 RID: 289
	// (get) Token: 0x06000C09 RID: 3081 RVA: 0x00004FC8 File Offset: 0x000031C8
	[Token(Token = "0x17000121")]
	public ushort Type
	{
		[Token(Token = "0x6000C09")]
		[Address(RVA = "0x43E990", Offset = "0x43DB90", VA = "0x18043E990", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000122 RID: 290
	// (get) Token: 0x06000C0A RID: 3082 RVA: 0x00004FE0 File Offset: 0x000031E0
	// (set) Token: 0x06000C0B RID: 3083 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000122")]
	public float Time
	{
		[Token(Token = "0x6000C0A")]
		[Address(RVA = "0x43E980", Offset = "0x43DB80", VA = "0x18043E980", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000C0B")]
		[Address(RVA = "0x43E9A0", Offset = "0x43DBA0", VA = "0x18043E9A0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x17000123 RID: 291
	// (get) Token: 0x06000C0C RID: 3084 RVA: 0x00004FF8 File Offset: 0x000031F8
	// (set) Token: 0x06000C0D RID: 3085 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000123")]
	public bool Cleared
	{
		[Token(Token = "0x6000C0C")]
		[Address(RVA = "0x3ACC20", Offset = "0x3ABE20", VA = "0x1803ACC20", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000C0D")]
		[Address(RVA = "0x3ACC30", Offset = "0x3ABE30", VA = "0x1803ACC30", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x17000124 RID: 292
	// (get) Token: 0x06000C0E RID: 3086 RVA: 0x00005010 File Offset: 0x00003210
	[Token(Token = "0x17000124")]
	public bool CanAdd
	{
		[Token(Token = "0x6000C0E")]
		[Address(RVA = "0x3423A0", Offset = "0x3415A0", VA = "0x1803423A0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000C0F RID: 3087 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C0F")]
	[Address(RVA = "0x43E520", Offset = "0x43D720", VA = "0x18043E520", Slot = "10")]
	public void Add(Vector2Int point)
	{
	}

	// Token: 0x06000C10 RID: 3088 RVA: 0x00005028 File Offset: 0x00003228
	[Token(Token = "0x6000C10")]
	[Address(RVA = "0x43E580", Offset = "0x43D780", VA = "0x18043E580", Slot = "11")]
	public float GetAlpha(Vector2 referencePoint)
	{
		return 0f;
	}

	// Token: 0x06000C11 RID: 3089 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000C11")]
	[Address(RVA = "0x3328E0", Offset = "0x331AE0", VA = "0x1803328E0", Slot = "12")]
	public IEnumerable<Vector2Int> GetPoints()
	{
		return null;
	}

	// Token: 0x06000C12 RID: 3090 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C12")]
	[Address(RVA = "0x43E830", Offset = "0x43DA30", VA = "0x18043E830", Slot = "13")]
	public void Remove(Vector2Int point)
	{
	}

	// Token: 0x04000A98 RID: 2712
	[Token(Token = "0x4000A98")]
	[FieldOffset(Offset = "0x10")]
	private readonly HashSet<Vector2Int> _points;

	// Token: 0x04000A99 RID: 2713
	[Token(Token = "0x4000A99")]
	[FieldOffset(Offset = "0x18")]
	private readonly CeilingDefinition _definition;

	// Token: 0x04000A9A RID: 2714
	[Token(Token = "0x4000A9A")]
	[FieldOffset(Offset = "0x20")]
	private float _lastAlpha;

	// Token: 0x04000A9B RID: 2715
	[Token(Token = "0x4000A9B")]
	[FieldOffset(Offset = "0x24")]
	private Vector2 _position;
}
