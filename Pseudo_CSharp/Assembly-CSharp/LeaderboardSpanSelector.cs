using System;
using Il2CppDummyDll;
using Ronin.Model.Enums;
using UnityEngine;

// Token: 0x02000116 RID: 278
[Token(Token = "0x2000116")]
public class LeaderboardSpanSelector : MonoBehaviour
{
	// Token: 0x060004C6 RID: 1222 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004C6")]
	[Address(RVA = "0x3D8C40", Offset = "0x3D7E40", VA = "0x1803D8C40")]
	public void Select(LeaderboardSpan span)
	{
	}

	// Token: 0x060004C7 RID: 1223 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004C7")]
	[Address(RVA = "0x3D8D60", Offset = "0x3D7F60", VA = "0x1803D8D60")]
	public void Select(LeaderboardSpanSelection selection)
	{
	}

	// Token: 0x060004C8 RID: 1224 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004C8")]
	[Address(RVA = "0x3D8E00", Offset = "0x3D8000", VA = "0x1803D8E00")]
	private void Update()
	{
	}

	// Token: 0x060004C9 RID: 1225 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004C9")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public LeaderboardSpanSelector()
	{
	}

	// Token: 0x0400051E RID: 1310
	[Token(Token = "0x400051E")]
	[FieldOffset(Offset = "0x20")]
	public LeaderboardSpanSelection Selected;

	// Token: 0x0400051F RID: 1311
	[Token(Token = "0x400051F")]
	[FieldOffset(Offset = "0x28")]
	public LeaderboardSpanSelection[] Selections;

	// Token: 0x04000520 RID: 1312
	[Token(Token = "0x4000520")]
	[FieldOffset(Offset = "0x30")]
	public Color SelectedColor;

	// Token: 0x04000521 RID: 1313
	[Token(Token = "0x4000521")]
	[FieldOffset(Offset = "0x40")]
	public Color UnselectedColor;
}
