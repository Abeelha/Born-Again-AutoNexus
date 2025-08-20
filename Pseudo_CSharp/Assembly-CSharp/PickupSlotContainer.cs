using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002DA RID: 730
[Token(Token = "0x20002DA")]
public class PickupSlotContainer : MonoBehaviour
{
	// Token: 0x170001CB RID: 459
	// (get) Token: 0x06000FD6 RID: 4054 RVA: 0x00006438 File Offset: 0x00004638
	// (set) Token: 0x06000FD7 RID: 4055 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001CB")]
	public int SlotContainerCount
	{
		[Token(Token = "0x6000FD6")]
		[Address(RVA = "0x354EF0", Offset = "0x3540F0", VA = "0x180354EF0")]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000FD7")]
		[Address(RVA = "0x355040", Offset = "0x354240", VA = "0x180355040")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x170001CC RID: 460
	// (get) Token: 0x06000FD8 RID: 4056 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x170001CC")]
	public RectTransform RectTransform
	{
		[Token(Token = "0x6000FD8")]
		[Address(RVA = "0x354E90", Offset = "0x354090", VA = "0x180354E90")]
		get
		{
			return null;
		}
	}

	// Token: 0x170001CD RID: 461
	// (get) Token: 0x06000FD9 RID: 4057 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x170001CD")]
	public IEnumerable<Slot> Slots
	{
		[Token(Token = "0x6000FD9")]
		[Address(RVA = "0x354F00", Offset = "0x354100", VA = "0x180354F00")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000FDA RID: 4058 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FDA")]
	[Address(RVA = "0x3546D0", Offset = "0x3538D0", VA = "0x1803546D0")]
	public void SetItems(ushort classType, ushort threadType, IEnumerable<IPickupContainer> containers)
	{
	}

	// Token: 0x06000FDB RID: 4059 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FDB")]
	[Address(RVA = "0x353DE0", Offset = "0x352FE0", VA = "0x180353DE0")]
	private void Awake()
	{
	}

	// Token: 0x06000FDC RID: 4060 RVA: 0x00006450 File Offset: 0x00004650
	[Token(Token = "0x6000FDC")]
	[Address(RVA = "0x353E60", Offset = "0x353060", VA = "0x180353E60")]
	private ValueTuple<GameObject, Slot> GetSlotContainer()
	{
		return default(ValueTuple<GameObject, Slot>);
	}

	// Token: 0x06000FDD RID: 4061 RVA: 0x00006468 File Offset: 0x00004668
	[Token(Token = "0x6000FDD")]
	[Address(RVA = "0x3540B0", Offset = "0x3532B0", VA = "0x1803540B0")]
	private int GetSpriteIndex(int index, int maxIndex)
	{
		return 0;
	}

	// Token: 0x06000FDE RID: 4062 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FDE")]
	[Address(RVA = "0x3541E0", Offset = "0x3533E0", VA = "0x1803541E0")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000FDF RID: 4063 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FDF")]
	[Address(RVA = "0x354E10", Offset = "0x354010", VA = "0x180354E10")]
	public PickupSlotContainer()
	{
	}

	// Token: 0x04000D2B RID: 3371
	[Token(Token = "0x4000D2B")]
	[FieldOffset(Offset = "0x20")]
	public GameObject SlotPrefab;

	// Token: 0x04000D2C RID: 3372
	[Token(Token = "0x4000D2C")]
	[FieldOffset(Offset = "0x28")]
	public Sprite[] PickupSprites;

	// Token: 0x04000D2D RID: 3373
	[Token(Token = "0x4000D2D")]
	[FieldOffset(Offset = "0x30")]
	private readonly List<ValueTuple<GameObject, Slot>> _slotContainers;

	// Token: 0x04000D2E RID: 3374
	[Token(Token = "0x4000D2E")]
	[FieldOffset(Offset = "0x38")]
	private Option _pickupOption;

	// Token: 0x04000D2F RID: 3375
	[Token(Token = "0x4000D2F")]
	[FieldOffset(Offset = "0x40")]
	private bool _pickupState;
}
