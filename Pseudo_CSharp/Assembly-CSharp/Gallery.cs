using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x02000188 RID: 392
[Token(Token = "0x2000188")]
public class Gallery : MonoBehaviour, IDragHandler, IEventSystemHandler, IEndDragHandler, IBeginDragHandler
{
	// Token: 0x170000B8 RID: 184
	// (get) Token: 0x060007C6 RID: 1990 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x170000B8")]
	public GameObject ActiveItem
	{
		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x4127C0", Offset = "0x4119C0", VA = "0x1804127C0")]
		get
		{
			return null;
		}
	}

	// Token: 0x170000B9 RID: 185
	// (get) Token: 0x060007C7 RID: 1991 RVA: 0x00003F30 File Offset: 0x00002130
	[Token(Token = "0x170000B9")]
	public int CurrentIndexValue
	{
		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x4127D0", Offset = "0x4119D0", VA = "0x1804127D0")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170000BA RID: 186
	// (get) Token: 0x060007C8 RID: 1992 RVA: 0x00003F48 File Offset: 0x00002148
	// (set) Token: 0x060007C9 RID: 1993 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000BA")]
	public int ItemCount
	{
		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x412810", Offset = "0x411A10", VA = "0x180412810")]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x4128A0", Offset = "0x411AA0", VA = "0x1804128A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x170000BB RID: 187
	// (get) Token: 0x060007CA RID: 1994 RVA: 0x00003F60 File Offset: 0x00002160
	// (set) Token: 0x060007CB RID: 1995 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000BB")]
	public float ScrollValue
	{
		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x333E80", Offset = "0x333080", VA = "0x180333E80")]
		[CompilerGenerated]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x333EC0", Offset = "0x3330C0", VA = "0x180333EC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x170000BC RID: 188
	// (get) Token: 0x060007CC RID: 1996 RVA: 0x00003F78 File Offset: 0x00002178
	[Token(Token = "0x170000BC")]
	public float ScrollIndexValue
	{
		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x412880", Offset = "0x411A80", VA = "0x180412880")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x170000BD RID: 189
	// (get) Token: 0x060007CD RID: 1997 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x170000BD")]
	private RectTransform RectTransform
	{
		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x412820", Offset = "0x411A20", VA = "0x180412820")]
		get
		{
			return null;
		}
	}

	// Token: 0x060007CE RID: 1998 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007CE")]
	[Address(RVA = "0x411CE0", Offset = "0x410EE0", VA = "0x180411CE0")]
	public void LayoutChildren()
	{
	}

	// Token: 0x060007CF RID: 1999 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007CF")]
	[Address(RVA = "0x412440", Offset = "0x411640", VA = "0x180412440")]
	public void MoveTo(float scrollValue)
	{
	}

	// Token: 0x060007D0 RID: 2000 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007D0")]
	[Address(RVA = "0x412320", Offset = "0x411520", VA = "0x180412320")]
	public void MoveToIndex(float scrollIndexValue)
	{
	}

	// Token: 0x060007D1 RID: 2001 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007D1")]
	[Address(RVA = "0x412350", Offset = "0x411550", VA = "0x180412350")]
	public void MoveToNextItem()
	{
	}

	// Token: 0x060007D2 RID: 2002 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007D2")]
	[Address(RVA = "0x4123D0", Offset = "0x4115D0", VA = "0x1804123D0")]
	public void MoveToPreviousItem()
	{
	}

	// Token: 0x060007D3 RID: 2003 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007D3")]
	[Address(RVA = "0x412460", Offset = "0x411660", VA = "0x180412460", Slot = "6")]
	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	// Token: 0x060007D4 RID: 2004 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007D4")]
	[Address(RVA = "0x412490", Offset = "0x411690", VA = "0x180412490", Slot = "4")]
	public void OnDrag(PointerEventData eventData)
	{
	}

	// Token: 0x060007D5 RID: 2005 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007D5")]
	[Address(RVA = "0x4124D0", Offset = "0x4116D0", VA = "0x1804124D0", Slot = "5")]
	public void OnEndDrag(PointerEventData eventData)
	{
	}

	// Token: 0x060007D6 RID: 2006 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007D6")]
	[Address(RVA = "0x412530", Offset = "0x411730", VA = "0x180412530")]
	public void SetScrollValue(float value)
	{
	}

	// Token: 0x060007D7 RID: 2007 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007D7")]
	[Address(RVA = "0x412500", Offset = "0x411700", VA = "0x180412500")]
	public void SetScrollIndexValue(float value)
	{
	}

	// Token: 0x060007D8 RID: 2008 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60007D8")]
	[Address(RVA = "0x4119E0", Offset = "0x410BE0", VA = "0x1804119E0")]
	private GameObject GetActiveItem()
	{
		return null;
	}

	// Token: 0x060007D9 RID: 2009 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60007D9")]
	[Address(RVA = "0x411B90", Offset = "0x410D90", VA = "0x180411B90")]
	private IEnumerable<GameObject> GetItems()
	{
		return null;
	}

	// Token: 0x060007DA RID: 2010 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007DA")]
	[Address(RVA = "0x411C10", Offset = "0x410E10", VA = "0x180411C10")]
	private void LateUpdate()
	{
	}

	// Token: 0x060007DB RID: 2011 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007DB")]
	[Address(RVA = "0x411C10", Offset = "0x410E10", VA = "0x180411C10")]
	private void LerpToIndex()
	{
	}

	// Token: 0x060007DC RID: 2012 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007DC")]
	[Address(RVA = "0x4120D0", Offset = "0x4112D0", VA = "0x1804120D0")]
	private void MoveContainer(float delta)
	{
	}

	// Token: 0x060007DD RID: 2013 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007DD")]
	[Address(RVA = "0x412780", Offset = "0x411980", VA = "0x180412780")]
	private void Start()
	{
	}

	// Token: 0x060007DE RID: 2014 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007DE")]
	[Address(RVA = "0x4127B0", Offset = "0x4119B0", VA = "0x1804127B0")]
	public Gallery()
	{
	}

	// Token: 0x040007BD RID: 1981
	[Token(Token = "0x40007BD")]
	[FieldOffset(Offset = "0x20")]
	public RectTransform Container;

	// Token: 0x040007BE RID: 1982
	[Token(Token = "0x40007BE")]
	[FieldOffset(Offset = "0x28")]
	public float HeightRelativeSpacing;

	// Token: 0x040007BF RID: 1983
	[Token(Token = "0x40007BF")]
	[FieldOffset(Offset = "0x2C")]
	private bool _dragging;

	// Token: 0x040007C0 RID: 1984
	[Token(Token = "0x40007C0")]
	[FieldOffset(Offset = "0x30")]
	private int _dragId;

	// Token: 0x040007C1 RID: 1985
	[Token(Token = "0x40007C1")]
	[FieldOffset(Offset = "0x34")]
	private bool _autoMoving;

	// Token: 0x040007C2 RID: 1986
	[Token(Token = "0x40007C2")]
	[FieldOffset(Offset = "0x38")]
	private float _autoMoveTo;
}
