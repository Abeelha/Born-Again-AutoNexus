using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002F1 RID: 753
[Token(Token = "0x20002F1")]
public abstract class ElementBuilder
{
	// Token: 0x06001099 RID: 4249 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001099")]
	[Address(RVA = "0x34E4D0", Offset = "0x34D6D0", VA = "0x18034E4D0")]
	protected ElementBuilder(GameObject gameObject)
	{
	}

	// Token: 0x0600109A RID: 4250 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600109A")]
	[Address(RVA = "0x34E120", Offset = "0x34D320", VA = "0x18034E120", Slot = "4")]
	public virtual void Apply(TooltipBuilder builder, Vector2 position)
	{
	}

	// Token: 0x0600109B RID: 4251 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600109B")]
	[Address(RVA = "0x34E2D0", Offset = "0x34D4D0", VA = "0x18034E2D0")]
	public void BringToFront()
	{
	}

	// Token: 0x0600109C RID: 4252 RVA: 0x000066F0 File Offset: 0x000048F0
	[Token(Token = "0x600109C")]
	[Address(RVA = "0x34E300", Offset = "0x34D500", VA = "0x18034E300", Slot = "5")]
	public virtual Rect GetRect()
	{
		return default(Rect);
	}

	// Token: 0x0600109D RID: 4253 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600109D")]
	[Address(RVA = "0x34E430", Offset = "0x34D630", VA = "0x18034E430")]
	protected void SetOffset(Vector2 offset)
	{
	}

	// Token: 0x0600109E RID: 4254 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600109E")]
	[Address(RVA = "0x34E440", Offset = "0x34D640", VA = "0x18034E440", Slot = "6")]
	protected virtual void SetPosition(Vector2 position)
	{
	}

	// Token: 0x0600109F RID: 4255 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600109F")]
	[Address(RVA = "0x34E4C0", Offset = "0x34D6C0", VA = "0x18034E4C0")]
	protected void SetScale(Vector2 scale)
	{
	}

	// Token: 0x04000DDC RID: 3548
	[Token(Token = "0x4000DDC")]
	[FieldOffset(Offset = "0x10")]
	private readonly GameObject _gameObject;

	// Token: 0x04000DDD RID: 3549
	[Token(Token = "0x4000DDD")]
	[FieldOffset(Offset = "0x18")]
	private Vector2 _offset;

	// Token: 0x04000DDE RID: 3550
	[Token(Token = "0x4000DDE")]
	[FieldOffset(Offset = "0x20")]
	private Vector2 _scale;
}
