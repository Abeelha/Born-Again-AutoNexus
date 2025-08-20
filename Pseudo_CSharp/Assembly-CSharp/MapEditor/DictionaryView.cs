using System;
using Il2CppDummyDll;
using UnityEngine;

namespace MapEditor
{
	// Token: 0x02000371 RID: 881
	[Token(Token = "0x2000371")]
	public class DictionaryView<TChunk, TType, TMonoBehaviour> : ChunkView<!0> where TChunk : DictionaryChunk<!1, !2>, new() where TMonoBehaviour : MonoBehaviour
	{
		// Token: 0x060013DD RID: 5085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013DD")]
		public DictionaryView(Vector2Int viewChunkSize, Vector2Int chunkSize, Func<Vector2Int, TType> getter)
		{
		}

		// Token: 0x060013DE RID: 5086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013DE")]
		public void Set(int x, int y, TType type)
		{
		}

		// Token: 0x060013DF RID: 5087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013DF")]
		public void Update(int x, int y)
		{
		}

		// Token: 0x060013E0 RID: 5088 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60013E0")]
		protected override TChunk CreateChunk()
		{
			return null;
		}

		// Token: 0x060013E1 RID: 5089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013E1")]
		protected override void DestroyChunk(TChunk chunk)
		{
		}

		// Token: 0x060013E2 RID: 5090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013E2")]
		protected override void LoadChunk(TChunk chunk)
		{
		}

		// Token: 0x060013E3 RID: 5091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013E3")]
		protected override void UnloadChunk(TChunk chunk)
		{
		}

		// Token: 0x04001034 RID: 4148
		[Token(Token = "0x4001034")]
		[FieldOffset(Offset = "0x0")]
		private readonly Func<Vector2Int, TType> _getter;
	}
}
