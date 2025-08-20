using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001EA RID: 490
[Token(Token = "0x20001EA")]
public class MovementAngleIndicator : MonoBehaviour
{
	// Token: 0x06000A1A RID: 2586 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A1A")]
	[Address(RVA = "0x42AEE0", Offset = "0x42A0E0", VA = "0x18042AEE0")]
	public void SetTarget(Transform target)
	{
	}

	// Token: 0x06000A1B RID: 2587 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A1B")]
	[Address(RVA = "0x42AE70", Offset = "0x42A070", VA = "0x18042AE70")]
	private void Awake()
	{
	}

	// Token: 0x06000A1C RID: 2588 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A1C")]
	[Address(RVA = "0x42AED0", Offset = "0x42A0D0", VA = "0x18042AED0")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000A1D RID: 2589 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A1D")]
	[Address(RVA = "0x42AF90", Offset = "0x42A190", VA = "0x18042AF90")]
	private void UpdatePositions()
	{
	}

	// Token: 0x06000A1E RID: 2590 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A1E")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public MovementAngleIndicator()
	{
	}

	// Token: 0x04000961 RID: 2401
	[Token(Token = "0x4000961")]
	[FieldOffset(Offset = "0x20")]
	public ControlManager ControlManager;

	// Token: 0x04000962 RID: 2402
	[Token(Token = "0x4000962")]
	[FieldOffset(Offset = "0x28")]
	public Transform Shaft;

	// Token: 0x04000963 RID: 2403
	[Token(Token = "0x4000963")]
	[FieldOffset(Offset = "0x30")]
	public Transform Circle;

	// Token: 0x04000964 RID: 2404
	[Token(Token = "0x4000964")]
	[FieldOffset(Offset = "0x38")]
	public Follow Follow;

	// Token: 0x04000965 RID: 2405
	[Token(Token = "0x4000965")]
	[FieldOffset(Offset = "0x40")]
	public Camera Camera;

	// Token: 0x04000966 RID: 2406
	[Token(Token = "0x4000966")]
	[FieldOffset(Offset = "0x48")]
	private Option _movementIndicatorOption;
}
