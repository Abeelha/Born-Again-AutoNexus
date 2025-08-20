using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Discord
{
	// Token: 0x020003F5 RID: 1013
	[Token(Token = "0x20003F5")]
	public class Discord : IDisposable
	{
		// Token: 0x0600165C RID: 5724
		[Token(Token = "0x600165C")]
		[Address(RVA = "0x3B1310", Offset = "0x3B0510", VA = "0x1803B1310")]
		[PreserveSig]
		private static extern Result DiscordCreate(uint version, ref Discord.FFICreateParams createParams, out IntPtr manager);

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x0600165D RID: 5725 RVA: 0x000079F8 File Offset: 0x00005BF8
		[Token(Token = "0x17000239")]
		private Discord.FFIMethods Methods
		{
			[Token(Token = "0x600165D")]
			[Address(RVA = "0x3B1D80", Offset = "0x3B0F80", VA = "0x1803B1D80")]
			get
			{
				return default(Discord.FFIMethods);
			}
		}

		// Token: 0x0600165E RID: 5726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600165E")]
		[Address(RVA = "0x3B1810", Offset = "0x3B0A10", VA = "0x1803B1810")]
		public Discord(long clientId, ulong flags)
		{
		}

		// Token: 0x0600165F RID: 5727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600165F")]
		[Address(RVA = "0x3B1700", Offset = "0x3B0900", VA = "0x1803B1700")]
		private void InitEvents(IntPtr eventsPtr, ref Discord.FFIEvents events)
		{
		}

		// Token: 0x06001660 RID: 5728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001660")]
		[Address(RVA = "0x3B13B0", Offset = "0x3B05B0", VA = "0x1803B13B0", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06001661 RID: 5729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001661")]
		[Address(RVA = "0x3B1770", Offset = "0x3B0970", VA = "0x1803B1770")]
		public void RunCallbacks()
		{
		}

		// Token: 0x06001662 RID: 5730 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001662")]
		[Address(RVA = "0x3B1560", Offset = "0x3B0760", VA = "0x1803B1560")]
		public ActivityManager GetActivityManager()
		{
			return null;
		}

		// Token: 0x040011FD RID: 4605
		[Token(Token = "0x40011FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private GCHandle SelfHandle;

		// Token: 0x040011FE RID: 4606
		[Token(Token = "0x40011FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IntPtr EventsPtr;

		// Token: 0x040011FF RID: 4607
		[Token(Token = "0x40011FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Discord.FFIEvents Events;

		// Token: 0x04001200 RID: 4608
		[Token(Token = "0x4001200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IntPtr ApplicationEventsPtr;

		// Token: 0x04001201 RID: 4609
		[Token(Token = "0x4001201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ApplicationManager.FFIEvents ApplicationEvents;

		// Token: 0x04001202 RID: 4610
		[Token(Token = "0x4001202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal ApplicationManager ApplicationManagerInstance;

		// Token: 0x04001203 RID: 4611
		[Token(Token = "0x4001203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private IntPtr UserEventsPtr;

		// Token: 0x04001204 RID: 4612
		[Token(Token = "0x4001204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private UserManager.FFIEvents UserEvents;

		// Token: 0x04001205 RID: 4613
		[Token(Token = "0x4001205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		internal UserManager UserManagerInstance;

		// Token: 0x04001206 RID: 4614
		[Token(Token = "0x4001206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private IntPtr ImageEventsPtr;

		// Token: 0x04001207 RID: 4615
		[Token(Token = "0x4001207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ImageManager.FFIEvents ImageEvents;

		// Token: 0x04001208 RID: 4616
		[Token(Token = "0x4001208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		internal ImageManager ImageManagerInstance;

		// Token: 0x04001209 RID: 4617
		[Token(Token = "0x4001209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private IntPtr ActivityEventsPtr;

		// Token: 0x0400120A RID: 4618
		[Token(Token = "0x400120A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private ActivityManager.FFIEvents ActivityEvents;

		// Token: 0x0400120B RID: 4619
		[Token(Token = "0x400120B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		internal ActivityManager ActivityManagerInstance;

		// Token: 0x0400120C RID: 4620
		[Token(Token = "0x400120C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private IntPtr RelationshipEventsPtr;

		// Token: 0x0400120D RID: 4621
		[Token(Token = "0x400120D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private RelationshipManager.FFIEvents RelationshipEvents;

		// Token: 0x0400120E RID: 4622
		[Token(Token = "0x400120E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		internal RelationshipManager RelationshipManagerInstance;

		// Token: 0x0400120F RID: 4623
		[Token(Token = "0x400120F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private IntPtr LobbyEventsPtr;

		// Token: 0x04001210 RID: 4624
		[Token(Token = "0x4001210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private LobbyManager.FFIEvents LobbyEvents;

		// Token: 0x04001211 RID: 4625
		[Token(Token = "0x4001211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		internal LobbyManager LobbyManagerInstance;

		// Token: 0x04001212 RID: 4626
		[Token(Token = "0x4001212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private IntPtr NetworkEventsPtr;

		// Token: 0x04001213 RID: 4627
		[Token(Token = "0x4001213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private NetworkManager.FFIEvents NetworkEvents;

		// Token: 0x04001214 RID: 4628
		[Token(Token = "0x4001214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		internal NetworkManager NetworkManagerInstance;

		// Token: 0x04001215 RID: 4629
		[Token(Token = "0x4001215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private IntPtr OverlayEventsPtr;

		// Token: 0x04001216 RID: 4630
		[Token(Token = "0x4001216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private OverlayManager.FFIEvents OverlayEvents;

		// Token: 0x04001217 RID: 4631
		[Token(Token = "0x4001217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		internal OverlayManager OverlayManagerInstance;

		// Token: 0x04001218 RID: 4632
		[Token(Token = "0x4001218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private IntPtr StorageEventsPtr;

		// Token: 0x04001219 RID: 4633
		[Token(Token = "0x4001219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private StorageManager.FFIEvents StorageEvents;

		// Token: 0x0400121A RID: 4634
		[Token(Token = "0x400121A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		internal StorageManager StorageManagerInstance;

		// Token: 0x0400121B RID: 4635
		[Token(Token = "0x400121B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private IntPtr StoreEventsPtr;

		// Token: 0x0400121C RID: 4636
		[Token(Token = "0x400121C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private StoreManager.FFIEvents StoreEvents;

		// Token: 0x0400121D RID: 4637
		[Token(Token = "0x400121D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		internal StoreManager StoreManagerInstance;

		// Token: 0x0400121E RID: 4638
		[Token(Token = "0x400121E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private IntPtr VoiceEventsPtr;

		// Token: 0x0400121F RID: 4639
		[Token(Token = "0x400121F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private VoiceManager.FFIEvents VoiceEvents;

		// Token: 0x04001220 RID: 4640
		[Token(Token = "0x4001220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		internal VoiceManager VoiceManagerInstance;

		// Token: 0x04001221 RID: 4641
		[Token(Token = "0x4001221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private IntPtr AchievementEventsPtr;

		// Token: 0x04001222 RID: 4642
		[Token(Token = "0x4001222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private AchievementManager.FFIEvents AchievementEvents;

		// Token: 0x04001223 RID: 4643
		[Token(Token = "0x4001223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		internal AchievementManager AchievementManagerInstance;

		// Token: 0x04001224 RID: 4644
		[Token(Token = "0x4001224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private IntPtr MethodsPtr;

		// Token: 0x04001225 RID: 4645
		[Token(Token = "0x4001225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private object MethodsStructure;

		// Token: 0x04001226 RID: 4646
		[Token(Token = "0x4001226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private GCHandle? setLogHook;

		// Token: 0x020003F6 RID: 1014
		[Token(Token = "0x20003F6")]
		internal struct FFIEvents
		{
		}

		// Token: 0x020003F7 RID: 1015
		[Token(Token = "0x20003F7")]
		internal struct FFIMethods
		{
			// Token: 0x04001227 RID: 4647
			[Token(Token = "0x4001227")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Discord.FFIMethods.DestroyHandler Destroy;

			// Token: 0x04001228 RID: 4648
			[Token(Token = "0x4001228")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal Discord.FFIMethods.RunCallbacksMethod RunCallbacks;

			// Token: 0x04001229 RID: 4649
			[Token(Token = "0x4001229")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal Discord.FFIMethods.SetLogHookMethod SetLogHook;

			// Token: 0x0400122A RID: 4650
			[Token(Token = "0x400122A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal Discord.FFIMethods.GetApplicationManagerMethod GetApplicationManager;

			// Token: 0x0400122B RID: 4651
			[Token(Token = "0x400122B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal Discord.FFIMethods.GetUserManagerMethod GetUserManager;

			// Token: 0x0400122C RID: 4652
			[Token(Token = "0x400122C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal Discord.FFIMethods.GetImageManagerMethod GetImageManager;

			// Token: 0x0400122D RID: 4653
			[Token(Token = "0x400122D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal Discord.FFIMethods.GetActivityManagerMethod GetActivityManager;

			// Token: 0x0400122E RID: 4654
			[Token(Token = "0x400122E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal Discord.FFIMethods.GetRelationshipManagerMethod GetRelationshipManager;

			// Token: 0x0400122F RID: 4655
			[Token(Token = "0x400122F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal Discord.FFIMethods.GetLobbyManagerMethod GetLobbyManager;

			// Token: 0x04001230 RID: 4656
			[Token(Token = "0x4001230")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal Discord.FFIMethods.GetNetworkManagerMethod GetNetworkManager;

			// Token: 0x04001231 RID: 4657
			[Token(Token = "0x4001231")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			internal Discord.FFIMethods.GetOverlayManagerMethod GetOverlayManager;

			// Token: 0x04001232 RID: 4658
			[Token(Token = "0x4001232")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			internal Discord.FFIMethods.GetStorageManagerMethod GetStorageManager;

			// Token: 0x04001233 RID: 4659
			[Token(Token = "0x4001233")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			internal Discord.FFIMethods.GetStoreManagerMethod GetStoreManager;

			// Token: 0x04001234 RID: 4660
			[Token(Token = "0x4001234")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			internal Discord.FFIMethods.GetVoiceManagerMethod GetVoiceManager;

			// Token: 0x04001235 RID: 4661
			[Token(Token = "0x4001235")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			internal Discord.FFIMethods.GetAchievementManagerMethod GetAchievementManager;

			// Token: 0x020003F8 RID: 1016
			// (Invoke) Token: 0x06001664 RID: 5732
			[Token(Token = "0x20003F8")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void DestroyHandler(IntPtr MethodsPtr);

			// Token: 0x020003F9 RID: 1017
			// (Invoke) Token: 0x06001666 RID: 5734
			[Token(Token = "0x20003F9")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result RunCallbacksMethod(IntPtr methodsPtr);

			// Token: 0x020003FA RID: 1018
			// (Invoke) Token: 0x06001668 RID: 5736
			[Token(Token = "0x20003FA")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void SetLogHookCallback(IntPtr ptr, LogLevel level, string message);

			// Token: 0x020003FB RID: 1019
			// (Invoke) Token: 0x0600166A RID: 5738
			[Token(Token = "0x20003FB")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void SetLogHookMethod(IntPtr methodsPtr, LogLevel minLevel, IntPtr callbackData, Discord.FFIMethods.SetLogHookCallback callback);

			// Token: 0x020003FC RID: 1020
			// (Invoke) Token: 0x0600166C RID: 5740
			[Token(Token = "0x20003FC")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate IntPtr GetApplicationManagerMethod(IntPtr discordPtr);

			// Token: 0x020003FD RID: 1021
			// (Invoke) Token: 0x0600166E RID: 5742
			[Token(Token = "0x20003FD")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate IntPtr GetUserManagerMethod(IntPtr discordPtr);

			// Token: 0x020003FE RID: 1022
			// (Invoke) Token: 0x06001670 RID: 5744
			[Token(Token = "0x20003FE")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate IntPtr GetImageManagerMethod(IntPtr discordPtr);

			// Token: 0x020003FF RID: 1023
			// (Invoke) Token: 0x06001672 RID: 5746
			[Token(Token = "0x20003FF")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate IntPtr GetActivityManagerMethod(IntPtr discordPtr);

			// Token: 0x02000400 RID: 1024
			// (Invoke) Token: 0x06001674 RID: 5748
			[Token(Token = "0x2000400")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate IntPtr GetRelationshipManagerMethod(IntPtr discordPtr);

			// Token: 0x02000401 RID: 1025
			// (Invoke) Token: 0x06001676 RID: 5750
			[Token(Token = "0x2000401")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate IntPtr GetLobbyManagerMethod(IntPtr discordPtr);

			// Token: 0x02000402 RID: 1026
			// (Invoke) Token: 0x06001678 RID: 5752
			[Token(Token = "0x2000402")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate IntPtr GetNetworkManagerMethod(IntPtr discordPtr);

			// Token: 0x02000403 RID: 1027
			// (Invoke) Token: 0x0600167A RID: 5754
			[Token(Token = "0x2000403")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate IntPtr GetOverlayManagerMethod(IntPtr discordPtr);

			// Token: 0x02000404 RID: 1028
			// (Invoke) Token: 0x0600167C RID: 5756
			[Token(Token = "0x2000404")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate IntPtr GetStorageManagerMethod(IntPtr discordPtr);

			// Token: 0x02000405 RID: 1029
			// (Invoke) Token: 0x0600167E RID: 5758
			[Token(Token = "0x2000405")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate IntPtr GetStoreManagerMethod(IntPtr discordPtr);

			// Token: 0x02000406 RID: 1030
			// (Invoke) Token: 0x06001680 RID: 5760
			[Token(Token = "0x2000406")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate IntPtr GetVoiceManagerMethod(IntPtr discordPtr);

			// Token: 0x02000407 RID: 1031
			// (Invoke) Token: 0x06001682 RID: 5762
			[Token(Token = "0x2000407")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate IntPtr GetAchievementManagerMethod(IntPtr discordPtr);
		}

		// Token: 0x02000408 RID: 1032
		[Token(Token = "0x2000408")]
		internal struct FFICreateParams
		{
			// Token: 0x04001236 RID: 4662
			[Token(Token = "0x4001236")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal long ClientId;

			// Token: 0x04001237 RID: 4663
			[Token(Token = "0x4001237")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal ulong Flags;

			// Token: 0x04001238 RID: 4664
			[Token(Token = "0x4001238")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal IntPtr Events;

			// Token: 0x04001239 RID: 4665
			[Token(Token = "0x4001239")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal IntPtr EventData;

			// Token: 0x0400123A RID: 4666
			[Token(Token = "0x400123A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal IntPtr ApplicationEvents;

			// Token: 0x0400123B RID: 4667
			[Token(Token = "0x400123B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal uint ApplicationVersion;

			// Token: 0x0400123C RID: 4668
			[Token(Token = "0x400123C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal IntPtr UserEvents;

			// Token: 0x0400123D RID: 4669
			[Token(Token = "0x400123D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal uint UserVersion;

			// Token: 0x0400123E RID: 4670
			[Token(Token = "0x400123E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal IntPtr ImageEvents;

			// Token: 0x0400123F RID: 4671
			[Token(Token = "0x400123F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal uint ImageVersion;

			// Token: 0x04001240 RID: 4672
			[Token(Token = "0x4001240")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			internal IntPtr ActivityEvents;

			// Token: 0x04001241 RID: 4673
			[Token(Token = "0x4001241")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			internal uint ActivityVersion;

			// Token: 0x04001242 RID: 4674
			[Token(Token = "0x4001242")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			internal IntPtr RelationshipEvents;

			// Token: 0x04001243 RID: 4675
			[Token(Token = "0x4001243")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			internal uint RelationshipVersion;

			// Token: 0x04001244 RID: 4676
			[Token(Token = "0x4001244")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			internal IntPtr LobbyEvents;

			// Token: 0x04001245 RID: 4677
			[Token(Token = "0x4001245")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			internal uint LobbyVersion;

			// Token: 0x04001246 RID: 4678
			[Token(Token = "0x4001246")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			internal IntPtr NetworkEvents;

			// Token: 0x04001247 RID: 4679
			[Token(Token = "0x4001247")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			internal uint NetworkVersion;

			// Token: 0x04001248 RID: 4680
			[Token(Token = "0x4001248")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			internal IntPtr OverlayEvents;

			// Token: 0x04001249 RID: 4681
			[Token(Token = "0x4001249")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			internal uint OverlayVersion;

			// Token: 0x0400124A RID: 4682
			[Token(Token = "0x400124A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			internal IntPtr StorageEvents;

			// Token: 0x0400124B RID: 4683
			[Token(Token = "0x400124B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			internal uint StorageVersion;

			// Token: 0x0400124C RID: 4684
			[Token(Token = "0x400124C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			internal IntPtr StoreEvents;

			// Token: 0x0400124D RID: 4685
			[Token(Token = "0x400124D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			internal uint StoreVersion;

			// Token: 0x0400124E RID: 4686
			[Token(Token = "0x400124E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			internal IntPtr VoiceEvents;

			// Token: 0x0400124F RID: 4687
			[Token(Token = "0x400124F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			internal uint VoiceVersion;

			// Token: 0x04001250 RID: 4688
			[Token(Token = "0x4001250")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			internal IntPtr AchievementEvents;

			// Token: 0x04001251 RID: 4689
			[Token(Token = "0x4001251")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			internal uint AchievementVersion;
		}
	}
}
