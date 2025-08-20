using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200019C RID: 412
[Token(Token = "0x200019C")]
public struct KeyRepeater
{
	// Token: 0x06000861 RID: 2145 RVA: 0x00004230 File Offset: 0x00002430
	[Token(Token = "0x6000861")]
	[Address(RVA = "0x414C20", Offset = "0x413E20", VA = "0x180414C20")]
	public bool GetPulse(KeyCode keyCode)
	{
		return default(bool);
	}

	// Token: 0x04000826 RID: 2086
	[Token(Token = "0x4000826")]
	[FieldOffset(Offset = "0x0")]
	private float _lastPulse;

	// Token: 0x04000827 RID: 2087
	[Token(Token = "0x4000827")]
	[FieldOffset(Offset = "0x4")]
	private float _startTime;

	// Token: 0x04000828 RID: 2088
	[Token(Token = "0x4000828")]
	[FieldOffset(Offset = "0x8")]
	private bool _lastDown;
}
