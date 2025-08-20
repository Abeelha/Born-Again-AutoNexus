using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Ronin.Model.Definitions;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x020001DB RID: 475
[Token(Token = "0x20001DB")]
public class MobileAimer : Aimer
{
	// Token: 0x170000E9 RID: 233
	// (get) Token: 0x06000993 RID: 2451 RVA: 0x00004698 File Offset: 0x00002898
	[Token(Token = "0x170000E9")]
	public override InputType InputType
	{
		[Token(Token = "0x6000993")]
		[Address(RVA = "0x42ADE0", Offset = "0x429FE0", VA = "0x18042ADE0", Slot = "4")]
		get
		{
			return InputType.Keyboard;
		}
	}

	// Token: 0x170000EA RID: 234
	// (get) Token: 0x06000994 RID: 2452 RVA: 0x000046B0 File Offset: 0x000028B0
	[Token(Token = "0x170000EA")]
	private float MaxKnobDistance
	{
		[Token(Token = "0x6000994")]
		[Address(RVA = "0x42ADF0", Offset = "0x429FF0", VA = "0x18042ADF0")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x06000995 RID: 2453 RVA: 0x000046C8 File Offset: 0x000028C8
	[Token(Token = "0x6000995")]
	[Address(RVA = "0x429AA0", Offset = "0x428CA0", VA = "0x180429AA0", Slot = "5")]
	public override Vector2 GetUseTarget(int index)
	{
		return default(Vector2);
	}

	// Token: 0x06000996 RID: 2454 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000996")]
	[Address(RVA = "0x429F10", Offset = "0x429110", VA = "0x180429F10", Slot = "6")]
	protected override void LateUpdate()
	{
	}

	// Token: 0x06000997 RID: 2455 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000997")]
	[Address(RVA = "0x429F30", Offset = "0x429130", VA = "0x180429F30", Slot = "7")]
	protected override void OnShowGizmo(int index, ItemDefinition itemDefinition, GameObject sender, [Optional] int? pointerId)
	{
	}

	// Token: 0x06000998 RID: 2456 RVA: 0x000046E0 File Offset: 0x000028E0
	[Token(Token = "0x6000998")]
	[Address(RVA = "0x429830", Offset = "0x428A30", VA = "0x180429830")]
	private static int GetPointerDown()
	{
		return 0;
	}

	// Token: 0x06000999 RID: 2457 RVA: 0x000046F8 File Offset: 0x000028F8
	[Token(Token = "0x6000999")]
	[Address(RVA = "0x4298F0", Offset = "0x428AF0", VA = "0x1804298F0")]
	private static ValueTuple<Vector2, bool> GetPointer(int pointerId)
	{
		return default(ValueTuple<Vector2, bool>);
	}

	// Token: 0x0600099A RID: 2458 RVA: 0x00004710 File Offset: 0x00002910
	[Token(Token = "0x600099A")]
	[Address(RVA = "0x429C80", Offset = "0x428E80", VA = "0x180429C80")]
	private bool IsCancelled(Vector2 position)
	{
		return default(bool);
	}

	// Token: 0x0600099B RID: 2459 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600099B")]
	[Address(RVA = "0x42A530", Offset = "0x429730", VA = "0x18042A530")]
	private void SetActive(bool active)
	{
	}

	// Token: 0x0600099C RID: 2460 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600099C")]
	[Address(RVA = "0x42A640", Offset = "0x429840", VA = "0x18042A640")]
	private void SetKnobLocalPosition(Vector2 positionVector)
	{
	}

	// Token: 0x0600099D RID: 2461 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600099D")]
	[Address(RVA = "0x42A860", Offset = "0x429A60", VA = "0x18042A860")]
	private void SetKnobScreenPosition(Vector2 position)
	{
	}

	// Token: 0x0600099E RID: 2462 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600099E")]
	[Address(RVA = "0x42A970", Offset = "0x429B70", VA = "0x18042A970")]
	private void UpdateKnob()
	{
	}

	// Token: 0x0600099F RID: 2463 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600099F")]
	[Address(RVA = "0x42AD60", Offset = "0x429F60", VA = "0x18042AD60")]
	public MobileAimer()
	{
	}

	// Token: 0x040008F0 RID: 2288
	[Token(Token = "0x40008F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public UseManager UseManager;

	// Token: 0x040008F1 RID: 2289
	[Token(Token = "0x40008F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Image Base;

	// Token: 0x040008F2 RID: 2290
	[Token(Token = "0x40008F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Image Knob;

	// Token: 0x040008F3 RID: 2291
	[Token(Token = "0x40008F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Image Shaft;

	// Token: 0x040008F4 RID: 2292
	[Token(Token = "0x40008F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject[] BottomRights;

	// Token: 0x040008F5 RID: 2293
	[Token(Token = "0x40008F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GameObject CancelArea;

	// Token: 0x040008F6 RID: 2294
	[Token(Token = "0x40008F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public GraphicRaycaster Raycaster;

	// Token: 0x040008F7 RID: 2295
	[Token(Token = "0x40008F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private int? _pointerId;

	// Token: 0x040008F8 RID: 2296
	[Token(Token = "0x40008F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private byte _useIndex;

	// Token: 0x040008F9 RID: 2297
	[Token(Token = "0x40008F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private float _minRange;

	// Token: 0x040008FA RID: 2298
	[Token(Token = "0x40008FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private float _maxRange;

	// Token: 0x040008FB RID: 2299
	[Token(Token = "0x40008FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private Vector2 _useVector;

	// Token: 0x040008FC RID: 2300
	[Token(Token = "0x40008FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private readonly List<RaycastResult> _results;
}
