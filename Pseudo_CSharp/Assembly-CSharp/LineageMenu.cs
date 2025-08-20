using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Il2CppDummyDll;
using Ronin.Api.Model.Character;
using Ronin.Api.Model.CharacterSlot;
using TMPro;

// Token: 0x0200011A RID: 282
[Token(Token = "0x200011A")]
public class LineageMenu : Menu
{
	// Token: 0x060004D6 RID: 1238 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004D6")]
	[Address(RVA = "0x3D8FD0", Offset = "0x3D81D0", VA = "0x1803D8FD0")]
	public void SelectNext()
	{
	}

	// Token: 0x060004D7 RID: 1239 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004D7")]
	[Address(RVA = "0x3D9050", Offset = "0x3D8250", VA = "0x1803D9050")]
	public void SelectPrevious()
	{
	}

	// Token: 0x060004D8 RID: 1240 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004D8")]
	[Address(RVA = "0x3D9500", Offset = "0x3D8700", VA = "0x1803D9500")]
	public void Setup(GetCharacterSlotResponse characterSlot)
	{
	}

	// Token: 0x060004D9 RID: 1241 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004D9")]
	[Address(RVA = "0x3D8FA0", Offset = "0x3D81A0", VA = "0x1803D8FA0", Slot = "5")]
	protected override void OnEnter()
	{
	}

	// Token: 0x060004DA RID: 1242 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60004DA")]
	[Address(RVA = "0x3D8ED0", Offset = "0x3D80D0", VA = "0x1803D8ED0")]
	private Task LoadAsync()
	{
		return null;
	}

	// Token: 0x060004DB RID: 1243 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004DB")]
	[Address(RVA = "0x3D9070", Offset = "0x3D8270", VA = "0x1803D9070")]
	private void SetKilledBy(GetCharacterResponse character)
	{
	}

	// Token: 0x060004DC RID: 1244 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004DC")]
	[Address(RVA = "0x3D95D0", Offset = "0x3D87D0", VA = "0x1803D95D0")]
	private void SyncCharacters()
	{
	}

	// Token: 0x060004DD RID: 1245 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004DD")]
	[Address(RVA = "0x3D97E0", Offset = "0x3D89E0", VA = "0x1803D97E0")]
	private void TryLoad()
	{
	}

	// Token: 0x060004DE RID: 1246 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004DE")]
	[Address(RVA = "0x3D9960", Offset = "0x3D8B60", VA = "0x1803D9960")]
	public LineageMenu()
	{
	}

	// Token: 0x0400052C RID: 1324
	[Token(Token = "0x400052C")]
	[FieldOffset(Offset = "0x90")]
	private readonly List<GetCharacterResponse> _characterList;

	// Token: 0x0400052D RID: 1325
	[Token(Token = "0x400052D")]
	[FieldOffset(Offset = "0x98")]
	private int _currentIndex;

	// Token: 0x0400052E RID: 1326
	[Token(Token = "0x400052E")]
	[FieldOffset(Offset = "0x9C")]
	private bool _loading;

	// Token: 0x0400052F RID: 1327
	[Token(Token = "0x400052F")]
	[FieldOffset(Offset = "0xA0")]
	public CharacterImage Previous;

	// Token: 0x04000530 RID: 1328
	[Token(Token = "0x4000530")]
	[FieldOffset(Offset = "0xA8")]
	public CharacterImage Next;

	// Token: 0x04000531 RID: 1329
	[Token(Token = "0x4000531")]
	[FieldOffset(Offset = "0xB0")]
	public CharacterImage Current;

	// Token: 0x04000532 RID: 1330
	[Token(Token = "0x4000532")]
	[FieldOffset(Offset = "0xB8")]
	public CharacterImage KilledBy;

	// Token: 0x04000533 RID: 1331
	[Token(Token = "0x4000533")]
	[FieldOffset(Offset = "0xC0")]
	public TextMeshProUGUI KilledByLabel;

	// Token: 0x04000534 RID: 1332
	[Token(Token = "0x4000534")]
	[FieldOffset(Offset = "0xC8")]
	public TextMeshProUGUI KilledByNameLabel;

	// Token: 0x04000535 RID: 1333
	[Token(Token = "0x4000535")]
	[FieldOffset(Offset = "0xD0")]
	public TextMeshProUGUI KilledMomentLabel;
}
