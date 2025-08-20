using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Discord
{
	// Token: 0x0200042A RID: 1066
	[Token(Token = "0x200042A")]
	public class NetworkManager
	{
		// Token: 0x04001272 RID: 4722
		[Token(Token = "0x4001272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr MethodsPtr;

		// Token: 0x04001273 RID: 4723
		[Token(Token = "0x4001273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object MethodsStructure;

		// Token: 0x04001274 RID: 4724
		[Token(Token = "0x4001274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[CompilerGenerated]
		private NetworkManager.MessageHandler OnMessage;

		// Token: 0x04001275 RID: 4725
		[Token(Token = "0x4001275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[CompilerGenerated]
		private NetworkManager.RouteUpdateHandler OnRouteUpdate;

		// Token: 0x0200042B RID: 1067
		[Token(Token = "0x200042B")]
		internal struct FFIEvents
		{
			// Token: 0x04001276 RID: 4726
			[Token(Token = "0x4001276")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal NetworkManager.FFIEvents.MessageHandler OnMessage;

			// Token: 0x04001277 RID: 4727
			[Token(Token = "0x4001277")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal NetworkManager.FFIEvents.RouteUpdateHandler OnRouteUpdate;

			// Token: 0x0200042C RID: 1068
			// (Invoke) Token: 0x060016B1 RID: 5809
			[Token(Token = "0x200042C")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void MessageHandler(IntPtr ptr, ulong peerId, byte channelId, IntPtr dataPtr, int dataLen);

			// Token: 0x0200042D RID: 1069
			// (Invoke) Token: 0x060016B3 RID: 5811
			[Token(Token = "0x200042D")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void RouteUpdateHandler(IntPtr ptr, string routeData);
		}

		// Token: 0x0200042E RID: 1070
		// (Invoke) Token: 0x060016B5 RID: 5813
		[Token(Token = "0x200042E")]
		public delegate void MessageHandler(ulong peerId, byte channelId, byte[] data);

		// Token: 0x0200042F RID: 1071
		// (Invoke) Token: 0x060016B7 RID: 5815
		[Token(Token = "0x200042F")]
		public delegate void RouteUpdateHandler(string routeData);
	}
}
