using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x02000083 RID: 131
[Token(Token = "0x2000083")]
public static class Bezier
{
	// Token: 0x06000231 RID: 561 RVA: 0x00002A90 File Offset: 0x00000C90
	[Token(Token = "0x6000231")]
	[Address(RVA = "0x332190", Offset = "0x331390", VA = "0x180332190")]
	public static float Lerp(float time, float aX, float aY, float bX, float bY)
	{
		return 0f;
	}

	// Token: 0x06000232 RID: 562 RVA: 0x00002AA8 File Offset: 0x00000CA8
	[Token(Token = "0x6000232")]
	[Address(RVA = "0x331CC0", Offset = "0x330EC0", VA = "0x180331CC0")]
	public static float Lerp(float time, BezierCurve curve)
	{
		return 0f;
	}

	// Token: 0x06000233 RID: 563 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000233")]
	[Address(RVA = "0x331AA0", Offset = "0x330CA0", VA = "0x180331AA0")]
	private static float[] CreateLookups(BezierCurve curve)
	{
		return null;
	}

	// Token: 0x06000234 RID: 564 RVA: 0x00002AC0 File Offset: 0x00000CC0
	[Token(Token = "0x6000234")]
	[Address(RVA = "0x331C40", Offset = "0x330E40", VA = "0x180331C40")]
	private static float CubicBezier(float t, float a, float b)
	{
		return 0f;
	}

	// Token: 0x0400020E RID: 526
	[Token(Token = "0x400020E")]
	[FieldOffset(Offset = "0x0")]
	private static readonly Dictionary<BezierCurve, float[]> s_lookups;
}
