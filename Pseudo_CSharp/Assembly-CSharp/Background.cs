using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001E3 RID: 483
[Token(Token = "0x20001E3")]
public class Background : MonoBehaviour
{
	// Token: 0x060009D8 RID: 2520 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009D8")]
	[Address(RVA = "0x41FC20", Offset = "0x41EE20", VA = "0x18041FC20")]
	private void Awake()
	{
	}

	// Token: 0x060009D9 RID: 2521 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009D9")]
	[Address(RVA = "0x41FE30", Offset = "0x41F030", VA = "0x18041FE30")]
	private void LateUpdate()
	{
	}

	// Token: 0x060009DA RID: 2522 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009DA")]
	[Address(RVA = "0x41FFD0", Offset = "0x41F1D0", VA = "0x18041FFD0")]
	private void UpdatePosition()
	{
	}

	// Token: 0x060009DB RID: 2523 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009DB")]
	[Address(RVA = "0x4200D0", Offset = "0x41F2D0", VA = "0x1804200D0")]
	private void UpdateSize()
	{
	}

	// Token: 0x060009DC RID: 2524 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009DC")]
	[Address(RVA = "0x420180", Offset = "0x41F380", VA = "0x180420180")]
	private void UpdateViewport()
	{
	}

	// Token: 0x060009DD RID: 2525 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009DD")]
	[Address(RVA = "0x4204D0", Offset = "0x41F6D0", VA = "0x1804204D0")]
	public Background()
	{
	}

	// Token: 0x04000914 RID: 2324
	[Token(Token = "0x4000914")]
	[FieldOffset(Offset = "0x20")]
	public MeshFilter MeshFilter;

	// Token: 0x04000915 RID: 2325
	[Token(Token = "0x4000915")]
	[FieldOffset(Offset = "0x28")]
	public MeshRenderer MeshRenderer;

	// Token: 0x04000916 RID: 2326
	[Token(Token = "0x4000916")]
	[FieldOffset(Offset = "0x30")]
	public Camera GameCamera;

	// Token: 0x04000917 RID: 2327
	[Token(Token = "0x4000917")]
	[FieldOffset(Offset = "0x38")]
	public float PixelsPerUnit;

	// Token: 0x04000918 RID: 2328
	[Token(Token = "0x4000918")]
	[FieldOffset(Offset = "0x3C")]
	public Vector2 ScrollSpeed;

	// Token: 0x04000919 RID: 2329
	[Token(Token = "0x4000919")]
	[FieldOffset(Offset = "0x44")]
	public float Parallax;

	// Token: 0x0400091A RID: 2330
	[Token(Token = "0x400091A")]
	[FieldOffset(Offset = "0x48")]
	private Mesh _mesh;

	// Token: 0x0400091B RID: 2331
	[Token(Token = "0x400091B")]
	[FieldOffset(Offset = "0x50")]
	private Vector3[] _vertices;

	// Token: 0x0400091C RID: 2332
	[Token(Token = "0x400091C")]
	[FieldOffset(Offset = "0x58")]
	private Vector2[] _uvs;

	// Token: 0x0400091D RID: 2333
	[Token(Token = "0x400091D")]
	[FieldOffset(Offset = "0x60")]
	private Bounds _viewport;
}
