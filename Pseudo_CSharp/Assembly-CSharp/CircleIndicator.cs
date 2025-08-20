using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000250 RID: 592
[Token(Token = "0x2000250")]
public class CircleIndicator : Indicator
{
	// Token: 0x06000B1C RID: 2844 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B1C")]
	[Address(RVA = "0x436E90", Offset = "0x436090", VA = "0x180436E90")]
	public void Follow(World world, uint entityId)
	{
	}

	// Token: 0x06000B1D RID: 2845 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B1D")]
	[Address(RVA = "0x437040", Offset = "0x436240", VA = "0x180437040")]
	public void Setup(Vector2 coordinates, float radius, float fillTime, float waitTime = 0f)
	{
	}

	// Token: 0x06000B1E RID: 2846 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B1E")]
	[Address(RVA = "0x437010", Offset = "0x436210", VA = "0x180437010")]
	public void SetColor(Color color)
	{
	}

	// Token: 0x06000B1F RID: 2847 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B1F")]
	[Address(RVA = "0x436EC0", Offset = "0x4360C0", VA = "0x180436EC0", Slot = "5")]
	protected override void LateUpdate()
	{
	}

	// Token: 0x06000B20 RID: 2848 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B20")]
	[Address(RVA = "0x42EC40", Offset = "0x42DE40", VA = "0x18042EC40", Slot = "4")]
	protected override void SetFill(float amount)
	{
	}

	// Token: 0x06000B21 RID: 2849 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B21")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public CircleIndicator()
	{
	}

	// Token: 0x040009E0 RID: 2528
	[Token(Token = "0x40009E0")]
	[FieldOffset(Offset = "0x28")]
	public SpriteRenderer Renderer;

	// Token: 0x040009E1 RID: 2529
	[Token(Token = "0x40009E1")]
	[FieldOffset(Offset = "0x30")]
	private World _world;

	// Token: 0x040009E2 RID: 2530
	[Token(Token = "0x40009E2")]
	[FieldOffset(Offset = "0x38")]
	private uint _entityId;
}
