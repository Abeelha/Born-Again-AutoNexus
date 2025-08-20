using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json;

// Token: 0x0200007E RID: 126
[Token(Token = "0x200007E")]
public class DataManifest
{
	// Token: 0x1700001E RID: 30
	// (get) Token: 0x0600021D RID: 541 RVA: 0x0000206A File Offset: 0x0000026A
	// (set) Token: 0x0600021E RID: 542 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700001E")]
	public Dictionary<string, DataManifest.Bundle> Bundles
	{
		[Token(Token = "0x600021D")]
		[Address(RVA = "0x3328E0", Offset = "0x331AE0", VA = "0x1803328E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600021E")]
		[Address(RVA = "0x334510", Offset = "0x333710", VA = "0x180334510")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x1700001F RID: 31
	// (get) Token: 0x0600021F RID: 543 RVA: 0x00002A00 File Offset: 0x00000C00
	[Token(Token = "0x1700001F")]
	[JsonIgnore]
	public long Hash
	{
		[Token(Token = "0x600021F")]
		[Address(RVA = "0x3343C0", Offset = "0x3335C0", VA = "0x1803343C0")]
		get
		{
			return 0L;
		}
	}

	// Token: 0x06000220 RID: 544 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000220")]
	[Address(RVA = "0x333FE0", Offset = "0x3331E0", VA = "0x180333FE0")]
	public static DataManifest Read(Stream stream)
	{
		return null;
	}

	// Token: 0x06000221 RID: 545 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000221")]
	[Address(RVA = "0x3341F0", Offset = "0x3333F0", VA = "0x1803341F0")]
	public void Write(Stream stream)
	{
	}

	// Token: 0x06000222 RID: 546 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000222")]
	[Address(RVA = "0x334340", Offset = "0x333540", VA = "0x180334340")]
	public DataManifest()
	{
	}

	// Token: 0x0200007F RID: 127
	[Token(Token = "0x200007F")]
	public class Bundle
	{
		// Token: 0x06000223 RID: 547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000223")]
		[Address(RVA = "0x3326B0", Offset = "0x3318B0", VA = "0x1803326B0")]
		public Bundle(string key, string version, string[] files)
		{
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000224 RID: 548 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000020")]
		public string Key
		{
			[Token(Token = "0x6000224")]
			[Address(RVA = "0x3328E0", Offset = "0x331AE0", VA = "0x1803328E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000225 RID: 549 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000021")]
		public string Version
		{
			[Token(Token = "0x6000225")]
			[Address(RVA = "0x32A4B0", Offset = "0x3296B0", VA = "0x18032A4B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000226 RID: 550 RVA: 0x00002A18 File Offset: 0x00000C18
		[Token(Token = "0x17000022")]
		[JsonIgnore]
		public long VersionValue
		{
			[Token(Token = "0x6000226")]
			[Address(RVA = "0x3328F0", Offset = "0x331AF0", VA = "0x1803328F0")]
			[CompilerGenerated]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000227 RID: 551 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000023")]
		public string[] Files
		{
			[Token(Token = "0x6000227")]
			[Address(RVA = "0x3328D0", Offset = "0x331AD0", VA = "0x1803328D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}
	}
}
