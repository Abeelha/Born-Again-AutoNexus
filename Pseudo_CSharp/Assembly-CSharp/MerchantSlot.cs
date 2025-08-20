using System;
using Il2CppDummyDll;
using Ronin.Model.Structs;
using TMPro;
using UnityEngine;

// Token: 0x020002C7 RID: 711
[Token(Token = "0x20002C7")]
public class MerchantSlot : MonoBehaviour
{
	// Token: 0x06000F49 RID: 3913 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F49")]
	[Address(RVA = "0x46FA00", Offset = "0x46EC00", VA = "0x18046FA00")]
	public void SetItem(ItemValue itemValue, long cost)
	{
	}

	// Token: 0x06000F4A RID: 3914 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000F4A")]
	[Address(RVA = "0x46F8F0", Offset = "0x46EAF0", VA = "0x18046F8F0")]
	private string GetGoldSpriteName(long cost)
	{
		return null;
	}

	// Token: 0x06000F4B RID: 3915 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F4B")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public MerchantSlot()
	{
	}

	// Token: 0x04000CAD RID: 3245
	[Token(Token = "0x4000CAD")]
	[FieldOffset(Offset = "0x20")]
	public Slot Slot;

	// Token: 0x04000CAE RID: 3246
	[Token(Token = "0x4000CAE")]
	[FieldOffset(Offset = "0x28")]
	public TMP_Text CostLabel;
}
