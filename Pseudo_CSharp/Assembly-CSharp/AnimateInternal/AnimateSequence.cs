using System;
using Il2CppDummyDll;

namespace AnimateInternal
{
	// Token: 0x02000446 RID: 1094
	[Token(Token = "0x2000446")]
	public class AnimateSequence : AnimateTaskCollection
	{
		// Token: 0x060016D4 RID: 5844 RVA: 0x00007A28 File Offset: 0x00005C28
		[Token(Token = "0x60016D4")]
		[Address(RVA = "0x3AF0D0", Offset = "0x3AE2D0", VA = "0x1803AF0D0", Slot = "4")]
		protected override bool DoUpdate()
		{
			return default(bool);
		}

		// Token: 0x060016D5 RID: 5845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016D5")]
		[Address(RVA = "0x3AF180", Offset = "0x3AE380", VA = "0x1803AF180")]
		public AnimateSequence()
		{
		}

		// Token: 0x0400128F RID: 4751
		[Token(Token = "0x400128F")]
		[FieldOffset(Offset = "0x28")]
		private int _currentTaskIndex;
	}
}
