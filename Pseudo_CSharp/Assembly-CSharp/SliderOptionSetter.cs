using System;
using Il2CppDummyDll;

// Token: 0x020001CB RID: 459
[Token(Token = "0x20001CB")]
public class SliderOptionSetter : OptionSetter
{
	// Token: 0x06000945 RID: 2373 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000945")]
	[Address(RVA = "0x42FDA0", Offset = "0x42EFA0", VA = "0x18042FDA0")]
	public void OnSliderChanged(long value)
	{
	}

	// Token: 0x06000946 RID: 2374 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000946")]
	[Address(RVA = "0x42FD60", Offset = "0x42EF60", VA = "0x18042FD60", Slot = "4")]
	protected override void OnOptionChanged()
	{
	}

	// Token: 0x06000947 RID: 2375 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000947")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public SliderOptionSetter()
	{
	}

	// Token: 0x040008CC RID: 2252
	[Token(Token = "0x40008CC")]
	[FieldOffset(Offset = "0x40")]
	public SliderInput SliderInput;
}
