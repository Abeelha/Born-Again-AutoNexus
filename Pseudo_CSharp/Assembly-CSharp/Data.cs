using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Il2CppDummyDll;
using Ronin.Api.Model.Data;

// Token: 0x0200002D RID: 45
[Token(Token = "0x200002D")]
public static class Data
{
	// Token: 0x1700000E RID: 14
	// (get) Token: 0x06000100 RID: 256 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x1700000E")]
	public static DataManifest Manifest
	{
		[Token(Token = "0x6000100")]
		[Address(RVA = "0x31DD20", Offset = "0x31CF20", VA = "0x18031DD20")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700000F RID: 15
	// (get) Token: 0x06000101 RID: 257 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x1700000F")]
	private static string ManifestFileName
	{
		[Token(Token = "0x6000101")]
		[Address(RVA = "0x31DC80", Offset = "0x31CE80", VA = "0x18031DC80")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000010 RID: 16
	// (get) Token: 0x06000102 RID: 258 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x17000010")]
	private static string ManifestFilePath
	{
		[Token(Token = "0x6000102")]
		[Address(RVA = "0x31DCB0", Offset = "0x31CEB0", VA = "0x18031DCB0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000103 RID: 259 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000103")]
	[Address(RVA = "0x31CC90", Offset = "0x31BE90", VA = "0x18031CC90")]
	public static void Delete(string key)
	{
	}

	// Token: 0x06000104 RID: 260 RVA: 0x00002550 File Offset: 0x00000750
	[Token(Token = "0x6000104")]
	[Address(RVA = "0x31CED0", Offset = "0x31C0D0", VA = "0x18031CED0")]
	public static bool Exists(string fileName)
	{
		return default(bool);
	}

	// Token: 0x06000105 RID: 261 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000105")]
	[Address(RVA = "0x31CF30", Offset = "0x31C130", VA = "0x18031CF30")]
	public static IEnumerable<GetDataResponse> GetAllData()
	{
		return null;
	}

	// Token: 0x06000106 RID: 262 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000106")]
	[Address(RVA = "0x31D0B0", Offset = "0x31C2B0", VA = "0x18031D0B0")]
	public static IEnumerable<string> GetAllFiles()
	{
		return null;
	}

	// Token: 0x06000107 RID: 263 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000107")]
	[Address(RVA = "0x31D4B0", Offset = "0x31C6B0", VA = "0x18031D4B0")]
	public static Stream OpenRead(string fileName)
	{
		return null;
	}

	// Token: 0x06000108 RID: 264 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000108")]
	[Address(RVA = "0x31D550", Offset = "0x31C750", VA = "0x18031D550")]
	public static Task<byte[]> ReadAsync(string fileName)
	{
		return null;
	}

	// Token: 0x06000109 RID: 265 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000109")]
	[Address(RVA = "0x31D650", Offset = "0x31C850", VA = "0x18031D650")]
	public static Task SaveManifestAsync()
	{
		return null;
	}

	// Token: 0x0600010A RID: 266 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600010A")]
	[Address(RVA = "0x31D700", Offset = "0x31C900", VA = "0x18031D700")]
	public static Task WriteAsync(GetDataResponse data, byte[] file)
	{
		return null;
	}

	// Token: 0x0600010B RID: 267 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600010B")]
	[Address(RVA = "0x31CE70", Offset = "0x31C070", VA = "0x18031CE70")]
	private static void EnsureDataDirectory()
	{
	}

	// Token: 0x0600010C RID: 268 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600010C")]
	[Address(RVA = "0x31D230", Offset = "0x31C430", VA = "0x18031D230")]
	private static string GetFilePath(string file)
	{
		return null;
	}

	// Token: 0x0600010D RID: 269 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600010D")]
	[Address(RVA = "0x31D2C0", Offset = "0x31C4C0", VA = "0x18031D2C0")]
	private static DataManifest LoadManifest()
	{
		return null;
	}

	// Token: 0x0600010E RID: 270 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600010E")]
	[Address(RVA = "0x31D810", Offset = "0x31CA10", VA = "0x18031D810")]
	public static Task WriteFileAsync(string fileName, byte[] file)
	{
		return null;
	}

	// Token: 0x0600010F RID: 271 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600010F")]
	[Address(RVA = "0x31DA10", Offset = "0x31CC10", VA = "0x18031DA10")]
	public static void WriteFile(string fileName, Stream binaryStream)
	{
	}

	// Token: 0x06000110 RID: 272 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000110")]
	[Address(RVA = "0x31D910", Offset = "0x31CB10", VA = "0x18031D910")]
	public static Task WriteFileAsync(string fileName, Stream binaryStream)
	{
		return null;
	}

	// Token: 0x040000D0 RID: 208
	[Token(Token = "0x40000D0")]
	[FieldOffset(Offset = "0x0")]
	public static string SavedDataDirectory;

	// Token: 0x040000D1 RID: 209
	[Token(Token = "0x40000D1")]
	[FieldOffset(Offset = "0x8")]
	private static DataManifest _manifest;
}
