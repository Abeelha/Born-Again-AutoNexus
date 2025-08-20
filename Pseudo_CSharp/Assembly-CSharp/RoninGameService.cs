using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;
using Zero.Game.Client;
using Zero.Unity;

// Token: 0x02000156 RID: 342
[Token(Token = "0x2000156")]
public class RoninGameService : MonoBehaviour
{
	// Token: 0x17000087 RID: 135
	// (get) Token: 0x060006AB RID: 1707 RVA: 0x00003960 File Offset: 0x00001B60
	[Token(Token = "0x17000087")]
	public static bool OnMainThread
	{
		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x3F8190", Offset = "0x3F7390", VA = "0x1803F8190")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000088 RID: 136
	// (get) Token: 0x060006AC RID: 1708 RVA: 0x0000206A File Offset: 0x0000026A
	// (set) Token: 0x060006AD RID: 1709 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000088")]
	public ZeroClient Client
	{
		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x3A3060", Offset = "0x3A2260", VA = "0x1803A3060")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x3F8250", Offset = "0x3F7450", VA = "0x1803F8250")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x17000089 RID: 137
	// (get) Token: 0x060006AE RID: 1710 RVA: 0x00003978 File Offset: 0x00001B78
	// (set) Token: 0x060006AF RID: 1711 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000089")]
	public bool ManuallyDisconnected
	{
		[Token(Token = "0x60006AE")]
		[Address(RVA = "0x333E50", Offset = "0x333050", VA = "0x180333E50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x333E90", Offset = "0x333090", VA = "0x180333E90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x1700008A RID: 138
	// (get) Token: 0x060006B0 RID: 1712 RVA: 0x00003990 File Offset: 0x00001B90
	[Token(Token = "0x1700008A")]
	public int Latency
	{
		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x3F8120", Offset = "0x3F7320", VA = "0x1803F8120")]
		get
		{
			return 0;
		}
	}

	// Token: 0x060006B1 RID: 1713 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006B1")]
	[Address(RVA = "0x3F7540", Offset = "0x3F6740", VA = "0x1803F7540")]
	public void Disconnect()
	{
	}

	// Token: 0x060006B2 RID: 1714 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006B2")]
	public void Push<T>(T data) where T : struct
	{
	}

	// Token: 0x060006B3 RID: 1715 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006B3")]
	[Address(RVA = "0x3F7BC0", Offset = "0x3F6DC0", VA = "0x1803F7BC0")]
	public void PushChat(string text)
	{
	}

	// Token: 0x060006B4 RID: 1716 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006B4")]
	[Address(RVA = "0x3F7220", Offset = "0x3F6420", VA = "0x1803F7220")]
	private void Awake()
	{
	}

	// Token: 0x060006B5 RID: 1717 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006B5")]
	[Address(RVA = "0x3F7300", Offset = "0x3F6500", VA = "0x1803F7300")]
	private void Connect()
	{
	}

	// Token: 0x060006B6 RID: 1718 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006B6")]
	[Address(RVA = "0x3F7560", Offset = "0x3F6760", VA = "0x1803F7560")]
	private void FixedUpdate()
	{
	}

	// Token: 0x060006B7 RID: 1719 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006B7")]
	[Address(RVA = "0x3F75C0", Offset = "0x3F67C0", VA = "0x1803F75C0")]
	private void OnApplicationQuit()
	{
	}

	// Token: 0x060006B8 RID: 1720 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006B8")]
	[Address(RVA = "0x3F75C0", Offset = "0x3F67C0", VA = "0x1803F75C0")]
	private void OnDestroy()
	{
	}

	// Token: 0x060006B9 RID: 1721 RVA: 0x000039A8 File Offset: 0x00001BA8
	[Token(Token = "0x60006B9")]
	[Address(RVA = "0x3F76E0", Offset = "0x3F68E0", VA = "0x1803F76E0")]
	private bool ProcessClientCommand(string text)
	{
		return default(bool);
	}

	// Token: 0x060006BA RID: 1722 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60006BA")]
	[Address(RVA = "0x3F75E0", Offset = "0x3F67E0", VA = "0x1803F75E0")]
	private Task ProcessAddFriendCommandAsync(string args)
	{
		return null;
	}

	// Token: 0x060006BB RID: 1723 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60006BB")]
	[Address(RVA = "0x3F7A10", Offset = "0x3F6C10", VA = "0x1803F7A10")]
	private Task ProcessFriendStatusCommandAsync()
	{
		return null;
	}

	// Token: 0x060006BC RID: 1724 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60006BC")]
	[Address(RVA = "0x3F7AC0", Offset = "0x3F6CC0", VA = "0x1803F7AC0")]
	private Task ProcessRemoveFriendCommandAsync(string args)
	{
		return null;
	}

	// Token: 0x060006BD RID: 1725 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006BD")]
	[Address(RVA = "0x3F8090", Offset = "0x3F7290", VA = "0x1803F8090")]
	private void Update()
	{
	}

	// Token: 0x060006BE RID: 1726 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006BE")]
	[Address(RVA = "0x3F80B0", Offset = "0x3F72B0", VA = "0x1803F80B0")]
	public RoninGameService()
	{
	}

	// Token: 0x040006AF RID: 1711
	[Token(Token = "0x40006AF")]
	[FieldOffset(Offset = "0x0")]
	private static Thread s_mainThread;

	// Token: 0x040006B0 RID: 1712
	[Token(Token = "0x40006B0")]
	[FieldOffset(Offset = "0x20")]
	public World World;

	// Token: 0x040006B1 RID: 1713
	[Token(Token = "0x40006B1")]
	[FieldOffset(Offset = "0x28")]
	private readonly ZeroUnityLogger _logger;
}
