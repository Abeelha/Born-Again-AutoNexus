using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x0200008B RID: 139
[Token(Token = "0x200008B")]
public class PcMoveInput : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IControlInput
{
	// Token: 0x17000036 RID: 54
	// (get) Token: 0x06000277 RID: 631 RVA: 0x00002E98 File Offset: 0x00001098
	// (set) Token: 0x06000278 RID: 632 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000036")]
	public bool Active
	{
		[Token(Token = "0x6000277")]
		[Address(RVA = "0x342390", Offset = "0x341590", VA = "0x180342390", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000278")]
		[Address(RVA = "0x3423D0", Offset = "0x3415D0", VA = "0x1803423D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x17000037 RID: 55
	// (get) Token: 0x06000279 RID: 633 RVA: 0x00002EB0 File Offset: 0x000010B0
	[Token(Token = "0x17000037")]
	public bool ActiveInHeirarchy
	{
		[Token(Token = "0x6000279")]
		[Address(RVA = "0x333E20", Offset = "0x333020", VA = "0x180333E20", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000038 RID: 56
	// (get) Token: 0x0600027A RID: 634 RVA: 0x00002EC8 File Offset: 0x000010C8
	[Token(Token = "0x17000038")]
	public bool Aiming
	{
		[Token(Token = "0x600027A")]
		[Address(RVA = "0x3423A0", Offset = "0x3415A0", VA = "0x1803423A0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000039 RID: 57
	// (get) Token: 0x0600027B RID: 635 RVA: 0x00002EE0 File Offset: 0x000010E0
	// (set) Token: 0x0600027C RID: 636 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000039")]
	public float Angle
	{
		[Token(Token = "0x600027B")]
		[Address(RVA = "0x3423B0", Offset = "0x3415B0", VA = "0x1803423B0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return 0f;
		}
		[Token(Token = "0x600027C")]
		[Address(RVA = "0x3423E0", Offset = "0x3415E0", VA = "0x1803423E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x1700003A RID: 58
	// (get) Token: 0x0600027D RID: 637 RVA: 0x00002EF8 File Offset: 0x000010F8
	// (set) Token: 0x0600027E RID: 638 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700003A")]
	public float Magnitude
	{
		[Token(Token = "0x600027D")]
		[Address(RVA = "0x3423C0", Offset = "0x3415C0", VA = "0x1803423C0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return 0f;
		}
		[Token(Token = "0x600027E")]
		[Address(RVA = "0x3423F0", Offset = "0x3415F0", VA = "0x1803423F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x0600027F RID: 639 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600027F")]
	[Address(RVA = "0x341BE0", Offset = "0x340DE0", VA = "0x180341BE0", Slot = "4")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	// Token: 0x06000280 RID: 640 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000280")]
	[Address(RVA = "0x341C10", Offset = "0x340E10", VA = "0x180341C10", Slot = "5")]
	public void OnPointerUp(PointerEventData eventData)
	{
	}

	// Token: 0x06000281 RID: 641 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000281")]
	[Address(RVA = "0x341AF0", Offset = "0x340CF0", VA = "0x180341AF0")]
	private void Awake()
	{
	}

	// Token: 0x06000282 RID: 642 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000282")]
	[Address(RVA = "0x342210", Offset = "0x341410", VA = "0x180342210")]
	private void Update()
	{
	}

	// Token: 0x06000283 RID: 643 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000283")]
	[Address(RVA = "0x3420D0", Offset = "0x3412D0", VA = "0x1803420D0")]
	private void UpdateKeys()
	{
	}

	// Token: 0x06000284 RID: 644 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000284")]
	[Address(RVA = "0x341E60", Offset = "0x341060", VA = "0x180341E60")]
	private void UpdateActive()
	{
	}

	// Token: 0x06000285 RID: 645 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000285")]
	[Address(RVA = "0x341EA0", Offset = "0x3410A0", VA = "0x180341EA0")]
	private void UpdateDrag()
	{
	}

	// Token: 0x06000286 RID: 646 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000286")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public PcMoveInput()
	{
	}

	// Token: 0x04000221 RID: 545
	[Token(Token = "0x4000221")]
	[FieldOffset(Offset = "0x20")]
	public World World;

	// Token: 0x04000222 RID: 546
	[Token(Token = "0x4000222")]
	[FieldOffset(Offset = "0x28")]
	private bool _held;

	// Token: 0x04000223 RID: 547
	[Token(Token = "0x4000223")]
	[FieldOffset(Offset = "0x29")]
	private bool _dragging;

	// Token: 0x04000224 RID: 548
	[Token(Token = "0x4000224")]
	[FieldOffset(Offset = "0x2C")]
	private Vector2 _moveVector;

	// Token: 0x04000225 RID: 549
	[Token(Token = "0x4000225")]
	[FieldOffset(Offset = "0x38")]
	private Option _moveRight;

	// Token: 0x04000226 RID: 550
	[Token(Token = "0x4000226")]
	[FieldOffset(Offset = "0x40")]
	private Option _moveUp;

	// Token: 0x04000227 RID: 551
	[Token(Token = "0x4000227")]
	[FieldOffset(Offset = "0x48")]
	private Option _moveLeft;

	// Token: 0x04000228 RID: 552
	[Token(Token = "0x4000228")]
	[FieldOffset(Offset = "0x50")]
	private Option _moveDown;

	// Token: 0x04000229 RID: 553
	[Token(Token = "0x4000229")]
	[FieldOffset(Offset = "0x58")]
	private Option _moveSlow;

	// Token: 0x0400022A RID: 554
	[Token(Token = "0x400022A")]
	[FieldOffset(Offset = "0x60")]
	private Option _mouseMovementOption;
}
