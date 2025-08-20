using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Ronin.Model.Definitions;
using UnityEngine;

// Token: 0x0200026D RID: 621
[Token(Token = "0x200026D")]
public class CeilingReveal
{
	// Token: 0x06000BF6 RID: 3062 RVA: 0x00004FB0 File Offset: 0x000031B0
	[Token(Token = "0x6000BF6")]
	[Address(RVA = "0x4351C0", Offset = "0x4343C0", VA = "0x1804351C0")]
	public float GetAlpha(Vector2 position, Vector2Int point)
	{
		return 0f;
	}

	// Token: 0x06000BF7 RID: 3063 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000BF7")]
	[Address(RVA = "0x435280", Offset = "0x434480", VA = "0x180435280")]
	public IReveal GetGroup(Vector2Int point)
	{
		return null;
	}

	// Token: 0x06000BF8 RID: 3064 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BF8")]
	[Address(RVA = "0x435600", Offset = "0x434800", VA = "0x180435600")]
	public void UpdateReveal(int x, int y, ushort type)
	{
	}

	// Token: 0x06000BF9 RID: 3065 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BF9")]
	[Address(RVA = "0x434BF0", Offset = "0x433DF0", VA = "0x180434BF0")]
	private void AddPoint(Vector2Int point, CeilingDefinition definition)
	{
	}

	// Token: 0x06000BFA RID: 3066 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000BFA")]
	[Address(RVA = "0x435300", Offset = "0x434500", VA = "0x180435300")]
	private HashSet<IReveal> GetNeighboringGroups(Vector2Int point, ushort type)
	{
		return null;
	}

	// Token: 0x06000BFB RID: 3067 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BFB")]
	[Address(RVA = "0x435460", Offset = "0x434660", VA = "0x180435460")]
	private void RemovePoint(Vector2Int point)
	{
	}

	// Token: 0x06000BFC RID: 3068 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000BFC")]
	[Address(RVA = "0x435520", Offset = "0x434720", VA = "0x180435520")]
	private CeilingDefinition ResolveDefinition(ushort type)
	{
		return null;
	}

	// Token: 0x06000BFD RID: 3069 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BFD")]
	[Address(RVA = "0x435800", Offset = "0x434A00", VA = "0x180435800")]
	public CeilingReveal()
	{
	}

	// Token: 0x04000A96 RID: 2710
	[Token(Token = "0x4000A96")]
	[FieldOffset(Offset = "0x10")]
	private readonly Dictionary<Vector2Int, IReveal> _revealGroups;

	// Token: 0x04000A97 RID: 2711
	[Token(Token = "0x4000A97")]
	[FieldOffset(Offset = "0x18")]
	private readonly HashSet<IReveal> _groupList;
}
