using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Ronin.Model.Data;
using Ronin.Model.Structs;
using Zero.Game.Shared;

// Token: 0x02000287 RID: 647
[Token(Token = "0x2000287")]
public class Container : Entity, IPickupContainer, IDataHandler<Inventory0Data>
{
	// Token: 0x17000156 RID: 342
	// (get) Token: 0x06000D0B RID: 3339 RVA: 0x000055F8 File Offset: 0x000037F8
	[Token(Token = "0x17000156")]
	public override WorldObjectType Type
	{
		[Token(Token = "0x6000D0B")]
		[Address(RVA = "0x3BB410", Offset = "0x3BA610", VA = "0x1803BB410", Slot = "13")]
		get
		{
			return (WorldObjectType)0;
		}
	}

	// Token: 0x06000D0C RID: 3340 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000D0C")]
	[Address(RVA = "0x452BB0", Offset = "0x451DB0", VA = "0x180452BB0", Slot = "67")]
	public IEnumerable<ValueTuple<ItemValue, int>> GetItems()
	{
		return null;
	}

	// Token: 0x06000D0D RID: 3341 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D0D")]
	[Address(RVA = "0x452C30", Offset = "0x451E30", VA = "0x180452C30", Slot = "69")]
	public void HandleData(ref Inventory0Data data)
	{
	}

	// Token: 0x06000D0E RID: 3342 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D0E")]
	[Address(RVA = "0x452CA0", Offset = "0x451EA0", VA = "0x180452CA0", Slot = "68")]
	public void PlaySfx()
	{
	}

	// Token: 0x06000D0F RID: 3343 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D0F")]
	[Address(RVA = "0x452C60", Offset = "0x451E60", VA = "0x180452C60", Slot = "32")]
	protected override void OnEnable()
	{
	}

	// Token: 0x06000D10 RID: 3344 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D10")]
	[Address(RVA = "0x452CB0", Offset = "0x451EB0", VA = "0x180452CB0", Slot = "35")]
	protected override void Update()
	{
	}

	// Token: 0x06000D11 RID: 3345 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D11")]
	[Address(RVA = "0x44F050", Offset = "0x44E250", VA = "0x18044F050")]
	public Container()
	{
	}

	// Token: 0x04000B0F RID: 2831
	[Token(Token = "0x4000B0F")]
	[FieldOffset(Offset = "0x200")]
	private Inventory _inventory;

	// Token: 0x04000B10 RID: 2832
	[Token(Token = "0x4000B10")]
	[FieldOffset(Offset = "0x232")]
	private bool _playSfx;
}
