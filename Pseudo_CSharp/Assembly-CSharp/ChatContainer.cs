using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000181 RID: 385
[Token(Token = "0x2000181")]
public class ChatContainer : MonoBehaviour
{
	// Token: 0x06000783 RID: 1923 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000783")]
	[Address(RVA = "0x409CE0", Offset = "0x408EE0", VA = "0x180409CE0")]
	public void AddChat(Chat chat)
	{
	}

	// Token: 0x06000784 RID: 1924 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000784")]
	[Address(RVA = "0x40A580", Offset = "0x409780", VA = "0x18040A580")]
	public void PageUp()
	{
	}

	// Token: 0x06000785 RID: 1925 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000785")]
	[Address(RVA = "0x40A540", Offset = "0x409740", VA = "0x18040A540")]
	public void PageDown()
	{
	}

	// Token: 0x06000786 RID: 1926 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000786")]
	[Address(RVA = "0x409EA0", Offset = "0x4090A0", VA = "0x180409EA0")]
	private void Awake()
	{
	}

	// Token: 0x06000787 RID: 1927 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000787")]
	[Address(RVA = "0x409F40", Offset = "0x409140", VA = "0x180409F40")]
	private void ClearInactiveChats()
	{
	}

	// Token: 0x06000788 RID: 1928 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000788")]
	[Address(RVA = "0x409FE0", Offset = "0x4091E0", VA = "0x180409FE0")]
	private ChatLine GetChatLine()
	{
		return null;
	}

	// Token: 0x06000789 RID: 1929 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000789")]
	[Address(RVA = "0x40A310", Offset = "0x409510", VA = "0x18040A310")]
	private void LateUpdate()
	{
	}

	// Token: 0x0600078A RID: 1930 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600078A")]
	[Address(RVA = "0x40A640", Offset = "0x409840", VA = "0x18040A640")]
	private void UpdateButtonsActive()
	{
	}

	// Token: 0x0600078B RID: 1931 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600078B")]
	[Address(RVA = "0x40AA70", Offset = "0x409C70", VA = "0x18040AA70")]
	private void UpdateChats(bool resetTime = false)
	{
	}

	// Token: 0x0600078C RID: 1932 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600078C")]
	[Address(RVA = "0x40A760", Offset = "0x409960", VA = "0x18040A760")]
	private void UpdateChatsBackwards()
	{
	}

	// Token: 0x0600078D RID: 1933 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600078D")]
	[Address(RVA = "0x40AE70", Offset = "0x40A070", VA = "0x18040AE70")]
	public ChatContainer()
	{
	}

	// Token: 0x0400078A RID: 1930
	[Token(Token = "0x400078A")]
	private const float ChatLifetime = 18f;

	// Token: 0x0400078B RID: 1931
	[Token(Token = "0x400078B")]
	[FieldOffset(Offset = "0x20")]
	public float Padding;

	// Token: 0x0400078C RID: 1932
	[Token(Token = "0x400078C")]
	[FieldOffset(Offset = "0x28")]
	public ChatLine ChatLinePrefab;

	// Token: 0x0400078D RID: 1933
	[Token(Token = "0x400078D")]
	[FieldOffset(Offset = "0x30")]
	public RectTransform ChatLineParent;

	// Token: 0x0400078E RID: 1934
	[Token(Token = "0x400078E")]
	[FieldOffset(Offset = "0x38")]
	public GameObject PageUpButton;

	// Token: 0x0400078F RID: 1935
	[Token(Token = "0x400078F")]
	[FieldOffset(Offset = "0x40")]
	public GameObject PageDownButton;

	// Token: 0x04000790 RID: 1936
	[Token(Token = "0x4000790")]
	[FieldOffset(Offset = "0x48")]
	private readonly List<ValueTuple<int, float, Chat>> _chatHistory;

	// Token: 0x04000791 RID: 1937
	[Token(Token = "0x4000791")]
	[FieldOffset(Offset = "0x50")]
	private readonly List<ChatLine> _chats;

	// Token: 0x04000792 RID: 1938
	[Token(Token = "0x4000792")]
	[FieldOffset(Offset = "0x58")]
	private int _activeCount;

	// Token: 0x04000793 RID: 1939
	[Token(Token = "0x4000793")]
	[FieldOffset(Offset = "0x5C")]
	private int? _viewIndex;

	// Token: 0x04000794 RID: 1940
	[Token(Token = "0x4000794")]
	[FieldOffset(Offset = "0x64")]
	private int _nextChatId;

	// Token: 0x04000795 RID: 1941
	[Token(Token = "0x4000795")]
	[FieldOffset(Offset = "0x68")]
	private Option _chatPageUpOption;

	// Token: 0x04000796 RID: 1942
	[Token(Token = "0x4000796")]
	[FieldOffset(Offset = "0x70")]
	private Option _chatPageDownOption;
}
