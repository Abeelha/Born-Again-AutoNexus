using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000191 RID: 401
[Token(Token = "0x2000191")]
public class TabSelector : MonoBehaviour
{
	// Token: 0x06000821 RID: 2081 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000821")]
	[Address(RVA = "0x41B660", Offset = "0x41A860", VA = "0x18041B660")]
	private void OnEnable()
	{
	}

	// Token: 0x06000822 RID: 2082 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000822")]
	[Address(RVA = "0x41B740", Offset = "0x41A940", VA = "0x18041B740")]
	public void Select(Button button)
	{
	}

	// Token: 0x06000823 RID: 2083 RVA: 0x000040B0 File Offset: 0x000022B0
	[Token(Token = "0x6000823")]
	[Address(RVA = "0x41B590", Offset = "0x41A790", VA = "0x18041B590")]
	private int GetIndexOfButton(Button button)
	{
		return 0;
	}

	// Token: 0x06000824 RID: 2084 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000824")]
	[Address(RVA = "0x41B8F0", Offset = "0x41AAF0", VA = "0x18041B8F0")]
	private void SetButtonSprite(Button button, Sprite sprite)
	{
	}

	// Token: 0x06000825 RID: 2085 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000825")]
	[Address(RVA = "0x41B980", Offset = "0x41AB80", VA = "0x18041B980")]
	public TabSelector()
	{
	}

	// Token: 0x040007F1 RID: 2033
	[Token(Token = "0x40007F1")]
	[FieldOffset(Offset = "0x20")]
	public Sprite DefaultSprite;

	// Token: 0x040007F2 RID: 2034
	[Token(Token = "0x40007F2")]
	[FieldOffset(Offset = "0x28")]
	public Sprite SelectedSprite;

	// Token: 0x040007F3 RID: 2035
	[Token(Token = "0x40007F3")]
	[FieldOffset(Offset = "0x30")]
	public TabSelector.Tab[] Tabs;

	// Token: 0x040007F4 RID: 2036
	[Token(Token = "0x40007F4")]
	[FieldOffset(Offset = "0x38")]
	private int _selectedTab;

	// Token: 0x02000192 RID: 402
	[Token(Token = "0x2000192")]
	[Serializable]
	public struct Tab
	{
		// Token: 0x040007F5 RID: 2037
		[Token(Token = "0x40007F5")]
		[FieldOffset(Offset = "0x0")]
		public Button Button;

		// Token: 0x040007F6 RID: 2038
		[Token(Token = "0x40007F6")]
		[FieldOffset(Offset = "0x8")]
		public GameObject Content;
	}
}
