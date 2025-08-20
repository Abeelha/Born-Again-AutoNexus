using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.InputSystem.Controls;

// Token: 0x02000088 RID: 136
[Token(Token = "0x2000088")]
public class ControllerInput : MonoBehaviour, IControlInput
{
	// Token: 0x17000026 RID: 38
	// (get) Token: 0x06000256 RID: 598 RVA: 0x00002D78 File Offset: 0x00000F78
	// (set) Token: 0x06000257 RID: 599 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000026")]
	public bool Active
	{
		[Token(Token = "0x6000256")]
		[Address(RVA = "0x333E50", Offset = "0x333050", VA = "0x180333E50", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000257")]
		[Address(RVA = "0x333E90", Offset = "0x333090", VA = "0x180333E90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x17000027 RID: 39
	// (get) Token: 0x06000258 RID: 600 RVA: 0x00002D90 File Offset: 0x00000F90
	[Token(Token = "0x17000027")]
	public bool ActiveInHeirarchy
	{
		[Token(Token = "0x6000258")]
		[Address(RVA = "0x333E20", Offset = "0x333020", VA = "0x180333E20", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000028 RID: 40
	// (get) Token: 0x06000259 RID: 601 RVA: 0x00002DA8 File Offset: 0x00000FA8
	// (set) Token: 0x0600025A RID: 602 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000028")]
	public bool Aiming
	{
		[Token(Token = "0x6000259")]
		[Address(RVA = "0x333E60", Offset = "0x333060", VA = "0x180333E60", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600025A")]
		[Address(RVA = "0x333EA0", Offset = "0x3330A0", VA = "0x180333EA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x17000029 RID: 41
	// (get) Token: 0x0600025B RID: 603 RVA: 0x00002DC0 File Offset: 0x00000FC0
	// (set) Token: 0x0600025C RID: 604 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000029")]
	public float Angle
	{
		[Token(Token = "0x600025B")]
		[Address(RVA = "0x333E70", Offset = "0x333070", VA = "0x180333E70", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return 0f;
		}
		[Token(Token = "0x600025C")]
		[Address(RVA = "0x333EB0", Offset = "0x3330B0", VA = "0x180333EB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x1700002A RID: 42
	// (get) Token: 0x0600025D RID: 605 RVA: 0x00002DD8 File Offset: 0x00000FD8
	// (set) Token: 0x0600025E RID: 606 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700002A")]
	public float Magnitude
	{
		[Token(Token = "0x600025D")]
		[Address(RVA = "0x333E80", Offset = "0x333080", VA = "0x180333E80", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return 0f;
		}
		[Token(Token = "0x600025E")]
		[Address(RVA = "0x333EC0", Offset = "0x3330C0", VA = "0x180333EC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x0600025F RID: 607 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600025F")]
	[Address(RVA = "0x333AA0", Offset = "0x332CA0", VA = "0x180333AA0")]
	private void Awake()
	{
	}

	// Token: 0x06000260 RID: 608 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000260")]
	[Address(RVA = "0x333B00", Offset = "0x332D00", VA = "0x180333B00")]
	private StickControl GetStick()
	{
		return null;
	}

	// Token: 0x06000261 RID: 609 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000261")]
	[Address(RVA = "0x333E10", Offset = "0x333010", VA = "0x180333E10")]
	private void Update()
	{
	}

	// Token: 0x06000262 RID: 610 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000262")]
	[Address(RVA = "0x333C00", Offset = "0x332E00", VA = "0x180333C00")]
	private void UpdateJoystick()
	{
	}

	// Token: 0x06000263 RID: 611 RVA: 0x00002DF0 File Offset: 0x00000FF0
	[Token(Token = "0x6000263")]
	[Address(RVA = "0x333B70", Offset = "0x332D70", VA = "0x180333B70")]
	private bool GetTrigger()
	{
		return default(bool);
	}

	// Token: 0x06000264 RID: 612 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000264")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public ControllerInput()
	{
	}

	// Token: 0x04000210 RID: 528
	[Token(Token = "0x4000210")]
	[FieldOffset(Offset = "0x20")]
	public bool Right;

	// Token: 0x04000211 RID: 529
	[Token(Token = "0x4000211")]
	[FieldOffset(Offset = "0x24")]
	private Vector2 _stickVector;

	// Token: 0x04000212 RID: 530
	[Token(Token = "0x4000212")]
	[FieldOffset(Offset = "0x30")]
	private Option _attackTargetingOption;
}
