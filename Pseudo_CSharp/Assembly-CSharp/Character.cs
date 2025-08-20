using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Ronin.Model.Data;
using Ronin.Model.Definitions;
using Ronin.Model.Enums;
using Ronin.Model.Files.Animation;
using Zero.Game.Shared;

// Token: 0x02000286 RID: 646
[Token(Token = "0x2000286")]
public class Character : Entity, IDataHandler<BlessingsData>, IDataHandler<ExperienceData>, IDataHandler<HatData>, IDataHandler<Inventory0Data>, IDataHandler<PlayerIdData>
{
	// Token: 0x1700014F RID: 335
	// (get) Token: 0x06000CE8 RID: 3304 RVA: 0x00005478 File Offset: 0x00003678
	[Token(Token = "0x1700014F")]
	public bool Friend
	{
		[Token(Token = "0x6000CE8")]
		[Address(RVA = "0x452970", Offset = "0x451B70", VA = "0x180452970")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000150 RID: 336
	// (get) Token: 0x06000CE9 RID: 3305 RVA: 0x00005490 File Offset: 0x00003690
	[Token(Token = "0x17000150")]
	public bool Ignored
	{
		[Token(Token = "0x6000CE9")]
		[Address(RVA = "0x452A80", Offset = "0x451C80", VA = "0x180452A80")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000151 RID: 337
	// (get) Token: 0x06000CEA RID: 3306 RVA: 0x000054A8 File Offset: 0x000036A8
	// (set) Token: 0x06000CEB RID: 3307 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000151")]
	public long PlayerId
	{
		[Token(Token = "0x6000CEA")]
		[Address(RVA = "0x452B90", Offset = "0x451D90", VA = "0x180452B90")]
		[CompilerGenerated]
		get
		{
			return 0L;
		}
		[Token(Token = "0x6000CEB")]
		[Address(RVA = "0x452BA0", Offset = "0x451DA0", VA = "0x180452BA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x17000152 RID: 338
	// (get) Token: 0x06000CEC RID: 3308 RVA: 0x000054C0 File Offset: 0x000036C0
	[Token(Token = "0x17000152")]
	public ulong Experience
	{
		[Token(Token = "0x6000CEC")]
		[Address(RVA = "0x452930", Offset = "0x451B30", VA = "0x180452930")]
		get
		{
			return 0UL;
		}
	}

	// Token: 0x17000153 RID: 339
	// (get) Token: 0x06000CED RID: 3309 RVA: 0x000054D8 File Offset: 0x000036D8
	[Token(Token = "0x17000153")]
	public override WorldObjectType Type
	{
		[Token(Token = "0x6000CED")]
		[Address(RVA = "0x42ADE0", Offset = "0x429FE0", VA = "0x18042ADE0", Slot = "13")]
		get
		{
			return (WorldObjectType)0;
		}
	}

	// Token: 0x17000154 RID: 340
	// (get) Token: 0x06000CEE RID: 3310 RVA: 0x000054F0 File Offset: 0x000036F0
	[Token(Token = "0x17000154")]
	protected override float AttackSpeedScalar
	{
		[Token(Token = "0x6000CEE")]
		[Address(RVA = "0x4510B0", Offset = "0x4502B0", VA = "0x1804510B0", Slot = "60")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000155 RID: 341
	// (get) Token: 0x06000CEF RID: 3311 RVA: 0x00005508 File Offset: 0x00003708
	[Token(Token = "0x17000155")]
	private ushort HatType
	{
		[Token(Token = "0x6000CEF")]
		[Address(RVA = "0x452A20", Offset = "0x451C20", VA = "0x180452A20")]
		get
		{
			return 0;
		}
	}

	// Token: 0x06000CF0 RID: 3312 RVA: 0x00005520 File Offset: 0x00003720
	[Token(Token = "0x6000CF0")]
	[Address(RVA = "0x451200", Offset = "0x450400", VA = "0x180451200", Slot = "20")]
	public override float GetSpriteHeightCurrent()
	{
		return 0f;
	}

	// Token: 0x06000CF1 RID: 3313 RVA: 0x00005538 File Offset: 0x00003738
	[Token(Token = "0x6000CF1")]
	[Address(RVA = "0x451200", Offset = "0x450400", VA = "0x180451200", Slot = "21")]
	public override float GetSpriteHeightFirst()
	{
		return 0f;
	}

	// Token: 0x06000CF2 RID: 3314 RVA: 0x00005550 File Offset: 0x00003750
	[Token(Token = "0x6000CF2")]
	[Address(RVA = "0x451220", Offset = "0x450420", VA = "0x180451220", Slot = "22")]
	public override float GetSpriteHeightStill()
	{
		return 0f;
	}

	// Token: 0x06000CF3 RID: 3315 RVA: 0x00005568 File Offset: 0x00003768
	[Token(Token = "0x6000CF3")]
	[Address(RVA = "0x451230", Offset = "0x450430", VA = "0x180451230", Slot = "23")]
	public override float GetSpriteWidthCurrent()
	{
		return 0f;
	}

	// Token: 0x06000CF4 RID: 3316 RVA: 0x00005580 File Offset: 0x00003780
	[Token(Token = "0x6000CF4")]
	[Address(RVA = "0x4328A0", Offset = "0x431AA0", VA = "0x1804328A0", Slot = "24")]
	public override float GetSpriteWidthStill()
	{
		return 0f;
	}

	// Token: 0x06000CF5 RID: 3317 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CF5")]
	[Address(RVA = "0x451250", Offset = "0x450450", VA = "0x180451250", Slot = "65")]
	public void HandleData(ref BlessingsData data)
	{
	}

	// Token: 0x06000CF6 RID: 3318 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CF6")]
	[Address(RVA = "0x4513D0", Offset = "0x4505D0", VA = "0x1804513D0", Slot = "66")]
	public void HandleData(ref ExperienceData data)
	{
	}

	// Token: 0x06000CF7 RID: 3319 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CF7")]
	[Address(RVA = "0x451260", Offset = "0x450460", VA = "0x180451260", Slot = "67")]
	public void HandleData(ref HatData data)
	{
	}

	// Token: 0x06000CF8 RID: 3320 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CF8")]
	[Address(RVA = "0x4514B0", Offset = "0x4506B0", VA = "0x1804514B0", Slot = "68")]
	public void HandleData(ref Inventory0Data data)
	{
	}

	// Token: 0x06000CF9 RID: 3321 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CF9")]
	[Address(RVA = "0x451390", Offset = "0x450590", VA = "0x180451390", Slot = "61")]
	public override void HandleData(ref LevelData data)
	{
	}

	// Token: 0x06000CFA RID: 3322 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CFA")]
	[Address(RVA = "0x451380", Offset = "0x450580", VA = "0x180451380", Slot = "69")]
	public void HandleData(ref PlayerIdData data)
	{
	}

	// Token: 0x06000CFB RID: 3323 RVA: 0x00005598 File Offset: 0x00003798
	[Token(Token = "0x6000CFB")]
	[Address(RVA = "0x4514C0", Offset = "0x4506C0", VA = "0x1804514C0")]
	public bool HasOpenSlot()
	{
		return default(bool);
	}

	// Token: 0x06000CFC RID: 3324 RVA: 0x000055B0 File Offset: 0x000037B0
	[Token(Token = "0x6000CFC")]
	[Address(RVA = "0x3B1FF0", Offset = "0x3B11F0", VA = "0x1803B1FF0", Slot = "18")]
	public override int HitBy(Attack attack, Vec2 attackCoordinates, bool isPlayer)
	{
		return 0;
	}

	// Token: 0x06000CFD RID: 3325 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CFD")]
	[Address(RVA = "0x451700", Offset = "0x450900", VA = "0x180451700", Slot = "25")]
	public override void Load(ObjectDefinition definition)
	{
	}

	// Token: 0x06000CFE RID: 3326 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CFE")]
	[Address(RVA = "0x451840", Offset = "0x450A40", VA = "0x180451840", Slot = "26")]
	public override void RemoveFromWorld()
	{
	}

	// Token: 0x06000CFF RID: 3327 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CFF")]
	[Address(RVA = "0x452250", Offset = "0x451450", VA = "0x180452250", Slot = "27")]
	public override void ShowChatBubble(string message, float lifetime, ChatType? chatType)
	{
	}

	// Token: 0x06000D00 RID: 3328 RVA: 0x000055C8 File Offset: 0x000037C8
	[Token(Token = "0x6000D00")]
	[Address(RVA = "0x452400", Offset = "0x451600", VA = "0x180452400")]
	public bool TradeEnabled()
	{
		return default(bool);
	}

	// Token: 0x06000D01 RID: 3329 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D01")]
	[Address(RVA = "0x450ED0", Offset = "0x4500D0", VA = "0x180450ED0", Slot = "30")]
	protected override void Awake()
	{
	}

	// Token: 0x06000D02 RID: 3330 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000D02")]
	[Address(RVA = "0x450FF0", Offset = "0x4501F0", VA = "0x180450FF0", Slot = "31")]
	protected override AnimationSwitch GetAnimationForIndex(int index)
	{
		return null;
	}

	// Token: 0x06000D03 RID: 3331 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D03")]
	[Address(RVA = "0x4517C0", Offset = "0x4509C0", VA = "0x1804517C0", Slot = "32")]
	protected override void OnEnable()
	{
	}

	// Token: 0x06000D04 RID: 3332 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D04")]
	[Address(RVA = "0x451900", Offset = "0x450B00", VA = "0x180451900", Slot = "33")]
	protected override void SetCurrentGround(GroundDefinition groundDefinition)
	{
	}

	// Token: 0x06000D05 RID: 3333 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D05")]
	[Address(RVA = "0x451940", Offset = "0x450B40", VA = "0x180451940", Slot = "64")]
	protected override void SetDead(DeadData deadData)
	{
	}

	// Token: 0x06000D06 RID: 3334 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D06")]
	[Address(RVA = "0x452500", Offset = "0x451700", VA = "0x180452500", Slot = "35")]
	protected override void Update()
	{
	}

	// Token: 0x06000D07 RID: 3335 RVA: 0x000055E0 File Offset: 0x000037E0
	[Token(Token = "0x6000D07")]
	[Address(RVA = "0x4510B0", Offset = "0x4502B0", VA = "0x1804510B0")]
	private float GetAttackSpeedScalar()
	{
		return 0f;
	}

	// Token: 0x06000D08 RID: 3336 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D08")]
	[Address(RVA = "0x4513D0", Offset = "0x4505D0", VA = "0x1804513D0")]
	private void SetExperience([In] ref ExperienceData experienceData)
	{
	}

	// Token: 0x06000D09 RID: 3337 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D09")]
	[Address(RVA = "0x451CD0", Offset = "0x450ED0", VA = "0x180451CD0")]
	private void SetLevel([In] ref LevelData levelData)
	{
	}

	// Token: 0x06000D0A RID: 3338 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D0A")]
	[Address(RVA = "0x44F050", Offset = "0x44E250", VA = "0x18044F050")]
	public Character()
	{
	}

	// Token: 0x04000B02 RID: 2818
	[Token(Token = "0x4000B02")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
	private byte? _level;

	// Token: 0x04000B03 RID: 2819
	[Token(Token = "0x4000B03")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
	private ulong? _experience;

	// Token: 0x04000B04 RID: 2820
	[Token(Token = "0x4000B04")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
	private ushort? _hatOverride;

	// Token: 0x04000B05 RID: 2821
	[Token(Token = "0x4000B05")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21C")]
	private ushort _hat;

	// Token: 0x04000B06 RID: 2822
	[Token(Token = "0x4000B06")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
	private Tombstone _tombstone;

	// Token: 0x04000B07 RID: 2823
	[Token(Token = "0x4000B07")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
	private Spectator _spectator;

	// Token: 0x04000B08 RID: 2824
	[Token(Token = "0x4000B08")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
	private ulong _gainedExperience;

	// Token: 0x04000B09 RID: 2825
	[Token(Token = "0x4000B09")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
	private Option _playerOpacityOption;

	// Token: 0x04000B0A RID: 2826
	[Token(Token = "0x4000B0A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
	private Option _opacityDistanceOption;

	// Token: 0x04000B0B RID: 2827
	[Token(Token = "0x4000B0B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
	private Option _opacityMinimumOption;

	// Token: 0x04000B0C RID: 2828
	[Token(Token = "0x4000B0C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
	private Option _fadingDistanceOption;

	// Token: 0x04000B0D RID: 2829
	[Token(Token = "0x4000B0D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
	private FootstepSfx _footstepSfx;
}
