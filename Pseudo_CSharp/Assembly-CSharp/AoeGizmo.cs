using System;
using Il2CppDummyDll;
using Ronin.Model.Simulation;
using Ronin.Model.Simulation.Interpolators;
using UnityEngine;

// Token: 0x02000248 RID: 584
[Token(Token = "0x2000248")]
public class AoeGizmo : Gizmo
{
	// Token: 0x06000AEF RID: 2799 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AEF")]
	[Address(RVA = "0x433E00", Offset = "0x433000", VA = "0x180433E00", Slot = "4")]
	protected override void SetCoordinates(Vector2 coordinates, Vector2 target, Simulation simulation)
	{
	}

	// Token: 0x06000AF0 RID: 2800 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AF0")]
	[Address(RVA = "0x434010", Offset = "0x433210", VA = "0x180434010", Slot = "5")]
	protected override void Setup()
	{
	}

	// Token: 0x06000AF1 RID: 2801 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AF1")]
	[Address(RVA = "0x433CE0", Offset = "0x432EE0", VA = "0x180433CE0")]
	private void OnDisable()
	{
	}

	// Token: 0x06000AF2 RID: 2802 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AF2")]
	[Address(RVA = "0x433D60", Offset = "0x432F60", VA = "0x180433D60")]
	private void OnEnable()
	{
	}

	// Token: 0x06000AF3 RID: 2803 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AF3")]
	[Address(RVA = "0x4341B0", Offset = "0x4333B0", VA = "0x1804341B0")]
	public AoeGizmo()
	{
	}

	// Token: 0x040009BF RID: 2495
	[Token(Token = "0x40009BF")]
	[FieldOffset(Offset = "0x60")]
	public Color Color;

	// Token: 0x040009C0 RID: 2496
	[Token(Token = "0x40009C0")]
	[FieldOffset(Offset = "0x70")]
	private CircleIndicator _indicator;

	// Token: 0x040009C1 RID: 2497
	[Token(Token = "0x40009C1")]
	[FieldOffset(Offset = "0x78")]
	private ForceInterpolator _emptyForce;
}
