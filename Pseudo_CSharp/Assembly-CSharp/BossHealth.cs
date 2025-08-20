using System;
using Il2CppDummyDll;
using Ronin.Model.Simulation.Components;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000298 RID: 664
[Token(Token = "0x2000298")]
public class BossHealth : MonoBehaviour
{
	// Token: 0x06000E46 RID: 3654 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E46")]
	[Address(RVA = "0x44F100", Offset = "0x44E300", VA = "0x18044F100")]
	public void SetBoss(Entity entity)
	{
	}

	// Token: 0x06000E47 RID: 3655 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E47")]
	[Address(RVA = "0x44F150", Offset = "0x44E350", VA = "0x18044F150")]
	public void UpdateBoss(Entity boss)
	{
	}

	// Token: 0x06000E48 RID: 3656 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000E48")]
	[Address(RVA = "0x44F060", Offset = "0x44E260", VA = "0x18044F060")]
	private Sprite GetContainerSprite(ref EntityState state)
	{
		return null;
	}

	// Token: 0x06000E49 RID: 3657 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E49")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public BossHealth()
	{
	}

	// Token: 0x04000B87 RID: 2951
	[Token(Token = "0x4000B87")]
	[FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI Name;

	// Token: 0x04000B88 RID: 2952
	[Token(Token = "0x4000B88")]
	[FieldOffset(Offset = "0x28")]
	public Image Container;

	// Token: 0x04000B89 RID: 2953
	[Token(Token = "0x4000B89")]
	[FieldOffset(Offset = "0x30")]
	public Image ArmorContainer;

	// Token: 0x04000B8A RID: 2954
	[Token(Token = "0x4000B8A")]
	[FieldOffset(Offset = "0x38")]
	public RectTransform HealthBar;

	// Token: 0x04000B8B RID: 2955
	[Token(Token = "0x4000B8B")]
	[FieldOffset(Offset = "0x40")]
	public RectTransform LootBar;

	// Token: 0x04000B8C RID: 2956
	[Token(Token = "0x4000B8C")]
	[FieldOffset(Offset = "0x48")]
	public RectTransform ArmorBar;

	// Token: 0x04000B8D RID: 2957
	[Token(Token = "0x4000B8D")]
	[FieldOffset(Offset = "0x50")]
	public TextMeshProUGUI LootPercent;

	// Token: 0x04000B8E RID: 2958
	[Token(Token = "0x4000B8E")]
	[FieldOffset(Offset = "0x58")]
	public Sprite NormalContainer;

	// Token: 0x04000B8F RID: 2959
	[Token(Token = "0x4000B8F")]
	[FieldOffset(Offset = "0x60")]
	public Sprite InvulnerableContainer;

	// Token: 0x04000B90 RID: 2960
	[Token(Token = "0x4000B90")]
	[FieldOffset(Offset = "0x68")]
	public Sprite ArmorNormalContainer;

	// Token: 0x04000B91 RID: 2961
	[Token(Token = "0x4000B91")]
	[FieldOffset(Offset = "0x70")]
	public Sprite ArmorVulnerableContainer;

	// Token: 0x04000B92 RID: 2962
	[Token(Token = "0x4000B92")]
	[FieldOffset(Offset = "0x78")]
	private int _rewardShare;
}
