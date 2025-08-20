using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Ronin.Model.Definitions;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x020000C2 RID: 194
[Token(Token = "0x20000C2")]
public class DefinitionPreview : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
{
	// Token: 0x1700004B RID: 75
	// (get) Token: 0x06000355 RID: 853 RVA: 0x0000206A File Offset: 0x0000026A
	// (set) Token: 0x06000356 RID: 854 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700004B")]
	public ObjectDefinition Definition
	{
		[Token(Token = "0x6000355")]
		[Address(RVA = "0x3C3070", Offset = "0x3C2270", VA = "0x1803C3070")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000356")]
		[Address(RVA = "0x3C3080", Offset = "0x3C2280", VA = "0x1803C3080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x06000357 RID: 855 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000357")]
	[Address(RVA = "0x3C2EB0", Offset = "0x3C20B0", VA = "0x1803C2EB0", Slot = "4")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	// Token: 0x06000358 RID: 856 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000358")]
	[Address(RVA = "0x3C2F90", Offset = "0x3C2190", VA = "0x1803C2F90")]
	public void Setup(ObjectDefinition definition, bool selected)
	{
	}

	// Token: 0x06000359 RID: 857 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000359")]
	[Address(RVA = "0x3C3050", Offset = "0x3C2250", VA = "0x1803C3050")]
	public DefinitionPreview()
	{
	}

	// Token: 0x0400033C RID: 828
	[Token(Token = "0x400033C")]
	[FieldOffset(Offset = "0x20")]
	public Color DefaultColor;

	// Token: 0x0400033D RID: 829
	[Token(Token = "0x400033D")]
	[FieldOffset(Offset = "0x30")]
	public Color SelectedColor;

	// Token: 0x0400033E RID: 830
	[Token(Token = "0x400033E")]
	[FieldOffset(Offset = "0x40")]
	public Image Preview;

	// Token: 0x0400033F RID: 831
	[Token(Token = "0x400033F")]
	[FieldOffset(Offset = "0x48")]
	public Image Selection;

	// Token: 0x04000340 RID: 832
	[Token(Token = "0x4000340")]
	[FieldOffset(Offset = "0x50")]
	public DefinitionSelectionMenu DefinitionSelectionMenu;
}
