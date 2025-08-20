using System;
using Il2CppDummyDll;
using UnityEngine;

namespace MapEditor
{
	// Token: 0x020003A2 RID: 930
	[Token(Token = "0x20003A2")]
	public class MoveTool : MapEditorTool
	{
		// Token: 0x06001556 RID: 5462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001556")]
		[Address(RVA = "0x3B4630", Offset = "0x3B3830", VA = "0x1803B4630", Slot = "4")]
		public override void Begin(Vector2 coordinates, MapEditorContext context)
		{
		}

		// Token: 0x06001557 RID: 5463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001557")]
		[Address(RVA = "0x392E60", Offset = "0x392060", VA = "0x180392E60", Slot = "5")]
		public override void Cancel(MapEditorContext context)
		{
		}

		// Token: 0x06001558 RID: 5464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001558")]
		[Address(RVA = "0x3B47E0", Offset = "0x3B39E0", VA = "0x1803B47E0", Slot = "8")]
		public override void End(Vector2 coordinates, MapEditorContext context)
		{
		}

		// Token: 0x06001559 RID: 5465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001559")]
		[Address(RVA = "0x3B49D0", Offset = "0x3B3BD0", VA = "0x1803B49D0", Slot = "10")]
		public override void Update(Vector2 coordinates, MapEditorContext context)
		{
		}

		// Token: 0x0600155A RID: 5466 RVA: 0x00007620 File Offset: 0x00005820
		[Token(Token = "0x600155A")]
		[Address(RVA = "0x3B4830", Offset = "0x3B3A30", VA = "0x1803B4830")]
		private Vector2Int GetIntCoord(Vector2 coordinates, MapEditorContext context)
		{
			return default(Vector2Int);
		}

		// Token: 0x0600155B RID: 5467 RVA: 0x00007638 File Offset: 0x00005838
		[Token(Token = "0x600155B")]
		[Address(RVA = "0x3B48D0", Offset = "0x3B3AD0", VA = "0x1803B48D0")]
		private RectInt GetRect(MapEditorContext context)
		{
			return default(RectInt);
		}

		// Token: 0x0600155C RID: 5468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600155C")]
		[Address(RVA = "0x3B0F60", Offset = "0x3B0160", VA = "0x1803B0F60")]
		public MoveTool()
		{
		}

		// Token: 0x0400110E RID: 4366
		[Token(Token = "0x400110E")]
		[FieldOffset(Offset = "0x18")]
		private Vector2Int? _last;
	}
}
