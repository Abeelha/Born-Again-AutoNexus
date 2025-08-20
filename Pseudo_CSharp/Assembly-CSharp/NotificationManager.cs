using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Il2CppDummyDll;
using Ronin.Model.Data;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000259 RID: 601
[Token(Token = "0x2000259")]
public class NotificationManager : MonoBehaviour
{
	// Token: 0x06000B52 RID: 2898 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B52")]
	[Address(RVA = "0x43B340", Offset = "0x43A540", VA = "0x18043B340")]
	public void Clear()
	{
	}

	// Token: 0x06000B53 RID: 2899 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B53")]
	[Address(RVA = "0x43B580", Offset = "0x43A780", VA = "0x18043B580")]
	public void HandleData(NotificationData data)
	{
	}

	// Token: 0x06000B54 RID: 2900 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B54")]
	[Address(RVA = "0x43B580", Offset = "0x43A780", VA = "0x18043B580")]
	public void HandleData(ref NotificationData data)
	{
	}

	// Token: 0x06000B55 RID: 2901 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B55")]
	[Address(RVA = "0x43B1E0", Offset = "0x43A3E0", VA = "0x18043B1E0")]
	private void Awake()
	{
	}

	// Token: 0x06000B56 RID: 2902 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B56")]
	[Address(RVA = "0x43B4B0", Offset = "0x43A6B0", VA = "0x18043B4B0")]
	private void Enqueue(NotificationData data)
	{
	}

	// Token: 0x06000B57 RID: 2903 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B57")]
	[Address(RVA = "0x43B600", Offset = "0x43A800", VA = "0x18043B600")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000B58 RID: 2904 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B58")]
	[Address(RVA = "0x43B340", Offset = "0x43A540", VA = "0x18043B340")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000B59 RID: 2905 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000B59")]
	[Address(RVA = "0x43B8C0", Offset = "0x43AAC0", VA = "0x18043B8C0")]
	private Task ShowAsync(NotificationData data)
	{
		return null;
	}

	// Token: 0x06000B5A RID: 2906 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B5A")]
	[Address(RVA = "0x43BA10", Offset = "0x43AC10", VA = "0x18043BA10")]
	public NotificationManager()
	{
	}

	// Token: 0x04000A05 RID: 2565
	[Token(Token = "0x4000A05")]
	private const float FadeDuration = 0.4f;

	// Token: 0x04000A06 RID: 2566
	[Token(Token = "0x4000A06")]
	[FieldOffset(Offset = "0x20")]
	public Image Icon;

	// Token: 0x04000A07 RID: 2567
	[Token(Token = "0x4000A07")]
	[FieldOffset(Offset = "0x28")]
	public TMP_Text Message;

	// Token: 0x04000A08 RID: 2568
	[Token(Token = "0x4000A08")]
	[FieldOffset(Offset = "0x30")]
	public Image Gradient;

	// Token: 0x04000A09 RID: 2569
	[Token(Token = "0x4000A09")]
	[FieldOffset(Offset = "0x38")]
	public RectTransform Container;

	// Token: 0x04000A0A RID: 2570
	[Token(Token = "0x4000A0A")]
	[FieldOffset(Offset = "0x40")]
	private readonly Queue<NotificationData> _queue;

	// Token: 0x04000A0B RID: 2571
	[Token(Token = "0x4000A0B")]
	[FieldOffset(Offset = "0x48")]
	private Graphic[] _graphics;

	// Token: 0x04000A0C RID: 2572
	[Token(Token = "0x4000A0C")]
	[FieldOffset(Offset = "0x50")]
	private bool _playing;

	// Token: 0x04000A0D RID: 2573
	[Token(Token = "0x4000A0D")]
	[FieldOffset(Offset = "0x54")]
	private float _gradientAlpha;

	// Token: 0x04000A0E RID: 2574
	[Token(Token = "0x4000A0E")]
	[FieldOffset(Offset = "0x58")]
	private Task _task;

	// Token: 0x04000A0F RID: 2575
	[Token(Token = "0x4000A0F")]
	[FieldOffset(Offset = "0x60")]
	private CancellationTokenSource _cancel;
}
