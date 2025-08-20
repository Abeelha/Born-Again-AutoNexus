using System;
using System.Text;
using Il2CppDummyDll;
using Ronin.Model.Interfaces;
using TMPro;
using UnityEngine;

namespace MapEditor
{
	// Token: 0x02000395 RID: 917
	[Token(Token = "0x2000395")]
	public class Override : MonoBehaviour
	{
		// Token: 0x060014FC RID: 5372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014FC")]
		[Address(RVA = "0x3A3310", Offset = "0x3A2510", VA = "0x1803A3310")]
		public void Setup(IOverride @override, Vector2Int position)
		{
		}

		// Token: 0x060014FD RID: 5373 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60014FD")]
		[Address(RVA = "0x3A3080", Offset = "0x3A2280", VA = "0x1803A3080")]
		private StringBuilder AddText(IOverride @override, StringBuilder builder)
		{
			return null;
		}

		// Token: 0x060014FE RID: 5374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014FE")]
		[Address(RVA = "0x3A3270", Offset = "0x3A2470", VA = "0x1803A3270")]
		private void SetLabel(IOverride @override)
		{
		}

		// Token: 0x060014FF RID: 5375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014FF")]
		[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
		public Override()
		{
		}

		// Token: 0x040010E6 RID: 4326
		[Token(Token = "0x40010E6")]
		[FieldOffset(Offset = "0x20")]
		public TextMeshPro Label;
	}
}
