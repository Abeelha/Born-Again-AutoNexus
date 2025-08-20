using System;
using Il2CppDummyDll;
using Ronin.Model.Data;
using UnityEngine;
using Zero.Game.Shared;

// Token: 0x020000E4 RID: 228
[Token(Token = "0x20000E4")]
public class BankRow : MonoBehaviour, IDataHandler<BankRowData>
{
	// Token: 0x1700004F RID: 79
	// (get) Token: 0x060003EC RID: 1004 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x1700004F")]
	public RectTransform RectTransform
	{
		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x3BF9E0", Offset = "0x3BEBE0", VA = "0x1803BF9E0")]
		get
		{
			return null;
		}
	}

	// Token: 0x060003ED RID: 1005 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003ED")]
	[Address(RVA = "0x3BF860", Offset = "0x3BEA60", VA = "0x1803BF860", Slot = "4")]
	public void HandleData(ref BankRowData data)
	{
	}

	// Token: 0x060003EE RID: 1006 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003EE")]
	[Address(RVA = "0x3BF920", Offset = "0x3BEB20", VA = "0x1803BF920")]
	public void Setup(uint bankEntityId, int index, ushort characterType, ushort threadType)
	{
	}

	// Token: 0x060003EF RID: 1007 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003EF")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public BankRow()
	{
	}

	// Token: 0x040003F7 RID: 1015
	[Token(Token = "0x40003F7")]
	[FieldOffset(Offset = "0x20")]
	public Slot[] Slots;
}
