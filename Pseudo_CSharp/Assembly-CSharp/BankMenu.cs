using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Ronin.Model.Data;
using Ronin.Model.Enums;
using UnityEngine;
using Zero.Game.Shared;

// Token: 0x020000E5 RID: 229
[Token(Token = "0x20000E5")]
public class BankMenu : Menu, IDataHandler<BankInfoData>, IDataHandler<BankRowData>
{
	// Token: 0x17000050 RID: 80
	// (get) Token: 0x060003F0 RID: 1008 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x17000050")]
	public IEnumerable<Slot> AllSlots
	{
		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x3BF720", Offset = "0x3BE920", VA = "0x1803BF720")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000051 RID: 81
	// (get) Token: 0x060003F1 RID: 1009 RVA: 0x000032E8 File Offset: 0x000014E8
	// (set) Token: 0x060003F2 RID: 1010 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000051")]
	public uint BankId
	{
		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x3BF840", Offset = "0x3BEA40", VA = "0x1803BF840")]
		[CompilerGenerated]
		get
		{
			return 0U;
		}
		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x3BF850", Offset = "0x3BEA50", VA = "0x1803BF850")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x060003F3 RID: 1011 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003F3")]
	[Address(RVA = "0x3BDEF0", Offset = "0x3BD0F0", VA = "0x1803BDEF0")]
	public void Clear()
	{
	}

	// Token: 0x060003F4 RID: 1012 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003F4")]
	[Address(RVA = "0x3BE410", Offset = "0x3BD610", VA = "0x1803BE410", Slot = "9")]
	public void HandleData(ref BankInfoData data)
	{
	}

	// Token: 0x060003F5 RID: 1013 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003F5")]
	[Address(RVA = "0x3BE7F0", Offset = "0x3BD9F0", VA = "0x1803BE7F0", Slot = "10")]
	public void HandleData(ref BankRowData data)
	{
	}

	// Token: 0x060003F6 RID: 1014 RVA: 0x00003300 File Offset: 0x00001500
	[Token(Token = "0x60003F6")]
	[Address(RVA = "0x3BE090", Offset = "0x3BD290", VA = "0x1803BE090")]
	public int GetFirstAvailableIndex()
	{
		return 0;
	}

	// Token: 0x060003F7 RID: 1015 RVA: 0x00003318 File Offset: 0x00001518
	[Token(Token = "0x60003F7")]
	[Address(RVA = "0x3BE200", Offset = "0x3BD400", VA = "0x1803BE200")]
	public int GetFirstPartialStack(ushort type)
	{
		return 0;
	}

	// Token: 0x060003F8 RID: 1016 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003F8")]
	[Address(RVA = "0x3BF000", Offset = "0x3BE200", VA = "0x1803BF000")]
	public void Purchase(CurrencyType currencyType)
	{
	}

	// Token: 0x060003F9 RID: 1017 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003F9")]
	[Address(RVA = "0x3BEFE0", Offset = "0x3BE1E0", VA = "0x1803BEFE0")]
	public void PurchaseHonor()
	{
	}

	// Token: 0x060003FA RID: 1018 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003FA")]
	[Address(RVA = "0x3BEFF0", Offset = "0x3BE1F0", VA = "0x1803BEFF0")]
	public void PurchaseMedallions()
	{
	}

	// Token: 0x060003FB RID: 1019 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003FB")]
	[Address(RVA = "0x3BF2D0", Offset = "0x3BE4D0", VA = "0x1803BF2D0")]
	public void Setup(Entity bankEntity)
	{
	}

	// Token: 0x060003FC RID: 1020 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003FC")]
	[Address(RVA = "0x3BF570", Offset = "0x3BE770", VA = "0x1803BF570")]
	public void Toggle(Entity bankEntity)
	{
	}

	// Token: 0x060003FD RID: 1021 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60003FD")]
	[Address(RVA = "0x3BDF50", Offset = "0x3BD150", VA = "0x1803BDF50")]
	private BankRow CreateRow()
	{
		return null;
	}

	// Token: 0x060003FE RID: 1022 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003FE")]
	[Address(RVA = "0x3BEA30", Offset = "0x3BDC30", VA = "0x1803BEA30")]
	private void LayoutRows()
	{
	}

	// Token: 0x060003FF RID: 1023 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003FF")]
	[Address(RVA = "0x3BE920", Offset = "0x3BDB20", VA = "0x1803BE920")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000400 RID: 1024 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000400")]
	[Address(RVA = "0x3BEEF0", Offset = "0x3BE0F0", VA = "0x1803BEEF0")]
	private void LoadBank()
	{
	}

	// Token: 0x06000401 RID: 1025 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000401")]
	[Address(RVA = "0x3BEFA0", Offset = "0x3BE1A0", VA = "0x1803BEFA0")]
	private void OnDisable()
	{
	}

	// Token: 0x06000402 RID: 1026 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000402")]
	[Address(RVA = "0x3BF5D0", Offset = "0x3BE7D0", VA = "0x1803BF5D0")]
	private void UpdateVisibility()
	{
	}

	// Token: 0x06000403 RID: 1027 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000403")]
	[Address(RVA = "0x3BF650", Offset = "0x3BE850", VA = "0x1803BF650")]
	public BankMenu()
	{
	}

	// Token: 0x040003F8 RID: 1016
	[Token(Token = "0x40003F8")]
	[FieldOffset(Offset = "0x90")]
	public World World;

	// Token: 0x040003F9 RID: 1017
	[Token(Token = "0x40003F9")]
	[FieldOffset(Offset = "0x98")]
	public GameObject Slots;

	// Token: 0x040003FA RID: 1018
	[Token(Token = "0x40003FA")]
	[FieldOffset(Offset = "0xA0")]
	public GameObject LoadingOverlay;

	// Token: 0x040003FB RID: 1019
	[Token(Token = "0x40003FB")]
	[FieldOffset(Offset = "0xA8")]
	public BankRow BankRowPrefab;

	// Token: 0x040003FC RID: 1020
	[Token(Token = "0x40003FC")]
	[FieldOffset(Offset = "0xB0")]
	public RectTransform ScrollContent;

	// Token: 0x040003FD RID: 1021
	[Token(Token = "0x40003FD")]
	[FieldOffset(Offset = "0xB8")]
	public RectTransform PurchaseRow;

	// Token: 0x040003FE RID: 1022
	[Token(Token = "0x40003FE")]
	[FieldOffset(Offset = "0xC0")]
	public PurchaseOptions PurchaseOptions;

	// Token: 0x040003FF RID: 1023
	[Token(Token = "0x40003FF")]
	[FieldOffset(Offset = "0xC8")]
	public GameTabController GameTabController;

	// Token: 0x04000400 RID: 1024
	[Token(Token = "0x4000400")]
	[FieldOffset(Offset = "0xD0")]
	private BankInfoData? _bankInfo;

	// Token: 0x04000401 RID: 1025
	[Token(Token = "0x4000401")]
	[FieldOffset(Offset = "0xE0")]
	private readonly List<BankRow> _bankRows;

	// Token: 0x04000402 RID: 1026
	[Token(Token = "0x4000402")]
	[FieldOffset(Offset = "0xE8")]
	private readonly List<BankRowData> _rowData;

	// Token: 0x04000403 RID: 1027
	[Token(Token = "0x4000403")]
	[FieldOffset(Offset = "0xF0")]
	private GameObject _startTab;

	// Token: 0x04000404 RID: 1028
	[Token(Token = "0x4000404")]
	[FieldOffset(Offset = "0xF8")]
	private bool _tabDidChange;
}
