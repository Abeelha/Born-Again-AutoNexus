using System;
using Coffee.UISoftMask;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200033F RID: 831
[Token(Token = "0x200033F")]
public class WorldChatToggler : MonoBehaviour
{
	// Token: 0x06001258 RID: 4696 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001258")]
	[Address(RVA = "0x385A20", Offset = "0x384C20", VA = "0x180385A20")]
	public void Toggle()
	{
	}

	// Token: 0x06001259 RID: 4697 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001259")]
	[Address(RVA = "0x385720", Offset = "0x384920", VA = "0x180385720")]
	private void Awake()
	{
	}

	// Token: 0x0600125A RID: 4698 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600125A")]
	[Address(RVA = "0x3858B0", Offset = "0x384AB0", VA = "0x1803858B0")]
	private void OnDestroy()
	{
	}

	// Token: 0x0600125B RID: 4699 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600125B")]
	[Address(RVA = "0x385940", Offset = "0x384B40", VA = "0x180385940")]
	private void PositionChat(Option obj)
	{
	}

	// Token: 0x0600125C RID: 4700 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600125C")]
	[Address(RVA = "0x385A40", Offset = "0x384C40", VA = "0x180385A40")]
	private void UpdateValues()
	{
	}

	// Token: 0x0600125D RID: 4701 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600125D")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public WorldChatToggler()
	{
	}

	// Token: 0x04000F03 RID: 3843
	[Token(Token = "0x4000F03")]
	[FieldOffset(Offset = "0x20")]
	public Sprite DefaultSprite;

	// Token: 0x04000F04 RID: 3844
	[Token(Token = "0x4000F04")]
	[FieldOffset(Offset = "0x28")]
	public Sprite ActiveSprite;

	// Token: 0x04000F05 RID: 3845
	[Token(Token = "0x4000F05")]
	[FieldOffset(Offset = "0x30")]
	public float MaxSlide;

	// Token: 0x04000F06 RID: 3846
	[Token(Token = "0x4000F06")]
	[FieldOffset(Offset = "0x38")]
	public RectTransform SlidingChat;

	// Token: 0x04000F07 RID: 3847
	[Token(Token = "0x4000F07")]
	[FieldOffset(Offset = "0x40")]
	public Image IconImage;

	// Token: 0x04000F08 RID: 3848
	[Token(Token = "0x4000F08")]
	[FieldOffset(Offset = "0x48")]
	public SoftMask SoftMask;

	// Token: 0x04000F09 RID: 3849
	[Token(Token = "0x4000F09")]
	[FieldOffset(Offset = "0x50")]
	public Image MaskImage;

	// Token: 0x04000F0A RID: 3850
	[Token(Token = "0x4000F0A")]
	[FieldOffset(Offset = "0x58")]
	public GameObject Buttons;

	// Token: 0x04000F0B RID: 3851
	[Token(Token = "0x4000F0B")]
	[FieldOffset(Offset = "0x60")]
	private bool _active;

	// Token: 0x04000F0C RID: 3852
	[Token(Token = "0x4000F0C")]
	[FieldOffset(Offset = "0x68")]
	private Option _chatPositionOption;
}
