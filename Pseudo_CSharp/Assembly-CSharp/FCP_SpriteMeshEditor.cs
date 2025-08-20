using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000004 RID: 4
[Token(Token = "0x2000004")]
[ExecuteInEditMode]
public class FCP_SpriteMeshEditor : MonoBehaviour
{
	// Token: 0x0600000C RID: 12 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000C")]
	[Address(RVA = "0x3228A0", Offset = "0x321AA0", VA = "0x1803228A0")]
	private void Update()
	{
	}

	// Token: 0x0600000D RID: 13 RVA: 0x00002070 File Offset: 0x00000270
	[Token(Token = "0x600000D")]
	[Address(RVA = "0x322280", Offset = "0x321480", VA = "0x180322280")]
	private int GetSettingHash()
	{
		return 0;
	}

	// Token: 0x0600000E RID: 14 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000E")]
	[Address(RVA = "0x322340", Offset = "0x321540", VA = "0x180322340")]
	private void MakeMesh(Sprite sprite, int x, int y, FCP_SpriteMeshEditor.MeshType meshtype)
	{
	}

	// Token: 0x0600000F RID: 15 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000F")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public FCP_SpriteMeshEditor()
	{
	}

	// Token: 0x0400000C RID: 12
	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x20")]
	public int x;

	// Token: 0x0400000D RID: 13
	[Token(Token = "0x400000D")]
	[FieldOffset(Offset = "0x24")]
	public int y;

	// Token: 0x0400000E RID: 14
	[Token(Token = "0x400000E")]
	[FieldOffset(Offset = "0x28")]
	public FCP_SpriteMeshEditor.MeshType meshType;

	// Token: 0x0400000F RID: 15
	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x30")]
	public Sprite sprite;

	// Token: 0x04000010 RID: 16
	[Token(Token = "0x4000010")]
	[FieldOffset(Offset = "0x38")]
	private int bufferedHash;

	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	public enum MeshType
	{
		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		CenterPoint,
		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4000013")]
		forward,
		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		backward
	}
}
