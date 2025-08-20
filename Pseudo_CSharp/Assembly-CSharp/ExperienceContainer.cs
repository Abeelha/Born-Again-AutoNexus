using System;
using Il2CppDummyDll;
using Ronin.Model.Data;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020002B2 RID: 690
[Token(Token = "0x20002B2")]
public class ExperienceContainer : MonoBehaviour
{
	// Token: 0x06000ECF RID: 3791 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000ECF")]
	[Address(RVA = "0x46AEB0", Offset = "0x46A0B0", VA = "0x18046AEB0")]
	public void LanguageChanged()
	{
	}

	// Token: 0x06000ED0 RID: 3792 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000ED0")]
	[Address(RVA = "0x46AF00", Offset = "0x46A100", VA = "0x18046AF00")]
	public void SetExperience(int level, ulong experience, ulong honor, BlessingsData blessings, bool force = false)
	{
	}

	// Token: 0x06000ED1 RID: 3793 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000ED1")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public ExperienceContainer()
	{
	}

	// Token: 0x04000C2F RID: 3119
	[Token(Token = "0x4000C2F")]
	[FieldOffset(Offset = "0x20")]
	public int Level;

	// Token: 0x04000C30 RID: 3120
	[Token(Token = "0x4000C30")]
	[FieldOffset(Offset = "0x28")]
	public ulong Experience;

	// Token: 0x04000C31 RID: 3121
	[Token(Token = "0x4000C31")]
	[FieldOffset(Offset = "0x30")]
	public ulong Honor;

	// Token: 0x04000C32 RID: 3122
	[Token(Token = "0x4000C32")]
	[FieldOffset(Offset = "0x38")]
	private BlessingsData _blessings;

	// Token: 0x04000C33 RID: 3123
	[Token(Token = "0x4000C33")]
	[FieldOffset(Offset = "0x50")]
	public TextMeshProUGUI LevelLabel;

	// Token: 0x04000C34 RID: 3124
	[Token(Token = "0x4000C34")]
	[FieldOffset(Offset = "0x58")]
	public Image Fill;

	// Token: 0x04000C35 RID: 3125
	[Token(Token = "0x4000C35")]
	[FieldOffset(Offset = "0x60")]
	public Color LevelingColor;

	// Token: 0x04000C36 RID: 3126
	[Token(Token = "0x4000C36")]
	[FieldOffset(Offset = "0x70")]
	public Color HonorColor;
}
