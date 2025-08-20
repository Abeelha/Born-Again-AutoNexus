using System;
using Il2CppDummyDll;
using Ronin.Model.Simulation;
using UnityEngine;

// Token: 0x0200024D RID: 589
[Token(Token = "0x200024D")]
public class ProjectileGizmo : Gizmo
{
	// Token: 0x06000B16 RID: 2838 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B16")]
	[Address(RVA = "0x43E2C0", Offset = "0x43D4C0", VA = "0x18043E2C0", Slot = "4")]
	protected override void SetCoordinates(Vector2 coordinates, Vector2 target, Simulation simulation)
	{
	}

	// Token: 0x06000B17 RID: 2839 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B17")]
	[Address(RVA = "0x316090", Offset = "0x315290", VA = "0x180316090", Slot = "5")]
	protected override void Setup()
	{
	}

	// Token: 0x06000B18 RID: 2840 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B18")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public ProjectileGizmo()
	{
	}

	// Token: 0x040009D4 RID: 2516
	[Token(Token = "0x40009D4")]
	[FieldOffset(Offset = "0x60")]
	public SpriteRenderer Renderer;

	// Token: 0x040009D5 RID: 2517
	[Token(Token = "0x40009D5")]
	[FieldOffset(Offset = "0x68")]
	public LineIndicator LineIndicator;
}
