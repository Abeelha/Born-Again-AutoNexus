using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace MapEditor
{
	// Token: 0x020003B9 RID: 953
	[Token(Token = "0x20003B9")]
	public class LightItem : ObjectGalleryItem
	{
		// Token: 0x060015E4 RID: 5604 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60015E4")]
		[Address(RVA = "0x3B1FF0", Offset = "0x3B11F0", VA = "0x1803B1FF0", Slot = "4")]
		public override Sprite GetSprite()
		{
			return null;
		}

		// Token: 0x060015E5 RID: 5605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015E5")]
		[Address(RVA = "0x3B2530", Offset = "0x3B1730", VA = "0x1803B2530")]
		public void Select()
		{
		}

		// Token: 0x060015E6 RID: 5606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015E6")]
		[Address(RVA = "0x3B2560", Offset = "0x3B1760", VA = "0x1803B2560", Slot = "5")]
		public override void SetItemType(ushort type)
		{
		}

		// Token: 0x060015E7 RID: 5607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015E7")]
		[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
		public LightItem()
		{
		}

		// Token: 0x0400114A RID: 4426
		[Token(Token = "0x400114A")]
		[FieldOffset(Offset = "0x20")]
		public MapEditorPalette Palette;

		// Token: 0x0400114B RID: 4427
		[Token(Token = "0x400114B")]
		[FieldOffset(Offset = "0x28")]
		public ObjectGallery Gallery;

		// Token: 0x0400114C RID: 4428
		[Token(Token = "0x400114C")]
		[FieldOffset(Offset = "0x30")]
		public Image Image;

		// Token: 0x0400114D RID: 4429
		[Token(Token = "0x400114D")]
		[FieldOffset(Offset = "0x38")]
		private ushort _type;
	}
}
