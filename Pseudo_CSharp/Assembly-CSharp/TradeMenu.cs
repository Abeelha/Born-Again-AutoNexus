using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Ronin.Model.Data;
using Ronin.Model.Enums;
using Ronin.Model.Structs;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020002C4 RID: 708
[Token(Token = "0x20002C4")]
public class TradeMenu : Menu
{
	// Token: 0x170001AE RID: 430
	// (get) Token: 0x06000F26 RID: 3878 RVA: 0x00006048 File Offset: 0x00004248
	[Token(Token = "0x170001AE")]
	public bool InTrade
	{
		[Token(Token = "0x6000F26")]
		[Address(RVA = "0x351160", Offset = "0x350360", VA = "0x180351160")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170001AF RID: 431
	// (get) Token: 0x06000F27 RID: 3879 RVA: 0x00006060 File Offset: 0x00004260
	// (set) Token: 0x06000F28 RID: 3880 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001AF")]
	public uint TradeEntityId
	{
		[Token(Token = "0x6000F27")]
		[Address(RVA = "0x475220", Offset = "0x474420", VA = "0x180475220")]
		[CompilerGenerated]
		get
		{
			return 0U;
		}
		[Token(Token = "0x6000F28")]
		[Address(RVA = "0x475230", Offset = "0x474430", VA = "0x180475230")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x170001B0 RID: 432
	// (get) Token: 0x06000F29 RID: 3881 RVA: 0x00006078 File Offset: 0x00004278
	[Token(Token = "0x170001B0")]
	private bool Accepted
	{
		[Token(Token = "0x6000F29")]
		[Address(RVA = "0x475160", Offset = "0x474360", VA = "0x180475160")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170001B1 RID: 433
	// (get) Token: 0x06000F2A RID: 3882 RVA: 0x00006090 File Offset: 0x00004290
	[Token(Token = "0x170001B1")]
	private bool CanAccept
	{
		[Token(Token = "0x6000F2A")]
		[Address(RVA = "0x475180", Offset = "0x474380", VA = "0x180475180")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170001B2 RID: 434
	// (get) Token: 0x06000F2B RID: 3883 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x170001B2")]
	private List<ValueTuple<ItemValue, float>> Changed
	{
		[Token(Token = "0x6000F2B")]
		[Address(RVA = "0x4751A0", Offset = "0x4743A0", VA = "0x1804751A0")]
		get
		{
			return null;
		}
	}

	// Token: 0x170001B3 RID: 435
	// (get) Token: 0x06000F2C RID: 3884 RVA: 0x000060A8 File Offset: 0x000042A8
	[Token(Token = "0x170001B3")]
	private bool OtherAccepted
	{
		[Token(Token = "0x6000F2C")]
		[Address(RVA = "0x4751C0", Offset = "0x4743C0", VA = "0x1804751C0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170001B4 RID: 436
	// (get) Token: 0x06000F2D RID: 3885 RVA: 0x000060C0 File Offset: 0x000042C0
	[Token(Token = "0x170001B4")]
	private bool OtherCanAccept
	{
		[Token(Token = "0x6000F2D")]
		[Address(RVA = "0x4751E0", Offset = "0x4743E0", VA = "0x1804751E0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170001B5 RID: 437
	// (get) Token: 0x06000F2E RID: 3886 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x170001B5")]
	private List<ValueTuple<ItemValue, float>> OtherChanged
	{
		[Token(Token = "0x6000F2E")]
		[Address(RVA = "0x475200", Offset = "0x474400", VA = "0x180475200")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000F2F RID: 3887 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F2F")]
	[Address(RVA = "0x472E90", Offset = "0x472090", VA = "0x180472E90")]
	public void Accept()
	{
	}

	// Token: 0x06000F30 RID: 3888 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F30")]
	[Address(RVA = "0x472EA0", Offset = "0x4720A0", VA = "0x180472EA0")]
	public void Cancel()
	{
	}

	// Token: 0x06000F31 RID: 3889 RVA: 0x000060D8 File Offset: 0x000042D8
	[Token(Token = "0x6000F31")]
	[Address(RVA = "0x473330", Offset = "0x472530", VA = "0x180473330")]
	public bool Deselect(Slot slot)
	{
		return default(bool);
	}

	// Token: 0x06000F32 RID: 3890 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F32")]
	[Address(RVA = "0x473460", Offset = "0x472660", VA = "0x180473460")]
	public void EndTrade()
	{
	}

	// Token: 0x06000F33 RID: 3891 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F33")]
	[Address(RVA = "0x473A60", Offset = "0x472C60", VA = "0x180473A60")]
	public void Select(Slot slot, long amount)
	{
	}

	// Token: 0x06000F34 RID: 3892 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F34")]
	[Address(RVA = "0x473D80", Offset = "0x472F80", VA = "0x180473D80")]
	public void StartTrade(uint tradeEntityId, ref TradeParticipantsData data)
	{
	}

	// Token: 0x06000F35 RID: 3893 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F35")]
	[Address(RVA = "0x474B70", Offset = "0x473D70", VA = "0x180474B70")]
	public void UpdateTrade(ref TradeStateData data)
	{
	}

	// Token: 0x06000F36 RID: 3894 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000F36")]
	[Address(RVA = "0x4734B0", Offset = "0x4726B0", VA = "0x1804734B0")]
	private static List<ItemValue> GetMissingItems(ref TradeOffer fromOffer, ref TradeOffer toOffer)
	{
		return null;
	}

	// Token: 0x06000F37 RID: 3895 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000F37")]
	[Address(RVA = "0x473710", Offset = "0x472910", VA = "0x180473710")]
	private static List<ItemValue> GetOfferItems(ref TradeOffer offer)
	{
		return null;
	}

	// Token: 0x06000F38 RID: 3896 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F38")]
	[Address(RVA = "0x472EB0", Offset = "0x4720B0", VA = "0x180472EB0")]
	private void CheckChanged(ref TradeOffer newOffer, ref TradeOffer lastOffer, List<ValueTuple<ItemValue, float>> changed)
	{
	}

	// Token: 0x06000F39 RID: 3897 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F39")]
	[Address(RVA = "0x473840", Offset = "0x472A40", VA = "0x180473840")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000F3A RID: 3898 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F3A")]
	[Address(RVA = "0x4738B0", Offset = "0x472AB0", VA = "0x1804738B0")]
	private void ResetAcceptState()
	{
	}

	// Token: 0x06000F3B RID: 3899 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F3B")]
	[Address(RVA = "0x473CF0", Offset = "0x472EF0", VA = "0x180473CF0")]
	private void SendAction(TradeAction action)
	{
	}

	// Token: 0x06000F3C RID: 3900 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F3C")]
	[Address(RVA = "0x4741B0", Offset = "0x4733B0", VA = "0x1804741B0")]
	private void SyncOffer(ref TradeOffer offer, TradeSlot[] offerSlots)
	{
	}

	// Token: 0x06000F3D RID: 3901 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F3D")]
	[Address(RVA = "0x4742E0", Offset = "0x4734E0", VA = "0x1804742E0")]
	private void UpdateAcceptState()
	{
	}

	// Token: 0x06000F3E RID: 3902 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F3E")]
	[Address(RVA = "0x474610", Offset = "0x473810", VA = "0x180474610")]
	private void UpdateChanged()
	{
	}

	// Token: 0x06000F3F RID: 3903 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F3F")]
	[Address(RVA = "0x4744C0", Offset = "0x4736C0", VA = "0x1804744C0")]
	private void UpdateChangedOffer(TradeSlot[] offers, List<ValueTuple<ItemValue, float>> changed)
	{
	}

	// Token: 0x06000F40 RID: 3904 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F40")]
	[Address(RVA = "0x474670", Offset = "0x473870", VA = "0x180474670")]
	private void UpdateStatus()
	{
	}

	// Token: 0x06000F41 RID: 3905 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F41")]
	[Address(RVA = "0x474EF0", Offset = "0x4740F0", VA = "0x180474EF0")]
	public TradeMenu()
	{
	}

	// Token: 0x04000C8B RID: 3211
	[Token(Token = "0x4000C8B")]
	private const float ChangedDuration = 10f;

	// Token: 0x04000C8C RID: 3212
	[Token(Token = "0x4000C8C")]
	[FieldOffset(Offset = "0x0")]
	private static TradeOffer s_emptyOffer;

	// Token: 0x04000C8D RID: 3213
	[Token(Token = "0x4000C8D")]
	[FieldOffset(Offset = "0x90")]
	public TextMeshProUGUI Name;

	// Token: 0x04000C8E RID: 3214
	[Token(Token = "0x4000C8E")]
	[FieldOffset(Offset = "0x98")]
	public TradeSlot[] Offers;

	// Token: 0x04000C8F RID: 3215
	[Token(Token = "0x4000C8F")]
	[FieldOffset(Offset = "0xA0")]
	public TextMeshProUGUI OtherName;

	// Token: 0x04000C90 RID: 3216
	[Token(Token = "0x4000C90")]
	[FieldOffset(Offset = "0xA8")]
	public TradeSlot[] OtherOffers;

	// Token: 0x04000C91 RID: 3217
	[Token(Token = "0x4000C91")]
	[FieldOffset(Offset = "0xB0")]
	public Slider AcceptSlider;

	// Token: 0x04000C92 RID: 3218
	[Token(Token = "0x4000C92")]
	[FieldOffset(Offset = "0xB8")]
	public Button AcceptButton;

	// Token: 0x04000C93 RID: 3219
	[Token(Token = "0x4000C93")]
	[FieldOffset(Offset = "0xC0")]
	public Color GreenColor;

	// Token: 0x04000C94 RID: 3220
	[Token(Token = "0x4000C94")]
	[FieldOffset(Offset = "0xD0")]
	public Color RedColor;

	// Token: 0x04000C95 RID: 3221
	[Token(Token = "0x4000C95")]
	[FieldOffset(Offset = "0xE0")]
	public TextMeshProUGUI Status;

	// Token: 0x04000C96 RID: 3222
	[Token(Token = "0x4000C96")]
	[FieldOffset(Offset = "0xE8")]
	public Image StatusOutline;

	// Token: 0x04000C97 RID: 3223
	[Token(Token = "0x4000C97")]
	[FieldOffset(Offset = "0xF0")]
	public SlotController SlotController;

	// Token: 0x04000C98 RID: 3224
	[Token(Token = "0x4000C98")]
	[FieldOffset(Offset = "0xF8")]
	public World World;

	// Token: 0x04000C99 RID: 3225
	[Token(Token = "0x4000C99")]
	[FieldOffset(Offset = "0x100")]
	private float _acceptTime;

	// Token: 0x04000C9A RID: 3226
	[Token(Token = "0x4000C9A")]
	[FieldOffset(Offset = "0x104")]
	private TradeStateData _tradeStateData;

	// Token: 0x04000C9B RID: 3227
	[Token(Token = "0x4000C9B")]
	[FieldOffset(Offset = "0x23A")]
	private TradeOffer _lastOfferA;

	// Token: 0x04000C9C RID: 3228
	[Token(Token = "0x4000C9C")]
	[FieldOffset(Offset = "0x2D1")]
	private TradeOffer _lastOfferB;

	// Token: 0x04000C9D RID: 3229
	[Token(Token = "0x4000C9D")]
	[FieldOffset(Offset = "0x368")]
	private readonly List<ValueTuple<ItemValue, float>> _changedA;

	// Token: 0x04000C9E RID: 3230
	[Token(Token = "0x4000C9E")]
	[FieldOffset(Offset = "0x370")]
	private readonly List<ValueTuple<ItemValue, float>> _changedB;

	// Token: 0x04000C9F RID: 3231
	[Token(Token = "0x4000C9F")]
	[FieldOffset(Offset = "0x378")]
	private readonly Dictionary<byte, ValueTuple<byte, long>> _offers;

	// Token: 0x04000CA0 RID: 3232
	[Token(Token = "0x4000CA0")]
	[FieldOffset(Offset = "0x380")]
	private bool _isA;

	// Token: 0x04000CA1 RID: 3233
	[Token(Token = "0x4000CA1")]
	[FieldOffset(Offset = "0x384")]
	private float _acceptDelay;
}
