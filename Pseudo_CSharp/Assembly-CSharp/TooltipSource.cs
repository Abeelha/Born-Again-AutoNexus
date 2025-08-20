using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000302 RID: 770
[Token(Token = "0x2000302")]
public abstract class TooltipSource : MonoBehaviour
{
	// Token: 0x170001E3 RID: 483
	// (get) Token: 0x06001119 RID: 4377
	[Token(Token = "0x170001E3")]
	public abstract bool CanShow { [Token(Token = "0x6001119")] get; }

	// Token: 0x0600111A RID: 4378
	[Token(Token = "0x600111A")]
	public abstract void Build(TooltipBuilder builder);

	// Token: 0x0600111B RID: 4379 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600111B")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	protected TooltipSource()
	{
	}

	// Token: 0x04000E22 RID: 3618
	[Token(Token = "0x4000E22")]
	[FieldOffset(Offset = "0x20")]
	public TooltipFlags Flags;
}
