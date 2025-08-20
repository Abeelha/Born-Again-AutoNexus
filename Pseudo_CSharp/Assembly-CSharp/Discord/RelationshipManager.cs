using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Discord
{
	// Token: 0x02000412 RID: 1042
	[Token(Token = "0x2000412")]
	public class RelationshipManager
	{
		// Token: 0x0400125A RID: 4698
		[Token(Token = "0x400125A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr MethodsPtr;

		// Token: 0x0400125B RID: 4699
		[Token(Token = "0x400125B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object MethodsStructure;

		// Token: 0x0400125C RID: 4700
		[Token(Token = "0x400125C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[CompilerGenerated]
		private RelationshipManager.RefreshHandler OnRefresh;

		// Token: 0x0400125D RID: 4701
		[Token(Token = "0x400125D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[CompilerGenerated]
		private RelationshipManager.RelationshipUpdateHandler OnRelationshipUpdate;

		// Token: 0x02000413 RID: 1043
		[Token(Token = "0x2000413")]
		internal struct FFIEvents
		{
			// Token: 0x0400125E RID: 4702
			[Token(Token = "0x400125E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal RelationshipManager.FFIEvents.RefreshHandler OnRefresh;

			// Token: 0x0400125F RID: 4703
			[Token(Token = "0x400125F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal RelationshipManager.FFIEvents.RelationshipUpdateHandler OnRelationshipUpdate;

			// Token: 0x02000414 RID: 1044
			// (Invoke) Token: 0x06001689 RID: 5769
			[Token(Token = "0x2000414")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void RefreshHandler(IntPtr ptr);

			// Token: 0x02000415 RID: 1045
			// (Invoke) Token: 0x0600168B RID: 5771
			[Token(Token = "0x2000415")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void RelationshipUpdateHandler(IntPtr ptr, ref Relationship relationship);
		}

		// Token: 0x02000416 RID: 1046
		// (Invoke) Token: 0x0600168D RID: 5773
		[Token(Token = "0x2000416")]
		public delegate void RefreshHandler();

		// Token: 0x02000417 RID: 1047
		// (Invoke) Token: 0x0600168F RID: 5775
		[Token(Token = "0x2000417")]
		public delegate void RelationshipUpdateHandler(ref Relationship relationship);
	}
}
