using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x02000029 RID: 41
[Token(Token = "0x2000029")]
internal sealed class InsensitiveStringKeyedDictionary<T>
{
	// Token: 0x060000F1 RID: 241 RVA: 0x000024A8 File Offset: 0x000006A8
	[Token(Token = "0x60000F1")]
	public static int GetHashCode(ReadOnlySpan<char> value)
	{
		return 0;
	}

	// Token: 0x060000F2 RID: 242 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000F2")]
	public void Add(string key, T value)
	{
	}

	// Token: 0x060000F3 RID: 243 RVA: 0x000024C0 File Offset: 0x000006C0
	[Token(Token = "0x60000F3")]
	public bool TryGetValue(ReadOnlySpan<char> key, out T value)
	{
		return default(bool);
	}

	// Token: 0x060000F4 RID: 244 RVA: 0x000024D8 File Offset: 0x000006D8
	[Token(Token = "0x60000F4")]
	public bool TryGetValue(ReadOnlySpan<char> key, int bucketKey, out T value)
	{
		return default(bool);
	}

	// Token: 0x060000F5 RID: 245 RVA: 0x000024F0 File Offset: 0x000006F0
	[Token(Token = "0x60000F5")]
	private static int GetLower(int value)
	{
		return 0;
	}

	// Token: 0x060000F6 RID: 246 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000F6")]
	public InsensitiveStringKeyedDictionary()
	{
	}

	// Token: 0x040000CC RID: 204
	[Token(Token = "0x40000CC")]
	[FieldOffset(Offset = "0x0")]
	private readonly Dictionary<int, InsensitiveStringKeyedDictionary<T>.Bucket> _buckets;

	// Token: 0x0200002A RID: 42
	[Token(Token = "0x200002A")]
	private struct Bucket
	{
		// Token: 0x060000F7 RID: 247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F7")]
		public Bucket(int capacity)
		{
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F8")]
		public void Add(string key, T value)
		{
		}

		// Token: 0x040000CD RID: 205
		[Token(Token = "0x40000CD")]
		[FieldOffset(Offset = "0x0")]
		public ValueTuple<string, T>[] Array;

		// Token: 0x040000CE RID: 206
		[Token(Token = "0x40000CE")]
		[FieldOffset(Offset = "0x0")]
		public int Count;
	}
}
