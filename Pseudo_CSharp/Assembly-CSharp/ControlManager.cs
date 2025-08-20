using System;
using Il2CppDummyDll;
using Ronin.Model.Data;
using UnityEngine;

// Token: 0x02000256 RID: 598
[Token(Token = "0x2000256")]
public class ControlManager : Manager
{
	// Token: 0x17000116 RID: 278
	// (get) Token: 0x06000B3D RID: 2877 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x17000116")]
	public IControlInput CurrentAttackInput
	{
		[Token(Token = "0x6000B3D")]
		[Address(RVA = "0x437C40", Offset = "0x436E40", VA = "0x180437C40")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000117 RID: 279
	// (get) Token: 0x06000B3E RID: 2878 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x17000117")]
	public IControlInput CurrentMoveInput
	{
		[Token(Token = "0x6000B3E")]
		[Address(RVA = "0x437C50", Offset = "0x436E50", VA = "0x180437C50")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000B3F RID: 2879 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B3F")]
	[Address(RVA = "0x437570", Offset = "0x436770", VA = "0x180437570")]
	public void Drop(byte slot)
	{
	}

	// Token: 0x06000B40 RID: 2880 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B40")]
	[Address(RVA = "0x437690", Offset = "0x436890", VA = "0x180437690", Slot = "4")]
	public override void NetworkInputUpdate()
	{
	}

	// Token: 0x06000B41 RID: 2881 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B41")]
	[Address(RVA = "0x437840", Offset = "0x436A40", VA = "0x180437840", Slot = "6")]
	public override void NewWorld(ref MapInfoData mapInfoData)
	{
	}

	// Token: 0x06000B42 RID: 2882 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B42")]
	[Address(RVA = "0x437A80", Offset = "0x436C80", VA = "0x180437A80")]
	public void Pickup(uint entityId, byte index)
	{
	}

	// Token: 0x06000B43 RID: 2883 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B43")]
	[Address(RVA = "0x4371A0", Offset = "0x4363A0", VA = "0x1804371A0")]
	private void Awake()
	{
	}

	// Token: 0x06000B44 RID: 2884 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000B44")]
	[Address(RVA = "0x4375D0", Offset = "0x4367D0", VA = "0x1804375D0")]
	private IControlInput GetCurrentInput(IControlInput[] inputs)
	{
		return null;
	}

	// Token: 0x06000B45 RID: 2885 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B45")]
	[Address(RVA = "0x4378C0", Offset = "0x436AC0", VA = "0x1804378C0")]
	private void OnAutoFireChange(Option obj)
	{
	}

	// Token: 0x06000B46 RID: 2886 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B46")]
	[Address(RVA = "0x4379F0", Offset = "0x436BF0", VA = "0x1804379F0")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000B47 RID: 2887 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B47")]
	[Address(RVA = "0x437A90", Offset = "0x436C90", VA = "0x180437A90")]
	private void UpdateDrop()
	{
	}

	// Token: 0x06000B48 RID: 2888 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B48")]
	[Address(RVA = "0x437B60", Offset = "0x436D60", VA = "0x180437B60")]
	private void UpdatePickup()
	{
	}

	// Token: 0x06000B49 RID: 2889 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B49")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public ControlManager()
	{
	}

	// Token: 0x040009F6 RID: 2550
	[Token(Token = "0x40009F6")]
	[FieldOffset(Offset = "0x28")]
	public GameObject[] AttackInputs;

	// Token: 0x040009F7 RID: 2551
	[Token(Token = "0x40009F7")]
	[FieldOffset(Offset = "0x30")]
	public GameObject[] MoveInputs;

	// Token: 0x040009F8 RID: 2552
	[Token(Token = "0x40009F8")]
	[FieldOffset(Offset = "0x38")]
	public MobileButtons MobileAttack;

	// Token: 0x040009F9 RID: 2553
	[Token(Token = "0x40009F9")]
	[FieldOffset(Offset = "0x40")]
	public World World;

	// Token: 0x040009FA RID: 2554
	[Token(Token = "0x40009FA")]
	[FieldOffset(Offset = "0x48")]
	public GameObject AutoFireIndicator;

	// Token: 0x040009FB RID: 2555
	[Token(Token = "0x40009FB")]
	[FieldOffset(Offset = "0x50")]
	private uint _pickup;

	// Token: 0x040009FC RID: 2556
	[Token(Token = "0x40009FC")]
	[FieldOffset(Offset = "0x54")]
	private byte _pickupIndex;

	// Token: 0x040009FD RID: 2557
	[Token(Token = "0x40009FD")]
	[FieldOffset(Offset = "0x55")]
	private byte? _dropSlot;

	// Token: 0x040009FE RID: 2558
	[Token(Token = "0x40009FE")]
	[FieldOffset(Offset = "0x58")]
	private Option _autoFireOption;

	// Token: 0x040009FF RID: 2559
	[Token(Token = "0x40009FF")]
	[FieldOffset(Offset = "0x60")]
	public IControlInput[] _attackInputs;

	// Token: 0x04000A00 RID: 2560
	[Token(Token = "0x4000A00")]
	[FieldOffset(Offset = "0x68")]
	public IControlInput[] _moveInputs;
}
