using System;
using Il2CppDummyDll;
using UnityEngine;

namespace MapEditor
{
	// Token: 0x020003AB RID: 939
	[Token(Token = "0x20003AB")]
	public class TileTool : MapEditorTool
	{
		// Token: 0x0600158B RID: 5515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600158B")]
		[Address(RVA = "0x3B9A70", Offset = "0x3B8C70", VA = "0x1803B9A70", Slot = "4")]
		public override void Begin(Vector2 coordinates, MapEditorContext context)
		{
		}

		// Token: 0x0600158C RID: 5516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600158C")]
		[Address(RVA = "0x392E60", Offset = "0x392060", VA = "0x180392E60", Slot = "5")]
		public override void Cancel(MapEditorContext context)
		{
		}

		// Token: 0x0600158D RID: 5517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600158D")]
		[Address(RVA = "0x3B88E0", Offset = "0x3B7AE0", VA = "0x1803B88E0", Slot = "8")]
		public override void End(Vector2 coordinates, MapEditorContext context)
		{
		}

		// Token: 0x0600158E RID: 5518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600158E")]
		[Address(RVA = "0x3B9A70", Offset = "0x3B8C70", VA = "0x1803B9A70", Slot = "10")]
		public override void Update(Vector2 coordinates, MapEditorContext context)
		{
		}

		// Token: 0x0600158F RID: 5519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600158F")]
		[Address(RVA = "0x3B9A80", Offset = "0x3B8C80", VA = "0x1803B9A80")]
		private void Draw(Vector2 coordinates, MapEditorContext context)
		{
		}

		// Token: 0x06001590 RID: 5520 RVA: 0x00007758 File Offset: 0x00005958
		[Token(Token = "0x6001590")]
		[Address(RVA = "0x3B9D00", Offset = "0x3B8F00", VA = "0x1803B9D00")]
		private bool IsGridLocked()
		{
			return default(bool);
		}

		// Token: 0x06001591 RID: 5521 RVA: 0x00007770 File Offset: 0x00005970
		[Token(Token = "0x6001591")]
		[Address(RVA = "0x3B9D30", Offset = "0x3B8F30", VA = "0x1803B9D30")]
		private int Mod(int x, int m)
		{
			return 0;
		}

		// Token: 0x06001592 RID: 5522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001592")]
		[Address(RVA = "0x3B0F60", Offset = "0x3B0160", VA = "0x1803B0F60")]
		public TileTool()
		{
		}

		// Token: 0x0400111A RID: 4378
		[Token(Token = "0x400111A")]
		[FieldOffset(Offset = "0x18")]
		private Vector2Int? _last;
	}
}
