using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Ronin.Model.Data;
using Ronin.Model.Definitions;
using Ronin.Model.Enums;
using Ronin.Model.Simulation.Components;
using Ronin.Model.Structs;
using UnityEngine;
using Zero.Game.Shared;

// Token: 0x0200028A RID: 650
[Token(Token = "0x200028A")]
public abstract class Entity : WorldObject, IDataHandler<ArmorData>, IDataHandler<BadgeData>, IDataHandler<DeadData>, IDataHandler<DeathNoteData>, IDataHandler<EffectData>, IDataHandler<HomeCancelData>, IDataHandler<HomeStartData>, IDataHandler<KillerData>, IDataHandler<LevelData>, IDataHandler<MaxArmorData>, IDataHandler<MaxHealthData>, IDataHandler<NameData>, IDataHandler<OtherData>, IDataHandler<PositionData>, IDataHandler<PrestigeData>, IDataHandler<QuestData>, IDataHandler<QuestCompleteData>, IDataHandler<RankData>, IDataHandler<SfxData>, IDataHandler<TextureData>, IDataHandler<UsedData>
{
	// Token: 0x1700015D RID: 349
	// (get) Token: 0x06000D26 RID: 3366 RVA: 0x000056B8 File Offset: 0x000038B8
	// (set) Token: 0x06000D27 RID: 3367 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700015D")]
	public int Armor
	{
		[Token(Token = "0x6000D26")]
		[Address(RVA = "0x457310", Offset = "0x456510", VA = "0x180457310")]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000D27")]
		[Address(RVA = "0x4579B0", Offset = "0x456BB0", VA = "0x1804579B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x1700015E RID: 350
	// (get) Token: 0x06000D28 RID: 3368 RVA: 0x000056D0 File Offset: 0x000038D0
	[Token(Token = "0x1700015E")]
	public bool Ally
	{
		[Token(Token = "0x6000D28")]
		[Address(RVA = "0x4572F0", Offset = "0x4564F0", VA = "0x1804572F0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700015F RID: 351
	// (get) Token: 0x06000D29 RID: 3369 RVA: 0x000056E8 File Offset: 0x000038E8
	[Token(Token = "0x1700015F")]
	public bool Controlled
	{
		[Token(Token = "0x6000D29")]
		[Address(RVA = "0x457330", Offset = "0x456530", VA = "0x180457330")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000160 RID: 352
	// (get) Token: 0x06000D2A RID: 3370 RVA: 0x00005700 File Offset: 0x00003900
	[Token(Token = "0x17000160")]
	public bool Dead
	{
		[Token(Token = "0x6000D2A")]
		[Address(RVA = "0x4573D0", Offset = "0x4565D0", VA = "0x1804573D0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000161 RID: 353
	// (get) Token: 0x06000D2B RID: 3371 RVA: 0x00005718 File Offset: 0x00003918
	[Token(Token = "0x17000161")]
	public bool HasEntityName
	{
		[Token(Token = "0x6000D2B")]
		[Address(RVA = "0x4574B0", Offset = "0x4566B0", VA = "0x1804574B0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000162 RID: 354
	// (get) Token: 0x06000D2C RID: 3372 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x17000162")]
	public virtual string EntityName
	{
		[Token(Token = "0x6000D2C")]
		[Address(RVA = "0x457430", Offset = "0x456630", VA = "0x180457430", Slot = "57")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000163 RID: 355
	// (get) Token: 0x06000D2D RID: 3373 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x17000163")]
	public virtual string RichTextName
	{
		[Token(Token = "0x6000D2D")]
		[Address(RVA = "0x457790", Offset = "0x456990", VA = "0x180457790", Slot = "58")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000164 RID: 356
	// (get) Token: 0x06000D2E RID: 3374 RVA: 0x00005730 File Offset: 0x00003930
	// (set) Token: 0x06000D2F RID: 3375 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000164")]
	public uint EntityId
	{
		[Token(Token = "0x6000D2E")]
		[Address(RVA = "0x457420", Offset = "0x456620", VA = "0x180457420", Slot = "59")]
		[CompilerGenerated]
		get
		{
			return 0U;
		}
		[Token(Token = "0x6000D2F")]
		[Address(RVA = "0x4579D0", Offset = "0x456BD0", VA = "0x1804579D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x17000165 RID: 357
	// (get) Token: 0x06000D30 RID: 3376 RVA: 0x00005748 File Offset: 0x00003948
	[Token(Token = "0x17000165")]
	public int Health
	{
		[Token(Token = "0x6000D30")]
		[Address(RVA = "0x4574D0", Offset = "0x4566D0", VA = "0x1804574D0")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000166 RID: 358
	// (get) Token: 0x06000D31 RID: 3377 RVA: 0x00005760 File Offset: 0x00003960
	[Token(Token = "0x17000166")]
	public override int Level
	{
		[Token(Token = "0x6000D31")]
		[Address(RVA = "0x4575F0", Offset = "0x4567F0", VA = "0x1804575F0", Slot = "11")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000167 RID: 359
	// (get) Token: 0x06000D32 RID: 3378 RVA: 0x00005778 File Offset: 0x00003978
	[Token(Token = "0x17000167")]
	public override Vec2 HitPosition
	{
		[Token(Token = "0x6000D32")]
		[Address(RVA = "0x457540", Offset = "0x456740", VA = "0x180457540", Slot = "9")]
		get
		{
			return default(Vec2);
		}
	}

	// Token: 0x17000168 RID: 360
	// (get) Token: 0x06000D33 RID: 3379 RVA: 0x00005790 File Offset: 0x00003990
	// (set) Token: 0x06000D34 RID: 3380 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000168")]
	public int? Prestige
	{
		[Token(Token = "0x6000D33")]
		[Address(RVA = "0x388F80", Offset = "0x388180", VA = "0x180388F80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000D34")]
		[Address(RVA = "0x457A30", Offset = "0x456C30", VA = "0x180457A30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x17000169 RID: 361
	// (get) Token: 0x06000D35 RID: 3381 RVA: 0x000057A8 File Offset: 0x000039A8
	// (set) Token: 0x06000D36 RID: 3382 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000169")]
	public EntityMasks TargetMask
	{
		[Token(Token = "0x6000D35")]
		[Address(RVA = "0x457910", Offset = "0x456B10", VA = "0x180457910")]
		[CompilerGenerated]
		get
		{
			return EntityMasks.None;
		}
		[Token(Token = "0x6000D36")]
		[Address(RVA = "0x457A60", Offset = "0x456C60", VA = "0x180457A60")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	// Token: 0x1700016A RID: 362
	// (get) Token: 0x06000D37 RID: 3383 RVA: 0x000057C0 File Offset: 0x000039C0
	// (set) Token: 0x06000D38 RID: 3384 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700016A")]
	public uint StartTime
	{
		[Token(Token = "0x6000D37")]
		[Address(RVA = "0x4577D0", Offset = "0x4569D0", VA = "0x1804577D0")]
		[CompilerGenerated]
		get
		{
			return 0U;
		}
		[Token(Token = "0x6000D38")]
		[Address(RVA = "0x457A50", Offset = "0x456C50", VA = "0x180457A50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x1700016B RID: 363
	// (get) Token: 0x06000D39 RID: 3385 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x1700016B")]
	public ref EntityState State
	{
		[Token(Token = "0x6000D39")]
		[Address(RVA = "0x4577E0", Offset = "0x4569E0", VA = "0x1804577E0")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700016C RID: 364
	// (get) Token: 0x06000D3A RID: 3386 RVA: 0x000057D8 File Offset: 0x000039D8
	[Token(Token = "0x1700016C")]
	public override StatusEffects StatusEffects
	{
		[Token(Token = "0x6000D3A")]
		[Address(RVA = "0x457820", Offset = "0x456A20", VA = "0x180457820", Slot = "12")]
		get
		{
			return StatusEffects.None;
		}
	}

	// Token: 0x1700016D RID: 365
	// (get) Token: 0x06000D3B RID: 3387 RVA: 0x0000206A File Offset: 0x0000026A
	// (set) Token: 0x06000D3C RID: 3388 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700016D")]
	public ObjectDefinition ArmorDefinition
	{
		[Token(Token = "0x6000D3B")]
		[Address(RVA = "0x457300", Offset = "0x456500", VA = "0x180457300")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000D3C")]
		[Address(RVA = "0x457990", Offset = "0x456B90", VA = "0x180457990")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x1700016E RID: 366
	// (get) Token: 0x06000D3D RID: 3389 RVA: 0x0000206A File Offset: 0x0000026A
	// (set) Token: 0x06000D3E RID: 3390 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700016E")]
	public ObjectDefinition WeaponDefinition
	{
		[Token(Token = "0x6000D3D")]
		[Address(RVA = "0x457980", Offset = "0x456B80", VA = "0x180457980")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000D3E")]
		[Address(RVA = "0x457A70", Offset = "0x456C70", VA = "0x180457A70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x1700016F RID: 367
	// (get) Token: 0x06000D3F RID: 3391 RVA: 0x000057F0 File Offset: 0x000039F0
	[Token(Token = "0x1700016F")]
	public Vector3 Top
	{
		[Token(Token = "0x6000D3F")]
		[Address(RVA = "0x457920", Offset = "0x456B20", VA = "0x180457920")]
		get
		{
			return default(Vector3);
		}
	}

	// Token: 0x17000170 RID: 368
	// (get) Token: 0x06000D40 RID: 3392 RVA: 0x00005808 File Offset: 0x00003A08
	[Token(Token = "0x17000170")]
	public Vector3 Middle
	{
		[Token(Token = "0x6000D40")]
		[Address(RVA = "0x457640", Offset = "0x456840", VA = "0x180457640")]
		get
		{
			return default(Vector3);
		}
	}

	// Token: 0x17000171 RID: 369
	// (get) Token: 0x06000D41 RID: 3393 RVA: 0x00005820 File Offset: 0x00003A20
	// (set) Token: 0x06000D42 RID: 3394 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000171")]
	public Vector2 Facing
	{
		[Token(Token = "0x6000D41")]
		[Address(RVA = "0x457480", Offset = "0x456680", VA = "0x180457480")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x6000D42")]
		[Address(RVA = "0x4579E0", Offset = "0x456BE0", VA = "0x1804579E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x17000172 RID: 370
	// (get) Token: 0x06000D43 RID: 3395 RVA: 0x00005838 File Offset: 0x00003A38
	// (set) Token: 0x06000D44 RID: 3396 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000172")]
	public Vector2 LastMoveDelta
	{
		[Token(Token = "0x6000D43")]
		[Address(RVA = "0x4575D0", Offset = "0x4567D0", VA = "0x1804575D0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x6000D44")]
		[Address(RVA = "0x457A00", Offset = "0x456C00", VA = "0x180457A00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x17000173 RID: 371
	// (get) Token: 0x06000D45 RID: 3397 RVA: 0x00005850 File Offset: 0x00003A50
	// (set) Token: 0x06000D46 RID: 3398 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000173")]
	public int MaxArmor
	{
		[Token(Token = "0x6000D45")]
		[Address(RVA = "0x457630", Offset = "0x456830", VA = "0x180457630")]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000D46")]
		[Address(RVA = "0x457A10", Offset = "0x456C10", VA = "0x180457A10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x17000174 RID: 372
	// (get) Token: 0x06000D47 RID: 3399 RVA: 0x00005868 File Offset: 0x00003A68
	// (set) Token: 0x06000D48 RID: 3400 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000174")]
	public int MusicLayer
	{
		[Token(Token = "0x6000D47")]
		[Address(RVA = "0x4576B0", Offset = "0x4568B0", VA = "0x1804576B0")]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000D48")]
		[Address(RVA = "0x457A20", Offset = "0x456C20", VA = "0x180457A20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x17000175 RID: 373
	// (get) Token: 0x06000D49 RID: 3401 RVA: 0x00005880 File Offset: 0x00003A80
	// (set) Token: 0x06000D4A RID: 3402 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000175")]
	public BadgeType Badge
	{
		[Token(Token = "0x6000D49")]
		[Address(RVA = "0x457320", Offset = "0x456520", VA = "0x180457320")]
		[CompilerGenerated]
		get
		{
			return BadgeType.None;
		}
		[Token(Token = "0x6000D4A")]
		[Address(RVA = "0x4579C0", Offset = "0x456BC0", VA = "0x1804579C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x17000176 RID: 374
	// (get) Token: 0x06000D4B RID: 3403 RVA: 0x00005898 File Offset: 0x00003A98
	// (set) Token: 0x06000D4C RID: 3404 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000176")]
	public RankType Rank
	{
		[Token(Token = "0x6000D4B")]
		[Address(RVA = "0x457780", Offset = "0x456980", VA = "0x180457780")]
		[CompilerGenerated]
		get
		{
			return RankType.Guest;
		}
		[Token(Token = "0x6000D4C")]
		[Address(RVA = "0x457A40", Offset = "0x456C40", VA = "0x180457A40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x17000177 RID: 375
	// (get) Token: 0x06000D4D RID: 3405 RVA: 0x000058B0 File Offset: 0x00003AB0
	// (set) Token: 0x06000D4E RID: 3406 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000177")]
	public bool GoingHome
	{
		[Token(Token = "0x6000D4D")]
		[Address(RVA = "0x4574A0", Offset = "0x4566A0", VA = "0x1804574A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000D4E")]
		[Address(RVA = "0x4579F0", Offset = "0x456BF0", VA = "0x1804579F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x17000178 RID: 376
	// (get) Token: 0x06000D4F RID: 3407 RVA: 0x000058C8 File Offset: 0x00003AC8
	[Token(Token = "0x17000178")]
	public override QuestData Quest
	{
		[Token(Token = "0x6000D4F")]
		[Address(RVA = "0x457770", Offset = "0x456970", VA = "0x180457770", Slot = "14")]
		get
		{
			return default(QuestData);
		}
	}

	// Token: 0x17000179 RID: 377
	// (get) Token: 0x06000D50 RID: 3408 RVA: 0x000058E0 File Offset: 0x00003AE0
	[Token(Token = "0x17000179")]
	public bool OnScreen
	{
		[Token(Token = "0x6000D50")]
		[Address(RVA = "0x4576C0", Offset = "0x4568C0", VA = "0x1804576C0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700017A RID: 378
	// (get) Token: 0x06000D51 RID: 3409 RVA: 0x000058F8 File Offset: 0x00003AF8
	[Token(Token = "0x1700017A")]
	protected virtual float AttackSpeedScalar
	{
		[Token(Token = "0x6000D51")]
		[Address(RVA = "0x4328A0", Offset = "0x431AA0", VA = "0x1804328A0", Slot = "60")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x06000D52 RID: 3410 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D52")]
	[Address(RVA = "0x453120", Offset = "0x452320", VA = "0x180453120", Slot = "15")]
	public override void AddToWorld(World world)
	{
	}

	// Token: 0x06000D53 RID: 3411 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D53")]
	[Address(RVA = "0x453100", Offset = "0x452300", VA = "0x180453100")]
	public void AddToWorld(World world, uint entityId)
	{
	}

	// Token: 0x06000D54 RID: 3412 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D54")]
	[Address(RVA = "0x4533A0", Offset = "0x4525A0", VA = "0x1804533A0")]
	public void Attack(uint id, ref AttackOutputData attackOutput)
	{
	}

	// Token: 0x06000D55 RID: 3413 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D55")]
	[Address(RVA = "0x453230", Offset = "0x452430", VA = "0x180453230")]
	public void Attack(uint id, ref AttackOutputData attackOutput, Vec2 coordinates)
	{
	}

	// Token: 0x06000D56 RID: 3414 RVA: 0x00005910 File Offset: 0x00003B10
	[Token(Token = "0x6000D56")]
	[Address(RVA = "0x453700", Offset = "0x452900", VA = "0x180453700", Slot = "19")]
	public override float GetHeight()
	{
		return 0f;
	}

	// Token: 0x06000D57 RID: 3415 RVA: 0x00005928 File Offset: 0x00003B28
	[Token(Token = "0x6000D57")]
	[Address(RVA = "0x4538B0", Offset = "0x452AB0", VA = "0x1804538B0", Slot = "16")]
	public override int GetStatBase(StatType statType)
	{
		return 0;
	}

	// Token: 0x06000D58 RID: 3416 RVA: 0x00005940 File Offset: 0x00003B40
	[Token(Token = "0x6000D58")]
	[Address(RVA = "0x453920", Offset = "0x452B20", VA = "0x180453920")]
	public int GetStatBase(ref EntityState state, StatType statType)
	{
		return 0;
	}

	// Token: 0x06000D59 RID: 3417 RVA: 0x00005958 File Offset: 0x00003B58
	[Token(Token = "0x6000D59")]
	[Address(RVA = "0x453A00", Offset = "0x452C00", VA = "0x180453A00", Slot = "17")]
	public override int GetStatFunctional(StatType statType)
	{
		return 0;
	}

	// Token: 0x06000D5A RID: 3418 RVA: 0x00005970 File Offset: 0x00003B70
	[Token(Token = "0x6000D5A")]
	[Address(RVA = "0x453950", Offset = "0x452B50", VA = "0x180453950")]
	public int GetStatFunctional(ref EntityState state, StatType statType)
	{
		return 0;
	}

	// Token: 0x06000D5B RID: 3419 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D5B")]
	public void HandleData<T>(ref T data) where T : struct
	{
	}

	// Token: 0x06000D5C RID: 3420 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D5C")]
	[Address(RVA = "0x454560", Offset = "0x453760", VA = "0x180454560", Slot = "36")]
	public void HandleData(ref ArmorData data)
	{
	}

	// Token: 0x06000D5D RID: 3421 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D5D")]
	[Address(RVA = "0x453B40", Offset = "0x452D40", VA = "0x180453B40", Slot = "37")]
	public void HandleData(ref BadgeData data)
	{
	}

	// Token: 0x06000D5E RID: 3422 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D5E")]
	[Address(RVA = "0x454230", Offset = "0x453430", VA = "0x180454230", Slot = "38")]
	public void HandleData(ref DeadData data)
	{
	}

	// Token: 0x06000D5F RID: 3423 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D5F")]
	[Address(RVA = "0x454540", Offset = "0x453740", VA = "0x180454540", Slot = "39")]
	public void HandleData(ref DeathNoteData data)
	{
	}

	// Token: 0x06000D60 RID: 3424 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D60")]
	[Address(RVA = "0x453FB0", Offset = "0x4531B0", VA = "0x180453FB0", Slot = "40")]
	public void HandleData(ref EffectData data)
	{
	}

	// Token: 0x06000D61 RID: 3425 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D61")]
	[Address(RVA = "0x453B70", Offset = "0x452D70", VA = "0x180453B70", Slot = "41")]
	public void HandleData(ref HomeCancelData data)
	{
	}

	// Token: 0x06000D62 RID: 3426 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D62")]
	[Address(RVA = "0x454550", Offset = "0x453750", VA = "0x180454550", Slot = "42")]
	public void HandleData(ref HomeStartData data)
	{
	}

	// Token: 0x06000D63 RID: 3427 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D63")]
	[Address(RVA = "0x454280", Offset = "0x453480", VA = "0x180454280", Slot = "43")]
	public void HandleData(ref KillerData data)
	{
	}

	// Token: 0x06000D64 RID: 3428 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D64")]
	[Address(RVA = "0x454260", Offset = "0x453460", VA = "0x180454260", Slot = "61")]
	public virtual void HandleData(ref LevelData data)
	{
	}

	// Token: 0x06000D65 RID: 3429 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D65")]
	[Address(RVA = "0x453B60", Offset = "0x452D60", VA = "0x180453B60", Slot = "45")]
	public void HandleData(ref MaxArmorData data)
	{
	}

	// Token: 0x06000D66 RID: 3430 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D66")]
	[Address(RVA = "0x4541D0", Offset = "0x4533D0", VA = "0x1804541D0", Slot = "46")]
	public void HandleData(ref MaxHealthData data)
	{
	}

	// Token: 0x06000D67 RID: 3431 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D67")]
	[Address(RVA = "0x453AF0", Offset = "0x452CF0", VA = "0x180453AF0", Slot = "47")]
	public void HandleData(ref NameData data)
	{
	}

	// Token: 0x06000D68 RID: 3432 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D68")]
	[Address(RVA = "0x453C60", Offset = "0x452E60", VA = "0x180453C60", Slot = "48")]
	public void HandleData(ref OtherData data)
	{
	}

	// Token: 0x06000D69 RID: 3433 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D69")]
	[Address(RVA = "0x453C10", Offset = "0x452E10", VA = "0x180453C10", Slot = "49")]
	public void HandleData(ref PositionData data)
	{
	}

	// Token: 0x06000D6A RID: 3434 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D6A")]
	[Address(RVA = "0x453E50", Offset = "0x453050", VA = "0x180453E50", Slot = "50")]
	public void HandleData(ref PrestigeData data)
	{
	}

	// Token: 0x06000D6B RID: 3435 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D6B")]
	[Address(RVA = "0x453C90", Offset = "0x452E90", VA = "0x180453C90", Slot = "51")]
	public void HandleData(ref QuestData data)
	{
	}

	// Token: 0x06000D6C RID: 3436 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D6C")]
	[Address(RVA = "0x4541A0", Offset = "0x4533A0", VA = "0x1804541A0", Slot = "52")]
	public void HandleData(ref QuestCompleteData data)
	{
	}

	// Token: 0x06000D6D RID: 3437 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D6D")]
	[Address(RVA = "0x454420", Offset = "0x453620", VA = "0x180454420", Slot = "53")]
	public void HandleData(ref RankData data)
	{
	}

	// Token: 0x06000D6E RID: 3438 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D6E")]
	[Address(RVA = "0x454440", Offset = "0x453640", VA = "0x180454440", Slot = "54")]
	public void HandleData(ref SfxData data)
	{
	}

	// Token: 0x06000D6F RID: 3439 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D6F")]
	[Address(RVA = "0x453AE0", Offset = "0x452CE0", VA = "0x180453AE0", Slot = "55")]
	public void HandleData(ref TextureData data)
	{
	}

	// Token: 0x06000D70 RID: 3440 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D70")]
	[Address(RVA = "0x453EB0", Offset = "0x4530B0", VA = "0x180453EB0", Slot = "56")]
	public void HandleData(ref UsedData data)
	{
	}

	// Token: 0x06000D71 RID: 3441 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D71")]
	[Address(RVA = "0x454820", Offset = "0x453A20", VA = "0x180454820", Slot = "25")]
	public override void Load(ObjectDefinition definition)
	{
	}

	// Token: 0x06000D72 RID: 3442 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D72")]
	[Address(RVA = "0x455060", Offset = "0x454260", VA = "0x180455060")]
	public void PlayAbilityGesture(ushort itemType, Vector2 targetCoordinates)
	{
	}

	// Token: 0x06000D73 RID: 3443 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D73")]
	[Address(RVA = "0x455300", Offset = "0x454500", VA = "0x180455300", Slot = "26")]
	public override void RemoveFromWorld()
	{
	}

	// Token: 0x06000D74 RID: 3444 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D74")]
	[Address(RVA = "0x455590", Offset = "0x454790", VA = "0x180455590")]
	public void SetControl(bool controlled)
	{
	}

	// Token: 0x06000D75 RID: 3445 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D75")]
	[Address(RVA = "0x455860", Offset = "0x454A60", VA = "0x180455860")]
	public void StateUpdate(ref EntityState state)
	{
	}

	// Token: 0x06000D76 RID: 3446 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D76")]
	[Address(RVA = "0x455E30", Offset = "0x455030", VA = "0x180455E30")]
	public void TriggerHitFlash()
	{
	}

	// Token: 0x06000D77 RID: 3447 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D77")]
	[Address(RVA = "0x455E40", Offset = "0x455040", VA = "0x180455E40", Slot = "28")]
	public override void Unload()
	{
	}

	// Token: 0x06000D78 RID: 3448 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D78")]
	[Address(RVA = "0x451250", Offset = "0x450450", VA = "0x180451250")]
	public void UpdateNameGui()
	{
	}

	// Token: 0x06000D79 RID: 3449 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D79")]
	[Address(RVA = "0x4566C0", Offset = "0x4558C0", VA = "0x1804566C0", Slot = "29")]
	public override void WorldMessageDamage(int damage, bool fromPlayer, bool isPlayer, bool trueDamage, bool criticalStrike)
	{
	}

	// Token: 0x06000D7A RID: 3450 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D7A")]
	[Address(RVA = "0x456700", Offset = "0x455900", VA = "0x180456700")]
	public void WorldMessageHeal(int amount)
	{
	}

	// Token: 0x06000D7B RID: 3451 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D7B")]
	[Address(RVA = "0x4568D0", Offset = "0x455AD0", VA = "0x1804568D0")]
	public void WorldMessageLevelUp()
	{
	}

	// Token: 0x06000D7C RID: 3452 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D7C")]
	[Address(RVA = "0x456A40", Offset = "0x455C40", VA = "0x180456A40")]
	public void WorldMessageQuestCompleted(QuestCompleteData data)
	{
	}

	// Token: 0x06000D7D RID: 3453 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D7D")]
	[Address(RVA = "0x456DC0", Offset = "0x455FC0", VA = "0x180456DC0")]
	public void WorldMessageQuestProgressed()
	{
	}

	// Token: 0x06000D7E RID: 3454 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D7E")]
	[Address(RVA = "0x456ED0", Offset = "0x4560D0", VA = "0x180456ED0")]
	public void WorldMessageQuestStarted(ushort questType)
	{
	}

	// Token: 0x06000D7F RID: 3455 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D7F")]
	[Address(RVA = "0x454960", Offset = "0x453B60", VA = "0x180454960", Slot = "62")]
	protected virtual void OnDisable()
	{
	}

	// Token: 0x06000D80 RID: 3456 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D80")]
	[Address(RVA = "0x4549F0", Offset = "0x453BF0", VA = "0x1804549F0", Slot = "32")]
	protected override void OnEnable()
	{
	}

	// Token: 0x06000D81 RID: 3457 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D81")]
	[Address(RVA = "0x454C60", Offset = "0x453E60", VA = "0x180454C60")]
	private void OnEntityGuiChange(Option obj)
	{
	}

	// Token: 0x06000D82 RID: 3458 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D82")]
	[Address(RVA = "0x4554A0", Offset = "0x4546A0", VA = "0x1804554A0", Slot = "63")]
	protected virtual void SetAppearance(Appearance appearance)
	{
	}

	// Token: 0x06000D83 RID: 3459 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D83")]
	[Address(RVA = "0x4555E0", Offset = "0x4547E0", VA = "0x1804555E0", Slot = "64")]
	protected virtual void SetDead(DeadData deadData)
	{
	}

	// Token: 0x06000D84 RID: 3460 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D84")]
	[Address(RVA = "0x4556C0", Offset = "0x4548C0", VA = "0x1804556C0")]
	protected void SetEntityGuiName(string name)
	{
	}

	// Token: 0x06000D85 RID: 3461 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D85")]
	[Address(RVA = "0x4565B0", Offset = "0x4557B0", VA = "0x1804565B0", Slot = "35")]
	protected override void Update()
	{
	}

	// Token: 0x06000D86 RID: 3462 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D86")]
	[Address(RVA = "0x453570", Offset = "0x452770", VA = "0x180453570")]
	private void ClearStatusEffects()
	{
	}

	// Token: 0x06000D87 RID: 3463 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000D87")]
	[Address(RVA = "0x4537B0", Offset = "0x4529B0", VA = "0x1804537B0")]
	private static string GetPrestige(int prestige)
	{
		return null;
	}

	// Token: 0x06000D88 RID: 3464 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000D88")]
	[Address(RVA = "0x453840", Offset = "0x452A40", VA = "0x180453840")]
	private static string GetQuestName(ushort questType)
	{
		return null;
	}

	// Token: 0x06000D89 RID: 3465 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D89")]
	[Address(RVA = "0x454680", Offset = "0x453880", VA = "0x180454680")]
	private void KilledBy(KillerData killerData)
	{
	}

	// Token: 0x06000D8A RID: 3466 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D8A")]
	[Address(RVA = "0x454CA0", Offset = "0x453EA0", VA = "0x180454CA0")]
	private void OnStatusEffectAdded(StatusEffects effectType)
	{
	}

	// Token: 0x06000D8B RID: 3467 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D8B")]
	[Address(RVA = "0x454F90", Offset = "0x454190", VA = "0x180454F90")]
	private void OnStatusEffectRemoved(StatusEffects effectType)
	{
	}

	// Token: 0x06000D8C RID: 3468 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D8C")]
	[Address(RVA = "0x4556D0", Offset = "0x4548D0", VA = "0x1804556D0")]
	private void SetEntityName(string name)
	{
	}

	// Token: 0x06000D8D RID: 3469 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D8D")]
	[Address(RVA = "0x455710", Offset = "0x454910", VA = "0x180455710")]
	private void SetHome(bool goinghome)
	{
	}

	// Token: 0x06000D8E RID: 3470 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D8E")]
	[Address(RVA = "0x455D50", Offset = "0x454F50", VA = "0x180455D50")]
	private void SyncStatusEffects(StatusEffects newEffects, StatusEffects oldEffects)
	{
	}

	// Token: 0x06000D8F RID: 3471 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D8F")]
	[Address(RVA = "0x455E80", Offset = "0x455080", VA = "0x180455E80")]
	private void UpdateFlash(ref EntityState state)
	{
	}

	// Token: 0x06000D90 RID: 3472 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D90")]
	[Address(RVA = "0x4562E0", Offset = "0x4554E0", VA = "0x1804562E0")]
	private void UpdatePosition(ref EntityState state)
	{
	}

	// Token: 0x06000D91 RID: 3473 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D91")]
	[Address(RVA = "0x4564A0", Offset = "0x4556A0", VA = "0x1804564A0")]
	private void UpdateStatusEffects(StatusEffects statusEffects)
	{
	}

	// Token: 0x06000D92 RID: 3474 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D92")]
	[Address(RVA = "0x457180", Offset = "0x456380", VA = "0x180457180")]
	protected Entity()
	{
	}

	// Token: 0x04000B19 RID: 2841
	[Token(Token = "0x4000B19")]
	[FieldOffset(Offset = "0xF0")]
	public EntityRig Rig;

	// Token: 0x04000B1A RID: 2842
	[Token(Token = "0x4000B1A")]
	[FieldOffset(Offset = "0xF8")]
	public float Opacity;

	// Token: 0x04000B1B RID: 2843
	[Token(Token = "0x4000B1B")]
	[FieldOffset(Offset = "0x100")]
	protected EntityGui Gui;

	// Token: 0x04000B1C RID: 2844
	[Token(Token = "0x4000B1C")]
	[FieldOffset(Offset = "0x160")]
	private readonly Dictionary<Type, object[]> _dataHandlers;

	// Token: 0x04000B1D RID: 2845
	[Token(Token = "0x4000B1D")]
	[FieldOffset(Offset = "0x168")]
	private float _hitFlashTime;

	// Token: 0x04000B1E RID: 2846
	[Token(Token = "0x4000B1E")]
	[FieldOffset(Offset = "0x170")]
	private HomeEffect _homeEffect;

	// Token: 0x04000B1F RID: 2847
	[Token(Token = "0x4000B1F")]
	[FieldOffset(Offset = "0x178")]
	private string _entityName;

	// Token: 0x04000B20 RID: 2848
	[Token(Token = "0x4000B20")]
	[FieldOffset(Offset = "0x180")]
	private readonly Dictionary<StatusEffects, EffectBase> _statusEffectEffects;

	// Token: 0x04000B21 RID: 2849
	[Token(Token = "0x4000B21")]
	[FieldOffset(Offset = "0x188")]
	[NonSerialized]
	private StatusEffects _syncedStatusEffects;

	// Token: 0x04000B22 RID: 2850
	[Token(Token = "0x4000B22")]
	[FieldOffset(Offset = "0x190")]
	private int? _maxHealth;

	// Token: 0x04000B23 RID: 2851
	[Token(Token = "0x4000B23")]
	[FieldOffset(Offset = "0x198")]
	private Option _entityGuiOption;

	// Token: 0x04000B24 RID: 2852
	[Token(Token = "0x4000B24")]
	[FieldOffset(Offset = "0x1A0")]
	private QuestData _quest;

	// Token: 0x04000B25 RID: 2853
	[Token(Token = "0x4000B25")]
	[FieldOffset(Offset = "0x1A8")]
	private QuestEffect _questEffect;
}
