using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace AnimateInternal
{
	// Token: 0x02000444 RID: 1092
	[Token(Token = "0x2000444")]
	public class AnimateGroup : AnimateTaskCollection
	{
		// Token: 0x060016CC RID: 5836 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60016CC")]
		[Address(RVA = "0x3AE8A0", Offset = "0x3ADAA0", VA = "0x1803AE8A0", Slot = "5")]
		public override AnimateTaskCollection Add(AnimateTask task)
		{
			return null;
		}

		// Token: 0x060016CD RID: 5837 RVA: 0x00007A10 File Offset: 0x00005C10
		[Token(Token = "0x60016CD")]
		[Address(RVA = "0x3AE9D0", Offset = "0x3ADBD0", VA = "0x1803AE9D0", Slot = "4")]
		protected override bool DoUpdate()
		{
			return default(bool);
		}

		// Token: 0x060016CE RID: 5838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016CE")]
		[Address(RVA = "0x3AEAC0", Offset = "0x3ADCC0", VA = "0x1803AEAC0")]
		public AnimateGroup()
		{
		}

		// Token: 0x0400128C RID: 4748
		[Token(Token = "0x400128C")]
		[FieldOffset(Offset = "0x28")]
		private readonly List<bool> _done;
	}
}
