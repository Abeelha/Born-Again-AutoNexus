using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Discord
{
	// Token: 0x02000418 RID: 1048
	[Token(Token = "0x2000418")]
	public class LobbyManager
	{
		// Token: 0x04001260 RID: 4704
		[Token(Token = "0x4001260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr MethodsPtr;

		// Token: 0x04001261 RID: 4705
		[Token(Token = "0x4001261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object MethodsStructure;

		// Token: 0x04001262 RID: 4706
		[Token(Token = "0x4001262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[CompilerGenerated]
		private LobbyManager.LobbyUpdateHandler OnLobbyUpdate;

		// Token: 0x04001263 RID: 4707
		[Token(Token = "0x4001263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[CompilerGenerated]
		private LobbyManager.LobbyDeleteHandler OnLobbyDelete;

		// Token: 0x04001264 RID: 4708
		[Token(Token = "0x4001264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[CompilerGenerated]
		private LobbyManager.MemberConnectHandler OnMemberConnect;

		// Token: 0x04001265 RID: 4709
		[Token(Token = "0x4001265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[CompilerGenerated]
		private LobbyManager.MemberUpdateHandler OnMemberUpdate;

		// Token: 0x04001266 RID: 4710
		[Token(Token = "0x4001266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[CompilerGenerated]
		private LobbyManager.MemberDisconnectHandler OnMemberDisconnect;

		// Token: 0x04001267 RID: 4711
		[Token(Token = "0x4001267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[CompilerGenerated]
		private LobbyManager.LobbyMessageHandler OnLobbyMessage;

		// Token: 0x04001268 RID: 4712
		[Token(Token = "0x4001268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[CompilerGenerated]
		private LobbyManager.SpeakingHandler OnSpeaking;

		// Token: 0x04001269 RID: 4713
		[Token(Token = "0x4001269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[CompilerGenerated]
		private LobbyManager.NetworkMessageHandler OnNetworkMessage;

		// Token: 0x02000419 RID: 1049
		[Token(Token = "0x2000419")]
		internal struct FFIEvents
		{
			// Token: 0x0400126A RID: 4714
			[Token(Token = "0x400126A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal LobbyManager.FFIEvents.LobbyUpdateHandler OnLobbyUpdate;

			// Token: 0x0400126B RID: 4715
			[Token(Token = "0x400126B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal LobbyManager.FFIEvents.LobbyDeleteHandler OnLobbyDelete;

			// Token: 0x0400126C RID: 4716
			[Token(Token = "0x400126C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal LobbyManager.FFIEvents.MemberConnectHandler OnMemberConnect;

			// Token: 0x0400126D RID: 4717
			[Token(Token = "0x400126D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal LobbyManager.FFIEvents.MemberUpdateHandler OnMemberUpdate;

			// Token: 0x0400126E RID: 4718
			[Token(Token = "0x400126E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal LobbyManager.FFIEvents.MemberDisconnectHandler OnMemberDisconnect;

			// Token: 0x0400126F RID: 4719
			[Token(Token = "0x400126F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal LobbyManager.FFIEvents.LobbyMessageHandler OnLobbyMessage;

			// Token: 0x04001270 RID: 4720
			[Token(Token = "0x4001270")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal LobbyManager.FFIEvents.SpeakingHandler OnSpeaking;

			// Token: 0x04001271 RID: 4721
			[Token(Token = "0x4001271")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal LobbyManager.FFIEvents.NetworkMessageHandler OnNetworkMessage;

			// Token: 0x0200041A RID: 1050
			// (Invoke) Token: 0x06001691 RID: 5777
			[Token(Token = "0x200041A")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void LobbyUpdateHandler(IntPtr ptr, long lobbyId);

			// Token: 0x0200041B RID: 1051
			// (Invoke) Token: 0x06001693 RID: 5779
			[Token(Token = "0x200041B")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void LobbyDeleteHandler(IntPtr ptr, long lobbyId, uint reason);

			// Token: 0x0200041C RID: 1052
			// (Invoke) Token: 0x06001695 RID: 5781
			[Token(Token = "0x200041C")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void MemberConnectHandler(IntPtr ptr, long lobbyId, long userId);

			// Token: 0x0200041D RID: 1053
			// (Invoke) Token: 0x06001697 RID: 5783
			[Token(Token = "0x200041D")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void MemberUpdateHandler(IntPtr ptr, long lobbyId, long userId);

			// Token: 0x0200041E RID: 1054
			// (Invoke) Token: 0x06001699 RID: 5785
			[Token(Token = "0x200041E")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void MemberDisconnectHandler(IntPtr ptr, long lobbyId, long userId);

			// Token: 0x0200041F RID: 1055
			// (Invoke) Token: 0x0600169B RID: 5787
			[Token(Token = "0x200041F")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void LobbyMessageHandler(IntPtr ptr, long lobbyId, long userId, IntPtr dataPtr, int dataLen);

			// Token: 0x02000420 RID: 1056
			// (Invoke) Token: 0x0600169D RID: 5789
			[Token(Token = "0x2000420")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void SpeakingHandler(IntPtr ptr, long lobbyId, long userId, bool speaking);

			// Token: 0x02000421 RID: 1057
			// (Invoke) Token: 0x0600169F RID: 5791
			[Token(Token = "0x2000421")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void NetworkMessageHandler(IntPtr ptr, long lobbyId, long userId, byte channelId, IntPtr dataPtr, int dataLen);
		}

		// Token: 0x02000422 RID: 1058
		// (Invoke) Token: 0x060016A1 RID: 5793
		[Token(Token = "0x2000422")]
		public delegate void LobbyUpdateHandler(long lobbyId);

		// Token: 0x02000423 RID: 1059
		// (Invoke) Token: 0x060016A3 RID: 5795
		[Token(Token = "0x2000423")]
		public delegate void LobbyDeleteHandler(long lobbyId, uint reason);

		// Token: 0x02000424 RID: 1060
		// (Invoke) Token: 0x060016A5 RID: 5797
		[Token(Token = "0x2000424")]
		public delegate void MemberConnectHandler(long lobbyId, long userId);

		// Token: 0x02000425 RID: 1061
		// (Invoke) Token: 0x060016A7 RID: 5799
		[Token(Token = "0x2000425")]
		public delegate void MemberUpdateHandler(long lobbyId, long userId);

		// Token: 0x02000426 RID: 1062
		// (Invoke) Token: 0x060016A9 RID: 5801
		[Token(Token = "0x2000426")]
		public delegate void MemberDisconnectHandler(long lobbyId, long userId);

		// Token: 0x02000427 RID: 1063
		// (Invoke) Token: 0x060016AB RID: 5803
		[Token(Token = "0x2000427")]
		public delegate void LobbyMessageHandler(long lobbyId, long userId, byte[] data);

		// Token: 0x02000428 RID: 1064
		// (Invoke) Token: 0x060016AD RID: 5805
		[Token(Token = "0x2000428")]
		public delegate void SpeakingHandler(long lobbyId, long userId, bool speaking);

		// Token: 0x02000429 RID: 1065
		// (Invoke) Token: 0x060016AF RID: 5807
		[Token(Token = "0x2000429")]
		public delegate void NetworkMessageHandler(long lobbyId, long userId, byte channelId, byte[] data);
	}
}
