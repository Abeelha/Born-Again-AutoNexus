using System;
using Il2CppDummyDll;

namespace Discord
{
	// Token: 0x020003F0 RID: 1008
	[Token(Token = "0x20003F0")]
	public struct Presence
	{
		// Token: 0x040011F0 RID: 4592
		[Token(Token = "0x40011F0")]
		[FieldOffset(Offset = "0x0")]
		public Status Status;

		// Token: 0x040011F1 RID: 4593
		[Token(Token = "0x40011F1")]
		[FieldOffset(Offset = "0x8")]
		public Activity Activity;
	}
}
