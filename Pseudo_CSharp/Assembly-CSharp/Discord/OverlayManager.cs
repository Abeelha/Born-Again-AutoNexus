using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Discord
{
	// Token: 0x02000430 RID: 1072
	[Token(Token = "0x2000430")]
	public class OverlayManager
	{
		// Token: 0x04001278 RID: 4728
		[Token(Token = "0x4001278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr MethodsPtr;

		// Token: 0x04001279 RID: 4729
		[Token(Token = "0x4001279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object MethodsStructure;

		// Token: 0x0400127A RID: 4730
		[Token(Token = "0x400127A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[CompilerGenerated]
		private OverlayManager.ToggleHandler OnToggle;

		// Token: 0x02000431 RID: 1073
		[Token(Token = "0x2000431")]
		internal struct FFIEvents
		{
			// Token: 0x0400127B RID: 4731
			[Token(Token = "0x400127B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal OverlayManager.FFIEvents.ToggleHandler OnToggle;

			// Token: 0x02000432 RID: 1074
			// (Invoke) Token: 0x060016B9 RID: 5817
			[Token(Token = "0x2000432")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void ToggleHandler(IntPtr ptr, bool locked);
		}

		// Token: 0x02000433 RID: 1075
		// (Invoke) Token: 0x060016BB RID: 5819
		[Token(Token = "0x2000433")]
		public delegate void ToggleHandler(bool locked);
	}
}
