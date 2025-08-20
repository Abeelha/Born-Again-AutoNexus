using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace MapEditor
{
	// Token: 0x02000370 RID: 880
	[Token(Token = "0x2000370")]
	public abstract class DictionaryChunk<TType, TMonoBehaviour> : IChunk where TMonoBehaviour : MonoBehaviour
	{
		// Token: 0x17000206 RID: 518
		// (get) Token: 0x060013CF RID: 5071 RVA: 0x00006F60 File Offset: 0x00005160
		// (set) Token: 0x060013D0 RID: 5072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000206")]
		public Vector2Int Index
		{
			[Token(Token = "0x60013CF")]
			[CompilerGenerated]
			get
			{
				return default(Vector2Int);
			}
			[Token(Token = "0x60013D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x060013D1 RID: 5073 RVA: 0x00006F78 File Offset: 0x00005178
		// (set) Token: 0x060013D2 RID: 5074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000207")]
		public Vector2Int Position
		{
			[Token(Token = "0x60013D1")]
			[CompilerGenerated]
			get
			{
				return default(Vector2Int);
			}
			[Token(Token = "0x60013D2")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x060013D3 RID: 5075 RVA: 0x00006F90 File Offset: 0x00005190
		// (set) Token: 0x060013D4 RID: 5076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000208")]
		public Vector2Int Size
		{
			[Token(Token = "0x60013D3")]
			[CompilerGenerated]
			get
			{
				return default(Vector2Int);
			}
			[Token(Token = "0x60013D4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x060013D5 RID: 5077 RVA: 0x00006FA8 File Offset: 0x000051A8
		// (set) Token: 0x060013D6 RID: 5078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000209")]
		public Vector2Int Zone
		{
			[Token(Token = "0x60013D5")]
			[CompilerGenerated]
			get
			{
				return default(Vector2Int);
			}
			[Token(Token = "0x60013D6")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060013D7 RID: 5079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013D7")]
		public void Create(Vector2Int size)
		{
		}

		// Token: 0x060013D8 RID: 5080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013D8")]
		public void Set(Vector2Int relativeCoord, TType type)
		{
		}

		// Token: 0x060013D9 RID: 5081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013D9")]
		public void SetActive(bool active)
		{
		}

		// Token: 0x060013DA RID: 5082
		[Token(Token = "0x60013DA")]
		protected abstract bool HasValue(TType type);

		// Token: 0x060013DB RID: 5083
		[Token(Token = "0x60013DB")]
		protected abstract void Setup(TMonoBehaviour obj, TType type, Vector2Int coordinates);

		// Token: 0x060013DC RID: 5084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013DC")]
		protected DictionaryChunk()
		{
		}

		// Token: 0x0400102E RID: 4142
		[Token(Token = "0x400102E")]
		[FieldOffset(Offset = "0x0")]
		private readonly Dictionary<Vector2Int, TMonoBehaviour> _objects;

		// Token: 0x0400102F RID: 4143
		[Token(Token = "0x400102F")]
		[FieldOffset(Offset = "0x0")]
		private bool _active;
	}
}
