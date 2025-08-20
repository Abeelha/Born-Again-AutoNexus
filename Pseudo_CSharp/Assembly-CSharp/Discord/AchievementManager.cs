using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Discord
{
	// Token: 0x02000440 RID: 1088
	[Token(Token = "0x2000440")]
	public class AchievementManager
	{
		// Token: 0x04001288 RID: 4744
		[Token(Token = "0x4001288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr MethodsPtr;

		// Token: 0x04001289 RID: 4745
		[Token(Token = "0x4001289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object MethodsStructure;

		// Token: 0x0400128A RID: 4746
		[Token(Token = "0x400128A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[CompilerGenerated]
		private AchievementManager.UserAchievementUpdateHandler OnUserAchievementUpdate;

		// Token: 0x02000441 RID: 1089
		[Token(Token = "0x2000441")]
		internal struct FFIEvents
		{
			// Token: 0x0400128B RID: 4747
			[Token(Token = "0x400128B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal AchievementManager.FFIEvents.UserAchievementUpdateHandler OnUserAchievementUpdate;

			// Token: 0x02000442 RID: 1090
			// (Invoke) Token: 0x060016C9 RID: 5833
			[Token(Token = "0x2000442")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void UserAchievementUpdateHandler(IntPtr ptr, ref UserAchievement userAchievement);
		}

		// Token: 0x02000443 RID: 1091
		// (Invoke) Token: 0x060016CB RID: 5835
		[Token(Token = "0x2000443")]
		public delegate void UserAchievementUpdateHandler(ref UserAchievement userAchievement);
	}
}
