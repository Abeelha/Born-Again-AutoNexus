using System;
using Il2CppDummyDll;

namespace SFB
{
	// Token: 0x02000356 RID: 854
	[Token(Token = "0x2000356")]
	public class StandaloneFileBrowser
	{
		// Token: 0x06001363 RID: 4963 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001363")]
		[Address(RVA = "0x37C770", Offset = "0x37B970", VA = "0x18037C770")]
		public static string[] OpenFilePanel(string title, string directory, string extension, bool multiselect)
		{
			return null;
		}

		// Token: 0x06001364 RID: 4964 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001364")]
		[Address(RVA = "0x37C9B0", Offset = "0x37BBB0", VA = "0x18037C9B0")]
		public static string[] OpenFilePanel(string title, string directory, ExtensionFilter[] extensions, bool multiselect)
		{
			return null;
		}

		// Token: 0x06001365 RID: 4965 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001365")]
		[Address(RVA = "0x37CC00", Offset = "0x37BE00", VA = "0x18037CC00")]
		public static string SaveFilePanel(string title, string directory, string defaultName, string extension)
		{
			return null;
		}

		// Token: 0x06001366 RID: 4966 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001366")]
		[Address(RVA = "0x37CAD0", Offset = "0x37BCD0", VA = "0x18037CAD0")]
		public static string SaveFilePanel(string title, string directory, string defaultName, ExtensionFilter[] extensions)
		{
			return null;
		}

		// Token: 0x04000FC2 RID: 4034
		[Token(Token = "0x4000FC2")]
		[FieldOffset(Offset = "0x0")]
		private static IStandaloneFileBrowser _platformWrapper;
	}
}
