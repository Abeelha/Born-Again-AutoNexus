using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Ronin.Model.Interfaces;
using UnityEngine;

namespace MapEditor
{
	// Token: 0x02000390 RID: 912
	[Token(Token = "0x2000390")]
	public abstract class OverrideSubMenu : MonoBehaviour
	{
		// Token: 0x17000228 RID: 552
		// (get) Token: 0x060014DF RID: 5343 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060014E0 RID: 5344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000228")]
		private protected MapEditorContext Context
		{
			[Token(Token = "0x60014DF")]
			[Address(RVA = "0x3328D0", Offset = "0x331AD0", VA = "0x1803328D0")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x60014E0")]
			[Address(RVA = "0x34E000", Offset = "0x34D200", VA = "0x18034E000")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x060014E1 RID: 5345 RVA: 0x000074B8 File Offset: 0x000056B8
		// (set) Token: 0x060014E2 RID: 5346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000229")]
		private protected Vector2Int Coordinates
		{
			[Token(Token = "0x60014E1")]
			[Address(RVA = "0x3A3060", Offset = "0x3A2260", VA = "0x1803A3060")]
			[CompilerGenerated]
			protected get
			{
				return default(Vector2Int);
			}
			[Token(Token = "0x60014E2")]
			[Address(RVA = "0x3A3070", Offset = "0x3A2270", VA = "0x1803A3070")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x060014E3 RID: 5347 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060014E4 RID: 5348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700022A")]
		private protected IOverride CurrentOverride
		{
			[Token(Token = "0x60014E3")]
			[Address(RVA = "0x3944E0", Offset = "0x3936E0", VA = "0x1803944E0")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x60014E4")]
			[Address(RVA = "0x394520", Offset = "0x393720", VA = "0x180394520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060014E5 RID: 5349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014E5")]
		[Address(RVA = "0x3A2F20", Offset = "0x3A2120", VA = "0x1803A2F20")]
		public void Complete()
		{
		}

		// Token: 0x060014E6 RID: 5350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014E6")]
		[Address(RVA = "0x3A2FF0", Offset = "0x3A21F0", VA = "0x1803A2FF0")]
		public void Setup(Menu parentMenu, MapEditorContext context, Vector2Int coordinates, IOverride currentOverride)
		{
		}

		// Token: 0x060014E7 RID: 5351
		[Token(Token = "0x60014E7")]
		protected abstract IOverride GetOverride();

		// Token: 0x060014E8 RID: 5352
		[Token(Token = "0x60014E8")]
		protected abstract string GetValidationError();

		// Token: 0x060014E9 RID: 5353
		[Token(Token = "0x60014E9")]
		protected abstract void Layout();

		// Token: 0x060014EA RID: 5354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014EA")]
		[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
		protected OverrideSubMenu()
		{
		}

		// Token: 0x040010CD RID: 4301
		[Token(Token = "0x40010CD")]
		[FieldOffset(Offset = "0x20")]
		public Menu Menu;

		// Token: 0x040010D1 RID: 4305
		[Token(Token = "0x40010D1")]
		[FieldOffset(Offset = "0x40")]
		private Menu _parentMenu;
	}
}
