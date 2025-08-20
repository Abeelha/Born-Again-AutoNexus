using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200029D RID: 669
[Token(Token = "0x200029D")]
public class BountyRibbon : MonoBehaviour
{
	// Token: 0x1700019E RID: 414
	// (get) Token: 0x06000E57 RID: 3671 RVA: 0x00005E80 File Offset: 0x00004080
	// (set) Token: 0x06000E58 RID: 3672 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700019E")]
	public int BountyIndex
	{
		[Token(Token = "0x6000E57")]
		[Address(RVA = "0x394080", Offset = "0x393280", VA = "0x180394080")]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000E58")]
		[Address(RVA = "0x394090", Offset = "0x393290", VA = "0x180394090")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x06000E59 RID: 3673 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E59")]
	[Address(RVA = "0x450320", Offset = "0x44F520", VA = "0x180450320")]
	public void SetBounty(uint bounty)
	{
	}

	// Token: 0x06000E5A RID: 3674 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E5A")]
	[Address(RVA = "0x4501F0", Offset = "0x44F3F0", VA = "0x1804501F0")]
	public void SetBountyIndex(int index)
	{
	}

	// Token: 0x06000E5B RID: 3675 RVA: 0x00005E98 File Offset: 0x00004098
	[Token(Token = "0x6000E5B")]
	[Address(RVA = "0x450140", Offset = "0x44F340", VA = "0x180450140")]
	private int GetBountyIndex(uint bounty)
	{
		return 0;
	}

	// Token: 0x06000E5C RID: 3676 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E5C")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public BountyRibbon()
	{
	}

	// Token: 0x04000BA1 RID: 2977
	[Token(Token = "0x4000BA1")]
	[FieldOffset(Offset = "0x20")]
	public Image[] ProgressCoins;

	// Token: 0x04000BA2 RID: 2978
	[Token(Token = "0x4000BA2")]
	[FieldOffset(Offset = "0x28")]
	public Sprite[] CoinSprites;
}
