using System;
using System.IO;
using Il2CppDummyDll;

// Token: 0x02000028 RID: 40
[Token(Token = "0x2000028")]
public sealed class ChatFilter
{
	// Token: 0x060000E9 RID: 233 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x31BCF0", Offset = "0x31AEF0", VA = "0x18031BCF0")]
	public void AddBlacklist(Stream file, char separator)
	{
	}

	// Token: 0x060000EA RID: 234 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x31BD90", Offset = "0x31AF90", VA = "0x18031BD90")]
	public void AddWhitelist(Stream file, char separator)
	{
	}

	// Token: 0x060000EB RID: 235 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x31C0C0", Offset = "0x31B2C0", VA = "0x18031C0C0")]
	public void Process(Span<char> chat, char replaceCharacter)
	{
	}

	// Token: 0x060000EC RID: 236 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x31BE30", Offset = "0x31B030", VA = "0x18031BE30")]
	private void ProcessToken(Span<char> token, Span<int> mask, int offset)
	{
	}

	// Token: 0x060000ED RID: 237 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x31C510", Offset = "0x31B710", VA = "0x18031C510")]
	private void ReadFile(Stream file, char separator, Action<string> tokenHandler)
	{
	}

	// Token: 0x060000EE RID: 238 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x31C7D0", Offset = "0x31B9D0", VA = "0x18031C7D0")]
	public ChatFilter()
	{
	}

	// Token: 0x040000C9 RID: 201
	[Token(Token = "0x40000C9")]
	[FieldOffset(Offset = "0x10")]
	private readonly InsensitiveStringKeyedDictionary<bool> _blacklist;

	// Token: 0x040000CA RID: 202
	[Token(Token = "0x40000CA")]
	[FieldOffset(Offset = "0x18")]
	private readonly InsensitiveStringKeyedDictionary<bool> _whitelist;

	// Token: 0x040000CB RID: 203
	[Token(Token = "0x40000CB")]
	[FieldOffset(Offset = "0x20")]
	private readonly char[] _noSpace;
}
