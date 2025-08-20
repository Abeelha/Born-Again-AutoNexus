using System;
using Il2CppDummyDll;
using Ronin.Model.Enums;
using UnityEngine;

// Token: 0x0200009E RID: 158
[Token(Token = "0x200009E")]
public class ColorLibrary : ScriptableObject, ILoadable
{
	// Token: 0x060002DA RID: 730 RVA: 0x00003060 File Offset: 0x00001260
	[Token(Token = "0x60002DA")]
	[Address(RVA = "0x332B30", Offset = "0x331D30", VA = "0x180332B30")]
	public Color Get(ColorType colorType)
	{
		return default(Color);
	}

	// Token: 0x060002DB RID: 731 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002DB")]
	[Address(RVA = "0x332B90", Offset = "0x331D90", VA = "0x180332B90", Slot = "4")]
	public void Load()
	{
	}

	// Token: 0x060002DC RID: 732 RVA: 0x00003078 File Offset: 0x00001278
	[Token(Token = "0x60002DC")]
	[Address(RVA = "0x332E80", Offset = "0x332080", VA = "0x180332E80")]
	public Color Name(RankType rank, bool friend)
	{
		return default(Color);
	}

	// Token: 0x060002DD RID: 733 RVA: 0x00003090 File Offset: 0x00001290
	[Token(Token = "0x60002DD")]
	[Address(RVA = "0x332EF0", Offset = "0x3320F0", VA = "0x180332EF0")]
	public Color Rarity(Rarity rarity)
	{
		return default(Color);
	}

	// Token: 0x060002DE RID: 734 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002DE")]
	[Address(RVA = "0x332FC0", Offset = "0x3321C0", VA = "0x180332FC0")]
	public ColorLibrary()
	{
	}

	// Token: 0x04000286 RID: 646
	[Token(Token = "0x4000286")]
	[FieldOffset(Offset = "0x18")]
	public Color BenefitialColor;

	// Token: 0x04000287 RID: 647
	[Token(Token = "0x4000287")]
	[FieldOffset(Offset = "0x28")]
	public Color AlteringColor;

	// Token: 0x04000288 RID: 648
	[Token(Token = "0x4000288")]
	[FieldOffset(Offset = "0x38")]
	public Color GizmoColor;

	// Token: 0x04000289 RID: 649
	[Token(Token = "0x4000289")]
	[FieldOffset(Offset = "0x48")]
	public Color HostileColor;

	// Token: 0x0400028A RID: 650
	[Token(Token = "0x400028A")]
	[FieldOffset(Offset = "0x58")]
	public Color HostileEffectColor;

	// Token: 0x0400028B RID: 651
	[Token(Token = "0x400028B")]
	[FieldOffset(Offset = "0x68")]
	public Color IndifferentColor;

	// Token: 0x0400028C RID: 652
	[Token(Token = "0x400028C")]
	[FieldOffset(Offset = "0x78")]
	public Color TrueDamageColor;

	// Token: 0x0400028D RID: 653
	[Token(Token = "0x400028D")]
	[FieldOffset(Offset = "0x88")]
	public float IndicatorAlpha;

	// Token: 0x0400028E RID: 654
	[Token(Token = "0x400028E")]
	[FieldOffset(Offset = "0x8C")]
	public Color SelfColor;

	// Token: 0x0400028F RID: 655
	[Token(Token = "0x400028F")]
	[FieldOffset(Offset = "0x9C")]
	public Color LootOutline;

	// Token: 0x04000290 RID: 656
	[Token(Token = "0x4000290")]
	[FieldOffset(Offset = "0xAC")]
	public Color ScrollSub;

	// Token: 0x04000291 RID: 657
	[Token(Token = "0x4000291")]
	[FieldOffset(Offset = "0xBC")]
	public Color Soul;

	// Token: 0x04000292 RID: 658
	[Token(Token = "0x4000292")]
	[FieldOffset(Offset = "0xCC")]
	public Color Exp;

	// Token: 0x04000293 RID: 659
	[Token(Token = "0x4000293")]
	[FieldOffset(Offset = "0xDC")]
	public Color Damage;

	// Token: 0x04000294 RID: 660
	[Token(Token = "0x4000294")]
	[FieldOffset(Offset = "0xEC")]
	public Color CriticalStrike;

	// Token: 0x04000295 RID: 661
	[Token(Token = "0x4000295")]
	[FieldOffset(Offset = "0xFC")]
	public Color ArmorDamage;

	// Token: 0x04000296 RID: 662
	[Token(Token = "0x4000296")]
	[FieldOffset(Offset = "0x10C")]
	public Color Power;

	// Token: 0x04000297 RID: 663
	[Token(Token = "0x4000297")]
	[FieldOffset(Offset = "0x11C")]
	public Color Finesse;

	// Token: 0x04000298 RID: 664
	[Token(Token = "0x4000298")]
	[FieldOffset(Offset = "0x12C")]
	public Color Agility;

	// Token: 0x04000299 RID: 665
	[Token(Token = "0x4000299")]
	[FieldOffset(Offset = "0x13C")]
	public Color Focus;

	// Token: 0x0400029A RID: 666
	[Token(Token = "0x400029A")]
	[FieldOffset(Offset = "0x14C")]
	public Color Support;

	// Token: 0x0400029B RID: 667
	[Token(Token = "0x400029B")]
	[FieldOffset(Offset = "0x15C")]
	public Color Defense;

	// Token: 0x0400029C RID: 668
	[Token(Token = "0x400029C")]
	[FieldOffset(Offset = "0x16C")]
	public Color GoldCountDefault;

	// Token: 0x0400029D RID: 669
	[Token(Token = "0x400029D")]
	[FieldOffset(Offset = "0x17C")]
	public Color GoldCount100k;

	// Token: 0x0400029E RID: 670
	[Token(Token = "0x400029E")]
	[FieldOffset(Offset = "0x18C")]
	public Color GoldCount10m;

	// Token: 0x0400029F RID: 671
	[Token(Token = "0x400029F")]
	[FieldOffset(Offset = "0x19C")]
	public Color ChatWorld;

	// Token: 0x040002A0 RID: 672
	[Token(Token = "0x40002A0")]
	[FieldOffset(Offset = "0x1AC")]
	public Color ChatParty;

	// Token: 0x040002A1 RID: 673
	[Token(Token = "0x40002A1")]
	[FieldOffset(Offset = "0x1BC")]
	public Color ChatNpc;

	// Token: 0x040002A2 RID: 674
	[Token(Token = "0x40002A2")]
	[FieldOffset(Offset = "0x1CC")]
	public Color ChatEnemy;

	// Token: 0x040002A3 RID: 675
	[Token(Token = "0x40002A3")]
	[FieldOffset(Offset = "0x1DC")]
	public Color ChatEnemyName;

	// Token: 0x040002A4 RID: 676
	[Token(Token = "0x40002A4")]
	[FieldOffset(Offset = "0x1EC")]
	public Color ChatInfo;

	// Token: 0x040002A5 RID: 677
	[Token(Token = "0x40002A5")]
	[FieldOffset(Offset = "0x1FC")]
	public Color ChatError;

	// Token: 0x040002A6 RID: 678
	[Token(Token = "0x40002A6")]
	[FieldOffset(Offset = "0x20C")]
	public Color ChatSuccess;

	// Token: 0x040002A7 RID: 679
	[Token(Token = "0x40002A7")]
	[FieldOffset(Offset = "0x21C")]
	public Color EntityName;

	// Token: 0x040002A8 RID: 680
	[Token(Token = "0x40002A8")]
	[FieldOffset(Offset = "0x22C")]
	public Color EnemyName;

	// Token: 0x040002A9 RID: 681
	[Token(Token = "0x40002A9")]
	[FieldOffset(Offset = "0x23C")]
	public Color AdminName;

	// Token: 0x040002AA RID: 682
	[Token(Token = "0x40002AA")]
	[FieldOffset(Offset = "0x24C")]
	public Color ModeratorName;

	// Token: 0x040002AB RID: 683
	[Token(Token = "0x40002AB")]
	[FieldOffset(Offset = "0x25C")]
	public Color PlayerName;

	// Token: 0x040002AC RID: 684
	[Token(Token = "0x40002AC")]
	[FieldOffset(Offset = "0x26C")]
	public Color GuestName;

	// Token: 0x040002AD RID: 685
	[Token(Token = "0x40002AD")]
	[FieldOffset(Offset = "0x27C")]
	public Color FriendName;

	// Token: 0x040002AE RID: 686
	[Token(Token = "0x40002AE")]
	[FieldOffset(Offset = "0x28C")]
	public Color Level;

	// Token: 0x040002AF RID: 687
	[Token(Token = "0x40002AF")]
	[FieldOffset(Offset = "0x29C")]
	public Color LevelHardcore;

	// Token: 0x040002B0 RID: 688
	[Token(Token = "0x40002B0")]
	[FieldOffset(Offset = "0x2AC")]
	public Color DeathNote;

	// Token: 0x040002B1 RID: 689
	[Token(Token = "0x40002B1")]
	[FieldOffset(Offset = "0x2BC")]
	public Color RarityEpic;

	// Token: 0x040002B2 RID: 690
	[Token(Token = "0x40002B2")]
	[FieldOffset(Offset = "0x2CC")]
	public Color RarityRare;

	// Token: 0x040002B3 RID: 691
	[Token(Token = "0x40002B3")]
	[FieldOffset(Offset = "0x2DC")]
	public Color RarityMythic;

	// Token: 0x040002B4 RID: 692
	[Token(Token = "0x40002B4")]
	[FieldOffset(Offset = "0x2EC")]
	public Color RarityExalted;

	// Token: 0x040002B5 RID: 693
	[Token(Token = "0x40002B5")]
	[FieldOffset(Offset = "0x2FC")]
	public Color RarityAncestral;

	// Token: 0x040002B6 RID: 694
	[Token(Token = "0x40002B6")]
	[FieldOffset(Offset = "0x30C")]
	public Color StatNormal;

	// Token: 0x040002B7 RID: 695
	[Token(Token = "0x40002B7")]
	[FieldOffset(Offset = "0x31C")]
	public Color StatMaxed;

	// Token: 0x040002B8 RID: 696
	[Token(Token = "0x40002B8")]
	[FieldOffset(Offset = "0x32C")]
	public Color BlessingMaxStack;

	// Token: 0x040002B9 RID: 697
	[Token(Token = "0x40002B9")]
	[FieldOffset(Offset = "0x340")]
	public ColorLibrary.ColorDefintion[] ServerColors;

	// Token: 0x040002BA RID: 698
	[Token(Token = "0x40002BA")]
	[FieldOffset(Offset = "0x348")]
	public ColorLibrary.RarityColor[] RarityColors;

	// Token: 0x040002BB RID: 699
	[Token(Token = "0x40002BB")]
	[FieldOffset(Offset = "0x350")]
	private Color[] _colors;

	// Token: 0x0200009F RID: 159
	[Token(Token = "0x200009F")]
	[Serializable]
	public struct ColorDefintion
	{
		// Token: 0x040002BC RID: 700
		[Token(Token = "0x40002BC")]
		[FieldOffset(Offset = "0x0")]
		public ColorType Type;

		// Token: 0x040002BD RID: 701
		[Token(Token = "0x40002BD")]
		[FieldOffset(Offset = "0x4")]
		public Color Color;
	}

	// Token: 0x020000A0 RID: 160
	[Token(Token = "0x20000A0")]
	[Serializable]
	public struct RarityColor
	{
		// Token: 0x040002BE RID: 702
		[Token(Token = "0x40002BE")]
		[FieldOffset(Offset = "0x0")]
		public Rarity Rarity;

		// Token: 0x040002BF RID: 703
		[Token(Token = "0x40002BF")]
		[FieldOffset(Offset = "0x4")]
		public Color Color;
	}
}
