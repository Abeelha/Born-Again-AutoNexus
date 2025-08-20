using System;
using Il2CppDummyDll;

namespace Discord
{
	// Token: 0x020003F1 RID: 1009
	[Token(Token = "0x20003F1")]
	public struct Relationship
	{
		// Token: 0x040011F2 RID: 4594
		[Token(Token = "0x40011F2")]
		[FieldOffset(Offset = "0x0")]
		public RelationshipType Type;

		// Token: 0x040011F3 RID: 4595
		[Token(Token = "0x40011F3")]
		[FieldOffset(Offset = "0x8")]
		public User User;

		// Token: 0x040011F4 RID: 4596
		[Token(Token = "0x40011F4")]
		[FieldOffset(Offset = "0x30")]
		public Presence Presence;
	}
}
