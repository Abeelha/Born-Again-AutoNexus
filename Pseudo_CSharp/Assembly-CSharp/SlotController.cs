using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x020002E5 RID: 741
[Token(Token = "0x20002E5")]
public class SlotController : MonoBehaviour
{
	// Token: 0x170001D4 RID: 468
	// (get) Token: 0x0600103F RID: 4159 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x170001D4")]
	public Slot DraggingSlot
	{
		[Token(Token = "0x600103F")]
		[Address(RVA = "0x35B070", Offset = "0x35A270", VA = "0x18035B070")]
		get
		{
			return null;
		}
	}

	// Token: 0x170001D5 RID: 469
	// (get) Token: 0x06001040 RID: 4160 RVA: 0x00006558 File Offset: 0x00004758
	[Token(Token = "0x170001D5")]
	public bool CanDrag
	{
		[Token(Token = "0x6001040")]
		[Address(RVA = "0x35B040", Offset = "0x35A240", VA = "0x18035B040")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170001D6 RID: 470
	// (get) Token: 0x06001041 RID: 4161 RVA: 0x00006570 File Offset: 0x00004770
	[Token(Token = "0x170001D6")]
	public bool UseOnFirstSelect
	{
		[Token(Token = "0x6001041")]
		[Address(RVA = "0x35B080", Offset = "0x35A280", VA = "0x18035B080")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06001042 RID: 4162 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001042")]
	[Address(RVA = "0x357F80", Offset = "0x357180", VA = "0x180357F80")]
	public void CancelDrag(Slot slot)
	{
	}

	// Token: 0x06001043 RID: 4163 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001043")]
	[Address(RVA = "0x3580E0", Offset = "0x3572E0", VA = "0x1803580E0")]
	public void Clear()
	{
	}

	// Token: 0x06001044 RID: 4164 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001044")]
	[Address(RVA = "0x3584D0", Offset = "0x3576D0", VA = "0x1803584D0")]
	public void Deselect(Slot slot)
	{
	}

	// Token: 0x06001045 RID: 4165 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001045")]
	[Address(RVA = "0x3583C0", Offset = "0x3575C0", VA = "0x1803583C0")]
	public void Deselect()
	{
	}

	// Token: 0x06001046 RID: 4166 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001046")]
	[Address(RVA = "0x358830", Offset = "0x357A30", VA = "0x180358830")]
	public void Interact(Slot slotA, Slot slotB)
	{
	}

	// Token: 0x06001047 RID: 4167 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001047")]
	[Address(RVA = "0x358CC0", Offset = "0x357EC0", VA = "0x180358CC0")]
	public void OnBeginDrag(Slot slot, PointerEventData eventData, [Optional] Vector2 graphicOffset)
	{
	}

	// Token: 0x06001048 RID: 4168 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001048")]
	[Address(RVA = "0x358F30", Offset = "0x358130", VA = "0x180358F30")]
	public void OnDrag(Slot slot, PointerEventData eventData, [Optional] Vector2 graphicOffset)
	{
	}

	// Token: 0x06001049 RID: 4169 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001049")]
	[Address(RVA = "0x359070", Offset = "0x358270", VA = "0x180359070")]
	public void OnEndDrag(Slot slot, PointerEventData eventData)
	{
	}

	// Token: 0x0600104A RID: 4170 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600104A")]
	[Address(RVA = "0x359610", Offset = "0x358810", VA = "0x180359610")]
	public void QuickUse(Slot slot, bool useIfEmpty = false)
	{
	}

	// Token: 0x0600104B RID: 4171 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600104B")]
	[Address(RVA = "0x359D10", Offset = "0x358F10", VA = "0x180359D10")]
	public void Select(Slot slot, InputType inputType)
	{
	}

	// Token: 0x0600104C RID: 4172 RVA: 0x00006588 File Offset: 0x00004788
	[Token(Token = "0x600104C")]
	[Address(RVA = "0x35A050", Offset = "0x359250", VA = "0x18035A050")]
	public bool Selected(Slot slot)
	{
		return default(bool);
	}

	// Token: 0x0600104D RID: 4173 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600104D")]
	[Address(RVA = "0x35A0B0", Offset = "0x3592B0", VA = "0x18035A0B0")]
	public void SetEquippedArmor(Slot slot)
	{
	}

	// Token: 0x0600104E RID: 4174 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600104E")]
	[Address(RVA = "0x35A130", Offset = "0x359330", VA = "0x18035A130")]
	public void SetEquippedWeapon(Slot slot)
	{
	}

	// Token: 0x0600104F RID: 4175 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600104F")]
	[Address(RVA = "0x35A2E0", Offset = "0x3594E0", VA = "0x18035A2E0")]
	public void SetSelection(Slot targetSlot, bool selected)
	{
	}

	// Token: 0x06001050 RID: 4176 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001050")]
	[Address(RVA = "0x35A9B0", Offset = "0x359BB0", VA = "0x18035A9B0")]
	public void UpdateCooldown(int index, float progress, int charges, int maxCharge)
	{
	}

	// Token: 0x06001051 RID: 4177 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001051")]
	[Address(RVA = "0x357F10", Offset = "0x357110", VA = "0x180357F10")]
	private void Awake()
	{
	}

	// Token: 0x06001052 RID: 4178 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001052")]
	[Address(RVA = "0x358000", Offset = "0x357200", VA = "0x180358000")]
	private void ClearDrag()
	{
	}

	// Token: 0x06001053 RID: 4179 RVA: 0x000065A0 File Offset: 0x000047A0
	[Token(Token = "0x6001053")]
	[Address(RVA = "0x3581B0", Offset = "0x3573B0", VA = "0x1803581B0")]
	private bool ControlFirst(Slot slot)
	{
		return default(bool);
	}

	// Token: 0x06001054 RID: 4180 RVA: 0x000065B8 File Offset: 0x000047B8
	[Token(Token = "0x6001054")]
	[Address(RVA = "0x358200", Offset = "0x357400", VA = "0x180358200")]
	private bool ControlSecond(Slot slotA, Slot slotB)
	{
		return default(bool);
	}

	// Token: 0x06001055 RID: 4181 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001055")]
	[Address(RVA = "0x358640", Offset = "0x357840", VA = "0x180358640")]
	private void Drop(Slot slot)
	{
	}

	// Token: 0x06001056 RID: 4182 RVA: 0x000065D0 File Offset: 0x000047D0
	[Token(Token = "0x6001056")]
	[Address(RVA = "0x358B20", Offset = "0x357D20", VA = "0x180358B20")]
	private bool IsEmpty(Slot slot)
	{
		return default(bool);
	}

	// Token: 0x06001057 RID: 4183 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001057")]
	[Address(RVA = "0x358C00", Offset = "0x357E00", VA = "0x180358C00")]
	private void LateUpdate()
	{
	}

	// Token: 0x06001058 RID: 4184 RVA: 0x000065E8 File Offset: 0x000047E8
	[Token(Token = "0x6001058")]
	[Address(RVA = "0x359310", Offset = "0x358510", VA = "0x180359310")]
	private bool Pickup(Slot slot)
	{
		return default(bool);
	}

	// Token: 0x06001059 RID: 4185 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001059")]
	[Address(RVA = "0x359440", Offset = "0x358640", VA = "0x180359440")]
	private static void PositionSelection(Slot slot, RectTransform selection)
	{
	}

	// Token: 0x0600105A RID: 4186 RVA: 0x00006600 File Offset: 0x00004800
	[Token(Token = "0x600105A")]
	[Address(RVA = "0x359F80", Offset = "0x359180", VA = "0x180359F80")]
	private bool SelectedSame(Slot slot)
	{
		return default(bool);
	}

	// Token: 0x0600105B RID: 4187 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600105B")]
	[Address(RVA = "0x35A690", Offset = "0x359890", VA = "0x18035A690")]
	private void Split(Slot slot)
	{
	}

	// Token: 0x0600105C RID: 4188 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600105C")]
	[Address(RVA = "0x35A760", Offset = "0x359960", VA = "0x18035A760")]
	private void Swap(Slot slotA, Slot slotB)
	{
	}

	// Token: 0x0600105D RID: 4189 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600105D")]
	[Address(RVA = "0x35A1B0", Offset = "0x3593B0", VA = "0x18035A1B0")]
	private void SetEquipped(RectTransform selection, Slot slot)
	{
	}

	// Token: 0x0600105E RID: 4190 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600105E")]
	[Address(RVA = "0x358680", Offset = "0x357880", VA = "0x180358680")]
	private RectTransform GetSelection()
	{
		return null;
	}

	// Token: 0x0600105F RID: 4191 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600105F")]
	[Address(RVA = "0x359C00", Offset = "0x358E00", VA = "0x180359C00")]
	private void ReturnSelection(RectTransform selection)
	{
	}

	// Token: 0x06001060 RID: 4192 RVA: 0x00006618 File Offset: 0x00004818
	[Token(Token = "0x6001060")]
	[Address(RVA = "0x35ADC0", Offset = "0x359FC0", VA = "0x18035ADC0")]
	private bool Use(Slot slot, InputType inputType)
	{
		return default(bool);
	}

	// Token: 0x06001061 RID: 4193 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001061")]
	[Address(RVA = "0x35AEA0", Offset = "0x35A0A0", VA = "0x18035AEA0")]
	public SlotController()
	{
	}

	// Token: 0x06001062 RID: 4194 RVA: 0x00006630 File Offset: 0x00004830
	[Token(Token = "0x6001062")]
	[Address(RVA = "0x35A820", Offset = "0x359A20", VA = "0x18035A820")]
	[CompilerGenerated]
	internal static int <QuickUse>g__getInventoryFirstAvailable|41_0(World world)
	{
		return 0;
	}

	// Token: 0x06001063 RID: 4195 RVA: 0x00006648 File Offset: 0x00004848
	[Token(Token = "0x6001063")]
	[Address(RVA = "0x35A8A0", Offset = "0x359AA0", VA = "0x18035A8A0")]
	[CompilerGenerated]
	internal static int <QuickUse>g__getInventoryFirstPartialStack|41_1(World world, ushort type)
	{
		return 0;
	}

	// Token: 0x04000D99 RID: 3481
	[Token(Token = "0x4000D99")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public RectTransform SlotSelection;

	// Token: 0x04000D9A RID: 3482
	[Token(Token = "0x4000D9A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public RectTransform SlotArmorSelection;

	// Token: 0x04000D9B RID: 3483
	[Token(Token = "0x4000D9B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public RectTransform SlotWeaponSelection;

	// Token: 0x04000D9C RID: 3484
	[Token(Token = "0x4000D9C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public World World;

	// Token: 0x04000D9D RID: 3485
	[Token(Token = "0x4000D9D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public SplitMenu SplitMenu;

	// Token: 0x04000D9E RID: 3486
	[Token(Token = "0x4000D9E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject InventoryControls;

	// Token: 0x04000D9F RID: 3487
	[Token(Token = "0x4000D9F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject SplitControl;

	// Token: 0x04000DA0 RID: 3488
	[Token(Token = "0x4000DA0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject CancelUseControl;

	// Token: 0x04000DA1 RID: 3489
	[Token(Token = "0x4000DA1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GameObject InventoryTab;

	// Token: 0x04000DA2 RID: 3490
	[Token(Token = "0x4000DA2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public TradeMenu TradeMenu;

	// Token: 0x04000DA3 RID: 3491
	[Token(Token = "0x4000DA3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public BankMenu BankMenu;

	// Token: 0x04000DA4 RID: 3492
	[Token(Token = "0x4000DA4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public AmountMenu AmountMenu;

	// Token: 0x04000DA5 RID: 3493
	[Token(Token = "0x4000DA5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public GameTabController Tabs;

	// Token: 0x04000DA6 RID: 3494
	[Token(Token = "0x4000DA6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public UseManager UseManager;

	// Token: 0x04000DA7 RID: 3495
	[Token(Token = "0x4000DA7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public GraphicRaycaster GraphicRaycaster;

	// Token: 0x04000DA8 RID: 3496
	[Token(Token = "0x4000DA8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Slot DragImageSlot;

	// Token: 0x04000DA9 RID: 3497
	[Token(Token = "0x4000DA9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Image[] AbilityEnergyReady;

	// Token: 0x04000DAA RID: 3498
	[Token(Token = "0x4000DAA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Image[] AbilityEnergyCharge;

	// Token: 0x04000DAB RID: 3499
	[Token(Token = "0x4000DAB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public TextMeshProUGUI[] AbilityChargeLabels;

	// Token: 0x04000DAC RID: 3500
	[Token(Token = "0x4000DAC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Sprite AbilityChargeSprite;

	// Token: 0x04000DAD RID: 3501
	[Token(Token = "0x4000DAD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Sprite AbilityReadySprite;

	// Token: 0x04000DAE RID: 3502
	[Token(Token = "0x4000DAE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private Slot _draggingSlot;

	// Token: 0x04000DAF RID: 3503
	[Token(Token = "0x4000DAF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private readonly int[] _charges;

	// Token: 0x04000DB0 RID: 3504
	[Token(Token = "0x4000DB0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private readonly Dictionary<int, string> _chargeLabels;

	// Token: 0x04000DB1 RID: 3505
	[Token(Token = "0x4000DB1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private readonly Dictionary<Slot, RectTransform> _selections;

	// Token: 0x04000DB2 RID: 3506
	[Token(Token = "0x4000DB2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private readonly List<RectTransform> _selectionCache;

	// Token: 0x04000DB3 RID: 3507
	[Token(Token = "0x4000DB3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private readonly List<RaycastResult> _raycastResults;
}
