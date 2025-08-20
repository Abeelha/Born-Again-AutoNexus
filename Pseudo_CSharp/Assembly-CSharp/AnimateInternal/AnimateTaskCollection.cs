using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace AnimateInternal
{
	// Token: 0x02000448 RID: 1096
	[Token(Token = "0x2000448")]
	public abstract class AnimateTaskCollection : AnimateTask
	{
		// Token: 0x1700023C RID: 572
		// (get) Token: 0x060016E3 RID: 5859 RVA: 0x00007A88 File Offset: 0x00005C88
		[Token(Token = "0x1700023C")]
		public int TaskCount
		{
			[Token(Token = "0x60016E3")]
			[Address(RVA = "0x3AF330", Offset = "0x3AE530", VA = "0x1803AF330")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060016E4 RID: 5860 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60016E4")]
		[Address(RVA = "0x3AF190", Offset = "0x3AE390", VA = "0x1803AF190", Slot = "5")]
		public virtual AnimateTaskCollection Add(AnimateTask task)
		{
			return null;
		}

		// Token: 0x060016E5 RID: 5861 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60016E5")]
		[Address(RVA = "0x3AF250", Offset = "0x3AE450", VA = "0x1803AF250")]
		protected AnimateTask GetTask(int index)
		{
			return null;
		}

		// Token: 0x060016E6 RID: 5862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016E6")]
		[Address(RVA = "0x3AF2B0", Offset = "0x3AE4B0", VA = "0x1803AF2B0")]
		protected AnimateTaskCollection()
		{
		}

		// Token: 0x04001293 RID: 4755
		[Token(Token = "0x4001293")]
		[FieldOffset(Offset = "0x20")]
		private readonly List<AnimateTask> _tasks;
	}
}
