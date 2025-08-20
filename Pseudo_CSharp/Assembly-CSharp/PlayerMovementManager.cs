using System;
using Il2CppDummyDll;
using Ronin.Model.Structs;
using Zero.Game.Shared;

// Token: 0x0200025F RID: 607
[Token(Token = "0x200025F")]
public class PlayerMovementManager : Manager
{
	// Token: 0x06000B6B RID: 2923 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B6B")]
	[Address(RVA = "0x43DCC0", Offset = "0x43CEC0", VA = "0x18043DCC0", Slot = "4")]
	public override void NetworkInputUpdate()
	{
	}

	// Token: 0x06000B6C RID: 2924 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B6C")]
	[Address(RVA = "0x43CB50", Offset = "0x43BD50", VA = "0x18043CB50")]
	private void Awake()
	{
	}

	// Token: 0x06000B6D RID: 2925 RVA: 0x00004DB8 File Offset: 0x00002FB8
	[Token(Token = "0x6000B6D")]
	[Address(RVA = "0x43CFB0", Offset = "0x43C1B0", VA = "0x18043CFB0")]
	private bool CanWalk(Vec2 start, Vec2 position)
	{
		return default(bool);
	}

	// Token: 0x06000B6E RID: 2926 RVA: 0x00004DD0 File Offset: 0x00002FD0
	[Token(Token = "0x6000B6E")]
	[Address(RVA = "0x43CC70", Offset = "0x43BE70", VA = "0x18043CC70")]
	private bool CanWalkWithBuffer(Vec2 start, Vec2 position)
	{
		return default(bool);
	}

	// Token: 0x06000B6F RID: 2927 RVA: 0x00004DE8 File Offset: 0x00002FE8
	[Token(Token = "0x6000B6F")]
	[Address(RVA = "0x43D8E0", Offset = "0x43CAE0", VA = "0x18043D8E0")]
	private Vec2 GetFutureCoordinates(Vec2 startCoordinates, byte angleIndex, byte magnitudeIndex, float speed)
	{
		return default(Vec2);
	}

	// Token: 0x06000B70 RID: 2928 RVA: 0x00004E00 File Offset: 0x00003000
	[Token(Token = "0x6000B70")]
	[Address(RVA = "0x43DA00", Offset = "0x43CC00", VA = "0x18043DA00")]
	private ValueTuple<MoveIntent, float> GetNextMove()
	{
		return default(ValueTuple<MoveIntent, float>);
	}

	// Token: 0x06000B71 RID: 2929 RVA: 0x00004E18 File Offset: 0x00003018
	[Token(Token = "0x6000B71")]
	[Address(RVA = "0x43D050", Offset = "0x43C250", VA = "0x18043D050")]
	private byte? GetCollisionSlideAngle(Vec2 current, byte angleIndex, byte magnitudeIndex, float speed)
	{
		return null;
	}

	// Token: 0x06000B72 RID: 2930 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B72")]
	[Address(RVA = "0x43DCD0", Offset = "0x43CED0", VA = "0x18043DCD0")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000B73 RID: 2931 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B73")]
	[Address(RVA = "0x43DD60", Offset = "0x43CF60", VA = "0x18043DD60")]
	private void OnHomeStyleChange(Option obj)
	{
	}

	// Token: 0x06000B74 RID: 2932 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B74")]
	[Address(RVA = "0x43DDB0", Offset = "0x43CFB0", VA = "0x18043DDB0")]
	private void PushMove(MoveIntent move)
	{
	}

	// Token: 0x06000B75 RID: 2933 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B75")]
	[Address(RVA = "0x43E2B0", Offset = "0x43D4B0", VA = "0x18043E2B0")]
	private void Update()
	{
	}

	// Token: 0x06000B76 RID: 2934 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B76")]
	[Address(RVA = "0x43DE60", Offset = "0x43D060", VA = "0x18043DE60")]
	private void UpdateHomeInput()
	{
	}

	// Token: 0x06000B77 RID: 2935 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B77")]
	[Address(RVA = "0x43E0F0", Offset = "0x43D2F0", VA = "0x18043E0F0")]
	private void UpdateMoves()
	{
	}

	// Token: 0x06000B78 RID: 2936 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B78")]
	[Address(RVA = "0x43DFD0", Offset = "0x43D1D0", VA = "0x18043DFD0")]
	private void UpdateMoveForCollision(float moveMagnitude, float speed, ref byte moveAngleIndex, ref byte moveMagnitudeIndex)
	{
	}

	// Token: 0x06000B79 RID: 2937 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B79")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public PlayerMovementManager()
	{
	}

	// Token: 0x04000A20 RID: 2592
	[Token(Token = "0x4000A20")]
	private const float Collision_Buffer = 0.25f;

	// Token: 0x04000A21 RID: 2593
	[Token(Token = "0x4000A21")]
	[FieldOffset(Offset = "0x28")]
	public ControlManager ControlManager;

	// Token: 0x04000A22 RID: 2594
	[Token(Token = "0x4000A22")]
	[FieldOffset(Offset = "0x30")]
	public World World;

	// Token: 0x04000A23 RID: 2595
	[Token(Token = "0x4000A23")]
	[FieldOffset(Offset = "0x38")]
	public TutorialNotificationManager TutorialNotificationManager;

	// Token: 0x04000A24 RID: 2596
	[Token(Token = "0x4000A24")]
	[FieldOffset(Offset = "0x40")]
	private MoveIntent _currentMove;

	// Token: 0x04000A25 RID: 2597
	[Token(Token = "0x4000A25")]
	[FieldOffset(Offset = "0x48")]
	private Option _homeOption;

	// Token: 0x04000A26 RID: 2598
	[Token(Token = "0x4000A26")]
	[FieldOffset(Offset = "0x50")]
	private bool _homeState;

	// Token: 0x04000A27 RID: 2599
	[Token(Token = "0x4000A27")]
	[FieldOffset(Offset = "0x58")]
	private Option _homeStyleOption;

	// Token: 0x04000A28 RID: 2600
	[Token(Token = "0x4000A28")]
	[FieldOffset(Offset = "0x60")]
	private HomeStyle _homeStyle;
}
