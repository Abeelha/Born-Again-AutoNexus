using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x020001F1 RID: 497
[Token(Token = "0x20001F1")]
[RequireComponent(typeof(SpriteRenderer))]
public class WorldButton : MonoBehaviour
{
	// Token: 0x170000F8 RID: 248
	// (get) Token: 0x06000A3E RID: 2622 RVA: 0x000049F8 File Offset: 0x00002BF8
	[Token(Token = "0x170000F8")]
	public Vector2 Size
	{
		[Token(Token = "0x6000A3E")]
		[Address(RVA = "0x4336C0", Offset = "0x4328C0", VA = "0x1804336C0")]
		get
		{
			return default(Vector2);
		}
	}

	// Token: 0x06000A3F RID: 2623 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A3F")]
	[Address(RVA = "0x432FF0", Offset = "0x4321F0", VA = "0x180432FF0")]
	public void Setup(WorldObject interactable, string label, bool localized)
	{
	}

	// Token: 0x06000A40 RID: 2624 RVA: 0x00004A10 File Offset: 0x00002C10
	[Token(Token = "0x6000A40")]
	[Address(RVA = "0x432920", Offset = "0x431B20", VA = "0x180432920")]
	private static WorldButton.State GetState(WorldButton.State currentState, bool mouseOverButton, bool mouseDown, bool mouseUp)
	{
		return WorldButton.State.None;
	}

	// Token: 0x06000A41 RID: 2625 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A41")]
	[Address(RVA = "0x4328B0", Offset = "0x431AB0", VA = "0x1804328B0")]
	private void Awake()
	{
	}

	// Token: 0x06000A42 RID: 2626 RVA: 0x00004A28 File Offset: 0x00002C28
	[Token(Token = "0x6000A42")]
	[Address(RVA = "0x432960", Offset = "0x431B60", VA = "0x180432960")]
	private bool IsMouseOverButton()
	{
		return default(bool);
	}

	// Token: 0x06000A43 RID: 2627 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A43")]
	[Address(RVA = "0x433630", Offset = "0x432830", VA = "0x180433630")]
	private void Update()
	{
	}

	// Token: 0x06000A44 RID: 2628 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A44")]
	[Address(RVA = "0x432E80", Offset = "0x432080", VA = "0x180432E80")]
	private void OnClicked()
	{
	}

	// Token: 0x06000A45 RID: 2629 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A45")]
	[Address(RVA = "0x432FE0", Offset = "0x4321E0", VA = "0x180432FE0")]
	private void OnEnable()
	{
	}

	// Token: 0x06000A46 RID: 2630 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A46")]
	[Address(RVA = "0x433350", Offset = "0x432550", VA = "0x180433350")]
	private void UpdateInput()
	{
	}

	// Token: 0x06000A47 RID: 2631 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A47")]
	[Address(RVA = "0x433570", Offset = "0x432770", VA = "0x180433570")]
	private void UpdateSprite()
	{
	}

	// Token: 0x06000A48 RID: 2632 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A48")]
	[Address(RVA = "0x433640", Offset = "0x432840", VA = "0x180433640")]
	public WorldButton()
	{
	}

	// Token: 0x0400097B RID: 2427
	[Token(Token = "0x400097B")]
	[FieldOffset(Offset = "0x0")]
	public static float ClickedTime;

	// Token: 0x0400097C RID: 2428
	[Token(Token = "0x400097C")]
	[FieldOffset(Offset = "0x20")]
	public Sprite Hovered;

	// Token: 0x0400097D RID: 2429
	[Token(Token = "0x400097D")]
	[FieldOffset(Offset = "0x28")]
	public Sprite Pressed;

	// Token: 0x0400097E RID: 2430
	[Token(Token = "0x400097E")]
	[FieldOffset(Offset = "0x30")]
	public TMP_Text Label;

	// Token: 0x0400097F RID: 2431
	[Token(Token = "0x400097F")]
	[FieldOffset(Offset = "0x38")]
	private SpriteRenderer _spriteRenderer;

	// Token: 0x04000980 RID: 2432
	[Token(Token = "0x4000980")]
	[FieldOffset(Offset = "0x40")]
	private Sprite _normalSprite;

	// Token: 0x04000981 RID: 2433
	[Token(Token = "0x4000981")]
	[FieldOffset(Offset = "0x48")]
	private WorldButton.State _state;

	// Token: 0x04000982 RID: 2434
	[Token(Token = "0x4000982")]
	[FieldOffset(Offset = "0x50")]
	private WorldObject _interactable;

	// Token: 0x04000983 RID: 2435
	[Token(Token = "0x4000983")]
	[FieldOffset(Offset = "0x58")]
	private readonly List<RaycastResult> _raycastResults;

	// Token: 0x04000984 RID: 2436
	[Token(Token = "0x4000984")]
	[FieldOffset(Offset = "0x60")]
	private Option _interactKey;

	// Token: 0x020001F2 RID: 498
	[Token(Token = "0x20001F2")]
	private enum State
	{
		// Token: 0x04000986 RID: 2438
		[Token(Token = "0x4000986")]
		None,
		// Token: 0x04000987 RID: 2439
		[Token(Token = "0x4000987")]
		Hovered,
		// Token: 0x04000988 RID: 2440
		[Token(Token = "0x4000988")]
		Pressed,
		// Token: 0x04000989 RID: 2441
		[Token(Token = "0x4000989")]
		Clicked
	}
}
