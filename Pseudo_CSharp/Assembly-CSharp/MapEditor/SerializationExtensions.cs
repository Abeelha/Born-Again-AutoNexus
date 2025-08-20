using System;
using Il2CppDummyDll;
using Ronin.Model.Files.Map;
using UnityEngine;

namespace MapEditor
{
	// Token: 0x02000396 RID: 918
	[Token(Token = "0x2000396")]
	public static class SerializationExtensions
	{
		// Token: 0x06001500 RID: 5376 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001500")]
		[Address(RVA = "0x3A3B80", Offset = "0x3A2D80", VA = "0x1803A3B80")]
		public static MapFile ExportMap(this MapEditorContext context, RectInt rect)
		{
			return null;
		}

		// Token: 0x06001501 RID: 5377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001501")]
		[Address(RVA = "0x3A77D0", Offset = "0x3A69D0", VA = "0x1803A77D0")]
		public static void ImportMap(this MapEditorContext context, MapFile file, Vector2Int coordinates)
		{
		}
	}
}
