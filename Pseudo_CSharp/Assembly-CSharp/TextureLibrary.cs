using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Ronin.Model.Files.Animation;
using UnityEngine;

// Token: 0x020000BA RID: 186
[Token(Token = "0x20000BA")]
public class TextureLibrary
{
	// Token: 0x0600031F RID: 799 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600031F")]
	[Address(RVA = "0x345700", Offset = "0x344900", VA = "0x180345700")]
	public void Add(Texture2D texture, Color32[] colors, IEnumerable<AnimationSwitch> switches)
	{
	}

	// Token: 0x06000320 RID: 800 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000320")]
	[Address(RVA = "0x345220", Offset = "0x344420", VA = "0x180345220")]
	public void Add(Texture2D texture, Color32[] colors, AnimationSwitch @switch)
	{
	}

	// Token: 0x06000321 RID: 801 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000321")]
	[Address(RVA = "0x3448B0", Offset = "0x343AB0", VA = "0x1803448B0")]
	public void AddBlendTexture(Texture2D texture, Color32[] colors, int blendCount)
	{
	}

	// Token: 0x06000322 RID: 802 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000322")]
	[Address(RVA = "0x344B60", Offset = "0x343D60", VA = "0x180344B60")]
	public void AddCeilingTexture(Texture2D texture, Color32[] colors)
	{
	}

	// Token: 0x06000323 RID: 803 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000323")]
	[Address(RVA = "0x344CC0", Offset = "0x343EC0", VA = "0x180344CC0")]
	public void AddGroundTexture(Texture2D texture, Color32[] colors)
	{
	}

	// Token: 0x06000324 RID: 804 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000324")]
	[Address(RVA = "0x316090", Offset = "0x315290", VA = "0x180316090")]
	public void Destroy()
	{
	}

	// Token: 0x06000325 RID: 805 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000325")]
	[Address(RVA = "0x3460B0", Offset = "0x3452B0", VA = "0x1803460B0")]
	public AnimationSwitch Get(string name)
	{
		return null;
	}

	// Token: 0x06000326 RID: 806 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000326")]
	[Address(RVA = "0x346030", Offset = "0x345230", VA = "0x180346030")]
	public Sprite GetSprite(AnimationFrame frame)
	{
		return null;
	}

	// Token: 0x06000327 RID: 807 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000327")]
	[Address(RVA = "0x345FB0", Offset = "0x3451B0", VA = "0x180345FB0")]
	public SpriteMetaData GetSpriteMetaData(AnimationFrame frame)
	{
		return null;
	}

	// Token: 0x06000328 RID: 808 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000328")]
	[Address(RVA = "0x3458E0", Offset = "0x344AE0", VA = "0x1803458E0")]
	public AnimationSwitch GetArmorNone()
	{
		return null;
	}

	// Token: 0x06000329 RID: 809 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000329")]
	[Address(RVA = "0x345A20", Offset = "0x344C20", VA = "0x180345A20")]
	public AnimationSwitch GetBootsNone()
	{
		return null;
	}

	// Token: 0x0600032A RID: 810 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600032A")]
	[Address(RVA = "0x345990", Offset = "0x344B90", VA = "0x180345990")]
	public Sprite GetBlend(int index, BlendDirection blendDirection)
	{
		return null;
	}

	// Token: 0x0600032B RID: 811 RVA: 0x00003138 File Offset: 0x00001338
	[Token(Token = "0x600032B")]
	[Address(RVA = "0x345BB0", Offset = "0x344DB0", VA = "0x180345BB0")]
	public ValueTuple<Sprite, SpriteMetaData> GetCeiling(string file, int index)
	{
		return default(ValueTuple<Sprite, SpriteMetaData>);
	}

	// Token: 0x0600032C RID: 812 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600032C")]
	[Address(RVA = "0x345AD0", Offset = "0x344CD0", VA = "0x180345AD0")]
	public Sprite GetCeilingSprite(string file, int index)
	{
		return null;
	}

	// Token: 0x0600032D RID: 813 RVA: 0x00003150 File Offset: 0x00001350
	[Token(Token = "0x600032D")]
	[Address(RVA = "0x345D70", Offset = "0x344F70", VA = "0x180345D70")]
	public ValueTuple<Sprite, SpriteMetaData> GetGround(string file, int index)
	{
		return default(ValueTuple<Sprite, SpriteMetaData>);
	}

	// Token: 0x0600032E RID: 814 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600032E")]
	[Address(RVA = "0x345C90", Offset = "0x344E90", VA = "0x180345C90")]
	public Sprite GetGroundSprite(string file, int index)
	{
		return null;
	}

	// Token: 0x0600032F RID: 815 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600032F")]
	[Address(RVA = "0x345F00", Offset = "0x345100", VA = "0x180345F00")]
	public AnimationSwitch GetMissing()
	{
		return null;
	}

	// Token: 0x06000330 RID: 816 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000330")]
	[Address(RVA = "0x345E50", Offset = "0x345050", VA = "0x180345E50")]
	public AnimationSwitch GetMissingModel()
	{
		return null;
	}

	// Token: 0x06000331 RID: 817 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000331")]
	[Address(RVA = "0x344E20", Offset = "0x344020", VA = "0x180344E20")]
	private static void AddTileSprites(Texture2D texture, Color32[] colors, List<ValueTuple<Sprite, SpriteMetaData>> sprites)
	{
	}

	// Token: 0x06000332 RID: 818 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000332")]
	[Address(RVA = "0x346140", Offset = "0x345340", VA = "0x180346140")]
	public TextureLibrary()
	{
	}

	// Token: 0x04000318 RID: 792
	[Token(Token = "0x4000318")]
	[FieldOffset(Offset = "0x10")]
	private readonly List<AnimationSwitch> _all;

	// Token: 0x04000319 RID: 793
	[Token(Token = "0x4000319")]
	[FieldOffset(Offset = "0x18")]
	private readonly Dictionary<string, AnimationSwitch> _nameMap;

	// Token: 0x0400031A RID: 794
	[Token(Token = "0x400031A")]
	[FieldOffset(Offset = "0x20")]
	private readonly List<Sprite> _blends;

	// Token: 0x0400031B RID: 795
	[Token(Token = "0x400031B")]
	[FieldOffset(Offset = "0x28")]
	private readonly Dictionary<string, List<ValueTuple<Sprite, SpriteMetaData>>> _ceilings;

	// Token: 0x0400031C RID: 796
	[Token(Token = "0x400031C")]
	[FieldOffset(Offset = "0x30")]
	private readonly Dictionary<string, List<ValueTuple<Sprite, SpriteMetaData>>> _grounds;

	// Token: 0x0400031D RID: 797
	[Token(Token = "0x400031D")]
	[FieldOffset(Offset = "0x38")]
	private readonly Dictionary<AnimationFrame, Sprite> _frameSpriteMap;

	// Token: 0x0400031E RID: 798
	[Token(Token = "0x400031E")]
	[FieldOffset(Offset = "0x40")]
	private readonly Dictionary<AnimationFrame, SpriteMetaData> _frameSpriteMetaDataMap;
}
