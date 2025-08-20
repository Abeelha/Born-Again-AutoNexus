using System;
using Il2CppDummyDll;
using MapEditor;
using UnityEngine;

// Token: 0x020000D0 RID: 208
[Token(Token = "0x20000D0")]
public class ZonePointObj : MonoBehaviour
{
	// Token: 0x0600039C RID: 924 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600039C")]
	[Address(RVA = "0x3D39C0", Offset = "0x3D2BC0", VA = "0x1803D39C0")]
	public void Setup(Vector2Int coordinates, ZonePointGroup group)
	{
	}

	// Token: 0x0600039D RID: 925 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600039D")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public ZonePointObj()
	{
	}

	// Token: 0x04000385 RID: 901
	[Token(Token = "0x4000385")]
	[FieldOffset(Offset = "0x20")]
	public SpriteRenderer SpriteRenderer;

	// Token: 0x04000386 RID: 902
	[Token(Token = "0x4000386")]
	[FieldOffset(Offset = "0x28")]
	private ZonePointGroup _group;
}
