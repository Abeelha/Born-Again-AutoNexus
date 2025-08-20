using System;
using Il2CppDummyDll;

namespace SFB
{
	// Token: 0x02000354 RID: 852
	[Token(Token = "0x2000354")]
	public interface IStandaloneFileBrowser
	{
		// Token: 0x0600135F RID: 4959
		[Token(Token = "0x600135F")]
		string[] OpenFilePanel(string title, string directory, ExtensionFilter[] extensions, bool multiselect);

		// Token: 0x06001360 RID: 4960
		[Token(Token = "0x6001360")]
		string SaveFilePanel(string title, string directory, string defaultName, ExtensionFilter[] extensions);
	}
}
