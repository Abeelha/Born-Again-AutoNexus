using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x02000196 RID: 406
[Token(Token = "0x2000196")]
public class ChatInput : MonoBehaviour
{
	// Token: 0x170000C6 RID: 198
	// (get) Token: 0x06000835 RID: 2101 RVA: 0x000040E0 File Offset: 0x000022E0
	// (set) Token: 0x06000836 RID: 2102 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000C6")]
	public bool DidSubmit
	{
		[Token(Token = "0x6000835")]
		[Address(RVA = "0x40B8A0", Offset = "0x40AAA0", VA = "0x18040B8A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000836")]
		[Address(RVA = "0x40B8B0", Offset = "0x40AAB0", VA = "0x18040B8B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x06000837 RID: 2103 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000837")]
	[Address(RVA = "0x40B100", Offset = "0x40A300", VA = "0x18040B100")]
	public void Hide()
	{
	}

	// Token: 0x06000838 RID: 2104 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000838")]
	[Address(RVA = "0x40B5E0", Offset = "0x40A7E0", VA = "0x18040B5E0")]
	public void Show()
	{
	}

	// Token: 0x06000839 RID: 2105 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000839")]
	[Address(RVA = "0x40B710", Offset = "0x40A910", VA = "0x18040B710")]
	public void Show(string placeholder)
	{
	}

	// Token: 0x0600083A RID: 2106 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600083A")]
	[Address(RVA = "0x40B350", Offset = "0x40A550", VA = "0x18040B350")]
	public void Send()
	{
	}

	// Token: 0x0600083B RID: 2107 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600083B")]
	[Address(RVA = "0x40AF40", Offset = "0x40A140", VA = "0x18040AF40")]
	private void AddHistory(string text)
	{
	}

	// Token: 0x0600083C RID: 2108 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600083C")]
	[Address(RVA = "0x40B050", Offset = "0x40A250", VA = "0x18040B050")]
	private void Awake()
	{
	}

	// Token: 0x0600083D RID: 2109 RVA: 0x000040F8 File Offset: 0x000022F8
	[Token(Token = "0x600083D")]
	[Address(RVA = "0x40B180", Offset = "0x40A380", VA = "0x18040B180")]
	private bool IsEmpty(string text)
	{
		return default(bool);
	}

	// Token: 0x0600083E RID: 2110 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600083E")]
	[Address(RVA = "0x40B1E0", Offset = "0x40A3E0", VA = "0x18040B1E0")]
	private void LateUpdate()
	{
	}

	// Token: 0x0600083F RID: 2111 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600083F")]
	[Address(RVA = "0x40B310", Offset = "0x40A510", VA = "0x18040B310")]
	private void OnSubmit(string text)
	{
	}

	// Token: 0x06000840 RID: 2112 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000840")]
	[Address(RVA = "0x40B4E0", Offset = "0x40A6E0", VA = "0x18040B4E0")]
	private void SetRecoveredIndex(int index)
	{
	}

	// Token: 0x06000841 RID: 2113 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000841")]
	[Address(RVA = "0x40B820", Offset = "0x40AA20", VA = "0x18040B820")]
	public ChatInput()
	{
	}

	// Token: 0x04000805 RID: 2053
	[Token(Token = "0x4000805")]
	[FieldOffset(Offset = "0x20")]
	public TMP_InputField InputField;

	// Token: 0x04000806 RID: 2054
	[Token(Token = "0x4000806")]
	[FieldOffset(Offset = "0x28")]
	public RoninGameService GameService;

	// Token: 0x04000807 RID: 2055
	[Token(Token = "0x4000807")]
	[FieldOffset(Offset = "0x30")]
	private bool _didShow;

	// Token: 0x04000808 RID: 2056
	[Token(Token = "0x4000808")]
	[FieldOffset(Offset = "0x38")]
	private readonly List<string> _history;

	// Token: 0x04000809 RID: 2057
	[Token(Token = "0x4000809")]
	[FieldOffset(Offset = "0x40")]
	private int _recoverIndex;
}
