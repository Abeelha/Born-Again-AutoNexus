using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace MapEditor
{
	// Token: 0x020003AF RID: 943
	[Token(Token = "0x20003AF")]
	public class AnchorSelector : MonoBehaviour
	{
		// Token: 0x17000235 RID: 565
		// (get) Token: 0x0600159D RID: 5533 RVA: 0x000077B8 File Offset: 0x000059B8
		[Token(Token = "0x17000235")]
		public Vector2 Anchor
		{
			[Token(Token = "0x600159D")]
			[Address(RVA = "0x3AE0F0", Offset = "0x3AD2F0", VA = "0x1803AE0F0")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x0600159E RID: 5534 RVA: 0x000077D0 File Offset: 0x000059D0
		// (set) Token: 0x0600159F RID: 5535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000236")]
		public int AnchorIndex
		{
			[Token(Token = "0x600159E")]
			[Address(RVA = "0x3AE880", Offset = "0x3ADA80", VA = "0x1803AE880")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600159F")]
			[Address(RVA = "0x3AE890", Offset = "0x3ADA90", VA = "0x1803AE890")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060015A0 RID: 5536 RVA: 0x000077E8 File Offset: 0x000059E8
		[Token(Token = "0x60015A0")]
		[Address(RVA = "0x3AE0F0", Offset = "0x3AD2F0", VA = "0x1803AE0F0")]
		public Vector2 GetAnchor()
		{
			return default(Vector2);
		}

		// Token: 0x060015A1 RID: 5537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015A1")]
		[Address(RVA = "0x3AE2B0", Offset = "0x3AD4B0", VA = "0x1803AE2B0")]
		public void SetAnchorIndex(int index)
		{
		}

		// Token: 0x060015A2 RID: 5538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015A2")]
		[Address(RVA = "0x3ADF70", Offset = "0x3AD170", VA = "0x1803ADF70")]
		private void EachAnchorButton(Action<int> indexAction)
		{
		}

		// Token: 0x060015A3 RID: 5539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015A3")]
		[Address(RVA = "0x3AE160", Offset = "0x3AD360", VA = "0x1803AE160")]
		private void SetAnchorIcon(int index, Sprite sprite, int rotation)
		{
		}

		// Token: 0x060015A4 RID: 5540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015A4")]
		[Address(RVA = "0x3AE4A0", Offset = "0x3AD6A0", VA = "0x1803AE4A0")]
		private void SetAnchorSelected(int index, bool selected)
		{
		}

		// Token: 0x060015A5 RID: 5541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015A5")]
		[Address(RVA = "0x3AE870", Offset = "0x3ADA70", VA = "0x1803AE870")]
		public AnchorSelector()
		{
		}

		// Token: 0x0400111D RID: 4381
		[Token(Token = "0x400111D")]
		[FieldOffset(Offset = "0x20")]
		public Button[] AnchorButtons;

		// Token: 0x0400111E RID: 4382
		[Token(Token = "0x400111E")]
		[FieldOffset(Offset = "0x28")]
		public Image[] AnchorIcons;

		// Token: 0x0400111F RID: 4383
		[Token(Token = "0x400111F")]
		[FieldOffset(Offset = "0x30")]
		public Sprite ArrowSprite;

		// Token: 0x04001120 RID: 4384
		[Token(Token = "0x4001120")]
		[FieldOffset(Offset = "0x38")]
		public Sprite DefaultSprite;

		// Token: 0x04001121 RID: 4385
		[Token(Token = "0x4001121")]
		[FieldOffset(Offset = "0x40")]
		public Sprite SelectedSprite;
	}
}
