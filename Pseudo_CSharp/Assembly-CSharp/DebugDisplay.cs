using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x020001D3 RID: 467
[Token(Token = "0x20001D3")]
public class DebugDisplay : MonoBehaviour
{
	// Token: 0x06000963 RID: 2403 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000963")]
	[Address(RVA = "0x424270", Offset = "0x423470", VA = "0x180424270")]
	private void Awake()
	{
	}

	// Token: 0x06000964 RID: 2404 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000964")]
	[Address(RVA = "0x424680", Offset = "0x423880", VA = "0x180424680")]
	private void OnChange(Option obj)
	{
	}

	// Token: 0x06000965 RID: 2405 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000965")]
	[Address(RVA = "0x4246C0", Offset = "0x4238C0", VA = "0x1804246C0")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000966 RID: 2406 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000966")]
	[Address(RVA = "0x424750", Offset = "0x423950", VA = "0x180424750")]
	private void OnEnable()
	{
	}

	// Token: 0x06000967 RID: 2407 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000967")]
	[Address(RVA = "0x424360", Offset = "0x423560", VA = "0x180424360")]
	private void FixedUpdate()
	{
	}

	// Token: 0x06000968 RID: 2408 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000968")]
	[Address(RVA = "0x424520", Offset = "0x423720", VA = "0x180424520")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000969 RID: 2409 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000969")]
	[Address(RVA = "0x424520", Offset = "0x423720", VA = "0x180424520")]
	private void UpdateText()
	{
	}

	// Token: 0x0600096A RID: 2410 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600096A")]
	[Address(RVA = "0x4247A0", Offset = "0x4239A0", VA = "0x1804247A0")]
	public DebugDisplay()
	{
	}

	// Token: 0x040008E4 RID: 2276
	[Token(Token = "0x40008E4")]
	[FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI Label;

	// Token: 0x040008E5 RID: 2277
	[Token(Token = "0x40008E5")]
	[FieldOffset(Offset = "0x28")]
	public RoninGameService GameService;

	// Token: 0x040008E6 RID: 2278
	[Token(Token = "0x40008E6")]
	[FieldOffset(Offset = "0x30")]
	private readonly List<int> _latencies;

	// Token: 0x040008E7 RID: 2279
	[Token(Token = "0x40008E7")]
	[FieldOffset(Offset = "0x38")]
	private int _averageLatency;

	// Token: 0x040008E8 RID: 2280
	[Token(Token = "0x40008E8")]
	[FieldOffset(Offset = "0x40")]
	private Option _debugStatsOption;
}
