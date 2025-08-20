using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace MapEditor
{
	// Token: 0x0200036D RID: 877
	[Token(Token = "0x200036D")]
	public class MapEditorToolKeyControls : MonoBehaviour
	{
		// Token: 0x060013BE RID: 5054 RVA: 0x00006EE8 File Offset: 0x000050E8
		[Token(Token = "0x60013BE")]
		[Address(RVA = "0x39C200", Offset = "0x39B400", VA = "0x18039C200")]
		private MapEditorToolType? GetNewTool()
		{
			return null;
		}

		// Token: 0x060013BF RID: 5055 RVA: 0x00006F00 File Offset: 0x00005100
		[Token(Token = "0x60013BF")]
		[Address(RVA = "0x39C390", Offset = "0x39B590", VA = "0x18039C390")]
		private bool IsAltDown()
		{
			return default(bool);
		}

		// Token: 0x060013C0 RID: 5056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013C0")]
		[Address(RVA = "0x39C3A0", Offset = "0x39B5A0", VA = "0x18039C3A0")]
		private void Update()
		{
		}

		// Token: 0x060013C1 RID: 5057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013C1")]
		[Address(RVA = "0x39C3A0", Offset = "0x39B5A0", VA = "0x18039C3A0")]
		private void UpdateKeyBinds()
		{
		}

		// Token: 0x060013C2 RID: 5058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013C2")]
		[Address(RVA = "0x39C4A0", Offset = "0x39B6A0", VA = "0x18039C4A0")]
		public MapEditorToolKeyControls()
		{
		}

		// Token: 0x04001028 RID: 4136
		[Token(Token = "0x4001028")]
		[FieldOffset(Offset = "0x20")]
		public MapEditorToolController ToolControl;

		// Token: 0x04001029 RID: 4137
		[Token(Token = "0x4001029")]
		[FieldOffset(Offset = "0x28")]
		private readonly Dictionary<KeyCode, MapEditorToolType> _toolMappings;
	}
}
