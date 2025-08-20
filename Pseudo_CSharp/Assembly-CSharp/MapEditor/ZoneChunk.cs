using System;
using Il2CppDummyDll;
using UnityEngine;

namespace MapEditor
{
	// Token: 0x02000375 RID: 885
	[Token(Token = "0x2000375")]
	public class ZoneChunk : DictionaryChunk<ZonePointGroup, ZonePointObj>
	{
		// Token: 0x060013ED RID: 5101 RVA: 0x00007008 File Offset: 0x00005208
		[Token(Token = "0x60013ED")]
		[Address(RVA = "0x3A2650", Offset = "0x3A1850", VA = "0x1803A2650", Slot = "12")]
		protected override bool HasValue(ZonePointGroup type)
		{
			return default(bool);
		}

		// Token: 0x060013EE RID: 5102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013EE")]
		[Address(RVA = "0x3ACAD0", Offset = "0x3ABCD0", VA = "0x1803ACAD0", Slot = "13")]
		protected override void Setup(ZonePointObj obj, ZonePointGroup type, Vector2Int coordinates)
		{
		}

		// Token: 0x060013EF RID: 5103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013EF")]
		[Address(RVA = "0x3ACB00", Offset = "0x3ABD00", VA = "0x1803ACB00")]
		public ZoneChunk()
		{
		}
	}
}
