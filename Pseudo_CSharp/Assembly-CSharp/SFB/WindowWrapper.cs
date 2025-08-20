using System;
using System.Windows.Forms;
using Il2CppDummyDll;

namespace SFB
{
	// Token: 0x02000357 RID: 855
	[Token(Token = "0x2000357")]
	public class WindowWrapper : IWin32Window
	{
		// Token: 0x06001367 RID: 4967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001367")]
		[Address(RVA = "0x385500", Offset = "0x384700", VA = "0x180385500")]
		public WindowWrapper(IntPtr handle)
		{
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06001368 RID: 4968 RVA: 0x00006E70 File Offset: 0x00005070
		[Token(Token = "0x17000202")]
		public IntPtr Handle
		{
			[Token(Token = "0x6001368")]
			[Address(RVA = "0x3328E0", Offset = "0x331AE0", VA = "0x1803328E0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x04000FC3 RID: 4035
		[Token(Token = "0x4000FC3")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr _hwnd;
	}
}
