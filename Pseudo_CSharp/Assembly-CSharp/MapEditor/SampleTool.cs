using System;
using Il2CppDummyDll;
using UnityEngine;

namespace MapEditor
{
	// Token: 0x020003A5 RID: 933
	[Token(Token = "0x20003A5")]
	public class SampleTool : MapEditorTool
	{
		// Token: 0x06001563 RID: 5475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001563")]
		[Address(RVA = "0x3B7480", Offset = "0x3B6680", VA = "0x1803B7480", Slot = "4")]
		public override void Begin(Vector2 coordinates, MapEditorContext context)
		{
		}

		// Token: 0x06001564 RID: 5476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001564")]
		[Address(RVA = "0x3B7480", Offset = "0x3B6680", VA = "0x1803B7480", Slot = "10")]
		public override void Update(Vector2 coordinates, MapEditorContext context)
		{
		}

		// Token: 0x06001565 RID: 5477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001565")]
		[Address(RVA = "0x3B7810", Offset = "0x3B6A10", VA = "0x1803B7810", Slot = "11")]
		public override void UpdateInactive(Vector2 coordinates, MapEditorContext context)
		{
		}

		// Token: 0x06001566 RID: 5478 RVA: 0x00007668 File Offset: 0x00005868
		[Token(Token = "0x6001566")]
		[Address(RVA = "0x3B74D0", Offset = "0x3B66D0", VA = "0x1803B74D0")]
		private ValueTuple<ushort?, MapObjectType> GetTypeAt(Vector2 coordinates, MapEditorContext context)
		{
			return default(ValueTuple<ushort?, MapObjectType>);
		}

		// Token: 0x06001567 RID: 5479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001567")]
		[Address(RVA = "0x3B7760", Offset = "0x3B6960", VA = "0x1803B7760")]
		private void Sample(Vector2 coordinates, MapEditorContext context)
		{
		}

		// Token: 0x06001568 RID: 5480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001568")]
		[Address(RVA = "0x3B7820", Offset = "0x3B6A20", VA = "0x1803B7820")]
		private void UpdateLabel(Vector2 coordinates, MapEditorContext context)
		{
		}

		// Token: 0x06001569 RID: 5481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001569")]
		[Address(RVA = "0x3B0F60", Offset = "0x3B0160", VA = "0x1803B0F60")]
		public SampleTool()
		{
		}
	}
}
