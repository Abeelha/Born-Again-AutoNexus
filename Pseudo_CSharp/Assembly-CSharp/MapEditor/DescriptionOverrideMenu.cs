using System;
using Il2CppDummyDll;
using Ronin.Model.Interfaces;
using TMPro;

namespace MapEditor
{
	// Token: 0x0200038E RID: 910
	[Token(Token = "0x200038E")]
	public class DescriptionOverrideMenu : OverrideSubMenu
	{
		// Token: 0x17000224 RID: 548
		// (get) Token: 0x060014D2 RID: 5330 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000224")]
		protected string Description
		{
			[Token(Token = "0x60014D2")]
			[Address(RVA = "0x392D20", Offset = "0x391F20", VA = "0x180392D20")]
			get
			{
				return null;
			}
		}

		// Token: 0x060014D3 RID: 5331 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60014D3")]
		[Address(RVA = "0x392BA0", Offset = "0x391DA0", VA = "0x180392BA0", Slot = "4")]
		protected override IOverride GetOverride()
		{
			return null;
		}

		// Token: 0x060014D4 RID: 5332 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60014D4")]
		[Address(RVA = "0x392C10", Offset = "0x391E10", VA = "0x180392C10", Slot = "5")]
		protected override string GetValidationError()
		{
			return null;
		}

		// Token: 0x060014D5 RID: 5333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014D5")]
		[Address(RVA = "0x392C70", Offset = "0x391E70", VA = "0x180392C70", Slot = "6")]
		protected override void Layout()
		{
		}

		// Token: 0x060014D6 RID: 5334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014D6")]
		[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
		public DescriptionOverrideMenu()
		{
		}

		// Token: 0x040010C6 RID: 4294
		[Token(Token = "0x40010C6")]
		[FieldOffset(Offset = "0x48")]
		public TMP_InputField Input;
	}
}
