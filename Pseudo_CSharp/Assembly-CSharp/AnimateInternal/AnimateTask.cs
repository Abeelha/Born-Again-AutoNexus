using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace AnimateInternal
{
	// Token: 0x02000447 RID: 1095
	[Token(Token = "0x2000447")]
	public abstract class AnimateTask
	{
		// Token: 0x1700023A RID: 570
		// (get) Token: 0x060016D6 RID: 5846 RVA: 0x00007A40 File Offset: 0x00005C40
		// (set) Token: 0x060016D7 RID: 5847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700023A")]
		public bool Canceled
		{
			[Token(Token = "0x60016D6")]
			[Address(RVA = "0x3AF600", Offset = "0x3AE800", VA = "0x1803AF600")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60016D7")]
			[Address(RVA = "0x3AF620", Offset = "0x3AE820", VA = "0x1803AF620")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x060016D8 RID: 5848 RVA: 0x00007A58 File Offset: 0x00005C58
		// (set) Token: 0x060016D9 RID: 5849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700023B")]
		public bool Finished
		{
			[Token(Token = "0x60016D8")]
			[Address(RVA = "0x3AF610", Offset = "0x3AE810", VA = "0x1803AF610")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60016D9")]
			[Address(RVA = "0x3AF630", Offset = "0x3AE830", VA = "0x1803AF630")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060016DA RID: 5850 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60016DA")]
		[Address(RVA = "0x3AF3C0", Offset = "0x3AE5C0", VA = "0x1803AF3C0")]
		public AnimateTask CancelWith(CancellationToken token)
		{
			return null;
		}

		// Token: 0x060016DB RID: 5851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016DB")]
		[Address(RVA = "0x3AF470", Offset = "0x3AE670", VA = "0x1803AF470")]
		public void Cancel()
		{
		}

		// Token: 0x060016DC RID: 5852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016DC")]
		[Address(RVA = "0x3AF370", Offset = "0x3AE570", VA = "0x1803AF370")]
		public void CancelImmediate()
		{
		}

		// Token: 0x060016DD RID: 5853 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60016DD")]
		[Address(RVA = "0x3AF480", Offset = "0x3AE680", VA = "0x1803AF480")]
		public AnimateTask Play()
		{
			return null;
		}

		// Token: 0x060016DE RID: 5854 RVA: 0x00007A70 File Offset: 0x00005C70
		[Token(Token = "0x60016DE")]
		[Address(RVA = "0x3AF4D0", Offset = "0x3AE6D0", VA = "0x1803AF4D0")]
		public bool Update()
		{
			return default(bool);
		}

		// Token: 0x060016DF RID: 5855 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60016DF")]
		[Address(RVA = "0x3AF560", Offset = "0x3AE760", VA = "0x1803AF560")]
		public Task<bool> WaitAsync()
		{
			return null;
		}

		// Token: 0x060016E0 RID: 5856
		[Token(Token = "0x60016E0")]
		protected abstract bool DoUpdate();

		// Token: 0x060016E1 RID: 5857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016E1")]
		[Address(RVA = "0x3AF4A0", Offset = "0x3AE6A0", VA = "0x1803AF4A0")]
		protected void SetupTask()
		{
		}

		// Token: 0x060016E2 RID: 5858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016E2")]
		[Address(RVA = "0x316100", Offset = "0x315300", VA = "0x180316100")]
		protected AnimateTask()
		{
		}

		// Token: 0x04001290 RID: 4752
		[Token(Token = "0x4001290")]
		[FieldOffset(Offset = "0x10")]
		private TaskCompletionSource<bool> _completedSource;
	}
}
