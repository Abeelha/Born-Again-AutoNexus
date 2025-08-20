using System;
using Il2CppDummyDll;

// Token: 0x020002B8 RID: 696
[Token(Token = "0x20002B8")]
public class AmountMenu : Menu
{
	// Token: 0x06000EEE RID: 3822 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EEE")]
	[Address(RVA = "0x3BD8B0", Offset = "0x3BCAB0", VA = "0x1803BD8B0")]
	public void Cancel()
	{
	}

	// Token: 0x06000EEF RID: 3823 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EEF")]
	[Address(RVA = "0x463780", Offset = "0x462980", VA = "0x180463780")]
	public void Ok()
	{
	}

	// Token: 0x06000EF0 RID: 3824 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EF0")]
	[Address(RVA = "0x4637D0", Offset = "0x4629D0", VA = "0x1804637D0")]
	public void Show(Slot slot)
	{
	}

	// Token: 0x06000EF1 RID: 3825 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EF1")]
	[Address(RVA = "0x463720", Offset = "0x462920", VA = "0x180463720")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000EF2 RID: 3826 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EF2")]
	[Address(RVA = "0x4638A0", Offset = "0x462AA0", VA = "0x1804638A0")]
	private void UpdateValues()
	{
	}

	// Token: 0x06000EF3 RID: 3827 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EF3")]
	[Address(RVA = "0x3BC980", Offset = "0x3BBB80", VA = "0x1803BC980")]
	public AmountMenu()
	{
	}

	// Token: 0x04000C4F RID: 3151
	[Token(Token = "0x4000C4F")]
	[FieldOffset(Offset = "0x90")]
	public SliderInput SliderInput;

	// Token: 0x04000C50 RID: 3152
	[Token(Token = "0x4000C50")]
	[FieldOffset(Offset = "0x98")]
	public TradeMenu TradeMenu;

	// Token: 0x04000C51 RID: 3153
	[Token(Token = "0x4000C51")]
	[FieldOffset(Offset = "0xA0")]
	public Slot TargetSlot;

	// Token: 0x04000C52 RID: 3154
	[Token(Token = "0x4000C52")]
	[FieldOffset(Offset = "0xA8")]
	private Slot _slot;

	// Token: 0x04000C53 RID: 3155
	[Token(Token = "0x4000C53")]
	[FieldOffset(Offset = "0xB0")]
	private ushort _itemType;
}
