using System;
using System.Threading.Tasks;
using Il2CppDummyDll;
using Ronin.Api.Model.CharacterSlot;
using Ronin.Api.Model.Region;

// Token: 0x0200005D RID: 93
[Token(Token = "0x200005D")]
public static class ApiModelExtensions
{
	// Token: 0x06000181 RID: 385 RVA: 0x00002670 File Offset: 0x00000870
	[Token(Token = "0x6000181")]
	[Address(RVA = "0x3315D0", Offset = "0x3307D0", VA = "0x1803315D0")]
	public static bool CanContinueThread(this GetCharacterSlotResponse characterSlot)
	{
		return default(bool);
	}

	// Token: 0x06000182 RID: 386 RVA: 0x00002688 File Offset: 0x00000888
	[Token(Token = "0x6000182")]
	[Address(RVA = "0x3317B0", Offset = "0x3309B0", VA = "0x1803317B0")]
	public static bool NextCharacterStartsThread(this GetCharacterSlotResponse characterSlot)
	{
		return default(bool);
	}

	// Token: 0x06000183 RID: 387 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000183")]
	[Address(RVA = "0x3316B0", Offset = "0x3308B0", VA = "0x1803316B0")]
	public static Task<int> GetPingAsync(this GetRegionResponse region)
	{
		return null;
	}
}
