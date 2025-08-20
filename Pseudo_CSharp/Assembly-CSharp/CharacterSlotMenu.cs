using System;
using System.Threading.Tasks;
using Il2CppDummyDll;
using Ronin.Model.Enums;

// Token: 0x020000F6 RID: 246
[Token(Token = "0x20000F6")]
public class CharacterSlotMenu : GalleryMenu
{
	// Token: 0x06000438 RID: 1080 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000438")]
	[Address(RVA = "0x3C0D00", Offset = "0x3BFF00", VA = "0x1803C0D00")]
	public void Purchase(CurrencyType currencyType)
	{
	}

	// Token: 0x06000439 RID: 1081 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000439")]
	[Address(RVA = "0x3C1010", Offset = "0x3C0210", VA = "0x1803C1010")]
	public void Resync()
	{
	}

	// Token: 0x0600043A RID: 1082 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600043A")]
	[Address(RVA = "0x3C10D0", Offset = "0x3C02D0", VA = "0x1803C10D0", Slot = "10")]
	public override void Select()
	{
	}

	// Token: 0x0600043B RID: 1083 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600043B")]
	[Address(RVA = "0x3C1020", Offset = "0x3C0220", VA = "0x1803C1020")]
	public void SelectAlt()
	{
	}

	// Token: 0x0600043C RID: 1084 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600043C")]
	[Address(RVA = "0x3C0650", Offset = "0x3BF850", VA = "0x1803C0650", Slot = "5")]
	protected override void OnEnter()
	{
	}

	// Token: 0x0600043D RID: 1085 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600043D")]
	[Address(RVA = "0x3C0300", Offset = "0x3BF500", VA = "0x1803C0300", Slot = "11")]
	protected override void LoadItems()
	{
	}

	// Token: 0x0600043E RID: 1086 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600043E")]
	[Address(RVA = "0x3C02A0", Offset = "0x3BF4A0", VA = "0x1803C02A0")]
	private void Awake()
	{
	}

	// Token: 0x0600043F RID: 1087 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600043F")]
	[Address(RVA = "0x3C01C0", Offset = "0x3BF3C0", VA = "0x1803C01C0")]
	private Task AutoPlayAsync()
	{
		return null;
	}

	// Token: 0x06000440 RID: 1088 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000440")]
	[Address(RVA = "0x3C0BD0", Offset = "0x3BFDD0", VA = "0x1803C0BD0")]
	private Task PurchaseCharacterSlotAsync(StartCharacterSlotDisplay startCharacterSlotDisplay, int cost, CurrencyType currencyType)
	{
		return null;
	}

	// Token: 0x06000441 RID: 1089 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000441")]
	[Address(RVA = "0x3C13F0", Offset = "0x3C05F0", VA = "0x1803C13F0")]
	public CharacterSlotMenu()
	{
	}

	// Token: 0x04000453 RID: 1107
	[Token(Token = "0x4000453")]
	[FieldOffset(Offset = "0xC8")]
	public ThreadsMenu ThreadsMenu;

	// Token: 0x04000454 RID: 1108
	[Token(Token = "0x4000454")]
	[FieldOffset(Offset = "0xD0")]
	public ClassMenu ClassMenu;

	// Token: 0x04000455 RID: 1109
	[Token(Token = "0x4000455")]
	[FieldOffset(Offset = "0xD8")]
	public LeaderboardSelectionMenu LeaderboardSelectionMenu;

	// Token: 0x04000456 RID: 1110
	[Token(Token = "0x4000456")]
	[FieldOffset(Offset = "0xE0")]
	public GraveyardMenu GraveyardMenu;

	// Token: 0x04000457 RID: 1111
	[Token(Token = "0x4000457")]
	[FieldOffset(Offset = "0xE8")]
	public AccountLoadMenu AccountLoadMenu;

	// Token: 0x04000458 RID: 1112
	[Token(Token = "0x4000458")]
	[FieldOffset(Offset = "0xF0")]
	public SessionMenu SessionMenu;

	// Token: 0x04000459 RID: 1113
	[Token(Token = "0x4000459")]
	[FieldOffset(Offset = "0xF8")]
	public CharacterSlotDisplay CharacterSlotDisplayPrefab;

	// Token: 0x0400045A RID: 1114
	[Token(Token = "0x400045A")]
	[FieldOffset(Offset = "0x100")]
	public StartCharacterSlotDisplay StartCharacterSlotDisplayPrefab;

	// Token: 0x0400045B RID: 1115
	[Token(Token = "0x400045B")]
	[FieldOffset(Offset = "0x108")]
	public GraveyardDisplay GraveyardDisplay;

	// Token: 0x0400045C RID: 1116
	[Token(Token = "0x400045C")]
	[FieldOffset(Offset = "0x110")]
	private bool _didPushMenu;
}
