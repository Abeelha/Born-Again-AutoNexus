using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002E0 RID: 736
[Token(Token = "0x20002E0")]
public class RequestContainer : MonoBehaviour
{
	// Token: 0x06001007 RID: 4103 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001007")]
	[Address(RVA = "0x356970", Offset = "0x355B70", VA = "0x180356970")]
	public void AddPartyRequest(string leaderName)
	{
	}

	// Token: 0x06001008 RID: 4104 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001008")]
	[Address(RVA = "0x356C30", Offset = "0x355E30", VA = "0x180356C30")]
	public void AddTradeRequest(string traderName)
	{
	}

	// Token: 0x06001009 RID: 4105 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001009")]
	[Address(RVA = "0x356AD0", Offset = "0x355CD0", VA = "0x180356AD0")]
	private void AddRequest(Request request)
	{
	}

	// Token: 0x0600100A RID: 4106 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600100A")]
	[Address(RVA = "0x356D90", Offset = "0x355F90", VA = "0x180356D90")]
	private void Awake()
	{
	}

	// Token: 0x0600100B RID: 4107 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600100B")]
	[Address(RVA = "0x356E50", Offset = "0x356050", VA = "0x180356E50")]
	private Request GetRequest()
	{
		return null;
	}

	// Token: 0x0600100C RID: 4108 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600100C")]
	[Address(RVA = "0x356F70", Offset = "0x356170", VA = "0x180356F70")]
	private void LateUpdate()
	{
	}

	// Token: 0x0600100D RID: 4109 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600100D")]
	[Address(RVA = "0x357230", Offset = "0x356430", VA = "0x180357230")]
	private void Return(GameObject gameObject)
	{
	}

	// Token: 0x0600100E RID: 4110 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600100E")]
	[Address(RVA = "0x357250", Offset = "0x356450", VA = "0x180357250")]
	public RequestContainer()
	{
	}

	// Token: 0x04000D62 RID: 3426
	[Token(Token = "0x4000D62")]
	[FieldOffset(Offset = "0x20")]
	public GameObject RequestPrefab;

	// Token: 0x04000D63 RID: 3427
	[Token(Token = "0x4000D63")]
	[FieldOffset(Offset = "0x28")]
	public Sprite TradeIcon;

	// Token: 0x04000D64 RID: 3428
	[Token(Token = "0x4000D64")]
	[FieldOffset(Offset = "0x30")]
	public Sprite PartyIcon;

	// Token: 0x04000D65 RID: 3429
	[Token(Token = "0x4000D65")]
	[FieldOffset(Offset = "0x38")]
	private List<Request> _requests;

	// Token: 0x04000D66 RID: 3430
	[Token(Token = "0x4000D66")]
	[FieldOffset(Offset = "0x40")]
	private List<Request> _nextRequests;

	// Token: 0x04000D67 RID: 3431
	[Token(Token = "0x4000D67")]
	[FieldOffset(Offset = "0x48")]
	private GameObjectPool _requestPool;
}
