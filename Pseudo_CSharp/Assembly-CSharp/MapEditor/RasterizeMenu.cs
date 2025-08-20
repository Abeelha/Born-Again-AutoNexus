using System;
using System.Threading.Tasks;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace MapEditor
{
	// Token: 0x02000393 RID: 915
	[Token(Token = "0x2000393")]
	public class RasterizeMenu : MonoBehaviour
	{
		// Token: 0x060014F3 RID: 5363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014F3")]
		[Address(RVA = "0x3A3710", Offset = "0x3A2910", VA = "0x1803A3710")]
		public void Load()
		{
		}

		// Token: 0x060014F4 RID: 5364 RVA: 0x000074D0 File Offset: 0x000056D0
		[Token(Token = "0x60014F4")]
		[Address(RVA = "0x3A35A0", Offset = "0x3A27A0", VA = "0x1803A35A0")]
		private static ushort GetTileFromColor(Color color)
		{
			return 0;
		}

		// Token: 0x060014F5 RID: 5365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014F5")]
		[Address(RVA = "0x3A34F0", Offset = "0x3A26F0", VA = "0x1803A34F0")]
		private void ClearInputs()
		{
		}

		// Token: 0x060014F6 RID: 5366 RVA: 0x000074E8 File Offset: 0x000056E8
		[Token(Token = "0x60014F6")]
		[Address(RVA = "0x3A3540", Offset = "0x3A2740", VA = "0x1803A3540")]
		private int GetScale()
		{
			return 0;
		}

		// Token: 0x060014F7 RID: 5367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014F7")]
		[Address(RVA = "0x3A34F0", Offset = "0x3A26F0", VA = "0x1803A34F0")]
		private void OnEnable()
		{
		}

		// Token: 0x060014F8 RID: 5368 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60014F8")]
		[Address(RVA = "0x3A39F0", Offset = "0x3A2BF0", VA = "0x1803A39F0")]
		private Task OpenAsync(string path, float scale)
		{
			return null;
		}

		// Token: 0x060014F9 RID: 5369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014F9")]
		[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
		public RasterizeMenu()
		{
		}

		// Token: 0x040010DD RID: 4317
		[Token(Token = "0x40010DD")]
		[FieldOffset(Offset = "0x20")]
		public TMP_InputField ScaleInput;

		// Token: 0x040010DE RID: 4318
		[Token(Token = "0x40010DE")]
		[FieldOffset(Offset = "0x28")]
		public Menu Menu;

		// Token: 0x040010DF RID: 4319
		[Token(Token = "0x40010DF")]
		[FieldOffset(Offset = "0x30")]
		public MapEditorContext Context;
	}
}
