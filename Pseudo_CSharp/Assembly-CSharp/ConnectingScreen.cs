using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020002A3 RID: 675
[Token(Token = "0x20002A3")]
public class ConnectingScreen : MonoBehaviour
{
	// Token: 0x170001A0 RID: 416
	// (get) Token: 0x06000E75 RID: 3701 RVA: 0x00005EB0 File Offset: 0x000040B0
	// (set) Token: 0x06000E76 RID: 3702 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001A0")]
	public bool Active
	{
		[Token(Token = "0x6000E75")]
		[Address(RVA = "0x3ACC20", Offset = "0x3ABE20", VA = "0x1803ACC20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000E76")]
		[Address(RVA = "0x3ACC30", Offset = "0x3ABE30", VA = "0x1803ACC30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x06000E77 RID: 3703 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E77")]
	[Address(RVA = "0x464AF0", Offset = "0x463CF0", VA = "0x180464AF0")]
	public void FadeOut()
	{
	}

	// Token: 0x06000E78 RID: 3704 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E78")]
	[Address(RVA = "0x464D00", Offset = "0x463F00", VA = "0x180464D00")]
	public void Show()
	{
	}

	// Token: 0x06000E79 RID: 3705 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E79")]
	[Address(RVA = "0x464B50", Offset = "0x463D50", VA = "0x180464B50")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000E7A RID: 3706 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E7A")]
	[Address(RVA = "0x464C00", Offset = "0x463E00", VA = "0x180464C00")]
	private void SetActive(bool active)
	{
	}

	// Token: 0x06000E7B RID: 3707 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E7B")]
	[Address(RVA = "0x464C60", Offset = "0x463E60", VA = "0x180464C60")]
	private void SetAlpha(float alpha)
	{
	}

	// Token: 0x06000E7C RID: 3708 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E7C")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public ConnectingScreen()
	{
	}

	// Token: 0x04000BC4 RID: 3012
	[Token(Token = "0x4000BC4")]
	[FieldOffset(Offset = "0x20")]
	public GameObject Content;

	// Token: 0x04000BC5 RID: 3013
	[Token(Token = "0x4000BC5")]
	[FieldOffset(Offset = "0x28")]
	public Image Image;

	// Token: 0x04000BC6 RID: 3014
	[Token(Token = "0x4000BC6")]
	[FieldOffset(Offset = "0x30")]
	public float FadeSpeed;
}
