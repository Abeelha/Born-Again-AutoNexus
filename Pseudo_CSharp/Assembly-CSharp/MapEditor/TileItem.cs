using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace MapEditor
{
	// Token: 0x020003C5 RID: 965
	[Token(Token = "0x20003C5")]
	public class TileItem : ObjectGalleryItem
	{
		// Token: 0x06001618 RID: 5656 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001618")]
		[Address(RVA = "0x3B0970", Offset = "0x3AFB70", VA = "0x1803B0970", Slot = "4")]
		public override Sprite GetSprite()
		{
			return null;
		}

		// Token: 0x06001619 RID: 5657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001619")]
		[Address(RVA = "0x3B9560", Offset = "0x3B8760", VA = "0x1803B9560")]
		public void Select()
		{
		}

		// Token: 0x0600161A RID: 5658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600161A")]
		[Address(RVA = "0x3B9590", Offset = "0x3B8790", VA = "0x1803B9590", Slot = "5")]
		public override void SetItemType(ushort type)
		{
		}

		// Token: 0x0600161B RID: 5659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600161B")]
		[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
		public TileItem()
		{
		}

		// Token: 0x04001169 RID: 4457
		[Token(Token = "0x4001169")]
		[FieldOffset(Offset = "0x20")]
		public MapEditorPalette Palette;

		// Token: 0x0400116A RID: 4458
		[Token(Token = "0x400116A")]
		[FieldOffset(Offset = "0x28")]
		public ObjectGallery Gallery;

		// Token: 0x0400116B RID: 4459
		[Token(Token = "0x400116B")]
		[FieldOffset(Offset = "0x30")]
		public Image Image;

		// Token: 0x0400116C RID: 4460
		[Token(Token = "0x400116C")]
		[FieldOffset(Offset = "0x38")]
		private ushort _type;
	}
}
