using System;
using Il2CppDummyDll;
using TMPro;

// Token: 0x02000145 RID: 325
[Token(Token = "0x2000145")]
public class GenerationMenu : Menu
{
	// Token: 0x060005C7 RID: 1479 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005C7")]
	[Address(RVA = "0x3F0710", Offset = "0x3EF910", VA = "0x1803F0710")]
	public void Generate()
	{
	}

	// Token: 0x060005C8 RID: 1480 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005C8")]
	[Address(RVA = "0x3F0710", Offset = "0x3EF910", VA = "0x1803F0710")]
	public void OnChange()
	{
	}

	// Token: 0x060005C9 RID: 1481 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005C9")]
	[Address(RVA = "0x3F0710", Offset = "0x3EF910", VA = "0x1803F0710")]
	public void Relax()
	{
	}

	// Token: 0x060005CA RID: 1482 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005CA")]
	[Address(RVA = "0x3F0720", Offset = "0x3EF920", VA = "0x1803F0720")]
	private void SyncVariables()
	{
	}

	// Token: 0x060005CB RID: 1483 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005CB")]
	[Address(RVA = "0x3BC980", Offset = "0x3BBB80", VA = "0x1803BC980")]
	public GenerationMenu()
	{
	}

	// Token: 0x04000678 RID: 1656
	[Token(Token = "0x4000678")]
	[FieldOffset(Offset = "0x90")]
	public Generator Generator;

	// Token: 0x04000679 RID: 1657
	[Token(Token = "0x4000679")]
	[FieldOffset(Offset = "0x98")]
	public TMP_InputField PointCountInput;

	// Token: 0x0400067A RID: 1658
	[Token(Token = "0x400067A")]
	[FieldOffset(Offset = "0xA0")]
	public TMP_InputField LandValueInput;
}
