using System;
using Il2CppDummyDll;
using UnityEngine;

namespace MapEditor
{
	// Token: 0x0200037B RID: 891
	[Token(Token = "0x200037B")]
	public class MapEditorIndicator : MonoBehaviour
	{
		// Token: 0x06001435 RID: 5173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001435")]
		[Address(RVA = "0x39AC70", Offset = "0x399E70", VA = "0x18039AC70")]
		private void LateUpdate()
		{
		}

		// Token: 0x06001436 RID: 5174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001436")]
		[Address(RVA = "0x39AC80", Offset = "0x399E80", VA = "0x18039AC80")]
		private void SetPosition(Vector2 position)
		{
		}

		// Token: 0x06001437 RID: 5175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001437")]
		[Address(RVA = "0x39AD20", Offset = "0x399F20", VA = "0x18039AD20")]
		private void SetVisible(bool visible)
		{
		}

		// Token: 0x06001438 RID: 5176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001438")]
		[Address(RVA = "0x39AD40", Offset = "0x399F40", VA = "0x18039AD40")]
		private void UpdatePosition()
		{
		}

		// Token: 0x06001439 RID: 5177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001439")]
		[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
		public MapEditorIndicator()
		{
		}

		// Token: 0x04001058 RID: 4184
		[Token(Token = "0x4001058")]
		[FieldOffset(Offset = "0x20")]
		public MapEditorContext Context;

		// Token: 0x04001059 RID: 4185
		[Token(Token = "0x4001059")]
		[FieldOffset(Offset = "0x28")]
		public SpriteRenderer SpriteRenderer;
	}
}
