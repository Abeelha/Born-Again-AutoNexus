using System;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

namespace MapEditor
{
	// Token: 0x02000389 RID: 905
	[Token(Token = "0x2000389")]
	public class ImportMenu : MonoBehaviour
	{
		// Token: 0x060014BF RID: 5311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014BF")]
		[Address(RVA = "0x394120", Offset = "0x393320", VA = "0x180394120")]
		public void Load()
		{
		}

		// Token: 0x060014C0 RID: 5312 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60014C0")]
		[Address(RVA = "0x3943D0", Offset = "0x3935D0", VA = "0x1803943D0")]
		private Task OpenAsync(string path, Vector2Int coordinates)
		{
			return null;
		}

		// Token: 0x060014C1 RID: 5313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014C1")]
		[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
		public ImportMenu()
		{
		}

		// Token: 0x040010AD RID: 4269
		[Token(Token = "0x40010AD")]
		[FieldOffset(Offset = "0x20")]
		public Menu Menu;

		// Token: 0x040010AE RID: 4270
		[Token(Token = "0x40010AE")]
		[FieldOffset(Offset = "0x28")]
		public MapEditorContext Context;
	}
}
