using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

// Token: 0x020001AD RID: 429
[Token(Token = "0x20001AD")]
public static class Alert
{
	// Token: 0x170000D3 RID: 211
	// (get) Token: 0x0600089C RID: 2204 RVA: 0x000042D8 File Offset: 0x000024D8
	[Token(Token = "0x170000D3")]
	public static bool Showing
	{
		[Token(Token = "0x600089C")]
		[Address(RVA = "0x406F00", Offset = "0x406100", VA = "0x180406F00")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x0600089D RID: 2205 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600089D")]
	[Address(RVA = "0x406E20", Offset = "0x406020", VA = "0x180406E20")]
	public static AlertFrame Show(string title, string message, AlertButtonDescriptor[] buttons, [Optional] AlertInputDescriptor input, bool largeMessage = false)
	{
		return null;
	}

	// Token: 0x0600089E RID: 2206 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600089E")]
	[Address(RVA = "0x406BC0", Offset = "0x405DC0", VA = "0x180406BC0")]
	public static AlertFrame Show(string title, string message, bool largeMessage = false)
	{
		return null;
	}

	// Token: 0x0600089F RID: 2207 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600089F")]
	[Address(RVA = "0x4069F0", Offset = "0x405BF0", VA = "0x1804069F0")]
	private static AlertButtonDescriptor[] GetDefaultButtons()
	{
		return null;
	}
}
