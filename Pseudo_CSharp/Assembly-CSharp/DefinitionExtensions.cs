using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Ronin.Model.Classes;
using Ronin.Model.Definitions;
using Ronin.Model.Enums;
using Ronin.Model.Files.Animation;
using Ronin.Model.Structs;
using UnityEngine;

// Token: 0x02000062 RID: 98
[Token(Token = "0x2000062")]
public static class DefinitionExtensions
{
	// Token: 0x0600018E RID: 398 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600018E")]
	[Address(RVA = "0x334690", Offset = "0x333890", VA = "0x180334690")]
	public static AnimationSwitch GetArmorAnimation(this ObjectDefinition definition, int animationIndex)
	{
		return null;
	}

	// Token: 0x0600018F RID: 399 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600018F")]
	[Address(RVA = "0x3347E0", Offset = "0x3339E0", VA = "0x1803347E0")]
	public static Sprite GetArmorSprite(this ObjectDefinition definition)
	{
		return null;
	}

	// Token: 0x06000190 RID: 400 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000190")]
	[Address(RVA = "0x334520", Offset = "0x333720", VA = "0x180334520")]
	public static AnimationSwitch GetAnimation(this ObjectDefinition definition, int animationIndex = 0)
	{
		return null;
	}

	// Token: 0x06000191 RID: 401 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000191")]
	[Address(RVA = "0x3349B0", Offset = "0x333BB0", VA = "0x1803349B0")]
	public static AnimationSwitch GetBootAnimation(this ObjectDefinition definition, int animationIndex)
	{
		return null;
	}

	// Token: 0x06000192 RID: 402 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000192")]
	[Address(RVA = "0x334B00", Offset = "0x333D00", VA = "0x180334B00")]
	public static AnimationLoop GetDisplayLoop(this ObjectDefinition definition)
	{
		return null;
	}

	// Token: 0x06000193 RID: 403 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000193")]
	[Address(RVA = "0x334B50", Offset = "0x333D50", VA = "0x180334B50")]
	public static AnimationLoop GetDisplayLoop(this AnimationSwitch @switch)
	{
		return null;
	}

	// Token: 0x06000194 RID: 404 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000194")]
	[Address(RVA = "0x334BA0", Offset = "0x333DA0", VA = "0x180334BA0")]
	public static SpriteMetaData GetDisplayMetaData(this ObjectDefinition definition, Vector2Int coordinates)
	{
		return null;
	}

	// Token: 0x06000195 RID: 405 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000195")]
	[Address(RVA = "0x335170", Offset = "0x334370", VA = "0x180335170")]
	public static Sprite GetDisplaySprite(this ObjectDefinition definition)
	{
		return null;
	}

	// Token: 0x06000196 RID: 406 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000196")]
	[Address(RVA = "0x335480", Offset = "0x334680", VA = "0x180335480")]
	public static Sprite GetDisplaySprite(this AnimationSwitch @switch)
	{
		return null;
	}

	// Token: 0x06000197 RID: 407 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000197")]
	[Address(RVA = "0x335640", Offset = "0x334840", VA = "0x180335640")]
	public static Sprite GetDisplaySprite(this AnimationLoop loop)
	{
		return null;
	}

	// Token: 0x06000198 RID: 408 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000198")]
	[Address(RVA = "0x335790", Offset = "0x334990", VA = "0x180335790")]
	public static AnimationLoop GetEquipLoop(this ObjectDefinition definition, bool noHands = false)
	{
		return null;
	}

	// Token: 0x06000199 RID: 409 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000199")]
	[Address(RVA = "0x335730", Offset = "0x334930", VA = "0x180335730")]
	public static AnimationLoop GetEquipLoop(this AnimationSwitch @switch, bool noHands = false)
	{
		return null;
	}

	// Token: 0x0600019A RID: 410 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600019A")]
	[Address(RVA = "0x335860", Offset = "0x334A60", VA = "0x180335860")]
	public static Sprite GetEquipSprite(this ObjectDefinition definition)
	{
		return null;
	}

	// Token: 0x0600019B RID: 411 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600019B")]
	[Address(RVA = "0x335800", Offset = "0x334A00", VA = "0x180335800")]
	public static Sprite GetEquipSprite(this AnimationLoop loop)
	{
		return null;
	}

	// Token: 0x0600019C RID: 412 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600019C")]
	[Address(RVA = "0x334FC0", Offset = "0x3341C0", VA = "0x180334FC0")]
	public static Sprite GetDisplaySprite(this ItemValue itemValue)
	{
		return null;
	}

	// Token: 0x0600019D RID: 413 RVA: 0x000026E8 File Offset: 0x000008E8
	[Token(Token = "0x600019D")]
	[Address(RVA = "0x335E90", Offset = "0x335090", VA = "0x180335E90")]
	public static Color GetLevelColor(this BlessingDefinition birthBlessing)
	{
		return default(Color);
	}

	// Token: 0x0600019E RID: 414 RVA: 0x00002700 File Offset: 0x00000900
	[Token(Token = "0x600019E")]
	[Address(RVA = "0x336170", Offset = "0x335370", VA = "0x180336170")]
	public static ValueTuple<string, string> GetNameAndDescription(this ObjectDefinition definition, bool silouhette = false)
	{
		return default(ValueTuple<string, string>);
	}

	// Token: 0x0600019F RID: 415 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600019F")]
	[Address(RVA = "0x336800", Offset = "0x335A00", VA = "0x180336800")]
	public static AnimationSwitch GetRig(this ObjectDefinition definition)
	{
		return null;
	}

	// Token: 0x060001A0 RID: 416 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60001A0")]
	[Address(RVA = "0x3365D0", Offset = "0x3357D0", VA = "0x1803365D0")]
	public static AnimationSwitch GetRig(this SlotType slotType)
	{
		return null;
	}

	// Token: 0x060001A1 RID: 417 RVA: 0x00002718 File Offset: 0x00000918
	[Token(Token = "0x60001A1")]
	[Address(RVA = "0x336AC0", Offset = "0x335CC0", VA = "0x180336AC0")]
	public static TileSprite GetTileSprite(this ObjectDefinition definition, Vector2Int coordinates)
	{
		return default(TileSprite);
	}

	// Token: 0x060001A2 RID: 418 RVA: 0x00002730 File Offset: 0x00000930
	[Token(Token = "0x60001A2")]
	[Address(RVA = "0x335F90", Offset = "0x335190", VA = "0x180335F90")]
	public static WorldObjectType GetMapType(this ObjectDefinition definition)
	{
		return (WorldObjectType)0;
	}

	// Token: 0x060001A3 RID: 419 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60001A3")]
	[Address(RVA = "0x336230", Offset = "0x335430", VA = "0x180336230")]
	public static Sprite GetPortraitSprite(this ObjectDefinition definition, [Optional] Vector2 pivot)
	{
		return null;
	}

	// Token: 0x060001A4 RID: 420 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60001A4")]
	[Address(RVA = "0x335AC0", Offset = "0x334CC0", VA = "0x180335AC0")]
	public static Sprite GetLargePortraitSprite(this ObjectDefinition definition)
	{
		return null;
	}

	// Token: 0x060001A5 RID: 421 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60001A5")]
	[Address(RVA = "0x336EF0", Offset = "0x3360F0", VA = "0x180336EF0")]
	public static string GetTypeNameString(this ObjectDefinition definition)
	{
		return null;
	}

	// Token: 0x060001A6 RID: 422 RVA: 0x00002748 File Offset: 0x00000948
	[Token(Token = "0x60001A6")]
	[Address(RVA = "0x336F90", Offset = "0x336190", VA = "0x180336F90")]
	public static bool MeetsCondition(this Effect effect, Vector2Int coordinates)
	{
		return default(bool);
	}

	// Token: 0x060001A7 RID: 423 RVA: 0x00002760 File Offset: 0x00000960
	[Token(Token = "0x60001A7")]
	[Address(RVA = "0x336FE0", Offset = "0x3361E0", VA = "0x180336FE0")]
	public static bool MeetsCondition(this Condition condition, Vector2Int coordinates)
	{
		return default(bool);
	}

	// Token: 0x060001A8 RID: 424 RVA: 0x00002778 File Offset: 0x00000978
	[Token(Token = "0x60001A8")]
	[Address(RVA = "0x3369F0", Offset = "0x335BF0", VA = "0x1803369F0")]
	private static int GetTileIndex(TileDefinition tileData, Vector2Int coordinates)
	{
		return 0;
	}
}
