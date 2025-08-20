using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200013F RID: 319
[Token(Token = "0x200013F")]
public class Option
{
	// Token: 0x14000001 RID: 1
	// (add) Token: 0x0600059B RID: 1435 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600059C RID: 1436 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x14000001")]
	public event Action<Option> OnChange
	{
		[Token(Token = "0x600059B")]
		[Address(RVA = "0x3F2D50", Offset = "0x3F1F50", VA = "0x1803F2D50")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600059C")]
		[Address(RVA = "0x3F2EE0", Offset = "0x3F20E0", VA = "0x1803F2EE0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	// Token: 0x1700006A RID: 106
	// (get) Token: 0x0600059D RID: 1437 RVA: 0x00003630 File Offset: 0x00001830
	// (set) Token: 0x0600059E RID: 1438 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700006A")]
	public bool Bool
	{
		[Token(Token = "0x600059D")]
		[Address(RVA = "0x3F2B10", Offset = "0x3F1D10", VA = "0x1803F2B10")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600059E")]
		[Address(RVA = "0x3F2A60", Offset = "0x3F1C60", VA = "0x1803F2A60")]
		set
		{
		}
	}

	// Token: 0x1700006B RID: 107
	// (get) Token: 0x0600059F RID: 1439 RVA: 0x00003648 File Offset: 0x00001848
	[Token(Token = "0x1700006B")]
	public float Float
	{
		[Token(Token = "0x600059F")]
		[Address(RVA = "0x3F2E00", Offset = "0x3F2000", VA = "0x1803F2E00")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x1700006C RID: 108
	// (get) Token: 0x060005A0 RID: 1440 RVA: 0x00003660 File Offset: 0x00001860
	[Token(Token = "0x1700006C")]
	public int Int
	{
		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x3F2CA0", Offset = "0x3F1EA0", VA = "0x1803F2CA0")]
		get
		{
			return 0;
		}
	}

	// Token: 0x1700006D RID: 109
	// (get) Token: 0x060005A1 RID: 1441 RVA: 0x00003678 File Offset: 0x00001878
	[Token(Token = "0x1700006D")]
	public KeyCode KeyCode
	{
		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x3F2CA0", Offset = "0x3F1EA0", VA = "0x1803F2CA0")]
		get
		{
			return KeyCode.None;
		}
	}

	// Token: 0x1700006E RID: 110
	// (get) Token: 0x060005A2 RID: 1442 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x1700006E")]
	public string Value
	{
		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x3944E0", Offset = "0x3936E0", VA = "0x1803944E0")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700006F RID: 111
	// (get) Token: 0x060005A3 RID: 1443 RVA: 0x00003690 File Offset: 0x00001890
	[Token(Token = "0x1700006F")]
	public float Volume
	{
		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x3F2EC0", Offset = "0x3F20C0", VA = "0x1803F2EC0")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x060005A4 RID: 1444 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005A4")]
	[Address(RVA = "0x3F2CB0", Offset = "0x3F1EB0", VA = "0x1803F2CB0")]
	public Option(string key, string defaultValue)
	{
	}

	// Token: 0x060005A5 RID: 1445 RVA: 0x000036A8 File Offset: 0x000018A8
	[Token(Token = "0x60005A5")]
	[Address(RVA = "0x3F29C0", Offset = "0x3F1BC0", VA = "0x1803F29C0")]
	public bool GetKey()
	{
		return default(bool);
	}

	// Token: 0x060005A6 RID: 1446 RVA: 0x000036C0 File Offset: 0x000018C0
	[Token(Token = "0x60005A6")]
	[Address(RVA = "0x3F2980", Offset = "0x3F1B80", VA = "0x1803F2980")]
	public bool GetKeyDown()
	{
		return default(bool);
	}

	// Token: 0x060005A7 RID: 1447 RVA: 0x000036D8 File Offset: 0x000018D8
	[Token(Token = "0x60005A7")]
	[Address(RVA = "0x3F29A0", Offset = "0x3F1BA0", VA = "0x1803F29A0")]
	public bool GetKeyUp()
	{
		return default(bool);
	}

	// Token: 0x060005A8 RID: 1448 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005A8")]
	[Address(RVA = "0x3F2A90", Offset = "0x3F1C90", VA = "0x1803F2A90")]
	public void Set(string value)
	{
	}

	// Token: 0x060005A9 RID: 1449 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005A9")]
	[Address(RVA = "0x3F2A60", Offset = "0x3F1C60", VA = "0x1803F2A60")]
	public void Set(bool value)
	{
	}

	// Token: 0x060005AA RID: 1450 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005AA")]
	[Address(RVA = "0x3F2A30", Offset = "0x3F1C30", VA = "0x1803F2A30")]
	public void Set(float value)
	{
	}

	// Token: 0x060005AB RID: 1451 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005AB")]
	[Address(RVA = "0x3F2A00", Offset = "0x3F1C00", VA = "0x1803F2A00")]
	public void Set(int value)
	{
	}

	// Token: 0x060005AC RID: 1452 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005AC")]
	[Address(RVA = "0x3F2A00", Offset = "0x3F1C00", VA = "0x1803F2A00")]
	public void Set(KeyCode keyCode)
	{
	}

	// Token: 0x060005AD RID: 1453 RVA: 0x000036F0 File Offset: 0x000018F0
	[Token(Token = "0x60005AD")]
	[Address(RVA = "0x3F2B10", Offset = "0x3F1D10", VA = "0x1803F2B10")]
	public bool ValueBool()
	{
		return default(bool);
	}

	// Token: 0x060005AE RID: 1454 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60005AE")]
	public T ValueEnum<T>([Optional] T @default) where T : struct
	{
		return null;
	}

	// Token: 0x060005AF RID: 1455 RVA: 0x00003708 File Offset: 0x00001908
	[Token(Token = "0x60005AF")]
	[Address(RVA = "0x3F2B30", Offset = "0x3F1D30", VA = "0x1803F2B30")]
	public float ValueFloat(float @default)
	{
		return 0f;
	}

	// Token: 0x060005B0 RID: 1456 RVA: 0x00003720 File Offset: 0x00001920
	[Token(Token = "0x60005B0")]
	[Address(RVA = "0x3F2BF0", Offset = "0x3F1DF0", VA = "0x1803F2BF0")]
	public int ValueInt()
	{
		return 0;
	}

	// Token: 0x060005B1 RID: 1457 RVA: 0x00003738 File Offset: 0x00001938
	[Token(Token = "0x60005B1")]
	[Address(RVA = "0x3F2CA0", Offset = "0x3F1EA0", VA = "0x1803F2CA0")]
	public KeyCode ValueKeyCode()
	{
		return KeyCode.None;
	}

	// Token: 0x060005B2 RID: 1458 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60005B2")]
	[Address(RVA = "0x3F29E0", Offset = "0x3F1BE0", VA = "0x1803F29E0")]
	private string LoadValue()
	{
		return null;
	}

	// Token: 0x060005B3 RID: 1459 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005B3")]
	[Address(RVA = "0x3F29F0", Offset = "0x3F1BF0", VA = "0x1803F29F0")]
	private void SetValue(string value)
	{
	}

	// Token: 0x04000612 RID: 1554
	[Token(Token = "0x4000612")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly string _key;

	// Token: 0x04000613 RID: 1555
	[Token(Token = "0x4000613")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly string _defaultValue;

	// Token: 0x04000614 RID: 1556
	[Token(Token = "0x4000614")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Option.ValueCache _cache;

	// Token: 0x04000615 RID: 1557
	[Token(Token = "0x4000615")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private string _value;

	// Token: 0x02000140 RID: 320
	[Token(Token = "0x2000140")]
	private struct ValueCache
	{
		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060005B4 RID: 1460 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060005B5 RID: 1461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000070")]
		public object Enum
		{
			[Token(Token = "0x60005B4")]
			[Address(RVA = "0x405340", Offset = "0x404540", VA = "0x180405340")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60005B5")]
			[Address(RVA = "0x405360", Offset = "0x404560", VA = "0x180405360")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060005B6 RID: 1462 RVA: 0x00003750 File Offset: 0x00001950
		// (set) Token: 0x060005B7 RID: 1463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000071")]
		public float? Float
		{
			[Token(Token = "0x60005B6")]
			[Address(RVA = "0x405350", Offset = "0x404550", VA = "0x180405350")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60005B7")]
			[Address(RVA = "0x405370", Offset = "0x404570", VA = "0x180405370")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060005B8 RID: 1464 RVA: 0x00003768 File Offset: 0x00001968
		// (set) Token: 0x060005B9 RID: 1465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000072")]
		public int? Int
		{
			[Token(Token = "0x60005B8")]
			[Address(RVA = "0x3328E0", Offset = "0x331AE0", VA = "0x1803328E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60005B9")]
			[Address(RVA = "0x405380", Offset = "0x404580", VA = "0x180405380")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
