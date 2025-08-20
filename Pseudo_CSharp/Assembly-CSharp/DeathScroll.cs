using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Ronin.Api.Model.Character;
using Ronin.Model.Data;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000193 RID: 403
[Token(Token = "0x2000193")]
public class DeathScroll : MonoBehaviour
{
	// Token: 0x06000826 RID: 2086 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000826")]
	[Address(RVA = "0x40E1E0", Offset = "0x40D3E0", VA = "0x18040E1E0")]
	public void SetCharacter(int index, string playerName, GetCharacterResponse character)
	{
	}

	// Token: 0x06000827 RID: 2087 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000827")]
	[Address(RVA = "0x40D900", Offset = "0x40CB00", VA = "0x18040D900")]
	private void ExpandScrollTo(RectTransform rectTransform, int spacing = 0)
	{
	}

	// Token: 0x06000828 RID: 2088 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000828")]
	[Address(RVA = "0x40DA40", Offset = "0x40CC40", VA = "0x18040DA40")]
	private BlessingStrand GetBlessingStrand(BlessingsData data)
	{
		return null;
	}

	// Token: 0x06000829 RID: 2089 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000829")]
	[Address(RVA = "0x40DB20", Offset = "0x40CD20", VA = "0x18040DB20")]
	private CharacterImage GetCharacterImage()
	{
		return null;
	}

	// Token: 0x0600082A RID: 2090 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600082A")]
	[Address(RVA = "0x40DBC0", Offset = "0x40CDC0", VA = "0x18040DBC0")]
	private TextMeshProUGUI GetLabel(string text, float fontSize = 7f, [Optional] FontLibrary.FontPair fontPair, [Optional] Color? color, bool autoSize = false)
	{
		return null;
	}

	// Token: 0x0600082B RID: 2091 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600082B")]
	[Address(RVA = "0x40DE40", Offset = "0x40D040", VA = "0x18040DE40")]
	private Image GetObject(Sprite sprite)
	{
		return null;
	}

	// Token: 0x0600082C RID: 2092 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600082C")]
	[Address(RVA = "0x40DF50", Offset = "0x40D150", VA = "0x18040DF50")]
	private Image GetSeparator()
	{
		return null;
	}

	// Token: 0x0600082D RID: 2093 RVA: 0x000040C8 File Offset: 0x000022C8
	[Token(Token = "0x600082D")]
	[Address(RVA = "0x40DFF0", Offset = "0x40D1F0", VA = "0x18040DFF0")]
	private ValueTuple<RectTransform, Slot[]> GetSlots()
	{
		return default(ValueTuple<RectTransform, Slot[]>);
	}

	// Token: 0x0600082E RID: 2094 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600082E")]
	[Address(RVA = "0x40E120", Offset = "0x40D320", VA = "0x18040E120")]
	private void InsertAndPlace(RectTransform rectTransform, float spacing = 0f)
	{
	}

	// Token: 0x0600082F RID: 2095 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600082F")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public DeathScroll()
	{
	}

	// Token: 0x040007F7 RID: 2039
	[Token(Token = "0x40007F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Image Scroll;

	// Token: 0x040007F8 RID: 2040
	[Token(Token = "0x40007F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ScrollRect ScrollRect;

	// Token: 0x040007F9 RID: 2041
	[Token(Token = "0x40007F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public RectTransform ScrollContentContainer;

	// Token: 0x040007FA RID: 2042
	[Token(Token = "0x40007FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public TextMeshProUGUI LabelPrefab;

	// Token: 0x040007FB RID: 2043
	[Token(Token = "0x40007FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject SlotsPrefab;

	// Token: 0x040007FC RID: 2044
	[Token(Token = "0x40007FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Image ObjectPrefab;

	// Token: 0x040007FD RID: 2045
	[Token(Token = "0x40007FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public CharacterImage CharacterImagePrefab;

	// Token: 0x040007FE RID: 2046
	[Token(Token = "0x40007FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Image SeparatorPrefab;

	// Token: 0x040007FF RID: 2047
	[Token(Token = "0x40007FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public BlessingStrand BlessingStrandPrefab;

	// Token: 0x04000800 RID: 2048
	[Token(Token = "0x4000800")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private float _scrollContentHeight;
}
