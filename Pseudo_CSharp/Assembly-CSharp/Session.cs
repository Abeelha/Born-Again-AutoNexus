using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using Ronin.Api.Model.Account;
using Ronin.Api.Model.Bundle;
using Ronin.Api.Model.CharacterSlot;
using Ronin.Api.Model.Connection;
using Ronin.Api.Model.Friend;
using Ronin.Api.Model.Hello;
using Ronin.Api.Model.Region;
using Ronin.Model.Enums;
using UnityEngine;
using UnnamedStudios.Common.Model;

// Token: 0x0200015D RID: 349
[Token(Token = "0x200015D")]
public static class Session
{
	// Token: 0x1700008B RID: 139
	// (get) Token: 0x060006CD RID: 1741 RVA: 0x0000206A File Offset: 0x0000026A
	// (set) Token: 0x060006CE RID: 1742 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700008B")]
	public static GetAccountResponse Account
	{
		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x3F9790", Offset = "0x3F8990", VA = "0x1803F9790")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x3FA070", Offset = "0x3F9270", VA = "0x1803FA070")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x1700008C RID: 140
	// (get) Token: 0x060006CF RID: 1743 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x1700008C")]
	public static Dictionary<int, GetBundleResponse> Bundles
	{
		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x3F97E0", Offset = "0x3F89E0", VA = "0x1803F97E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	// Token: 0x1700008D RID: 141
	// (get) Token: 0x060006D0 RID: 1744 RVA: 0x0000206A File Offset: 0x0000026A
	// (set) Token: 0x060006D1 RID: 1745 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700008D")]
	public static List<GetCharacterSlotResponse> CharacterSlots
	{
		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x3F9830", Offset = "0x3F8A30", VA = "0x1803F9830")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x3FA0E0", Offset = "0x3F92E0", VA = "0x1803FA0E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x1700008E RID: 142
	// (get) Token: 0x060006D2 RID: 1746 RVA: 0x00003A20 File Offset: 0x00001C20
	// (set) Token: 0x060006D3 RID: 1747 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700008E")]
	public static bool CreateNewCharacter
	{
		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x3F98D0", Offset = "0x3F8AD0", VA = "0x1803F98D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x3FA1C0", Offset = "0x3F93C0", VA = "0x1803FA1C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x1700008F RID: 143
	// (get) Token: 0x060006D4 RID: 1748 RVA: 0x0000206A File Offset: 0x0000026A
	// (set) Token: 0x060006D5 RID: 1749 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700008F")]
	public static CreateConnectionResponse ConnectionResponse
	{
		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x3F9880", Offset = "0x3F8A80", VA = "0x1803F9880")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x3FA150", Offset = "0x3F9350", VA = "0x1803FA150")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x17000090 RID: 144
	// (get) Token: 0x060006D6 RID: 1750 RVA: 0x0000206A File Offset: 0x0000026A
	// (set) Token: 0x060006D7 RID: 1751 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000090")]
	public static GetRegionResponse CurrentRegion
	{
		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x3F9960", Offset = "0x3F8B60", VA = "0x1803F9960")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x3FA220", Offset = "0x3F9420", VA = "0x1803FA220")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x17000091 RID: 145
	// (get) Token: 0x060006D8 RID: 1752 RVA: 0x00003A38 File Offset: 0x00001C38
	// (set) Token: 0x060006D9 RID: 1753 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000091")]
	public static DisconnectReason? DisconnectReason
	{
		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x3F99C0", Offset = "0x3F8BC0", VA = "0x1803F99C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x3FA290", Offset = "0x3F9490", VA = "0x1803FA290")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x17000092 RID: 146
	// (get) Token: 0x060006DA RID: 1754 RVA: 0x0000206A File Offset: 0x0000026A
	// (set) Token: 0x060006DB RID: 1755 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000092")]
	public static Dictionary<long, GetFriendResponse> FriendList
	{
		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x3F9A10", Offset = "0x3F8C10", VA = "0x1803F9A10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x3FA2F0", Offset = "0x3F94F0", VA = "0x1803FA2F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x17000093 RID: 147
	// (get) Token: 0x060006DC RID: 1756 RVA: 0x0000206A File Offset: 0x0000026A
	// (set) Token: 0x060006DD RID: 1757 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000093")]
	public static Dictionary<long, GetStatusFriendResponse> FriendStatuses
	{
		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x3F9A60", Offset = "0x3F8C60", VA = "0x1803F9A60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x3FA360", Offset = "0x3F9560", VA = "0x1803FA360")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x17000094 RID: 148
	// (get) Token: 0x060006DE RID: 1758 RVA: 0x0000206A File Offset: 0x0000026A
	// (set) Token: 0x060006DF RID: 1759 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000094")]
	public static Dictionary<long, string> StatusDetails
	{
		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x3F9F50", Offset = "0x3F9150", VA = "0x1803F9F50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x3FA600", Offset = "0x3F9800", VA = "0x1803FA600")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x17000095 RID: 149
	// (get) Token: 0x060006E0 RID: 1760 RVA: 0x00003A50 File Offset: 0x00001C50
	// (set) Token: 0x060006E1 RID: 1761 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000095")]
	public static DateTime LastFriendStatusUpdate
	{
		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x3F9B10", Offset = "0x3F8D10", VA = "0x1803F9B10")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x3FA450", Offset = "0x3F9650", VA = "0x1803FA450")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x17000096 RID: 150
	// (get) Token: 0x060006E2 RID: 1762 RVA: 0x0000206A File Offset: 0x0000026A
	// (set) Token: 0x060006E3 RID: 1763 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000096")]
	public static HelloResponse Hello
	{
		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x3F9AB0", Offset = "0x3F8CB0", VA = "0x1803F9AB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x3FA3D0", Offset = "0x3F95D0", VA = "0x1803FA3D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x17000097 RID: 151
	// (get) Token: 0x060006E4 RID: 1764 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x17000097")]
	public static List<GetRegionResponse> Regions
	{
		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x3F9CE0", Offset = "0x3F8EE0", VA = "0x1803F9CE0")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000098 RID: 152
	// (get) Token: 0x060006E5 RID: 1765 RVA: 0x0000206A File Offset: 0x0000026A
	// (set) Token: 0x060006E6 RID: 1766 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000098")]
	public static Dictionary<long, GetStatusRegionResponse> RegionStatuses
	{
		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x3F9C00", Offset = "0x3F8E00", VA = "0x1803F9C00")]
		get
		{
			return null;
		}
		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x3FA4B0", Offset = "0x3F96B0", VA = "0x1803FA4B0")]
		set
		{
		}
	}

	// Token: 0x17000099 RID: 153
	// (get) Token: 0x060006E7 RID: 1767 RVA: 0x00003A68 File Offset: 0x00001C68
	[Token(Token = "0x17000099")]
	public static bool RegionsExpired
	{
		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x3F9C50", Offset = "0x3F8E50", VA = "0x1803F9C50")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700009A RID: 154
	// (get) Token: 0x060006E8 RID: 1768 RVA: 0x00003A80 File Offset: 0x00001C80
	[Token(Token = "0x1700009A")]
	public static bool RegionStatusesExpired
	{
		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x3F9B70", Offset = "0x3F8D70", VA = "0x1803F9B70")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700009B RID: 155
	// (get) Token: 0x060006E9 RID: 1769 RVA: 0x0000206A File Offset: 0x0000026A
	// (set) Token: 0x060006EA RID: 1770 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700009B")]
	public static GetCharacterSlotResponse SelectedCharacterSlot
	{
		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x3F9DA0", Offset = "0x3F8FA0", VA = "0x1803F9DA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x3FA580", Offset = "0x3F9780", VA = "0x1803FA580")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x1700009C RID: 156
	// (get) Token: 0x060006EB RID: 1771 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x1700009C")]
	public static GetRegionResponse SelectedRegion
	{
		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x3F9E00", Offset = "0x3F9000", VA = "0x1803F9E00")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700009D RID: 157
	// (get) Token: 0x060006EC RID: 1772 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x1700009D")]
	public static List<ulong> Wardrobe
	{
		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x3F9FB0", Offset = "0x3F91B0", VA = "0x1803F9FB0")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700009E RID: 158
	// (get) Token: 0x060006ED RID: 1773 RVA: 0x00003A98 File Offset: 0x00001C98
	[Token(Token = "0x1700009E")]
	public static PlatformType CurrentPlatform
	{
		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x3F9920", Offset = "0x3F8B20", VA = "0x1803F9920")]
		get
		{
			return PlatformType.Pc;
		}
	}

	// Token: 0x1700009F RID: 159
	// (get) Token: 0x060006EE RID: 1774 RVA: 0x00003AB0 File Offset: 0x00001CB0
	[Token(Token = "0x1700009F")]
	public static DeviceType DeviceType
	{
		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x3F99B0", Offset = "0x3F8BB0", VA = "0x1803F99B0")]
		get
		{
			return DeviceType.Unknown;
		}
	}

	// Token: 0x170000A0 RID: 160
	// (get) Token: 0x060006EF RID: 1775 RVA: 0x00003AC8 File Offset: 0x00001CC8
	[Token(Token = "0x170000A0")]
	public static Rect SafeArea
	{
		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x3F9D70", Offset = "0x3F8F70", VA = "0x1803F9D70")]
		get
		{
			return default(Rect);
		}
	}

	// Token: 0x060006F0 RID: 1776 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006F0")]
	[Address(RVA = "0x3F8400", Offset = "0x3F7600", VA = "0x1803F8400")]
	public static void AddCurrency(CurrencyType currency, int amount)
	{
	}

	// Token: 0x060006F1 RID: 1777 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006F1")]
	[Address(RVA = "0x3F8540", Offset = "0x3F7740", VA = "0x1803F8540")]
	public static void AddMedallions(int amount)
	{
	}

	// Token: 0x060006F2 RID: 1778 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60006F2")]
	[Address(RVA = "0x3F8630", Offset = "0x3F7830", VA = "0x1803F8630")]
	public static Task<GetRegionResponse> GetBestServerAsync()
	{
		return null;
	}

	// Token: 0x060006F3 RID: 1779 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60006F3")]
	[Address(RVA = "0x3F8710", Offset = "0x3F7910", VA = "0x1803F8710")]
	public static Task<GetRegionResponse> GetCurrentRegionAsync()
	{
		return null;
	}

	// Token: 0x060006F4 RID: 1780 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60006F4")]
	[Address(RVA = "0x3F88D0", Offset = "0x3F7AD0", VA = "0x1803F88D0")]
	public static Task GetRegionsAsync()
	{
		return null;
	}

	// Token: 0x060006F5 RID: 1781 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60006F5")]
	[Address(RVA = "0x3F87F0", Offset = "0x3F79F0", VA = "0x1803F87F0")]
	public static Task<ServiceResponse<GetAllStatusRegionResponse>> GetRegionStatusesAsync()
	{
		return null;
	}

	// Token: 0x060006F6 RID: 1782 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60006F6")]
	[Address(RVA = "0x3F89D0", Offset = "0x3F7BD0", VA = "0x1803F89D0")]
	public static Task<ServiceResponse> PlayAsync(GetCharacterSlotResponse characterSlot)
	{
		return null;
	}

	// Token: 0x060006F7 RID: 1783 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006F7")]
	[Address(RVA = "0x3F8AE0", Offset = "0x3F7CE0", VA = "0x1803F8AE0")]
	public static void RecordPurchase(CurrencyType currency, int amount, string purchaseType, string purchaseItem)
	{
	}

	// Token: 0x060006F8 RID: 1784 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006F8")]
	[Address(RVA = "0x3F8E60", Offset = "0x3F8060", VA = "0x1803F8E60")]
	public static void TakeCurrency(CurrencyType currency, int amount)
	{
	}

	// Token: 0x060006F9 RID: 1785 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006F9")]
	[Address(RVA = "0x3F92A0", Offset = "0x3F84A0", VA = "0x1803F92A0")]
	public static void UpdateConsent(bool consent)
	{
	}

	// Token: 0x060006FA RID: 1786 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60006FA")]
	[Address(RVA = "0x3F8980", Offset = "0x3F7B80", VA = "0x1803F8980")]
	private static List<GetRegionResponse> GetRegions()
	{
		return null;
	}

	// Token: 0x060006FB RID: 1787 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006FB")]
	[Address(RVA = "0x3F8CE0", Offset = "0x3F7EE0", VA = "0x1803F8CE0")]
	private static void SetRegions(List<GetRegionResponse> regions, TimeSpan timeout)
	{
	}

	// Token: 0x060006FC RID: 1788 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60006FC")]
	[Address(RVA = "0x3F8DB0", Offset = "0x3F7FB0", VA = "0x1803F8DB0")]
	private static Task ShowServerFullAsync()
	{
		return null;
	}

	// Token: 0x060006FE RID: 1790 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60006FE")]
	[Address(RVA = "0x3F91B0", Offset = "0x3F83B0", VA = "0x1803F91B0")]
	[CompilerGenerated]
	internal static Task<ValueTuple<GetRegionResponse, int>> <GetBestServerAsync>g__pingAsync|79_3(GetRegionResponse region)
	{
		return null;
	}

	// Token: 0x060006FF RID: 1791 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60006FF")]
	[Address(RVA = "0x3F8FA0", Offset = "0x3F81A0", VA = "0x1803F8FA0")]
	[CompilerGenerated]
	internal static Task<ValueTuple<GetRegionResponse, int>> <GetBestServerAsync>g__bestPingAsync|79_4(IEnumerable<GetRegionResponse> regions)
	{
		return null;
	}

	// Token: 0x06000700 RID: 1792 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000700")]
	[Address(RVA = "0x3F9090", Offset = "0x3F8290", VA = "0x1803F9090")]
	[CompilerGenerated]
	internal static Task<ValueTuple<GetRegionResponse, int>> <GetBestServerAsync>g__optimalRegionAsync|79_5(IEnumerable<GetRegionResponse> regions, Dictionary<long, GetStatusRegionResponse> statuses)
	{
		return null;
	}

	// Token: 0x040006C9 RID: 1737
	[Token(Token = "0x40006C9")]
	[FieldOffset(Offset = "0x0")]
	private static List<ulong> s_emptyWardrobe;

	// Token: 0x040006CA RID: 1738
	[Token(Token = "0x40006CA")]
	[FieldOffset(Offset = "0x8")]
	private static List<GetRegionResponse> s_regions;

	// Token: 0x040006CB RID: 1739
	[Token(Token = "0x40006CB")]
	[FieldOffset(Offset = "0x10")]
	private static DateTime s_regionTtl;

	// Token: 0x040006CC RID: 1740
	[Token(Token = "0x40006CC")]
	[FieldOffset(Offset = "0x18")]
	private static Dictionary<long, GetStatusRegionResponse> s_regionStatuses;

	// Token: 0x040006CD RID: 1741
	[Token(Token = "0x40006CD")]
	[FieldOffset(Offset = "0x20")]
	private static DateTime s_regionStatusTtl;

	// Token: 0x040006CE RID: 1742
	[Token(Token = "0x40006CE")]
	[FieldOffset(Offset = "0x28")]
	private static Dictionary<long, GetFriendResponse> s_friendList;

	// Token: 0x040006CF RID: 1743
	[Token(Token = "0x40006CF")]
	[FieldOffset(Offset = "0x30")]
	public static bool FirstMenu;
}
