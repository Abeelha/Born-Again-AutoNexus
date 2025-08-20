using System;
using Il2CppDummyDll;
using Ronin.Model.Enums;

// Token: 0x02000300 RID: 768
[Token(Token = "0x2000300")]
public class SlotTooltipSource : TooltipSource
{
	// Token: 0x170001E1 RID: 481
	// (get) Token: 0x06001111 RID: 4369 RVA: 0x000067F8 File Offset: 0x000049F8
	[Token(Token = "0x170001E1")]
	public override bool CanShow
	{
		[Token(Token = "0x6001111")]
		[Address(RVA = "0x35B440", Offset = "0x35A640", VA = "0x18035B440", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06001112 RID: 4370 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001112")]
	[Address(RVA = "0x35B180", Offset = "0x35A380", VA = "0x18035B180", Slot = "5")]
	public override void Build(TooltipBuilder builder)
	{
	}

	// Token: 0x06001113 RID: 4371 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001113")]
	[Address(RVA = "0x35B0F0", Offset = "0x35A2F0", VA = "0x18035B0F0")]
	private void Awake()
	{
	}

	// Token: 0x06001114 RID: 4372 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6001114")]
	[Address(RVA = "0x35B310", Offset = "0x35A510", VA = "0x18035B310")]
	private Func<StatType, int> GetStatGetter()
	{
		return null;
	}

	// Token: 0x06001115 RID: 4373 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001115")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public SlotTooltipSource()
	{
	}

	// Token: 0x04000E1E RID: 3614
	[Token(Token = "0x4000E1E")]
	[FieldOffset(Offset = "0x28")]
	public Slot Slot;

	// Token: 0x04000E1F RID: 3615
	[Token(Token = "0x4000E1F")]
	[FieldOffset(Offset = "0x30")]
	public StatsDisplay Stats;

	// Token: 0x04000E20 RID: 3616
	[Token(Token = "0x4000E20")]
	[FieldOffset(Offset = "0x38")]
	public World World;
}
