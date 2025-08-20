using System;
using Il2CppDummyDll;

// Token: 0x020001CA RID: 458
[Token(Token = "0x20001CA")]
public class SliderFloatOptionSetter : OptionSetter
{
	// Token: 0x06000942 RID: 2370 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000942")]
	[Address(RVA = "0x42FD40", Offset = "0x42EF40", VA = "0x18042FD40")]
	public void OnSliderChanged(float value)
	{
	}

	// Token: 0x06000943 RID: 2371 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000943")]
	[Address(RVA = "0x42FD00", Offset = "0x42EF00", VA = "0x18042FD00", Slot = "4")]
	protected override void OnOptionChanged()
	{
	}

	// Token: 0x06000944 RID: 2372 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000944")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public SliderFloatOptionSetter()
	{
	}

	// Token: 0x040008CB RID: 2251
	[Token(Token = "0x40008CB")]
	[FieldOffset(Offset = "0x40")]
	public SliderFloatInput SliderInput;
}
