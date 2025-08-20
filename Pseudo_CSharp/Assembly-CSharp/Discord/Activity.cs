using System;
using Il2CppDummyDll;

namespace Discord
{
	// Token: 0x020003EF RID: 1007
	[Token(Token = "0x20003EF")]
	public struct Activity
	{
		// Token: 0x040011E6 RID: 4582
		[Token(Token = "0x40011E6")]
		[FieldOffset(Offset = "0x0")]
		public ActivityType Type;

		// Token: 0x040011E7 RID: 4583
		[Token(Token = "0x40011E7")]
		[FieldOffset(Offset = "0x8")]
		public long ApplicationId;

		// Token: 0x040011E8 RID: 4584
		[Token(Token = "0x40011E8")]
		[FieldOffset(Offset = "0x10")]
		public string Name;

		// Token: 0x040011E9 RID: 4585
		[Token(Token = "0x40011E9")]
		[FieldOffset(Offset = "0x18")]
		public string State;

		// Token: 0x040011EA RID: 4586
		[Token(Token = "0x40011EA")]
		[FieldOffset(Offset = "0x20")]
		public string Details;

		// Token: 0x040011EB RID: 4587
		[Token(Token = "0x40011EB")]
		[FieldOffset(Offset = "0x28")]
		public ActivityTimestamps Timestamps;

		// Token: 0x040011EC RID: 4588
		[Token(Token = "0x40011EC")]
		[FieldOffset(Offset = "0x38")]
		public ActivityAssets Assets;

		// Token: 0x040011ED RID: 4589
		[Token(Token = "0x40011ED")]
		[FieldOffset(Offset = "0x58")]
		public ActivityParty Party;

		// Token: 0x040011EE RID: 4590
		[Token(Token = "0x40011EE")]
		[FieldOffset(Offset = "0x68")]
		public ActivitySecrets Secrets;

		// Token: 0x040011EF RID: 4591
		[Token(Token = "0x40011EF")]
		[FieldOffset(Offset = "0x80")]
		public bool Instance;
	}
}
