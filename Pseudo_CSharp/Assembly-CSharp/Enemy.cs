using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Ronin.Model.Definitions;
using Zero.Game.Shared;

// Token: 0x02000289 RID: 649
[Token(Token = "0x2000289")]
public class Enemy : Entity
{
	// Token: 0x17000159 RID: 345
	// (get) Token: 0x06000D1A RID: 3354 RVA: 0x00005640 File Offset: 0x00003840
	// (set) Token: 0x06000D1B RID: 3355 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000159")]
	public byte LootShare
	{
		[Token(Token = "0x6000D1A")]
		[Address(RVA = "0x453090", Offset = "0x452290", VA = "0x180453090")]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000D1B")]
		[Address(RVA = "0x4530F0", Offset = "0x4522F0", VA = "0x1804530F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x1700015A RID: 346
	// (get) Token: 0x06000D1C RID: 3356 RVA: 0x00005658 File Offset: 0x00003858
	[Token(Token = "0x1700015A")]
	public bool ShowName
	{
		[Token(Token = "0x6000D1C")]
		[Address(RVA = "0x4530C0", Offset = "0x4522C0", VA = "0x1804530C0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700015B RID: 347
	// (get) Token: 0x06000D1D RID: 3357 RVA: 0x00005670 File Offset: 0x00003870
	[Token(Token = "0x1700015B")]
	public bool ShowHealthBar
	{
		[Token(Token = "0x6000D1D")]
		[Address(RVA = "0x4530A0", Offset = "0x4522A0", VA = "0x1804530A0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700015C RID: 348
	// (get) Token: 0x06000D1E RID: 3358 RVA: 0x00005688 File Offset: 0x00003888
	[Token(Token = "0x1700015C")]
	public override WorldObjectType Type
	{
		[Token(Token = "0x6000D1E")]
		[Address(RVA = "0x4530E0", Offset = "0x4522E0", VA = "0x1804530E0", Slot = "13")]
		get
		{
			return (WorldObjectType)0;
		}
	}

	// Token: 0x06000D1F RID: 3359 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D1F")]
	[Address(RVA = "0x452D40", Offset = "0x451F40", VA = "0x180452D40", Slot = "15")]
	public override void AddToWorld(World world)
	{
	}

	// Token: 0x06000D20 RID: 3360 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D20")]
	[Address(RVA = "0x452FC0", Offset = "0x4521C0", VA = "0x180452FC0", Slot = "26")]
	public override void RemoveFromWorld()
	{
	}

	// Token: 0x06000D21 RID: 3361 RVA: 0x000056A0 File Offset: 0x000038A0
	[Token(Token = "0x6000D21")]
	[Address(RVA = "0x452E80", Offset = "0x452080", VA = "0x180452E80", Slot = "18")]
	public override int HitBy(Attack attack, Vec2 attackCoordinates, bool fromPlayer)
	{
		return 0;
	}

	// Token: 0x06000D22 RID: 3362 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D22")]
	[Address(RVA = "0x452F50", Offset = "0x452150", VA = "0x180452F50", Slot = "25")]
	public override void Load(ObjectDefinition definition)
	{
	}

	// Token: 0x06000D23 RID: 3363 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D23")]
	[Address(RVA = "0x452F90", Offset = "0x452190", VA = "0x180452F90", Slot = "32")]
	protected override void OnEnable()
	{
	}

	// Token: 0x06000D24 RID: 3364 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D24")]
	[Address(RVA = "0x451250", Offset = "0x450450", VA = "0x180451250")]
	private void OnEnemyNameChanged(Option obj)
	{
	}

	// Token: 0x06000D25 RID: 3365 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D25")]
	[Address(RVA = "0x44F050", Offset = "0x44E250", VA = "0x18044F050")]
	public Enemy()
	{
	}

	// Token: 0x04000B16 RID: 2838
	[Token(Token = "0x4000B16")]
	[FieldOffset(Offset = "0x200")]
	private Option _enemyNameOption;

	// Token: 0x04000B17 RID: 2839
	[Token(Token = "0x4000B17")]
	[FieldOffset(Offset = "0x208")]
	private Option _enemyHealthBarOption;
}
