using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;
using Ronin.Model.Classes;
using Ronin.Model.Data;
using Ronin.Model.Definitions;
using Ronin.Model.Enums;
using Ronin.Model.GameActions;
using Ronin.Model.Merchant;
using Ronin.Model.Modifiers;
using Ronin.Model.Rewards;
using Ronin.Model.Structs;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x02000305 RID: 773
[Token(Token = "0x2000305")]
public static class TooltipExtensions
{
	// Token: 0x06001144 RID: 4420 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001144")]
	[Address(RVA = "0x367D90", Offset = "0x366F90", VA = "0x180367D90")]
	public static void BuildBlessing(this TooltipBuilder builder, ObjectDefinition definition, int count, [Optional] byte? index, bool remove = false)
	{
	}

	// Token: 0x06001145 RID: 4421 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001145")]
	[Address(RVA = "0x3684A0", Offset = "0x3676A0", VA = "0x1803684A0")]
	public static void BuildCharacter(this TooltipBuilder builder, Character character, bool clickForOptions = false)
	{
	}

	// Token: 0x06001146 RID: 4422 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001146")]
	[Address(RVA = "0x368A60", Offset = "0x367C60", VA = "0x180368A60")]
	public static void BuildClass(this TooltipBuilder builder, ObjectDefinition definition)
	{
	}

	// Token: 0x06001147 RID: 4423 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001147")]
	[Address(RVA = "0x369520", Offset = "0x368720", VA = "0x180369520")]
	public static void BuildClock(this TooltipBuilder builder, float timeProgress)
	{
	}

	// Token: 0x06001148 RID: 4424 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6001148")]
	[Address(RVA = "0x369E70", Offset = "0x369070", VA = "0x180369E70")]
	public static TooltipBuilder BuildDefinition(this TooltipBuilder builder, ObjectDefinition definition)
	{
		return null;
	}

	// Token: 0x06001149 RID: 4425 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001149")]
	[Address(RVA = "0x369F20", Offset = "0x369120", VA = "0x180369F20")]
	public static void BuildExperience(this TooltipBuilder builder, int currentLevel, ulong experience)
	{
	}

	// Token: 0x0600114A RID: 4426 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600114A")]
	[Address(RVA = "0x36BA10", Offset = "0x36AC10", VA = "0x18036BA10")]
	public static void BuildHonor(this TooltipBuilder builder, ulong honor)
	{
	}

	// Token: 0x0600114B RID: 4427 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600114B")]
	[Address(RVA = "0x36BD90", Offset = "0x36AF90", VA = "0x18036BD90")]
	public static void BuildItem(this TooltipBuilder builder, ItemValue itemValue, Func<StatType, int> statGetter)
	{
	}

	// Token: 0x0600114C RID: 4428 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600114C")]
	[Address(RVA = "0x36DB20", Offset = "0x36CD20", VA = "0x18036DB20")]
	public static TooltipBuilder BuildMessage(this TooltipBuilder builder, string message, bool rtlSupport, string icon)
	{
		return null;
	}

	// Token: 0x0600114D RID: 4429 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600114D")]
	[Address(RVA = "0x3703E0", Offset = "0x36F5E0", VA = "0x1803703E0")]
	public static TooltipBuilder BuildObject(this TooltipBuilder builder, ObjectDefinition definition, WorldObject worldObject)
	{
		return null;
	}

	// Token: 0x0600114E RID: 4430 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600114E")]
	[Address(RVA = "0x370610", Offset = "0x36F810", VA = "0x180370610")]
	public static TooltipBuilder BuildOffer(this TooltipBuilder builder, WorldObject worldObject, MerchantOffer offer, byte offerIndex)
	{
		return null;
	}

	// Token: 0x0600114F RID: 4431 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600114F")]
	[Address(RVA = "0x370BF0", Offset = "0x36FDF0", VA = "0x180370BF0")]
	public static void BuildOption(this TooltipBuilder builder, ContextActions.ContextActionsOptionState option, UnityAction onClick)
	{
	}

	// Token: 0x06001150 RID: 4432 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001150")]
	[Address(RVA = "0x370DC0", Offset = "0x36FFC0", VA = "0x180370DC0")]
	public static void BuildPlayerName(this TooltipBuilder builder, string playerName)
	{
	}

	// Token: 0x06001151 RID: 4433 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6001151")]
	[Address(RVA = "0x370EE0", Offset = "0x3700E0", VA = "0x180370EE0")]
	public static TooltipBuilder BuildQuestOffer(this TooltipBuilder builder, QuestDefinition questDefinition, QuestProgressData questProgress, World world, Entity offeringEntity)
	{
		return null;
	}

	// Token: 0x06001152 RID: 4434 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6001152")]
	[Address(RVA = "0x371500", Offset = "0x370700", VA = "0x180371500")]
	public static TooltipBuilder BuildQuestProgress(this TooltipBuilder builder, QuestDefinition questDefinition, QuestProgressData questProgress, World world)
	{
		return null;
	}

	// Token: 0x06001153 RID: 4435 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6001153")]
	[Address(RVA = "0x3735B0", Offset = "0x3727B0", VA = "0x1803735B0")]
	public static TooltipBuilder BuildShop(this TooltipBuilder builder, Shop shop)
	{
		return null;
	}

	// Token: 0x06001154 RID: 4436 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6001154")]
	[Address(RVA = "0x373A00", Offset = "0x372C00", VA = "0x180373A00")]
	public static TooltipBuilder BuildStat(this TooltipBuilder builder, StatType statType)
	{
		return null;
	}

	// Token: 0x06001155 RID: 4437 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001155")]
	[Address(RVA = "0x373F00", Offset = "0x373100", VA = "0x180373F00")]
	public static void BuildThread(this TooltipBuilder builder, ObjectDefinition definition)
	{
	}

	// Token: 0x06001156 RID: 4438 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001156")]
	[Address(RVA = "0x367390", Offset = "0x366590", VA = "0x180367390")]
	private static void BuildBasicAttack(this TooltipBuilder builder, Func<StatType, int> statGetter, StringBuilder stringBuilder, ObjectDefinition definition, ItemDefinition itemDefinition)
	{
	}

	// Token: 0x06001157 RID: 4439 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6001157")]
	[Address(RVA = "0x36B7B0", Offset = "0x36A9B0", VA = "0x18036B7B0")]
	private static TooltipBuilder BuildGameActions(this TooltipBuilder builder, ObjectDefinition definition, IEnumerable<GameAction> gameActions, bool range, bool centered = false, float scalar = 1f, bool onHit = false, [Optional] Func<StatType, int> statGetter, bool constant = false, float timeScalar = 1f)
	{
		return null;
	}

	// Token: 0x06001158 RID: 4440 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6001158")]
	[Address(RVA = "0x36A2C0", Offset = "0x3694C0", VA = "0x18036A2C0")]
	private static TooltipBuilder BuildGameAction(this TooltipBuilder builder, ObjectDefinition definition, GameAction action, bool showRange, bool centered = false, float scalar = 1f, bool onHit = false, [Optional] Func<StatType, int> statGetter, bool constant = false, float timeScalar = 1f)
	{
		return null;
	}

	// Token: 0x06001159 RID: 4441 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6001159")]
	[Address(RVA = "0x3666D0", Offset = "0x3658D0", VA = "0x1803666D0")]
	private static TooltipBuilder BuildAttack(this TooltipBuilder builder, AttackDescriptor attackDescriptor, ObjectDefinition definition, bool range, bool centered = false, [Optional] Func<StatType, int> statGetter)
	{
		return null;
	}

	// Token: 0x0600115A RID: 4442 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600115A")]
	[Address(RVA = "0x369CA0", Offset = "0x368EA0", VA = "0x180369CA0")]
	private static TooltipBuilder BuildCosts(this TooltipBuilder builder, World world, IEnumerable<MerchantCost> costs)
	{
		return null;
	}

	// Token: 0x0600115B RID: 4443 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600115B")]
	[Address(RVA = "0x3697A0", Offset = "0x3689A0", VA = "0x1803697A0")]
	private static TooltipBuilder BuildCost(this TooltipBuilder builder, World world, MerchantCost cost)
	{
		return null;
	}

	// Token: 0x0600115C RID: 4444 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600115C")]
	[Address(RVA = "0x3701E0", Offset = "0x36F3E0", VA = "0x1803701E0")]
	private static TooltipBuilder BuildModifiers(this TooltipBuilder builder, ObjectDefinition definition, IEnumerable<Modifier> modifiers, float charge, bool detailedDamage = false)
	{
		return null;
	}

	// Token: 0x0600115D RID: 4445 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600115D")]
	[Address(RVA = "0x36DD60", Offset = "0x36CF60", VA = "0x18036DD60")]
	private static TooltipBuilder BuildModifier(this TooltipBuilder builder, ObjectDefinition definition, Modifier modifier, float charge, bool detailedDamage = false)
	{
		return null;
	}

	// Token: 0x0600115E RID: 4446 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600115E")]
	[Address(RVA = "0x372FD0", Offset = "0x3721D0", VA = "0x180372FD0")]
	private static TooltipBuilder BuildRewards(this TooltipBuilder builder, World world, IEnumerable<Reward> rewards, out bool canAccept)
	{
		return null;
	}

	// Token: 0x0600115F RID: 4447 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600115F")]
	[Address(RVA = "0x371EC0", Offset = "0x3710C0", VA = "0x180371EC0")]
	private static TooltipBuilder BuildReward(this TooltipBuilder builder, World world, Reward reward, ref bool canAccept, int itemIndex, int itemCount)
	{
		return null;
	}

	// Token: 0x06001160 RID: 4448 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6001160")]
	[Address(RVA = "0x373410", Offset = "0x372610", VA = "0x180373410")]
	private static TooltipBuilder BuildSeparator(this TooltipBuilder builder)
	{
		return null;
	}

	// Token: 0x06001161 RID: 4449 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6001161")]
	[Address(RVA = "0x373C40", Offset = "0x372E40", VA = "0x180373C40")]
	private static TooltipBuilder BuildStatusEffect(this TooltipBuilder builder, StatusEffects type, uint duration, bool centered, bool constant)
	{
		return null;
	}

	// Token: 0x06001162 RID: 4450 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6001162")]
	[Address(RVA = "0x3665C0", Offset = "0x3657C0", VA = "0x1803665C0")]
	private static StringBuilder AppendDecimal(this StringBuilder builder, float value)
	{
		return null;
	}

	// Token: 0x06001163 RID: 4451 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6001163")]
	[Address(RVA = "0x366640", Offset = "0x365840", VA = "0x180366640")]
	private static StringBuilder AppendPercentage(this StringBuilder builder, float value)
	{
		return null;
	}

	// Token: 0x06001164 RID: 4452 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6001164")]
	[Address(RVA = "0x373820", Offset = "0x372A20", VA = "0x180373820")]
	private static TooltipBuilder BuildStatIncreases(this TooltipBuilder builder, ObjectDefinition definition, bool increases = true)
	{
		return null;
	}

	// Token: 0x06001165 RID: 4453 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6001165")]
	[Address(RVA = "0x373880", Offset = "0x372A80", VA = "0x180373880")]
	private static TooltipBuilder BuildStatIncreases(this TooltipBuilder builder, Stats stats, Stats multipliers, bool increases)
	{
		return null;
	}

	// Token: 0x06001166 RID: 4454 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6001166")]
	[Address(RVA = "0x374200", Offset = "0x373400", VA = "0x180374200")]
	private static string GetDeviceKey([Optional] string desktop, [Optional] string handheld)
	{
		return null;
	}

	// Token: 0x06001167 RID: 4455 RVA: 0x00006930 File Offset: 0x00004B30
	[Token(Token = "0x6001167")]
	[Address(RVA = "0x374280", Offset = "0x373480", VA = "0x180374280")]
	private static Color GetStyleColor(AbilityStyle style)
	{
		return default(Color);
	}

	// Token: 0x06001168 RID: 4456 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6001168")]
	[Address(RVA = "0x3744A0", Offset = "0x3736A0", VA = "0x1803744A0")]
	private static string GetStyleLabel(AbilityStyle style)
	{
		return null;
	}

	// Token: 0x06001169 RID: 4457 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6001169")]
	[Address(RVA = "0x374600", Offset = "0x373800", VA = "0x180374600")]
	[CompilerGenerated]
	internal static string <BuildModifier>g__getTriggerVerbage|28_25(TriggerEvent @event)
	{
		return null;
	}

	// Token: 0x0600116A RID: 4458 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600116A")]
	[Address(RVA = "0x374670", Offset = "0x373870", VA = "0x180374670")]
	[CompilerGenerated]
	internal static void <BuildStatIncreases>g__buildStat|38_0(TooltipBuilder builder, StringBuilder stringBuilder, StatType statType, int stat, bool multiplier, ref int index, int totalColumnCount, bool increases)
	{
	}
}
