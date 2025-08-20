using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200016A RID: 362
[Token(Token = "0x200016A")]
public class OnEnableSfx : MonoBehaviour
{
	// Token: 0x06000727 RID: 1831 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000727")]
	[Address(RVA = "0x3F1C80", Offset = "0x3F0E80", VA = "0x1803F1C80")]
	private void OnEnable()
	{
	}

	// Token: 0x06000728 RID: 1832 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000728")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public OnEnableSfx()
	{
	}

	// Token: 0x0400071B RID: 1819
	[Token(Token = "0x400071B")]
	[FieldOffset(Offset = "0x20")]
	public string Sfx;

	// Token: 0x0400071C RID: 1820
	[Token(Token = "0x400071C")]
	[FieldOffset(Offset = "0x28")]
	private SfxClip _sfxClip;
}
