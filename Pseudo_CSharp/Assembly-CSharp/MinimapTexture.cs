using System;
using Il2CppDummyDll;
using Ronin.Model.Structs;
using UnityEngine;

// Token: 0x020002CF RID: 719
[Token(Token = "0x20002CF")]
public class MinimapTexture : MonoBehaviour
{
	// Token: 0x170001BC RID: 444
	// (get) Token: 0x06000F83 RID: 3971 RVA: 0x00006258 File Offset: 0x00004458
	[Token(Token = "0x170001BC")]
	public int Height
	{
		[Token(Token = "0x6000F83")]
		[Address(RVA = "0x470390", Offset = "0x46F590", VA = "0x180470390")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170001BD RID: 445
	// (get) Token: 0x06000F84 RID: 3972 RVA: 0x00006270 File Offset: 0x00004470
	[Token(Token = "0x170001BD")]
	public int Width
	{
		[Token(Token = "0x6000F84")]
		[Address(RVA = "0x4703C0", Offset = "0x46F5C0", VA = "0x1804703C0")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170001BE RID: 446
	// (get) Token: 0x06000F85 RID: 3973 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x170001BE")]
	public Texture2D Texture
	{
		[Token(Token = "0x6000F85")]
		[Address(RVA = "0x3944E0", Offset = "0x3936E0", VA = "0x1803944E0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000F86 RID: 3974 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F86")]
	[Address(RVA = "0x470140", Offset = "0x46F340", VA = "0x180470140")]
	public void NewWorld(Vector2Int mapSize)
	{
	}

	// Token: 0x06000F87 RID: 3975 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F87")]
	[Address(RVA = "0x4702C0", Offset = "0x46F4C0", VA = "0x1804702C0")]
	public void SetTile(CoordTile tile)
	{
	}

	// Token: 0x06000F88 RID: 3976 RVA: 0x00006288 File Offset: 0x00004488
	[Token(Token = "0x6000F88")]
	[Address(RVA = "0x46FC90", Offset = "0x46EE90", VA = "0x18046FC90")]
	private static Color AdjustColor(Color color)
	{
		return default(Color);
	}

	// Token: 0x06000F89 RID: 3977 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F89")]
	[Address(RVA = "0x4700A0", Offset = "0x46F2A0", VA = "0x1804700A0")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000F8A RID: 3978 RVA: 0x000062A0 File Offset: 0x000044A0
	[Token(Token = "0x6000F8A")]
	[Address(RVA = "0x46FD80", Offset = "0x46EF80", VA = "0x18046FD80")]
	private Color GetColor(ref CoordTile tile)
	{
		return default(Color);
	}

	// Token: 0x06000F8B RID: 3979 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F8B")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public MinimapTexture()
	{
	}

	// Token: 0x04000CD2 RID: 3282
	[Token(Token = "0x4000CD2")]
	public const int Margin = 1;

	// Token: 0x04000CD3 RID: 3283
	[Token(Token = "0x4000CD3")]
	[FieldOffset(Offset = "0x20")]
	public Material MinimapMaterial;

	// Token: 0x04000CD4 RID: 3284
	[Token(Token = "0x4000CD4")]
	[FieldOffset(Offset = "0x28")]
	private Color32[] _colors;

	// Token: 0x04000CD5 RID: 3285
	[Token(Token = "0x4000CD5")]
	[FieldOffset(Offset = "0x30")]
	private bool _textureDirty;

	// Token: 0x04000CD6 RID: 3286
	[Token(Token = "0x4000CD6")]
	[FieldOffset(Offset = "0x38")]
	private Texture2D _mapTexture;

	// Token: 0x04000CD7 RID: 3287
	[Token(Token = "0x4000CD7")]
	[FieldOffset(Offset = "0x40")]
	private Color32[] _discoveryColors;
}
