using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Ronin.Model.Data;
using Ronin.Model.Structs;
using Zero.Game.Shared;

// Token: 0x0200028D RID: 653
[Token(Token = "0x200028D")]
public class Item : Entity, IPickupContainer, IDataHandler<ItemData>
{
	// Token: 0x1700017E RID: 382
	// (get) Token: 0x06000DA3 RID: 3491 RVA: 0x00005A30 File Offset: 0x00003C30
	[Token(Token = "0x1700017E")]
	public ItemValue ItemValue
	{
		[Token(Token = "0x6000DA3")]
		[Address(RVA = "0x459250", Offset = "0x458450", VA = "0x180459250")]
		get
		{
			return default(ItemValue);
		}
	}

	// Token: 0x1700017F RID: 383
	// (get) Token: 0x06000DA4 RID: 3492 RVA: 0x00005A48 File Offset: 0x00003C48
	[Token(Token = "0x1700017F")]
	public override WorldObjectType Type
	{
		[Token(Token = "0x6000DA4")]
		[Address(RVA = "0x459270", Offset = "0x458470", VA = "0x180459270", Slot = "13")]
		get
		{
			return (WorldObjectType)0;
		}
	}

	// Token: 0x06000DA5 RID: 3493 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000DA5")]
	[Address(RVA = "0x458D80", Offset = "0x457F80", VA = "0x180458D80", Slot = "67")]
	public IEnumerable<ValueTuple<ItemValue, int>> GetItems()
	{
		return null;
	}

	// Token: 0x06000DA6 RID: 3494 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DA6")]
	[Address(RVA = "0x458E00", Offset = "0x458000", VA = "0x180458E00", Slot = "69")]
	public void HandleData(ref ItemData data)
	{
	}

	// Token: 0x06000DA7 RID: 3495 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DA7")]
	[Address(RVA = "0x458F60", Offset = "0x458160", VA = "0x180458F60", Slot = "68")]
	public void PlaySfx()
	{
	}

	// Token: 0x06000DA8 RID: 3496 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DA8")]
	[Address(RVA = "0x458EE0", Offset = "0x4580E0", VA = "0x180458EE0", Slot = "32")]
	protected override void OnEnable()
	{
	}

	// Token: 0x06000DA9 RID: 3497 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DA9")]
	[Address(RVA = "0x459110", Offset = "0x458310", VA = "0x180459110", Slot = "35")]
	protected override void Update()
	{
	}

	// Token: 0x06000DAA RID: 3498 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DAA")]
	[Address(RVA = "0x458F70", Offset = "0x458170", VA = "0x180458F70")]
	private void SetCount(long count)
	{
	}

	// Token: 0x06000DAB RID: 3499 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DAB")]
	[Address(RVA = "0x459030", Offset = "0x458230", VA = "0x180459030")]
	private void SetItemValue(ItemValue itemValue)
	{
	}

	// Token: 0x06000DAC RID: 3500 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DAC")]
	[Address(RVA = "0x44F050", Offset = "0x44E250", VA = "0x18044F050")]
	public Item()
	{
	}

	// Token: 0x04000B3B RID: 2875
	[Token(Token = "0x4000B3B")]
	[FieldOffset(Offset = "0x200")]
	private ItemValue _itemValue;

	// Token: 0x04000B3C RID: 2876
	[Token(Token = "0x4000B3C")]
	[FieldOffset(Offset = "0x210")]
	private SfxClip _dropSfx;

	// Token: 0x04000B3D RID: 2877
	[Token(Token = "0x4000B3D")]
	[FieldOffset(Offset = "0x218")]
	private bool _playSfx;
}
