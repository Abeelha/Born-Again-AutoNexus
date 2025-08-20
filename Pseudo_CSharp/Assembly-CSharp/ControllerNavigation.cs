using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000197 RID: 407
[Token(Token = "0x2000197")]
public struct ControllerNavigation
{
	// Token: 0x06000842 RID: 2114 RVA: 0x00004110 File Offset: 0x00002310
	[Token(Token = "0x6000842")]
	[Address(RVA = "0x40D4A0", Offset = "0x40C6A0", VA = "0x18040D4A0")]
	public bool GetBack()
	{
		return default(bool);
	}

	// Token: 0x06000843 RID: 2115 RVA: 0x00004128 File Offset: 0x00002328
	[Token(Token = "0x6000843")]
	[Address(RVA = "0x40D660", Offset = "0x40C860", VA = "0x18040D660")]
	public Vector2Int GetDelta(bool stick = true, bool dpad = true)
	{
		return default(Vector2Int);
	}

	// Token: 0x06000844 RID: 2116 RVA: 0x00004140 File Offset: 0x00002340
	[Token(Token = "0x6000844")]
	[Address(RVA = "0x40D870", Offset = "0x40CA70", VA = "0x18040D870")]
	public bool GetSelect()
	{
		return default(bool);
	}

	// Token: 0x06000845 RID: 2117 RVA: 0x00004158 File Offset: 0x00002358
	[Token(Token = "0x6000845")]
	[Address(RVA = "0x40D330", Offset = "0x40C530", VA = "0x18040D330")]
	private static Vector2Int GetActiveDelta(bool stick, bool dpad)
	{
		return default(Vector2Int);
	}

	// Token: 0x06000846 RID: 2118 RVA: 0x00004170 File Offset: 0x00002370
	[Token(Token = "0x6000846")]
	[Address(RVA = "0x40D500", Offset = "0x40C700", VA = "0x18040D500")]
	private static Vector2Int GetDeltaDpad()
	{
		return default(Vector2Int);
	}

	// Token: 0x06000847 RID: 2119 RVA: 0x00004188 File Offset: 0x00002388
	[Token(Token = "0x6000847")]
	[Address(RVA = "0x40D5B0", Offset = "0x40C7B0", VA = "0x18040D5B0")]
	private static Vector2Int GetDeltaStick()
	{
		return default(Vector2Int);
	}

	// Token: 0x0400080B RID: 2059
	[Token(Token = "0x400080B")]
	[FieldOffset(Offset = "0x0")]
	private float _lastPulse;

	// Token: 0x0400080C RID: 2060
	[Token(Token = "0x400080C")]
	[FieldOffset(Offset = "0x4")]
	private float _startTime;

	// Token: 0x0400080D RID: 2061
	[Token(Token = "0x400080D")]
	[FieldOffset(Offset = "0x8")]
	private Vector2Int _lastDelta;

	// Token: 0x0400080E RID: 2062
	[Token(Token = "0x400080E")]
	[FieldOffset(Offset = "0x10")]
	private bool _selectState;

	// Token: 0x0400080F RID: 2063
	[Token(Token = "0x400080F")]
	[FieldOffset(Offset = "0x11")]
	private bool _backState;
}
