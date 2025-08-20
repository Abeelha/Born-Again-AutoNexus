using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Ronin.Model.Definitions;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x02000296 RID: 662
[Token(Token = "0x2000296")]
public sealed class BlessingIcon : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IDragHandler, IBeginDragHandler, IEndDragHandler, ICancelHandler
{
	// Token: 0x1700019C RID: 412
	// (get) Token: 0x06000E24 RID: 3620 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x1700019C")]
	public RectTransform RectTransform
	{
		[Token(Token = "0x6000E24")]
		[Address(RVA = "0x44BED0", Offset = "0x44B0D0", VA = "0x18044BED0")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700019D RID: 413
	// (get) Token: 0x06000E25 RID: 3621 RVA: 0x00005DD8 File Offset: 0x00003FD8
	[Token(Token = "0x1700019D")]
	private bool IsLiveBlessing
	{
		[Token(Token = "0x6000E25")]
		[Address(RVA = "0x44BE00", Offset = "0x44B000", VA = "0x18044BE00")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000E26 RID: 3622 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E26")]
	[Address(RVA = "0x44B770", Offset = "0x44A970", VA = "0x18044B770", Slot = "6")]
	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	// Token: 0x06000E27 RID: 3623 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E27")]
	[Address(RVA = "0x44B860", Offset = "0x44AA60", VA = "0x18044B860", Slot = "8")]
	public void OnCancel(BaseEventData eventData)
	{
	}

	// Token: 0x06000E28 RID: 3624 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E28")]
	[Address(RVA = "0x44B8A0", Offset = "0x44AAA0", VA = "0x18044B8A0", Slot = "5")]
	public void OnDrag(PointerEventData eventData)
	{
	}

	// Token: 0x06000E29 RID: 3625 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E29")]
	[Address(RVA = "0x44BAA0", Offset = "0x44ACA0", VA = "0x18044BAA0", Slot = "7")]
	public void OnEndDrag(PointerEventData eventData)
	{
	}

	// Token: 0x06000E2A RID: 3626 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E2A")]
	[Address(RVA = "0x44BAE0", Offset = "0x44ACE0", VA = "0x18044BAE0", Slot = "4")]
	public void OnPointerClick(PointerEventData eventData)
	{
	}

	// Token: 0x06000E2B RID: 3627 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E2B")]
	[Address(RVA = "0x44BCA0", Offset = "0x44AEA0", VA = "0x18044BCA0")]
	public void SetBlessing(int index, ObjectDefinition blessing, int count, [Optional] Sprite sprite)
	{
	}

	// Token: 0x06000E2C RID: 3628 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E2C")]
	[Address(RVA = "0x44B620", Offset = "0x44A820", VA = "0x18044B620")]
	private void DoOptions()
	{
	}

	// Token: 0x06000E2D RID: 3629 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E2D")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public BlessingIcon()
	{
	}

	// Token: 0x04000B6B RID: 2923
	[Token(Token = "0x4000B6B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Image Image;

	// Token: 0x04000B6C RID: 2924
	[Token(Token = "0x4000B6C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool Removable;

	// Token: 0x04000B6D RID: 2925
	[Token(Token = "0x4000B6D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int Index;

	// Token: 0x04000B6E RID: 2926
	[Token(Token = "0x4000B6E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ObjectDefinition Blessing;

	// Token: 0x04000B6F RID: 2927
	[Token(Token = "0x4000B6F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int Count;

	// Token: 0x04000B70 RID: 2928
	[Token(Token = "0x4000B70")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public TextMeshProUGUI CountLabel;

	// Token: 0x04000B71 RID: 2929
	[Token(Token = "0x4000B71")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ContextActions ContextActions;

	// Token: 0x04000B72 RID: 2930
	[Token(Token = "0x4000B72")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public World World;

	// Token: 0x04000B73 RID: 2931
	[Token(Token = "0x4000B73")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public BlessingStrand BlessingStrand;

	// Token: 0x04000B74 RID: 2932
	[Token(Token = "0x4000B74")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool _didDrag;

	// Token: 0x04000B75 RID: 2933
	[Token(Token = "0x4000B75")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
	private bool _dragging;
}
