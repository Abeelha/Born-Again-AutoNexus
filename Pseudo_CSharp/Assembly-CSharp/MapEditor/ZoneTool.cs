using System;
using Il2CppDummyDll;

namespace MapEditor
{
	// Token: 0x020003AE RID: 942
	[Token(Token = "0x20003AE")]
	public sealed class ZoneTool : PointZoneTool
	{
		// Token: 0x17000234 RID: 564
		// (get) Token: 0x0600159B RID: 5531 RVA: 0x000077A0 File Offset: 0x000059A0
		[Token(Token = "0x17000234")]
		protected override MapObjectType MapObjectType
		{
			[Token(Token = "0x600159B")]
			[Address(RVA = "0x3BB410", Offset = "0x3BA610", VA = "0x1803BB410", Slot = "14")]
			get
			{
				return MapObjectType.Tile;
			}
		}

		// Token: 0x0600159C RID: 5532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600159C")]
		[Address(RVA = "0x3BB390", Offset = "0x3BA590", VA = "0x1803BB390")]
		public ZoneTool()
		{
		}
	}
}
