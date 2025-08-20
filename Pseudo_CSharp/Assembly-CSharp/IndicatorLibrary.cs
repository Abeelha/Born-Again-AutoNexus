using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000A8 RID: 168
[Token(Token = "0x20000A8")]
public class IndicatorLibrary : ScriptableObject, ILoadable
{
	// Token: 0x060002EA RID: 746 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60002EA")]
	[Address(RVA = "0x33BAD0", Offset = "0x33ACD0", VA = "0x18033BAD0")]
	public Sprite GetCircle(float radius)
	{
		return null;
	}

	// Token: 0x060002EB RID: 747 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60002EB")]
	[Address(RVA = "0x33BA70", Offset = "0x33AC70", VA = "0x18033BA70")]
	public Sprite GetCircleOutline(float radius)
	{
		return null;
	}

	// Token: 0x060002EC RID: 748 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60002EC")]
	[Address(RVA = "0x33BB80", Offset = "0x33AD80", VA = "0x18033BB80")]
	public Sprite GetProjectile(float width)
	{
		return null;
	}

	// Token: 0x060002ED RID: 749 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002ED")]
	[Address(RVA = "0x316090", Offset = "0x315290", VA = "0x180316090", Slot = "4")]
	public void Load()
	{
	}

	// Token: 0x060002EE RID: 750 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60002EE")]
	[Address(RVA = "0x33BB30", Offset = "0x33AD30", VA = "0x18033BB30")]
	private static Sprite GetDiameterSprite(float radius, Sprite[] sprites)
	{
		return null;
	}

	// Token: 0x060002EF RID: 751 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002EF")]
	[Address(RVA = "0x333FD0", Offset = "0x3331D0", VA = "0x180333FD0")]
	public IndicatorLibrary()
	{
	}

	// Token: 0x040002CE RID: 718
	[Token(Token = "0x40002CE")]
	[FieldOffset(Offset = "0x18")]
	public Sprite[] CircleSprites;

	// Token: 0x040002CF RID: 719
	[Token(Token = "0x40002CF")]
	[FieldOffset(Offset = "0x20")]
	public Sprite[] CircleOutlineSprites;

	// Token: 0x040002D0 RID: 720
	[Token(Token = "0x40002D0")]
	[FieldOffset(Offset = "0x28")]
	public Sprite[] ProjectileSprites;
}
