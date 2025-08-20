using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020002B6 RID: 694
[Token(Token = "0x20002B6")]
public class LowHealthGradient : MonoBehaviour
{
	// Token: 0x06000EE3 RID: 3811 RVA: 0x00005FE8 File Offset: 0x000041E8
	[Token(Token = "0x6000EE3")]
	[Address(RVA = "0x46BCE0", Offset = "0x46AEE0", VA = "0x18046BCE0")]
	private bool IsLow()
	{
		return default(bool);
	}

	// Token: 0x06000EE4 RID: 3812 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EE4")]
	[Address(RVA = "0x46BDE0", Offset = "0x46AFE0", VA = "0x18046BDE0")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000EE5 RID: 3813 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EE5")]
	[Address(RVA = "0x46BDF0", Offset = "0x46AFF0", VA = "0x18046BDF0")]
	private void UpdateAlpha()
	{
	}

	// Token: 0x06000EE6 RID: 3814 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EE6")]
	[Address(RVA = "0x46C010", Offset = "0x46B210", VA = "0x18046C010")]
	public LowHealthGradient()
	{
	}

	// Token: 0x04000C42 RID: 3138
	[Token(Token = "0x4000C42")]
	[FieldOffset(Offset = "0x20")]
	public Image Image;

	// Token: 0x04000C43 RID: 3139
	[Token(Token = "0x4000C43")]
	[FieldOffset(Offset = "0x28")]
	public World World;

	// Token: 0x04000C44 RID: 3140
	[Token(Token = "0x4000C44")]
	[FieldOffset(Offset = "0x30")]
	public float AlphaSpeed;

	// Token: 0x04000C45 RID: 3141
	[Token(Token = "0x4000C45")]
	[FieldOffset(Offset = "0x34")]
	public float MaxAlpha;

	// Token: 0x04000C46 RID: 3142
	[Token(Token = "0x4000C46")]
	[FieldOffset(Offset = "0x38")]
	private float _timeOffset;
}
