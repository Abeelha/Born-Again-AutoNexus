using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020002B3 RID: 691
[Token(Token = "0x20002B3")]
public class ExperienceOrbs : MonoBehaviour
{
	// Token: 0x170001A8 RID: 424
	// (get) Token: 0x06000ED2 RID: 3794 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x170001A8")]
	public RectTransform RectTransform
	{
		[Token(Token = "0x6000ED2")]
		[Address(RVA = "0x46B540", Offset = "0x46A740", VA = "0x18046B540")]
		get
		{
			return null;
		}
	}

	// Token: 0x170001A9 RID: 425
	// (get) Token: 0x06000ED3 RID: 3795 RVA: 0x00005FA0 File Offset: 0x000041A0
	// (set) Token: 0x06000ED4 RID: 3796 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001A9")]
	public int Level
	{
		[Token(Token = "0x6000ED3")]
		[Address(RVA = "0x46B530", Offset = "0x46A730", VA = "0x18046B530")]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000ED4")]
		[Address(RVA = "0x46B5A0", Offset = "0x46A7A0", VA = "0x18046B5A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x170001AA RID: 426
	// (get) Token: 0x06000ED5 RID: 3797 RVA: 0x00005FB8 File Offset: 0x000041B8
	// (set) Token: 0x06000ED6 RID: 3798 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001AA")]
	public ulong Exp
	{
		[Token(Token = "0x6000ED5")]
		[Address(RVA = "0x40CFC0", Offset = "0x40C1C0", VA = "0x18040CFC0")]
		[CompilerGenerated]
		get
		{
			return 0UL;
		}
		[Token(Token = "0x6000ED6")]
		[Address(RVA = "0x40CFF0", Offset = "0x40C1F0", VA = "0x18040CFF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x170001AB RID: 427
	// (get) Token: 0x06000ED7 RID: 3799 RVA: 0x00005FD0 File Offset: 0x000041D0
	// (set) Token: 0x06000ED8 RID: 3800 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001AB")]
	public ulong Honor
	{
		[Token(Token = "0x6000ED7")]
		[Address(RVA = "0x438730", Offset = "0x437930", VA = "0x180438730")]
		[CompilerGenerated]
		get
		{
			return 0UL;
		}
		[Token(Token = "0x6000ED8")]
		[Address(RVA = "0x438770", Offset = "0x437970", VA = "0x180438770")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x06000ED9 RID: 3801 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000ED9")]
	[Address(RVA = "0x46B260", Offset = "0x46A460", VA = "0x18046B260")]
	public void SetExperience(int level, ulong experience, ulong honor)
	{
	}

	// Token: 0x06000EDA RID: 3802 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EDA")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public ExperienceOrbs()
	{
	}

	// Token: 0x04000C37 RID: 3127
	[Token(Token = "0x4000C37")]
	[FieldOffset(Offset = "0x20")]
	public RectTransform PartialAnimation;

	// Token: 0x04000C38 RID: 3128
	[Token(Token = "0x4000C38")]
	[FieldOffset(Offset = "0x28")]
	public Image PartialFill;

	// Token: 0x04000C39 RID: 3129
	[Token(Token = "0x4000C39")]
	[FieldOffset(Offset = "0x30")]
	public TextMeshProUGUI OrbCount;

	// Token: 0x04000C3A RID: 3130
	[Token(Token = "0x4000C3A")]
	[FieldOffset(Offset = "0x38")]
	public TextMeshProUGUI HonorCount;
}
