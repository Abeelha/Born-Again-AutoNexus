using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000251 RID: 593
[Token(Token = "0x2000251")]
public abstract class Indicator : MonoBehaviour
{
	// Token: 0x06000B22 RID: 2850 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B22")]
	[Address(RVA = "0x316090", Offset = "0x315290", VA = "0x180316090")]
	public void ScaleFromZero()
	{
	}

	// Token: 0x06000B23 RID: 2851
	[Token(Token = "0x6000B23")]
	protected abstract void SetFill(float amount);

	// Token: 0x06000B24 RID: 2852 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B24")]
	[Address(RVA = "0x438860", Offset = "0x437A60", VA = "0x180438860")]
	protected void Setup(float fillTime, float waitTime = 0f)
	{
	}

	// Token: 0x06000B25 RID: 2853 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B25")]
	[Address(RVA = "0x4387B0", Offset = "0x4379B0", VA = "0x1804387B0", Slot = "5")]
	protected virtual void LateUpdate()
	{
	}

	// Token: 0x06000B26 RID: 2854 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B26")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	protected Indicator()
	{
	}

	// Token: 0x040009E3 RID: 2531
	[Token(Token = "0x40009E3")]
	[FieldOffset(Offset = "0x20")]
	private float _fillTime;

	// Token: 0x040009E4 RID: 2532
	[Token(Token = "0x40009E4")]
	[FieldOffset(Offset = "0x24")]
	private float _time;
}
