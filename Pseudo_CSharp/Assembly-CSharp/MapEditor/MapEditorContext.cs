using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Ronin.Model.Files.Map.Chunks;
using UnityEngine;

namespace MapEditor
{
	// Token: 0x02000377 RID: 887
	[Token(Token = "0x2000377")]
	public class MapEditorContext : MonoBehaviour
	{
		// Token: 0x1700020F RID: 527
		// (get) Token: 0x060013FA RID: 5114 RVA: 0x00007068 File Offset: 0x00005268
		[Token(Token = "0x1700020F")]
		public bool HasMap
		{
			[Token(Token = "0x60013FA")]
			[Address(RVA = "0x398F00", Offset = "0x398100", VA = "0x180398F00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x060013FB RID: 5115 RVA: 0x00007080 File Offset: 0x00005280
		[Token(Token = "0x17000210")]
		public RectInt Rect
		{
			[Token(Token = "0x60013FB")]
			[Address(RVA = "0x398F10", Offset = "0x398110", VA = "0x180398F10")]
			get
			{
				return default(RectInt);
			}
		}

		// Token: 0x060013FC RID: 5116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013FC")]
		[Address(RVA = "0x3945E0", Offset = "0x3937E0", VA = "0x1803945E0")]
		public void ClearChangeHistory()
		{
		}

		// Token: 0x060013FD RID: 5117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013FD")]
		[Address(RVA = "0x394660", Offset = "0x393860", VA = "0x180394660")]
		public void ClearSelection()
		{
		}

		// Token: 0x060013FE RID: 5118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013FE")]
		[Address(RVA = "0x394760", Offset = "0x393960", VA = "0x180394760")]
		public void CommitChanges()
		{
		}

		// Token: 0x060013FF RID: 5119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013FF")]
		[Address(RVA = "0x394BC0", Offset = "0x393DC0", VA = "0x180394BC0")]
		public void CutToScratch(RectInt rect)
		{
		}

		// Token: 0x06001400 RID: 5120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001400")]
		[Address(RVA = "0x394F80", Offset = "0x394180", VA = "0x180394F80")]
		public void DiscardChanges()
		{
		}

		// Token: 0x06001401 RID: 5121 RVA: 0x00007098 File Offset: 0x00005298
		[Token(Token = "0x6001401")]
		[Address(RVA = "0x395BA0", Offset = "0x394DA0", VA = "0x180395BA0")]
		public ushort? Get(MapObjectType type, int x, int y)
		{
			return null;
		}

		// Token: 0x06001402 RID: 5122 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001402")]
		public T Get<T>(MapObjectType type, int x, int y)
		{
			return null;
		}

		// Token: 0x06001403 RID: 5123 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001403")]
		public T GetWithoutScratch<T>(MapObjectType type, int x, int y)
		{
			return null;
		}

		// Token: 0x06001404 RID: 5124 RVA: 0x000070B0 File Offset: 0x000052B0
		[Token(Token = "0x6001404")]
		[Address(RVA = "0x395350", Offset = "0x394550", VA = "0x180395350")]
		public RectInt? GetBounds(MapObjectType type, RectInt rect)
		{
			return null;
		}

		// Token: 0x06001405 RID: 5125 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001405")]
		[Address(RVA = "0x395840", Offset = "0x394A40", VA = "0x180395840")]
		public MapRegion GetRegion(RectInt rect)
		{
			return null;
		}

		// Token: 0x06001406 RID: 5126 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001406")]
		[Address(RVA = "0x395750", Offset = "0x394950", VA = "0x180395750")]
		public object GetObject(MapObjectType type, int x, int y)
		{
			return null;
		}

		// Token: 0x06001407 RID: 5127 RVA: 0x000070C8 File Offset: 0x000052C8
		[Token(Token = "0x6001407")]
		[Address(RVA = "0x395B50", Offset = "0x394D50", VA = "0x180395B50")]
		public ushort? GetSelected(int x, int y)
		{
			return null;
		}

		// Token: 0x06001408 RID: 5128 RVA: 0x000070E0 File Offset: 0x000052E0
		[Token(Token = "0x6001408")]
		[Address(RVA = "0x395B80", Offset = "0x394D80", VA = "0x180395B80")]
		public RectInt? GetSelection()
		{
			return null;
		}

		// Token: 0x06001409 RID: 5129 RVA: 0x000070F8 File Offset: 0x000052F8
		[Token(Token = "0x6001409")]
		[Address(RVA = "0x395CA0", Offset = "0x394EA0", VA = "0x180395CA0")]
		public bool HasScratch()
		{
			return default(bool);
		}

		// Token: 0x0600140A RID: 5130 RVA: 0x00007110 File Offset: 0x00005310
		[Token(Token = "0x600140A")]
		[Address(RVA = "0x395CE0", Offset = "0x394EE0", VA = "0x180395CE0")]
		public bool InGrid(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x0600140B RID: 5131 RVA: 0x00007128 File Offset: 0x00005328
		[Token(Token = "0x600140B")]
		[Address(RVA = "0x395D10", Offset = "0x394F10", VA = "0x180395D10")]
		public bool InSelection(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x0600140C RID: 5132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600140C")]
		[Address(RVA = "0x395DD0", Offset = "0x394FD0", VA = "0x180395DD0")]
		public void MoveScratch(Vector2Int target)
		{
		}

		// Token: 0x0600140D RID: 5133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600140D")]
		[Address(RVA = "0x396230", Offset = "0x395430", VA = "0x180396230")]
		public void New(int width, int height)
		{
		}

		// Token: 0x0600140E RID: 5134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600140E")]
		[Address(RVA = "0x3968D0", Offset = "0x395AD0", VA = "0x1803968D0")]
		public void RedoChange()
		{
		}

		// Token: 0x0600140F RID: 5135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600140F")]
		[Address(RVA = "0x396970", Offset = "0x395B70", VA = "0x180396970")]
		public void Resize(int newWidth, int newHeight, Vector2 anchor)
		{
		}

		// Token: 0x06001410 RID: 5136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001410")]
		[Address(RVA = "0x3970A0", Offset = "0x3962A0", VA = "0x1803970A0")]
		public void RevertChange()
		{
		}

		// Token: 0x06001411 RID: 5137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001411")]
		[Address(RVA = "0x3977E0", Offset = "0x3969E0", VA = "0x1803977E0")]
		public void Set(MapObjectType type, int x, int y, ushort? value)
		{
		}

		// Token: 0x06001412 RID: 5138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001412")]
		public void Set<T>(MapObjectType type, int x, int y, T value)
		{
		}

		// Token: 0x06001413 RID: 5139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001413")]
		[Address(RVA = "0x3973D0", Offset = "0x3965D0", VA = "0x1803973D0")]
		public void SetRegion(MapRegion region)
		{
		}

		// Token: 0x06001414 RID: 5140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001414")]
		[Address(RVA = "0x397120", Offset = "0x396320", VA = "0x180397120")]
		public void SetRegionValues(MapRegion region)
		{
		}

		// Token: 0x06001415 RID: 5141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001415")]
		[Address(RVA = "0x3976C0", Offset = "0x3968C0", VA = "0x1803976C0")]
		public void SetSelected(int x, int y, ushort? value)
		{
		}

		// Token: 0x06001416 RID: 5142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001416")]
		[Address(RVA = "0x397700", Offset = "0x396900", VA = "0x180397700")]
		public void SetSelection(RectInt rect)
		{
		}

		// Token: 0x06001417 RID: 5143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001417")]
		[Address(RVA = "0x394540", Offset = "0x393740", VA = "0x180394540")]
		private void Awake()
		{
		}

		// Token: 0x06001418 RID: 5144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001418")]
		[Address(RVA = "0x395220", Offset = "0x394420", VA = "0x180395220")]
		private void ExpandScratch(int x, int y)
		{
		}

		// Token: 0x06001419 RID: 5145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001419")]
		[Address(RVA = "0x3963C0", Offset = "0x3955C0", VA = "0x1803963C0")]
		private void PushChange(MapRegion before, MapRegion after)
		{
		}

		// Token: 0x0600141A RID: 5146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600141A")]
		[Address(RVA = "0x396570", Offset = "0x395770", VA = "0x180396570")]
		private void PushFloatingChange(MapRegion before, MapRegion after)
		{
		}

		// Token: 0x0600141B RID: 5147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600141B")]
		[Address(RVA = "0x396650", Offset = "0x395850", VA = "0x180396650")]
		private void RedoChange(MapEditorContext.MapChange change)
		{
		}

		// Token: 0x0600141C RID: 5148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600141C")]
		[Address(RVA = "0x396E20", Offset = "0x396020", VA = "0x180396E20")]
		private void RevertChange(MapEditorContext.MapChange change)
		{
		}

		// Token: 0x0600141D RID: 5149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600141D")]
		[Address(RVA = "0x397950", Offset = "0x396B50", VA = "0x180397950")]
		private void Setup()
		{
		}

		// Token: 0x0600141E RID: 5150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600141E")]
		[Address(RVA = "0x397950", Offset = "0x396B50", VA = "0x180397950")]
		private void Start()
		{
		}

		// Token: 0x0600141F RID: 5151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600141F")]
		[Address(RVA = "0x398970", Offset = "0x397B70", VA = "0x180398970")]
		private void UpdateView(Vector2Int coordinates)
		{
		}

		// Token: 0x06001420 RID: 5152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001420")]
		[Address(RVA = "0x3985B0", Offset = "0x3977B0", VA = "0x1803985B0")]
		private void UpdateView(Vector2Int coordinates, MapObjectType type)
		{
		}

		// Token: 0x06001421 RID: 5153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001421")]
		[Address(RVA = "0x397A00", Offset = "0x396C00", VA = "0x180397A00")]
		private void UpdateViewWithScratch(Vector2Int coordinates)
		{
		}

		// Token: 0x06001422 RID: 5154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001422")]
		[Address(RVA = "0x397FB0", Offset = "0x3971B0", VA = "0x180397FB0")]
		private void UpdateViewWithScratch(Vector2Int coordinates, MapObjectType type)
		{
		}

		// Token: 0x06001423 RID: 5155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001423")]
		[Address(RVA = "0x398DD0", Offset = "0x397FD0", VA = "0x180398DD0")]
		public MapEditorContext()
		{
		}

		// Token: 0x0400103A RID: 4154
		[Token(Token = "0x400103A")]
		[FieldOffset(Offset = "0x20")]
		public MapInfoChunk MapInfo;

		// Token: 0x0400103B RID: 4155
		[Token(Token = "0x400103B")]
		[FieldOffset(Offset = "0x28")]
		public MapEditorPalette Palette;

		// Token: 0x0400103C RID: 4156
		[Token(Token = "0x400103C")]
		[FieldOffset(Offset = "0x30")]
		public MapEditorView View;

		// Token: 0x0400103D RID: 4157
		[Token(Token = "0x400103D")]
		[FieldOffset(Offset = "0x38")]
		public MapEditorIndicatorBar IndicatorBar;

		// Token: 0x0400103E RID: 4158
		[Token(Token = "0x400103E")]
		[FieldOffset(Offset = "0x40")]
		public OverrideMenu OverrideMenu;

		// Token: 0x0400103F RID: 4159
		[Token(Token = "0x400103F")]
		[FieldOffset(Offset = "0x48")]
		public SpawnZoneMenu SpawnZoneMenu;

		// Token: 0x04001040 RID: 4160
		[Token(Token = "0x4001040")]
		[FieldOffset(Offset = "0x50")]
		public ZoneMenu ZoneMenu;

		// Token: 0x04001041 RID: 4161
		[Token(Token = "0x4001041")]
		[FieldOffset(Offset = "0x58")]
		public ZonePointMenu ZonePointsMenu;

		// Token: 0x04001042 RID: 4162
		[Token(Token = "0x4001042")]
		[FieldOffset(Offset = "0x60")]
		public string LoadedFilePath;

		// Token: 0x04001043 RID: 4163
		[Token(Token = "0x4001043")]
		[FieldOffset(Offset = "0x68")]
		public bool Edited;

		// Token: 0x04001044 RID: 4164
		[Token(Token = "0x4001044")]
		[FieldOffset(Offset = "0x70")]
		private MapRegion _mapData;

		// Token: 0x04001045 RID: 4165
		[Token(Token = "0x4001045")]
		[FieldOffset(Offset = "0x78")]
		private MapRegion _scratch;

		// Token: 0x04001046 RID: 4166
		[Token(Token = "0x4001046")]
		[FieldOffset(Offset = "0x80")]
		private RectInt? _scratchRect;

		// Token: 0x04001047 RID: 4167
		[Token(Token = "0x4001047")]
		[FieldOffset(Offset = "0x94")]
		private RectInt? _selection;

		// Token: 0x04001048 RID: 4168
		[Token(Token = "0x4001048")]
		[FieldOffset(Offset = "0xA8")]
		private int _changeIndex;

		// Token: 0x04001049 RID: 4169
		[Token(Token = "0x4001049")]
		[FieldOffset(Offset = "0xB0")]
		private readonly List<MapEditorContext.MapChange> _changeList;

		// Token: 0x0400104A RID: 4170
		[Token(Token = "0x400104A")]
		[FieldOffset(Offset = "0xB8")]
		private readonly DarknessTexture _darknessTexture;

		// Token: 0x0400104B RID: 4171
		[Token(Token = "0x400104B")]
		[FieldOffset(Offset = "0xC0")]
		private MapEditorContext.MapChange _floatingChange;

		// Token: 0x02000378 RID: 888
		[Token(Token = "0x2000378")]
		private class MapChange
		{
			// Token: 0x17000211 RID: 529
			// (get) Token: 0x06001424 RID: 5156 RVA: 0x0000206A File Offset: 0x0000026A
			// (set) Token: 0x06001425 RID: 5157 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000211")]
			public MapRegion Before
			{
				[Token(Token = "0x6001424")]
				[Address(RVA = "0x3328E0", Offset = "0x331AE0", VA = "0x1803328E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6001425")]
				[Address(RVA = "0x334510", Offset = "0x333710", VA = "0x180334510")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000212 RID: 530
			// (get) Token: 0x06001426 RID: 5158 RVA: 0x0000206A File Offset: 0x0000026A
			// (set) Token: 0x06001427 RID: 5159 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000212")]
			public MapRegion After
			{
				[Token(Token = "0x6001426")]
				[Address(RVA = "0x32A4B0", Offset = "0x3296B0", VA = "0x18032A4B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6001427")]
				[Address(RVA = "0x394510", Offset = "0x393710", VA = "0x180394510")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000213 RID: 531
			// (get) Token: 0x06001428 RID: 5160 RVA: 0x00007140 File Offset: 0x00005340
			// (set) Token: 0x06001429 RID: 5161 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000213")]
			public RectInt? Selection
			{
				[Token(Token = "0x6001428")]
				[Address(RVA = "0x3944F0", Offset = "0x3936F0", VA = "0x1803944F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6001429")]
				[Address(RVA = "0x394530", Offset = "0x393730", VA = "0x180394530")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000214 RID: 532
			// (get) Token: 0x0600142A RID: 5162 RVA: 0x0000206A File Offset: 0x0000026A
			// (set) Token: 0x0600142B RID: 5163 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000214")]
			public MapEditorContext.MapChange Link
			{
				[Token(Token = "0x600142A")]
				[Address(RVA = "0x3944E0", Offset = "0x3936E0", VA = "0x1803944E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600142B")]
				[Address(RVA = "0x394520", Offset = "0x393720", VA = "0x180394520")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x0600142C RID: 5164 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600142C")]
			[Address(RVA = "0x316100", Offset = "0x315300", VA = "0x180316100")]
			public MapChange()
			{
			}
		}
	}
}
