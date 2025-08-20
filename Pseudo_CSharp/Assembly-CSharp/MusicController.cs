using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200013A RID: 314
[Token(Token = "0x200013A")]
public class MusicController : MonoBehaviour
{
	// Token: 0x17000063 RID: 99
	// (get) Token: 0x0600057C RID: 1404 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x17000063")]
	public MusicSet CurrentSet
	{
		[Token(Token = "0x600057C")]
		[Address(RVA = "0x3F0E20", Offset = "0x3F0020", VA = "0x1803F0E20")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600057D RID: 1405 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600057D")]
	[Address(RVA = "0x3F0B50", Offset = "0x3EFD50", VA = "0x1803F0B50")]
	public void Play(MusicSet musicSet, bool immediate = true)
	{
	}

	// Token: 0x0600057E RID: 1406 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600057E")]
	[Address(RVA = "0x3F0DC0", Offset = "0x3EFFC0", VA = "0x1803F0DC0")]
	public void UpdateDangerLevel(int level, bool immediate = false)
	{
	}

	// Token: 0x0600057F RID: 1407 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600057F")]
	[Address(RVA = "0x3F0AD0", Offset = "0x3EFCD0", VA = "0x1803F0AD0")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000580 RID: 1408 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000580")]
	[Address(RVA = "0x3F0BD0", Offset = "0x3EFDD0", VA = "0x1803F0BD0")]
	private void SetMusic(MusicSet musicSet, bool fade)
	{
	}

	// Token: 0x06000581 RID: 1409 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000581")]
	[Address(RVA = "0x3F0BA0", Offset = "0x3EFDA0", VA = "0x1803F0BA0")]
	private void SetDangerLevel(int level)
	{
	}

	// Token: 0x06000582 RID: 1410 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000582")]
	[Address(RVA = "0x3F0E10", Offset = "0x3F0010", VA = "0x1803F0E10")]
	public MusicController()
	{
	}

	// Token: 0x040005F6 RID: 1526
	[Token(Token = "0x40005F6")]
	[FieldOffset(Offset = "0x20")]
	public MusicPlayer MainPlayer;

	// Token: 0x040005F7 RID: 1527
	[Token(Token = "0x40005F7")]
	[FieldOffset(Offset = "0x28")]
	public MusicPlayer TransitionPlayer;

	// Token: 0x040005F8 RID: 1528
	[Token(Token = "0x40005F8")]
	[FieldOffset(Offset = "0x30")]
	public float TransitionTime;

	// Token: 0x040005F9 RID: 1529
	[Token(Token = "0x40005F9")]
	[FieldOffset(Offset = "0x34")]
	private float _queueTime;

	// Token: 0x040005FA RID: 1530
	[Token(Token = "0x40005FA")]
	[FieldOffset(Offset = "0x38")]
	private MusicSet _queuedSet;

	// Token: 0x040005FB RID: 1531
	[Token(Token = "0x40005FB")]
	[FieldOffset(Offset = "0x40")]
	private int _queuedLevel;
}
