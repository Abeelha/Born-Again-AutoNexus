using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200019E RID: 414
[Token(Token = "0x200019E")]
public class ActiveImage : MonoBehaviour
{
	// Token: 0x06000866 RID: 2150 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000866")]
	[Address(RVA = "0x4053D0", Offset = "0x4045D0", VA = "0x1804053D0")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000867 RID: 2151 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000867")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public ActiveImage()
	{
	}

	// Token: 0x04000829 RID: 2089
	[Token(Token = "0x4000829")]
	[FieldOffset(Offset = "0x20")]
	public GameObject Target;

	// Token: 0x0400082A RID: 2090
	[Token(Token = "0x400082A")]
	[FieldOffset(Offset = "0x28")]
	public Image Image;

	// Token: 0x0400082B RID: 2091
	[Token(Token = "0x400082B")]
	[FieldOffset(Offset = "0x30")]
	public Sprite ActiveSprite;

	// Token: 0x0400082C RID: 2092
	[Token(Token = "0x400082C")]
	[FieldOffset(Offset = "0x38")]
	private Sprite _defaultSprite;

	// Token: 0x0400082D RID: 2093
	[Token(Token = "0x400082D")]
	[FieldOffset(Offset = "0x40")]
	private bool _active;
}
