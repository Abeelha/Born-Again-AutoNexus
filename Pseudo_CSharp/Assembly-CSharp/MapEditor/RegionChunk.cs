using System;
using Il2CppDummyDll;
using UnityEngine;

namespace MapEditor
{
	// Token: 0x02000373 RID: 883
	[Token(Token = "0x2000373")]
	public class RegionChunk : DictionaryChunk<ushort, Region>
	{
		// Token: 0x060013E7 RID: 5095 RVA: 0x00006FD8 File Offset: 0x000051D8
		[Token(Token = "0x60013E7")]
		[Address(RVA = "0x3A3B00", Offset = "0x3A2D00", VA = "0x1803A3B00", Slot = "12")]
		protected override bool HasValue(ushort type)
		{
			return default(bool);
		}

		// Token: 0x060013E8 RID: 5096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013E8")]
		[Address(RVA = "0x3A3B10", Offset = "0x3A2D10", VA = "0x1803A3B10", Slot = "13")]
		protected override void Setup(Region obj, ushort type, Vector2Int coordinates)
		{
		}

		// Token: 0x060013E9 RID: 5097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013E9")]
		[Address(RVA = "0x3A3B40", Offset = "0x3A2D40", VA = "0x1803A3B40")]
		public RegionChunk()
		{
		}
	}
}
