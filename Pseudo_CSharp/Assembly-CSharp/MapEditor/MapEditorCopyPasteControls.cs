using System;
using Il2CppDummyDll;
using UnityEngine;

namespace MapEditor
{
	// Token: 0x02000366 RID: 870
	[Token(Token = "0x2000366")]
	public class MapEditorCopyPasteControls : MonoBehaviour
	{
		// Token: 0x0600139F RID: 5023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600139F")]
		[Address(RVA = "0x398F40", Offset = "0x398140", VA = "0x180398F40")]
		private void Copy()
		{
		}

		// Token: 0x060013A0 RID: 5024 RVA: 0x00006ED0 File Offset: 0x000050D0
		[Token(Token = "0x60013A0")]
		[Address(RVA = "0x399010", Offset = "0x398210", VA = "0x180399010")]
		private bool IsControlDown()
		{
			return default(bool);
		}

		// Token: 0x060013A1 RID: 5025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013A1")]
		[Address(RVA = "0x399020", Offset = "0x398220", VA = "0x180399020")]
		private void Paste()
		{
		}

		// Token: 0x060013A2 RID: 5026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013A2")]
		[Address(RVA = "0x399250", Offset = "0x398450", VA = "0x180399250")]
		private void Update()
		{
		}

		// Token: 0x060013A3 RID: 5027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013A3")]
		[Address(RVA = "0x399250", Offset = "0x398450", VA = "0x180399250")]
		private void UpdateControls()
		{
		}

		// Token: 0x060013A4 RID: 5028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013A4")]
		[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
		public MapEditorCopyPasteControls()
		{
		}

		// Token: 0x04001003 RID: 4099
		[Token(Token = "0x4001003")]
		[FieldOffset(Offset = "0x20")]
		public MapEditorContext Context;

		// Token: 0x04001004 RID: 4100
		[Token(Token = "0x4001004")]
		[FieldOffset(Offset = "0x28")]
		public MapEditorToolController Tools;

		// Token: 0x04001005 RID: 4101
		[Token(Token = "0x4001005")]
		[FieldOffset(Offset = "0x30")]
		private MapRegion _copiedRegion;
	}
}
