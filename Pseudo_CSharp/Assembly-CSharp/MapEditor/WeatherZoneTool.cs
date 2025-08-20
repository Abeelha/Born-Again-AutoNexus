using System;
using Il2CppDummyDll;

namespace MapEditor
{
	// Token: 0x020003AD RID: 941
	[Token(Token = "0x20003AD")]
	public sealed class WeatherZoneTool : PointZoneTool
	{
		// Token: 0x17000233 RID: 563
		// (get) Token: 0x06001599 RID: 5529 RVA: 0x00007788 File Offset: 0x00005988
		[Token(Token = "0x17000233")]
		protected override MapObjectType MapObjectType
		{
			[Token(Token = "0x6001599")]
			[Address(RVA = "0x3BB380", Offset = "0x3BA580", VA = "0x1803BB380", Slot = "14")]
			get
			{
				return MapObjectType.Tile;
			}
		}

		// Token: 0x0600159A RID: 5530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600159A")]
		[Address(RVA = "0x3BB300", Offset = "0x3BA500", VA = "0x1803BB300")]
		public WeatherZoneTool()
		{
		}
	}
}
