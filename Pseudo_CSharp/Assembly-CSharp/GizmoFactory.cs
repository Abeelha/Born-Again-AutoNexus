using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Ronin.Model.Definitions;
using Ronin.Model.GameActions;

// Token: 0x02000074 RID: 116
[Token(Token = "0x2000074")]
public static class GizmoFactory
{
	// Token: 0x060001E0 RID: 480 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60001E0")]
	[Address(RVA = "0x33AB30", Offset = "0x339D30", VA = "0x18033AB30")]
	public static IEnumerable<ValueTuple<GameAction, uint>> FlattenWithTime(this GameAction[] actions, ObjectDefinition definition)
	{
		return null;
	}

	// Token: 0x060001E1 RID: 481 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60001E1")]
	[Address(RVA = "0x33ABC0", Offset = "0x339DC0", VA = "0x18033ABC0")]
	public static List<Gizmo> GetGizmoList(ItemDefinition definition)
	{
		return null;
	}

	// Token: 0x060001E2 RID: 482 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60001E2")]
	[Address(RVA = "0x33B980", Offset = "0x33AB80", VA = "0x18033B980")]
	private static IEnumerable<Gizmo> GetGizmos(GizmoDefinition gizmoDefinition, byte totalMagnitude)
	{
		return null;
	}

	// Token: 0x060001E3 RID: 483 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60001E3")]
	[Address(RVA = "0x33B830", Offset = "0x33AA30", VA = "0x18033B830")]
	private static Gizmo GetGizmo(GizmoType type)
	{
		return null;
	}

	// Token: 0x060001E4 RID: 484 RVA: 0x00002910 File Offset: 0x00000B10
	[Token(Token = "0x60001E4")]
	[Address(RVA = "0x33B3C0", Offset = "0x33A5C0", VA = "0x18033B3C0")]
	private static GizmoDefinition GetGizmoType(GameAction gameAction, uint time, ObjectDefinition definition)
	{
		return default(GizmoDefinition);
	}

	// Token: 0x060001E5 RID: 485 RVA: 0x00002928 File Offset: 0x00000B28
	[Token(Token = "0x60001E5")]
	[Address(RVA = "0x33B110", Offset = "0x33A310", VA = "0x18033B110")]
	private static GizmoDefinition GetGizmoTypeAttack(AttackGameAction attackGameAction, uint time, ObjectDefinition definition)
	{
		return default(GizmoDefinition);
	}
}
