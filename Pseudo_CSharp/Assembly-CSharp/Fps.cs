using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200001F RID: 31
[Token(Token = "0x200001F")]
public class Fps : MonoBehaviour
{
	// Token: 0x060000C4 RID: 196 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x327B10", Offset = "0x326D10", VA = "0x180327B10")]
	private void Awake()
	{
	}

	// Token: 0x060000C5 RID: 197 RVA: 0x00002430 File Offset: 0x00000630
	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x327C40", Offset = "0x326E40", VA = "0x180327C40")]
	private int GetTargetFps(FpsStyle fpsStyle)
	{
		return 0;
	}

	// Token: 0x060000C6 RID: 198 RVA: 0x00002448 File Offset: 0x00000648
	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x327C70", Offset = "0x326E70", VA = "0x180327C70")]
	private int GetVSyncCount(FpsStyle fpsStyle)
	{
		return 0;
	}

	// Token: 0x060000C7 RID: 199 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x327C80", Offset = "0x326E80", VA = "0x180327C80")]
	private void OnDestroy()
	{
	}

	// Token: 0x060000C8 RID: 200 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x327D50", Offset = "0x326F50", VA = "0x180327D50")]
	private void OnOptionChanged(Option option)
	{
	}

	// Token: 0x060000C9 RID: 201 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x327D60", Offset = "0x326F60", VA = "0x180327D60")]
	private void SetOptionValues()
	{
	}

	// Token: 0x060000CA RID: 202 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public Fps()
	{
	}

	// Token: 0x040000A5 RID: 165
	[Token(Token = "0x40000A5")]
	[FieldOffset(Offset = "0x20")]
	private Option _targetFpsOption;

	// Token: 0x040000A6 RID: 166
	[Token(Token = "0x40000A6")]
	[FieldOffset(Offset = "0x28")]
	private Option _fpsStyleOption;
}
