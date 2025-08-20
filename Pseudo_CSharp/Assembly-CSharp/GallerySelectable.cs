using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x0200018C RID: 396
[Token(Token = "0x200018C")]
public class GallerySelectable : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
{
	// Token: 0x060007F0 RID: 2032 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007F0")]
	[Address(RVA = "0x411930", Offset = "0x410B30", VA = "0x180411930", Slot = "4")]
	public void OnPointerClick(PointerEventData eventData)
	{
	}

	// Token: 0x060007F1 RID: 2033 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007F1")]
	[Address(RVA = "0x411840", Offset = "0x410A40", VA = "0x180411840")]
	private void Awake()
	{
	}

	// Token: 0x060007F2 RID: 2034 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007F2")]
	[Address(RVA = "0x411840", Offset = "0x410A40", VA = "0x180411840")]
	private void GetGalleryItem()
	{
	}

	// Token: 0x060007F3 RID: 2035 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007F3")]
	[Address(RVA = "0x411890", Offset = "0x410A90", VA = "0x180411890")]
	private void LateUpdate()
	{
	}

	// Token: 0x060007F4 RID: 2036 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007F4")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public GallerySelectable()
	{
	}

	// Token: 0x040007D3 RID: 2003
	[Token(Token = "0x40007D3")]
	[FieldOffset(Offset = "0x20")]
	private GalleryItem _galleryItem;
}
