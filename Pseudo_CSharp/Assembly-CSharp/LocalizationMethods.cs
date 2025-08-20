using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Ronin.Model.Classes;

// Token: 0x020000BF RID: 191
[Token(Token = "0x20000BF")]
public static class LocalizationMethods
{
	// Token: 0x06000347 RID: 839 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000347")]
	public static string GetLocalEnumString<T>(this T value) where T : Enum
	{
		return null;
	}

	// Token: 0x06000348 RID: 840 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000348")]
	[Address(RVA = "0x3C6460", Offset = "0x3C5660", VA = "0x1803C6460")]
	public static string GetLocalString(this string key, bool inlineRtl = true)
	{
		return null;
	}

	// Token: 0x06000349 RID: 841 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000349")]
	[Address(RVA = "0x3C6300", Offset = "0x3C5500", VA = "0x1803C6300")]
	public static string GetLocalStringWithFallback(this string key, string fallback)
	{
		return null;
	}

	// Token: 0x0600034A RID: 842 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600034A")]
	[Address(RVA = "0x3C64F0", Offset = "0x3C56F0", VA = "0x1803C64F0")]
	public static string GetValue(this PlatformString value)
	{
		return null;
	}

	// Token: 0x0600034B RID: 843 RVA: 0x00003198 File Offset: 0x00001398
	[Token(Token = "0x600034B")]
	[Address(RVA = "0x3C6490", Offset = "0x3C5690", VA = "0x1803C6490")]
	public static ushort GetValue(this PlatformUInt16 value)
	{
		return 0;
	}

	// Token: 0x0600034C RID: 844 RVA: 0x000031B0 File Offset: 0x000013B0
	[Token(Token = "0x600034C")]
	[Address(RVA = "0x3C6550", Offset = "0x3C5750", VA = "0x1803C6550")]
	public static bool HasLocalize(this string potentialKey)
	{
		return default(bool);
	}

	// Token: 0x0600034D RID: 845 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600034D")]
	[Address(RVA = "0x3C66A0", Offset = "0x3C58A0", VA = "0x1803C66A0")]
	public static string TryLocalize(this string potentialKey)
	{
		return null;
	}

	// Token: 0x020000C0 RID: 192
	[Token(Token = "0x20000C0")]
	private static class EnumKeyCache<T> where T : Enum
	{
		// Token: 0x0600034E RID: 846 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600034E")]
		public static string Get(T value)
		{
			return null;
		}

		// Token: 0x04000337 RID: 823
		[Token(Token = "0x4000337")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<T, string> _keys;
	}
}
