using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x02000169 RID: 361
[Token(Token = "0x2000169")]
public class ButtonSfx : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerDownHandler
{
	// Token: 0x06000724 RID: 1828 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000724")]
	[Address(RVA = "0x3ECBB0", Offset = "0x3EBDB0", VA = "0x1803ECBB0", Slot = "5")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	// Token: 0x06000725 RID: 1829 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000725")]
	[Address(RVA = "0x3ECD20", Offset = "0x3EBF20", VA = "0x1803ECD20", Slot = "4")]
	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	// Token: 0x06000726 RID: 1830 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000726")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public ButtonSfx()
	{
	}

	// Token: 0x04000717 RID: 1815
	[Token(Token = "0x4000717")]
	[FieldOffset(Offset = "0x20")]
	public string HoverSfx;

	// Token: 0x04000718 RID: 1816
	[Token(Token = "0x4000718")]
	[FieldOffset(Offset = "0x28")]
	public string ClickSfx;

	// Token: 0x04000719 RID: 1817
	[Token(Token = "0x4000719")]
	[FieldOffset(Offset = "0x30")]
	private SfxClip _hoverClip;

	// Token: 0x0400071A RID: 1818
	[Token(Token = "0x400071A")]
	[FieldOffset(Offset = "0x38")]
	private SfxClip _clickClip;
}
