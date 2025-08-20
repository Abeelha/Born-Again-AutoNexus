using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace MapEditor
{
	// Token: 0x020003BF RID: 959
	[Token(Token = "0x20003BF")]
	public class ObjectItem : ObjectGalleryItem
	{
		// Token: 0x06001602 RID: 5634 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001602")]
		[Address(RVA = "0x3B0970", Offset = "0x3AFB70", VA = "0x1803B0970", Slot = "4")]
		public override Sprite GetSprite()
		{
			return null;
		}

		// Token: 0x06001603 RID: 5635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001603")]
		[Address(RVA = "0x3B5D70", Offset = "0x3B4F70", VA = "0x1803B5D70")]
		public void Select()
		{
		}

		// Token: 0x06001604 RID: 5636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001604")]
		[Address(RVA = "0x3B5DA0", Offset = "0x3B4FA0", VA = "0x1803B5DA0", Slot = "5")]
		public override void SetItemType(ushort type)
		{
		}

		// Token: 0x06001605 RID: 5637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001605")]
		[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
		public ObjectItem()
		{
		}

		// Token: 0x0400115A RID: 4442
		[Token(Token = "0x400115A")]
		[FieldOffset(Offset = "0x20")]
		public MapEditorPalette Palette;

		// Token: 0x0400115B RID: 4443
		[Token(Token = "0x400115B")]
		[FieldOffset(Offset = "0x28")]
		public ObjectGallery Gallery;

		// Token: 0x0400115C RID: 4444
		[Token(Token = "0x400115C")]
		[FieldOffset(Offset = "0x30")]
		public Image Image;

		// Token: 0x0400115D RID: 4445
		[Token(Token = "0x400115D")]
		[FieldOffset(Offset = "0x38")]
		private ushort _type;
	}
}
