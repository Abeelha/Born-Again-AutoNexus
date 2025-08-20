using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x0200008D RID: 141
[Token(Token = "0x200008D")]
public class SteamButton : MonoBehaviour
{
	// Token: 0x06000288 RID: 648 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000288")]
	[Address(RVA = "0x344080", Offset = "0x343280", VA = "0x180344080")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000289 RID: 649 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000289")]
	[Address(RVA = "0x343F10", Offset = "0x343110", VA = "0x180343F10")]
	private string GetUsername()
	{
		return null;
	}

	// Token: 0x0600028A RID: 650 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600028A")]
	[Address(RVA = "0x344320", Offset = "0x343520", VA = "0x180344320")]
	public SteamButton()
	{
	}

	// Token: 0x0400022E RID: 558
	[Token(Token = "0x400022E")]
	[FieldOffset(Offset = "0x20")]
	public string PlaceholderText;

	// Token: 0x0400022F RID: 559
	[Token(Token = "0x400022F")]
	[FieldOffset(Offset = "0x28")]
	public TMP_Text Username;

	// Token: 0x04000230 RID: 560
	[Token(Token = "0x4000230")]
	[FieldOffset(Offset = "0x30")]
	private ulong? _linkedId;
}
