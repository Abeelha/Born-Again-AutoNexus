using System;
using Il2CppDummyDll;

// Token: 0x02000177 RID: 375
[Token(Token = "0x2000177")]
[Serializable]
public struct BezierCurve
{
	// Token: 0x06000764 RID: 1892 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000764")]
	[Address(RVA = "0x407370", Offset = "0x406570", VA = "0x180407370")]
	public BezierCurve(float x1, float y1, float x2, float y2)
	{
	}

	// Token: 0x0400075E RID: 1886
	[Token(Token = "0x400075E")]
	[FieldOffset(Offset = "0x0")]
	public float X1;

	// Token: 0x0400075F RID: 1887
	[Token(Token = "0x400075F")]
	[FieldOffset(Offset = "0x4")]
	public float X2;

	// Token: 0x04000760 RID: 1888
	[Token(Token = "0x4000760")]
	[FieldOffset(Offset = "0x8")]
	public float Y1;

	// Token: 0x04000761 RID: 1889
	[Token(Token = "0x4000761")]
	[FieldOffset(Offset = "0xC")]
	public float Y2;
}
