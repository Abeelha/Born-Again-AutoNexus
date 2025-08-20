using System;
using Il2CppDummyDll;
using UnityEngine;

namespace MapEditor
{
	// Token: 0x0200037D RID: 893
	[Token(Token = "0x200037D")]
	public class MapEditorSelection : MonoBehaviour
	{
		// Token: 0x06001440 RID: 5184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001440")]
		[Address(RVA = "0x39B0E0", Offset = "0x39A2E0", VA = "0x18039B0E0")]
		public void UpdateSelection(bool enabled, RectInt rect)
		{
		}

		// Token: 0x06001441 RID: 5185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001441")]
		[Address(RVA = "0x39AFC0", Offset = "0x39A1C0", VA = "0x18039AFC0")]
		private void SetPosition(Vector2Int position)
		{
		}

		// Token: 0x06001442 RID: 5186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001442")]
		[Address(RVA = "0x39B070", Offset = "0x39A270", VA = "0x18039B070")]
		private void SetSize(Vector2Int size)
		{
		}

		// Token: 0x06001443 RID: 5187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001443")]
		[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
		public MapEditorSelection()
		{
		}

		// Token: 0x0400105C RID: 4188
		[Token(Token = "0x400105C")]
		[FieldOffset(Offset = "0x20")]
		public SpriteRenderer SpriteRenderer;
	}
}
