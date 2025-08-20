using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Il2CppDummyDll;
using kha2dev.DatePicker;
using Ronin.Api.Model.Enums;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000127 RID: 295
[Token(Token = "0x2000127")]
public class RegisterMenu : Menu
{
	// Token: 0x1700005A RID: 90
	// (get) Token: 0x06000510 RID: 1296 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x1700005A")]
	public string Email
	{
		[Token(Token = "0x6000510")]
		[Address(RVA = "0x3DC400", Offset = "0x3DB600", VA = "0x1803DC400")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700005B RID: 91
	// (get) Token: 0x06000511 RID: 1297 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x1700005B")]
	public string Password
	{
		[Token(Token = "0x6000511")]
		[Address(RVA = "0x3DC490", Offset = "0x3DB690", VA = "0x1803DC490")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000512 RID: 1298 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000512")]
	[Address(RVA = "0x3DB400", Offset = "0x3DA600", VA = "0x1803DB400")]
	public void LanguageChanged()
	{
	}

	// Token: 0x06000513 RID: 1299 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000513")]
	[Address(RVA = "0x3DB550", Offset = "0x3DA750", VA = "0x1803DB550")]
	public void NoClear()
	{
	}

	// Token: 0x06000514 RID: 1300 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000514")]
	[Address(RVA = "0x3DBA00", Offset = "0x3DAC00", VA = "0x1803DBA00")]
	public void Register()
	{
	}

	// Token: 0x06000515 RID: 1301 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000515")]
	[Address(RVA = "0x3DBBE0", Offset = "0x3DADE0", VA = "0x1803DBBE0")]
	public void SelectDateOfBirth()
	{
	}

	// Token: 0x06000516 RID: 1302 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000516")]
	[Address(RVA = "0x3DB560", Offset = "0x3DA760", VA = "0x1803DB560", Slot = "5")]
	protected override void OnEnter()
	{
	}

	// Token: 0x06000517 RID: 1303 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000517")]
	[Address(RVA = "0x3DB320", Offset = "0x3DA520", VA = "0x1803DB320")]
	private static string GetShortDateString(DateTime date)
	{
		return null;
	}

	// Token: 0x06000518 RID: 1304 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000518")]
	[Address(RVA = "0x3DB290", Offset = "0x3DA490", VA = "0x1803DB290")]
	private void DateOfBirthChanged(DateTime date)
	{
	}

	// Token: 0x06000519 RID: 1305 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000519")]
	[Address(RVA = "0x3DB540", Offset = "0x3DA740", VA = "0x1803DB540")]
	private void LateUpdate()
	{
	}

	// Token: 0x0600051A RID: 1306 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600051A")]
	[Address(RVA = "0x3DB8D0", Offset = "0x3DAAD0", VA = "0x1803DB8D0")]
	private Task RegisterAsync(string email, string password, DateTime dateOfBirth)
	{
		return null;
	}

	// Token: 0x0600051B RID: 1307 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600051B")]
	[Address(RVA = "0x3DBD60", Offset = "0x3DAF60", VA = "0x1803DBD60")]
	private void UpdatePasswordStrength()
	{
	}

	// Token: 0x0600051C RID: 1308 RVA: 0x000034B0 File Offset: 0x000016B0
	[Token(Token = "0x600051C")]
	[Address(RVA = "0x3DBE50", Offset = "0x3DB050", VA = "0x1803DBE50")]
	private bool ValidateInput()
	{
		return default(bool);
	}

	// Token: 0x0600051D RID: 1309 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600051D")]
	[Address(RVA = "0x3BC980", Offset = "0x3BBB80", VA = "0x1803BC980")]
	public RegisterMenu()
	{
	}

	// Token: 0x04000579 RID: 1401
	[Token(Token = "0x4000579")]
	[FieldOffset(Offset = "0x90")]
	private Dictionary<PasswordStrength, Color> _passwordStrengthColors;

	// Token: 0x0400057A RID: 1402
	[Token(Token = "0x400057A")]
	[FieldOffset(Offset = "0x98")]
	private DateTime? _dateOfBirth;

	// Token: 0x0400057B RID: 1403
	[Token(Token = "0x400057B")]
	[FieldOffset(Offset = "0xA8")]
	private bool _noClear;

	// Token: 0x0400057C RID: 1404
	[Token(Token = "0x400057C")]
	[FieldOffset(Offset = "0xB0")]
	public TMP_InputField EmailInput;

	// Token: 0x0400057D RID: 1405
	[Token(Token = "0x400057D")]
	[FieldOffset(Offset = "0xB8")]
	public TMP_InputField PasswordInput;

	// Token: 0x0400057E RID: 1406
	[Token(Token = "0x400057E")]
	[FieldOffset(Offset = "0xC0")]
	public TMP_InputField ConfirmPasswordInput;

	// Token: 0x0400057F RID: 1407
	[Token(Token = "0x400057F")]
	[FieldOffset(Offset = "0xC8")]
	public Slider PasswordStrengthSlider;

	// Token: 0x04000580 RID: 1408
	[Token(Token = "0x4000580")]
	[FieldOffset(Offset = "0xD0")]
	public Image PasswordStrengthSliderImage;

	// Token: 0x04000581 RID: 1409
	[Token(Token = "0x4000581")]
	[FieldOffset(Offset = "0xD8")]
	public RegisterMenu.PasswordStrengthColor[] PasswordStrengthColors;

	// Token: 0x04000582 RID: 1410
	[Token(Token = "0x4000582")]
	[FieldOffset(Offset = "0xE0")]
	public TMP_InputField DateOfBirthInput;

	// Token: 0x04000583 RID: 1411
	[Token(Token = "0x4000583")]
	[FieldOffset(Offset = "0xE8")]
	public TextMeshProUGUI DateOfBirthPlaceholder;

	// Token: 0x04000584 RID: 1412
	[Token(Token = "0x4000584")]
	[FieldOffset(Offset = "0xF0")]
	public CalendarDatePicker DatePicker;

	// Token: 0x04000585 RID: 1413
	[Token(Token = "0x4000585")]
	[FieldOffset(Offset = "0xF8")]
	private Task _registerTask;

	// Token: 0x02000128 RID: 296
	[Token(Token = "0x2000128")]
	[Serializable]
	public struct PasswordStrengthColor
	{
		// Token: 0x04000586 RID: 1414
		[Token(Token = "0x4000586")]
		[FieldOffset(Offset = "0x0")]
		public PasswordStrength PasswordStrength;

		// Token: 0x04000587 RID: 1415
		[Token(Token = "0x4000587")]
		[FieldOffset(Offset = "0x4")]
		public Color Color;
	}
}
