using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace kha2dev.DatePicker
{
	// Token: 0x0200035F RID: 863
	[Token(Token = "0x200035F")]
	public class ParameterDatePicker
	{
		// Token: 0x0600138D RID: 5005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600138D")]
		[Address(RVA = "0x3A3420", Offset = "0x3A2620", VA = "0x1803A3420")]
		public ParameterDatePicker()
		{
		}

		// Token: 0x04000FE7 RID: 4071
		[Token(Token = "0x4000FE7")]
		[FieldOffset(Offset = "0x10")]
		public DateTime defaultDate;

		// Token: 0x04000FE8 RID: 4072
		[Token(Token = "0x4000FE8")]
		[FieldOffset(Offset = "0x18")]
		public DateTime startDateFrom;

		// Token: 0x04000FE9 RID: 4073
		[Token(Token = "0x4000FE9")]
		[FieldOffset(Offset = "0x20")]
		public DateTime finishDateUntil;

		// Token: 0x04000FEA RID: 4074
		[Token(Token = "0x4000FEA")]
		[FieldOffset(Offset = "0x28")]
		public List<DateTime> listDisableDate;

		// Token: 0x04000FEB RID: 4075
		[Token(Token = "0x4000FEB")]
		[FieldOffset(Offset = "0x30")]
		public bool disableSunday;

		// Token: 0x04000FEC RID: 4076
		[Token(Token = "0x4000FEC")]
		[FieldOffset(Offset = "0x31")]
		public bool disableMonday;

		// Token: 0x04000FED RID: 4077
		[Token(Token = "0x4000FED")]
		[FieldOffset(Offset = "0x32")]
		public bool disableTuesday;

		// Token: 0x04000FEE RID: 4078
		[Token(Token = "0x4000FEE")]
		[FieldOffset(Offset = "0x33")]
		public bool disableWednesday;

		// Token: 0x04000FEF RID: 4079
		[Token(Token = "0x4000FEF")]
		[FieldOffset(Offset = "0x34")]
		public bool disableThursday;

		// Token: 0x04000FF0 RID: 4080
		[Token(Token = "0x4000FF0")]
		[FieldOffset(Offset = "0x35")]
		public bool disableFriday;

		// Token: 0x04000FF1 RID: 4081
		[Token(Token = "0x4000FF1")]
		[FieldOffset(Offset = "0x36")]
		public bool disableSaturday;

		// Token: 0x04000FF2 RID: 4082
		[Token(Token = "0x4000FF2")]
		[FieldOffset(Offset = "0x37")]
		public bool startOnMonth;

		// Token: 0x04000FF3 RID: 4083
		[Token(Token = "0x4000FF3")]
		[FieldOffset(Offset = "0x38")]
		public bool startOnYear;

		// Token: 0x04000FF4 RID: 4084
		[Token(Token = "0x4000FF4")]
		[FieldOffset(Offset = "0x39")]
		public bool selectMonthOnly;
	}
}
