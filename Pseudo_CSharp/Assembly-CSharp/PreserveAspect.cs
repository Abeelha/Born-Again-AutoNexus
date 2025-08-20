using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001A5 RID: 421
[Token(Token = "0x20001A5")]
[RequireComponent(typeof(RectTransform))]
[ExecuteAlways]
public class PreserveAspect : MonoBehaviour
{
	// Token: 0x170000D2 RID: 210
	// (get) Token: 0x06000880 RID: 2176 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x170000D2")]
	private RectTransform RectTransform
	{
		[Token(Token = "0x6000880")]
		[Address(RVA = "0x4199B0", Offset = "0x418BB0", VA = "0x1804199B0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000881 RID: 2177 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000881")]
	[Address(RVA = "0x4197B0", Offset = "0x4189B0", VA = "0x1804197B0")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000882 RID: 2178 RVA: 0x00004278 File Offset: 0x00002478
	[Token(Token = "0x6000882")]
	[Address(RVA = "0x419780", Offset = "0x418980", VA = "0x180419780")]
	private float GetTargetDimension(Vector2 vector)
	{
		return 0f;
	}

	// Token: 0x06000883 RID: 2179 RVA: 0x00004290 File Offset: 0x00002490
	[Token(Token = "0x6000883")]
	[Address(RVA = "0x4197C0", Offset = "0x4189C0", VA = "0x1804197C0")]
	private Vector2 SetFollowingDimension(Vector2 vector, float value)
	{
		return default(Vector2);
	}

	// Token: 0x06000884 RID: 2180 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000884")]
	[Address(RVA = "0x4197F0", Offset = "0x4189F0", VA = "0x1804197F0")]
	private void SizeTo()
	{
	}

	// Token: 0x06000885 RID: 2181 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000885")]
	[Address(RVA = "0x419990", Offset = "0x418B90", VA = "0x180419990")]
	public PreserveAspect()
	{
	}

	// Token: 0x04000841 RID: 2113
	[Token(Token = "0x4000841")]
	[FieldOffset(Offset = "0x20")]
	public float Aspect;

	// Token: 0x04000842 RID: 2114
	[Token(Token = "0x4000842")]
	[FieldOffset(Offset = "0x24")]
	public Dimension TargetDimension;
}
