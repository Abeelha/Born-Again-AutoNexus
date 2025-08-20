using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace SFB
{
	// Token: 0x02000358 RID: 856
	[Token(Token = "0x2000358")]
	public class StandaloneFileBrowserWindows : IStandaloneFileBrowser
	{
		// Token: 0x06001369 RID: 4969
		[Token(Token = "0x6001369")]
		[Address(RVA = "0x37BF90", Offset = "0x37B190", VA = "0x18037BF90")]
		[PreserveSig]
		private static extern IntPtr GetActiveWindow();

		// Token: 0x0600136A RID: 4970 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600136A")]
		[Address(RVA = "0x37C320", Offset = "0x37B520", VA = "0x18037C320", Slot = "4")]
		public string[] OpenFilePanel(string title, string directory, ExtensionFilter[] extensions, bool multiselect)
		{
			return null;
		}

		// Token: 0x0600136B RID: 4971 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600136B")]
		[Address(RVA = "0x37C510", Offset = "0x37B710", VA = "0x18037C510", Slot = "5")]
		public string SaveFilePanel(string title, string directory, string defaultName, ExtensionFilter[] extensions)
		{
			return null;
		}

		// Token: 0x0600136C RID: 4972 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600136C")]
		[Address(RVA = "0x37C150", Offset = "0x37B350", VA = "0x18037C150")]
		private static string GetFilterFromFileExtensionList(ExtensionFilter[] extensions)
		{
			return null;
		}

		// Token: 0x0600136D RID: 4973 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600136D")]
		[Address(RVA = "0x37C000", Offset = "0x37B200", VA = "0x18037C000")]
		private static string GetDirectoryPath(string directory)
		{
			return null;
		}

		// Token: 0x0600136E RID: 4974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600136E")]
		[Address(RVA = "0x316100", Offset = "0x315300", VA = "0x180316100")]
		public StandaloneFileBrowserWindows()
		{
		}
	}
}
