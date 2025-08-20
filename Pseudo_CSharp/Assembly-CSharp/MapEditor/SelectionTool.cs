using System;
using Il2CppDummyDll;
using UnityEngine;

namespace MapEditor
{
	// Token: 0x020003A6 RID: 934
	[Token(Token = "0x20003A6")]
	public class SelectionTool : MapEditorTool
	{
		// Token: 0x0600156A RID: 5482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600156A")]
		[Address(RVA = "0x3B79E0", Offset = "0x3B6BE0", VA = "0x1803B79E0", Slot = "4")]
		public override void Begin(Vector2 coordinates, MapEditorContext context)
		{
		}

		// Token: 0x0600156B RID: 5483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600156B")]
		[Address(RVA = "0x3B7AC0", Offset = "0x3B6CC0", VA = "0x1803B7AC0", Slot = "5")]
		public override void Cancel(MapEditorContext context)
		{
		}

		// Token: 0x0600156C RID: 5484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600156C")]
		[Address(RVA = "0x3B7AE0", Offset = "0x3B6CE0", VA = "0x1803B7AE0", Slot = "8")]
		public override void End(Vector2 coordinates, MapEditorContext context)
		{
		}

		// Token: 0x0600156D RID: 5485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600156D")]
		[Address(RVA = "0x3B7DB0", Offset = "0x3B6FB0", VA = "0x1803B7DB0", Slot = "10")]
		public override void Update(Vector2 coordinates, MapEditorContext context)
		{
		}

		// Token: 0x0600156E RID: 5486 RVA: 0x00007680 File Offset: 0x00005880
		[Token(Token = "0x600156E")]
		[Address(RVA = "0x3B4830", Offset = "0x3B3A30", VA = "0x1803B4830")]
		private Vector2Int GetIntCoord(Vector2 coordinates, MapEditorContext context)
		{
			return default(Vector2Int);
		}

		// Token: 0x0600156F RID: 5487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600156F")]
		[Address(RVA = "0x3B7C70", Offset = "0x3B6E70", VA = "0x1803B7C70")]
		private void UpdateSelection(Vector2Int coordinates, MapEditorContext context)
		{
		}

		// Token: 0x06001570 RID: 5488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001570")]
		[Address(RVA = "0x3B0F60", Offset = "0x3B0160", VA = "0x1803B0F60")]
		public SelectionTool()
		{
		}

		// Token: 0x0400110F RID: 4367
		[Token(Token = "0x400110F")]
		[FieldOffset(Offset = "0x18")]
		private Vector2Int _start;

		// Token: 0x04001110 RID: 4368
		[Token(Token = "0x4001110")]
		[FieldOffset(Offset = "0x20")]
		private Vector2 _startScreen;
	}
}
