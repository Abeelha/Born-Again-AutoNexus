using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace MapEditor
{
	// Token: 0x02000399 RID: 921
	[Token(Token = "0x2000399")]
	public abstract class DrawTool : MapEditorTool
	{
		// Token: 0x1700022B RID: 555
		// (get) Token: 0x0600150D RID: 5389 RVA: 0x00007500 File Offset: 0x00005700
		// (set) Token: 0x0600150E RID: 5390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700022B")]
		private protected int BrushSize
		{
			[Token(Token = "0x600150D")]
			[Address(RVA = "0x394080", Offset = "0x393280", VA = "0x180394080")]
			[CompilerGenerated]
			protected get
			{
				return 0;
			}
			[Token(Token = "0x600150E")]
			[Address(RVA = "0x394090", Offset = "0x393290", VA = "0x180394090")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600150F RID: 5391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600150F")]
		[Address(RVA = "0x392DC0", Offset = "0x391FC0", VA = "0x180392DC0", Slot = "4")]
		public override void Begin(Vector2 coordinates, MapEditorContext context)
		{
		}

		// Token: 0x06001510 RID: 5392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001510")]
		[Address(RVA = "0x392E60", Offset = "0x392060", VA = "0x180392E60", Slot = "5")]
		public override void Cancel(MapEditorContext context)
		{
		}

		// Token: 0x06001511 RID: 5393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001511")]
		[Address(RVA = "0x392E20", Offset = "0x392020", VA = "0x180392E20", Slot = "6")]
		public override void CancelInactive(MapEditorContext context)
		{
		}

		// Token: 0x06001512 RID: 5394 RVA: 0x00007518 File Offset: 0x00005718
		[Token(Token = "0x6001512")]
		[Address(RVA = "0x393210", Offset = "0x392410", VA = "0x180393210", Slot = "7")]
		public override bool Decrease(int index)
		{
			return default(bool);
		}

		// Token: 0x06001513 RID: 5395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001513")]
		[Address(RVA = "0x3939C0", Offset = "0x392BC0", VA = "0x1803939C0", Slot = "8")]
		public override void End(Vector2 coordinates, MapEditorContext context)
		{
		}

		// Token: 0x06001514 RID: 5396 RVA: 0x00007530 File Offset: 0x00005730
		[Token(Token = "0x6001514")]
		[Address(RVA = "0x393A40", Offset = "0x392C40", VA = "0x180393A40", Slot = "9")]
		public override bool Increase(int index)
		{
			return default(bool);
		}

		// Token: 0x06001515 RID: 5397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001515")]
		[Address(RVA = "0x393DF0", Offset = "0x392FF0", VA = "0x180393DF0", Slot = "10")]
		public override void Update(Vector2 coordinates, MapEditorContext context)
		{
		}

		// Token: 0x06001516 RID: 5398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001516")]
		[Address(RVA = "0x393BD0", Offset = "0x392DD0", VA = "0x180393BD0", Slot = "11")]
		public override void UpdateInactive(Vector2 coordinates, MapEditorContext context)
		{
		}

		// Token: 0x06001517 RID: 5399 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001517")]
		[Address(RVA = "0x393A00", Offset = "0x392C00", VA = "0x180393A00", Slot = "12")]
		protected virtual string GetToolLabel(Vector2Int? size, MapEditorContext context)
		{
			return null;
		}

		// Token: 0x06001518 RID: 5400
		[Token(Token = "0x6001518")]
		protected abstract void Set(Vector2Int coordinates, MapEditorContext context, bool preview);

		// Token: 0x06001519 RID: 5401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001519")]
		[Address(RVA = "0x393AF0", Offset = "0x392CF0", VA = "0x180393AF0")]
		protected void SetSize(int size)
		{
		}

		// Token: 0x0600151A RID: 5402 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600151A")]
		[Address(RVA = "0x392E80", Offset = "0x392080", VA = "0x180392E80")]
		private static Vector2Int[] CreateBrush(int size)
		{
			return null;
		}

		// Token: 0x0600151B RID: 5403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600151B")]
		[Address(RVA = "0x392E20", Offset = "0x392020", VA = "0x180392E20")]
		private void ClearPreview(MapEditorContext context)
		{
		}

		// Token: 0x0600151C RID: 5404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600151C")]
		[Address(RVA = "0x3936B0", Offset = "0x3928B0", VA = "0x1803936B0")]
		private void Draw(Vector2 coordinates, MapEditorContext context, bool preview)
		{
		}

		// Token: 0x0600151D RID: 5405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600151D")]
		[Address(RVA = "0x393240", Offset = "0x392440", VA = "0x180393240")]
		private void DrawLine(Vector2Int from, Vector2Int to, MapEditorContext context, bool preview)
		{
		}

		// Token: 0x0600151E RID: 5406 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600151E")]
		[Address(RVA = "0x393A70", Offset = "0x392C70", VA = "0x180393A70")]
		private IEnumerable<Vector2Int> Line(Vector2Int? start, Vector2Int end)
		{
			return null;
		}

		// Token: 0x0600151F RID: 5407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600151F")]
		[Address(RVA = "0x393CE0", Offset = "0x392EE0", VA = "0x180393CE0")]
		private void UpdatePreview(Vector2Int end, MapEditorContext context)
		{
		}

		// Token: 0x06001520 RID: 5408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001520")]
		[Address(RVA = "0x393DA0", Offset = "0x392FA0", VA = "0x180393DA0")]
		private void UpdateToolLabel(Vector2Int? size, MapEditorContext context)
		{
		}

		// Token: 0x06001521 RID: 5409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001521")]
		[Address(RVA = "0x393FA0", Offset = "0x3931A0", VA = "0x180393FA0")]
		protected DrawTool()
		{
		}

		// Token: 0x040010F1 RID: 4337
		[Token(Token = "0x40010F1")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<int, Vector2Int[]> _brushes;

		// Token: 0x040010F2 RID: 4338
		[Token(Token = "0x40010F2")]
		[FieldOffset(Offset = "0x18")]
		private Vector2Int? _last;

		// Token: 0x040010F3 RID: 4339
		[Token(Token = "0x40010F3")]
		[FieldOffset(Offset = "0x24")]
		private bool _previewDrawn;

		// Token: 0x040010F4 RID: 4340
		[Token(Token = "0x40010F4")]
		[FieldOffset(Offset = "0x28")]
		private Vector2Int[] _brush;
	}
}
