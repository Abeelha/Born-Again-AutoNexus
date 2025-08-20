using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000252 RID: 594
[Token(Token = "0x2000252")]
public class LineIndicator : Indicator
{
	// Token: 0x06000B27 RID: 2855 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B27")]
	[Address(RVA = "0x438920", Offset = "0x437B20", VA = "0x180438920")]
	public void Follow(World world, uint entityId)
	{
	}

	// Token: 0x06000B28 RID: 2856 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B28")]
	[Address(RVA = "0x438AE0", Offset = "0x437CE0", VA = "0x180438AE0")]
	public void Setup(Vector2 coordinates, Vector2 size, float backwardsSize, float angleDegrees, float fillTime, float waitTime = 0f, bool projectile = false)
	{
	}

	// Token: 0x06000B29 RID: 2857 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B29")]
	[Address(RVA = "0x437010", Offset = "0x436210", VA = "0x180437010")]
	public void SetColor(Color color)
	{
	}

	// Token: 0x06000B2A RID: 2858 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B2A")]
	[Address(RVA = "0x438950", Offset = "0x437B50", VA = "0x180438950", Slot = "5")]
	protected override void LateUpdate()
	{
	}

	// Token: 0x06000B2B RID: 2859 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B2B")]
	[Address(RVA = "0x438AA0", Offset = "0x437CA0", VA = "0x180438AA0", Slot = "4")]
	protected override void SetFill(float amount)
	{
	}

	// Token: 0x06000B2C RID: 2860 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B2C")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public LineIndicator()
	{
	}

	// Token: 0x040009E5 RID: 2533
	[Token(Token = "0x40009E5")]
	[FieldOffset(Offset = "0x28")]
	public SpriteRenderer Renderer;

	// Token: 0x040009E6 RID: 2534
	[Token(Token = "0x40009E6")]
	[FieldOffset(Offset = "0x30")]
	public Transform InnerTransform;

	// Token: 0x040009E7 RID: 2535
	[Token(Token = "0x40009E7")]
	[FieldOffset(Offset = "0x38")]
	private Vector2 _size;

	// Token: 0x040009E8 RID: 2536
	[Token(Token = "0x40009E8")]
	[FieldOffset(Offset = "0x40")]
	private World _world;

	// Token: 0x040009E9 RID: 2537
	[Token(Token = "0x40009E9")]
	[FieldOffset(Offset = "0x48")]
	private uint _entityId;
}
