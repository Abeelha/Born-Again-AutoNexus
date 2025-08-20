using System;
using Il2CppDummyDll;
using Ronin.Model.Enums;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020002F4 RID: 756
[Token(Token = "0x20002F4")]
public class SpriteBuilder : ElementBuilder
{
	// Token: 0x060010B7 RID: 4279 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010B7")]
	[Address(RVA = "0x35E560", Offset = "0x35D760", VA = "0x18035E560")]
	public SpriteBuilder(GameObject gameObject)
	{
	}

	// Token: 0x060010B8 RID: 4280 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60010B8")]
	[Address(RVA = "0x350260", Offset = "0x34F460", VA = "0x180350260")]
	public SpriteBuilder Color(Color color)
	{
		return null;
	}

	// Token: 0x060010B9 RID: 4281 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60010B9")]
	[Address(RVA = "0x35DF10", Offset = "0x35D110", VA = "0x18035DF10")]
	public SpriteBuilder NineSlice()
	{
		return null;
	}

	// Token: 0x060010BA RID: 4282 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60010BA")]
	[Address(RVA = "0x3505F0", Offset = "0x34F7F0", VA = "0x1803505F0")]
	public SpriteBuilder Offset(Vector2 offset)
	{
		return null;
	}

	// Token: 0x060010BB RID: 4283 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60010BB")]
	[Address(RVA = "0x35DF40", Offset = "0x35D140", VA = "0x18035DF40")]
	public SpriteBuilder Pivot(Vector2 pivot)
	{
		return null;
	}

	// Token: 0x060010BC RID: 4284 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60010BC")]
	[Address(RVA = "0x35DF90", Offset = "0x35D190", VA = "0x18035DF90")]
	public SpriteBuilder RadialFill(float percentage)
	{
		return null;
	}

	// Token: 0x060010BD RID: 4285 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60010BD")]
	[Address(RVA = "0x35E020", Offset = "0x35D220", VA = "0x18035E020")]
	public SpriteBuilder Scale(float scale)
	{
		return null;
	}

	// Token: 0x060010BE RID: 4286 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60010BE")]
	[Address(RVA = "0x357C80", Offset = "0x356E80", VA = "0x180357C80")]
	public SpriteBuilder Scale(Vector2 scale)
	{
		return null;
	}

	// Token: 0x060010BF RID: 4287 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60010BF")]
	[Address(RVA = "0x35E0A0", Offset = "0x35D2A0", VA = "0x18035E0A0")]
	public SpriteBuilder Size(Vector2 size)
	{
		return null;
	}

	// Token: 0x060010C0 RID: 4288 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60010C0")]
	[Address(RVA = "0x35E330", Offset = "0x35D530", VA = "0x18035E330")]
	public SpriteBuilder Sprite(Sprite sprite)
	{
		return null;
	}

	// Token: 0x060010C1 RID: 4289 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60010C1")]
	[Address(RVA = "0x35E400", Offset = "0x35D600", VA = "0x18035E400")]
	public SpriteBuilder Sprite(string name)
	{
		return null;
	}

	// Token: 0x060010C2 RID: 4290 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60010C2")]
	[Address(RVA = "0x35E100", Offset = "0x35D300", VA = "0x18035E100")]
	public SpriteBuilder Sprite(StatType statType)
	{
		return null;
	}

	// Token: 0x060010C3 RID: 4291 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010C3")]
	[Address(RVA = "0x35E030", Offset = "0x35D230", VA = "0x18035E030", Slot = "6")]
	protected override void SetPosition(Vector2 position)
	{
	}

	// Token: 0x060010C4 RID: 4292 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60010C4")]
	[Address(RVA = "0x35DE00", Offset = "0x35D000", VA = "0x18035DE00")]
	private static string GetStatSpriteName(StatType statType)
	{
		return null;
	}

	// Token: 0x04000DE4 RID: 3556
	[Token(Token = "0x4000DE4")]
	[FieldOffset(Offset = "0x28")]
	private readonly Image _image;

	// Token: 0x04000DE5 RID: 3557
	[Token(Token = "0x4000DE5")]
	[FieldOffset(Offset = "0x30")]
	private Vector2 _size;
}
