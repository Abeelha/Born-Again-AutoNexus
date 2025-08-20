using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace MapEditor
{
	// Token: 0x020003BC RID: 956
	[Token(Token = "0x20003BC")]
	public class ObjectGallery : MonoBehaviour
	{
		// Token: 0x060015EF RID: 5615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015EF")]
		[Address(RVA = "0x3B5BB0", Offset = "0x3B4DB0", VA = "0x1803B5BB0")]
		public void Reload()
		{
		}

		// Token: 0x060015F0 RID: 5616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015F0")]
		[Address(RVA = "0x3B4FF0", Offset = "0x3B41F0", VA = "0x1803B4FF0")]
		private void Awake()
		{
		}

		// Token: 0x060015F1 RID: 5617 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60015F1")]
		[Address(RVA = "0x3B5020", Offset = "0x3B4220", VA = "0x1803B5020")]
		private ObjectGalleryItem CreateItem()
		{
			return null;
		}

		// Token: 0x060015F2 RID: 5618 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60015F2")]
		[Address(RVA = "0x3B51F0", Offset = "0x3B43F0", VA = "0x1803B51F0")]
		private ObjectGalleryItem GetItem(int index)
		{
			return null;
		}

		// Token: 0x060015F3 RID: 5619 RVA: 0x000078D8 File Offset: 0x00005AD8
		[Token(Token = "0x60015F3")]
		[Address(RVA = "0x3B5150", Offset = "0x3B4350", VA = "0x1803B5150")]
		private Rect GetItemRect(int index, float contentWidth, float spacing, int columns)
		{
			return default(Rect);
		}

		// Token: 0x060015F4 RID: 5620 RVA: 0x000078F0 File Offset: 0x00005AF0
		[Token(Token = "0x60015F4")]
		[Address(RVA = "0x3B5450", Offset = "0x3B4650", VA = "0x1803B5450")]
		private ushort? GetTypeAt(int index)
		{
			return null;
		}

		// Token: 0x060015F5 RID: 5621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015F5")]
		[Address(RVA = "0x3B5530", Offset = "0x3B4730", VA = "0x1803B5530")]
		private void LoadItems()
		{
		}

		// Token: 0x060015F6 RID: 5622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015F6")]
		[Address(RVA = "0x3B56F0", Offset = "0x3B48F0", VA = "0x1803B56F0")]
		private void PositionItems()
		{
		}

		// Token: 0x060015F7 RID: 5623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015F7")]
		[Address(RVA = "0x3B5BC0", Offset = "0x3B4DC0", VA = "0x1803B5BC0")]
		private void SetSelecitonRect(Rect rect)
		{
		}

		// Token: 0x060015F8 RID: 5624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015F8")]
		[Address(RVA = "0x3B5C40", Offset = "0x3B4E40", VA = "0x1803B5C40")]
		private void Update()
		{
		}

		// Token: 0x060015F9 RID: 5625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015F9")]
		[Address(RVA = "0x3B5CF0", Offset = "0x3B4EF0", VA = "0x1803B5CF0")]
		public ObjectGallery()
		{
		}

		// Token: 0x04001151 RID: 4433
		[Token(Token = "0x4001151")]
		[FieldOffset(Offset = "0x20")]
		public int Columns;

		// Token: 0x04001152 RID: 4434
		[Token(Token = "0x4001152")]
		[FieldOffset(Offset = "0x24")]
		public float Spacing;

		// Token: 0x04001153 RID: 4435
		[Token(Token = "0x4001153")]
		[FieldOffset(Offset = "0x28")]
		public RectTransform Content;

		// Token: 0x04001154 RID: 4436
		[Token(Token = "0x4001154")]
		[FieldOffset(Offset = "0x30")]
		public ObjectGallerySource Source;

		// Token: 0x04001155 RID: 4437
		[Token(Token = "0x4001155")]
		[FieldOffset(Offset = "0x38")]
		public ObjectGalleryItem ItemPrefab;

		// Token: 0x04001156 RID: 4438
		[Token(Token = "0x4001156")]
		[FieldOffset(Offset = "0x40")]
		public RectTransform Selection;

		// Token: 0x04001157 RID: 4439
		[Token(Token = "0x4001157")]
		[FieldOffset(Offset = "0x48")]
		public MapEditorPalette Palette;

		// Token: 0x04001158 RID: 4440
		[Token(Token = "0x4001158")]
		[FieldOffset(Offset = "0x50")]
		private readonly List<ObjectGalleryItem> _items;

		// Token: 0x04001159 RID: 4441
		[Token(Token = "0x4001159")]
		[FieldOffset(Offset = "0x58")]
		private bool _loaded;
	}
}
