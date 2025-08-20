using System;
using Il2CppDummyDll;

namespace Discord
{
	// Token: 0x020003F2 RID: 1010
	[Token(Token = "0x20003F2")]
	public struct Entitlement
	{
		// Token: 0x040011F5 RID: 4597
		[Token(Token = "0x40011F5")]
		[FieldOffset(Offset = "0x0")]
		public long Id;

		// Token: 0x040011F6 RID: 4598
		[Token(Token = "0x40011F6")]
		[FieldOffset(Offset = "0x8")]
		public EntitlementType Type;

		// Token: 0x040011F7 RID: 4599
		[Token(Token = "0x40011F7")]
		[FieldOffset(Offset = "0x10")]
		public long SkuId;
	}
}
