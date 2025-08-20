using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Ronin.Api.Model.Region;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200012B RID: 299
[Token(Token = "0x200012B")]
public class ServerDisplay : MonoBehaviour
{
	// Token: 0x1700005C RID: 92
	// (get) Token: 0x06000524 RID: 1316 RVA: 0x000034F8 File Offset: 0x000016F8
	[Token(Token = "0x1700005C")]
	public long Id
	{
		[Token(Token = "0x6000524")]
		[Address(RVA = "0x3DCF80", Offset = "0x3DC180", VA = "0x1803DCF80")]
		get
		{
			return 0L;
		}
	}

	// Token: 0x1700005D RID: 93
	// (get) Token: 0x06000525 RID: 1317 RVA: 0x0000206A File Offset: 0x0000026A
	// (set) Token: 0x06000526 RID: 1318 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700005D")]
	public GetRegionResponse Region
	{
		[Token(Token = "0x6000525")]
		[Address(RVA = "0x3DCFB0", Offset = "0x3DC1B0", VA = "0x1803DCFB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000526")]
		[Address(RVA = "0x3DCFF0", Offset = "0x3DC1F0", VA = "0x1803DCFF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x1700005E RID: 94
	// (get) Token: 0x06000527 RID: 1319 RVA: 0x0000206A File Offset: 0x0000026A
	// (set) Token: 0x06000528 RID: 1320 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700005E")]
	public GetStatusRegionResponse RegionStatus
	{
		[Token(Token = "0x6000527")]
		[Address(RVA = "0x3DCFA0", Offset = "0x3DC1A0", VA = "0x1803DCFA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000528")]
		[Address(RVA = "0x3DCFD0", Offset = "0x3DC1D0", VA = "0x1803DCFD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x1700005F RID: 95
	// (get) Token: 0x06000529 RID: 1321 RVA: 0x00003510 File Offset: 0x00001710
	// (set) Token: 0x0600052A RID: 1322 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700005F")]
	public bool Selected
	{
		[Token(Token = "0x6000529")]
		[Address(RVA = "0x3DCFC0", Offset = "0x3DC1C0", VA = "0x1803DCFC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600052A")]
		[Address(RVA = "0x3DCAE0", Offset = "0x3DBCE0", VA = "0x1803DCAE0")]
		set
		{
		}
	}

	// Token: 0x0600052B RID: 1323 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600052B")]
	[Address(RVA = "0x3DC7E0", Offset = "0x3DB9E0", VA = "0x1803DC7E0")]
	public void SetRegion(GetRegionResponse region, GetStatusRegionResponse status)
	{
	}

	// Token: 0x0600052C RID: 1324 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600052C")]
	[Address(RVA = "0x3DCDA0", Offset = "0x3DBFA0", VA = "0x1803DCDA0")]
	public void SwapPings(ServerDisplay other)
	{
	}

	// Token: 0x0600052D RID: 1325 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600052D")]
	[Address(RVA = "0x3DCC00", Offset = "0x3DBE00", VA = "0x1803DCC00")]
	public void StartPing()
	{
	}

	// Token: 0x0600052E RID: 1326 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600052E")]
	[Address(RVA = "0x3DC520", Offset = "0x3DB720", VA = "0x1803DC520")]
	private Sprite GetPingIconSprite(int ms)
	{
		return null;
	}

	// Token: 0x0600052F RID: 1327 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600052F")]
	[Address(RVA = "0x3DC610", Offset = "0x3DB810", VA = "0x1803DC610")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000530 RID: 1328 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000530")]
	[Address(RVA = "0x3DC550", Offset = "0x3DB750", VA = "0x1803DC550")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000531 RID: 1329 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000531")]
	[Address(RVA = "0x3DC630", Offset = "0x3DB830", VA = "0x1803DC630")]
	private void SetPing(int? ms)
	{
	}

	// Token: 0x06000532 RID: 1330 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000532")]
	[Address(RVA = "0x3DCAE0", Offset = "0x3DBCE0", VA = "0x1803DCAE0")]
	private void SetSelected(bool value)
	{
	}

	// Token: 0x06000533 RID: 1331 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000533")]
	[Address(RVA = "0x3DC550", Offset = "0x3DB750", VA = "0x1803DC550")]
	private void UpdatePing()
	{
	}

	// Token: 0x06000534 RID: 1332 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000534")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public ServerDisplay()
	{
	}

	// Token: 0x04000595 RID: 1429
	[Token(Token = "0x4000595")]
	[FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI NameLabel;

	// Token: 0x04000596 RID: 1430
	[Token(Token = "0x4000596")]
	[FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI PingLabel;

	// Token: 0x04000597 RID: 1431
	[Token(Token = "0x4000597")]
	[FieldOffset(Offset = "0x30")]
	public TextMeshProUGUI LobbyCountLabel;

	// Token: 0x04000598 RID: 1432
	[Token(Token = "0x4000598")]
	[FieldOffset(Offset = "0x38")]
	public TextMeshProUGUI PlayerCountLabel;

	// Token: 0x04000599 RID: 1433
	[Token(Token = "0x4000599")]
	[FieldOffset(Offset = "0x40")]
	public Image PingIcon;

	// Token: 0x0400059A RID: 1434
	[Token(Token = "0x400059A")]
	[FieldOffset(Offset = "0x48")]
	public Image ButtonImage;

	// Token: 0x0400059B RID: 1435
	[Token(Token = "0x400059B")]
	[FieldOffset(Offset = "0x50")]
	public Button Button;

	// Token: 0x0400059C RID: 1436
	[Token(Token = "0x400059C")]
	[FieldOffset(Offset = "0x58")]
	public Sprite PingGoodSprite;

	// Token: 0x0400059D RID: 1437
	[Token(Token = "0x400059D")]
	[FieldOffset(Offset = "0x60")]
	public Sprite PingOkaySprite;

	// Token: 0x0400059E RID: 1438
	[Token(Token = "0x400059E")]
	[FieldOffset(Offset = "0x68")]
	public Sprite PingDegradedSprite;

	// Token: 0x0400059F RID: 1439
	[Token(Token = "0x400059F")]
	[FieldOffset(Offset = "0x70")]
	public Sprite PingBadSprite;

	// Token: 0x040005A0 RID: 1440
	[Token(Token = "0x40005A0")]
	[FieldOffset(Offset = "0x78")]
	public Sprite[] DefaultSprites;

	// Token: 0x040005A1 RID: 1441
	[Token(Token = "0x40005A1")]
	[FieldOffset(Offset = "0x80")]
	public Sprite[] SelectedSprites;

	// Token: 0x040005A2 RID: 1442
	[Token(Token = "0x40005A2")]
	[FieldOffset(Offset = "0x88")]
	private Ping _ping;

	// Token: 0x040005A3 RID: 1443
	[Token(Token = "0x40005A3")]
	[FieldOffset(Offset = "0x90")]
	private bool _selected;
}
