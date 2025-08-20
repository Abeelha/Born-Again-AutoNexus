using System;
using System.Text;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x02000340 RID: 832
[Token(Token = "0x2000340")]
public class WorldUIStat : MonoBehaviour
{
	// Token: 0x0600125E RID: 4702 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600125E")]
	[Address(RVA = "0x385DC0", Offset = "0x384FC0", VA = "0x180385DC0")]
	public void SetStat(int stat, int increase, bool multiplier)
	{
	}

	// Token: 0x0600125F RID: 4703 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600125F")]
	[Address(RVA = "0x385F10", Offset = "0x385110", VA = "0x180385F10")]
	public void SetStat(int value, int max, int increase, bool multiplier)
	{
	}

	// Token: 0x06001260 RID: 4704 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001260")]
	[Address(RVA = "0x385AC0", Offset = "0x384CC0", VA = "0x180385AC0")]
	private void AppendIncrease(StringBuilder builder, int increase, bool multiplier)
	{
	}

	// Token: 0x06001261 RID: 4705 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001261")]
	[Address(RVA = "0x385CB0", Offset = "0x384EB0", VA = "0x180385CB0")]
	private void AppendStat(StringBuilder builder, int stat, bool multiplier)
	{
	}

	// Token: 0x06001262 RID: 4706 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001262")]
	[Address(RVA = "0x386110", Offset = "0x385310", VA = "0x180386110")]
	public WorldUIStat()
	{
	}

	// Token: 0x04000F0D RID: 3853
	[Token(Token = "0x4000F0D")]
	[FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI Label;

	// Token: 0x04000F0E RID: 3854
	[Token(Token = "0x4000F0E")]
	[FieldOffset(Offset = "0x28")]
	public bool Divide;

	// Token: 0x04000F0F RID: 3855
	[Token(Token = "0x4000F0F")]
	[FieldOffset(Offset = "0x2C")]
	public Color IncreaseColor;

	// Token: 0x04000F10 RID: 3856
	[Token(Token = "0x4000F10")]
	[FieldOffset(Offset = "0x3C")]
	public Color DecreaseColor;
}
