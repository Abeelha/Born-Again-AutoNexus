using System;
using Il2CppDummyDll;
using UnityEngine;

namespace MapEditor
{
	// Token: 0x020003B2 RID: 946
	[Token(Token = "0x20003B2")]
	public class MapEditorToolBar : MonoBehaviour
	{
		// Token: 0x060015BD RID: 5565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015BD")]
		[Address(RVA = "0x3B3910", Offset = "0x3B2B10", VA = "0x1803B3910")]
		public void Select(MapEditorToolType type)
		{
		}

		// Token: 0x060015BE RID: 5566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015BE")]
		[Address(RVA = "0x3B36E0", Offset = "0x3B28E0", VA = "0x1803B36E0")]
		public void Select(MapEditorButton button)
		{
		}

		// Token: 0x060015BF RID: 5567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015BF")]
		[Address(RVA = "0x3B3560", Offset = "0x3B2760", VA = "0x1803B3560")]
		public void SelectAlt(MapEditorToolType type)
		{
		}

		// Token: 0x060015C0 RID: 5568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015C0")]
		[Address(RVA = "0x3B3490", Offset = "0x3B2690", VA = "0x1803B3490")]
		public void SelectAlt(MapEditorButton button)
		{
		}

		// Token: 0x060015C1 RID: 5569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015C1")]
		[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
		public MapEditorToolBar()
		{
		}

		// Token: 0x04001132 RID: 4402
		[Token(Token = "0x4001132")]
		[FieldOffset(Offset = "0x20")]
		public MapEditorButton[] ToolButtons;

		// Token: 0x04001133 RID: 4403
		[Token(Token = "0x4001133")]
		[FieldOffset(Offset = "0x28")]
		private MapEditorButton _selectedButton;

		// Token: 0x04001134 RID: 4404
		[Token(Token = "0x4001134")]
		[FieldOffset(Offset = "0x30")]
		private MapEditorButton _selectedAltButton;
	}
}
