using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Ronin.Model.Definitions;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000136 RID: 310
[Token(Token = "0x2000136")]
public class WardrobeMenu : Menu
{
	// Token: 0x17000062 RID: 98
	// (get) Token: 0x06000569 RID: 1385 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x17000062")]
	public IEnumerable<Slot> Slots
	{
		[Token(Token = "0x6000569")]
		[Address(RVA = "0x3EC3A0", Offset = "0x3EB5A0", VA = "0x1803EC3A0")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600056A RID: 1386 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600056A")]
	[Address(RVA = "0x3EAEC0", Offset = "0x3EA0C0", VA = "0x1803EAEC0")]
	public void Equip(ushort type)
	{
	}

	// Token: 0x0600056B RID: 1387 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600056B")]
	[Address(RVA = "0x3EB680", Offset = "0x3EA880", VA = "0x1803EB680")]
	public void RemoveHat()
	{
	}

	// Token: 0x0600056C RID: 1388 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600056C")]
	[Address(RVA = "0x3EB7A0", Offset = "0x3EA9A0", VA = "0x1803EB7A0")]
	public void Save(Slot slotA)
	{
	}

	// Token: 0x0600056D RID: 1389 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600056D")]
	[Address(RVA = "0x3EBD50", Offset = "0x3EAF50", VA = "0x1803EBD50")]
	public void Setup(WorldObject interactable)
	{
	}

	// Token: 0x0600056E RID: 1390 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600056E")]
	[Address(RVA = "0x3EBD80", Offset = "0x3EAF80", VA = "0x1803EBD80")]
	public void Unlocked(ushort unlockedType)
	{
	}

	// Token: 0x0600056F RID: 1391 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600056F")]
	[Address(RVA = "0x3EAFF0", Offset = "0x3EA1F0", VA = "0x1803EAFF0")]
	private static List<HatDefinition> GetWardrobeHats()
	{
		return null;
	}

	// Token: 0x06000570 RID: 1392 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000570")]
	[Address(RVA = "0x3EAA50", Offset = "0x3E9C50", VA = "0x1803EAA50")]
	private void Awake()
	{
	}

	// Token: 0x06000571 RID: 1393 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000571")]
	[Address(RVA = "0x3EAA70", Offset = "0x3E9C70", VA = "0x1803EAA70")]
	private void CreateSlots()
	{
	}

	// Token: 0x06000572 RID: 1394 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000572")]
	[Address(RVA = "0x3EB360", Offset = "0x3EA560", VA = "0x1803EB360")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000573 RID: 1395 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000573")]
	[Address(RVA = "0x3EB9F0", Offset = "0x3EABF0", VA = "0x1803EB9F0")]
	private void SetSlotUnlocked(Slot slot, bool unlocked)
	{
	}

	// Token: 0x06000574 RID: 1396 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000574")]
	[Address(RVA = "0x3EBB60", Offset = "0x3EAD60", VA = "0x1803EBB60")]
	private void SetTheme(WardrobeMenu.WardrobeTheme theme)
	{
	}

	// Token: 0x06000575 RID: 1397 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000575")]
	[Address(RVA = "0x3EBE70", Offset = "0x3EB070", VA = "0x1803EBE70")]
	private void UpdateUnlocked()
	{
	}

	// Token: 0x06000576 RID: 1398 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000576")]
	[Address(RVA = "0x3EC270", Offset = "0x3EB470", VA = "0x1803EC270")]
	public WardrobeMenu()
	{
	}

	// Token: 0x040005D9 RID: 1497
	[Token(Token = "0x40005D9")]
	[FieldOffset(Offset = "0x90")]
	public int ColumnCount;

	// Token: 0x040005DA RID: 1498
	[Token(Token = "0x40005DA")]
	[FieldOffset(Offset = "0x94")]
	public Vector2 CellSize;

	// Token: 0x040005DB RID: 1499
	[Token(Token = "0x40005DB")]
	[FieldOffset(Offset = "0xA0")]
	public Slot SlotPrefab;

	// Token: 0x040005DC RID: 1500
	[Token(Token = "0x40005DC")]
	[FieldOffset(Offset = "0xA8")]
	public RectTransform SlotContent;

	// Token: 0x040005DD RID: 1501
	[Token(Token = "0x40005DD")]
	[FieldOffset(Offset = "0xB0")]
	public TMP_Text ProgressLabel;

	// Token: 0x040005DE RID: 1502
	[Token(Token = "0x40005DE")]
	[FieldOffset(Offset = "0xB8")]
	public Color DefaultProgressColor;

	// Token: 0x040005DF RID: 1503
	[Token(Token = "0x40005DF")]
	[FieldOffset(Offset = "0xC8")]
	public Color MaxedProgressColor;

	// Token: 0x040005E0 RID: 1504
	[Token(Token = "0x40005E0")]
	[FieldOffset(Offset = "0xD8")]
	public World World;

	// Token: 0x040005E1 RID: 1505
	[Token(Token = "0x40005E1")]
	[FieldOffset(Offset = "0xE0")]
	public SlotController SlotController;

	// Token: 0x040005E2 RID: 1506
	[Token(Token = "0x40005E2")]
	[FieldOffset(Offset = "0xE8")]
	public GameObject DragHandler;

	// Token: 0x040005E3 RID: 1507
	[Token(Token = "0x40005E3")]
	[FieldOffset(Offset = "0xF0")]
	public TextMeshProUGUI CostLabel;

	// Token: 0x040005E4 RID: 1508
	[Token(Token = "0x40005E4")]
	[FieldOffset(Offset = "0xF8")]
	public Image Background;

	// Token: 0x040005E5 RID: 1509
	[Token(Token = "0x40005E5")]
	[FieldOffset(Offset = "0x100")]
	public WardrobeMenu.WardrobeTheme DefaultTheme;

	// Token: 0x040005E6 RID: 1510
	[Token(Token = "0x40005E6")]
	[FieldOffset(Offset = "0x110")]
	public WardrobeMenu.WardrobeTheme MaxedTheme;

	// Token: 0x040005E7 RID: 1511
	[Token(Token = "0x40005E7")]
	[FieldOffset(Offset = "0x120")]
	private readonly List<Slot> _slots;

	// Token: 0x040005E8 RID: 1512
	[Token(Token = "0x40005E8")]
	[FieldOffset(Offset = "0x128")]
	private readonly Dictionary<ushort, Slot> _hatMap;

	// Token: 0x040005E9 RID: 1513
	[Token(Token = "0x40005E9")]
	[FieldOffset(Offset = "0x130")]
	private readonly List<HatDefinition> _wardrobeHats;

	// Token: 0x040005EA RID: 1514
	[Token(Token = "0x40005EA")]
	[FieldOffset(Offset = "0x138")]
	private WorldObject _interactable;

	// Token: 0x040005EB RID: 1515
	[Token(Token = "0x40005EB")]
	[FieldOffset(Offset = "0x140")]
	private int _syncedCost;

	// Token: 0x02000137 RID: 311
	[Token(Token = "0x2000137")]
	[Serializable]
	public struct WardrobeTheme
	{
		// Token: 0x040005EC RID: 1516
		[Token(Token = "0x40005EC")]
		[FieldOffset(Offset = "0x0")]
		public Sprite Background;

		// Token: 0x040005ED RID: 1517
		[Token(Token = "0x40005ED")]
		[FieldOffset(Offset = "0x8")]
		public Sprite Shelf;
	}
}
