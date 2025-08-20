using System;
using Il2CppDummyDll;

namespace SFB
{
	// Token: 0x02000355 RID: 853
	[Token(Token = "0x2000355")]
	public struct ExtensionFilter
	{
		// Token: 0x06001361 RID: 4961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001361")]
		[Address(RVA = "0x37B9C0", Offset = "0x37ABC0", VA = "0x18037B9C0")]
		public ExtensionFilter(string filterName, params string[] filterExtensions)
		{
		}

		// Token: 0x04000FC0 RID: 4032
		[Token(Token = "0x4000FC0")]
		[FieldOffset(Offset = "0x0")]
		public string Name;

		// Token: 0x04000FC1 RID: 4033
		[Token(Token = "0x4000FC1")]
		[FieldOffset(Offset = "0x8")]
		public string[] Extensions;
	}
}
