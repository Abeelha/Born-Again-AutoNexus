using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace MapEditor
{
	// Token: 0x020003A8 RID: 936
	[Token(Token = "0x20003A8")]
	public class SprayTool : PencilTool
	{
		// Token: 0x06001579 RID: 5497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001579")]
		[Address(RVA = "0x3B93C0", Offset = "0x3B85C0", VA = "0x1803B93C0")]
		public SprayTool()
		{
		}

		// Token: 0x0600157A RID: 5498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600157A")]
		[Address(RVA = "0x3B9020", Offset = "0x3B8220", VA = "0x1803B9020", Slot = "5")]
		public override void Cancel(MapEditorContext context)
		{
		}

		// Token: 0x0600157B RID: 5499 RVA: 0x000076F8 File Offset: 0x000058F8
		[Token(Token = "0x600157B")]
		[Address(RVA = "0x3B9080", Offset = "0x3B8280", VA = "0x1803B9080", Slot = "7")]
		public override bool Decrease(int index)
		{
			return default(bool);
		}

		// Token: 0x0600157C RID: 5500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600157C")]
		[Address(RVA = "0x3B90F0", Offset = "0x3B82F0", VA = "0x1803B90F0", Slot = "8")]
		public override void End(Vector2 coordinates, MapEditorContext context)
		{
		}

		// Token: 0x0600157D RID: 5501 RVA: 0x00007710 File Offset: 0x00005910
		[Token(Token = "0x600157D")]
		[Address(RVA = "0x3B9220", Offset = "0x3B8420", VA = "0x1803B9220", Slot = "9")]
		public override bool Increase(int index)
		{
			return default(bool);
		}

		// Token: 0x0600157E RID: 5502 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600157E")]
		[Address(RVA = "0x3B9170", Offset = "0x3B8370", VA = "0x1803B9170", Slot = "12")]
		protected override string GetToolLabel(Vector2Int? size, MapEditorContext context)
		{
			return null;
		}

		// Token: 0x0600157F RID: 5503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600157F")]
		[Address(RVA = "0x3B9290", Offset = "0x3B8490", VA = "0x1803B9290", Slot = "13")]
		protected override void Set(Vector2Int coordinates, MapEditorContext context, bool preview)
		{
		}

		// Token: 0x04001111 RID: 4369
		[Token(Token = "0x4001111")]
		[FieldOffset(Offset = "0x38")]
		private readonly HashSet<Vector2Int> _usedCoordinates;

		// Token: 0x04001112 RID: 4370
		[Token(Token = "0x4001112")]
		[FieldOffset(Offset = "0x40")]
		private int _percent;
	}
}
