using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000BC RID: 188
[Token(Token = "0x20000BC")]
public class Light : MonoBehaviour
{
	// Token: 0x06000338 RID: 824 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000338")]
	[Address(RVA = "0x3C60E0", Offset = "0x3C52E0", VA = "0x1803C60E0")]
	private void Awake()
	{
	}

	// Token: 0x06000339 RID: 825 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000339")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public Light()
	{
	}

	// Token: 0x04000323 RID: 803
	[Token(Token = "0x4000323")]
	[FieldOffset(Offset = "0x20")]
	public string Name;

	// Token: 0x04000324 RID: 804
	[Token(Token = "0x4000324")]
	[FieldOffset(Offset = "0x28")]
	public Follow Follow;

	// Token: 0x04000325 RID: 805
	[Token(Token = "0x4000325")]
	[FieldOffset(Offset = "0x30")]
	public SpriteRenderer Renderer;
}
