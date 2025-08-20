using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200018D RID: 397
[Token(Token = "0x200018D")]
public class ScaleWithGalleryItem : MonoBehaviour
{
	// Token: 0x060007F5 RID: 2037 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007F5")]
	[Address(RVA = "0x41A300", Offset = "0x419500", VA = "0x18041A300")]
	private void Awake()
	{
	}

	// Token: 0x060007F6 RID: 2038 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007F6")]
	[Address(RVA = "0x41A350", Offset = "0x419550", VA = "0x18041A350")]
	private void Update()
	{
	}

	// Token: 0x060007F7 RID: 2039 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007F7")]
	[Address(RVA = "0x41A350", Offset = "0x419550", VA = "0x18041A350")]
	private void OnEnable()
	{
	}

	// Token: 0x060007F8 RID: 2040 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007F8")]
	[Address(RVA = "0x41A360", Offset = "0x419560", VA = "0x18041A360")]
	private void UpdateScale()
	{
	}

	// Token: 0x060007F9 RID: 2041 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007F9")]
	[Address(RVA = "0x407190", Offset = "0x406390", VA = "0x180407190")]
	public ScaleWithGalleryItem()
	{
	}

	// Token: 0x040007D4 RID: 2004
	[Token(Token = "0x40007D4")]
	[FieldOffset(Offset = "0x20")]
	public float MinScale;

	// Token: 0x040007D5 RID: 2005
	[Token(Token = "0x40007D5")]
	[FieldOffset(Offset = "0x24")]
	public float OffsetScalingFactor;

	// Token: 0x040007D6 RID: 2006
	[Token(Token = "0x40007D6")]
	[FieldOffset(Offset = "0x28")]
	private GalleryItem _galleryItem;
}
