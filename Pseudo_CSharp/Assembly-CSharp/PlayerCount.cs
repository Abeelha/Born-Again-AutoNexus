using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x020001CD RID: 461
[Token(Token = "0x20001CD")]
public class PlayerCount : MonoBehaviour
{
	// Token: 0x0600094B RID: 2379 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600094B")]
	[Address(RVA = "0x42CB10", Offset = "0x42BD10", VA = "0x18042CB10")]
	public void LanguageChanged()
	{
	}

	// Token: 0x0600094C RID: 2380 RVA: 0x00004530 File Offset: 0x00002730
	[Token(Token = "0x600094C")]
	[Address(RVA = "0x42C940", Offset = "0x42BB40", VA = "0x18042C940")]
	private int GetPlayerCount()
	{
		return 0;
	}

	// Token: 0x0600094D RID: 2381 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600094D")]
	[Address(RVA = "0x42CB20", Offset = "0x42BD20", VA = "0x18042CB20")]
	private void LateUpdate()
	{
	}

	// Token: 0x0600094E RID: 2382 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600094E")]
	[Address(RVA = "0x42CB60", Offset = "0x42BD60", VA = "0x18042CB60")]
	private void UpdateLabel()
	{
	}

	// Token: 0x0600094F RID: 2383 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600094F")]
	[Address(RVA = "0x42CDD0", Offset = "0x42BFD0", VA = "0x18042CDD0")]
	public PlayerCount()
	{
	}

	// Token: 0x040008D1 RID: 2257
	[Token(Token = "0x40008D1")]
	[FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI Label;

	// Token: 0x040008D2 RID: 2258
	[Token(Token = "0x40008D2")]
	[FieldOffset(Offset = "0x28")]
	private int _setCount;
}
