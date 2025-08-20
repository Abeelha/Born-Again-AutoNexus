using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x020001BA RID: 442
[Token(Token = "0x20001BA")]
public class MenuSelected : MonoBehaviour
{
	// Token: 0x060008EF RID: 2287 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008EF")]
	[Address(RVA = "0x416B10", Offset = "0x415D10", VA = "0x180416B10")]
	private void Awake()
	{
	}

	// Token: 0x060008F0 RID: 2288 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008F0")]
	[Address(RVA = "0x416BA0", Offset = "0x415DA0", VA = "0x180416BA0")]
	private void LateUpdate()
	{
	}

	// Token: 0x060008F1 RID: 2289 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008F1")]
	[Address(RVA = "0x416C30", Offset = "0x415E30", VA = "0x180416C30")]
	private void SetSelected(bool selected)
	{
	}

	// Token: 0x060008F2 RID: 2290 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008F2")]
	[Address(RVA = "0x416CE0", Offset = "0x415EE0", VA = "0x180416CE0")]
	public MenuSelected()
	{
	}

	// Token: 0x04000896 RID: 2198
	[Token(Token = "0x4000896")]
	[FieldOffset(Offset = "0x20")]
	public GameObject Menu;

	// Token: 0x04000897 RID: 2199
	[Token(Token = "0x4000897")]
	[FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI Label;

	// Token: 0x04000898 RID: 2200
	[Token(Token = "0x4000898")]
	[FieldOffset(Offset = "0x30")]
	public Color SelectedColor;

	// Token: 0x04000899 RID: 2201
	[Token(Token = "0x4000899")]
	[FieldOffset(Offset = "0x40")]
	public Color UnselectedColor;

	// Token: 0x0400089A RID: 2202
	[Token(Token = "0x400089A")]
	[FieldOffset(Offset = "0x50")]
	private bool _selected;
}
