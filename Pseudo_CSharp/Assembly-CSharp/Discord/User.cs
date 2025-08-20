using System;
using Il2CppDummyDll;

namespace Discord
{
	// Token: 0x020003E9 RID: 1001
	[Token(Token = "0x20003E9")]
	public struct User
	{
		// Token: 0x040011D4 RID: 4564
		[Token(Token = "0x40011D4")]
		[FieldOffset(Offset = "0x0")]
		public long Id;

		// Token: 0x040011D5 RID: 4565
		[Token(Token = "0x40011D5")]
		[FieldOffset(Offset = "0x8")]
		public string Username;

		// Token: 0x040011D6 RID: 4566
		[Token(Token = "0x40011D6")]
		[FieldOffset(Offset = "0x10")]
		public string Discriminator;

		// Token: 0x040011D7 RID: 4567
		[Token(Token = "0x40011D7")]
		[FieldOffset(Offset = "0x18")]
		public string Avatar;

		// Token: 0x040011D8 RID: 4568
		[Token(Token = "0x40011D8")]
		[FieldOffset(Offset = "0x20")]
		public bool Bot;
	}
}
