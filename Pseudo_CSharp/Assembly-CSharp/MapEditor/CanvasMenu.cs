using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace MapEditor
{
	// Token: 0x02000388 RID: 904
	[Token(Token = "0x2000388")]
	public class CanvasMenu : MonoBehaviour
	{
		// Token: 0x060014B9 RID: 5305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014B9")]
		[Address(RVA = "0x392650", Offset = "0x391850", VA = "0x180392650")]
		public void Okay()
		{
		}

		// Token: 0x060014BA RID: 5306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014BA")]
		[Address(RVA = "0x3924F0", Offset = "0x3916F0", VA = "0x1803924F0")]
		private void ClearInputs()
		{
		}

		// Token: 0x060014BB RID: 5307 RVA: 0x00007440 File Offset: 0x00005640
		[Token(Token = "0x60014BB")]
		[Address(RVA = "0x392610", Offset = "0x391810", VA = "0x180392610")]
		private int GetWidth()
		{
			return 0;
		}

		// Token: 0x060014BC RID: 5308 RVA: 0x00007458 File Offset: 0x00005658
		[Token(Token = "0x60014BC")]
		[Address(RVA = "0x3925D0", Offset = "0x3917D0", VA = "0x1803925D0")]
		private int GetHeight()
		{
			return 0;
		}

		// Token: 0x060014BD RID: 5309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014BD")]
		[Address(RVA = "0x3924F0", Offset = "0x3916F0", VA = "0x1803924F0")]
		private void OnEnable()
		{
		}

		// Token: 0x060014BE RID: 5310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014BE")]
		[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
		public CanvasMenu()
		{
		}

		// Token: 0x040010A8 RID: 4264
		[Token(Token = "0x40010A8")]
		[FieldOffset(Offset = "0x20")]
		public TMP_InputField WidthInput;

		// Token: 0x040010A9 RID: 4265
		[Token(Token = "0x40010A9")]
		[FieldOffset(Offset = "0x28")]
		public TMP_InputField HeightInput;

		// Token: 0x040010AA RID: 4266
		[Token(Token = "0x40010AA")]
		[FieldOffset(Offset = "0x30")]
		public AnchorSelector AnchorSelector;

		// Token: 0x040010AB RID: 4267
		[Token(Token = "0x40010AB")]
		[FieldOffset(Offset = "0x38")]
		public Menu Menu;

		// Token: 0x040010AC RID: 4268
		[Token(Token = "0x40010AC")]
		[FieldOffset(Offset = "0x40")]
		public MapEditorContext Context;
	}
}
