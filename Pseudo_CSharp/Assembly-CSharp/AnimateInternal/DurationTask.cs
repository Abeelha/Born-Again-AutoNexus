using System;
using Il2CppDummyDll;

namespace AnimateInternal
{
	// Token: 0x02000449 RID: 1097
	[Token(Token = "0x2000449")]
	public class DurationTask : AnimateTask
	{
		// Token: 0x060016E7 RID: 5863 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60016E7")]
		[Address(RVA = "0x3B1F70", Offset = "0x3B1170", VA = "0x1803B1F70")]
		public DurationTask Duration(float duration)
		{
			return null;
		}

		// Token: 0x060016E8 RID: 5864 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60016E8")]
		[Address(RVA = "0x3B1F80", Offset = "0x3B1180", VA = "0x1803B1F80")]
		public DurationTask Ease(EasingType easingType)
		{
			return null;
		}

		// Token: 0x060016E9 RID: 5865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016E9")]
		[Address(RVA = "0x3B1F90", Offset = "0x3B1190", VA = "0x1803B1F90")]
		public void Setup(float duration, Action<float> stepAction)
		{
		}

		// Token: 0x060016EA RID: 5866 RVA: 0x00007AA0 File Offset: 0x00005CA0
		[Token(Token = "0x60016EA")]
		[Address(RVA = "0x3B1EE0", Offset = "0x3B10E0", VA = "0x1803B1EE0", Slot = "4")]
		protected override bool DoUpdate()
		{
			return default(bool);
		}

		// Token: 0x060016EB RID: 5867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016EB")]
		[Address(RVA = "0x316100", Offset = "0x315300", VA = "0x180316100")]
		public DurationTask()
		{
		}

		// Token: 0x04001294 RID: 4756
		[Token(Token = "0x4001294")]
		[FieldOffset(Offset = "0x20")]
		private float _duration;

		// Token: 0x04001295 RID: 4757
		[Token(Token = "0x4001295")]
		[FieldOffset(Offset = "0x28")]
		private Action<float> _stepAction;

		// Token: 0x04001296 RID: 4758
		[Token(Token = "0x4001296")]
		[FieldOffset(Offset = "0x30")]
		private float _time;

		// Token: 0x04001297 RID: 4759
		[Token(Token = "0x4001297")]
		[FieldOffset(Offset = "0x34")]
		private EasingType _easingType;
	}
}
