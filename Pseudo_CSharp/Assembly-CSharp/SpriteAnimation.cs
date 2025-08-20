using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200017D RID: 381
[Token(Token = "0x200017D")]
[RequireComponent(typeof(Image))]
public class SpriteAnimation : MonoBehaviour
{
	// Token: 0x06000774 RID: 1908 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000774")]
	[Address(RVA = "0x41B150", Offset = "0x41A350", VA = "0x18041B150")]
	private void Awake()
	{
	}

	// Token: 0x06000775 RID: 1909 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000775")]
	[Address(RVA = "0x41B1B0", Offset = "0x41A3B0", VA = "0x18041B1B0")]
	private void OnEnable()
	{
	}

	// Token: 0x06000776 RID: 1910 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000776")]
	[Address(RVA = "0x41B1A0", Offset = "0x41A3A0", VA = "0x18041B1A0")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000777 RID: 1911 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000777")]
	[Address(RVA = "0x41B1D0", Offset = "0x41A3D0", VA = "0x18041B1D0")]
	private void UpdateAnimation()
	{
	}

	// Token: 0x06000778 RID: 1912 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000778")]
	[Address(RVA = "0x41B410", Offset = "0x41A610", VA = "0x18041B410")]
	private void UpdateSprite()
	{
	}

	// Token: 0x06000779 RID: 1913 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000779")]
	[Address(RVA = "0x41B570", Offset = "0x41A770", VA = "0x18041B570")]
	public SpriteAnimation()
	{
	}

	// Token: 0x0400077C RID: 1916
	[Token(Token = "0x400077C")]
	[FieldOffset(Offset = "0x20")]
	public float FrameTime;

	// Token: 0x0400077D RID: 1917
	[Token(Token = "0x400077D")]
	[FieldOffset(Offset = "0x24")]
	public bool ResizeImage;

	// Token: 0x0400077E RID: 1918
	[Token(Token = "0x400077E")]
	[FieldOffset(Offset = "0x25")]
	public bool RepositionImage;

	// Token: 0x0400077F RID: 1919
	[Token(Token = "0x400077F")]
	[FieldOffset(Offset = "0x26")]
	public bool HideWhenDone;

	// Token: 0x04000780 RID: 1920
	[Token(Token = "0x4000780")]
	[FieldOffset(Offset = "0x28")]
	public Sprite[] Sprites;

	// Token: 0x04000781 RID: 1921
	[Token(Token = "0x4000781")]
	[FieldOffset(Offset = "0x30")]
	public bool Loop;

	// Token: 0x04000782 RID: 1922
	[Token(Token = "0x4000782")]
	[FieldOffset(Offset = "0x34")]
	private float _remainingTime;

	// Token: 0x04000783 RID: 1923
	[Token(Token = "0x4000783")]
	[FieldOffset(Offset = "0x38")]
	private int _frame;

	// Token: 0x04000784 RID: 1924
	[Token(Token = "0x4000784")]
	[FieldOffset(Offset = "0x40")]
	private Image _image;

	// Token: 0x04000785 RID: 1925
	[Token(Token = "0x4000785")]
	[FieldOffset(Offset = "0x48")]
	private bool _done;
}
