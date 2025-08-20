using System;
using Il2CppDummyDll;
using UnityEngine;

namespace MapEditor
{
	// Token: 0x020003A4 RID: 932
	[Token(Token = "0x20003A4")]
	public class PencilTool : DrawTool
	{
		// Token: 0x0600155F RID: 5471 RVA: 0x00007650 File Offset: 0x00005850
		[Token(Token = "0x600155F")]
		[Address(RVA = "0x3B6340", Offset = "0x3B5540", VA = "0x1803B6340", Slot = "14")]
		protected virtual ushort GetDrawType(MapEditorContext context)
		{
			return 0;
		}

		// Token: 0x06001560 RID: 5472 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001560")]
		[Address(RVA = "0x3B6370", Offset = "0x3B5570", VA = "0x1803B6370", Slot = "12")]
		protected override string GetToolLabel(Vector2Int? size, MapEditorContext context)
		{
			return null;
		}

		// Token: 0x06001561 RID: 5473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001561")]
		[Address(RVA = "0x3B6580", Offset = "0x3B5780", VA = "0x1803B6580", Slot = "13")]
		protected override void Set(Vector2Int coordinates, MapEditorContext context, bool preview)
		{
		}

		// Token: 0x06001562 RID: 5474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001562")]
		[Address(RVA = "0x3B2000", Offset = "0x3B1200", VA = "0x1803B2000")]
		public PencilTool()
		{
		}
	}
}
