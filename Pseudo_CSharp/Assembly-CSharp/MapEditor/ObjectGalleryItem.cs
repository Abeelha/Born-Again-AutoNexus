using System;
using Il2CppDummyDll;
using UnityEngine;

namespace MapEditor
{
	// Token: 0x020003BD RID: 957
	[Token(Token = "0x20003BD")]
	[RequireComponent(typeof(RectTransform))]
	public abstract class ObjectGalleryItem : MonoBehaviour
	{
		// Token: 0x17000237 RID: 567
		// (get) Token: 0x060015FA RID: 5626 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000237")]
		public RectTransform RectTransform
		{
			[Token(Token = "0x60015FA")]
			[Address(RVA = "0x3B4F90", Offset = "0x3B4190", VA = "0x1803B4F90")]
			get
			{
				return null;
			}
		}

		// Token: 0x060015FB RID: 5627
		[Token(Token = "0x60015FB")]
		public abstract Sprite GetSprite();

		// Token: 0x060015FC RID: 5628
		[Token(Token = "0x60015FC")]
		public abstract void SetItemType(ushort type);

		// Token: 0x060015FD RID: 5629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015FD")]
		[Address(RVA = "0x3B4D40", Offset = "0x3B3F40", VA = "0x1803B4D40")]
		public void SetRect(Rect rect)
		{
		}

		// Token: 0x060015FE RID: 5630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015FE")]
		[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
		protected ObjectGalleryItem()
		{
		}
	}
}
