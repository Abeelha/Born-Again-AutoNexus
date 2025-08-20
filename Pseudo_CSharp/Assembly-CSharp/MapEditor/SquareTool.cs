using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace MapEditor
{
	// Token: 0x020003A9 RID: 937
	[Token(Token = "0x20003A9")]
	public class SquareTool : ShapeTool
	{
		// Token: 0x06001580 RID: 5504 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001580")]
		[Address(RVA = "0x3B94F0", Offset = "0x3B86F0", VA = "0x1803B94F0")]
		public static IEnumerable<Vector2Int> GetSquare(RectInt rect)
		{
			return null;
		}

		// Token: 0x06001581 RID: 5505 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001581")]
		[Address(RVA = "0x3B9480", Offset = "0x3B8680", VA = "0x1803B9480", Slot = "12")]
		protected override IEnumerable<Vector2Int> GetPoints(RectInt rect)
		{
			return null;
		}

		// Token: 0x06001582 RID: 5506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001582")]
		[Address(RVA = "0x3B0F60", Offset = "0x3B0160", VA = "0x1803B0F60")]
		public SquareTool()
		{
		}
	}
}
