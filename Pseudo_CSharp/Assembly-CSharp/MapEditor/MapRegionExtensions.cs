using System;
using Il2CppDummyDll;
using UnityEngine;

namespace MapEditor
{
	// Token: 0x02000387 RID: 903
	[Token(Token = "0x2000387")]
	public static class MapRegionExtensions
	{
		// Token: 0x060014B2 RID: 5298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014B2")]
		[Address(RVA = "0x39FFC0", Offset = "0x39F1C0", VA = "0x18039FFC0")]
		public static void ApplyRegion(this MapRegion mapRegion, MapRegion region, RectInt subRect)
		{
		}

		// Token: 0x060014B3 RID: 5299 RVA: 0x000073F8 File Offset: 0x000055F8
		[Token(Token = "0x60014B3")]
		[Address(RVA = "0x3A0230", Offset = "0x39F430", VA = "0x1803A0230")]
		public static bool Contains(this MapRegion mapRegion, Vector2Int coordinates)
		{
			return default(bool);
		}

		// Token: 0x060014B4 RID: 5300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014B4")]
		[Address(RVA = "0x3A0340", Offset = "0x39F540", VA = "0x1803A0340")]
		public static void CopyTo(this MapRegion mapRegion, Vector2Int sourceCoordinates, MapRegion target, Vector2Int targetCoordinates)
		{
		}

		// Token: 0x060014B5 RID: 5301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014B5")]
		[Address(RVA = "0x3A03E0", Offset = "0x39F5E0", VA = "0x1803A03E0")]
		public static void CopyValuesTo(this MapRegion mapRegion, Vector2Int sourceCoordinates, MapRegion target, Vector2Int targetCoordinates)
		{
		}

		// Token: 0x060014B6 RID: 5302 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60014B6")]
		[Address(RVA = "0x3A04D0", Offset = "0x39F6D0", VA = "0x1803A04D0")]
		public static MapRegion Extract(this MapRegion mapRegion, RectInt rect)
		{
			return null;
		}

		// Token: 0x060014B7 RID: 5303 RVA: 0x00007410 File Offset: 0x00005610
		[Token(Token = "0x60014B7")]
		[Address(RVA = "0x3A07B0", Offset = "0x39F9B0", VA = "0x1803A07B0")]
		public static bool IsEqual(this MapRegion mapRegion, MapObjectType type, int x, int y, ushort? value)
		{
			return default(bool);
		}

		// Token: 0x060014B8 RID: 5304 RVA: 0x00007428 File Offset: 0x00005628
		[Token(Token = "0x60014B8")]
		public static bool IsEqual<T>(this MapRegion mapRegion, MapObjectType objectType, int x, int y, T obj)
		{
			return default(bool);
		}
	}
}
