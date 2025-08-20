using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200033C RID: 828
[Token(Token = "0x200033C")]
public class TradeSlot : MonoBehaviour
{
	// Token: 0x06001250 RID: 4688 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001250")]
	[Address(RVA = "0x37CEC0", Offset = "0x37C0C0", VA = "0x18037CEC0")]
	private void LateUpdate()
	{
	}

	// Token: 0x06001251 RID: 4689 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001251")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public TradeSlot()
	{
	}

	// Token: 0x04000EF9 RID: 3833
	[Token(Token = "0x4000EF9")]
	[FieldOffset(Offset = "0x20")]
	public Image ChangeIndicator;

	// Token: 0x04000EFA RID: 3834
	[Token(Token = "0x4000EFA")]
	[FieldOffset(Offset = "0x28")]
	public Slot Slot;

	// Token: 0x04000EFB RID: 3835
	[Token(Token = "0x4000EFB")]
	[FieldOffset(Offset = "0x30")]
	public bool ChangeEnabled;
}
