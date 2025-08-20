using System;
using Il2CppDummyDll;
using Ronin.Model.Definitions;
using Ronin.Model.Files.Animation;
using UnityEngine;

// Token: 0x0200014E RID: 334
[Token(Token = "0x200014E")]
public class EntityRig : MonoBehaviour, IAnimatedObject
{
	// Token: 0x17000082 RID: 130
	// (get) Token: 0x06000607 RID: 1543 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x17000082")]
	public ObjectDefinition WeaponDefinition
	{
		[Token(Token = "0x6000607")]
		[Address(RVA = "0x3EEC00", Offset = "0x3EDE00", VA = "0x1803EEC00")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000083 RID: 131
	// (get) Token: 0x06000608 RID: 1544 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x17000083")]
	public ObjectDefinition BootDefinition
	{
		[Token(Token = "0x6000608")]
		[Address(RVA = "0x3ECB80", Offset = "0x3EBD80", VA = "0x1803ECB80")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000084 RID: 132
	// (get) Token: 0x06000609 RID: 1545 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x17000084")]
	public ObjectDefinition ArmorDefinition
	{
		[Token(Token = "0x6000609")]
		[Address(RVA = "0x3ECAC0", Offset = "0x3EBCC0", VA = "0x1803ECAC0")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000085 RID: 133
	// (get) Token: 0x0600060A RID: 1546 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x17000085")]
	public ObjectDefinition BodyDefinition
	{
		[Token(Token = "0x600060A")]
		[Address(RVA = "0x3EEBE0", Offset = "0x3EDDE0", VA = "0x1803EEBE0")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000086 RID: 134
	// (get) Token: 0x0600060B RID: 1547 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x17000086")]
	public ObjectDefinition HatDefinition
	{
		[Token(Token = "0x600060B")]
		[Address(RVA = "0x3EEBF0", Offset = "0x3EDDF0", VA = "0x1803EEBF0")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600060C RID: 1548 RVA: 0x00003900 File Offset: 0x00001B00
	[Token(Token = "0x600060C")]
	[Address(RVA = "0x3ECE90", Offset = "0x3EC090", VA = "0x1803ECE90")]
	public static float GetHFromColor(Color color)
	{
		return 0f;
	}

	// Token: 0x0600060D RID: 1549 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600060D")]
	[Address(RVA = "0x3ED110", Offset = "0x3EC310", VA = "0x1803ED110")]
	public void SetArmor(ObjectDefinition data)
	{
	}

	// Token: 0x0600060E RID: 1550 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600060E")]
	[Address(RVA = "0x3ED1D0", Offset = "0x3EC3D0", VA = "0x1803ED1D0")]
	public void SetBody(ObjectDefinition data)
	{
	}

	// Token: 0x0600060F RID: 1551 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600060F")]
	[Address(RVA = "0x3ED330", Offset = "0x3EC530", VA = "0x1803ED330")]
	public void SetBoots(ObjectDefinition data)
	{
	}

	// Token: 0x06000610 RID: 1552 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000610")]
	[Address(RVA = "0x3ED460", Offset = "0x3EC660", VA = "0x1803ED460", Slot = "4")]
	public void SetColor(Color color)
	{
	}

	// Token: 0x06000611 RID: 1553 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000611")]
	[Address(RVA = "0x3ED470", Offset = "0x3EC670", VA = "0x1803ED470")]
	public void SetColors(Color flashColor, float flashIntensity, float alpha, Color outlineColor)
	{
	}

	// Token: 0x06000612 RID: 1554 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000612")]
	[Address(RVA = "0x3ED8A0", Offset = "0x3ECAA0", VA = "0x1803ED8A0")]
	public void SetHat(ObjectDefinition data)
	{
	}

	// Token: 0x06000613 RID: 1555 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000613")]
	[Address(RVA = "0x3EDB90", Offset = "0x3ECD90", VA = "0x1803EDB90")]
	public void SetOutline(Color color)
	{
	}

	// Token: 0x06000614 RID: 1556 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000614")]
	[Address(RVA = "0x3ED7F0", Offset = "0x3EC9F0", VA = "0x1803ED7F0", Slot = "7")]
	public void SetFlipped(bool value)
	{
	}

	// Token: 0x06000615 RID: 1557 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000615")]
	[Address(RVA = "0x3EDAF0", Offset = "0x3ECCF0", VA = "0x1803EDAF0", Slot = "5")]
	public void SetLayer(int layer)
	{
	}

	// Token: 0x06000616 RID: 1558 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000616")]
	[Address(RVA = "0x3EDE80", Offset = "0x3ED080", VA = "0x1803EDE80", Slot = "6")]
	public void SetSprite(AnimationFrame frame)
	{
	}

	// Token: 0x06000617 RID: 1559 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000617")]
	[Address(RVA = "0x3EE090", Offset = "0x3ED290", VA = "0x1803EE090")]
	public void SetWeapon(ObjectDefinition data)
	{
	}

	// Token: 0x06000618 RID: 1560 RVA: 0x00003918 File Offset: 0x00001B18
	[Token(Token = "0x6000618")]
	[Address(RVA = "0x3ECFE0", Offset = "0x3EC1E0", VA = "0x1803ECFE0")]
	private int PositionComponents(AnimationRunner[] runners, AnimationComponentData[] datas, bool bodyFlipped, int layerOrder)
	{
		return 0;
	}

	// Token: 0x06000619 RID: 1561 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000619")]
	[Address(RVA = "0x3EE1C0", Offset = "0x3ED3C0", VA = "0x1803EE1C0")]
	private void Start()
	{
	}

	// Token: 0x0600061A RID: 1562 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600061A")]
	[Address(RVA = "0x3EE3C0", Offset = "0x3ED5C0", VA = "0x1803EE3C0")]
	private void UpdateArmorPosition()
	{
	}

	// Token: 0x0600061B RID: 1563 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600061B")]
	[Address(RVA = "0x3EE530", Offset = "0x3ED730", VA = "0x1803EE530")]
	private void UpdateBodyPosition()
	{
	}

	// Token: 0x0600061C RID: 1564 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600061C")]
	[Address(RVA = "0x3EE710", Offset = "0x3ED910", VA = "0x1803EE710")]
	private void UpdateBodyVisibility()
	{
	}

	// Token: 0x0600061D RID: 1565 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600061D")]
	[Address(RVA = "0x3EE7A0", Offset = "0x3ED9A0", VA = "0x1803EE7A0")]
	private void UpdateComponentPositions()
	{
	}

	// Token: 0x0600061E RID: 1566 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600061E")]
	[Address(RVA = "0x3EEA00", Offset = "0x3EDC00", VA = "0x1803EEA00")]
	private void UpdateHatPosition()
	{
	}

	// Token: 0x0600061F RID: 1567 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600061F")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public EntityRig()
	{
	}

	// Token: 0x04000691 RID: 1681
	[Token(Token = "0x4000691")]
	[FieldOffset(Offset = "0x20")]
	public AnimationRunner Main;

	// Token: 0x04000692 RID: 1682
	[Token(Token = "0x4000692")]
	[FieldOffset(Offset = "0x28")]
	public SpriteRenderer Rig;

	// Token: 0x04000693 RID: 1683
	[Token(Token = "0x4000693")]
	[FieldOffset(Offset = "0x30")]
	public SpriteRenderer Body;

	// Token: 0x04000694 RID: 1684
	[Token(Token = "0x4000694")]
	[FieldOffset(Offset = "0x38")]
	public SpriteRenderer Armor;

	// Token: 0x04000695 RID: 1685
	[Token(Token = "0x4000695")]
	[FieldOffset(Offset = "0x40")]
	public SpriteRenderer Hat;

	// Token: 0x04000696 RID: 1686
	[Token(Token = "0x4000696")]
	[FieldOffset(Offset = "0x48")]
	public AnimationRunner[] Weapons;

	// Token: 0x04000697 RID: 1687
	[Token(Token = "0x4000697")]
	[FieldOffset(Offset = "0x50")]
	public AnimationRunner[] Boots;

	// Token: 0x04000698 RID: 1688
	[Token(Token = "0x4000698")]
	[FieldOffset(Offset = "0x58")]
	public bool DisableRig;

	// Token: 0x04000699 RID: 1689
	[Token(Token = "0x4000699")]
	[FieldOffset(Offset = "0x60")]
	private AnimationFrame _frame;

	// Token: 0x0400069A RID: 1690
	[Token(Token = "0x400069A")]
	[FieldOffset(Offset = "0x68")]
	private ObjectDefinition _weapon;

	// Token: 0x0400069B RID: 1691
	[Token(Token = "0x400069B")]
	[FieldOffset(Offset = "0x70")]
	private ObjectDefinition _boot;

	// Token: 0x0400069C RID: 1692
	[Token(Token = "0x400069C")]
	[FieldOffset(Offset = "0x78")]
	private ObjectDefinition _armor;

	// Token: 0x0400069D RID: 1693
	[Token(Token = "0x400069D")]
	[FieldOffset(Offset = "0x80")]
	private ObjectDefinition _body;

	// Token: 0x0400069E RID: 1694
	[Token(Token = "0x400069E")]
	[FieldOffset(Offset = "0x88")]
	private ObjectDefinition _hat;

	// Token: 0x0400069F RID: 1695
	[Token(Token = "0x400069F")]
	[FieldOffset(Offset = "0x90")]
	private bool _flipped;

	// Token: 0x040006A0 RID: 1696
	[Token(Token = "0x40006A0")]
	[FieldOffset(Offset = "0x94")]
	private Color _color;

	// Token: 0x040006A1 RID: 1697
	[Token(Token = "0x40006A1")]
	[FieldOffset(Offset = "0xA4")]
	private bool _bodyHidden;
}
