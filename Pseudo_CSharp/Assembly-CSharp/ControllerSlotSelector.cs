using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020002A9 RID: 681
[Token(Token = "0x20002A9")]
public class ControllerSlotSelector : MonoBehaviour
{
	// Token: 0x170001A7 RID: 423
	// (get) Token: 0x06000E9A RID: 3738 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x170001A7")]
	private IEnumerable<Slot> AllSlots
	{
		[Token(Token = "0x6000E9A")]
		[Address(RVA = "0x468AC0", Offset = "0x467CC0", VA = "0x180468AC0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000E9B RID: 3739 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E9B")]
	[Address(RVA = "0x466AB0", Offset = "0x465CB0", VA = "0x180466AB0")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000E9C RID: 3740 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E9C")]
	[Address(RVA = "0x468850", Offset = "0x467A50", VA = "0x180468850")]
	private void UpdateTooltip()
	{
	}

	// Token: 0x06000E9D RID: 3741 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E9D")]
	[Address(RVA = "0x467470", Offset = "0x466670", VA = "0x180467470")]
	private void Select(Slot slot, bool tooltip = false)
	{
	}

	// Token: 0x06000E9E RID: 3742 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E9E")]
	[Address(RVA = "0x466DB0", Offset = "0x465FB0", VA = "0x180466DB0")]
	private void SelectDeltaNearest(Vector2 checkPoint, Vector2 delta, bool tooltip)
	{
	}

	// Token: 0x06000E9F RID: 3743 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E9F")]
	[Address(RVA = "0x4671A0", Offset = "0x4663A0", VA = "0x1804671A0")]
	private void SelectNearest(Vector2 checkPoint, bool tooltip)
	{
	}

	// Token: 0x06000EA0 RID: 3744 RVA: 0x00005F58 File Offset: 0x00004158
	[Token(Token = "0x6000EA0")]
	[Address(RVA = "0x467DB0", Offset = "0x466FB0", VA = "0x180467DB0")]
	private bool SlotIsEligible(Slot slot)
	{
		return default(bool);
	}

	// Token: 0x06000EA1 RID: 3745 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EA1")]
	[Address(RVA = "0x467EE0", Offset = "0x4670E0", VA = "0x180467EE0")]
	private void UpdateInput()
	{
	}

	// Token: 0x06000EA2 RID: 3746 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EA2")]
	[Address(RVA = "0x468560", Offset = "0x467760", VA = "0x180468560")]
	private void UpdateNavigation()
	{
	}

	// Token: 0x06000EA3 RID: 3747 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EA3")]
	[Address(RVA = "0x468680", Offset = "0x467880", VA = "0x180468680")]
	private void UpdateSelected()
	{
	}

	// Token: 0x06000EA4 RID: 3748 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EA4")]
	[Address(RVA = "0x4689A0", Offset = "0x467BA0", VA = "0x1804689A0")]
	private void UpdateVisible()
	{
	}

	// Token: 0x06000EA5 RID: 3749 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EA5")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public ControllerSlotSelector()
	{
	}

	// Token: 0x04000BDC RID: 3036
	[Token(Token = "0x4000BDC")]
	[FieldOffset(Offset = "0x0")]
	private static readonly Vector3[] s_corners;

	// Token: 0x04000BDD RID: 3037
	[Token(Token = "0x4000BDD")]
	[FieldOffset(Offset = "0x20")]
	public Image Image;

	// Token: 0x04000BDE RID: 3038
	[Token(Token = "0x4000BDE")]
	[FieldOffset(Offset = "0x28")]
	public Slot DefaultSlot;

	// Token: 0x04000BDF RID: 3039
	[Token(Token = "0x4000BDF")]
	[FieldOffset(Offset = "0x30")]
	public Slot[] Slots;

	// Token: 0x04000BE0 RID: 3040
	[Token(Token = "0x4000BE0")]
	[FieldOffset(Offset = "0x38")]
	public PickupSlotContainer PickupSlotContainer;

	// Token: 0x04000BE1 RID: 3041
	[Token(Token = "0x4000BE1")]
	[FieldOffset(Offset = "0x40")]
	public GameTabController TabController;

	// Token: 0x04000BE2 RID: 3042
	[Token(Token = "0x4000BE2")]
	[FieldOffset(Offset = "0x48")]
	public SlotController SlotController;

	// Token: 0x04000BE3 RID: 3043
	[Token(Token = "0x4000BE3")]
	[FieldOffset(Offset = "0x50")]
	public BankMenu BankMenu;

	// Token: 0x04000BE4 RID: 3044
	[Token(Token = "0x4000BE4")]
	[FieldOffset(Offset = "0x58")]
	public WardrobeMenu WardrobeMenu;

	// Token: 0x04000BE5 RID: 3045
	[Token(Token = "0x4000BE5")]
	[FieldOffset(Offset = "0x60")]
	public World World;

	// Token: 0x04000BE6 RID: 3046
	[Token(Token = "0x4000BE6")]
	[FieldOffset(Offset = "0x68")]
	private Slot _selectedSlot;

	// Token: 0x04000BE7 RID: 3047
	[Token(Token = "0x4000BE7")]
	[FieldOffset(Offset = "0x70")]
	private ControllerNavigation _controllerNavigation;

	// Token: 0x04000BE8 RID: 3048
	[Token(Token = "0x4000BE8")]
	[FieldOffset(Offset = "0x88")]
	private Tooltip _tooltip;

	// Token: 0x04000BE9 RID: 3049
	[Token(Token = "0x4000BE9")]
	[FieldOffset(Offset = "0x90")]
	private float _startHeld;

	// Token: 0x04000BEA RID: 3050
	[Token(Token = "0x4000BEA")]
	[FieldOffset(Offset = "0x94")]
	private bool _startActivated;

	// Token: 0x04000BEB RID: 3051
	[Token(Token = "0x4000BEB")]
	[FieldOffset(Offset = "0x98")]
	private Slot _dragging;
}
