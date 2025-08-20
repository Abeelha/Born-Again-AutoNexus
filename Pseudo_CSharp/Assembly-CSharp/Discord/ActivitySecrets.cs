using System;
using Il2CppDummyDll;

namespace Discord
{
	// Token: 0x020003EE RID: 1006
	[Token(Token = "0x20003EE")]
	public struct ActivitySecrets
	{
		// Token: 0x040011E3 RID: 4579
		[Token(Token = "0x40011E3")]
		[FieldOffset(Offset = "0x0")]
		public string Match;

		// Token: 0x040011E4 RID: 4580
		[Token(Token = "0x40011E4")]
		[FieldOffset(Offset = "0x8")]
		public string Join;

		// Token: 0x040011E5 RID: 4581
		[Token(Token = "0x40011E5")]
		[FieldOffset(Offset = "0x10")]
		public string Spectate;
	}
}
