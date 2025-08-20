using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000253 RID: 595
[Token(Token = "0x2000253")]
[RequireComponent(typeof(MeshFilter))]
public class SlashIndicator : Indicator
{
	// Token: 0x06000B2D RID: 2861 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B2D")]
	[Address(RVA = "0x43F610", Offset = "0x43E810", VA = "0x18043F610")]
	public void MoveTo(Vector2 coordinates)
	{
	}

	// Token: 0x06000B2E RID: 2862 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B2E")]
	[Address(RVA = "0x43F680", Offset = "0x43E880", VA = "0x18043F680")]
	public void Return(float afterDelay)
	{
	}

	// Token: 0x06000B2F RID: 2863 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B2F")]
	[Address(RVA = "0x43F950", Offset = "0x43EB50", VA = "0x18043F950")]
	public void Setup(Vector2 coordinates, float spread, float angle, float radius, uint entityId, World world, float fillTime, float waitTime = 0f)
	{
	}

	// Token: 0x06000B30 RID: 2864 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B30")]
	[Address(RVA = "0x43F790", Offset = "0x43E990", VA = "0x18043F790")]
	public void SetColor(Color color)
	{
	}

	// Token: 0x06000B31 RID: 2865 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B31")]
	[Address(RVA = "0x43F1C0", Offset = "0x43E3C0", VA = "0x18043F1C0")]
	private void Awake()
	{
	}

	// Token: 0x06000B32 RID: 2866 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B32")]
	[Address(RVA = "0x43ED10", Offset = "0x43DF10", VA = "0x18043ED10")]
	private void AssignPartialQuad(int quadCount, float spriteWorldRadius, float spriteRadius, int i, Vector2 textureCenter, Vector2 texelSize, Vector2 fillTextureCenter)
	{
	}

	// Token: 0x06000B33 RID: 2867 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B33")]
	[Address(RVA = "0x43F410", Offset = "0x43E610", VA = "0x18043F410", Slot = "5")]
	protected override void LateUpdate()
	{
	}

	// Token: 0x06000B34 RID: 2868 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B34")]
	[Address(RVA = "0x43F8E0", Offset = "0x43EAE0", VA = "0x18043F8E0", Slot = "4")]
	protected override void SetFill(float amount)
	{
	}

	// Token: 0x06000B35 RID: 2869 RVA: 0x00004D28 File Offset: 0x00002F28
	[Token(Token = "0x6000B35")]
	[Address(RVA = "0x43F5E0", Offset = "0x43E7E0", VA = "0x18043F5E0")]
	private float Mod(float x, float m)
	{
		return 0f;
	}

	// Token: 0x06000B36 RID: 2870 RVA: 0x00004D40 File Offset: 0x00002F40
	[Token(Token = "0x6000B36")]
	[Address(RVA = "0x43F740", Offset = "0x43E940", VA = "0x18043F740")]
	private Vector2 Rotate(Vector2 vector, float sin, float cos)
	{
		return default(Vector2);
	}

	// Token: 0x06000B37 RID: 2871 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B37")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public SlashIndicator()
	{
	}

	// Token: 0x040009EA RID: 2538
	[Token(Token = "0x40009EA")]
	private const float Sqrt2 = 1.4142135f;

	// Token: 0x040009EB RID: 2539
	[Token(Token = "0x40009EB")]
	[FieldOffset(Offset = "0x28")]
	private MeshFilter _meshFilter;

	// Token: 0x040009EC RID: 2540
	[Token(Token = "0x40009EC")]
	[FieldOffset(Offset = "0x30")]
	private Mesh _mesh;

	// Token: 0x040009ED RID: 2541
	[Token(Token = "0x40009ED")]
	[FieldOffset(Offset = "0x38")]
	private Vector3[] _vertices;

	// Token: 0x040009EE RID: 2542
	[Token(Token = "0x40009EE")]
	[FieldOffset(Offset = "0x40")]
	private Vector2[] _uv;

	// Token: 0x040009EF RID: 2543
	[Token(Token = "0x40009EF")]
	[FieldOffset(Offset = "0x48")]
	private Color32[] _colors;

	// Token: 0x040009F0 RID: 2544
	[Token(Token = "0x40009F0")]
	[FieldOffset(Offset = "0x50")]
	private float _spread;

	// Token: 0x040009F1 RID: 2545
	[Token(Token = "0x40009F1")]
	[FieldOffset(Offset = "0x58")]
	private Sprite _sprite;

	// Token: 0x040009F2 RID: 2546
	[Token(Token = "0x40009F2")]
	[FieldOffset(Offset = "0x60")]
	private Color32 _color;

	// Token: 0x040009F3 RID: 2547
	[Token(Token = "0x40009F3")]
	[FieldOffset(Offset = "0x64")]
	private float? _returnTime;

	// Token: 0x040009F4 RID: 2548
	[Token(Token = "0x40009F4")]
	[FieldOffset(Offset = "0x6C")]
	private uint _entityId;

	// Token: 0x040009F5 RID: 2549
	[Token(Token = "0x40009F5")]
	[FieldOffset(Offset = "0x70")]
	private World _world;
}
