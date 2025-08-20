using System;
using Il2CppDummyDll;
using Ronin.Model.Definitions;

namespace MapEditor
{
	// Token: 0x020003C0 RID: 960
	[Token(Token = "0x20003C0")]
	public class ObjectSource : ObjectGallerySource
	{
		// Token: 0x06001606 RID: 5638 RVA: 0x00007908 File Offset: 0x00005B08
		[Token(Token = "0x6001606")]
		[Address(RVA = "0x3B5E90", Offset = "0x3B5090", VA = "0x1803B5E90", Slot = "4")]
		public override int GetItemLength()
		{
			return 0;
		}

		// Token: 0x06001607 RID: 5639 RVA: 0x00007920 File Offset: 0x00005B20
		[Token(Token = "0x6001607")]
		[Address(RVA = "0x3B0C10", Offset = "0x3AFE10", VA = "0x1803B0C10", Slot = "5")]
		public override ushort GetItemTypeAt(int index)
		{
			return 0;
		}

		// Token: 0x06001608 RID: 5640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001608")]
		[Address(RVA = "0x3B6060", Offset = "0x3B5260", VA = "0x1803B6060")]
		private void LoadData()
		{
		}

		// Token: 0x06001609 RID: 5641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001609")]
		[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
		public ObjectSource()
		{
		}

		// Token: 0x0400115E RID: 4446
		[Token(Token = "0x400115E")]
		[FieldOffset(Offset = "0x20")]
		private ObjectDefinition[] _datas;
	}
}
