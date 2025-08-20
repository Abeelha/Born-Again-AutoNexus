using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x020001C9 RID: 457
[Token(Token = "0x20001C9")]
[ExecuteInEditMode]
public abstract class OptionSetter : MonoBehaviour
{
	// Token: 0x170000E5 RID: 229
	// (get) Token: 0x06000939 RID: 2361 RVA: 0x0000206A File Offset: 0x0000026A
	// (set) Token: 0x0600093A RID: 2362 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000E5")]
	private protected Option Option
	{
		[Token(Token = "0x6000939")]
		[Address(RVA = "0x3944E0", Offset = "0x3936E0", VA = "0x1803944E0")]
		[CompilerGenerated]
		protected get
		{
			return null;
		}
		[Token(Token = "0x600093A")]
		[Address(RVA = "0x394520", Offset = "0x393720", VA = "0x180394520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x0600093B RID: 2363 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600093B")]
	[Address(RVA = "0x42C4A0", Offset = "0x42B6A0", VA = "0x18042C4A0")]
	public void LanguageChanged()
	{
	}

	// Token: 0x0600093C RID: 2364 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600093C")]
	[Address(RVA = "0x316090", Offset = "0x315290", VA = "0x180316090", Slot = "4")]
	protected virtual void OnOptionChanged()
	{
	}

	// Token: 0x0600093D RID: 2365 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600093D")]
	[Address(RVA = "0x42C3B0", Offset = "0x42B5B0", VA = "0x18042C3B0")]
	private void Awake()
	{
	}

	// Token: 0x0600093E RID: 2366 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600093E")]
	[Address(RVA = "0x42C500", Offset = "0x42B700", VA = "0x18042C500")]
	private void OnDestroy()
	{
	}

	// Token: 0x0600093F RID: 2367 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600093F")]
	[Address(RVA = "0x42C4E0", Offset = "0x42B6E0", VA = "0x18042C4E0")]
	private void OnChange(Option obj)
	{
	}

	// Token: 0x06000940 RID: 2368 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000940")]
	[Address(RVA = "0x42C590", Offset = "0x42B790", VA = "0x18042C590")]
	private void SetTitle()
	{
	}

	// Token: 0x06000941 RID: 2369 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000941")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	protected OptionSetter()
	{
	}

	// Token: 0x040008C7 RID: 2247
	[Token(Token = "0x40008C7")]
	[FieldOffset(Offset = "0x20")]
	public OptionType Type;

	// Token: 0x040008C8 RID: 2248
	[Token(Token = "0x40008C8")]
	[FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI TitleLabel;

	// Token: 0x040008C9 RID: 2249
	[Token(Token = "0x40008C9")]
	[FieldOffset(Offset = "0x30")]
	public string TitleOverride;
}
