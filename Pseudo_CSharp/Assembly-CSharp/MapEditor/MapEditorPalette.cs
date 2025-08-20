using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace MapEditor
{
	// Token: 0x0200037C RID: 892
	[Token(Token = "0x200037C")]
	public class MapEditorPalette : MonoBehaviour
	{
		// Token: 0x17000215 RID: 533
		// (get) Token: 0x0600143A RID: 5178 RVA: 0x00007170 File Offset: 0x00005370
		// (set) Token: 0x0600143B RID: 5179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000215")]
		public MapObjectType SelectedObjectType
		{
			[Token(Token = "0x600143A")]
			[Address(RVA = "0x39AF80", Offset = "0x39A180", VA = "0x18039AF80")]
			[CompilerGenerated]
			get
			{
				return MapObjectType.Tile;
			}
			[Token(Token = "0x600143B")]
			[Address(RVA = "0x39AFA0", Offset = "0x39A1A0", VA = "0x18039AFA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x0600143C RID: 5180 RVA: 0x00007188 File Offset: 0x00005388
		// (set) Token: 0x0600143D RID: 5181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000216")]
		public ushort SelectedType
		{
			[Token(Token = "0x600143C")]
			[Address(RVA = "0x39AF90", Offset = "0x39A190", VA = "0x18039AF90")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600143D")]
			[Address(RVA = "0x39AFB0", Offset = "0x39A1B0", VA = "0x18039AFB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600143E RID: 5182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600143E")]
		[Address(RVA = "0x39AF60", Offset = "0x39A160", VA = "0x18039AF60")]
		public void Select(MapObjectType objectType, ushort type)
		{
		}

		// Token: 0x0600143F RID: 5183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600143F")]
		[Address(RVA = "0x39AF70", Offset = "0x39A170", VA = "0x18039AF70")]
		public MapEditorPalette()
		{
		}
	}
}
