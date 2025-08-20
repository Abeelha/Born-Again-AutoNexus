using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x0200018E RID: 398
[Token(Token = "0x200018E")]
public class GameObjectGallery : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler
{
	// Token: 0x170000C0 RID: 192
	// (get) Token: 0x060007FA RID: 2042 RVA: 0x00003FF0 File Offset: 0x000021F0
	[Token(Token = "0x170000C0")]
	public int ActiveIndex
	{
		[Token(Token = "0x60007FA")]
		[Address(RVA = "0x412930", Offset = "0x411B30", VA = "0x180412930")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170000C1 RID: 193
	// (get) Token: 0x060007FB RID: 2043 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x170000C1")]
	public GameObject ActiveItem
	{
		[Token(Token = "0x60007FB")]
		[Address(RVA = "0x413A00", Offset = "0x412C00", VA = "0x180413A00")]
		get
		{
			return null;
		}
	}

	// Token: 0x170000C2 RID: 194
	// (get) Token: 0x060007FC RID: 2044 RVA: 0x00004008 File Offset: 0x00002208
	[Token(Token = "0x170000C2")]
	public float IndexPosition
	{
		[Token(Token = "0x60007FC")]
		[Address(RVA = "0x412A30", Offset = "0x411C30", VA = "0x180412A30")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x170000C3 RID: 195
	// (get) Token: 0x060007FD RID: 2045 RVA: 0x00004020 File Offset: 0x00002220
	[Token(Token = "0x170000C3")]
	private bool Dragging
	{
		[Token(Token = "0x60007FD")]
		[Address(RVA = "0x413A90", Offset = "0x412C90", VA = "0x180413A90")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060007FE RID: 2046 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007FE")]
	[Address(RVA = "0x412E90", Offset = "0x412090", VA = "0x180412E90")]
	public void LayoutItems()
	{
	}

	// Token: 0x060007FF RID: 2047 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007FF")]
	[Address(RVA = "0x413170", Offset = "0x412370", VA = "0x180413170", Slot = "4")]
	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	// Token: 0x06000800 RID: 2048 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000800")]
	[Address(RVA = "0x4131F0", Offset = "0x4123F0", VA = "0x1804131F0", Slot = "5")]
	public void OnDrag(PointerEventData eventData)
	{
	}

	// Token: 0x06000801 RID: 2049 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000801")]
	[Address(RVA = "0x413320", Offset = "0x412520", VA = "0x180413320", Slot = "6")]
	public void OnEndDrag(PointerEventData eventData)
	{
	}

	// Token: 0x06000802 RID: 2050 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000802")]
	[Address(RVA = "0x4134F0", Offset = "0x4126F0", VA = "0x1804134F0")]
	public void SelectItem(GameObject item)
	{
	}

	// Token: 0x06000803 RID: 2051 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000803")]
	[Address(RVA = "0x4133D0", Offset = "0x4125D0", VA = "0x1804133D0")]
	public void SelectItemImmediate(int index)
	{
	}

	// Token: 0x06000804 RID: 2052 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000804")]
	[Address(RVA = "0x413470", Offset = "0x412670", VA = "0x180413470")]
	public void SelectItemImmediate(GameObject item)
	{
	}

	// Token: 0x06000805 RID: 2053 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000805")]
	[Address(RVA = "0x413550", Offset = "0x412750", VA = "0x180413550")]
	public void SelectLeft()
	{
	}

	// Token: 0x06000806 RID: 2054 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000806")]
	[Address(RVA = "0x413560", Offset = "0x412760", VA = "0x180413560")]
	public void SelectRight()
	{
	}

	// Token: 0x06000807 RID: 2055 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000807")]
	[Address(RVA = "0x4128B0", Offset = "0x411AB0", VA = "0x1804128B0")]
	private void Awake()
	{
	}

	// Token: 0x06000808 RID: 2056 RVA: 0x00004038 File Offset: 0x00002238
	[Token(Token = "0x6000808")]
	[Address(RVA = "0x412930", Offset = "0x411B30", VA = "0x180412930")]
	private int GetClosestIndex()
	{
		return 0;
	}

	// Token: 0x06000809 RID: 2057 RVA: 0x00004050 File Offset: 0x00002250
	[Token(Token = "0x6000809")]
	[Address(RVA = "0x412980", Offset = "0x411B80", VA = "0x180412980")]
	private float GetContentPosition()
	{
		return 0f;
	}

	// Token: 0x0600080A RID: 2058 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600080A")]
	[Address(RVA = "0x412A50", Offset = "0x411C50", VA = "0x180412A50")]
	private IEnumerable<GameObject> GetItems()
	{
		return null;
	}

	// Token: 0x0600080B RID: 2059 RVA: 0x00004068 File Offset: 0x00002268
	[Token(Token = "0x600080B")]
	[Address(RVA = "0x412A30", Offset = "0x411C30", VA = "0x180412A30")]
	private float GetIndexPosition()
	{
		return 0f;
	}

	// Token: 0x0600080C RID: 2060 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600080C")]
	[Address(RVA = "0x412AD0", Offset = "0x411CD0", VA = "0x180412AD0")]
	private void LateUpdate()
	{
	}

	// Token: 0x0600080D RID: 2061 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600080D")]
	[Address(RVA = "0x4130A0", Offset = "0x4122A0", VA = "0x1804130A0")]
	private void LerpToSelectedIndex()
	{
	}

	// Token: 0x0600080E RID: 2062 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600080E")]
	[Address(RVA = "0x413590", Offset = "0x412790", VA = "0x180413590")]
	private void Start()
	{
	}

	// Token: 0x0600080F RID: 2063 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600080F")]
	[Address(RVA = "0x413850", Offset = "0x412A50", VA = "0x180413850")]
	private void Update()
	{
	}

	// Token: 0x06000810 RID: 2064 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000810")]
	[Address(RVA = "0x4135A0", Offset = "0x4127A0", VA = "0x1804135A0")]
	private void UpdateControllerInput()
	{
	}

	// Token: 0x06000811 RID: 2065 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000811")]
	[Address(RVA = "0x413600", Offset = "0x412800", VA = "0x180413600")]
	private void UpdateItems()
	{
	}

	// Token: 0x06000812 RID: 2066 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000812")]
	[Address(RVA = "0x4137A0", Offset = "0x4129A0", VA = "0x1804137A0")]
	private void UpdateKeyboardInput()
	{
	}

	// Token: 0x06000813 RID: 2067 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000813")]
	[Address(RVA = "0x4139A0", Offset = "0x412BA0", VA = "0x1804139A0")]
	public GameObjectGallery()
	{
	}

	// Token: 0x040007D7 RID: 2007
	[Token(Token = "0x40007D7")]
	[FieldOffset(Offset = "0x20")]
	public RectTransform Content;

	// Token: 0x040007D8 RID: 2008
	[Token(Token = "0x40007D8")]
	[FieldOffset(Offset = "0x28")]
	public int SelectedIndex;

	// Token: 0x040007D9 RID: 2009
	[Token(Token = "0x40007D9")]
	[FieldOffset(Offset = "0x2C")]
	public float Spacing;

	// Token: 0x040007DA RID: 2010
	[Token(Token = "0x40007DA")]
	[FieldOffset(Offset = "0x30")]
	public float LerpScalar;

	// Token: 0x040007DB RID: 2011
	[Token(Token = "0x40007DB")]
	[FieldOffset(Offset = "0x34")]
	public bool AutoLayout;

	// Token: 0x040007DC RID: 2012
	[Token(Token = "0x40007DC")]
	[FieldOffset(Offset = "0x38")]
	public GameObject[] Items;

	// Token: 0x040007DD RID: 2013
	[Token(Token = "0x40007DD")]
	[FieldOffset(Offset = "0x40")]
	private float _position;

	// Token: 0x040007DE RID: 2014
	[Token(Token = "0x40007DE")]
	[FieldOffset(Offset = "0x44")]
	private int? _dragId;

	// Token: 0x040007DF RID: 2015
	[Token(Token = "0x40007DF")]
	[FieldOffset(Offset = "0x4C")]
	private ControllerNavigation _controllerNavigation;

	// Token: 0x040007E0 RID: 2016
	[Token(Token = "0x40007E0")]
	[FieldOffset(Offset = "0x60")]
	private Option _moveLeft;

	// Token: 0x040007E1 RID: 2017
	[Token(Token = "0x40007E1")]
	[FieldOffset(Offset = "0x68")]
	private Option _moveRight;

	// Token: 0x040007E2 RID: 2018
	[Token(Token = "0x40007E2")]
	[FieldOffset(Offset = "0x70")]
	private KeyRepeater _leftRepeater;

	// Token: 0x040007E3 RID: 2019
	[Token(Token = "0x40007E3")]
	[FieldOffset(Offset = "0x7C")]
	private KeyRepeater _leftArrowRepeater;

	// Token: 0x040007E4 RID: 2020
	[Token(Token = "0x40007E4")]
	[FieldOffset(Offset = "0x88")]
	private KeyRepeater _rightRepeater;

	// Token: 0x040007E5 RID: 2021
	[Token(Token = "0x40007E5")]
	[FieldOffset(Offset = "0x94")]
	private KeyRepeater _rightArrowRepeater;

	// Token: 0x040007E6 RID: 2022
	[Token(Token = "0x40007E6")]
	[FieldOffset(Offset = "0xA0")]
	private int _sfxIndex;
}
