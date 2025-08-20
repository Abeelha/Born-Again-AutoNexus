using System;
using Il2CppDummyDll;
using Ronin.Model.Files.Animation;
using UnityEngine;

// Token: 0x02000150 RID: 336
[Token(Token = "0x2000150")]
public class MeshRig : MonoBehaviour, IAnimatedObject
{
	// Token: 0x06000625 RID: 1573 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000625")]
	[Address(RVA = "0x316090", Offset = "0x315290", VA = "0x180316090", Slot = "4")]
	public void SetColor(Color color)
	{
	}

	// Token: 0x06000626 RID: 1574 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000626")]
	[Address(RVA = "0x316090", Offset = "0x315290", VA = "0x180316090", Slot = "7")]
	public void SetFlipped(bool value)
	{
	}

	// Token: 0x06000627 RID: 1575 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000627")]
	[Address(RVA = "0x316090", Offset = "0x315290", VA = "0x180316090", Slot = "5")]
	public void SetLayer(int layer)
	{
	}

	// Token: 0x06000628 RID: 1576 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000628")]
	[Address(RVA = "0x3F09F0", Offset = "0x3EFBF0", VA = "0x1803F09F0", Slot = "6")]
	public void SetSprite(AnimationFrame frame)
	{
	}

	// Token: 0x06000629 RID: 1577 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000629")]
	[Address(RVA = "0x3F08E0", Offset = "0x3EFAE0", VA = "0x1803F08E0")]
	private void OnEnable()
	{
	}

	// Token: 0x0600062A RID: 1578 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600062A")]
	[Address(RVA = "0x3F08E0", Offset = "0x3EFAE0", VA = "0x1803F08E0")]
	private void UpdateMaterial()
	{
	}

	// Token: 0x0600062B RID: 1579 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600062B")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public MeshRig()
	{
	}

	// Token: 0x040006A3 RID: 1699
	[Token(Token = "0x40006A3")]
	[FieldOffset(Offset = "0x20")]
	public MeshFilter MeshFilter;

	// Token: 0x040006A4 RID: 1700
	[Token(Token = "0x40006A4")]
	[FieldOffset(Offset = "0x28")]
	public MeshRenderer MeshRenderer;

	// Token: 0x040006A5 RID: 1701
	[Token(Token = "0x40006A5")]
	[FieldOffset(Offset = "0x30")]
	private bool _flat;
}
