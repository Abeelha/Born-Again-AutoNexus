using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace MapEditor
{
	// Token: 0x020003B1 RID: 945
	[Token(Token = "0x20003B1")]
	public class MapEditorIndicatorBar : MonoBehaviour
	{
		// Token: 0x060015B5 RID: 5557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015B5")]
		[Address(RVA = "0x3B2E50", Offset = "0x3B2050", VA = "0x1803B2E50")]
		public void SetToolIcon(Sprite sprite)
		{
		}

		// Token: 0x060015B6 RID: 5558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015B6")]
		[Address(RVA = "0x3B2F30", Offset = "0x3B2130", VA = "0x1803B2F30")]
		public void SetToolLabel(string text)
		{
		}

		// Token: 0x060015B7 RID: 5559 RVA: 0x00007800 File Offset: 0x00005A00
		[Token(Token = "0x60015B7")]
		[Address(RVA = "0x3B2D30", Offset = "0x3B1F30", VA = "0x1803B2D30")]
		private Vector2 GetPosition()
		{
			return default(Vector2);
		}

		// Token: 0x060015B8 RID: 5560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015B8")]
		[Address(RVA = "0x3B2E30", Offset = "0x3B2030", VA = "0x1803B2E30")]
		private void LateUpdate()
		{
		}

		// Token: 0x060015B9 RID: 5561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015B9")]
		[Address(RVA = "0x3B2E30", Offset = "0x3B2030", VA = "0x1803B2E30")]
		private void UpdateLabels()
		{
		}

		// Token: 0x060015BA RID: 5562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015BA")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B21C0", VA = "0x1803B2FC0")]
		private void UpdatePositionLabel()
		{
		}

		// Token: 0x060015BB RID: 5563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015BB")]
		[Address(RVA = "0x3B3210", Offset = "0x3B2410", VA = "0x1803B3210")]
		private void UpdateSelectionLabel()
		{
		}

		// Token: 0x060015BC RID: 5564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015BC")]
		[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
		public MapEditorIndicatorBar()
		{
		}

		// Token: 0x0400112C RID: 4396
		[Token(Token = "0x400112C")]
		[FieldOffset(Offset = "0x20")]
		public TextMeshProUGUI PositionLabel;

		// Token: 0x0400112D RID: 4397
		[Token(Token = "0x400112D")]
		[FieldOffset(Offset = "0x28")]
		public GameObject Selection;

		// Token: 0x0400112E RID: 4398
		[Token(Token = "0x400112E")]
		[FieldOffset(Offset = "0x30")]
		public TextMeshProUGUI SelectionLabel;

		// Token: 0x0400112F RID: 4399
		[Token(Token = "0x400112F")]
		[FieldOffset(Offset = "0x38")]
		public MapEditorContext Context;

		// Token: 0x04001130 RID: 4400
		[Token(Token = "0x4001130")]
		[FieldOffset(Offset = "0x40")]
		public Image ToolIcon;

		// Token: 0x04001131 RID: 4401
		[Token(Token = "0x4001131")]
		[FieldOffset(Offset = "0x48")]
		public TextMeshProUGUI ToolLabel;
	}
}
