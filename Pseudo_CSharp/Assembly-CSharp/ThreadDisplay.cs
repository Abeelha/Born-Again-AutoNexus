using System;
using Il2CppDummyDll;
using Ronin.Model.Definitions;
using UnityEngine;

// Token: 0x02000130 RID: 304
[Token(Token = "0x2000130")]
public class ThreadDisplay : MonoBehaviour, IDefinitionDisplay
{
	// Token: 0x17000060 RID: 96
	// (get) Token: 0x06000549 RID: 1353 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x17000060")]
	public ObjectDefinition Definition
	{
		[Token(Token = "0x6000549")]
		[Address(RVA = "0x3328F0", Offset = "0x331AF0", VA = "0x1803328F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600054A RID: 1354 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600054A")]
	[Address(RVA = "0x3DED30", Offset = "0x3DDF30", VA = "0x1803DED30")]
	public void Setup(BlessingDefinition thread)
	{
	}

	// Token: 0x0600054B RID: 1355 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600054B")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public ThreadDisplay()
	{
	}

	// Token: 0x040005B8 RID: 1464
	[Token(Token = "0x40005B8")]
	[FieldOffset(Offset = "0x20")]
	public BlessingDefinition Thread;

	// Token: 0x040005B9 RID: 1465
	[Token(Token = "0x40005B9")]
	[FieldOffset(Offset = "0x28")]
	public BlessingStrand BlessingStrand;
}
