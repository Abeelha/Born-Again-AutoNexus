using System;
using Il2CppDummyDll;
using Zero.Game.Client;
using Zero.Game.Shared;

// Token: 0x02000155 RID: 341
[Token(Token = "0x2000155")]
internal class RoninClientPlugin : ClientPlugin
{
	// Token: 0x060006A5 RID: 1701 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006A5")]
	[Address(RVA = "0x3F7150", Offset = "0x3F6350", VA = "0x1803F7150")]
	public RoninClientPlugin(World world, RoninGameService gameService)
	{
	}

	// Token: 0x060006A6 RID: 1702 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006A6")]
	[Address(RVA = "0x3F6F70", Offset = "0x3F6170", VA = "0x1803F6F70", Slot = "4")]
	public override void BuildData(DataBuilder builder)
	{
	}

	// Token: 0x060006A7 RID: 1703 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006A7")]
	[Address(RVA = "0x3F6F80", Offset = "0x3F6180", VA = "0x1803F6F80", Slot = "5")]
	public override void Connected()
	{
	}

	// Token: 0x060006A8 RID: 1704 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006A8")]
	[Address(RVA = "0x3F6FE0", Offset = "0x3F61E0", VA = "0x1803F6FE0", Slot = "6")]
	public override void Connecting()
	{
	}

	// Token: 0x060006A9 RID: 1705 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006A9")]
	[Address(RVA = "0x3F7050", Offset = "0x3F6250", VA = "0x1803F7050", Slot = "7")]
	public override void Disconnected()
	{
	}

	// Token: 0x060006AA RID: 1706 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006AA")]
	[Address(RVA = "0x3F7130", Offset = "0x3F6330", VA = "0x1803F7130", Slot = "8")]
	public override void Update()
	{
	}

	// Token: 0x040006AD RID: 1709
	[Token(Token = "0x40006AD")]
	[FieldOffset(Offset = "0x18")]
	private readonly World _world;

	// Token: 0x040006AE RID: 1710
	[Token(Token = "0x40006AE")]
	[FieldOffset(Offset = "0x20")]
	private readonly RoninGameService _gameService;
}
