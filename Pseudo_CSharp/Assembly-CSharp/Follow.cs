using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000341 RID: 833
[Token(Token = "0x2000341")]
public class Follow : MonoBehaviour
{
	// Token: 0x06001263 RID: 4707 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001263")]
	[Address(RVA = "0x37BBD0", Offset = "0x37ADD0", VA = "0x18037BBD0")]
	public void SetTarget(Transform target)
	{
	}

	// Token: 0x06001264 RID: 4708 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001264")]
	[Address(RVA = "0x37BA00", Offset = "0x37AC00", VA = "0x18037BA00")]
	private void Awake()
	{
	}

	// Token: 0x06001265 RID: 4709 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001265")]
	[Address(RVA = "0x37BB00", Offset = "0x37AD00", VA = "0x18037BB00")]
	private void OnDestroy()
	{
	}

	// Token: 0x06001266 RID: 4710 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001266")]
	[Address(RVA = "0x37BBA0", Offset = "0x37ADA0", VA = "0x18037BBA0")]
	private void OnEnable()
	{
	}

	// Token: 0x06001267 RID: 4711 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001267")]
	[Address(RVA = "0x37BBC0", Offset = "0x37ADC0", VA = "0x18037BBC0")]
	private void OnGuiFollowStyleChanged(Option option)
	{
	}

	// Token: 0x06001268 RID: 4712 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001268")]
	[Address(RVA = "0x37BAE0", Offset = "0x37ACE0", VA = "0x18037BAE0")]
	private void LateUpdate()
	{
	}

	// Token: 0x06001269 RID: 4713 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001269")]
	[Address(RVA = "0x37BC00", Offset = "0x37AE00", VA = "0x18037BC00")]
	private void UpdatePosition(bool lerp)
	{
	}

	// Token: 0x0600126A RID: 4714 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600126A")]
	[Address(RVA = "0x37BEF0", Offset = "0x37B0F0", VA = "0x18037BEF0")]
	public Follow()
	{
	}

	// Token: 0x04000F11 RID: 3857
	[Token(Token = "0x4000F11")]
	[FieldOffset(Offset = "0x20")]
	public Transform Target;

	// Token: 0x04000F12 RID: 3858
	[Token(Token = "0x4000F12")]
	[FieldOffset(Offset = "0x28")]
	public Vector3 PositionMask;

	// Token: 0x04000F13 RID: 3859
	[Token(Token = "0x4000F13")]
	[FieldOffset(Offset = "0x34")]
	public Vector3 PositionOffset;

	// Token: 0x04000F14 RID: 3860
	[Token(Token = "0x4000F14")]
	[FieldOffset(Offset = "0x40")]
	public bool Lerp;

	// Token: 0x04000F15 RID: 3861
	[Token(Token = "0x4000F15")]
	[FieldOffset(Offset = "0x44")]
	public float LerpScalar;

	// Token: 0x04000F16 RID: 3862
	[Token(Token = "0x4000F16")]
	[FieldOffset(Offset = "0x48")]
	public bool IsGUI;

	// Token: 0x04000F17 RID: 3863
	[Token(Token = "0x4000F17")]
	[FieldOffset(Offset = "0x4C")]
	private Vector3 _targetPosition;

	// Token: 0x04000F18 RID: 3864
	[Token(Token = "0x4000F18")]
	[FieldOffset(Offset = "0x58")]
	private Option _guiFollowStyleOption;

	// Token: 0x04000F19 RID: 3865
	[Token(Token = "0x4000F19")]
	[FieldOffset(Offset = "0x60")]
	private bool _didEnable;
}
