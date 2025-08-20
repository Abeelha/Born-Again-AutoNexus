using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001C5 RID: 453
[Token(Token = "0x20001C5")]
public class KeybindSetter : MonoBehaviour
{
	// Token: 0x170000E4 RID: 228
	// (get) Token: 0x06000924 RID: 2340 RVA: 0x000044E8 File Offset: 0x000026E8
	[Token(Token = "0x170000E4")]
	public static bool Active
	{
		[Token(Token = "0x6000924")]
		[Address(RVA = "0x4158D0", Offset = "0x414AD0", VA = "0x1804158D0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000926 RID: 2342 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000926")]
	[Address(RVA = "0x415140", Offset = "0x414340", VA = "0x180415140")]
	public static Task<KeyCode?> GetKeyAsync([Optional] KeyCode[] allowedKeys)
	{
		return null;
	}

	// Token: 0x06000927 RID: 2343 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000927")]
	[Address(RVA = "0x414FB0", Offset = "0x4141B0", VA = "0x180414FB0")]
	public void Cancel()
	{
	}

	// Token: 0x06000928 RID: 2344 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000928")]
	[Address(RVA = "0x415020", Offset = "0x414220", VA = "0x180415020")]
	public Task<KeyCode?> GetAsync([Optional] KeyCode[] allowedKeys)
	{
		return null;
	}

	// Token: 0x06000929 RID: 2345 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000929")]
	[Address(RVA = "0x357300", Offset = "0x356500", VA = "0x180357300")]
	private void Hide()
	{
	}

	// Token: 0x0600092A RID: 2346 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600092A")]
	[Address(RVA = "0x4153E0", Offset = "0x4145E0", VA = "0x1804153E0")]
	private void LateUpdate()
	{
	}

	// Token: 0x0600092B RID: 2347 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600092B")]
	[Address(RVA = "0x4154D0", Offset = "0x4146D0", VA = "0x1804154D0")]
	private void OnDestroy()
	{
	}

	// Token: 0x0600092C RID: 2348 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600092C")]
	[Address(RVA = "0x4155B0", Offset = "0x4147B0", VA = "0x1804155B0")]
	private void ReturnKey(KeyCode keyCode)
	{
	}

	// Token: 0x0600092D RID: 2349 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600092D")]
	[Address(RVA = "0x4153E0", Offset = "0x4145E0", VA = "0x1804153E0")]
	private void UpdateKeyListener()
	{
	}

	// Token: 0x0600092E RID: 2350 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600092E")]
	[Address(RVA = "0x415820", Offset = "0x414A20", VA = "0x180415820")]
	public KeybindSetter()
	{
	}

	// Token: 0x040008BE RID: 2238
	[Token(Token = "0x40008BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly KeyCode[] s_allKeys;

	// Token: 0x040008BF RID: 2239
	[Token(Token = "0x40008BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static KeybindSetter s_instance;

	// Token: 0x040008C0 RID: 2240
	[Token(Token = "0x40008C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private TaskCompletionSource<KeyCode?> _keyCompletionSource;

	// Token: 0x040008C1 RID: 2241
	[Token(Token = "0x40008C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private KeyCode[] _allowedKeys;
}
