using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000144 RID: 324
[Token(Token = "0x2000144")]
public static class OptionValue
{
	// Token: 0x060005BF RID: 1471 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60005BF")]
	[Address(RVA = "0x3F27C0", Offset = "0x3F19C0", VA = "0x1803F27C0")]
	public static string FromBool(bool value)
	{
		return null;
	}

	// Token: 0x060005C0 RID: 1472 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60005C0")]
	[Address(RVA = "0x3F27D0", Offset = "0x3F19D0", VA = "0x1803F27D0")]
	public static string FromFloat(float value)
	{
		return null;
	}

	// Token: 0x060005C1 RID: 1473 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60005C1")]
	[Address(RVA = "0x3F2850", Offset = "0x3F1A50", VA = "0x1803F2850")]
	public static string FromInt(int value)
	{
		return null;
	}

	// Token: 0x060005C2 RID: 1474 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60005C2")]
	[Address(RVA = "0x3F28D0", Offset = "0x3F1AD0", VA = "0x1803F28D0")]
	public static string FromKeyCode(KeyCode keyCode)
	{
		return null;
	}

	// Token: 0x060005C3 RID: 1475 RVA: 0x00003780 File Offset: 0x00001980
	[Token(Token = "0x60005C3")]
	[Address(RVA = "0x3F28E0", Offset = "0x3F1AE0", VA = "0x1803F28E0")]
	public static bool ToBool(int optionValue)
	{
		return default(bool);
	}

	// Token: 0x060005C4 RID: 1476 RVA: 0x00003798 File Offset: 0x00001998
	[Token(Token = "0x60005C4")]
	[Address(RVA = "0x3F28F0", Offset = "0x3F1AF0", VA = "0x1803F28F0")]
	public static float ToFloat(string optionValue, float @default)
	{
		return 0f;
	}

	// Token: 0x060005C5 RID: 1477 RVA: 0x000037B0 File Offset: 0x000019B0
	[Token(Token = "0x60005C5")]
	[Address(RVA = "0x3F2940", Offset = "0x3F1B40", VA = "0x1803F2940")]
	public static int ToInt(string optionValue)
	{
		return 0;
	}

	// Token: 0x060005C6 RID: 1478 RVA: 0x000037C8 File Offset: 0x000019C8
	[Token(Token = "0x60005C6")]
	[Address(RVA = "0x3F2970", Offset = "0x3F1B70", VA = "0x1803F2970")]
	public static KeyCode ToKeyCode(int optionValue)
	{
		return KeyCode.None;
	}
}
