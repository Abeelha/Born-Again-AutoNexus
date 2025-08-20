using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Ronin.Model.Simulation;
using UnityEngine;
using Zero.Game.Shared;

// Token: 0x0200024A RID: 586
[Token(Token = "0x200024A")]
public abstract class Gizmo : MonoBehaviour
{
	// Token: 0x17000106 RID: 262
	// (get) Token: 0x06000AF7 RID: 2807 RVA: 0x00004BA8 File Offset: 0x00002DA8
	// (set) Token: 0x06000AF8 RID: 2808 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000106")]
	private protected GizmoDefinition Definition
	{
		[Token(Token = "0x6000AF7")]
		[Address(RVA = "0x438740", Offset = "0x437940", VA = "0x180438740")]
		[CompilerGenerated]
		protected get
		{
			return default(GizmoDefinition);
		}
		[Token(Token = "0x6000AF8")]
		[Address(RVA = "0x438780", Offset = "0x437980", VA = "0x180438780")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x17000107 RID: 263
	// (get) Token: 0x06000AF9 RID: 2809 RVA: 0x00004BC0 File Offset: 0x00002DC0
	// (set) Token: 0x06000AFA RID: 2810 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000107")]
	private protected Vec2 AngleOffset
	{
		[Token(Token = "0x6000AF9")]
		[Address(RVA = "0x438730", Offset = "0x437930", VA = "0x180438730")]
		[CompilerGenerated]
		protected get
		{
			return default(Vec2);
		}
		[Token(Token = "0x6000AFA")]
		[Address(RVA = "0x438770", Offset = "0x437970", VA = "0x180438770")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x17000108 RID: 264
	// (get) Token: 0x06000AFB RID: 2811 RVA: 0x00004BD8 File Offset: 0x00002DD8
	// (set) Token: 0x06000AFC RID: 2812 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000108")]
	private protected byte Magnitude
	{
		[Token(Token = "0x6000AFB")]
		[Address(RVA = "0x438760", Offset = "0x437960", VA = "0x180438760")]
		[CompilerGenerated]
		protected get
		{
			return 0;
		}
		[Token(Token = "0x6000AFC")]
		[Address(RVA = "0x4387A0", Offset = "0x4379A0", VA = "0x1804387A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x06000AFD RID: 2813 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AFD")]
	[Address(RVA = "0x4386D0", Offset = "0x4378D0", VA = "0x1804386D0")]
	public void Setup(GizmoDefinition definition, byte magnitude)
	{
	}

	// Token: 0x06000AFE RID: 2814 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AFE")]
	[Address(RVA = "0x4385E0", Offset = "0x4377E0", VA = "0x1804385E0")]
	public void SetTarget(Vector2 coordinates, Vector2 target, Simulation simulation)
	{
	}

	// Token: 0x06000AFF RID: 2815 RVA: 0x00004BF0 File Offset: 0x00002DF0
	[Token(Token = "0x6000AFF")]
	[Address(RVA = "0x4385A0", Offset = "0x4377A0", VA = "0x1804385A0")]
	protected Vector2 ApplyOffset(Vector2 vector)
	{
		return default(Vector2);
	}

	// Token: 0x06000B00 RID: 2816
	[Token(Token = "0x6000B00")]
	protected abstract void SetCoordinates(Vector2 coordinates, Vector2 target, Simulation simulation);

	// Token: 0x06000B01 RID: 2817
	[Token(Token = "0x6000B01")]
	protected abstract void Setup();

	// Token: 0x06000B02 RID: 2818 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B02")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	protected Gizmo()
	{
	}
}
