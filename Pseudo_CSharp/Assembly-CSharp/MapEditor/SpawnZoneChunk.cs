using System;
using Il2CppDummyDll;
using Ronin.Model.Structs;
using UnityEngine;

namespace MapEditor
{
	// Token: 0x02000374 RID: 884
	[Token(Token = "0x2000374")]
	public class SpawnZoneChunk : DictionaryChunk<SpawnZone?, SpawnZoneObj>
	{
		// Token: 0x060013EA RID: 5098 RVA: 0x00006FF0 File Offset: 0x000051F0
		[Token(Token = "0x60013EA")]
		[Address(RVA = "0x3A8F20", Offset = "0x3A8120", VA = "0x1803A8F20", Slot = "12")]
		protected override bool HasValue(SpawnZone? type)
		{
			return default(bool);
		}

		// Token: 0x060013EB RID: 5099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013EB")]
		[Address(RVA = "0x3A8F60", Offset = "0x3A8160", VA = "0x1803A8F60", Slot = "13")]
		protected override void Setup(SpawnZoneObj obj, SpawnZone? type, Vector2Int coordinates)
		{
		}

		// Token: 0x060013EC RID: 5100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013EC")]
		[Address(RVA = "0x3A9000", Offset = "0x3A8200", VA = "0x1803A9000")]
		public SpawnZoneChunk()
		{
		}
	}
}
