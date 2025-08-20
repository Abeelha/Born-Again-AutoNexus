using System;
using Il2CppDummyDll;
using Ronin.Api.Model.CharacterSlot;
using UnityEngine;

// Token: 0x020000F1 RID: 241
[Token(Token = "0x20000F1")]
public class StartCharacterSlotDisplay : MonoBehaviour
{
	// Token: 0x06000426 RID: 1062 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000426")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public StartCharacterSlotDisplay()
	{
	}

	// Token: 0x04000434 RID: 1076
	[Token(Token = "0x4000434")]
	[FieldOffset(Offset = "0x20")]
	public GetCharacterSlotResponse CharacterSlot;
}
