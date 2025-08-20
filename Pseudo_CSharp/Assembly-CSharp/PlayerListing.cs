using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x020002DD RID: 733
[Token(Token = "0x20002DD")]
public class PlayerListing : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
{
	// Token: 0x06000FEA RID: 4074 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FEA")]
	[Address(RVA = "0x355960", Offset = "0x354B60", VA = "0x180355960", Slot = "4")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	// Token: 0x06000FEB RID: 4075 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FEB")]
	[Address(RVA = "0x355970", Offset = "0x354B70", VA = "0x180355970")]
	public void SetDetail(string detail)
	{
	}

	// Token: 0x06000FEC RID: 4076 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FEC")]
	[Address(RVA = "0x355DF0", Offset = "0x354FF0", VA = "0x180355DF0")]
	public void Setup(Character character)
	{
	}

	// Token: 0x06000FED RID: 4077 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FED")]
	[Address(RVA = "0x355A40", Offset = "0x354C40", VA = "0x180355A40")]
	public void Setup(long playerId, string playerName)
	{
	}

	// Token: 0x06000FEE RID: 4078 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FEE")]
	[Address(RVA = "0x3555D0", Offset = "0x3547D0", VA = "0x1803555D0")]
	private void DoOptions()
	{
	}

	// Token: 0x06000FEF RID: 4079 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FEF")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public PlayerListing()
	{
	}

	// Token: 0x06000FF0 RID: 4080 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FF0")]
	[Address(RVA = "0x356330", Offset = "0x355530", VA = "0x180356330")]
	[CompilerGenerated]
	internal static void <DoOptions>g__doCommand|15_0(World world, string command, long playerId, string name)
	{
	}

	// Token: 0x04000D3D RID: 3389
	[Token(Token = "0x4000D3D")]
	[FieldOffset(Offset = "0x20")]
	public Sprite DefaultPortrait;

	// Token: 0x04000D3E RID: 3390
	[Token(Token = "0x4000D3E")]
	[FieldOffset(Offset = "0x28")]
	public Image Portrait;

	// Token: 0x04000D3F RID: 3391
	[Token(Token = "0x4000D3F")]
	[FieldOffset(Offset = "0x30")]
	public TextMeshProUGUI Name;

	// Token: 0x04000D40 RID: 3392
	[Token(Token = "0x4000D40")]
	[FieldOffset(Offset = "0x38")]
	public TextMeshProUGUI Detail;

	// Token: 0x04000D41 RID: 3393
	[Token(Token = "0x4000D41")]
	[FieldOffset(Offset = "0x40")]
	public CharacterTooltipSource CharacterTooltipSource;

	// Token: 0x04000D42 RID: 3394
	[Token(Token = "0x4000D42")]
	[FieldOffset(Offset = "0x48")]
	public ContextActions Options;

	// Token: 0x04000D43 RID: 3395
	[Token(Token = "0x4000D43")]
	[FieldOffset(Offset = "0x50")]
	public World World;

	// Token: 0x04000D44 RID: 3396
	[Token(Token = "0x4000D44")]
	[FieldOffset(Offset = "0x58")]
	public GameObject Ignored;

	// Token: 0x04000D45 RID: 3397
	[Token(Token = "0x4000D45")]
	[FieldOffset(Offset = "0x60")]
	private uint _entityId;

	// Token: 0x04000D46 RID: 3398
	[Token(Token = "0x4000D46")]
	[FieldOffset(Offset = "0x68")]
	private long _playerId;

	// Token: 0x04000D47 RID: 3399
	[Token(Token = "0x4000D47")]
	[FieldOffset(Offset = "0x70")]
	private bool _canTrade;
}
