using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000043 RID: 67
[Token(Token = "0x2000043")]
public class Dispatcher : MonoBehaviour
{
	// Token: 0x0600015E RID: 350 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600015E")]
	[Address(RVA = "0x31FF60", Offset = "0x31F160", VA = "0x18031FF60")]
	public static TaskCompletionSource<bool> RunOnMainThread(Action action)
	{
		return null;
	}

	// Token: 0x0600015F RID: 351 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600015F")]
	[Address(RVA = "0x320250", Offset = "0x31F450", VA = "0x180320250")]
	private void Update()
	{
	}

	// Token: 0x06000160 RID: 352 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000160")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public Dispatcher()
	{
	}

	// Token: 0x04000137 RID: 311
	[Token(Token = "0x4000137")]
	[FieldOffset(Offset = "0x0")]
	private static List<ValueTuple<Action, TaskCompletionSource<bool>>> _actions;

	// Token: 0x04000138 RID: 312
	[Token(Token = "0x4000138")]
	[FieldOffset(Offset = "0x8")]
	private static List<ValueTuple<Action, TaskCompletionSource<bool>>> _actionsOld;

	// Token: 0x04000139 RID: 313
	[Token(Token = "0x4000139")]
	[FieldOffset(Offset = "0x10")]
	private static readonly object _actionLock;

	// Token: 0x0400013A RID: 314
	[Token(Token = "0x400013A")]
	[FieldOffset(Offset = "0x18")]
	private static int _mainThreadId;
}
