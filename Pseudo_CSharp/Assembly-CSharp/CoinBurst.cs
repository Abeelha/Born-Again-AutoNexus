using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002A0 RID: 672
[Token(Token = "0x20002A0")]
public class CoinBurst : MonoBehaviour
{
	// Token: 0x06000E6B RID: 3691 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E6B")]
	[Address(RVA = "0x463F20", Offset = "0x463120", VA = "0x180463F20")]
	public void Play(int bountyIndex)
	{
	}

	// Token: 0x06000E6C RID: 3692 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E6C")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public CoinBurst()
	{
	}

	// Token: 0x04000BAF RID: 2991
	[Token(Token = "0x4000BAF")]
	[FieldOffset(Offset = "0x20")]
	public GameObject[] Coins;

	// Token: 0x04000BB0 RID: 2992
	[Token(Token = "0x4000BB0")]
	[FieldOffset(Offset = "0x28")]
	public SpriteAnimation Animation;
}
