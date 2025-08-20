using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x02000304 RID: 772
[Token(Token = "0x2000304")]
public class TooltipActivator : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler
{
	// Token: 0x170001E9 RID: 489
	// (get) Token: 0x06001137 RID: 4407 RVA: 0x000068E8 File Offset: 0x00004AE8
	[Token(Token = "0x170001E9")]
	private bool ShowsOnHover
	{
		[Token(Token = "0x6001137")]
		[Address(RVA = "0x366500", Offset = "0x365700", VA = "0x180366500")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170001EA RID: 490
	// (get) Token: 0x06001138 RID: 4408 RVA: 0x00006900 File Offset: 0x00004B00
	[Token(Token = "0x170001EA")]
	private bool ShowsOnPress
	{
		[Token(Token = "0x6001138")]
		[Address(RVA = "0x366560", Offset = "0x365760", VA = "0x180366560")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06001139 RID: 4409 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001139")]
	[Address(RVA = "0x365CD0", Offset = "0x364ED0", VA = "0x180365CD0")]
	public void CloseTooltip()
	{
	}

	// Token: 0x0600113A RID: 4410 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600113A")]
	[Address(RVA = "0x365DA0", Offset = "0x364FA0", VA = "0x180365DA0")]
	public void Deselected()
	{
	}

	// Token: 0x0600113B RID: 4411 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600113B")]
	[Address(RVA = "0x3660D0", Offset = "0x3652D0", VA = "0x1803660D0", Slot = "6")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	// Token: 0x0600113C RID: 4412 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600113C")]
	[Address(RVA = "0x366280", Offset = "0x365480", VA = "0x180366280", Slot = "4")]
	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	// Token: 0x0600113D RID: 4413 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600113D")]
	[Address(RVA = "0x366310", Offset = "0x365510", VA = "0x180366310", Slot = "5")]
	public void OnPointerExit(PointerEventData eventData)
	{
	}

	// Token: 0x0600113E RID: 4414 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600113E")]
	[Address(RVA = "0x365C40", Offset = "0x364E40", VA = "0x180365C40")]
	private void Awake()
	{
	}

	// Token: 0x0600113F RID: 4415 RVA: 0x00006918 File Offset: 0x00004B18
	[Token(Token = "0x600113F")]
	[Address(RVA = "0x365E10", Offset = "0x365010", VA = "0x180365E10")]
	private bool DidPress()
	{
		return default(bool);
	}

	// Token: 0x06001140 RID: 4416 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001140")]
	[Address(RVA = "0x3660C0", Offset = "0x3652C0", VA = "0x1803660C0")]
	private void OnDisable()
	{
	}

	// Token: 0x06001141 RID: 4417 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001141")]
	[Address(RVA = "0x365F30", Offset = "0x365130", VA = "0x180365F30")]
	private void LateUpdate()
	{
	}

	// Token: 0x06001142 RID: 4418 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001142")]
	[Address(RVA = "0x366380", Offset = "0x365580", VA = "0x180366380")]
	private void ShowTooltip(Vector2 eventPosition)
	{
	}

	// Token: 0x06001143 RID: 4419 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001143")]
	[Address(RVA = "0x3664F0", Offset = "0x3656F0", VA = "0x1803664F0")]
	public TooltipActivator()
	{
	}

	// Token: 0x04000E35 RID: 3637
	[Token(Token = "0x4000E35")]
	[FieldOffset(Offset = "0x20")]
	public TooltipSource Source;

	// Token: 0x04000E36 RID: 3638
	[Token(Token = "0x4000E36")]
	[FieldOffset(Offset = "0x28")]
	public GameObject ActiveReference;

	// Token: 0x04000E37 RID: 3639
	[Token(Token = "0x4000E37")]
	[FieldOffset(Offset = "0x30")]
	public TooltipBuilder Builder;

	// Token: 0x04000E38 RID: 3640
	[Token(Token = "0x4000E38")]
	[FieldOffset(Offset = "0x38")]
	public bool ShowsOnHoverOverride;

	// Token: 0x04000E39 RID: 3641
	[Token(Token = "0x4000E39")]
	[FieldOffset(Offset = "0x39")]
	public bool ShowsOnPressOverride;

	// Token: 0x04000E3A RID: 3642
	[Token(Token = "0x4000E3A")]
	[FieldOffset(Offset = "0x40")]
	private Tooltip _tooltip;

	// Token: 0x04000E3B RID: 3643
	[Token(Token = "0x4000E3B")]
	[FieldOffset(Offset = "0x48")]
	private bool _didShow;

	// Token: 0x04000E3C RID: 3644
	[Token(Token = "0x4000E3C")]
	[FieldOffset(Offset = "0x4C")]
	private int? _showId;
}
