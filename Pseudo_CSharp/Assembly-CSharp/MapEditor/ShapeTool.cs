using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace MapEditor
{
	// Token: 0x0200039C RID: 924
	[Token(Token = "0x200039C")]
	public abstract class ShapeTool : MapEditorTool
	{
		// Token: 0x06001537 RID: 5431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001537")]
		[Address(RVA = "0x3B8090", Offset = "0x3B7290", VA = "0x1803B8090", Slot = "4")]
		public override void Begin(Vector2 coordinates, MapEditorContext context)
		{
		}

		// Token: 0x06001538 RID: 5432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001538")]
		[Address(RVA = "0x392E60", Offset = "0x392060", VA = "0x180392E60", Slot = "5")]
		public override void Cancel(MapEditorContext context)
		{
		}

		// Token: 0x06001539 RID: 5433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001539")]
		[Address(RVA = "0x3B88E0", Offset = "0x3B7AE0", VA = "0x1803B88E0", Slot = "8")]
		public override void End(Vector2 coordinates, MapEditorContext context)
		{
		}

		// Token: 0x0600153A RID: 5434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600153A")]
		[Address(RVA = "0x3B8950", Offset = "0x3B7B50", VA = "0x1803B8950", Slot = "10")]
		public override void Update(Vector2 coordinates, MapEditorContext context)
		{
		}

		// Token: 0x0600153B RID: 5435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600153B")]
		[Address(RVA = "0x3B8900", Offset = "0x3B7B00", VA = "0x1803B8900", Slot = "11")]
		public override void UpdateInactive(Vector2 coordinates, MapEditorContext context)
		{
		}

		// Token: 0x0600153C RID: 5436
		[Token(Token = "0x600153C")]
		protected abstract IEnumerable<Vector2Int> GetPoints(RectInt rect);

		// Token: 0x0600153D RID: 5437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600153D")]
		[Address(RVA = "0x3B80C0", Offset = "0x3B72C0", VA = "0x1803B80C0")]
		private void DrawShape(Vector2Int extent, MapEditorContext context)
		{
		}

		// Token: 0x0600153E RID: 5438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600153E")]
		[Address(RVA = "0x3B0F60", Offset = "0x3B0160", VA = "0x1803B0F60")]
		protected ShapeTool()
		{
		}

		// Token: 0x04001103 RID: 4355
		[Token(Token = "0x4001103")]
		[FieldOffset(Offset = "0x18")]
		private Vector2Int _start;

		// Token: 0x04001104 RID: 4356
		[Token(Token = "0x4001104")]
		[FieldOffset(Offset = "0x20")]
		private RectInt _indicatorRect;
	}
}
