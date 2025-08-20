using System;
using Il2CppDummyDll;
using UnityEngine.UI;

// Token: 0x020002C2 RID: 706
[Token(Token = "0x20002C2")]
public class OptionsMenu : Menu
{
	// Token: 0x06000F16 RID: 3862 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F16")]
	[Address(RVA = "0x472290", Offset = "0x471490", VA = "0x180472290", Slot = "6")]
	protected override void OnExit()
	{
	}

	// Token: 0x06000F17 RID: 3863 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F17")]
	[Address(RVA = "0x316090", Offset = "0x315290", VA = "0x180316090")]
	public void MainMenuCancel()
	{
	}

	// Token: 0x06000F18 RID: 3864 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F18")]
	[Address(RVA = "0x472260", Offset = "0x471460", VA = "0x180472260")]
	public void MainMenuStart()
	{
	}

	// Token: 0x06000F19 RID: 3865 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F19")]
	[Address(RVA = "0x4722D0", Offset = "0x4714D0", VA = "0x1804722D0")]
	public void SetDefaultMouse()
	{
	}

	// Token: 0x06000F1A RID: 3866 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F1A")]
	[Address(RVA = "0x4724E0", Offset = "0x4716E0", VA = "0x1804724E0")]
	public void SetDefaultWasd()
	{
	}

	// Token: 0x06000F1B RID: 3867 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F1B")]
	[Address(RVA = "0x4726F0", Offset = "0x4718F0", VA = "0x1804726F0", Slot = "4")]
	public override void Show()
	{
	}

	// Token: 0x06000F1C RID: 3868 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F1C")]
	[Address(RVA = "0x472180", Offset = "0x471380", VA = "0x180472180")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000F1D RID: 3869 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F1D")]
	[Address(RVA = "0x472780", Offset = "0x471980", VA = "0x180472780")]
	public OptionsMenu()
	{
	}

	// Token: 0x04000C7E RID: 3198
	[Token(Token = "0x4000C7E")]
	[FieldOffset(Offset = "0x90")]
	public Menu DefaultMenu;

	// Token: 0x04000C7F RID: 3199
	[Token(Token = "0x4000C7F")]
	[FieldOffset(Offset = "0x98")]
	public Slider DisconnectSlider;

	// Token: 0x04000C80 RID: 3200
	[Token(Token = "0x4000C80")]
	[FieldOffset(Offset = "0xA0")]
	public World World;

	// Token: 0x04000C81 RID: 3201
	[Token(Token = "0x4000C81")]
	[FieldOffset(Offset = "0xA8")]
	private bool _firstShow;
}
