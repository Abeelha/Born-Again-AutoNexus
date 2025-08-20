using System;
using Il2CppDummyDll;

// Token: 0x020001F7 RID: 503
[Token(Token = "0x20001F7")]
public abstract class BurstEffectBase : EffectBase
{
	// Token: 0x06000A59 RID: 2649 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A59")]
	[Address(RVA = "0x422330", Offset = "0x421530", VA = "0x180422330", Slot = "5")]
	public override void SetWorld(World world)
	{
	}

	// Token: 0x06000A5A RID: 2650 RVA: 0x00004A58 File Offset: 0x00002C58
	[Token(Token = "0x6000A5A")]
	[Address(RVA = "0x4221E0", Offset = "0x4213E0", VA = "0x1804221E0", Slot = "8")]
	protected virtual bool IsEffectDone()
	{
		return default(bool);
	}

	// Token: 0x06000A5B RID: 2651 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A5B")]
	[Address(RVA = "0x4222A0", Offset = "0x4214A0", VA = "0x1804222A0")]
	protected void Return()
	{
	}

	// Token: 0x06000A5C RID: 2652 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A5C")]
	[Address(RVA = "0x422200", Offset = "0x421400", VA = "0x180422200")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000A5D RID: 2653 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A5D")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	protected BurstEffectBase()
	{
	}
}
