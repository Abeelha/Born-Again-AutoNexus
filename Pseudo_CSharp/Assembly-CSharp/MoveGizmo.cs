using System;
using Il2CppDummyDll;
using Ronin.Model.Simulation;
using UnityEngine;

// Token: 0x0200024C RID: 588
[Token(Token = "0x200024C")]
public class MoveGizmo : Gizmo
{
	// Token: 0x06000B13 RID: 2835 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B13")]
	[Address(RVA = "0x43AE20", Offset = "0x43A020", VA = "0x18043AE20", Slot = "4")]
	protected override void SetCoordinates(Vector2 coordinates, Vector2 target, Simulation simulation)
	{
	}

	// Token: 0x06000B14 RID: 2836 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B14")]
	[Address(RVA = "0x316090", Offset = "0x315290", VA = "0x180316090", Slot = "5")]
	protected override void Setup()
	{
	}

	// Token: 0x06000B15 RID: 2837 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B15")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public MoveGizmo()
	{
	}

	// Token: 0x040009D2 RID: 2514
	[Token(Token = "0x40009D2")]
	[FieldOffset(Offset = "0x60")]
	public SpriteRenderer Renderer;

	// Token: 0x040009D3 RID: 2515
	[Token(Token = "0x40009D3")]
	[FieldOffset(Offset = "0x68")]
	public LineIndicator LineIndicator;
}
