using System;
using Il2CppDummyDll;
using Ronin.Model.Definitions;

namespace MapEditor
{
	// Token: 0x020003C6 RID: 966
	[Token(Token = "0x20003C6")]
	public class TileSource : ObjectGallerySource
	{
		// Token: 0x0600161C RID: 5660 RVA: 0x00007998 File Offset: 0x00005B98
		[Token(Token = "0x600161C")]
		[Address(RVA = "0x3B97A0", Offset = "0x3B89A0", VA = "0x1803B97A0", Slot = "4")]
		public override int GetItemLength()
		{
			return 0;
		}

		// Token: 0x0600161D RID: 5661 RVA: 0x000079B0 File Offset: 0x00005BB0
		[Token(Token = "0x600161D")]
		[Address(RVA = "0x3B0C10", Offset = "0x3AFE10", VA = "0x1803B0C10", Slot = "5")]
		public override ushort GetItemTypeAt(int index)
		{
			return 0;
		}

		// Token: 0x0600161E RID: 5662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600161E")]
		[Address(RVA = "0x3B97D0", Offset = "0x3B89D0", VA = "0x1803B97D0")]
		private void LoadData()
		{
		}

		// Token: 0x0600161F RID: 5663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600161F")]
		[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
		public TileSource()
		{
		}

		// Token: 0x0400116D RID: 4461
		[Token(Token = "0x400116D")]
		[FieldOffset(Offset = "0x20")]
		private GroundDefinition[] _tileDatas;
	}
}
