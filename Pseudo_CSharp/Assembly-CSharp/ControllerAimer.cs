using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Ronin.Model.Definitions;
using UnityEngine;
using UnityEngine.InputSystem.Controls;

// Token: 0x020001DA RID: 474
[Token(Token = "0x20001DA")]
public class ControllerAimer : Aimer
{
	// Token: 0x170000E8 RID: 232
	// (get) Token: 0x0600098D RID: 2445 RVA: 0x00004638 File Offset: 0x00002838
	[Token(Token = "0x170000E8")]
	public override InputType InputType
	{
		[Token(Token = "0x600098D")]
		[Address(RVA = "0x424260", Offset = "0x423460", VA = "0x180424260", Slot = "4")]
		get
		{
			return InputType.Keyboard;
		}
	}

	// Token: 0x0600098E RID: 2446 RVA: 0x00004650 File Offset: 0x00002850
	[Token(Token = "0x600098E")]
	[Address(RVA = "0x423BD0", Offset = "0x422DD0", VA = "0x180423BD0", Slot = "5")]
	public override Vector2 GetUseTarget(int index)
	{
		return default(Vector2);
	}

	// Token: 0x0600098F RID: 2447 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600098F")]
	[Address(RVA = "0x424170", Offset = "0x423370", VA = "0x180424170", Slot = "7")]
	protected override void OnShowGizmo(int index, ItemDefinition itemDefinition, GameObject sender, [Optional] int? pointerId)
	{
	}

	// Token: 0x06000990 RID: 2448 RVA: 0x00004668 File Offset: 0x00002868
	[Token(Token = "0x6000990")]
	[Address(RVA = "0x423ED0", Offset = "0x4230D0", VA = "0x180423ED0")]
	private Vector2 GetUseVector(Entity controlled, float maxRange)
	{
		return default(Vector2);
	}

	// Token: 0x06000991 RID: 2449 RVA: 0x00004680 File Offset: 0x00002880
	[Token(Token = "0x6000991")]
	[Address(RVA = "0x423B00", Offset = "0x422D00", VA = "0x180423B00")]
	private Vector2? GetStickVector(StickControl stick)
	{
		return null;
	}

	// Token: 0x06000992 RID: 2450 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000992")]
	[Address(RVA = "0x4241E0", Offset = "0x4233E0", VA = "0x1804241E0")]
	public ControllerAimer()
	{
	}

	// Token: 0x040008EF RID: 2287
	[Token(Token = "0x40008EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly Dictionary<int, ValueTuple<float, float>> _ranges;
}
