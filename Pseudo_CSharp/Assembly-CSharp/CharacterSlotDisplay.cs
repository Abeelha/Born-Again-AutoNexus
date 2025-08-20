using System;
using Il2CppDummyDll;
using Ronin.Api.Model.CharacterSlot;
using UnityEngine;

// Token: 0x020000EA RID: 234
[Token(Token = "0x20000EA")]
public class CharacterSlotDisplay : MonoBehaviour
{
	// Token: 0x06000412 RID: 1042 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000412")]
	[Address(RVA = "0x3C0170", Offset = "0x3BF370", VA = "0x1803C0170")]
	public void Setup(GetCharacterSlotResponse characterSlot)
	{
	}

	// Token: 0x06000413 RID: 1043 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000413")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public CharacterSlotDisplay()
	{
	}

	// Token: 0x0400041B RID: 1051
	[Token(Token = "0x400041B")]
	[FieldOffset(Offset = "0x20")]
	public CharacterImage CharacterImage;

	// Token: 0x0400041C RID: 1052
	[Token(Token = "0x400041C")]
	[FieldOffset(Offset = "0x28")]
	public GetCharacterSlotResponse CharacterSlot;
}
