using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace MapEditor
{
	// Token: 0x02000385 RID: 901
	[Token(Token = "0x2000385")]
	public class MapRegion
	{
		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06001499 RID: 5273 RVA: 0x00007338 File Offset: 0x00005538
		// (set) Token: 0x0600149A RID: 5274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000221")]
		public RectInt Rect
		{
			[Token(Token = "0x6001499")]
			[Address(RVA = "0x3A13E0", Offset = "0x3A05E0", VA = "0x1803A13E0")]
			[CompilerGenerated]
			get
			{
				return default(RectInt);
			}
			[Token(Token = "0x600149A")]
			[Address(RVA = "0x3A13F0", Offset = "0x3A05F0", VA = "0x1803A13F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600149B RID: 5275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600149B")]
		[Address(RVA = "0x3A1320", Offset = "0x3A0520", VA = "0x1803A1320")]
		public MapRegion(RectInt rect)
		{
		}

		// Token: 0x0600149C RID: 5276 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600149C")]
		public T Get<T>(MapObjectType type, Vector2Int coordinate)
		{
			return null;
		}

		// Token: 0x0600149D RID: 5277 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600149D")]
		public T Get<T>(MapObjectType type, int x, int y)
		{
			return null;
		}

		// Token: 0x0600149E RID: 5278 RVA: 0x00007350 File Offset: 0x00005550
		[Token(Token = "0x600149E")]
		[Address(RVA = "0x3A0CB0", Offset = "0x39FEB0", VA = "0x1803A0CB0")]
		public ushort? Get(MapObjectType type, Vector2Int coordinate)
		{
			return null;
		}

		// Token: 0x0600149F RID: 5279 RVA: 0x00007368 File Offset: 0x00005568
		[Token(Token = "0x600149F")]
		[Address(RVA = "0x3A0BB0", Offset = "0x39FDB0", VA = "0x1803A0BB0")]
		public ushort? Get(MapObjectType type, int x, int y)
		{
			return null;
		}

		// Token: 0x060014A0 RID: 5280 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60014A0")]
		[Address(RVA = "0x3A0A50", Offset = "0x39FC50", VA = "0x1803A0A50")]
		public object GetObject(MapObjectType type, Vector2Int coordinate)
		{
			return null;
		}

		// Token: 0x060014A1 RID: 5281 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60014A1")]
		[Address(RVA = "0x3A0970", Offset = "0x39FB70", VA = "0x1803A0970")]
		public object GetObject(MapObjectType type, int x, int y)
		{
			return null;
		}

		// Token: 0x060014A2 RID: 5282 RVA: 0x00007380 File Offset: 0x00005580
		[Token(Token = "0x60014A2")]
		[Address(RVA = "0x3A0A70", Offset = "0x39FC70", VA = "0x1803A0A70")]
		public MapRegion.Option<object> GetOption(MapObjectType type, Vector2Int coordinate)
		{
			return default(MapRegion.Option<object>);
		}

		// Token: 0x060014A3 RID: 5283 RVA: 0x00007398 File Offset: 0x00005598
		[Token(Token = "0x60014A3")]
		[Address(RVA = "0x3A0AB0", Offset = "0x39FCB0", VA = "0x1803A0AB0")]
		public MapRegion.Option<object> GetOption(MapObjectType type, int x, int y)
		{
			return default(MapRegion.Option<object>);
		}

		// Token: 0x060014A4 RID: 5284 RVA: 0x000073B0 File Offset: 0x000055B0
		[Token(Token = "0x60014A4")]
		public MapRegion.Option<T> GetOption<T>(MapObjectType type, Vector2Int coordinate)
		{
			return default(MapRegion.Option<!!0>);
		}

		// Token: 0x060014A5 RID: 5285 RVA: 0x000073C8 File Offset: 0x000055C8
		[Token(Token = "0x60014A5")]
		public MapRegion.Option<T> GetOption<T>(MapObjectType type, int x, int y)
		{
			return default(MapRegion.Option<!!0>);
		}

		// Token: 0x060014A6 RID: 5286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014A6")]
		[Address(RVA = "0x3A0CD0", Offset = "0x39FED0", VA = "0x1803A0CD0")]
		public void MoveTo(Vector2Int position)
		{
		}

		// Token: 0x060014A7 RID: 5287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014A7")]
		[Address(RVA = "0x3A0DF0", Offset = "0x39FFF0", VA = "0x1803A0DF0")]
		public void Remove(Vector2Int coordinate)
		{
		}

		// Token: 0x060014A8 RID: 5288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014A8")]
		[Address(RVA = "0x3A0D00", Offset = "0x39FF00", VA = "0x1803A0D00")]
		public void Remove(int x, int y)
		{
		}

		// Token: 0x060014A9 RID: 5289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014A9")]
		[Address(RVA = "0x3A1110", Offset = "0x3A0310", VA = "0x1803A1110")]
		public void Set(MapObjectType type, int x, int y, object obj)
		{
		}

		// Token: 0x060014AA RID: 5290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014AA")]
		[Address(RVA = "0x3A1240", Offset = "0x3A0440", VA = "0x1803A1240")]
		public void Set(MapObjectType type, int x, int y, ushort? value)
		{
		}

		// Token: 0x060014AB RID: 5291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014AB")]
		[Address(RVA = "0x3A10E0", Offset = "0x3A02E0", VA = "0x1803A10E0")]
		public void SetObject(MapObjectType type, Vector2Int coordinates, object value)
		{
		}

		// Token: 0x060014AC RID: 5292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014AC")]
		[Address(RVA = "0x3A0EF0", Offset = "0x3A00F0", VA = "0x1803A0EF0")]
		public void SetObject(MapObjectType type, int x, int y, object value)
		{
		}

		// Token: 0x040010A3 RID: 4259
		[Token(Token = "0x40010A3")]
		[FieldOffset(Offset = "0x10")]
		private readonly ushort?[,,] _perUnit;

		// Token: 0x040010A4 RID: 4260
		[Token(Token = "0x40010A4")]
		[FieldOffset(Offset = "0x18")]
		private readonly Dictionary<Vector2Int, object>[] _dictionaries;

		// Token: 0x02000386 RID: 902
		[Token(Token = "0x2000386")]
		public struct Option<T>
		{
			// Token: 0x060014AD RID: 5293 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60014AD")]
			public Option(bool defined, T value)
			{
			}

			// Token: 0x17000222 RID: 546
			// (get) Token: 0x060014AE RID: 5294 RVA: 0x000073E0 File Offset: 0x000055E0
			// (set) Token: 0x060014AF RID: 5295 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000222")]
			public bool Defined
			{
				[Token(Token = "0x60014AE")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60014AF")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000223 RID: 547
			// (get) Token: 0x060014B0 RID: 5296 RVA: 0x0000206A File Offset: 0x0000026A
			// (set) Token: 0x060014B1 RID: 5297 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000223")]
			public T Value
			{
				[Token(Token = "0x60014B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60014B1")]
				[CompilerGenerated]
				private set
				{
				}
			}
		}
	}
}
