using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x0200019B RID: 411
[Token(Token = "0x200019B")]
public class Joystick : MonoBehaviour, IDragHandler, IEventSystemHandler, IEndDragHandler, IControlInput, ICancelHandler, IPointerDownHandler, IPointerUpHandler
{
	// Token: 0x170000C7 RID: 199
	// (get) Token: 0x0600084D RID: 2125 RVA: 0x000041A0 File Offset: 0x000023A0
	// (set) Token: 0x0600084E RID: 2126 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000C7")]
	public bool Active
	{
		[Token(Token = "0x600084D")]
		[Address(RVA = "0x414B40", Offset = "0x413D40", VA = "0x180414B40", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600084E")]
		[Address(RVA = "0x414BF0", Offset = "0x413DF0", VA = "0x180414BF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x170000C8 RID: 200
	// (get) Token: 0x0600084F RID: 2127 RVA: 0x000041B8 File Offset: 0x000023B8
	[Token(Token = "0x170000C8")]
	public bool ActiveInHeirarchy
	{
		[Token(Token = "0x600084F")]
		[Address(RVA = "0x333E20", Offset = "0x333020", VA = "0x180333E20", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170000C9 RID: 201
	// (get) Token: 0x06000850 RID: 2128 RVA: 0x000041D0 File Offset: 0x000023D0
	[Token(Token = "0x170000C9")]
	public bool Aiming
	{
		[Token(Token = "0x6000850")]
		[Address(RVA = "0x3423A0", Offset = "0x3415A0", VA = "0x1803423A0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170000CA RID: 202
	// (get) Token: 0x06000851 RID: 2129 RVA: 0x000041E8 File Offset: 0x000023E8
	// (set) Token: 0x06000852 RID: 2130 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000CA")]
	public float Angle
	{
		[Token(Token = "0x6000851")]
		[Address(RVA = "0x414B50", Offset = "0x413D50", VA = "0x180414B50", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000852")]
		[Address(RVA = "0x414C00", Offset = "0x413E00", VA = "0x180414C00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x170000CB RID: 203
	// (get) Token: 0x06000853 RID: 2131 RVA: 0x00004200 File Offset: 0x00002400
	// (set) Token: 0x06000854 RID: 2132 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000CB")]
	public float Magnitude
	{
		[Token(Token = "0x6000853")]
		[Address(RVA = "0x414B60", Offset = "0x413D60", VA = "0x180414B60", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000854")]
		[Address(RVA = "0x414C10", Offset = "0x413E10", VA = "0x180414C10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x170000CC RID: 204
	// (get) Token: 0x06000855 RID: 2133 RVA: 0x00004218 File Offset: 0x00002418
	[Token(Token = "0x170000CC")]
	private float MaxKnobDistance
	{
		[Token(Token = "0x6000855")]
		[Address(RVA = "0x414B70", Offset = "0x413D70", VA = "0x180414B70")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x06000856 RID: 2134 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000856")]
	[Address(RVA = "0x413FB0", Offset = "0x4131B0", VA = "0x180413FB0")]
	private void Awake()
	{
	}

	// Token: 0x06000857 RID: 2135 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000857")]
	[Address(RVA = "0x4140C0", Offset = "0x4132C0", VA = "0x1804140C0")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000858 RID: 2136 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000858")]
	[Address(RVA = "0x414510", Offset = "0x413710", VA = "0x180414510", Slot = "5")]
	public void OnEndDrag(PointerEventData eventData)
	{
	}

	// Token: 0x06000859 RID: 2137 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000859")]
	[Address(RVA = "0x414340", Offset = "0x413540", VA = "0x180414340", Slot = "4")]
	public void OnDrag(PointerEventData eventData)
	{
	}

	// Token: 0x0600085A RID: 2138 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600085A")]
	[Address(RVA = "0x4145A0", Offset = "0x4137A0", VA = "0x1804145A0")]
	private void SetJoystickActive(bool active)
	{
	}

	// Token: 0x0600085B RID: 2139 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600085B")]
	[Address(RVA = "0x414720", Offset = "0x413920", VA = "0x180414720")]
	private void SetKnobLocalPosition(Vector2 positionVector)
	{
	}

	// Token: 0x0600085C RID: 2140 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600085C")]
	[Address(RVA = "0x414A20", Offset = "0x413C20", VA = "0x180414A20")]
	private void SetKnobScreenPosition(Vector2 position)
	{
	}

	// Token: 0x0600085D RID: 2141 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600085D")]
	[Address(RVA = "0x414310", Offset = "0x413510", VA = "0x180414310", Slot = "12")]
	public void OnCancel(BaseEventData eventData)
	{
	}

	// Token: 0x0600085E RID: 2142 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600085E")]
	[Address(RVA = "0x316090", Offset = "0x315290", VA = "0x180316090", Slot = "14")]
	public void OnPointerUp(PointerEventData eventData)
	{
	}

	// Token: 0x0600085F RID: 2143 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600085F")]
	[Address(RVA = "0x316090", Offset = "0x315290", VA = "0x180316090", Slot = "13")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	// Token: 0x06000860 RID: 2144 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000860")]
	[Address(RVA = "0x414B30", Offset = "0x413D30", VA = "0x180414B30")]
	public Joystick()
	{
	}

	// Token: 0x04000812 RID: 2066
	[Token(Token = "0x4000812")]
	[FieldOffset(Offset = "0x20")]
	public Image Base;

	// Token: 0x04000813 RID: 2067
	[Token(Token = "0x4000813")]
	[FieldOffset(Offset = "0x28")]
	public Image Shaft;

	// Token: 0x04000814 RID: 2068
	[Token(Token = "0x4000814")]
	[FieldOffset(Offset = "0x30")]
	public Image Knob;

	// Token: 0x04000815 RID: 2069
	[Token(Token = "0x4000815")]
	[FieldOffset(Offset = "0x38")]
	public bool HideJoystickOnEnd;

	// Token: 0x04000816 RID: 2070
	[Token(Token = "0x4000816")]
	[FieldOffset(Offset = "0x39")]
	public bool AllowKeys;

	// Token: 0x04000817 RID: 2071
	[Token(Token = "0x4000817")]
	[FieldOffset(Offset = "0x3C")]
	public float MaxMagnitude;

	// Token: 0x04000818 RID: 2072
	[Token(Token = "0x4000818")]
	[FieldOffset(Offset = "0x40")]
	public bool DisableMagnitude;

	// Token: 0x04000819 RID: 2073
	[Token(Token = "0x4000819")]
	[FieldOffset(Offset = "0x41")]
	public bool UseFineMovementOption;

	// Token: 0x0400081A RID: 2074
	[Token(Token = "0x400081A")]
	[FieldOffset(Offset = "0x48")]
	private Option _moveRight;

	// Token: 0x0400081B RID: 2075
	[Token(Token = "0x400081B")]
	[FieldOffset(Offset = "0x50")]
	private Option _moveUp;

	// Token: 0x0400081C RID: 2076
	[Token(Token = "0x400081C")]
	[FieldOffset(Offset = "0x58")]
	private Option _moveLeft;

	// Token: 0x0400081D RID: 2077
	[Token(Token = "0x400081D")]
	[FieldOffset(Offset = "0x60")]
	private Option _moveDown;

	// Token: 0x0400081E RID: 2078
	[Token(Token = "0x400081E")]
	[FieldOffset(Offset = "0x68")]
	private Option _moveSlow;

	// Token: 0x0400081F RID: 2079
	[Token(Token = "0x400081F")]
	[FieldOffset(Offset = "0x70")]
	private Option _moveMouse;

	// Token: 0x04000820 RID: 2080
	[Token(Token = "0x4000820")]
	[FieldOffset(Offset = "0x78")]
	private Option _fineMovementOption;

	// Token: 0x04000821 RID: 2081
	[Token(Token = "0x4000821")]
	[FieldOffset(Offset = "0x80")]
	private int? _pointerId;

	// Token: 0x04000822 RID: 2082
	[Token(Token = "0x4000822")]
	[FieldOffset(Offset = "0x88")]
	private bool _dragging;
}
