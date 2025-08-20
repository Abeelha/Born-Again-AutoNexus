using System;
using Il2CppDummyDll;
using Ronin.Model.Interfaces;
using TMPro;

namespace MapEditor
{
	// Token: 0x0200038F RID: 911
	[Token(Token = "0x200038F")]
	public class OffsetOverrideMenu : OverrideSubMenu
	{
		// Token: 0x17000225 RID: 549
		// (get) Token: 0x060014D7 RID: 5335 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000225")]
		public string StringX
		{
			[Token(Token = "0x60014D7")]
			[Address(RVA = "0x3A1F00", Offset = "0x3A1100", VA = "0x1803A1F00")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x060014D8 RID: 5336 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000226")]
		public string StringY
		{
			[Token(Token = "0x60014D8")]
			[Address(RVA = "0x3A1F90", Offset = "0x3A1190", VA = "0x1803A1F90")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x060014D9 RID: 5337 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000227")]
		public string StringZ
		{
			[Token(Token = "0x60014D9")]
			[Address(RVA = "0x3A2020", Offset = "0x3A1220", VA = "0x1803A2020")]
			get
			{
				return null;
			}
		}

		// Token: 0x060014DA RID: 5338 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60014DA")]
		[Address(RVA = "0x3A1A10", Offset = "0x3A0C10", VA = "0x1803A1A10", Slot = "4")]
		protected override IOverride GetOverride()
		{
			return null;
		}

		// Token: 0x060014DB RID: 5339 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60014DB")]
		[Address(RVA = "0x3A1AC0", Offset = "0x3A0CC0", VA = "0x1803A1AC0", Slot = "5")]
		protected override string GetValidationError()
		{
			return null;
		}

		// Token: 0x060014DC RID: 5340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014DC")]
		[Address(RVA = "0x3A1D00", Offset = "0x3A0F00", VA = "0x1803A1D00", Slot = "6")]
		protected override void Layout()
		{
		}

		// Token: 0x060014DD RID: 5341 RVA: 0x000074A0 File Offset: 0x000056A0
		[Token(Token = "0x60014DD")]
		[Address(RVA = "0x3A1EB0", Offset = "0x3A10B0", VA = "0x1803A1EB0")]
		private bool TryParse(string x, out float value)
		{
			return default(bool);
		}

		// Token: 0x060014DE RID: 5342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014DE")]
		[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
		public OffsetOverrideMenu()
		{
		}

		// Token: 0x040010C7 RID: 4295
		[Token(Token = "0x40010C7")]
		[FieldOffset(Offset = "0x48")]
		public TMP_InputField InputX;

		// Token: 0x040010C8 RID: 4296
		[Token(Token = "0x40010C8")]
		[FieldOffset(Offset = "0x50")]
		public TMP_InputField InputY;

		// Token: 0x040010C9 RID: 4297
		[Token(Token = "0x40010C9")]
		[FieldOffset(Offset = "0x58")]
		public TMP_InputField InputZ;

		// Token: 0x040010CA RID: 4298
		[Token(Token = "0x40010CA")]
		[FieldOffset(Offset = "0x60")]
		private float _x;

		// Token: 0x040010CB RID: 4299
		[Token(Token = "0x40010CB")]
		[FieldOffset(Offset = "0x64")]
		private float _y;

		// Token: 0x040010CC RID: 4300
		[Token(Token = "0x40010CC")]
		[FieldOffset(Offset = "0x68")]
		private float _z;
	}
}
