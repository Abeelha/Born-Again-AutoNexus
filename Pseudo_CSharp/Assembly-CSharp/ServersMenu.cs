using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x0200012C RID: 300
[Token(Token = "0x200012C")]
public class ServersMenu : Menu
{
	// Token: 0x06000535 RID: 1333 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000535")]
	[Address(RVA = "0x3DD010", Offset = "0x3DC210", VA = "0x1803DD010")]
	private void Awake()
	{
	}

	// Token: 0x06000536 RID: 1334 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000536")]
	[Address(RVA = "0x3BD8B0", Offset = "0x3BCAB0", VA = "0x1803BD8B0")]
	public void Back()
	{
	}

	// Token: 0x06000537 RID: 1335 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000537")]
	[Address(RVA = "0x3DE240", Offset = "0x3DD440", VA = "0x1803DE240")]
	public void Refresh()
	{
	}

	// Token: 0x06000538 RID: 1336 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000538")]
	[Address(RVA = "0x3DE4F0", Offset = "0x3DD6F0", VA = "0x1803DE4F0")]
	public void Select(ServerDisplay display)
	{
	}

	// Token: 0x06000539 RID: 1337 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000539")]
	[Address(RVA = "0x3DE050", Offset = "0x3DD250", VA = "0x1803DE050", Slot = "5")]
	protected override void OnEnter()
	{
	}

	// Token: 0x0600053A RID: 1338 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600053A")]
	[Address(RVA = "0x3DD070", Offset = "0x3DC270", VA = "0x1803DD070")]
	private ServerDisplay GetDisplay()
	{
		return null;
	}

	// Token: 0x0600053B RID: 1339 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600053B")]
	[Address(RVA = "0x3DD3B0", Offset = "0x3DC5B0", VA = "0x1803DD3B0")]
	private TextMeshProUGUI GetGroupLabel()
	{
		return null;
	}

	// Token: 0x0600053C RID: 1340 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600053C")]
	[Address(RVA = "0x3DD6C0", Offset = "0x3DC8C0", VA = "0x1803DD6C0")]
	private void LayoutDisplays()
	{
	}

	// Token: 0x0600053D RID: 1341 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600053D")]
	[Address(RVA = "0x3DE420", Offset = "0x3DD620", VA = "0x1803DE420")]
	private Task ReloadStatusAsync()
	{
		return null;
	}

	// Token: 0x0600053E RID: 1342 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600053E")]
	[Address(RVA = "0x3DE5F0", Offset = "0x3DD7F0", VA = "0x1803DE5F0")]
	private void StartPing()
	{
	}

	// Token: 0x0600053F RID: 1343 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600053F")]
	[Address(RVA = "0x3DE800", Offset = "0x3DDA00", VA = "0x1803DE800")]
	public ServersMenu()
	{
	}

	// Token: 0x040005A6 RID: 1446
	[Token(Token = "0x40005A6")]
	[FieldOffset(Offset = "0x90")]
	public TextMeshProUGUI GroupLabelPrefab;

	// Token: 0x040005A7 RID: 1447
	[Token(Token = "0x40005A7")]
	[FieldOffset(Offset = "0x98")]
	public ServerDisplay ServerDisplayPrefab;

	// Token: 0x040005A8 RID: 1448
	[Token(Token = "0x40005A8")]
	[FieldOffset(Offset = "0xA0")]
	public ServerDisplay AutoSelectDisplay;

	// Token: 0x040005A9 RID: 1449
	[Token(Token = "0x40005A9")]
	[FieldOffset(Offset = "0xA8")]
	public RectTransform ScrollContent;

	// Token: 0x040005AA RID: 1450
	[Token(Token = "0x40005AA")]
	[FieldOffset(Offset = "0xB0")]
	public GameObject NoRegions;

	// Token: 0x040005AB RID: 1451
	[Token(Token = "0x40005AB")]
	[FieldOffset(Offset = "0xB8")]
	private readonly List<ServerDisplay> _displays;

	// Token: 0x040005AC RID: 1452
	[Token(Token = "0x40005AC")]
	[FieldOffset(Offset = "0xC0")]
	private readonly List<TextMeshProUGUI> _groupLabels;

	// Token: 0x040005AD RID: 1453
	[Token(Token = "0x40005AD")]
	[FieldOffset(Offset = "0xC8")]
	private int _activeDisplays;

	// Token: 0x040005AE RID: 1454
	[Token(Token = "0x40005AE")]
	[FieldOffset(Offset = "0xCC")]
	private int _activeGroupLabels;

	// Token: 0x040005AF RID: 1455
	[Token(Token = "0x40005AF")]
	[FieldOffset(Offset = "0xD0")]
	private ServerDisplay _selectedDisplay;

	// Token: 0x040005B0 RID: 1456
	[Token(Token = "0x40005B0")]
	[FieldOffset(Offset = "0xD8")]
	private DateTime _lastRefresh;
}
