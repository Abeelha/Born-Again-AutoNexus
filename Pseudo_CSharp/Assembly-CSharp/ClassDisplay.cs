using System;
using Il2CppDummyDll;
using Ronin.Model.Definitions;
using UnityEngine;

// Token: 0x020000EB RID: 235
[Token(Token = "0x20000EB")]
public class ClassDisplay : MonoBehaviour, IDefinitionDisplay
{
	// Token: 0x17000053 RID: 83
	// (get) Token: 0x06000414 RID: 1044 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x17000053")]
	public ObjectDefinition Definition
	{
		[Token(Token = "0x6000414")]
		[Address(RVA = "0x3328D0", Offset = "0x331AD0", VA = "0x1803328D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000415 RID: 1045 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000415")]
	[Address(RVA = "0x3C1400", Offset = "0x3C0600", VA = "0x1803C1400")]
	public void Setup(BlessingDefinition thread, CharacterDefinition @class, bool locked)
	{
	}

	// Token: 0x06000416 RID: 1046 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000416")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public ClassDisplay()
	{
	}

	// Token: 0x0400041D RID: 1053
	[Token(Token = "0x400041D")]
	[FieldOffset(Offset = "0x0")]
	private static readonly Color s_lockedColor;

	// Token: 0x0400041E RID: 1054
	[Token(Token = "0x400041E")]
	[FieldOffset(Offset = "0x20")]
	public BlessingDefinition Thread;

	// Token: 0x0400041F RID: 1055
	[Token(Token = "0x400041F")]
	[FieldOffset(Offset = "0x28")]
	public CharacterDefinition Class;

	// Token: 0x04000420 RID: 1056
	[Token(Token = "0x4000420")]
	[FieldOffset(Offset = "0x30")]
	public CharacterImage CharacterImage;

	// Token: 0x04000421 RID: 1057
	[Token(Token = "0x4000421")]
	[FieldOffset(Offset = "0x38")]
	public GameObject Lock;

	// Token: 0x04000422 RID: 1058
	[Token(Token = "0x4000422")]
	[FieldOffset(Offset = "0x40")]
	public bool Locked;
}
