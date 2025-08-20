using System;
using Il2CppDummyDll;
using Ronin.Model.Definitions;

namespace MapEditor
{
	// Token: 0x020003B7 RID: 951
	[Token(Token = "0x20003B7")]
	public class CeilingSource : ObjectGallerySource
	{
		// Token: 0x060015DC RID: 5596 RVA: 0x00007848 File Offset: 0x00005A48
		[Token(Token = "0x60015DC")]
		[Address(RVA = "0x3B0BE0", Offset = "0x3AFDE0", VA = "0x1803B0BE0", Slot = "4")]
		public override int GetItemLength()
		{
			return 0;
		}

		// Token: 0x060015DD RID: 5597 RVA: 0x00007860 File Offset: 0x00005A60
		[Token(Token = "0x60015DD")]
		[Address(RVA = "0x3B0C10", Offset = "0x3AFE10", VA = "0x1803B0C10", Slot = "5")]
		public override ushort GetItemTypeAt(int index)
		{
			return 0;
		}

		// Token: 0x060015DE RID: 5598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015DE")]
		[Address(RVA = "0x3B0C50", Offset = "0x3AFE50", VA = "0x1803B0C50")]
		private void LoadData()
		{
		}

		// Token: 0x060015DF RID: 5599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015DF")]
		[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
		public CeilingSource()
		{
		}

		// Token: 0x04001146 RID: 4422
		[Token(Token = "0x4001146")]
		[FieldOffset(Offset = "0x20")]
		private CeilingDefinition[] _ceilingDatas;
	}
}
