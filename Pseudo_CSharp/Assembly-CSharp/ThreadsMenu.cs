using System;
using Il2CppDummyDll;
using Ronin.Api.Model.CharacterSlot;

// Token: 0x02000131 RID: 305
[Token(Token = "0x2000131")]
public class ThreadsMenu : GalleryMenu
{
	// Token: 0x0600054C RID: 1356 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600054C")]
	[Address(RVA = "0x3BD8B0", Offset = "0x3BCAB0", VA = "0x1803BD8B0", Slot = "9")]
	public override void Back()
	{
	}

	// Token: 0x0600054D RID: 1357 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600054D")]
	[Address(RVA = "0x3DF3E0", Offset = "0x3DE5E0", VA = "0x1803DF3E0", Slot = "10")]
	public override void Select()
	{
	}

	// Token: 0x0600054E RID: 1358 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600054E")]
	[Address(RVA = "0x3DF4B0", Offset = "0x3DE6B0", VA = "0x1803DF4B0")]
	public void Setup(GetCharacterSlotResponse characterSlot)
	{
	}

	// Token: 0x0600054F RID: 1359 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600054F")]
	[Address(RVA = "0x3DEDC0", Offset = "0x3DDFC0", VA = "0x1803DEDC0", Slot = "11")]
	protected override void LoadItems()
	{
	}

	// Token: 0x06000550 RID: 1360 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000550")]
	[Address(RVA = "0x3DF2E0", Offset = "0x3DE4E0", VA = "0x1803DF2E0", Slot = "5")]
	protected override void OnEnter()
	{
	}

	// Token: 0x06000551 RID: 1361 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000551")]
	[Address(RVA = "0x3D8430", Offset = "0x3D7630", VA = "0x1803D8430")]
	private void Awake()
	{
	}

	// Token: 0x06000552 RID: 1362 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000552")]
	[Address(RVA = "0x3BC980", Offset = "0x3BBB80", VA = "0x1803BC980")]
	public ThreadsMenu()
	{
	}

	// Token: 0x040005BA RID: 1466
	[Token(Token = "0x40005BA")]
	[FieldOffset(Offset = "0xC8")]
	public GetCharacterSlotResponse CharacterSlot;

	// Token: 0x040005BB RID: 1467
	[Token(Token = "0x40005BB")]
	[FieldOffset(Offset = "0xD0")]
	public ClassMenu ClassMenu;

	// Token: 0x040005BC RID: 1468
	[Token(Token = "0x40005BC")]
	[FieldOffset(Offset = "0xD8")]
	public ThreadDisplay ThreadDisplayPrefab;

	// Token: 0x040005BD RID: 1469
	[Token(Token = "0x40005BD")]
	[FieldOffset(Offset = "0xE0")]
	private bool _didPushClasses;

	// Token: 0x040005BE RID: 1470
	[Token(Token = "0x40005BE")]
	[FieldOffset(Offset = "0xE4")]
	private int _selectIndex;

	// Token: 0x040005BF RID: 1471
	[Token(Token = "0x40005BF")]
	[FieldOffset(Offset = "0xE8")]
	private ushort _selectType;
}
