using System;
using Il2CppDummyDll;
using Ronin.Model.Simulation;
using UnityEngine;

// Token: 0x0200024E RID: 590
[Token(Token = "0x200024E")]
public class SlashGizmo : Gizmo
{
	// Token: 0x06000B19 RID: 2841 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B19")]
	[Address(RVA = "0x43EBD0", Offset = "0x43DDD0", VA = "0x18043EBD0", Slot = "4")]
	protected override void SetCoordinates(Vector2 coordinates, Vector2 target, Simulation simulation)
	{
	}

	// Token: 0x06000B1A RID: 2842 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B1A")]
	[Address(RVA = "0x316090", Offset = "0x315290", VA = "0x180316090", Slot = "5")]
	protected override void Setup()
	{
	}

	// Token: 0x06000B1B RID: 2843 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B1B")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public SlashGizmo()
	{
	}

	// Token: 0x040009D6 RID: 2518
	[Token(Token = "0x40009D6")]
	[FieldOffset(Offset = "0x60")]
	public Color Color;

	// Token: 0x040009D7 RID: 2519
	[Token(Token = "0x40009D7")]
	[FieldOffset(Offset = "0x70")]
	public SlashIndicator SlashIndicator;
}
