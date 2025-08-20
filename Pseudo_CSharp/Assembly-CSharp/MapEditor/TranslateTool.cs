using System;
using Il2CppDummyDll;
using UnityEngine;

namespace MapEditor
{
	// Token: 0x020003AC RID: 940
	[Token(Token = "0x20003AC")]
	public class TranslateTool : MapEditorTool
	{
		// Token: 0x06001593 RID: 5523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001593")]
		[Address(RVA = "0x3B9EB0", Offset = "0x3B90B0", VA = "0x1803B9EB0", Slot = "4")]
		public override void Begin(Vector2 coordinates, MapEditorContext context)
		{
		}

		// Token: 0x06001594 RID: 5524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001594")]
		[Address(RVA = "0x3B9EC0", Offset = "0x3B90C0", VA = "0x1803B9EC0", Slot = "5")]
		public override void Cancel(MapEditorContext context)
		{
		}

		// Token: 0x06001595 RID: 5525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001595")]
		[Address(RVA = "0x3B9EE0", Offset = "0x3B90E0", VA = "0x1803B9EE0", Slot = "8")]
		public override void End(Vector2 coordinates, MapEditorContext context)
		{
		}

		// Token: 0x06001596 RID: 5526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001596")]
		[Address(RVA = "0x3B9EE0", Offset = "0x3B90E0", VA = "0x1803B9EE0", Slot = "10")]
		public override void Update(Vector2 coordinates, MapEditorContext context)
		{
		}

		// Token: 0x06001597 RID: 5527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001597")]
		[Address(RVA = "0x3B9EF0", Offset = "0x3B90F0", VA = "0x1803B9EF0")]
		private void UpdatePosition(Vector2 toPosition, MapEditorContext context)
		{
		}

		// Token: 0x06001598 RID: 5528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001598")]
		[Address(RVA = "0x3B0F60", Offset = "0x3B0160", VA = "0x1803B0F60")]
		public TranslateTool()
		{
		}

		// Token: 0x0400111B RID: 4379
		[Token(Token = "0x400111B")]
		[FieldOffset(Offset = "0x18")]
		private Vector2 _startPosition;

		// Token: 0x0400111C RID: 4380
		[Token(Token = "0x400111C")]
		[FieldOffset(Offset = "0x20")]
		private Vector2 _position;
	}
}
