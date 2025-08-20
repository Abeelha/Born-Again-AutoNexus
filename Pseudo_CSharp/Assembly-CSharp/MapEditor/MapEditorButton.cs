using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace MapEditor
{
	// Token: 0x020003B0 RID: 944
	[Token(Token = "0x20003B0")]
	public class MapEditorButton : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
	{
		// Token: 0x060015AF RID: 5551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015AF")]
		[Address(RVA = "0x3B2AA0", Offset = "0x3B1CA0", VA = "0x1803B2AA0")]
		public void Deselect()
		{
		}

		// Token: 0x060015B0 RID: 5552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015B0")]
		[Address(RVA = "0x3B2AB0", Offset = "0x3B1CB0", VA = "0x1803B2AB0", Slot = "4")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x060015B1 RID: 5553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015B1")]
		[Address(RVA = "0x3B2B10", Offset = "0x3B1D10", VA = "0x1803B2B10")]
		public void Select()
		{
		}

		// Token: 0x060015B2 RID: 5554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015B2")]
		[Address(RVA = "0x3B2B00", Offset = "0x3B1D00", VA = "0x1803B2B00")]
		public void SelectAlt()
		{
		}

		// Token: 0x060015B3 RID: 5555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015B3")]
		[Address(RVA = "0x3B2CA0", Offset = "0x3B1EA0", VA = "0x1803B2CA0")]
		private void SetSprite(Sprite sprite)
		{
		}

		// Token: 0x060015B4 RID: 5556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015B4")]
		[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
		public MapEditorButton()
		{
		}

		// Token: 0x04001123 RID: 4387
		[Token(Token = "0x4001123")]
		[FieldOffset(Offset = "0x20")]
		public MapEditorToolController Tools;

		// Token: 0x04001124 RID: 4388
		[Token(Token = "0x4001124")]
		[FieldOffset(Offset = "0x28")]
		public MapEditorIndicatorBar IndicatorBar;

		// Token: 0x04001125 RID: 4389
		[Token(Token = "0x4001125")]
		[FieldOffset(Offset = "0x30")]
		public MapEditorToolType Type;

		// Token: 0x04001126 RID: 4390
		[Token(Token = "0x4001126")]
		[FieldOffset(Offset = "0x38")]
		public Image Image;

		// Token: 0x04001127 RID: 4391
		[Token(Token = "0x4001127")]
		[FieldOffset(Offset = "0x40")]
		public Button Button;

		// Token: 0x04001128 RID: 4392
		[Token(Token = "0x4001128")]
		[FieldOffset(Offset = "0x48")]
		public Image Icon;

		// Token: 0x04001129 RID: 4393
		[Token(Token = "0x4001129")]
		[FieldOffset(Offset = "0x50")]
		public Sprite Default;

		// Token: 0x0400112A RID: 4394
		[Token(Token = "0x400112A")]
		[FieldOffset(Offset = "0x58")]
		public Sprite Selected;

		// Token: 0x0400112B RID: 4395
		[Token(Token = "0x400112B")]
		[FieldOffset(Offset = "0x60")]
		public Sprite SelectedAlt;
	}
}
