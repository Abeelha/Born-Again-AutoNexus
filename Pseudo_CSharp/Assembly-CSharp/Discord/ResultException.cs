using System;
using Il2CppDummyDll;

namespace Discord
{
	// Token: 0x020003F4 RID: 1012
	[Token(Token = "0x20003F4")]
	public class ResultException : Exception
	{
		// Token: 0x0600165B RID: 5723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600165B")]
		[Address(RVA = "0x3B7340", Offset = "0x3B6540", VA = "0x1803B7340")]
		public ResultException(Result result)
		{
		}

		// Token: 0x040011FC RID: 4604
		[Token(Token = "0x40011FC")]
		[FieldOffset(Offset = "0x90")]
		public readonly Result Result;
	}
}
