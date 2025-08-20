using System;
using Il2CppDummyDll;

// Token: 0x02000118 RID: 280
[Token(Token = "0x2000118")]
public class LeaderboardSelectionMenu : GalleryMenu
{
	// Token: 0x060004CC RID: 1228 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004CC")]
	[Address(RVA = "0x3BD8B0", Offset = "0x3BCAB0", VA = "0x1803BD8B0", Slot = "9")]
	public override void Back()
	{
	}

	// Token: 0x060004CD RID: 1229 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004CD")]
	[Address(RVA = "0x3D8A20", Offset = "0x3D7C20", VA = "0x1803D8A20", Slot = "10")]
	public override void Select()
	{
	}

	// Token: 0x060004CE RID: 1230 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004CE")]
	[Address(RVA = "0x3D8470", Offset = "0x3D7670", VA = "0x1803D8470", Slot = "11")]
	protected override void LoadItems()
	{
	}

	// Token: 0x060004CF RID: 1231 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004CF")]
	[Address(RVA = "0x3D8990", Offset = "0x3D7B90", VA = "0x1803D8990", Slot = "5")]
	protected override void OnEnter()
	{
	}

	// Token: 0x060004D0 RID: 1232 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004D0")]
	[Address(RVA = "0x3D8430", Offset = "0x3D7630", VA = "0x1803D8430")]
	private void Awake()
	{
	}

	// Token: 0x060004D1 RID: 1233 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004D1")]
	[Address(RVA = "0x3BC980", Offset = "0x3BBB80", VA = "0x1803BC980")]
	public LeaderboardSelectionMenu()
	{
	}

	// Token: 0x04000523 RID: 1315
	[Token(Token = "0x4000523")]
	[FieldOffset(Offset = "0xC8")]
	public LeaderboardMenu LeaderboardMenu;

	// Token: 0x04000524 RID: 1316
	[Token(Token = "0x4000524")]
	[FieldOffset(Offset = "0xD0")]
	public LeaderboardSpanSelector Selector;

	// Token: 0x04000525 RID: 1317
	[Token(Token = "0x4000525")]
	[FieldOffset(Offset = "0xD8")]
	public ThreadDisplay ThreadDisplayPrefab;

	// Token: 0x04000526 RID: 1318
	[Token(Token = "0x4000526")]
	[FieldOffset(Offset = "0xE0")]
	private bool _didPushLeaderboard;

	// Token: 0x04000527 RID: 1319
	[Token(Token = "0x4000527")]
	[FieldOffset(Offset = "0xE4")]
	private int _selectIndex;

	// Token: 0x04000528 RID: 1320
	[Token(Token = "0x4000528")]
	[FieldOffset(Offset = "0xE8")]
	private ushort _selectType;
}
