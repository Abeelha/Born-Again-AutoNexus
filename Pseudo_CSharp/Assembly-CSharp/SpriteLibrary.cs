using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Ronin.Model.Enums;
using UnityEngine;

// Token: 0x020000B4 RID: 180
[Token(Token = "0x20000B4")]
public class SpriteLibrary : ScriptableObject, ILoadable
{
	// Token: 0x06000311 RID: 785 RVA: 0x000030F0 File Offset: 0x000012F0
	[Token(Token = "0x6000311")]
	[Address(RVA = "0x3435E0", Offset = "0x3427E0", VA = "0x1803435E0")]
	public SpriteLibrary.BlessingTheme GetBlessingTheme(ushort blessingType)
	{
		return default(SpriteLibrary.BlessingTheme);
	}

	// Token: 0x06000312 RID: 786 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000312")]
	[Address(RVA = "0x343770", Offset = "0x342970", VA = "0x180343770")]
	public Sprite GetRegion(RegionType type)
	{
		return null;
	}

	// Token: 0x06000313 RID: 787 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000313")]
	[Address(RVA = "0x3437F0", Offset = "0x3429F0", VA = "0x1803437F0")]
	public Sprite Get(string name)
	{
		return null;
	}

	// Token: 0x06000314 RID: 788 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000314")]
	[Address(RVA = "0x343870", Offset = "0x342A70", VA = "0x180343870")]
	public Sprite Get(StatusEffects type)
	{
		return null;
	}

	// Token: 0x06000315 RID: 789 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000315")]
	[Address(RVA = "0x343540", Offset = "0x342740", VA = "0x180343540")]
	public string GetBadge(BadgeType badge)
	{
		return null;
	}

	// Token: 0x06000316 RID: 790 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000316")]
	[Address(RVA = "0x3436E0", Offset = "0x3428E0", VA = "0x1803436E0")]
	public string GetRank(RankType rank)
	{
		return null;
	}

	// Token: 0x06000317 RID: 791 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000317")]
	[Address(RVA = "0x3439F0", Offset = "0x342BF0", VA = "0x1803439F0", Slot = "4")]
	public void Load()
	{
	}

	// Token: 0x06000318 RID: 792 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000318")]
	[Address(RVA = "0x343DB0", Offset = "0x342FB0", VA = "0x180343DB0")]
	public SpriteLibrary()
	{
	}

	// Token: 0x040002F9 RID: 761
	[Token(Token = "0x40002F9")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<RegionType, Sprite> s_regionSprites;

	// Token: 0x040002FA RID: 762
	[Token(Token = "0x40002FA")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<string, Sprite> s_sprites;

	// Token: 0x040002FB RID: 763
	[Token(Token = "0x40002FB")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<ushort, SpriteLibrary.BlessingTheme> s_blessingThemes;

	// Token: 0x040002FC RID: 764
	[Token(Token = "0x40002FC")]
	[FieldOffset(Offset = "0x30")]
	private readonly Dictionary<StatusEffects, Sprite> s_statusEffectSprites;

	// Token: 0x040002FD RID: 765
	[Token(Token = "0x40002FD")]
	[FieldOffset(Offset = "0x38")]
	public SpriteLibrary.BlessingTheme[] BlessingThemes;

	// Token: 0x040002FE RID: 766
	[Token(Token = "0x40002FE")]
	[FieldOffset(Offset = "0x40")]
	public SpriteLibrary.RegionSprite[] RegionSprites;

	// Token: 0x040002FF RID: 767
	[Token(Token = "0x40002FF")]
	[FieldOffset(Offset = "0x48")]
	public SpriteLibrary.LocalSprite[] LocalSprites;

	// Token: 0x04000300 RID: 768
	[Token(Token = "0x4000300")]
	[FieldOffset(Offset = "0x50")]
	public Sprite[] Sprites;

	// Token: 0x04000301 RID: 769
	[Token(Token = "0x4000301")]
	[FieldOffset(Offset = "0x58")]
	public SpriteLibrary.ScrollBackground TooltipBackround;

	// Token: 0x04000302 RID: 770
	[Token(Token = "0x4000302")]
	[FieldOffset(Offset = "0x78")]
	public SpriteLibrary.ScrollBackground QuestBackround;

	// Token: 0x04000303 RID: 771
	[Token(Token = "0x4000303")]
	[FieldOffset(Offset = "0x98")]
	public SpriteLibrary.ScrollBackground[] RarityBackgrounds;

	// Token: 0x020000B5 RID: 181
	[Token(Token = "0x20000B5")]
	[Serializable]
	public struct RegionSprite
	{
		// Token: 0x04000304 RID: 772
		[Token(Token = "0x4000304")]
		[FieldOffset(Offset = "0x0")]
		public RegionType Type;

		// Token: 0x04000305 RID: 773
		[Token(Token = "0x4000305")]
		[FieldOffset(Offset = "0x8")]
		public Sprite Sprite;
	}

	// Token: 0x020000B6 RID: 182
	[Token(Token = "0x20000B6")]
	[Serializable]
	public struct BlessingTheme
	{
		// Token: 0x04000306 RID: 774
		[Token(Token = "0x4000306")]
		[FieldOffset(Offset = "0x0")]
		public ushort Type;

		// Token: 0x04000307 RID: 775
		[Token(Token = "0x4000307")]
		[FieldOffset(Offset = "0x8")]
		public Sprite Start;

		// Token: 0x04000308 RID: 776
		[Token(Token = "0x4000308")]
		[FieldOffset(Offset = "0x10")]
		public Sprite StrandDown;

		// Token: 0x04000309 RID: 777
		[Token(Token = "0x4000309")]
		[FieldOffset(Offset = "0x18")]
		public Sprite StrandUp;

		// Token: 0x0400030A RID: 778
		[Token(Token = "0x400030A")]
		[FieldOffset(Offset = "0x20")]
		public Sprite EndDown;

		// Token: 0x0400030B RID: 779
		[Token(Token = "0x400030B")]
		[FieldOffset(Offset = "0x28")]
		public Sprite EndUp;

		// Token: 0x0400030C RID: 780
		[Token(Token = "0x400030C")]
		[FieldOffset(Offset = "0x30")]
		public Sprite StrandUpBase;
	}

	// Token: 0x020000B7 RID: 183
	[Token(Token = "0x20000B7")]
	[Serializable]
	public struct ScrollBackground
	{
		// Token: 0x0400030D RID: 781
		[Token(Token = "0x400030D")]
		[FieldOffset(Offset = "0x0")]
		public Rarity Type;

		// Token: 0x0400030E RID: 782
		[Token(Token = "0x400030E")]
		[FieldOffset(Offset = "0x8")]
		public Sprite Background;

		// Token: 0x0400030F RID: 783
		[Token(Token = "0x400030F")]
		[FieldOffset(Offset = "0x10")]
		public Vector2 OffsetMin;

		// Token: 0x04000310 RID: 784
		[Token(Token = "0x4000310")]
		[FieldOffset(Offset = "0x18")]
		public Vector2 OffsetMax;
	}

	// Token: 0x020000B8 RID: 184
	[Token(Token = "0x20000B8")]
	[Serializable]
	public struct LocalSprite
	{
		// Token: 0x04000311 RID: 785
		[Token(Token = "0x4000311")]
		[FieldOffset(Offset = "0x0")]
		public string LangCode;

		// Token: 0x04000312 RID: 786
		[Token(Token = "0x4000312")]
		[FieldOffset(Offset = "0x8")]
		public Sprite Flag;
	}
}
