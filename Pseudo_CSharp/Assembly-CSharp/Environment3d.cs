using System;
using Il2CppDummyDll;

// Token: 0x0200028C RID: 652
[Token(Token = "0x200028C")]
public class Environment3d : global::Environment
{
	// Token: 0x1700017D RID: 381
	// (get) Token: 0x06000DA0 RID: 3488 RVA: 0x00005A00 File Offset: 0x00003C00
	[Token(Token = "0x1700017D")]
	public override WorldObjectType Type
	{
		[Token(Token = "0x6000DA0")]
		[Address(RVA = "0x3F99B0", Offset = "0x3F8BB0", VA = "0x1803F99B0", Slot = "13")]
		get
		{
			return (WorldObjectType)0;
		}
	}

	// Token: 0x06000DA1 RID: 3489 RVA: 0x00005A18 File Offset: 0x00003C18
	[Token(Token = "0x6000DA1")]
	[Address(RVA = "0x457A90", Offset = "0x456C90", VA = "0x180457A90", Slot = "22")]
	public override float GetSpriteHeightStill()
	{
		return 0f;
	}

	// Token: 0x06000DA2 RID: 3490 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DA2")]
	[Address(RVA = "0x457BA0", Offset = "0x456DA0", VA = "0x180457BA0")]
	public Environment3d()
	{
	}

	// Token: 0x04000B3A RID: 2874
	[Token(Token = "0x4000B3A")]
	[FieldOffset(Offset = "0x110")]
	public MeshRig Rig;
}
