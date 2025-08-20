using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using Steamworks;
using UnityEngine;
using UnnamedStudios.Common.Model;

// Token: 0x02000172 RID: 370
[Token(Token = "0x2000172")]
public class SteamController : MonoBehaviour
{
	// Token: 0x06000745 RID: 1861 RVA: 0x00003C90 File Offset: 0x00001E90
	[Token(Token = "0x6000745")]
	[Address(RVA = "0x3FD160", Offset = "0x3FC360", VA = "0x1803FD160")]
	public bool Init()
	{
		return default(bool);
	}

	// Token: 0x06000746 RID: 1862 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000746")]
	[Address(RVA = "0x3FD290", Offset = "0x3FC490", VA = "0x1803FD290")]
	private static List<SteamController.SteamPurchase> LoadPurchases()
	{
		return null;
	}

	// Token: 0x06000747 RID: 1863 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000747")]
	[Address(RVA = "0x3FD550", Offset = "0x3FC750", VA = "0x1803FD550")]
	private static void SavePurchases(List<SteamController.SteamPurchase> purchases)
	{
	}

	// Token: 0x06000748 RID: 1864 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000748")]
	[Address(RVA = "0x3FD3F0", Offset = "0x3FC5F0", VA = "0x1803FD3F0")]
	private void OnMtxAuthorizationResponse(AppId appId, ulong orderId, bool authorized)
	{
	}

	// Token: 0x06000749 RID: 1865 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000749")]
	[Address(RVA = "0x3FD390", Offset = "0x3FC590", VA = "0x1803FD390")]
	private void OnApplicationQuit()
	{
	}

	// Token: 0x0600074A RID: 1866 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600074A")]
	[Address(RVA = "0x3FD600", Offset = "0x3FC800", VA = "0x1803FD600")]
	private void Update()
	{
	}

	// Token: 0x0600074B RID: 1867 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600074B")]
	[Address(RVA = "0x3FD090", Offset = "0x3FC290", VA = "0x1803FD090")]
	private Task FinalizePurchasesAsync()
	{
		return null;
	}

	// Token: 0x0600074C RID: 1868 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600074C")]
	[Address(RVA = "0x3FCF60", Offset = "0x3FC160", VA = "0x1803FCF60")]
	private Task<bool> FinalizePurchaseAsync(ulong orderId, bool authorized)
	{
		return null;
	}

	// Token: 0x0600074D RID: 1869 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600074D")]
	[Address(RVA = "0x3FCCF0", Offset = "0x3FBEF0", VA = "0x1803FCCF0")]
	private void Awake()
	{
	}

	// Token: 0x0600074E RID: 1870 RVA: 0x00003CA8 File Offset: 0x00001EA8
	[Token(Token = "0x600074E")]
	[Address(RVA = "0x3FCE80", Offset = "0x3FC080", VA = "0x1803FCE80")]
	private bool Exists()
	{
		return default(bool);
	}

	// Token: 0x0600074F RID: 1871 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600074F")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public SteamController()
	{
	}

	// Token: 0x06000750 RID: 1872 RVA: 0x00003CC0 File Offset: 0x00001EC0
	[Token(Token = "0x6000750")]
	[Address(RVA = "0x3FD5C0", Offset = "0x3FC7C0", VA = "0x1803FD5C0")]
	[CompilerGenerated]
	internal static bool <FinalizePurchaseAsync>g__isRetryable|13_0(ServiceResponse serviceResponse, out bool largeDelay)
	{
		return default(bool);
	}

	// Token: 0x04000741 RID: 1857
	[Token(Token = "0x4000741")]
	private const string SavedTransactionKey = "_steam_saved_txn";

	// Token: 0x04000742 RID: 1858
	[Token(Token = "0x4000742")]
	[FieldOffset(Offset = "0x0")]
	public static SteamController Instance;

	// Token: 0x04000743 RID: 1859
	[Token(Token = "0x4000743")]
	[FieldOffset(Offset = "0x20")]
	public uint SteamId;

	// Token: 0x04000744 RID: 1860
	[Token(Token = "0x4000744")]
	[FieldOffset(Offset = "0x28")]
	public TaskCompletionSource<ValueTuple<ulong, bool>> MtxAuthorizationTask;

	// Token: 0x04000745 RID: 1861
	[Token(Token = "0x4000745")]
	[FieldOffset(Offset = "0x30")]
	private bool _initiated;

	// Token: 0x02000173 RID: 371
	[Token(Token = "0x2000173")]
	private struct SteamPurchase
	{
		// Token: 0x06000751 RID: 1873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000751")]
		[Address(RVA = "0x3FD660", Offset = "0x3FC860", VA = "0x1803FD660")]
		public SteamPurchase(ulong orderId, bool authorized)
		{
		}

		// Token: 0x04000746 RID: 1862
		[Token(Token = "0x4000746")]
		[FieldOffset(Offset = "0x0")]
		public ulong OrderId;

		// Token: 0x04000747 RID: 1863
		[Token(Token = "0x4000747")]
		[FieldOffset(Offset = "0x8")]
		public bool Authorized;
	}
}
