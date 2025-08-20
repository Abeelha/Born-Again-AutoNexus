using System;
using Il2CppDummyDll;

namespace MapEditor
{
	// Token: 0x020003A0 RID: 928
	[Token(Token = "0x20003A0")]
	public class EraseTool : PencilTool
	{
		// Token: 0x06001551 RID: 5457 RVA: 0x00007608 File Offset: 0x00005808
		[Token(Token = "0x6001551")]
		[Address(RVA = "0x3B1FF0", Offset = "0x3B11F0", VA = "0x1803B1FF0", Slot = "14")]
		protected override ushort GetDrawType(MapEditorContext context)
		{
			return 0;
		}

		// Token: 0x06001552 RID: 5458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001552")]
		[Address(RVA = "0x3B2000", Offset = "0x3B1200", VA = "0x1803B2000")]
		public EraseTool()
		{
		}
	}
}
