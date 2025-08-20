using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

// Token: 0x0200014A RID: 330
[Token(Token = "0x200014A")]
public abstract class PoolConfiguration
{
	// Token: 0x17000079 RID: 121
	// (get) Token: 0x060005E6 RID: 1510 RVA: 0x00003840 File Offset: 0x00001A40
	// (set) Token: 0x060005E7 RID: 1511 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000079")]
	public int MinCount
	{
		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x329390", Offset = "0x328590", VA = "0x180329390")]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x3F3390", Offset = "0x3F2590", VA = "0x1803F3390")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x1700007A RID: 122
	// (get) Token: 0x060005E8 RID: 1512 RVA: 0x00003858 File Offset: 0x00001A58
	// (set) Token: 0x060005E9 RID: 1513 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700007A")]
	public int MaxRented
	{
		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x3F3370", Offset = "0x3F2570", VA = "0x1803F3370")]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x3F3380", Offset = "0x3F2580", VA = "0x1803F3380")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x060005EA RID: 1514 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005EA")]
	[Address(RVA = "0x3F3330", Offset = "0x3F2530", VA = "0x1803F3330")]
	protected PoolConfiguration(int minCount, int maxRented)
	{
	}
}
