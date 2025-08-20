using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002A4 RID: 676
[Token(Token = "0x20002A4")]
public class ConsumableTray : MonoBehaviour
{
	// Token: 0x170001A1 RID: 417
	// (get) Token: 0x06000E7D RID: 3709 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x170001A1")]
	private RectTransform RectTransform
	{
		[Token(Token = "0x6000E7D")]
		[Address(RVA = "0x464FC0", Offset = "0x4641C0", VA = "0x180464FC0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000E7E RID: 3710 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E7E")]
	[Address(RVA = "0x464E80", Offset = "0x464080", VA = "0x180464E80")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000E7F RID: 3711 RVA: 0x00005EC8 File Offset: 0x000040C8
	[Token(Token = "0x6000E7F")]
	[Address(RVA = "0x464D90", Offset = "0x463F90", VA = "0x180464D90")]
	private float GetY()
	{
		return 0f;
	}

	// Token: 0x06000E80 RID: 3712 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E80")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public ConsumableTray()
	{
	}

	// Token: 0x04000BC8 RID: 3016
	[Token(Token = "0x4000BC8")]
	[FieldOffset(Offset = "0x20")]
	public InventoryTab Inventory;

	// Token: 0x04000BC9 RID: 3017
	[Token(Token = "0x4000BC9")]
	[FieldOffset(Offset = "0x28")]
	public int OpenY;

	// Token: 0x04000BCA RID: 3018
	[Token(Token = "0x4000BCA")]
	[FieldOffset(Offset = "0x2C")]
	public int ClosedPcY;

	// Token: 0x04000BCB RID: 3019
	[Token(Token = "0x4000BCB")]
	[FieldOffset(Offset = "0x30")]
	public int ClosedMobileY;
}
