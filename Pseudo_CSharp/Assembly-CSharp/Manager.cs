using System;
using Il2CppDummyDll;
using Ronin.Model.Data;
using UnityEngine;

// Token: 0x02000258 RID: 600
[Token(Token = "0x2000258")]
public abstract class Manager : MonoBehaviour
{
	// Token: 0x06000B4E RID: 2894 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B4E")]
	[Address(RVA = "0x316090", Offset = "0x315290", VA = "0x180316090", Slot = "4")]
	public virtual void NetworkInputUpdate()
	{
	}

	// Token: 0x06000B4F RID: 2895 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B4F")]
	[Address(RVA = "0x316090", Offset = "0x315290", VA = "0x180316090", Slot = "5")]
	public virtual void NetworkLateUpdate()
	{
	}

	// Token: 0x06000B50 RID: 2896 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B50")]
	[Address(RVA = "0x316090", Offset = "0x315290", VA = "0x180316090", Slot = "6")]
	public virtual void NewWorld(ref MapInfoData mapInfoData)
	{
	}

	// Token: 0x06000B51 RID: 2897 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B51")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	protected Manager()
	{
	}

	// Token: 0x04000A04 RID: 2564
	[Token(Token = "0x4000A04")]
	[FieldOffset(Offset = "0x20")]
	public int Priority;
}
