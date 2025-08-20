using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x020001A8 RID: 424
[Token(Token = "0x20001A8")]
public class TmpContentFitter : MonoBehaviour
{
	// Token: 0x0600088D RID: 2189 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600088D")]
	[Address(RVA = "0x41B990", Offset = "0x41AB90", VA = "0x18041B990")]
	private void LateUpdate()
	{
	}

	// Token: 0x0600088E RID: 2190 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600088E")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public TmpContentFitter()
	{
	}

	// Token: 0x0400084A RID: 2122
	[Token(Token = "0x400084A")]
	[FieldOffset(Offset = "0x20")]
	public RectTransform Content;

	// Token: 0x0400084B RID: 2123
	[Token(Token = "0x400084B")]
	[FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI Label;

	// Token: 0x0400084C RID: 2124
	[Token(Token = "0x400084C")]
	[FieldOffset(Offset = "0x30")]
	public float Padding;
}
