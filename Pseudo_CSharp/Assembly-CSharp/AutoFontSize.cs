using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x0200019F RID: 415
[Token(Token = "0x200019F")]
[ExecuteAlways]
[RequireComponent(typeof(TextMeshProUGUI))]
public class AutoFontSize : MonoBehaviour
{
	// Token: 0x170000CD RID: 205
	// (get) Token: 0x06000868 RID: 2152 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x170000CD")]
	protected RectTransform ParentRectTransform
	{
		[Token(Token = "0x6000868")]
		[Address(RVA = "0x407300", Offset = "0x406500", VA = "0x180407300")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000869 RID: 2153 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000869")]
	[Address(RVA = "0x4072A0", Offset = "0x4064A0", VA = "0x1804072A0")]
	private void Start()
	{
	}

	// Token: 0x0600086A RID: 2154 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600086A")]
	[Address(RVA = "0x4071A0", Offset = "0x4063A0", VA = "0x1804071A0")]
	private void LateUpdate()
	{
	}

	// Token: 0x0600086B RID: 2155 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600086B")]
	[Address(RVA = "0x4071A0", Offset = "0x4063A0", VA = "0x1804071A0")]
	private void UpdateFontSize()
	{
	}

	// Token: 0x0600086C RID: 2156 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600086C")]
	[Address(RVA = "0x4072F0", Offset = "0x4064F0", VA = "0x1804072F0")]
	public AutoFontSize()
	{
	}

	// Token: 0x0400082E RID: 2094
	[Token(Token = "0x400082E")]
	[FieldOffset(Offset = "0x20")]
	public float SizeScale;

	// Token: 0x0400082F RID: 2095
	[Token(Token = "0x400082F")]
	[FieldOffset(Offset = "0x28")]
	private TextMeshProUGUI _text;
}
