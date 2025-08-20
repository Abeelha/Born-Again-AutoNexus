using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200017B RID: 379
[Token(Token = "0x200017B")]
[RequireComponent(typeof(RectTransform))]
public class Float : MonoBehaviour
{
	// Token: 0x0600076F RID: 1903 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600076F")]
	[Address(RVA = "0x4111D0", Offset = "0x4103D0", VA = "0x1804111D0")]
	private void Awake()
	{
	}

	// Token: 0x06000770 RID: 1904 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000770")]
	[Address(RVA = "0x411230", Offset = "0x410430", VA = "0x180411230")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000771 RID: 1905 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000771")]
	[Address(RVA = "0x4072F0", Offset = "0x4064F0", VA = "0x1804072F0")]
	public Float()
	{
	}

	// Token: 0x04000773 RID: 1907
	[Token(Token = "0x4000773")]
	[FieldOffset(Offset = "0x20")]
	public float Scale;

	// Token: 0x04000774 RID: 1908
	[Token(Token = "0x4000774")]
	[FieldOffset(Offset = "0x24")]
	public bool RandomOffset;

	// Token: 0x04000775 RID: 1909
	[Token(Token = "0x4000775")]
	[FieldOffset(Offset = "0x25")]
	public bool Snap;

	// Token: 0x04000776 RID: 1910
	[Token(Token = "0x4000776")]
	[FieldOffset(Offset = "0x28")]
	private RectTransform _content;

	// Token: 0x04000777 RID: 1911
	[Token(Token = "0x4000777")]
	[FieldOffset(Offset = "0x30")]
	private Vector2 _offset;

	// Token: 0x04000778 RID: 1912
	[Token(Token = "0x4000778")]
	[FieldOffset(Offset = "0x38")]
	private float _random;
}
