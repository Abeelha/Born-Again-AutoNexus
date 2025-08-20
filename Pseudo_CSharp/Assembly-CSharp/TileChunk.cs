using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Ronin.Model.Enums;
using UnityEngine;

// Token: 0x0200027E RID: 638
[Token(Token = "0x200027E")]
public class TileChunk : MonoBehaviour, IChunk
{
	// Token: 0x17000140 RID: 320
	// (get) Token: 0x06000CA8 RID: 3240 RVA: 0x000052F8 File Offset: 0x000034F8
	// (set) Token: 0x06000CA9 RID: 3241 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000140")]
	public Vector2Int Index
	{
		[Token(Token = "0x6000CA8")]
		[Address(RVA = "0x3EEC00", Offset = "0x3EDE00", VA = "0x1803EEC00", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(Vector2Int);
		}
		[Token(Token = "0x6000CA9")]
		[Address(RVA = "0x45BA70", Offset = "0x45AC70", VA = "0x18045BA70", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x17000141 RID: 321
	// (get) Token: 0x06000CAA RID: 3242 RVA: 0x00005310 File Offset: 0x00003510
	// (set) Token: 0x06000CAB RID: 3243 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000141")]
	public Vector2Int Position
	{
		[Token(Token = "0x6000CAA")]
		[Address(RVA = "0x45B990", Offset = "0x45AB90", VA = "0x18045B990", Slot = "11")]
		get
		{
			return default(Vector2Int);
		}
		[Token(Token = "0x6000CAB")]
		[Address(RVA = "0x45BA80", Offset = "0x45AC80", VA = "0x18045BA80", Slot = "6")]
		set
		{
		}
	}

	// Token: 0x17000142 RID: 322
	// (get) Token: 0x06000CAC RID: 3244 RVA: 0x00005328 File Offset: 0x00003528
	[Token(Token = "0x17000142")]
	public RectInt Rect
	{
		[Token(Token = "0x6000CAC")]
		[Address(RVA = "0x45BA10", Offset = "0x45AC10", VA = "0x18045BA10")]
		get
		{
			return default(RectInt);
		}
	}

	// Token: 0x17000143 RID: 323
	// (get) Token: 0x06000CAD RID: 3245 RVA: 0x00005340 File Offset: 0x00003540
	// (set) Token: 0x06000CAE RID: 3246 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000143")]
	public Vector2Int Size
	{
		[Token(Token = "0x6000CAD")]
		[Address(RVA = "0x3ECAC0", Offset = "0x3EBCC0", VA = "0x1803ECAC0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2Int);
		}
		[Token(Token = "0x6000CAE")]
		[Address(RVA = "0x45BB00", Offset = "0x45AD00", VA = "0x18045BB00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x17000144 RID: 324
	// (get) Token: 0x06000CAF RID: 3247 RVA: 0x00005358 File Offset: 0x00003558
	// (set) Token: 0x06000CB0 RID: 3248 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000144")]
	public float Z
	{
		[Token(Token = "0x6000CAF")]
		[Address(RVA = "0x45BA50", Offset = "0x45AC50", VA = "0x18045BA50")]
		[CompilerGenerated]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000CB0")]
		[Address(RVA = "0x45BB10", Offset = "0x45AD10", VA = "0x18045BB10")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x17000145 RID: 325
	// (get) Token: 0x06000CB1 RID: 3249 RVA: 0x00005370 File Offset: 0x00003570
	// (set) Token: 0x06000CB2 RID: 3250 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000145")]
	public Vector2Int Zone
	{
		[Token(Token = "0x6000CB1")]
		[Address(RVA = "0x45BA60", Offset = "0x45AC60", VA = "0x18045BA60", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(Vector2Int);
		}
		[Token(Token = "0x6000CB2")]
		[Address(RVA = "0x45BB20", Offset = "0x45AD20", VA = "0x18045BB20", Slot = "8")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x06000CB3 RID: 3251 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CB3")]
	[Address(RVA = "0x45B550", Offset = "0x45A750", VA = "0x18045B550", Slot = "9")]
	public void Create(Vector2Int size)
	{
	}

	// Token: 0x06000CB4 RID: 3252 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CB4")]
	[Address(RVA = "0x45B800", Offset = "0x45AA00", VA = "0x18045B800", Slot = "10")]
	public void SetActive(bool active)
	{
	}

	// Token: 0x06000CB5 RID: 3253 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CB5")]
	[Address(RVA = "0x45B830", Offset = "0x45AA30", VA = "0x18045B830")]
	public void SetAlpha(float alpha, int tileIndex)
	{
	}

	// Token: 0x06000CB6 RID: 3254 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CB6")]
	[Address(RVA = "0x45B850", Offset = "0x45AA50", VA = "0x18045B850")]
	public void SetDrift(TileDriftType driftType, int tileIndex)
	{
	}

	// Token: 0x06000CB7 RID: 3255 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CB7")]
	[Address(RVA = "0x45B880", Offset = "0x45AA80", VA = "0x18045B880")]
	public void SetSprite(TileSprite sprite, int tileIndex)
	{
	}

	// Token: 0x06000CB8 RID: 3256 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CB8")]
	[Address(RVA = "0x45B8E0", Offset = "0x45AAE0", VA = "0x18045B8E0")]
	public void SetSprite(Sprite sprite, int tileIndex)
	{
	}

	// Token: 0x06000CB9 RID: 3257 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CB9")]
	[Address(RVA = "0x45B7A0", Offset = "0x45A9A0", VA = "0x18045B7A0")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000CBA RID: 3258 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CBA")]
	[Address(RVA = "0x45B930", Offset = "0x45AB30", VA = "0x18045B930")]
	public TileChunk()
	{
	}

	// Token: 0x04000AE7 RID: 2791
	[Token(Token = "0x4000AE7")]
	[FieldOffset(Offset = "0x20")]
	public MeshFilter MeshFilter;

	// Token: 0x04000AE8 RID: 2792
	[Token(Token = "0x4000AE8")]
	[FieldOffset(Offset = "0x28")]
	public MeshRenderer MeshRenderer;

	// Token: 0x04000AE9 RID: 2793
	[Token(Token = "0x4000AE9")]
	[FieldOffset(Offset = "0x30")]
	private Mesh _generatedMesh;

	// Token: 0x04000AEA RID: 2794
	[Token(Token = "0x4000AEA")]
	[FieldOffset(Offset = "0x38")]
	private TileUv _uv;

	// Token: 0x04000AEB RID: 2795
	[Token(Token = "0x4000AEB")]
	[FieldOffset(Offset = "0x50")]
	private TileUv _uv2;

	// Token: 0x04000AED RID: 2797
	[Token(Token = "0x4000AED")]
	[FieldOffset(Offset = "0x70")]
	public Vector2 NoneUv;
}
