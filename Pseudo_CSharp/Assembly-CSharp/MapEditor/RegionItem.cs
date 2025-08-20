using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace MapEditor
{
	// Token: 0x020003C2 RID: 962
	[Token(Token = "0x20003C2")]
	public class RegionItem : ObjectGalleryItem
	{
		// Token: 0x0600160D RID: 5645 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600160D")]
		[Address(RVA = "0x3B0970", Offset = "0x3AFB70", VA = "0x1803B0970", Slot = "4")]
		public override Sprite GetSprite()
		{
			return null;
		}

		// Token: 0x0600160E RID: 5646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600160E")]
		[Address(RVA = "0x3B6E30", Offset = "0x3B6030", VA = "0x1803B6E30")]
		public void Select()
		{
		}

		// Token: 0x0600160F RID: 5647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600160F")]
		[Address(RVA = "0x3B6E60", Offset = "0x3B6060", VA = "0x1803B6E60", Slot = "5")]
		public override void SetItemType(ushort type)
		{
		}

		// Token: 0x06001610 RID: 5648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001610")]
		[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
		public RegionItem()
		{
		}

		// Token: 0x04001161 RID: 4449
		[Token(Token = "0x4001161")]
		[FieldOffset(Offset = "0x20")]
		public MapEditorPalette Palette;

		// Token: 0x04001162 RID: 4450
		[Token(Token = "0x4001162")]
		[FieldOffset(Offset = "0x28")]
		public ObjectGallery Gallery;

		// Token: 0x04001163 RID: 4451
		[Token(Token = "0x4001163")]
		[FieldOffset(Offset = "0x30")]
		public Image Image;

		// Token: 0x04001164 RID: 4452
		[Token(Token = "0x4001164")]
		[FieldOffset(Offset = "0x38")]
		public RegionSource Source;

		// Token: 0x04001165 RID: 4453
		[Token(Token = "0x4001165")]
		[FieldOffset(Offset = "0x40")]
		private ushort _type;
	}
}
