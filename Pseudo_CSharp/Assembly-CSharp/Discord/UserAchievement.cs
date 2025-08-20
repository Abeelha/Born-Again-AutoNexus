using System;
using Il2CppDummyDll;

namespace Discord
{
	// Token: 0x020003F3 RID: 1011
	[Token(Token = "0x20003F3")]
	public struct UserAchievement
	{
		// Token: 0x040011F8 RID: 4600
		[Token(Token = "0x40011F8")]
		[FieldOffset(Offset = "0x0")]
		public long UserId;

		// Token: 0x040011F9 RID: 4601
		[Token(Token = "0x40011F9")]
		[FieldOffset(Offset = "0x8")]
		public long AchievementId;

		// Token: 0x040011FA RID: 4602
		[Token(Token = "0x40011FA")]
		[FieldOffset(Offset = "0x10")]
		public byte PercentComplete;

		// Token: 0x040011FB RID: 4603
		[Token(Token = "0x40011FB")]
		[FieldOffset(Offset = "0x18")]
		public string UnlockedAt;
	}
}
