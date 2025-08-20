using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002EA RID: 746
[Token(Token = "0x20002EA")]
public class GameTabController : MonoBehaviour
{
	// Token: 0x170001D7 RID: 471
	// (get) Token: 0x06001077 RID: 4215 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x170001D7")]
	public GameObject SelectedTab
	{
		[Token(Token = "0x6001077")]
		[Address(RVA = "0x34FD40", Offset = "0x34EF40", VA = "0x18034FD40")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001078 RID: 4216 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001078")]
	[Address(RVA = "0x34F6F0", Offset = "0x34E8F0", VA = "0x18034F6F0")]
	public void CycleTabs()
	{
	}

	// Token: 0x06001079 RID: 4217 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001079")]
	[Address(RVA = "0x34FAF0", Offset = "0x34ECF0", VA = "0x18034FAF0")]
	public void SelectTab(GameObject tab)
	{
	}

	// Token: 0x0600107A RID: 4218 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600107A")]
	[Address(RVA = "0x34FB40", Offset = "0x34ED40", VA = "0x18034FB40")]
	public void ToggleTab(GameObject tab)
	{
	}

	// Token: 0x0600107B RID: 4219 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600107B")]
	[Address(RVA = "0x34F5C0", Offset = "0x34E7C0", VA = "0x18034F5C0")]
	private void Awake()
	{
	}

	// Token: 0x0600107C RID: 4220 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600107C")]
	[Address(RVA = "0x34F880", Offset = "0x34EA80", VA = "0x18034F880")]
	private void DoSelectTab(GameObject tab)
	{
	}

	// Token: 0x0600107D RID: 4221 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600107D")]
	[Address(RVA = "0x34F9C0", Offset = "0x34EBC0", VA = "0x18034F9C0")]
	private void LateUpdate()
	{
	}

	// Token: 0x0600107E RID: 4222 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600107E")]
	[Address(RVA = "0x34FC40", Offset = "0x34EE40", VA = "0x18034FC40")]
	private void UpdateEquipsVisibility()
	{
	}

	// Token: 0x0600107F RID: 4223 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600107F")]
	[Address(RVA = "0x34FBE0", Offset = "0x34EDE0", VA = "0x18034FBE0")]
	private void UpdateCycleTabs()
	{
	}

	// Token: 0x06001080 RID: 4224 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001080")]
	[Address(RVA = "0x34FD00", Offset = "0x34EF00", VA = "0x18034FD00")]
	private void UpdateInTrade()
	{
	}

	// Token: 0x06001081 RID: 4225 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001081")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public GameTabController()
	{
	}

	// Token: 0x04000DC5 RID: 3525
	[Token(Token = "0x4000DC5")]
	[FieldOffset(Offset = "0x20")]
	public GameObject Equips;

	// Token: 0x04000DC6 RID: 3526
	[Token(Token = "0x4000DC6")]
	[FieldOffset(Offset = "0x28")]
	public GameObject[] Tabs;

	// Token: 0x04000DC7 RID: 3527
	[Token(Token = "0x4000DC7")]
	[FieldOffset(Offset = "0x30")]
	public TradeMenu TradeMenu;

	// Token: 0x04000DC8 RID: 3528
	[Token(Token = "0x4000DC8")]
	[FieldOffset(Offset = "0x38")]
	public GameObject InventoryTab;

	// Token: 0x04000DC9 RID: 3529
	[Token(Token = "0x4000DC9")]
	[FieldOffset(Offset = "0x40")]
	private GameObject _selectedTab;

	// Token: 0x04000DCA RID: 3530
	[Token(Token = "0x4000DCA")]
	[FieldOffset(Offset = "0x48")]
	private Option _cycleTabsOption;

	// Token: 0x04000DCB RID: 3531
	[Token(Token = "0x4000DCB")]
	[FieldOffset(Offset = "0x50")]
	private Option _openedTabOption;
}
