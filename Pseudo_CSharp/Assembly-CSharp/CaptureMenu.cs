using System;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using UnnamedStudios;

// Token: 0x0200029E RID: 670
[Token(Token = "0x200029E")]
public class CaptureMenu : MonoBehaviour
{
	// Token: 0x1700019F RID: 415
	// (get) Token: 0x06000E5D RID: 3677 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x1700019F")]
	private RectTransform RectTransform
	{
		[Token(Token = "0x6000E5D")]
		[Address(RVA = "0x450E70", Offset = "0x450070", VA = "0x180450E70")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000E5E RID: 3678 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E5E")]
	[Address(RVA = "0x357300", Offset = "0x356500", VA = "0x180357300")]
	public void Close()
	{
	}

	// Token: 0x06000E5F RID: 3679 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E5F")]
	[Address(RVA = "0x450AE0", Offset = "0x44FCE0", VA = "0x180450AE0")]
	public void NextFrame()
	{
	}

	// Token: 0x06000E60 RID: 3680 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E60")]
	[Address(RVA = "0x450B10", Offset = "0x44FD10", VA = "0x180450B10")]
	public void PreviousFrame()
	{
	}

	// Token: 0x06000E61 RID: 3681 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E61")]
	[Address(RVA = "0x450E40", Offset = "0x450040", VA = "0x180450E40")]
	public void TogglePlayback()
	{
	}

	// Token: 0x06000E62 RID: 3682 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E62")]
	[Address(RVA = "0x450D20", Offset = "0x44FF20", VA = "0x180450D20")]
	public void Save()
	{
	}

	// Token: 0x06000E63 RID: 3683 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E63")]
	[Address(RVA = "0x450C10", Offset = "0x44FE10", VA = "0x180450C10")]
	public void SaveImage()
	{
	}

	// Token: 0x06000E64 RID: 3684 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E64")]
	[Address(RVA = "0x450D90", Offset = "0x44FF90", VA = "0x180450D90")]
	public void Show()
	{
	}

	// Token: 0x06000E65 RID: 3685 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E65")]
	[Address(RVA = "0x450870", Offset = "0x44FA70", VA = "0x180450870")]
	private void Awake()
	{
	}

	// Token: 0x06000E66 RID: 3686 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E66")]
	[Address(RVA = "0x4508F0", Offset = "0x44FAF0", VA = "0x1804508F0")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000E67 RID: 3687 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000E67")]
	[Address(RVA = "0x450B40", Offset = "0x44FD40", VA = "0x180450B40")]
	private Task SaveImageAsync()
	{
		return null;
	}

	// Token: 0x06000E68 RID: 3688 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E68")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public CaptureMenu()
	{
	}

	// Token: 0x04000BA4 RID: 2980
	[Token(Token = "0x4000BA4")]
	[FieldOffset(Offset = "0x20")]
	public UIManager UI;

	// Token: 0x04000BA5 RID: 2981
	[Token(Token = "0x4000BA5")]
	[FieldOffset(Offset = "0x28")]
	public CapturePreview Preview;

	// Token: 0x04000BA6 RID: 2982
	[Token(Token = "0x4000BA6")]
	[FieldOffset(Offset = "0x30")]
	public Image PlayButton;

	// Token: 0x04000BA7 RID: 2983
	[Token(Token = "0x4000BA7")]
	[FieldOffset(Offset = "0x38")]
	public Sprite PlaySprite;

	// Token: 0x04000BA8 RID: 2984
	[Token(Token = "0x4000BA8")]
	[FieldOffset(Offset = "0x40")]
	public Sprite PauseSprite;

	// Token: 0x04000BA9 RID: 2985
	[Token(Token = "0x4000BA9")]
	[FieldOffset(Offset = "0x48")]
	private Option _playbackSpeed;

	// Token: 0x04000BAA RID: 2986
	[Token(Token = "0x4000BAA")]
	[FieldOffset(Offset = "0x50")]
	private Option _captureFrameRate;
}
