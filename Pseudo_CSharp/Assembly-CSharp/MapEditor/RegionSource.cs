using System;
using Il2CppDummyDll;
using Ronin.Model.Enums;

namespace MapEditor
{
	// Token: 0x020003C3 RID: 963
	[Token(Token = "0x20003C3")]
	public class RegionSource : ObjectGallerySource
	{
		// Token: 0x06001611 RID: 5649 RVA: 0x00007950 File Offset: 0x00005B50
		[Token(Token = "0x6001611")]
		[Address(RVA = "0x3B6F20", Offset = "0x3B6120", VA = "0x1803B6F20", Slot = "4")]
		public override int GetItemLength()
		{
			return 0;
		}

		// Token: 0x06001612 RID: 5650 RVA: 0x00007968 File Offset: 0x00005B68
		[Token(Token = "0x6001612")]
		[Address(RVA = "0x3B6F50", Offset = "0x3B6150", VA = "0x1803B6F50", Slot = "5")]
		public override ushort GetItemTypeAt(int index)
		{
			return 0;
		}

		// Token: 0x06001613 RID: 5651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001613")]
		[Address(RVA = "0x3B6F80", Offset = "0x3B6180", VA = "0x1803B6F80")]
		private void LoadData()
		{
		}

		// Token: 0x06001614 RID: 5652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001614")]
		[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
		public RegionSource()
		{
		}

		// Token: 0x04001166 RID: 4454
		[Token(Token = "0x4001166")]
		[FieldOffset(Offset = "0x20")]
		private RegionType[] _types;
	}
}
