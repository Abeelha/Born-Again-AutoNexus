using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x020002F0 RID: 752
[Token(Token = "0x20002F0")]
public class ButtonBuilder : LabelBuilder
{
	// Token: 0x06001096 RID: 4246 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001096")]
	[Address(RVA = "0x34DF50", Offset = "0x34D150", VA = "0x18034DF50")]
	public ButtonBuilder(GameObject gameObject)
	{
	}

	// Token: 0x06001097 RID: 4247 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6001097")]
	[Address(RVA = "0x34DF10", Offset = "0x34D110", VA = "0x18034DF10")]
	public ButtonBuilder OnClick(UnityAction action)
	{
		return null;
	}

	// Token: 0x06001098 RID: 4248 RVA: 0x000066D8 File Offset: 0x000048D8
	[Token(Token = "0x6001098")]
	[Address(RVA = "0x34DCD0", Offset = "0x34CED0", VA = "0x18034DCD0", Slot = "5")]
	public override Rect GetRect()
	{
		return default(Rect);
	}

	// Token: 0x04000DDB RID: 3547
	[Token(Token = "0x4000DDB")]
	[FieldOffset(Offset = "0x38")]
	private readonly Button _button;
}
