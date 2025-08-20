using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Ronin.Model.Files.Map.Chunks;
using Ronin.Model.Interfaces;
using Ronin.Model.Structs;
using UnityEngine;

// Token: 0x02000277 RID: 631
[Token(Token = "0x2000277")]
public class Map
{
	// Token: 0x06000C58 RID: 3160 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C58")]
	[Address(RVA = "0x43AAD0", Offset = "0x439CD0", VA = "0x18043AAD0")]
	public Map(World world, Camera camera)
	{
	}

	// Token: 0x06000C59 RID: 3161 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C59")]
	[Address(RVA = "0x438D30", Offset = "0x437F30", VA = "0x180438D30")]
	public void AddAreaZone(Vector2Int contentOffset, AreaZoneChunk areaZone)
	{
	}

	// Token: 0x06000C5A RID: 3162 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C5A")]
	[Address(RVA = "0x438FE0", Offset = "0x4381E0", VA = "0x180438FE0")]
	public void AddCameraZonePoint(string label, Vector2Int point)
	{
	}

	// Token: 0x06000C5B RID: 3163 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C5B")]
	[Address(RVA = "0x4392A0", Offset = "0x4384A0", VA = "0x1804392A0")]
	public void AddNoCameraPoint(Vector2Int point)
	{
	}

	// Token: 0x06000C5C RID: 3164 RVA: 0x000051A8 File Offset: 0x000033A8
	[Token(Token = "0x6000C5C")]
	[Address(RVA = "0x439420", Offset = "0x438620", VA = "0x180439420")]
	public bool BlockAttack(int x, int y)
	{
		return default(bool);
	}

	// Token: 0x06000C5D RID: 3165 RVA: 0x000051C0 File Offset: 0x000033C0
	[Token(Token = "0x6000C5D")]
	[Address(RVA = "0x439500", Offset = "0x438700", VA = "0x180439500")]
	public bool CanWalk(int x, int y)
	{
		return default(bool);
	}

	// Token: 0x06000C5E RID: 3166 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000C5E")]
	[Address(RVA = "0x439610", Offset = "0x438810", VA = "0x180439610")]
	public AreaZoneChunk GetAreaZone(Vector2Int point)
	{
		return null;
	}

	// Token: 0x06000C5F RID: 3167 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000C5F")]
	[Address(RVA = "0x439690", Offset = "0x438890", VA = "0x180439690")]
	public IEnumerable<AreaZoneChunk> GetAreaZones(string label)
	{
		return null;
	}

	// Token: 0x06000C60 RID: 3168 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000C60")]
	[Address(RVA = "0x439710", Offset = "0x438910", VA = "0x180439710")]
	public CameraZone GetCameraZone(Vector2Int point)
	{
		return null;
	}

	// Token: 0x06000C61 RID: 3169 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000C61")]
	[Address(RVA = "0x4397C0", Offset = "0x4389C0", VA = "0x1804397C0")]
	public IEnumerable<ValueTuple<ushort, string, Vector2Int>> GetLabels()
	{
		return null;
	}

	// Token: 0x06000C62 RID: 3170 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000C62")]
	[Address(RVA = "0x439840", Offset = "0x438A40", VA = "0x180439840")]
	public IEnumerable<WorldObject> GetObjects()
	{
		return null;
	}

	// Token: 0x06000C63 RID: 3171 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000C63")]
	[Address(RVA = "0x439980", Offset = "0x438B80", VA = "0x180439980")]
	public IEnumerable<ValueTuple<ushort, Vector2Int>> GetTravelLocations()
	{
		return null;
	}

	// Token: 0x06000C64 RID: 3172 RVA: 0x000051D8 File Offset: 0x000033D8
	[Token(Token = "0x6000C64")]
	[Address(RVA = "0x439860", Offset = "0x438A60", VA = "0x180439860")]
	public Tile? GetTile(int x, int y)
	{
		return null;
	}

	// Token: 0x06000C65 RID: 3173 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C65")]
	[Address(RVA = "0x439B60", Offset = "0x438D60", VA = "0x180439B60")]
	public void NewMap(Vector2Int size)
	{
	}

	// Token: 0x06000C66 RID: 3174 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C66")]
	[Address(RVA = "0x43A320", Offset = "0x439520", VA = "0x18043A320")]
	public void SetOverride(CoordOverride coordOverride)
	{
	}

	// Token: 0x06000C67 RID: 3175 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C67")]
	[Address(RVA = "0x43A410", Offset = "0x439610", VA = "0x18043A410")]
	public void SetTile(CoordTile tile)
	{
	}

	// Token: 0x06000C68 RID: 3176 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C68")]
	[Address(RVA = "0x43A3F0", Offset = "0x4395F0", VA = "0x18043A3F0")]
	public void SetRevealPosition(Vector2 position, bool force = false)
	{
	}

	// Token: 0x06000C69 RID: 3177 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C69")]
	[Address(RVA = "0x43A780", Offset = "0x439980", VA = "0x18043A780")]
	public void SetViewPosition(Vector2 position, Vector2 viewSize)
	{
	}

	// Token: 0x06000C6A RID: 3178 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C6A")]
	[Address(RVA = "0x43A920", Offset = "0x439B20", VA = "0x18043A920")]
	public void Update()
	{
	}

	// Token: 0x06000C6B RID: 3179 RVA: 0x000051F0 File Offset: 0x000033F0
	[Token(Token = "0x6000C6B")]
	[Address(RVA = "0x4399F0", Offset = "0x438BF0", VA = "0x1804399F0")]
	private Vector2Int GetViewChunkSize()
	{
		return default(Vector2Int);
	}

	// Token: 0x04000AB4 RID: 2740
	[Token(Token = "0x4000AB4")]
	private const int ChunkTilePadding = 10;

	// Token: 0x04000AB5 RID: 2741
	[Token(Token = "0x4000AB5")]
	[FieldOffset(Offset = "0x0")]
	private static Vector2Int s_chunkSize;

	// Token: 0x04000AB6 RID: 2742
	[Token(Token = "0x4000AB6")]
	[FieldOffset(Offset = "0x10")]
	public Vector2Int Size;

	// Token: 0x04000AB7 RID: 2743
	[Token(Token = "0x4000AB7")]
	[FieldOffset(Offset = "0x18")]
	private TileMap _tileMap;

	// Token: 0x04000AB8 RID: 2744
	[Token(Token = "0x4000AB8")]
	[FieldOffset(Offset = "0x20")]
	private TileView _tileView;

	// Token: 0x04000AB9 RID: 2745
	[Token(Token = "0x4000AB9")]
	[FieldOffset(Offset = "0x28")]
	private BlendView _blendView;

	// Token: 0x04000ABA RID: 2746
	[Token(Token = "0x4000ABA")]
	[FieldOffset(Offset = "0x30")]
	private ObjectView _objectView;

	// Token: 0x04000ABB RID: 2747
	[Token(Token = "0x4000ABB")]
	[FieldOffset(Offset = "0x38")]
	private CeilingView _ceilingView;

	// Token: 0x04000ABC RID: 2748
	[Token(Token = "0x4000ABC")]
	[FieldOffset(Offset = "0x40")]
	private Vector2Int _viewChunkSize;

	// Token: 0x04000ABD RID: 2749
	[Token(Token = "0x4000ABD")]
	[FieldOffset(Offset = "0x48")]
	private readonly Dictionary<Vector2Int, IOverride> _overrides;

	// Token: 0x04000ABE RID: 2750
	[Token(Token = "0x4000ABE")]
	[FieldOffset(Offset = "0x50")]
	private readonly Dictionary<Vector2Int, CameraZone> _cameraZonesPointMap;

	// Token: 0x04000ABF RID: 2751
	[Token(Token = "0x4000ABF")]
	[FieldOffset(Offset = "0x58")]
	private readonly HashSet<Vector2Int> _noCameraPoints;

	// Token: 0x04000AC0 RID: 2752
	[Token(Token = "0x4000AC0")]
	[FieldOffset(Offset = "0x60")]
	private readonly Dictionary<Vector2Int, AreaZoneChunk> _areaZoneMap;

	// Token: 0x04000AC1 RID: 2753
	[Token(Token = "0x4000AC1")]
	[FieldOffset(Offset = "0x68")]
	private readonly Dictionary<string, List<AreaZoneChunk>> _majorZones;

	// Token: 0x04000AC2 RID: 2754
	[Token(Token = "0x4000AC2")]
	[FieldOffset(Offset = "0x70")]
	private readonly Dictionary<string, CameraZone> _cameraZonesLabelMap;

	// Token: 0x04000AC3 RID: 2755
	[Token(Token = "0x4000AC3")]
	[FieldOffset(Offset = "0x78")]
	private readonly Dictionary<Vector2Int, ushort> _labels;

	// Token: 0x04000AC4 RID: 2756
	[Token(Token = "0x4000AC4")]
	[FieldOffset(Offset = "0x80")]
	private readonly Dictionary<Vector2Int, ushort> _travelLocations;

	// Token: 0x04000AC5 RID: 2757
	[Token(Token = "0x4000AC5")]
	[FieldOffset(Offset = "0x88")]
	private readonly List<ChunkView> _chunkViews;

	// Token: 0x04000AC6 RID: 2758
	[Token(Token = "0x4000AC6")]
	[FieldOffset(Offset = "0x90")]
	private readonly World _world;

	// Token: 0x04000AC7 RID: 2759
	[Token(Token = "0x4000AC7")]
	[FieldOffset(Offset = "0x98")]
	private readonly Camera _camera;

	// Token: 0x04000AC8 RID: 2760
	[Token(Token = "0x4000AC8")]
	[FieldOffset(Offset = "0xA0")]
	private readonly DarknessTexture _darknessTexture;
}
