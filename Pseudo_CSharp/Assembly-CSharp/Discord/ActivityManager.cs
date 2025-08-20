using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Discord
{
	// Token: 0x020003C8 RID: 968
	[Token(Token = "0x20003C8")]
	public class ActivityManager
	{
		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06001624 RID: 5668 RVA: 0x000079E0 File Offset: 0x00005BE0
		[Token(Token = "0x17000238")]
		private ActivityManager.FFIMethods Methods
		{
			[Token(Token = "0x6001624")]
			[Address(RVA = "0x3ADE40", Offset = "0x3AD040", VA = "0x1803ADE40")]
			get
			{
				return default(ActivityManager.FFIMethods);
			}
		}

		// Token: 0x06001625 RID: 5669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001625")]
		[Address(RVA = "0x3ADD50", Offset = "0x3ACF50", VA = "0x1803ADD50")]
		internal ActivityManager(IntPtr ptr, IntPtr eventsPtr, ref ActivityManager.FFIEvents events)
		{
		}

		// Token: 0x06001626 RID: 5670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001626")]
		[Address(RVA = "0x3AD4B0", Offset = "0x3AC6B0", VA = "0x1803AD4B0")]
		private void InitEvents(IntPtr eventsPtr, ref ActivityManager.FFIEvents events)
		{
		}

		// Token: 0x06001627 RID: 5671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001627")]
		[Address(RVA = "0x3ADB60", Offset = "0x3ACD60", VA = "0x1803ADB60")]
		[MonoPInvokeCallback]
		private static void UpdateActivityCallbackImpl(IntPtr ptr, Result result)
		{
		}

		// Token: 0x06001628 RID: 5672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001628")]
		[Address(RVA = "0x3ADC00", Offset = "0x3ACE00", VA = "0x1803ADC00")]
		public void UpdateActivity(Activity activity, ActivityManager.UpdateActivityHandler callback)
		{
		}

		// Token: 0x06001629 RID: 5673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001629")]
		[Address(RVA = "0x3AD2D0", Offset = "0x3AC4D0", VA = "0x1803AD2D0")]
		[MonoPInvokeCallback]
		private static void ClearActivityCallbackImpl(IntPtr ptr, Result result)
		{
		}

		// Token: 0x0600162A RID: 5674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600162A")]
		[Address(RVA = "0x3AD370", Offset = "0x3AC570", VA = "0x1803AD370")]
		public void ClearActivity(ActivityManager.ClearActivityHandler callback)
		{
		}

		// Token: 0x0600162B RID: 5675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600162B")]
		[Address(RVA = "0x3AD920", Offset = "0x3ACB20", VA = "0x1803AD920")]
		[MonoPInvokeCallback]
		private static void OnActivityJoinImpl(IntPtr ptr, string secret)
		{
		}

		// Token: 0x0600162C RID: 5676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600162C")]
		[Address(RVA = "0x3ADAA0", Offset = "0x3ACCA0", VA = "0x1803ADAA0")]
		[MonoPInvokeCallback]
		private static void OnActivitySpectateImpl(IntPtr ptr, string secret)
		{
		}

		// Token: 0x0600162D RID: 5677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600162D")]
		[Address(RVA = "0x3AD9E0", Offset = "0x3ACBE0", VA = "0x1803AD9E0")]
		[MonoPInvokeCallback]
		private static void OnActivityJoinRequestImpl(IntPtr ptr, ref User user)
		{
		}

		// Token: 0x0600162E RID: 5678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600162E")]
		[Address(RVA = "0x3AD840", Offset = "0x3ACA40", VA = "0x1803AD840")]
		[MonoPInvokeCallback]
		private static void OnActivityInviteImpl(IntPtr ptr, ActivityActionType type, ref User user, ref Activity activity)
		{
		}

		// Token: 0x04001171 RID: 4465
		[Token(Token = "0x4001171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr MethodsPtr;

		// Token: 0x04001172 RID: 4466
		[Token(Token = "0x4001172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object MethodsStructure;

		// Token: 0x04001173 RID: 4467
		[Token(Token = "0x4001173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[CompilerGenerated]
		private ActivityManager.ActivityJoinHandler OnActivityJoin;

		// Token: 0x04001174 RID: 4468
		[Token(Token = "0x4001174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[CompilerGenerated]
		private ActivityManager.ActivitySpectateHandler OnActivitySpectate;

		// Token: 0x04001175 RID: 4469
		[Token(Token = "0x4001175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[CompilerGenerated]
		private ActivityManager.ActivityJoinRequestHandler OnActivityJoinRequest;

		// Token: 0x04001176 RID: 4470
		[Token(Token = "0x4001176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[CompilerGenerated]
		private ActivityManager.ActivityInviteHandler OnActivityInvite;

		// Token: 0x020003C9 RID: 969
		[Token(Token = "0x20003C9")]
		internal struct FFIEvents
		{
			// Token: 0x04001177 RID: 4471
			[Token(Token = "0x4001177")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal ActivityManager.FFIEvents.ActivityJoinHandler OnActivityJoin;

			// Token: 0x04001178 RID: 4472
			[Token(Token = "0x4001178")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal ActivityManager.FFIEvents.ActivitySpectateHandler OnActivitySpectate;

			// Token: 0x04001179 RID: 4473
			[Token(Token = "0x4001179")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal ActivityManager.FFIEvents.ActivityJoinRequestHandler OnActivityJoinRequest;

			// Token: 0x0400117A RID: 4474
			[Token(Token = "0x400117A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal ActivityManager.FFIEvents.ActivityInviteHandler OnActivityInvite;

			// Token: 0x020003CA RID: 970
			// (Invoke) Token: 0x06001630 RID: 5680
			[Token(Token = "0x20003CA")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void ActivityJoinHandler(IntPtr ptr, string secret);

			// Token: 0x020003CB RID: 971
			// (Invoke) Token: 0x06001632 RID: 5682
			[Token(Token = "0x20003CB")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void ActivitySpectateHandler(IntPtr ptr, string secret);

			// Token: 0x020003CC RID: 972
			// (Invoke) Token: 0x06001634 RID: 5684
			[Token(Token = "0x20003CC")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void ActivityJoinRequestHandler(IntPtr ptr, ref User user);

			// Token: 0x020003CD RID: 973
			// (Invoke) Token: 0x06001636 RID: 5686
			[Token(Token = "0x20003CD")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void ActivityInviteHandler(IntPtr ptr, ActivityActionType type, ref User user, ref Activity activity);
		}

		// Token: 0x020003CE RID: 974
		[Token(Token = "0x20003CE")]
		internal struct FFIMethods
		{
			// Token: 0x0400117B RID: 4475
			[Token(Token = "0x400117B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal ActivityManager.FFIMethods.RegisterCommandMethod RegisterCommand;

			// Token: 0x0400117C RID: 4476
			[Token(Token = "0x400117C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal ActivityManager.FFIMethods.RegisterSteamMethod RegisterSteam;

			// Token: 0x0400117D RID: 4477
			[Token(Token = "0x400117D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal ActivityManager.FFIMethods.UpdateActivityMethod UpdateActivity;

			// Token: 0x0400117E RID: 4478
			[Token(Token = "0x400117E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal ActivityManager.FFIMethods.ClearActivityMethod ClearActivity;

			// Token: 0x0400117F RID: 4479
			[Token(Token = "0x400117F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal ActivityManager.FFIMethods.SendRequestReplyMethod SendRequestReply;

			// Token: 0x04001180 RID: 4480
			[Token(Token = "0x4001180")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal ActivityManager.FFIMethods.SendInviteMethod SendInvite;

			// Token: 0x04001181 RID: 4481
			[Token(Token = "0x4001181")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal ActivityManager.FFIMethods.AcceptInviteMethod AcceptInvite;

			// Token: 0x020003CF RID: 975
			// (Invoke) Token: 0x06001638 RID: 5688
			[Token(Token = "0x20003CF")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result RegisterCommandMethod(IntPtr methodsPtr, string command);

			// Token: 0x020003D0 RID: 976
			// (Invoke) Token: 0x0600163A RID: 5690
			[Token(Token = "0x20003D0")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result RegisterSteamMethod(IntPtr methodsPtr, uint steamId);

			// Token: 0x020003D1 RID: 977
			// (Invoke) Token: 0x0600163C RID: 5692
			[Token(Token = "0x20003D1")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void UpdateActivityCallback(IntPtr ptr, Result result);

			// Token: 0x020003D2 RID: 978
			// (Invoke) Token: 0x0600163E RID: 5694
			[Token(Token = "0x20003D2")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void UpdateActivityMethod(IntPtr methodsPtr, ref Activity activity, IntPtr callbackData, ActivityManager.FFIMethods.UpdateActivityCallback callback);

			// Token: 0x020003D3 RID: 979
			// (Invoke) Token: 0x06001640 RID: 5696
			[Token(Token = "0x20003D3")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void ClearActivityCallback(IntPtr ptr, Result result);

			// Token: 0x020003D4 RID: 980
			// (Invoke) Token: 0x06001642 RID: 5698
			[Token(Token = "0x20003D4")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void ClearActivityMethod(IntPtr methodsPtr, IntPtr callbackData, ActivityManager.FFIMethods.ClearActivityCallback callback);

			// Token: 0x020003D5 RID: 981
			// (Invoke) Token: 0x06001644 RID: 5700
			[Token(Token = "0x20003D5")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void SendRequestReplyCallback(IntPtr ptr, Result result);

			// Token: 0x020003D6 RID: 982
			// (Invoke) Token: 0x06001646 RID: 5702
			[Token(Token = "0x20003D6")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void SendRequestReplyMethod(IntPtr methodsPtr, long userId, ActivityJoinRequestReply reply, IntPtr callbackData, ActivityManager.FFIMethods.SendRequestReplyCallback callback);

			// Token: 0x020003D7 RID: 983
			// (Invoke) Token: 0x06001648 RID: 5704
			[Token(Token = "0x20003D7")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void SendInviteCallback(IntPtr ptr, Result result);

			// Token: 0x020003D8 RID: 984
			// (Invoke) Token: 0x0600164A RID: 5706
			[Token(Token = "0x20003D8")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void SendInviteMethod(IntPtr methodsPtr, long userId, ActivityActionType type, string content, IntPtr callbackData, ActivityManager.FFIMethods.SendInviteCallback callback);

			// Token: 0x020003D9 RID: 985
			// (Invoke) Token: 0x0600164C RID: 5708
			[Token(Token = "0x20003D9")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void AcceptInviteCallback(IntPtr ptr, Result result);

			// Token: 0x020003DA RID: 986
			// (Invoke) Token: 0x0600164E RID: 5710
			[Token(Token = "0x20003DA")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void AcceptInviteMethod(IntPtr methodsPtr, long userId, IntPtr callbackData, ActivityManager.FFIMethods.AcceptInviteCallback callback);
		}

		// Token: 0x020003DB RID: 987
		// (Invoke) Token: 0x06001650 RID: 5712
		[Token(Token = "0x20003DB")]
		public delegate void UpdateActivityHandler(Result result);

		// Token: 0x020003DC RID: 988
		// (Invoke) Token: 0x06001652 RID: 5714
		[Token(Token = "0x20003DC")]
		public delegate void ClearActivityHandler(Result result);

		// Token: 0x020003DD RID: 989
		// (Invoke) Token: 0x06001654 RID: 5716
		[Token(Token = "0x20003DD")]
		public delegate void ActivityJoinHandler(string secret);

		// Token: 0x020003DE RID: 990
		// (Invoke) Token: 0x06001656 RID: 5718
		[Token(Token = "0x20003DE")]
		public delegate void ActivitySpectateHandler(string secret);

		// Token: 0x020003DF RID: 991
		// (Invoke) Token: 0x06001658 RID: 5720
		[Token(Token = "0x20003DF")]
		public delegate void ActivityJoinRequestHandler(ref User user);

		// Token: 0x020003E0 RID: 992
		// (Invoke) Token: 0x0600165A RID: 5722
		[Token(Token = "0x20003E0")]
		public delegate void ActivityInviteHandler(ActivityActionType type, ref User user, ref Activity activity);
	}
}
