using System;
using Il2CppDummyDll;
using Ronin.Model.Files.Animation;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200014F RID: 335
[Token(Token = "0x200014F")]
public class ImageRig : MonoBehaviour, IAnimatedObject
{
	// Token: 0x06000620 RID: 1568 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000620")]
	[Address(RVA = "0x3F0800", Offset = "0x3EFA00", VA = "0x1803F0800", Slot = "4")]
	public void SetColor(Color color)
	{
	}

	// Token: 0x06000621 RID: 1569 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000621")]
	[Address(RVA = "0x316090", Offset = "0x315290", VA = "0x180316090", Slot = "7")]
	public void SetFlipped(bool value)
	{
	}

	// Token: 0x06000622 RID: 1570 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000622")]
	[Address(RVA = "0x316090", Offset = "0x315290", VA = "0x180316090", Slot = "5")]
	public void SetLayer(int layer)
	{
	}

	// Token: 0x06000623 RID: 1571 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000623")]
	[Address(RVA = "0x3F0840", Offset = "0x3EFA40", VA = "0x1803F0840", Slot = "6")]
	public void SetSprite(AnimationFrame frame)
	{
	}

	// Token: 0x06000624 RID: 1572 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000624")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public ImageRig()
	{
	}

	// Token: 0x040006A2 RID: 1698
	[Token(Token = "0x40006A2")]
	[FieldOffset(Offset = "0x20")]
	public Image Image;
}
