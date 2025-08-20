using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Ronin.Api.Model.CharacterSlot;
using Ronin.Model.Definitions;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020000E8 RID: 232
[Token(Token = "0x20000E8")]
public class CharacterMenuDisplay : MonoBehaviour
{
	// Token: 0x17000052 RID: 82
	// (get) Token: 0x06000407 RID: 1031 RVA: 0x00003330 File Offset: 0x00001530
	// (set) Token: 0x06000408 RID: 1032 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000052")]
	public LockState LockState
	{
		[Token(Token = "0x6000407")]
		[Address(RVA = "0x3C0150", Offset = "0x3BF350", VA = "0x1803C0150")]
		[CompilerGenerated]
		get
		{
			return LockState.Unlocked;
		}
		[Token(Token = "0x6000408")]
		[Address(RVA = "0x3C0160", Offset = "0x3BF360", VA = "0x1803C0160")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x06000409 RID: 1033 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000409")]
	[Address(RVA = "0x3BFA40", Offset = "0x3BEC40", VA = "0x1803BFA40")]
	public void SetCharacterSlot(GetCharacterSlotResponse characterSlot)
	{
	}

	// Token: 0x0600040A RID: 1034 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600040A")]
	[Address(RVA = "0x3BFAE0", Offset = "0x3BECE0", VA = "0x1803BFAE0")]
	public void SetClass(ObjectDefinition definition)
	{
	}

	// Token: 0x0600040B RID: 1035 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600040B")]
	[Address(RVA = "0x3C0080", Offset = "0x3BF280", VA = "0x1803C0080")]
	public void SetLocked(LockState lockState)
	{
	}

	// Token: 0x0600040C RID: 1036 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600040C")]
	[Address(RVA = "0x3BFD20", Offset = "0x3BEF20", VA = "0x1803BFD20")]
	public void SetGraphicsActive(bool active)
	{
	}

	// Token: 0x0600040D RID: 1037 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600040D")]
	[Address(RVA = "0x3BFEC0", Offset = "0x3BF0C0", VA = "0x1803BFEC0")]
	public void SetGraphicsTransition(float transition)
	{
	}

	// Token: 0x0600040E RID: 1038 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600040E")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public CharacterMenuDisplay()
	{
	}

	// Token: 0x0400040C RID: 1036
	[Token(Token = "0x400040C")]
	[FieldOffset(Offset = "0x20")]
	public GetCharacterSlotResponse CharacterSlot;

	// Token: 0x0400040D RID: 1037
	[Token(Token = "0x400040D")]
	[FieldOffset(Offset = "0x28")]
	public ObjectDefinition Class;

	// Token: 0x0400040E RID: 1038
	[Token(Token = "0x400040E")]
	[FieldOffset(Offset = "0x30")]
	public CharacterImage CharacterImage;

	// Token: 0x0400040F RID: 1039
	[Token(Token = "0x400040F")]
	[FieldOffset(Offset = "0x38")]
	public CharacterImage PreviousCharacterImage;

	// Token: 0x04000410 RID: 1040
	[Token(Token = "0x4000410")]
	[FieldOffset(Offset = "0x40")]
	public GameObject[] Graphics;

	// Token: 0x04000411 RID: 1041
	[Token(Token = "0x4000411")]
	[FieldOffset(Offset = "0x48")]
	public TextMeshProUGUI Button;

	// Token: 0x04000412 RID: 1042
	[Token(Token = "0x4000412")]
	[FieldOffset(Offset = "0x50")]
	public string ButtonText;

	// Token: 0x04000413 RID: 1043
	[Token(Token = "0x4000413")]
	[FieldOffset(Offset = "0x58")]
	public RectTransform StatsTarget;

	// Token: 0x04000414 RID: 1044
	[Token(Token = "0x4000414")]
	[FieldOffset(Offset = "0x60")]
	public Image Lock;

	// Token: 0x04000415 RID: 1045
	[Token(Token = "0x4000415")]
	[FieldOffset(Offset = "0x68")]
	public Sprite LockSprite;

	// Token: 0x04000416 RID: 1046
	[Token(Token = "0x4000416")]
	[FieldOffset(Offset = "0x70")]
	public Sprite CheckSprite;

	// Token: 0x04000417 RID: 1047
	[Token(Token = "0x4000417")]
	[FieldOffset(Offset = "0x78")]
	public Image Placeholder;
}
