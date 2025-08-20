using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000187 RID: 391
[Token(Token = "0x2000187")]
public class AlphaWithGalleryItem : MonoBehaviour
{
	// Token: 0x060007C1 RID: 1985 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007C1")]
	[Address(RVA = "0x406F60", Offset = "0x406160", VA = "0x180406F60")]
	private void Awake()
	{
	}

	// Token: 0x060007C2 RID: 1986 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007C2")]
	[Address(RVA = "0x406FE0", Offset = "0x4061E0", VA = "0x180406FE0")]
	private void Update()
	{
	}

	// Token: 0x060007C3 RID: 1987 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007C3")]
	[Address(RVA = "0x406FE0", Offset = "0x4061E0", VA = "0x180406FE0")]
	private void OnEnable()
	{
	}

	// Token: 0x060007C4 RID: 1988 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007C4")]
	[Address(RVA = "0x406FF0", Offset = "0x4061F0", VA = "0x180406FF0")]
	private void UpdateAlpha()
	{
	}

	// Token: 0x060007C5 RID: 1989 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007C5")]
	[Address(RVA = "0x407190", Offset = "0x406390", VA = "0x180407190")]
	public AlphaWithGalleryItem()
	{
	}

	// Token: 0x040007B9 RID: 1977
	[Token(Token = "0x40007B9")]
	[FieldOffset(Offset = "0x20")]
	public float MinAlpha;

	// Token: 0x040007BA RID: 1978
	[Token(Token = "0x40007BA")]
	[FieldOffset(Offset = "0x24")]
	public float OffsetScalingFactor;

	// Token: 0x040007BB RID: 1979
	[Token(Token = "0x40007BB")]
	[FieldOffset(Offset = "0x28")]
	private GalleryItem _galleryItem;

	// Token: 0x040007BC RID: 1980
	[Token(Token = "0x40007BC")]
	[FieldOffset(Offset = "0x30")]
	private Graphic[] _graphics;
}
