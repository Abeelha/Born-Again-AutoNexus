using System;
using Il2CppDummyDll;

// Token: 0x020002FA RID: 762
[Token(Token = "0x20002FA")]
public class CharacterTooltipSource : TooltipSource
{
	// Token: 0x170001DB RID: 475
	// (get) Token: 0x060010FE RID: 4350 RVA: 0x00006768 File Offset: 0x00004968
	[Token(Token = "0x170001DB")]
	public override bool CanShow
	{
		[Token(Token = "0x60010FE")]
		[Address(RVA = "0x34E010", Offset = "0x34D210", VA = "0x18034E010", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060010FF RID: 4351 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010FF")]
	[Address(RVA = "0x34DFE0", Offset = "0x34D1E0", VA = "0x18034DFE0", Slot = "5")]
	public override void Build(TooltipBuilder builder)
	{
	}

	// Token: 0x06001100 RID: 4352 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001100")]
	[Address(RVA = "0x34E000", Offset = "0x34D200", VA = "0x18034E000")]
	public void SetCharacter(Character character)
	{
	}

	// Token: 0x06001101 RID: 4353 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001101")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public CharacterTooltipSource()
	{
	}

	// Token: 0x04000E14 RID: 3604
	[Token(Token = "0x4000E14")]
	[FieldOffset(Offset = "0x28")]
	private Character _character;
}
