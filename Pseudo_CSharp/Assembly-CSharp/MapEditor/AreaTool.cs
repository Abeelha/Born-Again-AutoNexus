using System;
using Il2CppDummyDll;
using UnityEngine;

namespace MapEditor
{
	// Token: 0x02000397 RID: 919
	[Token(Token = "0x2000397")]
	public abstract class AreaTool<T> : MapEditorTool
	{
		// Token: 0x06001502 RID: 5378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001502")]
		public override void Begin(Vector2 coordinates, MapEditorContext context)
		{
		}

		// Token: 0x06001503 RID: 5379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001503")]
		public override void End(Vector2 coordinates, MapEditorContext context)
		{
		}

		// Token: 0x06001504 RID: 5380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001504")]
		public override void Update(Vector2 coordinates, MapEditorContext context)
		{
		}

		// Token: 0x06001505 RID: 5381
		[Token(Token = "0x6001505")]
		protected abstract T Create(int width, int height, MapEditorContext context);

		// Token: 0x06001506 RID: 5382
		[Token(Token = "0x6001506")]
		protected abstract T Get(int x, int y, MapEditorContext context);

		// Token: 0x06001507 RID: 5383
		[Token(Token = "0x6001507")]
		protected abstract RectInt GetRect(Vector2Int coordinates, T value, MapEditorContext context);

		// Token: 0x06001508 RID: 5384
		[Token(Token = "0x6001508")]
		protected abstract T Resize(Vector2Int newSize, T value, MapEditorContext context);

		// Token: 0x06001509 RID: 5385
		[Token(Token = "0x6001509")]
		protected abstract void Select(Vector2Int coordinates, T value, MapEditorContext context);

		// Token: 0x0600150A RID: 5386
		[Token(Token = "0x600150A")]
		protected abstract void Set(int x, int y, T value, MapEditorContext context);

		// Token: 0x0600150B RID: 5387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600150B")]
		protected AreaTool()
		{
		}

		// Token: 0x040010E7 RID: 4327
		[Token(Token = "0x40010E7")]
		[FieldOffset(Offset = "0x0")]
		private static readonly RectInt s_areaSearch;

		// Token: 0x040010E8 RID: 4328
		[Token(Token = "0x40010E8")]
		[FieldOffset(Offset = "0x0")]
		private Vector2Int? _beginCoordinates;

		// Token: 0x040010E9 RID: 4329
		[Token(Token = "0x40010E9")]
		[FieldOffset(Offset = "0x0")]
		private Vector2Int _targetedSpawnZone;

		// Token: 0x040010EA RID: 4330
		[Token(Token = "0x40010EA")]
		[FieldOffset(Offset = "0x0")]
		private AreaTool<T>.RectQuadrant _quadrant;

		// Token: 0x040010EB RID: 4331
		[Token(Token = "0x40010EB")]
		[FieldOffset(Offset = "0x0")]
		private RectInt _indicatorRect;

		// Token: 0x02000398 RID: 920
		[Token(Token = "0x2000398")]
		private enum RectQuadrant
		{
			// Token: 0x040010ED RID: 4333
			[Token(Token = "0x40010ED")]
			BottomLeft,
			// Token: 0x040010EE RID: 4334
			[Token(Token = "0x40010EE")]
			BottomRight,
			// Token: 0x040010EF RID: 4335
			[Token(Token = "0x40010EF")]
			TopLeft,
			// Token: 0x040010F0 RID: 4336
			[Token(Token = "0x40010F0")]
			TopRight
		}
	}
}
