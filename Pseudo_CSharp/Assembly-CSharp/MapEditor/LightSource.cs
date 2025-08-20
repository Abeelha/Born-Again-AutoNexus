using System;
using Il2CppDummyDll;

namespace MapEditor
{
	// Token: 0x020003BA RID: 954
	[Token(Token = "0x20003BA")]
	public class LightSource : ObjectGallerySource
	{
		// Token: 0x060015E8 RID: 5608 RVA: 0x00007890 File Offset: 0x00005A90
		[Token(Token = "0x60015E8")]
		[Address(RVA = "0x3B2600", Offset = "0x3B1800", VA = "0x1803B2600", Slot = "4")]
		public override int GetItemLength()
		{
			return 0;
		}

		// Token: 0x060015E9 RID: 5609 RVA: 0x000078A8 File Offset: 0x00005AA8
		[Token(Token = "0x60015E9")]
		[Address(RVA = "0x3B2780", Offset = "0x3B1980", VA = "0x1803B2780", Slot = "5")]
		public override ushort GetItemTypeAt(int index)
		{
			return 0;
		}

		// Token: 0x060015EA RID: 5610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015EA")]
		[Address(RVA = "0x3B27B0", Offset = "0x3B19B0", VA = "0x1803B27B0")]
		private void LoadData()
		{
		}

		// Token: 0x060015EB RID: 5611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015EB")]
		[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
		public LightSource()
		{
		}

		// Token: 0x0400114E RID: 4430
		[Token(Token = "0x400114E")]
		[FieldOffset(Offset = "0x20")]
		private ushort[] _types;
	}
}
