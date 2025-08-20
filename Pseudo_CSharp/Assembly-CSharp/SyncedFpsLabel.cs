using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x0200003B RID: 59
[Token(Token = "0x200003B")]
public class SyncedFpsLabel : MonoBehaviour
{
	// Token: 0x06000136 RID: 310 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000136")]
	[Address(RVA = "0x3293A0", Offset = "0x3285A0", VA = "0x1803293A0")]
	private void Awake()
	{
	}

	// Token: 0x06000137 RID: 311 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000137")]
	[Address(RVA = "0x329430", Offset = "0x328630", VA = "0x180329430")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000138 RID: 312 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000138")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public SyncedFpsLabel()
	{
	}

	// Token: 0x04000115 RID: 277
	[Token(Token = "0x4000115")]
	[FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI Label;

	// Token: 0x04000116 RID: 278
	[Token(Token = "0x4000116")]
	[FieldOffset(Offset = "0x28")]
	private int _syncedFps;
}
