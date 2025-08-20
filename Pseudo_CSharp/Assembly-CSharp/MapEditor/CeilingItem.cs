using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace MapEditor
{
	// Token: 0x020003B6 RID: 950
	[Token(Token = "0x20003B6")]
	public class CeilingItem : ObjectGalleryItem
	{
		// Token: 0x060015D8 RID: 5592 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60015D8")]
		[Address(RVA = "0x3B0970", Offset = "0x3AFB70", VA = "0x1803B0970", Slot = "4")]
		public override Sprite GetSprite()
		{
			return null;
		}

		// Token: 0x060015D9 RID: 5593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015D9")]
		[Address(RVA = "0x3B0990", Offset = "0x3AFB90", VA = "0x1803B0990")]
		public void Select()
		{
		}

		// Token: 0x060015DA RID: 5594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015DA")]
		[Address(RVA = "0x3B09C0", Offset = "0x3AFBC0", VA = "0x1803B09C0", Slot = "5")]
		public override void SetItemType(ushort type)
		{
		}

		// Token: 0x060015DB RID: 5595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015DB")]
		[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
		public CeilingItem()
		{
		}

		// Token: 0x04001142 RID: 4418
		[Token(Token = "0x4001142")]
		[FieldOffset(Offset = "0x20")]
		public MapEditorPalette Palette;

		// Token: 0x04001143 RID: 4419
		[Token(Token = "0x4001143")]
		[FieldOffset(Offset = "0x28")]
		public ObjectGallery Gallery;

		// Token: 0x04001144 RID: 4420
		[Token(Token = "0x4001144")]
		[FieldOffset(Offset = "0x30")]
		public Image Image;

		// Token: 0x04001145 RID: 4421
		[Token(Token = "0x4001145")]
		[FieldOffset(Offset = "0x38")]
		private ushort _type;
	}
}
