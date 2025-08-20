using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Discord
{
	// Token: 0x0200043C RID: 1084
	[Token(Token = "0x200043C")]
	public class VoiceManager
	{
		// Token: 0x04001284 RID: 4740
		[Token(Token = "0x4001284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr MethodsPtr;

		// Token: 0x04001285 RID: 4741
		[Token(Token = "0x4001285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object MethodsStructure;

		// Token: 0x04001286 RID: 4742
		[Token(Token = "0x4001286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[CompilerGenerated]
		private VoiceManager.SettingsUpdateHandler OnSettingsUpdate;

		// Token: 0x0200043D RID: 1085
		[Token(Token = "0x200043D")]
		internal struct FFIEvents
		{
			// Token: 0x04001287 RID: 4743
			[Token(Token = "0x4001287")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal VoiceManager.FFIEvents.SettingsUpdateHandler OnSettingsUpdate;

			// Token: 0x0200043E RID: 1086
			// (Invoke) Token: 0x060016C5 RID: 5829
			[Token(Token = "0x200043E")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void SettingsUpdateHandler(IntPtr ptr);
		}

		// Token: 0x0200043F RID: 1087
		// (Invoke) Token: 0x060016C7 RID: 5831
		[Token(Token = "0x200043F")]
		public delegate void SettingsUpdateHandler();
	}
}
