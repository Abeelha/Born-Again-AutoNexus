using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Discord
{
	// Token: 0x0200040C RID: 1036
	[Token(Token = "0x200040C")]
	public class UserManager
	{
		// Token: 0x04001254 RID: 4692
		[Token(Token = "0x4001254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr MethodsPtr;

		// Token: 0x04001255 RID: 4693
		[Token(Token = "0x4001255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object MethodsStructure;

		// Token: 0x04001256 RID: 4694
		[Token(Token = "0x4001256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[CompilerGenerated]
		private UserManager.CurrentUserUpdateHandler OnCurrentUserUpdate;

		// Token: 0x0200040D RID: 1037
		[Token(Token = "0x200040D")]
		internal struct FFIEvents
		{
			// Token: 0x04001257 RID: 4695
			[Token(Token = "0x4001257")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal UserManager.FFIEvents.CurrentUserUpdateHandler OnCurrentUserUpdate;

			// Token: 0x0200040E RID: 1038
			// (Invoke) Token: 0x06001685 RID: 5765
			[Token(Token = "0x200040E")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void CurrentUserUpdateHandler(IntPtr ptr);
		}

		// Token: 0x0200040F RID: 1039
		// (Invoke) Token: 0x06001687 RID: 5767
		[Token(Token = "0x200040F")]
		public delegate void CurrentUserUpdateHandler();
	}
}
