using System;
using Il2CppDummyDll;
using kha2dev.DatePicker;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000353 RID: 851
[Token(Token = "0x2000353")]
public class DemoCalendarDatePicker : MonoBehaviour
{
	// Token: 0x0600135A RID: 4954 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600135A")]
	[Address(RVA = "0x37B8D0", Offset = "0x37AAD0", VA = "0x18037B8D0")]
	private void Start()
	{
	}

	// Token: 0x0600135B RID: 4955 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600135B")]
	[Address(RVA = "0x37B840", Offset = "0x37AA40", VA = "0x18037B840")]
	private void OpenDatePicker_Normal()
	{
	}

	// Token: 0x0600135C RID: 4956 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600135C")]
	[Address(RVA = "0x37B510", Offset = "0x37A710", VA = "0x18037B510")]
	private void OpenDatePicker_Limited()
	{
	}

	// Token: 0x0600135D RID: 4957 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600135D")]
	[Address(RVA = "0x37B460", Offset = "0x37A660", VA = "0x18037B460")]
	private void CallbackDatePicker(DateTime result)
	{
	}

	// Token: 0x0600135E RID: 4958 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600135E")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public DemoCalendarDatePicker()
	{
	}

	// Token: 0x04000FBC RID: 4028
	[Token(Token = "0x4000FBC")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Button buttonOpenDatePicker_Normal;

	// Token: 0x04000FBD RID: 4029
	[Token(Token = "0x4000FBD")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Button buttonOpenDatePicker_Limited;

	// Token: 0x04000FBE RID: 4030
	[Token(Token = "0x4000FBE")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private TMP_Text textResult;

	// Token: 0x04000FBF RID: 4031
	[Token(Token = "0x4000FBF")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private CalendarDatePicker calendarDatePicker;
}
