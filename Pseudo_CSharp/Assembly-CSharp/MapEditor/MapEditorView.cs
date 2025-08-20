using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Ronin.Model.Enums;
using Ronin.Model.Interfaces;
using Ronin.Model.Structs;
using UnityEngine;

namespace MapEditor
{
	// Token: 0x02000383 RID: 899
	[Token(Token = "0x2000383")]
	public class MapEditorView : MonoBehaviour
	{
		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06001464 RID: 5220 RVA: 0x00007200 File Offset: 0x00005400
		// (set) Token: 0x06001465 RID: 5221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000218")]
		public bool AreaZoneVisibility
		{
			[Token(Token = "0x6001464")]
			[Address(RVA = "0x39F510", Offset = "0x39E710", VA = "0x18039F510")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001465")]
			[Address(RVA = "0x39F600", Offset = "0x39E800", VA = "0x18039F600")]
			set
			{
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06001466 RID: 5222 RVA: 0x00007218 File Offset: 0x00005418
		// (set) Token: 0x06001467 RID: 5223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000219")]
		public bool CeilingVisibility
		{
			[Token(Token = "0x6001466")]
			[Address(RVA = "0x39F530", Offset = "0x39E730", VA = "0x18039F530")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001467")]
			[Address(RVA = "0x39F630", Offset = "0x39E830", VA = "0x18039F630")]
			set
			{
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06001468 RID: 5224 RVA: 0x00007230 File Offset: 0x00005430
		// (set) Token: 0x06001469 RID: 5225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700021A")]
		public bool DarknessVisibility
		{
			[Token(Token = "0x6001468")]
			[Address(RVA = "0x39F540", Offset = "0x39E740", VA = "0x18039F540")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001469")]
			[Address(RVA = "0x39F660", Offset = "0x39E860", VA = "0x18039F660")]
			set
			{
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x0600146A RID: 5226 RVA: 0x00007248 File Offset: 0x00005448
		// (set) Token: 0x0600146B RID: 5227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700021B")]
		public bool ObjectVisibility
		{
			[Token(Token = "0x600146A")]
			[Address(RVA = "0x39F560", Offset = "0x39E760", VA = "0x18039F560")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600146B")]
			[Address(RVA = "0x39F690", Offset = "0x39E890", VA = "0x18039F690")]
			set
			{
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x0600146C RID: 5228 RVA: 0x00007260 File Offset: 0x00005460
		// (set) Token: 0x0600146D RID: 5229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700021C")]
		public bool OverrideVisibility
		{
			[Token(Token = "0x600146C")]
			[Address(RVA = "0x39F570", Offset = "0x39E770", VA = "0x18039F570")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600146D")]
			[Address(RVA = "0x39F6C0", Offset = "0x39E8C0", VA = "0x18039F6C0")]
			set
			{
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x0600146E RID: 5230 RVA: 0x00007278 File Offset: 0x00005478
		// (set) Token: 0x0600146F RID: 5231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700021D")]
		public bool RegionVisibility
		{
			[Token(Token = "0x600146E")]
			[Address(RVA = "0x39F590", Offset = "0x39E790", VA = "0x18039F590")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600146F")]
			[Address(RVA = "0x39F6F0", Offset = "0x39E8F0", VA = "0x18039F6F0")]
			set
			{
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06001470 RID: 5232 RVA: 0x00007290 File Offset: 0x00005490
		// (set) Token: 0x06001471 RID: 5233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700021E")]
		public bool SpawnZoneVisibility
		{
			[Token(Token = "0x6001470")]
			[Address(RVA = "0x39F5B0", Offset = "0x39E7B0", VA = "0x18039F5B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001471")]
			[Address(RVA = "0x39F720", Offset = "0x39E920", VA = "0x18039F720")]
			set
			{
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06001472 RID: 5234 RVA: 0x000072A8 File Offset: 0x000054A8
		// (set) Token: 0x06001473 RID: 5235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700021F")]
		public bool TileVisibility
		{
			[Token(Token = "0x6001472")]
			[Address(RVA = "0x39F5D0", Offset = "0x39E7D0", VA = "0x18039F5D0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001473")]
			[Address(RVA = "0x39F750", Offset = "0x39E950", VA = "0x18039F750")]
			set
			{
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06001474 RID: 5236 RVA: 0x000072C0 File Offset: 0x000054C0
		// (set) Token: 0x06001475 RID: 5237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000220")]
		public bool ZoneVisibility
		{
			[Token(Token = "0x6001474")]
			[Address(RVA = "0x39F5E0", Offset = "0x39E7E0", VA = "0x18039F5E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001475")]
			[Address(RVA = "0x39F7B0", Offset = "0x39E9B0", VA = "0x18039F7B0")]
			set
			{
			}
		}

		// Token: 0x06001476 RID: 5238 RVA: 0x000072D8 File Offset: 0x000054D8
		[Token(Token = "0x6001476")]
		[Address(RVA = "0x39E0C0", Offset = "0x39D2C0", VA = "0x18039E0C0")]
		public Vector2 ScreenToMapPosition(Vector2 screenPosition)
		{
			return default(Vector2);
		}

		// Token: 0x06001477 RID: 5239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001477")]
		[Address(RVA = "0x39CC40", Offset = "0x39BE40", VA = "0x18039CC40")]
		public void MoveBy(Vector2 vector)
		{
		}

		// Token: 0x06001478 RID: 5240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001478")]
		[Address(RVA = "0x39CB60", Offset = "0x39BD60", VA = "0x18039CB60")]
		public void MoveByScreen(Vector2 vector)
		{
		}

		// Token: 0x06001479 RID: 5241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001479")]
		[Address(RVA = "0x39CCC0", Offset = "0x39BEC0", VA = "0x18039CCC0")]
		public void MoveTo(Vector2 vector)
		{
		}

		// Token: 0x0600147A RID: 5242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600147A")]
		[Address(RVA = "0x39CF30", Offset = "0x39C130", VA = "0x18039CF30")]
		public void Reload()
		{
		}

		// Token: 0x0600147B RID: 5243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600147B")]
		[Address(RVA = "0x39D080", Offset = "0x39C280", VA = "0x18039D080")]
		public void Reset(int width, int height)
		{
		}

		// Token: 0x0600147C RID: 5244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600147C")]
		[Address(RVA = "0x39E0D0", Offset = "0x39D2D0", VA = "0x18039E0D0")]
		public void SetAreaZone(int x, int y, ZonePointGroup zonePointGroup)
		{
		}

		// Token: 0x0600147D RID: 5245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600147D")]
		[Address(RVA = "0x39E190", Offset = "0x39D390", VA = "0x18039E190")]
		public void SetCeiling(int x, int y, ushort ceilingType)
		{
		}

		// Token: 0x0600147E RID: 5246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600147E")]
		[Address(RVA = "0x39E2E0", Offset = "0x39D4E0", VA = "0x18039E2E0")]
		public void SetDarkness(int x, int y, byte darkness)
		{
		}

		// Token: 0x0600147F RID: 5247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600147F")]
		[Address(RVA = "0x39E440", Offset = "0x39D640", VA = "0x18039E440")]
		public void SetGround(int x, int y, ushort groundType)
		{
		}

		// Token: 0x06001480 RID: 5248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001480")]
		[Address(RVA = "0x39E630", Offset = "0x39D830", VA = "0x18039E630")]
		public void SetObject(int x, int y, ushort objectType)
		{
		}

		// Token: 0x06001481 RID: 5249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001481")]
		[Address(RVA = "0x39E780", Offset = "0x39D980", VA = "0x18039E780")]
		public void SetOverride(int x, int y, IOverride @override)
		{
		}

		// Token: 0x06001482 RID: 5250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001482")]
		[Address(RVA = "0x39E840", Offset = "0x39DA40", VA = "0x18039E840")]
		public void SetRegion(int x, int y, ushort regionType)
		{
		}

		// Token: 0x06001483 RID: 5251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001483")]
		[Address(RVA = "0x39E930", Offset = "0x39DB30", VA = "0x18039E930")]
		public void SetSpawnZone(int x, int y, SpawnZone? spawnZone)
		{
		}

		// Token: 0x06001484 RID: 5252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001484")]
		[Address(RVA = "0x39EA10", Offset = "0x39DC10", VA = "0x18039EA10")]
		public void SetZone(int x, int y, ZonePointGroup zone)
		{
		}

		// Token: 0x06001485 RID: 5253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001485")]
		[Address(RVA = "0x39EE00", Offset = "0x39E000", VA = "0x18039EE00")]
		public void UpdateAreaZone(int x, int y)
		{
		}

		// Token: 0x06001486 RID: 5254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001486")]
		[Address(RVA = "0x39EE70", Offset = "0x39E070", VA = "0x18039EE70")]
		public void UpdateCeiling(int x, int y)
		{
		}

		// Token: 0x06001487 RID: 5255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001487")]
		[Address(RVA = "0x39EE90", Offset = "0x39E090", VA = "0x18039EE90")]
		public void UpdateDarkness(int x, int y)
		{
		}

		// Token: 0x06001488 RID: 5256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001488")]
		[Address(RVA = "0x39EEC0", Offset = "0x39E0C0", VA = "0x18039EEC0")]
		public void UpdateObject(int x, int y)
		{
		}

		// Token: 0x06001489 RID: 5257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001489")]
		[Address(RVA = "0x39EEE0", Offset = "0x39E0E0", VA = "0x18039EEE0")]
		public void UpdateOverride(int x, int y)
		{
		}

		// Token: 0x0600148A RID: 5258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600148A")]
		[Address(RVA = "0x39EF50", Offset = "0x39E150", VA = "0x18039EF50")]
		public void UpdateRegion(int x, int y)
		{
		}

		// Token: 0x0600148B RID: 5259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600148B")]
		[Address(RVA = "0x39EFC0", Offset = "0x39E1C0", VA = "0x18039EFC0")]
		public void UpdateSelection(bool enabled, RectInt rect)
		{
		}

		// Token: 0x0600148C RID: 5260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600148C")]
		[Address(RVA = "0x39F170", Offset = "0x39E370", VA = "0x18039F170")]
		public void UpdateSpawnZone(int x, int y)
		{
		}

		// Token: 0x0600148D RID: 5261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600148D")]
		[Address(RVA = "0x39F1E0", Offset = "0x39E3E0", VA = "0x18039F1E0")]
		public void UpdateTile(int x, int y)
		{
		}

		// Token: 0x0600148E RID: 5262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600148E")]
		[Address(RVA = "0x39F2B0", Offset = "0x39E4B0", VA = "0x18039F2B0")]
		public void UpdateZone(int x, int y)
		{
		}

		// Token: 0x0600148F RID: 5263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600148F")]
		[Address(RVA = "0x39F320", Offset = "0x39E520", VA = "0x18039F320")]
		public void Zoom(float delta, Vector2 screenAnchor)
		{
		}

		// Token: 0x06001490 RID: 5264 RVA: 0x000072F0 File Offset: 0x000054F0
		[Token(Token = "0x6001490")]
		[Address(RVA = "0x39CAE0", Offset = "0x39BCE0", VA = "0x18039CAE0")]
		private Vector2 GetWorldPosition(Vector2 screenPosition)
		{
			return default(Vector2);
		}

		// Token: 0x06001491 RID: 5265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001491")]
		[Address(RVA = "0x39EAD0", Offset = "0x39DCD0", VA = "0x18039EAD0")]
		private void SetZoom(float zoom)
		{
		}

		// Token: 0x06001492 RID: 5266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001492")]
		[Address(RVA = "0x39EB10", Offset = "0x39DD10", VA = "0x18039EB10")]
		private void Start()
		{
		}

		// Token: 0x06001493 RID: 5267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001493")]
		[Address(RVA = "0x39F470", Offset = "0x39E670", VA = "0x18039F470")]
		public MapEditorView()
		{
		}

		// Token: 0x0400107B RID: 4219
		[Token(Token = "0x400107B")]
		[FieldOffset(Offset = "0x20")]
		public Camera Camera;

		// Token: 0x0400107C RID: 4220
		[Token(Token = "0x400107C")]
		[FieldOffset(Offset = "0x28")]
		public float MinZoom;

		// Token: 0x0400107D RID: 4221
		[Token(Token = "0x400107D")]
		[FieldOffset(Offset = "0x2C")]
		public float MaxZoom;

		// Token: 0x0400107E RID: 4222
		[Token(Token = "0x400107E")]
		[FieldOffset(Offset = "0x30")]
		public float DefaultZoom;

		// Token: 0x0400107F RID: 4223
		[Token(Token = "0x400107F")]
		[FieldOffset(Offset = "0x38")]
		public MapEditorSelection Selection;

		// Token: 0x04001080 RID: 4224
		[Token(Token = "0x4001080")]
		[FieldOffset(Offset = "0x40")]
		private float _zoom;

		// Token: 0x04001081 RID: 4225
		[Token(Token = "0x4001081")]
		[FieldOffset(Offset = "0x44")]
		private int _width;

		// Token: 0x04001082 RID: 4226
		[Token(Token = "0x4001082")]
		[FieldOffset(Offset = "0x48")]
		private int _height;

		// Token: 0x04001083 RID: 4227
		[Token(Token = "0x4001083")]
		[FieldOffset(Offset = "0x50")]
		private TileMap _groundMap;

		// Token: 0x04001084 RID: 4228
		[Token(Token = "0x4001084")]
		[FieldOffset(Offset = "0x58")]
		private TileView _groundView;

		// Token: 0x04001085 RID: 4229
		[Token(Token = "0x4001085")]
		[FieldOffset(Offset = "0x60")]
		private TileMap _objectMap;

		// Token: 0x04001086 RID: 4230
		[Token(Token = "0x4001086")]
		[FieldOffset(Offset = "0x68")]
		private TileView _objectView;

		// Token: 0x04001087 RID: 4231
		[Token(Token = "0x4001087")]
		[FieldOffset(Offset = "0x70")]
		private TileMap _ceilingMap;

		// Token: 0x04001088 RID: 4232
		[Token(Token = "0x4001088")]
		[FieldOffset(Offset = "0x78")]
		private TileView _ceilingView;

		// Token: 0x04001089 RID: 4233
		[Token(Token = "0x4001089")]
		[FieldOffset(Offset = "0x80")]
		private TileMap _darknessMap;

		// Token: 0x0400108A RID: 4234
		[Token(Token = "0x400108A")]
		[FieldOffset(Offset = "0x88")]
		private DarknessView _darknessView;

		// Token: 0x0400108B RID: 4235
		[Token(Token = "0x400108B")]
		[FieldOffset(Offset = "0x90")]
		private Dictionary<Vector2Int, RegionType> _regionMap;

		// Token: 0x0400108C RID: 4236
		[Token(Token = "0x400108C")]
		[FieldOffset(Offset = "0x98")]
		private DictionaryView<RegionChunk, ushort, Region> _regionView;

		// Token: 0x0400108D RID: 4237
		[Token(Token = "0x400108D")]
		[FieldOffset(Offset = "0xA0")]
		private Dictionary<Vector2Int, IOverride> _overrideMap;

		// Token: 0x0400108E RID: 4238
		[Token(Token = "0x400108E")]
		[FieldOffset(Offset = "0xA8")]
		private DictionaryView<OverrideChunk, IOverride, Override> _overrideView;

		// Token: 0x0400108F RID: 4239
		[Token(Token = "0x400108F")]
		[FieldOffset(Offset = "0xB0")]
		private Dictionary<Vector2Int, SpawnZone?> _spawnZoneMap;

		// Token: 0x04001090 RID: 4240
		[Token(Token = "0x4001090")]
		[FieldOffset(Offset = "0xB8")]
		private DictionaryView<SpawnZoneChunk, SpawnZone?, SpawnZoneObj> _spawnZoneView;

		// Token: 0x04001091 RID: 4241
		[Token(Token = "0x4001091")]
		[FieldOffset(Offset = "0xC0")]
		private Dictionary<Vector2Int, ZonePointGroup> _zoneMap;

		// Token: 0x04001092 RID: 4242
		[Token(Token = "0x4001092")]
		[FieldOffset(Offset = "0xC8")]
		private DictionaryView<ZoneChunk, ZonePointGroup, ZonePointObj> _zoneView;

		// Token: 0x04001093 RID: 4243
		[Token(Token = "0x4001093")]
		[FieldOffset(Offset = "0xD0")]
		private Dictionary<Vector2Int, ZonePointGroup> _areaZoneMap;

		// Token: 0x04001094 RID: 4244
		[Token(Token = "0x4001094")]
		[FieldOffset(Offset = "0xD8")]
		private DictionaryView<ZoneChunk, ZonePointGroup, ZonePointObj> _areaZoneView;

		// Token: 0x04001095 RID: 4245
		[Token(Token = "0x4001095")]
		[FieldOffset(Offset = "0xE0")]
		private readonly List<ChunkView> _views;

		// Token: 0x04001096 RID: 4246
		[Token(Token = "0x4001096")]
		[FieldOffset(Offset = "0xE8")]
		private BlendView _blendView;
	}
}
