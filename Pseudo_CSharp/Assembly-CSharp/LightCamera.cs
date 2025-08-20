using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000BD RID: 189
[Token(Token = "0x20000BD")]
public class LightCamera : MonoBehaviour
{
	// Token: 0x17000049 RID: 73
	// (get) Token: 0x0600033A RID: 826 RVA: 0x00003168 File Offset: 0x00001368
	[Token(Token = "0x17000049")]
	private float TextureScale
	{
		[Token(Token = "0x600033A")]
		[Address(RVA = "0x3C5E60", Offset = "0x3C5060", VA = "0x1803C5E60")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x1700004A RID: 74
	// (get) Token: 0x0600033B RID: 827 RVA: 0x00003180 File Offset: 0x00001380
	[Token(Token = "0x1700004A")]
	private Vector2 ExpectedTextureSize
	{
		[Token(Token = "0x600033B")]
		[Address(RVA = "0x3C5D70", Offset = "0x3C4F70", VA = "0x1803C5D70")]
		get
		{
			return default(Vector2);
		}
	}

	// Token: 0x0600033C RID: 828 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600033C")]
	[Address(RVA = "0x3C5580", Offset = "0x3C4780", VA = "0x1803C5580")]
	private void Awake()
	{
	}

	// Token: 0x0600033D RID: 829 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600033D")]
	[Address(RVA = "0x3C5820", Offset = "0x3C4A20", VA = "0x1803C5820")]
	private void LateUpdate()
	{
	}

	// Token: 0x0600033E RID: 830 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600033E")]
	[Address(RVA = "0x3C5B30", Offset = "0x3C4D30", VA = "0x1803C5B30")]
	private void SyncGlobal()
	{
	}

	// Token: 0x0600033F RID: 831 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600033F")]
	[Address(RVA = "0x3C5C00", Offset = "0x3C4E00", VA = "0x1803C5C00")]
	private void UpdateSize()
	{
	}

	// Token: 0x06000340 RID: 832 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000340")]
	[Address(RVA = "0x3C5610", Offset = "0x3C4810", VA = "0x1803C5610")]
	private void CreateTexture()
	{
	}

	// Token: 0x06000341 RID: 833 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000341")]
	[Address(RVA = "0x3C5A40", Offset = "0x3C4C40", VA = "0x1803C5A40")]
	private void OnPostRender()
	{
	}

	// Token: 0x06000342 RID: 834 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000342")]
	[Address(RVA = "0x3A2F00", Offset = "0x3A2100", VA = "0x1803A2F00")]
	public LightCamera()
	{
	}

	// Token: 0x04000326 RID: 806
	[Token(Token = "0x4000326")]
	[FieldOffset(Offset = "0x20")]
	public Camera Camera;

	// Token: 0x04000327 RID: 807
	[Token(Token = "0x4000327")]
	[FieldOffset(Offset = "0x28")]
	public Material Tonemapping;

	// Token: 0x04000328 RID: 808
	[Token(Token = "0x4000328")]
	[FieldOffset(Offset = "0x30")]
	public Color GlobalLight;

	// Token: 0x04000329 RID: 809
	[Token(Token = "0x4000329")]
	[FieldOffset(Offset = "0x40")]
	private RenderTexture _writeRenderTexture;

	// Token: 0x0400032A RID: 810
	[Token(Token = "0x400032A")]
	[FieldOffset(Offset = "0x48")]
	private RenderTexture _renderTexture;

	// Token: 0x0400032B RID: 811
	[Token(Token = "0x400032B")]
	[FieldOffset(Offset = "0x50")]
	private Color _syncedGlobal;

	// Token: 0x0400032C RID: 812
	[Token(Token = "0x400032C")]
	[FieldOffset(Offset = "0x60")]
	private Option _lightQuality;

	// Token: 0x0400032D RID: 813
	[Token(Token = "0x400032D")]
	[FieldOffset(Offset = "0x68")]
	private Option _resolutionScale;
}
