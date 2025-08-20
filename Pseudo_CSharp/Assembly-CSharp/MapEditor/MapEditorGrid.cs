using System;
using Il2CppDummyDll;
using UnityEngine;

namespace MapEditor
{
	// Token: 0x0200037A RID: 890
	[Token(Token = "0x200037A")]
	public class MapEditorGrid : MonoBehaviour
	{
		// Token: 0x0600142F RID: 5167 RVA: 0x00007158 File Offset: 0x00005358
		[Token(Token = "0x600142F")]
		[Address(RVA = "0x39A420", Offset = "0x399620", VA = "0x18039A420")]
		private Vector2Int GetTargetSize()
		{
			return default(Vector2Int);
		}

		// Token: 0x06001430 RID: 5168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001430")]
		[Address(RVA = "0x39A630", Offset = "0x399830", VA = "0x18039A630")]
		private void SetSize(Vector2Int size)
		{
		}

		// Token: 0x06001431 RID: 5169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001431")]
		[Address(RVA = "0x39AAF0", Offset = "0x399CF0", VA = "0x18039AAF0")]
		private void Update()
		{
		}

		// Token: 0x06001432 RID: 5170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001432")]
		[Address(RVA = "0x39A780", Offset = "0x399980", VA = "0x18039A780")]
		private void UpdatePosition()
		{
		}

		// Token: 0x06001433 RID: 5171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001433")]
		[Address(RVA = "0x39A970", Offset = "0x399B70", VA = "0x18039A970")]
		private void UpdateSize()
		{
		}

		// Token: 0x06001434 RID: 5172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001434")]
		[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
		public MapEditorGrid()
		{
		}

		// Token: 0x04001054 RID: 4180
		[Token(Token = "0x4001054")]
		[FieldOffset(Offset = "0x20")]
		public Camera Camera;

		// Token: 0x04001055 RID: 4181
		[Token(Token = "0x4001055")]
		[FieldOffset(Offset = "0x28")]
		public MeshRenderer MeshRenderer;

		// Token: 0x04001056 RID: 4182
		[Token(Token = "0x4001056")]
		[FieldOffset(Offset = "0x30")]
		public MapEditorContext Context;

		// Token: 0x04001057 RID: 4183
		[Token(Token = "0x4001057")]
		[FieldOffset(Offset = "0x38")]
		private Vector2Int _size;
	}
}
