using System;
using Il2CppDummyDll;
using Ronin.Model.Interfaces;
using UnityEngine;

namespace MapEditor
{
	// Token: 0x02000372 RID: 882
	[Token(Token = "0x2000372")]
	public class OverrideChunk : DictionaryChunk<IOverride, Override>
	{
		// Token: 0x060013E4 RID: 5092 RVA: 0x00006FC0 File Offset: 0x000051C0
		[Token(Token = "0x60013E4")]
		[Address(RVA = "0x3A2650", Offset = "0x3A1850", VA = "0x1803A2650", Slot = "12")]
		protected override bool HasValue(IOverride type)
		{
			return default(bool);
		}

		// Token: 0x060013E5 RID: 5093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013E5")]
		[Address(RVA = "0x3A2660", Offset = "0x3A1860", VA = "0x1803A2660", Slot = "13")]
		protected override void Setup(Override obj, IOverride type, Vector2Int coordinates)
		{
		}

		// Token: 0x060013E6 RID: 5094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013E6")]
		[Address(RVA = "0x3A2770", Offset = "0x3A1970", VA = "0x1803A2770")]
		public OverrideChunk()
		{
		}
	}
}
