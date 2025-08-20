using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020002A8 RID: 680
[Token(Token = "0x20002A8")]
public class ContextActionsOption : MonoBehaviour
{
	// Token: 0x170001A3 RID: 419
	// (get) Token: 0x06000E94 RID: 3732 RVA: 0x00005F10 File Offset: 0x00004110
	[Token(Token = "0x170001A3")]
	public float PreferredWidth
	{
		[Token(Token = "0x6000E94")]
		[Address(RVA = "0x465490", Offset = "0x464690", VA = "0x180465490")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x170001A4 RID: 420
	// (get) Token: 0x06000E95 RID: 3733 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x170001A4")]
	public RectTransform RectTransform
	{
		[Token(Token = "0x6000E95")]
		[Address(RVA = "0x465510", Offset = "0x464710", VA = "0x180465510")]
		get
		{
			return null;
		}
	}

	// Token: 0x170001A5 RID: 421
	// (get) Token: 0x06000E96 RID: 3734 RVA: 0x00005F28 File Offset: 0x00004128
	[Token(Token = "0x170001A5")]
	private float IconHeight
	{
		[Token(Token = "0x6000E96")]
		[Address(RVA = "0x4653E0", Offset = "0x4645E0", VA = "0x1804653E0")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x170001A6 RID: 422
	// (get) Token: 0x06000E97 RID: 3735 RVA: 0x00005F40 File Offset: 0x00004140
	[Token(Token = "0x170001A6")]
	private float IconOffset
	{
		[Token(Token = "0x6000E97")]
		[Address(RVA = "0x465430", Offset = "0x464630", VA = "0x180465430")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x06000E98 RID: 3736 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E98")]
	[Address(RVA = "0x4650F0", Offset = "0x4642F0", VA = "0x1804650F0")]
	public void Setup(Sprite icon, string label)
	{
	}

	// Token: 0x06000E99 RID: 3737 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E99")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public ContextActionsOption()
	{
	}

	// Token: 0x04000BDA RID: 3034
	[Token(Token = "0x4000BDA")]
	[FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI Label;

	// Token: 0x04000BDB RID: 3035
	[Token(Token = "0x4000BDB")]
	[FieldOffset(Offset = "0x28")]
	public Image Icon;
}
