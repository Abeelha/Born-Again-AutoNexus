using System;
using Il2CppDummyDll;
using Ronin.Model.Enums;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000115 RID: 277
[Token(Token = "0x2000115")]
public class LeaderboardSpanSelection : MonoBehaviour
{
	// Token: 0x060004C5 RID: 1221 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004C5")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public LeaderboardSpanSelection()
	{
	}

	// Token: 0x0400051C RID: 1308
	[Token(Token = "0x400051C")]
	[FieldOffset(Offset = "0x20")]
	public LeaderboardSpan Span;

	// Token: 0x0400051D RID: 1309
	[Token(Token = "0x400051D")]
	[FieldOffset(Offset = "0x28")]
	public Image Image;
}
