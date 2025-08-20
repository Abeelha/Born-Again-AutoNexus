using System;
using Il2CppDummyDll;
using Ronin.Model.Data;
using UnityEngine;

// Token: 0x020002F6 RID: 758
[Token(Token = "0x20002F6")]
public class ThreadBuilder : ElementBuilder
{
	// Token: 0x060010CF RID: 4303 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010CF")]
	[Address(RVA = "0x35ED90", Offset = "0x35DF90", VA = "0x18035ED90")]
	public ThreadBuilder(GameObject gameObject)
	{
	}

	// Token: 0x060010D0 RID: 4304 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60010D0")]
	[Address(RVA = "0x35EA60", Offset = "0x35DC60", VA = "0x18035EA60")]
	public ThreadBuilder Blessings(BlessingsData data)
	{
		return null;
	}

	// Token: 0x060010D1 RID: 4305 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60010D1")]
	[Address(RVA = "0x3505F0", Offset = "0x34F7F0", VA = "0x1803505F0")]
	public ThreadBuilder Offset(Vector2 offset)
	{
		return null;
	}

	// Token: 0x060010D2 RID: 4306 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60010D2")]
	[Address(RVA = "0x35EB40", Offset = "0x35DD40", VA = "0x18035EB40")]
	public ThreadBuilder Pivot(Vector2 pivot)
	{
		return null;
	}

	// Token: 0x060010D3 RID: 4307 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60010D3")]
	[Address(RVA = "0x357C80", Offset = "0x356E80", VA = "0x180357C80")]
	public ThreadBuilder Scale(Vector2 scale)
	{
		return null;
	}

	// Token: 0x060010D4 RID: 4308 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60010D4")]
	[Address(RVA = "0x35ECF0", Offset = "0x35DEF0", VA = "0x18035ECF0")]
	public ThreadBuilder StartVisibility(bool visible)
	{
		return null;
	}

	// Token: 0x060010D5 RID: 4309 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010D5")]
	[Address(RVA = "0x35EBD0", Offset = "0x35DDD0", VA = "0x18035EBD0", Slot = "6")]
	protected override void SetPosition(Vector2 position)
	{
	}

	// Token: 0x04000DE8 RID: 3560
	[Token(Token = "0x4000DE8")]
	[FieldOffset(Offset = "0x28")]
	private readonly BlessingStrand _strand;

	// Token: 0x04000DE9 RID: 3561
	[Token(Token = "0x4000DE9")]
	[FieldOffset(Offset = "0x30")]
	private Vector2 _size;
}
