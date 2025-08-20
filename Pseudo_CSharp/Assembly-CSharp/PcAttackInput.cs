using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200008A RID: 138
[Token(Token = "0x200008A")]
public class PcAttackInput : MonoBehaviour, IControlInput
{
	// Token: 0x17000031 RID: 49
	// (get) Token: 0x0600026B RID: 619 RVA: 0x00002E20 File Offset: 0x00001020
	// (set) Token: 0x0600026C RID: 620 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000031")]
	public bool Active
	{
		[Token(Token = "0x600026B")]
		[Address(RVA = "0x341A70", Offset = "0x340C70", VA = "0x180341A70", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600026C")]
		[Address(RVA = "0x341AB0", Offset = "0x340CB0", VA = "0x180341AB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x17000032 RID: 50
	// (get) Token: 0x0600026D RID: 621 RVA: 0x00002E38 File Offset: 0x00001038
	[Token(Token = "0x17000032")]
	public bool ActiveInHeirarchy
	{
		[Token(Token = "0x600026D")]
		[Address(RVA = "0x333E20", Offset = "0x333020", VA = "0x180333E20", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000033 RID: 51
	// (get) Token: 0x0600026E RID: 622 RVA: 0x00002E50 File Offset: 0x00001050
	// (set) Token: 0x0600026F RID: 623 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000033")]
	public bool Aiming
	{
		[Token(Token = "0x600026E")]
		[Address(RVA = "0x341A80", Offset = "0x340C80", VA = "0x180341A80", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600026F")]
		[Address(RVA = "0x341AC0", Offset = "0x340CC0", VA = "0x180341AC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x17000034 RID: 52
	// (get) Token: 0x06000270 RID: 624 RVA: 0x00002E68 File Offset: 0x00001068
	// (set) Token: 0x06000271 RID: 625 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000034")]
	public float Angle
	{
		[Token(Token = "0x6000270")]
		[Address(RVA = "0x341A90", Offset = "0x340C90", VA = "0x180341A90", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000271")]
		[Address(RVA = "0x341AD0", Offset = "0x340CD0", VA = "0x180341AD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x17000035 RID: 53
	// (get) Token: 0x06000272 RID: 626 RVA: 0x00002E80 File Offset: 0x00001080
	// (set) Token: 0x06000273 RID: 627 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000035")]
	public float Magnitude
	{
		[Token(Token = "0x6000272")]
		[Address(RVA = "0x341AA0", Offset = "0x340CA0", VA = "0x180341AA0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000273")]
		[Address(RVA = "0x341AE0", Offset = "0x340CE0", VA = "0x180341AE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x06000274 RID: 628 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000274")]
	[Address(RVA = "0x341830", Offset = "0x340A30", VA = "0x180341830")]
	private void Awake()
	{
	}

	// Token: 0x06000275 RID: 629 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000275")]
	[Address(RVA = "0x3418E0", Offset = "0x340AE0", VA = "0x1803418E0")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000276 RID: 630 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000276")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public PcAttackInput()
	{
	}

	// Token: 0x04000217 RID: 535
	[Token(Token = "0x4000217")]
	[FieldOffset(Offset = "0x20")]
	public WorldCamera Camera;

	// Token: 0x04000218 RID: 536
	[Token(Token = "0x4000218")]
	[FieldOffset(Offset = "0x28")]
	public World World;

	// Token: 0x04000219 RID: 537
	[Token(Token = "0x4000219")]
	[FieldOffset(Offset = "0x30")]
	private Option _attackOption;

	// Token: 0x0400021A RID: 538
	[Token(Token = "0x400021A")]
	[FieldOffset(Offset = "0x38")]
	private Option _attackTargetingOption;

	// Token: 0x0400021B RID: 539
	[Token(Token = "0x400021B")]
	[FieldOffset(Offset = "0x40")]
	private Option _autoFireToggleOption;

	// Token: 0x0400021C RID: 540
	[Token(Token = "0x400021C")]
	[FieldOffset(Offset = "0x48")]
	private Option _autoFireOption;
}
