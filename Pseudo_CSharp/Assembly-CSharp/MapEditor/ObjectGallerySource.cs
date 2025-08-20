using System;
using Il2CppDummyDll;
using UnityEngine;

namespace MapEditor
{
	// Token: 0x020003BE RID: 958
	[Token(Token = "0x20003BE")]
	public abstract class ObjectGallerySource : MonoBehaviour
	{
		// Token: 0x060015FF RID: 5631
		[Token(Token = "0x60015FF")]
		public abstract int GetItemLength();

		// Token: 0x06001600 RID: 5632
		[Token(Token = "0x6001600")]
		public abstract ushort GetItemTypeAt(int index);

		// Token: 0x06001601 RID: 5633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001601")]
		[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
		protected ObjectGallerySource()
		{
		}
	}
}
