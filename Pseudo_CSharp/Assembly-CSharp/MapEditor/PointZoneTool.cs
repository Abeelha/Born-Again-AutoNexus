using System;
using Il2CppDummyDll;
using UnityEngine;

namespace MapEditor
{
	// Token: 0x0200039B RID: 923
	[Token(Token = "0x200039B")]
	public abstract class PointZoneTool : DrawTool
	{
		// Token: 0x1700022E RID: 558
		// (get) Token: 0x0600152C RID: 5420
		[Token(Token = "0x1700022E")]
		protected abstract MapObjectType MapObjectType { [Token(Token = "0x600152C")] get; }

		// Token: 0x0600152D RID: 5421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600152D")]
		[Address(RVA = "0x3B6620", Offset = "0x3B5820", VA = "0x1803B6620", Slot = "4")]
		public override void Begin(Vector2 coordinates, MapEditorContext context)
		{
		}

		// Token: 0x0600152E RID: 5422 RVA: 0x00007578 File Offset: 0x00005778
		[Token(Token = "0x600152E")]
		[Address(RVA = "0x3B6810", Offset = "0x3B5A10", VA = "0x1803B6810", Slot = "7")]
		public override bool Decrease(int index)
		{
			return default(bool);
		}

		// Token: 0x0600152F RID: 5423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600152F")]
		[Address(RVA = "0x3B6860", Offset = "0x3B5A60", VA = "0x1803B6860", Slot = "8")]
		public override void End(Vector2 coordinates, MapEditorContext context)
		{
		}

		// Token: 0x06001530 RID: 5424 RVA: 0x00007590 File Offset: 0x00005790
		[Token(Token = "0x6001530")]
		[Address(RVA = "0x3B6A20", Offset = "0x3B5C20", VA = "0x1803B6A20", Slot = "9")]
		public override bool Increase(int index)
		{
			return default(bool);
		}

		// Token: 0x06001531 RID: 5425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001531")]
		[Address(RVA = "0x3B6BE0", Offset = "0x3B5DE0", VA = "0x1803B6BE0", Slot = "11")]
		public override void UpdateInactive(Vector2 coordinates, MapEditorContext context)
		{
		}

		// Token: 0x06001532 RID: 5426 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001532")]
		[Address(RVA = "0x3B68C0", Offset = "0x3B5AC0", VA = "0x1803B68C0", Slot = "12")]
		protected override string GetToolLabel(Vector2Int? size, MapEditorContext context)
		{
			return null;
		}

		// Token: 0x06001533 RID: 5427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001533")]
		[Address(RVA = "0x3B6A70", Offset = "0x3B5C70", VA = "0x1803B6A70", Slot = "13")]
		protected override void Set(Vector2Int coordinates, MapEditorContext context, bool preview)
		{
		}

		// Token: 0x06001534 RID: 5428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001534")]
		[Address(RVA = "0x3B6BB0", Offset = "0x3B5DB0", VA = "0x1803B6BB0", Slot = "15")]
		protected virtual void ShowMenu(MapEditorContext context, ZonePointGroup group)
		{
		}

		// Token: 0x06001535 RID: 5429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001535")]
		[Address(RVA = "0x3B6DE0", Offset = "0x3B5FE0", VA = "0x1803B6DE0")]
		protected PointZoneTool()
		{
		}

		// Token: 0x040010FE RID: 4350
		[Token(Token = "0x40010FE")]
		[FieldOffset(Offset = "0x0")]
		private static readonly ZonePointGroup s_previewGroup;

		// Token: 0x040010FF RID: 4351
		[Token(Token = "0x40010FF")]
		[FieldOffset(Offset = "0x38")]
		private ZonePointGroup _currentGroup;

		// Token: 0x04001100 RID: 4352
		[Token(Token = "0x4001100")]
		[FieldOffset(Offset = "0x40")]
		private bool _isRemoving;

		// Token: 0x04001101 RID: 4353
		[Token(Token = "0x4001101")]
		[FieldOffset(Offset = "0x41")]
		private bool _showMenu;

		// Token: 0x04001102 RID: 4354
		[Token(Token = "0x4001102")]
		[FieldOffset(Offset = "0x44")]
		private Vector2Int _startCoords;
	}
}
