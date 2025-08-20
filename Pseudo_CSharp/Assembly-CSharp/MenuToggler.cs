using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002C6 RID: 710
[Token(Token = "0x20002C6")]
public class MenuToggler : MonoBehaviour
{
	// Token: 0x06000F45 RID: 3909 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F45")]
	[Address(RVA = "0x46F4D0", Offset = "0x46E6D0", VA = "0x18046F4D0")]
	private void Awake()
	{
	}

	// Token: 0x06000F46 RID: 3910 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F46")]
	[Address(RVA = "0x46F5B0", Offset = "0x46E7B0", VA = "0x18046F5B0")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000F47 RID: 3911 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F47")]
	[Address(RVA = "0x46F5B0", Offset = "0x46E7B0", VA = "0x18046F5B0")]
	private void UpdateToggles()
	{
	}

	// Token: 0x06000F48 RID: 3912 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F48")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public MenuToggler()
	{
	}

	// Token: 0x04000CA5 RID: 3237
	[Token(Token = "0x4000CA5")]
	[FieldOffset(Offset = "0x20")]
	public UIManager UIManager;

	// Token: 0x04000CA6 RID: 3238
	[Token(Token = "0x4000CA6")]
	[FieldOffset(Offset = "0x28")]
	public GameTabController TabController;

	// Token: 0x04000CA7 RID: 3239
	[Token(Token = "0x4000CA7")]
	[FieldOffset(Offset = "0x30")]
	public GameObject InventoryTab;

	// Token: 0x04000CA8 RID: 3240
	[Token(Token = "0x4000CA8")]
	[FieldOffset(Offset = "0x38")]
	public GameObject PlayersTab;

	// Token: 0x04000CA9 RID: 3241
	[Token(Token = "0x4000CA9")]
	[FieldOffset(Offset = "0x40")]
	private Option _toggleOptions;

	// Token: 0x04000CAA RID: 3242
	[Token(Token = "0x4000CAA")]
	[FieldOffset(Offset = "0x48")]
	private Option _toggleMap;

	// Token: 0x04000CAB RID: 3243
	[Token(Token = "0x4000CAB")]
	[FieldOffset(Offset = "0x50")]
	private Option _toggleInventory;

	// Token: 0x04000CAC RID: 3244
	[Token(Token = "0x4000CAC")]
	[FieldOffset(Offset = "0x58")]
	private Option _togglePlayers;
}
