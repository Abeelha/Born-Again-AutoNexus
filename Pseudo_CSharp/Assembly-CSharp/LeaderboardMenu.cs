using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using kha2dev.DatePicker;
using Ronin.Api.Model.Leaderboard;
using Ronin.Model.Definitions;
using Ronin.Model.Enums;
using TMPro;
using UnityEngine;

// Token: 0x02000112 RID: 274
[Token(Token = "0x2000112")]
public class LeaderboardMenu : GalleryMenu
{
	// Token: 0x17000056 RID: 86
	// (get) Token: 0x060004AC RID: 1196 RVA: 0x00003408 File Offset: 0x00001608
	[Token(Token = "0x17000056")]
	private LeaderboardSpan Span
	{
		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x3D8400", Offset = "0x3D7600", VA = "0x1803D8400")]
		get
		{
			return LeaderboardSpan.All;
		}
	}

	// Token: 0x17000057 RID: 87
	// (get) Token: 0x060004AD RID: 1197 RVA: 0x00003420 File Offset: 0x00001620
	[Token(Token = "0x17000057")]
	private DateTime Date
	{
		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x3D83A0", Offset = "0x3D75A0", VA = "0x1803D83A0")]
		get
		{
			return default(DateTime);
		}
	}

	// Token: 0x060004AE RID: 1198 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004AE")]
	[Address(RVA = "0x3BD8B0", Offset = "0x3BCAB0", VA = "0x1803BD8B0", Slot = "9")]
	public override void Back()
	{
	}

	// Token: 0x060004AF RID: 1199 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004AF")]
	[Address(RVA = "0x3D6EF0", Offset = "0x3D60F0", VA = "0x1803D6EF0")]
	public void LanguageChanged()
	{
	}

	// Token: 0x060004B0 RID: 1200 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004B0")]
	[Address(RVA = "0x3D7870", Offset = "0x3D6A70", VA = "0x1803D7870")]
	public void PickDate()
	{
	}

	// Token: 0x060004B1 RID: 1201 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004B1")]
	[Address(RVA = "0x3D7CC0", Offset = "0x3D6EC0", VA = "0x1803D7CC0")]
	public void Setup(BlessingDefinition thread, LeaderboardSpan span)
	{
	}

	// Token: 0x060004B2 RID: 1202 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004B2")]
	[Address(RVA = "0x3D7050", Offset = "0x3D6250", VA = "0x1803D7050", Slot = "11")]
	protected override void LoadItems()
	{
	}

	// Token: 0x060004B3 RID: 1203 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004B3")]
	[Address(RVA = "0x3D77F0", Offset = "0x3D69F0", VA = "0x1803D77F0", Slot = "5")]
	protected override void OnEnter()
	{
	}

	// Token: 0x060004B4 RID: 1204 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60004B4")]
	[Address(RVA = "0x3D6E30", Offset = "0x3D6030", VA = "0x1803D6E30")]
	private static string GetLeaderboardKey(LeaderboardSpan span, DateTime date, ushort threadType)
	{
		return null;
	}

	// Token: 0x060004B5 RID: 1205 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004B5")]
	[Address(RVA = "0x3D6F90", Offset = "0x3D6190", VA = "0x1803D6F90")]
	private void LateUpdate()
	{
	}

	// Token: 0x060004B6 RID: 1206 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004B6")]
	[Address(RVA = "0x3D7520", Offset = "0x3D6720", VA = "0x1803D7520")]
	private void LoadLeaderboard()
	{
	}

	// Token: 0x060004B7 RID: 1207 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60004B7")]
	[Address(RVA = "0x3D7410", Offset = "0x3D6610", VA = "0x1803D7410")]
	private Task LoadLeaderboardAsync(LeaderboardSpan span, DateTime date)
	{
		return null;
	}

	// Token: 0x060004B8 RID: 1208 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004B8")]
	[Address(RVA = "0x3D7720", Offset = "0x3D6920", VA = "0x1803D7720")]
	private void OnDateChanged(DateTime date)
	{
	}

	// Token: 0x060004B9 RID: 1209 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004B9")]
	[Address(RVA = "0x3D7A20", Offset = "0x3D6C20", VA = "0x1803D7A20")]
	private void PickNext()
	{
	}

	// Token: 0x060004BA RID: 1210 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004BA")]
	[Address(RVA = "0x3D7B30", Offset = "0x3D6D30", VA = "0x1803D7B30")]
	private void PickPrevious()
	{
	}

	// Token: 0x060004BB RID: 1211 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004BB")]
	[Address(RVA = "0x3D7C40", Offset = "0x3D6E40", VA = "0x1803D7C40")]
	private void SetupLeaderboard(GetLeaderboardResponse leaderboard, [Optional] int? selectIndex)
	{
	}

	// Token: 0x060004BC RID: 1212 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004BC")]
	[Address(RVA = "0x3D7E00", Offset = "0x3D7000", VA = "0x1803D7E00")]
	private void UpdateControllerInput()
	{
	}

	// Token: 0x060004BD RID: 1213 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004BD")]
	[Address(RVA = "0x3D80E0", Offset = "0x3D72E0", VA = "0x1803D80E0")]
	private void UpdateDateLabel()
	{
	}

	// Token: 0x060004BE RID: 1214 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004BE")]
	[Address(RVA = "0x3D8320", Offset = "0x3D7520", VA = "0x1803D8320")]
	public LeaderboardMenu()
	{
	}

	// Token: 0x04000505 RID: 1285
	[Token(Token = "0x4000505")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly Dictionary<string, ValueTuple<DateTime, GetLeaderboardResponse>> s_leaderboardCache;

	// Token: 0x04000506 RID: 1286
	[Token(Token = "0x4000506")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public GameObject DateSelector;

	// Token: 0x04000507 RID: 1287
	[Token(Token = "0x4000507")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public TextMeshProUGUI DateSelectorLabel;

	// Token: 0x04000508 RID: 1288
	[Token(Token = "0x4000508")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public CalendarDatePicker DatePicker;

	// Token: 0x04000509 RID: 1289
	[Token(Token = "0x4000509")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public LeaderboardSpanSelector Selector;

	// Token: 0x0400050A RID: 1290
	[Token(Token = "0x400050A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public DeathDisplay DeathDisplayPrefab;

	// Token: 0x0400050B RID: 1291
	[Token(Token = "0x400050B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public GameObject NoDataLabel;

	// Token: 0x0400050C RID: 1292
	[Token(Token = "0x400050C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private BlessingDefinition _thread;

	// Token: 0x0400050D RID: 1293
	[Token(Token = "0x400050D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private readonly Dictionary<LeaderboardSpan, DateTime> _times;

	// Token: 0x0400050E RID: 1294
	[Token(Token = "0x400050E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private LeaderboardSpan _syncedSpan;

	// Token: 0x0400050F RID: 1295
	[Token(Token = "0x400050F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private GetLeaderboardResponse _leaderboard;

	// Token: 0x04000510 RID: 1296
	[Token(Token = "0x4000510")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private Task _loadTask;
}
