using System;
using AnimateInternal;
using Il2CppDummyDll;
using Ronin.Model.Enums;
using Ronin.Model.Structs;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x020002E4 RID: 740
[Token(Token = "0x20002E4")]
public class Slot : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler, IBeginDragHandler, IEndDragHandler, ISlotReceiver, IPointerClickHandler, ICancelHandler
{
	// Token: 0x170001CF RID: 463
	// (get) Token: 0x06001020 RID: 4128 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x170001CF")]
	public RectTransform RectTransform
	{
		[Token(Token = "0x6001020")]
		[Address(RVA = "0x35DD40", Offset = "0x35CF40", VA = "0x18035DD40", Slot = "12")]
		get
		{
			return null;
		}
	}

	// Token: 0x170001D0 RID: 464
	// (get) Token: 0x06001021 RID: 4129 RVA: 0x00006498 File Offset: 0x00004698
	[Token(Token = "0x170001D0")]
	public bool IsEmpty
	{
		[Token(Token = "0x6001021")]
		[Address(RVA = "0x35DC10", Offset = "0x35CE10", VA = "0x18035DC10")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170001D1 RID: 465
	// (get) Token: 0x06001022 RID: 4130 RVA: 0x000064B0 File Offset: 0x000046B0
	[Token(Token = "0x170001D1")]
	public uint ControlledEntityId
	{
		[Token(Token = "0x6001022")]
		[Address(RVA = "0x35DB90", Offset = "0x35CD90", VA = "0x18035DB90")]
		get
		{
			return 0U;
		}
	}

	// Token: 0x170001D2 RID: 466
	// (get) Token: 0x06001023 RID: 4131 RVA: 0x000064C8 File Offset: 0x000046C8
	[Token(Token = "0x170001D2")]
	public bool IsControlledSlot
	{
		[Token(Token = "0x6001023")]
		[Address(RVA = "0x35DBD0", Offset = "0x35CDD0", VA = "0x18035DBD0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170001D3 RID: 467
	// (get) Token: 0x06001024 RID: 4132 RVA: 0x000064E0 File Offset: 0x000046E0
	[Token(Token = "0x170001D3")]
	public bool IsPartialStack
	{
		[Token(Token = "0x6001024")]
		[Address(RVA = "0x35DC60", Offset = "0x35CE60", VA = "0x18035DC60")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06001025 RID: 4133 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6001025")]
	[Address(RVA = "0x35B840", Offset = "0x35AA40", VA = "0x18035B840")]
	public static string FormatCount(long count)
	{
		return null;
	}

	// Token: 0x06001026 RID: 4134 RVA: 0x000064F8 File Offset: 0x000046F8
	[Token(Token = "0x6001026")]
	[Address(RVA = "0x35B930", Offset = "0x35AB30", VA = "0x18035B930")]
	public static Color GetCountColor(long count)
	{
		return default(Color);
	}

	// Token: 0x06001027 RID: 4135 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001027")]
	[Address(RVA = "0x35B500", Offset = "0x35A700", VA = "0x18035B500")]
	public void BounceAnimation()
	{
	}

	// Token: 0x06001028 RID: 4136 RVA: 0x00006510 File Offset: 0x00004710
	[Token(Token = "0x6001028")]
	[Address(RVA = "0x35BAE0", Offset = "0x35ACE0", VA = "0x18035BAE0")]
	public ItemValue GetItemValue()
	{
		return default(ItemValue);
	}

	// Token: 0x06001029 RID: 4137 RVA: 0x00006528 File Offset: 0x00004728
	[Token(Token = "0x6001029")]
	[Address(RVA = "0x35BB00", Offset = "0x35AD00", VA = "0x18035BB00")]
	public bool IsVisible()
	{
		return default(bool);
	}

	// Token: 0x0600102A RID: 4138 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600102A")]
	[Address(RVA = "0x35BE20", Offset = "0x35B020", VA = "0x18035BE20", Slot = "7")]
	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	// Token: 0x0600102B RID: 4139 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600102B")]
	[Address(RVA = "0x35BED0", Offset = "0x35B0D0", VA = "0x18035BED0", Slot = "11")]
	public void OnCancel(BaseEventData eventData)
	{
	}

	// Token: 0x0600102C RID: 4140 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600102C")]
	[Address(RVA = "0x35BFF0", Offset = "0x35B1F0", VA = "0x18035BFF0", Slot = "6")]
	public void OnDrag(PointerEventData eventData)
	{
	}

	// Token: 0x0600102D RID: 4141 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600102D")]
	[Address(RVA = "0x35C190", Offset = "0x35B390", VA = "0x18035C190", Slot = "8")]
	public void OnEndDrag(PointerEventData eventData)
	{
	}

	// Token: 0x0600102E RID: 4142 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600102E")]
	[Address(RVA = "0x35C220", Offset = "0x35B420", VA = "0x18035C220", Slot = "10")]
	public void OnPointerClick(PointerEventData eventData)
	{
	}

	// Token: 0x0600102F RID: 4143 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600102F")]
	[Address(RVA = "0x35C3A0", Offset = "0x35B5A0", VA = "0x18035C3A0", Slot = "4")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	// Token: 0x06001030 RID: 4144 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001030")]
	[Address(RVA = "0x316090", Offset = "0x315290", VA = "0x180316090", Slot = "5")]
	public void OnPointerUp(PointerEventData eventData)
	{
	}

	// Token: 0x06001031 RID: 4145 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001031")]
	[Address(RVA = "0x35C5E0", Offset = "0x35B7E0", VA = "0x18035C5E0", Slot = "9")]
	public void Receive(Slot slot)
	{
	}

	// Token: 0x06001032 RID: 4146 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001032")]
	[Address(RVA = "0x35C670", Offset = "0x35B870", VA = "0x18035C670")]
	public void Reload()
	{
	}

	// Token: 0x06001033 RID: 4147 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001033")]
	[Address(RVA = "0x35C6E0", Offset = "0x35B8E0", VA = "0x18035C6E0")]
	public void Reveal()
	{
	}

	// Token: 0x06001034 RID: 4148 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001034")]
	[Address(RVA = "0x35CCB0", Offset = "0x35BEB0", VA = "0x18035CCB0")]
	public void SetClass(ushort type, ushort threadType)
	{
	}

	// Token: 0x06001035 RID: 4149 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001035")]
	[Address(RVA = "0x35D0D0", Offset = "0x35C2D0", VA = "0x18035D0D0")]
	public void SetItemValue(ItemValue itemValue)
	{
	}

	// Token: 0x06001036 RID: 4150 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001036")]
	[Address(RVA = "0x35B6D0", Offset = "0x35A8D0", VA = "0x18035B6D0")]
	private void CancelTask()
	{
	}

	// Token: 0x06001037 RID: 4151 RVA: 0x00006540 File Offset: 0x00004740
	[Token(Token = "0x6001037")]
	[Address(RVA = "0x35B780", Offset = "0x35A980", VA = "0x18035B780")]
	private bool DidPress()
	{
		return default(bool);
	}

	// Token: 0x06001038 RID: 4152 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001038")]
	[Address(RVA = "0x35BD80", Offset = "0x35AF80", VA = "0x18035BD80")]
	private void LateUpdate()
	{
	}

	// Token: 0x06001039 RID: 4153 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001039")]
	[Address(RVA = "0x35BF70", Offset = "0x35B170", VA = "0x18035BF70")]
	private void OnDisable()
	{
	}

	// Token: 0x0600103A RID: 4154 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600103A")]
	[Address(RVA = "0x35C490", Offset = "0x35B690", VA = "0x18035C490")]
	private void PlayItemSfx()
	{
	}

	// Token: 0x0600103B RID: 4155 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600103B")]
	[Address(RVA = "0x35CF10", Offset = "0x35C110", VA = "0x18035CF10")]
	private void SetItemSprite(Sprite sprite)
	{
	}

	// Token: 0x0600103C RID: 4156 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600103C")]
	[Address(RVA = "0x35D240", Offset = "0x35C440", VA = "0x18035D240")]
	private void UpdateConditions()
	{
	}

	// Token: 0x0600103D RID: 4157 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600103D")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public Slot()
	{
	}

	// Token: 0x04000D7E RID: 3454
	[Token(Token = "0x4000D7E")]
	[FieldOffset(Offset = "0x0")]
	private static readonly Vector3[] s_corners;

	// Token: 0x04000D7F RID: 3455
	[Token(Token = "0x4000D7F")]
	[FieldOffset(Offset = "0x20")]
	public SlotController SlotController;

	// Token: 0x04000D80 RID: 3456
	[Token(Token = "0x4000D80")]
	[FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI CountLabel;

	// Token: 0x04000D81 RID: 3457
	[Token(Token = "0x4000D81")]
	[FieldOffset(Offset = "0x30")]
	public Image ItemImage;

	// Token: 0x04000D82 RID: 3458
	[Token(Token = "0x4000D82")]
	[FieldOffset(Offset = "0x38")]
	public SlotControlType ControlType;

	// Token: 0x04000D83 RID: 3459
	[Token(Token = "0x4000D83")]
	[FieldOffset(Offset = "0x40")]
	public TooltipActivator TooltipActivator;

	// Token: 0x04000D84 RID: 3460
	[Token(Token = "0x4000D84")]
	[FieldOffset(Offset = "0x48")]
	public TooltipSource Source;

	// Token: 0x04000D85 RID: 3461
	[Token(Token = "0x4000D85")]
	[FieldOffset(Offset = "0x50")]
	public bool ShowPlaceholder;

	// Token: 0x04000D86 RID: 3462
	[Token(Token = "0x4000D86")]
	[FieldOffset(Offset = "0x58")]
	public Image Background;

	// Token: 0x04000D87 RID: 3463
	[Token(Token = "0x4000D87")]
	[FieldOffset(Offset = "0x60")]
	public bool Hidden;

	// Token: 0x04000D88 RID: 3464
	[Token(Token = "0x4000D88")]
	[FieldOffset(Offset = "0x61")]
	public bool Swappable;

	// Token: 0x04000D89 RID: 3465
	[Token(Token = "0x4000D89")]
	[FieldOffset(Offset = "0x68")]
	public GameObject Content;

	// Token: 0x04000D8A RID: 3466
	[Token(Token = "0x4000D8A")]
	[FieldOffset(Offset = "0x70")]
	public Graphic Graphic;

	// Token: 0x04000D8B RID: 3467
	[Token(Token = "0x4000D8B")]
	[FieldOffset(Offset = "0x78")]
	public ScrollRect Scroll;

	// Token: 0x04000D8C RID: 3468
	[Token(Token = "0x4000D8C")]
	[FieldOffset(Offset = "0x80")]
	public bool PlaySfx;

	// Token: 0x04000D8D RID: 3469
	[Token(Token = "0x4000D8D")]
	[FieldOffset(Offset = "0x82")]
	public ushort TestType;

	// Token: 0x04000D8E RID: 3470
	[Token(Token = "0x4000D8E")]
	[FieldOffset(Offset = "0x84")]
	public ushort TestCount;

	// Token: 0x04000D8F RID: 3471
	[Token(Token = "0x4000D8F")]
	[FieldOffset(Offset = "0x88")]
	public uint EntityId;

	// Token: 0x04000D90 RID: 3472
	[Token(Token = "0x4000D90")]
	[FieldOffset(Offset = "0x8C")]
	public int Index;

	// Token: 0x04000D91 RID: 3473
	[Token(Token = "0x4000D91")]
	[FieldOffset(Offset = "0x90")]
	private ItemValue _itemValue;

	// Token: 0x04000D92 RID: 3474
	[Token(Token = "0x4000D92")]
	[FieldOffset(Offset = "0x9A")]
	private bool _didSelect;

	// Token: 0x04000D93 RID: 3475
	[Token(Token = "0x4000D93")]
	[FieldOffset(Offset = "0xA0")]
	private SfxClip _sfx;

	// Token: 0x04000D94 RID: 3476
	[Token(Token = "0x4000D94")]
	[FieldOffset(Offset = "0xA8")]
	private ushort _classType;

	// Token: 0x04000D95 RID: 3477
	[Token(Token = "0x4000D95")]
	[FieldOffset(Offset = "0xAC")]
	private Rarity _maxRarity;

	// Token: 0x04000D96 RID: 3478
	[Token(Token = "0x4000D96")]
	[FieldOffset(Offset = "0xB0")]
	private AnimateTask _task;

	// Token: 0x04000D97 RID: 3479
	[Token(Token = "0x4000D97")]
	[FieldOffset(Offset = "0xB8")]
	private float _lastTap;

	// Token: 0x04000D98 RID: 3480
	[Token(Token = "0x4000D98")]
	[FieldOffset(Offset = "0xBC")]
	private float _tapCount;
}
