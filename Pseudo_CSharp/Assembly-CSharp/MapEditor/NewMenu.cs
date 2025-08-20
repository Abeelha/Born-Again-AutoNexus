using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace MapEditor
{
	// Token: 0x0200038B RID: 907
	[Token(Token = "0x200038B")]
	public class NewMenu : MonoBehaviour
	{
		// Token: 0x060014C4 RID: 5316 RVA: 0x00007470 File Offset: 0x00005670
		[Token(Token = "0x60014C4")]
		[Address(RVA = "0x392610", Offset = "0x391810", VA = "0x180392610")]
		private int GetWidth()
		{
			return 0;
		}

		// Token: 0x060014C5 RID: 5317 RVA: 0x00007488 File Offset: 0x00005688
		[Token(Token = "0x60014C5")]
		[Address(RVA = "0x3925D0", Offset = "0x3917D0", VA = "0x1803925D0")]
		private int GetHeight()
		{
			return 0;
		}

		// Token: 0x060014C6 RID: 5318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014C6")]
		[Address(RVA = "0x3A1890", Offset = "0x3A0A90", VA = "0x1803A1890")]
		public void Okay()
		{
		}

		// Token: 0x060014C7 RID: 5319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014C7")]
		[Address(RVA = "0x3A1810", Offset = "0x3A0A10", VA = "0x1803A1810")]
		private void ClearInputs()
		{
		}

		// Token: 0x060014C8 RID: 5320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014C8")]
		[Address(RVA = "0x3A1810", Offset = "0x3A0A10", VA = "0x1803A1810")]
		private void OnEnable()
		{
		}

		// Token: 0x060014C9 RID: 5321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014C9")]
		[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
		public NewMenu()
		{
		}

		// Token: 0x040010B6 RID: 4278
		[Token(Token = "0x40010B6")]
		[FieldOffset(Offset = "0x20")]
		public TMP_InputField WidthInput;

		// Token: 0x040010B7 RID: 4279
		[Token(Token = "0x40010B7")]
		[FieldOffset(Offset = "0x28")]
		public TMP_InputField HeightInput;

		// Token: 0x040010B8 RID: 4280
		[Token(Token = "0x40010B8")]
		[FieldOffset(Offset = "0x30")]
		public Menu Menu;

		// Token: 0x040010B9 RID: 4281
		[Token(Token = "0x40010B9")]
		[FieldOffset(Offset = "0x38")]
		public MapEditorContext Context;
	}
}
