using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Ronin.Model.Structs;
using UnityEngine;

// Token: 0x020000CD RID: 205
[Token(Token = "0x20000CD")]
public class SpawnZoneObj : MonoBehaviour
{
	// Token: 0x06000393 RID: 915 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000393")]
	[Address(RVA = "0x3C8BB0", Offset = "0x3C7DB0", VA = "0x1803C8BB0")]
	public void Setup(Vector2Int coordinates, SpawnZone spawnZone)
	{
	}

	// Token: 0x06000394 RID: 916 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000394")]
	[Address(RVA = "0x3C8580", Offset = "0x3C7780", VA = "0x1803C8580")]
	private SpriteRenderer GetPreview(int index)
	{
		return null;
	}

	// Token: 0x06000395 RID: 917 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000395")]
	[Address(RVA = "0x3C87C0", Offset = "0x3C79C0", VA = "0x1803C87C0")]
	private void SetPreviews(IEnumerable<Sprite> sprites)
	{
	}

	// Token: 0x06000396 RID: 918 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000396")]
	[Address(RVA = "0x3C8DC0", Offset = "0x3C7FC0", VA = "0x1803C8DC0")]
	public SpawnZoneObj()
	{
	}

	// Token: 0x0400037E RID: 894
	[Token(Token = "0x400037E")]
	[FieldOffset(Offset = "0x20")]
	public SpriteRenderer SpriteRenderer;

	// Token: 0x0400037F RID: 895
	[Token(Token = "0x400037F")]
	[FieldOffset(Offset = "0x28")]
	public SpriteRenderer PreviewPrefab;

	// Token: 0x04000380 RID: 896
	[Token(Token = "0x4000380")]
	[FieldOffset(Offset = "0x30")]
	private readonly List<SpriteRenderer> _previews;
}
