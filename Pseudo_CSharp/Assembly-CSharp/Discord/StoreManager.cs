using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Discord
{
	// Token: 0x02000436 RID: 1078
	[Token(Token = "0x2000436")]
	public class StoreManager
	{
		// Token: 0x0400127E RID: 4734
		[Token(Token = "0x400127E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr MethodsPtr;

		// Token: 0x0400127F RID: 4735
		[Token(Token = "0x400127F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object MethodsStructure;

		// Token: 0x04001280 RID: 4736
		[Token(Token = "0x4001280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[CompilerGenerated]
		private StoreManager.EntitlementCreateHandler OnEntitlementCreate;

		// Token: 0x04001281 RID: 4737
		[Token(Token = "0x4001281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[CompilerGenerated]
		private StoreManager.EntitlementDeleteHandler OnEntitlementDelete;

		// Token: 0x02000437 RID: 1079
		[Token(Token = "0x2000437")]
		internal struct FFIEvents
		{
			// Token: 0x04001282 RID: 4738
			[Token(Token = "0x4001282")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal StoreManager.FFIEvents.EntitlementCreateHandler OnEntitlementCreate;

			// Token: 0x04001283 RID: 4739
			[Token(Token = "0x4001283")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal StoreManager.FFIEvents.EntitlementDeleteHandler OnEntitlementDelete;

			// Token: 0x02000438 RID: 1080
			// (Invoke) Token: 0x060016BD RID: 5821
			[Token(Token = "0x2000438")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void EntitlementCreateHandler(IntPtr ptr, ref Entitlement entitlement);

			// Token: 0x02000439 RID: 1081
			// (Invoke) Token: 0x060016BF RID: 5823
			[Token(Token = "0x2000439")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void EntitlementDeleteHandler(IntPtr ptr, ref Entitlement entitlement);
		}

		// Token: 0x0200043A RID: 1082
		// (Invoke) Token: 0x060016C1 RID: 5825
		[Token(Token = "0x200043A")]
		public delegate void EntitlementCreateHandler(ref Entitlement entitlement);

		// Token: 0x0200043B RID: 1083
		// (Invoke) Token: 0x060016C3 RID: 5827
		[Token(Token = "0x200043B")]
		public delegate void EntitlementDeleteHandler(ref Entitlement entitlement);
	}
}
