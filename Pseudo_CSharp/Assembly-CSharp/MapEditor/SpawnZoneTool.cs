using System;
using Il2CppDummyDll;
using Ronin.Model.Structs;
using UnityEngine;

namespace MapEditor
{
	// Token: 0x020003A7 RID: 935
	[Token(Token = "0x20003A7")]
	public class SpawnZoneTool : AreaTool<SpawnZone?>
	{
		// Token: 0x06001571 RID: 5489 RVA: 0x00007698 File Offset: 0x00005898
		[Token(Token = "0x6001571")]
		[Address(RVA = "0x3B89B0", Offset = "0x3B7BB0", VA = "0x1803B89B0", Slot = "12")]
		protected override SpawnZone? Create(int width, int height, MapEditorContext context)
		{
			return null;
		}

		// Token: 0x06001572 RID: 5490 RVA: 0x000076B0 File Offset: 0x000058B0
		[Token(Token = "0x6001572")]
		[Address(RVA = "0x3B8AF0", Offset = "0x3B7CF0", VA = "0x1803B8AF0", Slot = "13")]
		protected override SpawnZone? Get(int x, int y, MapEditorContext context)
		{
			return null;
		}

		// Token: 0x06001573 RID: 5491 RVA: 0x000076C8 File Offset: 0x000058C8
		[Token(Token = "0x6001573")]
		[Address(RVA = "0x3B8A50", Offset = "0x3B7C50", VA = "0x1803B8A50", Slot = "14")]
		protected override RectInt GetRect(Vector2Int coordinates, SpawnZone? value, MapEditorContext context)
		{
			return default(RectInt);
		}

		// Token: 0x06001574 RID: 5492 RVA: 0x000076E0 File Offset: 0x000058E0
		[Token(Token = "0x6001574")]
		[Address(RVA = "0x3B8B90", Offset = "0x3B7D90", VA = "0x1803B8B90", Slot = "15")]
		protected override SpawnZone? Resize(Vector2Int newSize, SpawnZone? value, MapEditorContext context)
		{
			return null;
		}

		// Token: 0x06001575 RID: 5493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001575")]
		[Address(RVA = "0x3B8D10", Offset = "0x3B7F10", VA = "0x1803B8D10", Slot = "16")]
		protected override void Select(Vector2Int coordinates, SpawnZone? value, MapEditorContext context)
		{
		}

		// Token: 0x06001576 RID: 5494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001576")]
		[Address(RVA = "0x3B8D60", Offset = "0x3B7F60", VA = "0x1803B8D60", Slot = "17")]
		protected override void Set(int x, int y, SpawnZone? value, MapEditorContext context)
		{
		}

		// Token: 0x06001577 RID: 5495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001577")]
		[Address(RVA = "0x3B8E00", Offset = "0x3B8000", VA = "0x1803B8E00", Slot = "11")]
		public override void UpdateInactive(Vector2 coordinates, MapEditorContext context)
		{
		}

		// Token: 0x06001578 RID: 5496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001578")]
		[Address(RVA = "0x3B8E40", Offset = "0x3B8040", VA = "0x1803B8E40")]
		public SpawnZoneTool()
		{
		}
	}
}
