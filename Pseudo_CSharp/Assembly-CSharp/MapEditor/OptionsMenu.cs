using System;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

namespace MapEditor
{
	// Token: 0x0200038C RID: 908
	[Token(Token = "0x200038C")]
	public class OptionsMenu : MonoBehaviour
	{
		// Token: 0x060014CA RID: 5322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014CA")]
		[Address(RVA = "0x3A20B0", Offset = "0x3A12B0", VA = "0x1803A20B0")]
		public void Canvas()
		{
		}

		// Token: 0x060014CB RID: 5323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014CB")]
		[Address(RVA = "0x3A20F0", Offset = "0x3A12F0", VA = "0x1803A20F0")]
		public void Import()
		{
		}

		// Token: 0x060014CC RID: 5324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014CC")]
		[Address(RVA = "0x3A25D0", Offset = "0x3A17D0", VA = "0x1803A25D0")]
		public void Rasterize()
		{
		}

		// Token: 0x060014CD RID: 5325 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60014CD")]
		[Address(RVA = "0x3A24C0", Offset = "0x3A16C0", VA = "0x1803A24C0")]
		private Task OpenAsync(string path, Vector2Int coordinates)
		{
			return null;
		}

		// Token: 0x060014CE RID: 5326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014CE")]
		[Address(RVA = "0x3A2610", Offset = "0x3A1810", VA = "0x1803A2610")]
		private void ShowMenu(Menu menu)
		{
		}

		// Token: 0x060014CF RID: 5327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014CF")]
		[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
		public OptionsMenu()
		{
		}

		// Token: 0x040010BA RID: 4282
		[Token(Token = "0x40010BA")]
		[FieldOffset(Offset = "0x20")]
		public Menu Menu;

		// Token: 0x040010BB RID: 4283
		[Token(Token = "0x40010BB")]
		[FieldOffset(Offset = "0x28")]
		public Menu CanvasMenu;

		// Token: 0x040010BC RID: 4284
		[Token(Token = "0x40010BC")]
		[FieldOffset(Offset = "0x30")]
		public Menu RasterizeMenu;

		// Token: 0x040010BD RID: 4285
		[Token(Token = "0x40010BD")]
		[FieldOffset(Offset = "0x38")]
		public MapEditorContext Context;

		// Token: 0x040010BE RID: 4286
		[Token(Token = "0x40010BE")]
		[FieldOffset(Offset = "0x40")]
		public MapEditorToolController ToolController;
	}
}
