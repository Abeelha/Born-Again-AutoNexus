using System;
using Il2CppDummyDll;
using Ronin.Model.Structs;
using TMPro;
using UnityEngine.UI;

// Token: 0x020002C3 RID: 707
[Token(Token = "0x20002C3")]
public class SplitMenu : Menu
{
	// Token: 0x170001AD RID: 429
	// (get) Token: 0x06000F1E RID: 3870 RVA: 0x00006030 File Offset: 0x00004230
	[Token(Token = "0x170001AD")]
	private ItemValue DisplaySourceItem
	{
		[Token(Token = "0x6000F1E")]
		[Address(RVA = "0x472E40", Offset = "0x472040", VA = "0x180472E40")]
		get
		{
			return default(ItemValue);
		}
	}

	// Token: 0x06000F1F RID: 3871 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F1F")]
	[Address(RVA = "0x3BD8B0", Offset = "0x3BCAB0", VA = "0x1803BD8B0")]
	public void Cancel()
	{
	}

	// Token: 0x06000F20 RID: 3872 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F20")]
	[Address(RVA = "0x4728F0", Offset = "0x471AF0", VA = "0x1804728F0")]
	public void OnSliderChanged(float value)
	{
	}

	// Token: 0x06000F21 RID: 3873 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F21")]
	[Address(RVA = "0x472790", Offset = "0x471990", VA = "0x180472790")]
	public void OnCountChanged(string value)
	{
	}

	// Token: 0x06000F22 RID: 3874 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F22")]
	[Address(RVA = "0x472970", Offset = "0x471B70", VA = "0x180472970")]
	public void Show(byte slot, ItemValue itemValue)
	{
	}

	// Token: 0x06000F23 RID: 3875 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F23")]
	[Address(RVA = "0x472A90", Offset = "0x471C90", VA = "0x180472A90")]
	public void Split()
	{
	}

	// Token: 0x06000F24 RID: 3876 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F24")]
	[Address(RVA = "0x472D50", Offset = "0x471F50", VA = "0x180472D50")]
	private void UpdateValues()
	{
	}

	// Token: 0x06000F25 RID: 3877 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F25")]
	[Address(RVA = "0x3BC980", Offset = "0x3BBB80", VA = "0x1803BC980")]
	public SplitMenu()
	{
	}

	// Token: 0x04000C82 RID: 3202
	[Token(Token = "0x4000C82")]
	[FieldOffset(Offset = "0x90")]
	public Slider Slider;

	// Token: 0x04000C83 RID: 3203
	[Token(Token = "0x4000C83")]
	[FieldOffset(Offset = "0x98")]
	public TMP_InputField CountInput;

	// Token: 0x04000C84 RID: 3204
	[Token(Token = "0x4000C84")]
	[FieldOffset(Offset = "0xA0")]
	public Slot SourceSlot;

	// Token: 0x04000C85 RID: 3205
	[Token(Token = "0x4000C85")]
	[FieldOffset(Offset = "0xA8")]
	public Slot TargetSlot;

	// Token: 0x04000C86 RID: 3206
	[Token(Token = "0x4000C86")]
	[FieldOffset(Offset = "0xB0")]
	public World World;

	// Token: 0x04000C87 RID: 3207
	[Token(Token = "0x4000C87")]
	[FieldOffset(Offset = "0xB8")]
	private byte _slot;

	// Token: 0x04000C88 RID: 3208
	[Token(Token = "0x4000C88")]
	[FieldOffset(Offset = "0xC0")]
	private long _splitCount;

	// Token: 0x04000C89 RID: 3209
	[Token(Token = "0x4000C89")]
	[FieldOffset(Offset = "0xC8")]
	private ItemValue _sourceItem;

	// Token: 0x04000C8A RID: 3210
	[Token(Token = "0x4000C8A")]
	[FieldOffset(Offset = "0xD2")]
	private ItemValue _targetItem;
}
