using System;
using Il2CppDummyDll;
using Ronin.Model.Simulation;
using UnityEngine;

// Token: 0x02000249 RID: 585
[Token(Token = "0x2000249")]
public class ForceGizmo : Gizmo
{
	// Token: 0x06000AF4 RID: 2804 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AF4")]
	[Address(RVA = "0x438310", Offset = "0x437510", VA = "0x180438310", Slot = "4")]
	protected override void SetCoordinates(Vector2 coordinates, Vector2 target, Simulation simulation)
	{
	}

	// Token: 0x06000AF5 RID: 2805 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AF5")]
	[Address(RVA = "0x438380", Offset = "0x437580", VA = "0x180438380", Slot = "5")]
	protected override void Setup()
	{
	}

	// Token: 0x06000AF6 RID: 2806 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AF6")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public ForceGizmo()
	{
	}

	// Token: 0x040009C2 RID: 2498
	[Token(Token = "0x40009C2")]
	[FieldOffset(Offset = "0x60")]
	public SpriteRenderer MagnitudeRenderer;
}
