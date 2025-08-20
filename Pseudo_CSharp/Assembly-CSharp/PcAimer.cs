using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001DD RID: 477
[Token(Token = "0x20001DD")]
public class PcAimer : Aimer
{
	// Token: 0x170000EB RID: 235
	// (get) Token: 0x060009A2 RID: 2466 RVA: 0x00004728 File Offset: 0x00002928
	[Token(Token = "0x170000EB")]
	public override InputType InputType
	{
		[Token(Token = "0x60009A2")]
		[Address(RVA = "0x3B1FF0", Offset = "0x3B11F0", VA = "0x1803B1FF0", Slot = "4")]
		get
		{
			return InputType.Keyboard;
		}
	}

	// Token: 0x060009A3 RID: 2467 RVA: 0x00004740 File Offset: 0x00002940
	[Token(Token = "0x60009A3")]
	[Address(RVA = "0x42C7D0", Offset = "0x42B9D0", VA = "0x18042C7D0", Slot = "5")]
	public override Vector2 GetUseTarget(int index)
	{
		return default(Vector2);
	}

	// Token: 0x060009A4 RID: 2468 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009A4")]
	[Address(RVA = "0x42C930", Offset = "0x42BB30", VA = "0x18042C930")]
	public PcAimer()
	{
	}
}
