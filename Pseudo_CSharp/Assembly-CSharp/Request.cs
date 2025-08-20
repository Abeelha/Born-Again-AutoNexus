using System;
using AnimateInternal;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020002DF RID: 735
[Token(Token = "0x20002DF")]
public class Request : MonoBehaviour
{
	// Token: 0x170001CE RID: 462
	// (get) Token: 0x06000FFF RID: 4095 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x170001CE")]
	public RectTransform RectTransform
	{
		[Token(Token = "0x6000FFF")]
		[Address(RVA = "0x357910", Offset = "0x356B10", VA = "0x180357910")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001000 RID: 4096 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001000")]
	[Address(RVA = "0x357500", Offset = "0x356700", VA = "0x180357500")]
	public void Setup(string command, string playerName, string labelText, Sprite iconSprite)
	{
	}

	// Token: 0x06001001 RID: 4097 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001001")]
	[Address(RVA = "0x3575E0", Offset = "0x3567E0", VA = "0x1803575E0")]
	public void Show()
	{
	}

	// Token: 0x06001002 RID: 4098 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001002")]
	[Address(RVA = "0x357300", Offset = "0x356500", VA = "0x180357300")]
	public void Close()
	{
	}

	// Token: 0x06001003 RID: 4099 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001003")]
	[Address(RVA = "0x3573F0", Offset = "0x3565F0", VA = "0x1803573F0")]
	public void Ok()
	{
	}

	// Token: 0x06001004 RID: 4100 RVA: 0x00006480 File Offset: 0x00004680
	[Token(Token = "0x6001004")]
	[Address(RVA = "0x357330", Offset = "0x356530", VA = "0x180357330")]
	private Vector2 GetContentSize()
	{
		return default(Vector2);
	}

	// Token: 0x06001005 RID: 4101 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001005")]
	[Address(RVA = "0x3578A0", Offset = "0x356AA0", VA = "0x1803578A0")]
	private void Update()
	{
	}

	// Token: 0x06001006 RID: 4102 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001006")]
	[Address(RVA = "0x3578F0", Offset = "0x356AF0", VA = "0x1803578F0")]
	public Request()
	{
	}

	// Token: 0x04000D57 RID: 3415
	[Token(Token = "0x4000D57")]
	private const float RequestTime = 22f;

	// Token: 0x04000D58 RID: 3416
	[Token(Token = "0x4000D58")]
	[FieldOffset(Offset = "0x20")]
	public float Height;

	// Token: 0x04000D59 RID: 3417
	[Token(Token = "0x4000D59")]
	[FieldOffset(Offset = "0x28")]
	public RectTransform Content;

	// Token: 0x04000D5A RID: 3418
	[Token(Token = "0x4000D5A")]
	[FieldOffset(Offset = "0x30")]
	public TextMeshProUGUI Label;

	// Token: 0x04000D5B RID: 3419
	[Token(Token = "0x4000D5B")]
	[FieldOffset(Offset = "0x38")]
	public EasingType Ease;

	// Token: 0x04000D5C RID: 3420
	[Token(Token = "0x4000D5C")]
	[FieldOffset(Offset = "0x40")]
	public World World;

	// Token: 0x04000D5D RID: 3421
	[Token(Token = "0x4000D5D")]
	[FieldOffset(Offset = "0x48")]
	public Image Icon;

	// Token: 0x04000D5E RID: 3422
	[Token(Token = "0x4000D5E")]
	[FieldOffset(Offset = "0x50")]
	private AnimateTask _sizeTask;

	// Token: 0x04000D5F RID: 3423
	[Token(Token = "0x4000D5F")]
	[FieldOffset(Offset = "0x58")]
	private float _showTime;

	// Token: 0x04000D60 RID: 3424
	[Token(Token = "0x4000D60")]
	[FieldOffset(Offset = "0x60")]
	private string _command;

	// Token: 0x04000D61 RID: 3425
	[Token(Token = "0x4000D61")]
	[FieldOffset(Offset = "0x68")]
	private string _playerName;
}
