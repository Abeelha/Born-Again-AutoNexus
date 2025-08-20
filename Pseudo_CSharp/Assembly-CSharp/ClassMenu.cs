using System;
using System.Threading.Tasks;
using Il2CppDummyDll;
using Ronin.Api.Model.CharacterSlot;
using Ronin.Model.Definitions;
using Ronin.Model.Enums;

// Token: 0x020000FA RID: 250
[Token(Token = "0x20000FA")]
public class ClassMenu : GalleryMenu
{
	// Token: 0x06000449 RID: 1097 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000449")]
	[Address(RVA = "0x3BD8B0", Offset = "0x3BCAB0", VA = "0x1803BD8B0", Slot = "9")]
	public override void Back()
	{
	}

	// Token: 0x0600044A RID: 1098 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600044A")]
	[Address(RVA = "0x3C2050", Offset = "0x3C1250", VA = "0x1803C2050")]
	public void Purchase(CurrencyType currencyType)
	{
	}

	// Token: 0x0600044B RID: 1099 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600044B")]
	[Address(RVA = "0x3C23F0", Offset = "0x3C15F0", VA = "0x1803C23F0", Slot = "10")]
	public override void Select()
	{
	}

	// Token: 0x0600044C RID: 1100 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600044C")]
	[Address(RVA = "0x3C27C0", Offset = "0x3C19C0", VA = "0x1803C27C0")]
	public void Setup(GetCharacterSlotResponse characterSlot, BlessingDefinition thread)
	{
	}

	// Token: 0x0600044D RID: 1101 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600044D")]
	[Address(RVA = "0x3C1890", Offset = "0x3C0A90", VA = "0x1803C1890", Slot = "11")]
	protected override void LoadItems()
	{
	}

	// Token: 0x0600044E RID: 1102 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600044E")]
	[Address(RVA = "0x3C1DF0", Offset = "0x3C0FF0", VA = "0x1803C1DF0", Slot = "5")]
	protected override void OnEnter()
	{
	}

	// Token: 0x0600044F RID: 1103 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600044F")]
	[Address(RVA = "0x3C1710", Offset = "0x3C0910", VA = "0x1803C1710")]
	private void Awake()
	{
	}

	// Token: 0x06000450 RID: 1104 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000450")]
	[Address(RVA = "0x3C1750", Offset = "0x3C0950", VA = "0x1803C1750")]
	private Task CreateCharacterAsync(GetCharacterSlotResponse characterSlot, BlessingDefinition thread, CharacterDefinition @class)
	{
		return null;
	}

	// Token: 0x06000451 RID: 1105 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000451")]
	[Address(RVA = "0x3C1CB0", Offset = "0x3C0EB0", VA = "0x1803C1CB0")]
	private Task NewThreadWarnAsync(GetCharacterSlotResponse characterSlot, BlessingDefinition thread, CharacterDefinition @class)
	{
		return null;
	}

	// Token: 0x06000452 RID: 1106 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000452")]
	[Address(RVA = "0x3C1E30", Offset = "0x3C1030", VA = "0x1803C1E30")]
	private Task PlayAsync(GetCharacterSlotResponse characterSlot)
	{
		return null;
	}

	// Token: 0x06000453 RID: 1107 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000453")]
	[Address(RVA = "0x3C1F20", Offset = "0x3C1120", VA = "0x1803C1F20")]
	private Task PurchaseCharacterAsync(ClassDisplay classDisplay, CurrencyType currencyType, int cost)
	{
		return null;
	}

	// Token: 0x06000454 RID: 1108 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000454")]
	[Address(RVA = "0x3C13F0", Offset = "0x3C05F0", VA = "0x1803C13F0")]
	public ClassMenu()
	{
	}

	// Token: 0x04000472 RID: 1138
	[Token(Token = "0x4000472")]
	[FieldOffset(Offset = "0xC8")]
	public GetCharacterSlotResponse CharacterSlot;

	// Token: 0x04000473 RID: 1139
	[Token(Token = "0x4000473")]
	[FieldOffset(Offset = "0xD0")]
	public BlessingDefinition Thread;

	// Token: 0x04000474 RID: 1140
	[Token(Token = "0x4000474")]
	[FieldOffset(Offset = "0xD8")]
	public BlessingStrand ThreadStrand;

	// Token: 0x04000475 RID: 1141
	[Token(Token = "0x4000475")]
	[FieldOffset(Offset = "0xE0")]
	public ClassDisplay ClassDisplayPrefab;
}
