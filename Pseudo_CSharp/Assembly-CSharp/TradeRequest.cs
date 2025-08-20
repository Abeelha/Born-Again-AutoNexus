using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x020002E1 RID: 737
[Token(Token = "0x20002E1")]
public class TradeRequest : MonoBehaviour
{
	// Token: 0x0600100F RID: 4111 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600100F")]
	[Address(RVA = "0x363500", Offset = "0x362700", VA = "0x180363500")]
	public void Setup(string traderName)
	{
	}

	// Token: 0x06001010 RID: 4112 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001010")]
	[Address(RVA = "0x3635F0", Offset = "0x3627F0", VA = "0x1803635F0")]
	public void Trade()
	{
	}

	// Token: 0x06001011 RID: 4113 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001011")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public TradeRequest()
	{
	}

	// Token: 0x04000D68 RID: 3432
	[Token(Token = "0x4000D68")]
	[FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI Label;

	// Token: 0x04000D69 RID: 3433
	[Token(Token = "0x4000D69")]
	[FieldOffset(Offset = "0x28")]
	public World World;

	// Token: 0x04000D6A RID: 3434
	[Token(Token = "0x4000D6A")]
	[FieldOffset(Offset = "0x30")]
	private string _traderName;
}
