using System;
using Il2CppDummyDll;
using Ronin.Model.Enums;
using Ronin.Model.Interfaces;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace MapEditor
{
	// Token: 0x02000391 RID: 913
	[Token(Token = "0x2000391")]
	public class OverrideMenu : MonoBehaviour
	{
		// Token: 0x060014EB RID: 5355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014EB")]
		[Address(RVA = "0x3A27B0", Offset = "0x3A19B0", VA = "0x1803A27B0")]
		public void Remove()
		{
		}

		// Token: 0x060014EC RID: 5356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014EC")]
		[Address(RVA = "0x3A2840", Offset = "0x3A1A40", VA = "0x1803A2840")]
		public void SelectDescription()
		{
		}

		// Token: 0x060014ED RID: 5357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014ED")]
		[Address(RVA = "0x3A2850", Offset = "0x3A1A50", VA = "0x1803A2850")]
		public void SelectOffset()
		{
		}

		// Token: 0x060014EE RID: 5358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014EE")]
		[Address(RVA = "0x3A2C20", Offset = "0x3A1E20", VA = "0x1803A2C20")]
		public void Show(Vector2Int coordinates, IOverride currentOverride)
		{
		}

		// Token: 0x060014EF RID: 5359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014EF")]
		[Address(RVA = "0x3A2860", Offset = "0x3A1A60", VA = "0x1803A2860")]
		private void SelectSubMenu(OverrideType overrideType)
		{
		}

		// Token: 0x060014F0 RID: 5360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014F0")]
		[Address(RVA = "0x3A2940", Offset = "0x3A1B40", VA = "0x1803A2940")]
		private void SetCurrentButton(IOverride currentOverride)
		{
		}

		// Token: 0x060014F1 RID: 5361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014F1")]
		[Address(RVA = "0x3A2A60", Offset = "0x3A1C60", VA = "0x1803A2A60")]
		private void SetTitle(Vector2Int coordinates)
		{
		}

		// Token: 0x060014F2 RID: 5362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014F2")]
		[Address(RVA = "0x3A2F00", Offset = "0x3A2100", VA = "0x1803A2F00")]
		public OverrideMenu()
		{
		}

		// Token: 0x040010D2 RID: 4306
		[Token(Token = "0x40010D2")]
		[FieldOffset(Offset = "0x20")]
		public Menu Menu;

		// Token: 0x040010D3 RID: 4307
		[Token(Token = "0x40010D3")]
		[FieldOffset(Offset = "0x28")]
		public TextMeshProUGUI Title;

		// Token: 0x040010D4 RID: 4308
		[Token(Token = "0x40010D4")]
		[FieldOffset(Offset = "0x30")]
		public Color SelectedColor;

		// Token: 0x040010D5 RID: 4309
		[Token(Token = "0x40010D5")]
		[FieldOffset(Offset = "0x40")]
		public OverrideMenu.OverrideSelection[] Selections;

		// Token: 0x040010D6 RID: 4310
		[Token(Token = "0x40010D6")]
		[FieldOffset(Offset = "0x48")]
		public GameObject RemoveButton;

		// Token: 0x040010D7 RID: 4311
		[Token(Token = "0x40010D7")]
		[FieldOffset(Offset = "0x50")]
		public MapEditorContext Context;

		// Token: 0x040010D8 RID: 4312
		[Token(Token = "0x40010D8")]
		[FieldOffset(Offset = "0x58")]
		private Vector2Int _coordinates;

		// Token: 0x040010D9 RID: 4313
		[Token(Token = "0x40010D9")]
		[FieldOffset(Offset = "0x60")]
		private IOverride _currentOverride;

		// Token: 0x02000392 RID: 914
		[Token(Token = "0x2000392")]
		[Serializable]
		public struct OverrideSelection
		{
			// Token: 0x040010DA RID: 4314
			[Token(Token = "0x40010DA")]
			[FieldOffset(Offset = "0x0")]
			public OverrideType OverrideType;

			// Token: 0x040010DB RID: 4315
			[Token(Token = "0x40010DB")]
			[FieldOffset(Offset = "0x8")]
			public Image ButtonImage;

			// Token: 0x040010DC RID: 4316
			[Token(Token = "0x40010DC")]
			[FieldOffset(Offset = "0x10")]
			public OverrideSubMenu SubMenu;
		}
	}
}
