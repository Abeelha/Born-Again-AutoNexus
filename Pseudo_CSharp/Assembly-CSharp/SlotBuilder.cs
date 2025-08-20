using System;
using Il2CppDummyDll;
using Ronin.Model.Structs;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020002F3 RID: 755
[Token(Token = "0x20002F3")]
public class SlotBuilder : ElementBuilder
{
	// Token: 0x060010AC RID: 4268 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010AC")]
	[Address(RVA = "0x357CD0", Offset = "0x356ED0", VA = "0x180357CD0")]
	public SlotBuilder(GameObject gameObject)
	{
	}

	// Token: 0x060010AD RID: 4269 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60010AD")]
	[Address(RVA = "0x357970", Offset = "0x356B70", VA = "0x180357970")]
	public SlotBuilder Class(ushort classType, ushort threadType)
	{
		return null;
	}

	// Token: 0x060010AE RID: 4270 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60010AE")]
	[Address(RVA = "0x3579A0", Offset = "0x356BA0", VA = "0x1803579A0")]
	public SlotBuilder CountSize(float size)
	{
		return null;
	}

	// Token: 0x060010AF RID: 4271 RVA: 0x00006720 File Offset: 0x00004920
	[Token(Token = "0x60010AF")]
	[Address(RVA = "0x3579E0", Offset = "0x356BE0", VA = "0x1803579E0", Slot = "5")]
	public override Rect GetRect()
	{
		return default(Rect);
	}

	// Token: 0x060010B0 RID: 4272 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60010B0")]
	[Address(RVA = "0x357BC0", Offset = "0x356DC0", VA = "0x180357BC0")]
	public SlotBuilder Index(int index)
	{
		return null;
	}

	// Token: 0x060010B1 RID: 4273 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60010B1")]
	[Address(RVA = "0x357BF0", Offset = "0x356DF0", VA = "0x180357BF0")]
	public SlotBuilder Item(ItemValue itemValue)
	{
		return null;
	}

	// Token: 0x060010B2 RID: 4274 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60010B2")]
	[Address(RVA = "0x357B90", Offset = "0x356D90", VA = "0x180357B90")]
	public SlotBuilder HideBackground()
	{
		return null;
	}

	// Token: 0x060010B3 RID: 4275 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60010B3")]
	[Address(RVA = "0x357C40", Offset = "0x356E40", VA = "0x180357C40")]
	public SlotBuilder Material(Material material)
	{
		return null;
	}

	// Token: 0x060010B4 RID: 4276 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60010B4")]
	[Address(RVA = "0x3505F0", Offset = "0x34F7F0", VA = "0x1803505F0")]
	public SlotBuilder Offset(Vector2 offset)
	{
		return null;
	}

	// Token: 0x060010B5 RID: 4277 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60010B5")]
	[Address(RVA = "0x357C80", Offset = "0x356E80", VA = "0x180357C80")]
	public SlotBuilder Scale(Vector2 scale)
	{
		return null;
	}

	// Token: 0x060010B6 RID: 4278 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60010B6")]
	[Address(RVA = "0x357C90", Offset = "0x356E90", VA = "0x180357C90")]
	public SlotBuilder Tooltip(bool enabled)
	{
		return null;
	}

	// Token: 0x04000DE1 RID: 3553
	[Token(Token = "0x4000DE1")]
	[FieldOffset(Offset = "0x28")]
	private readonly RectTransform _rectTransform;

	// Token: 0x04000DE2 RID: 3554
	[Token(Token = "0x4000DE2")]
	[FieldOffset(Offset = "0x30")]
	private readonly Slot _slot;

	// Token: 0x04000DE3 RID: 3555
	[Token(Token = "0x4000DE3")]
	[FieldOffset(Offset = "0x38")]
	private readonly Image _background;
}
