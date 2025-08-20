using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace kha2dev.DatePicker
{
	// Token: 0x02000359 RID: 857
	[Token(Token = "0x2000359")]
	public class CalendarDatePicker : MonoBehaviour
	{
		// Token: 0x17000203 RID: 515
		// (get) Token: 0x0600136F RID: 4975 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000203")]
		public static CultureInfo CultureInfo
		{
			[Token(Token = "0x600136F")]
			[Address(RVA = "0x37B420", Offset = "0x37A620", VA = "0x18037B420")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001370 RID: 4976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001370")]
		[Address(RVA = "0x37B020", Offset = "0x37A220", VA = "0x18037B020")]
		private void Initialize()
		{
		}

		// Token: 0x06001371 RID: 4977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001371")]
		[Address(RVA = "0x37B080", Offset = "0x37A280", VA = "0x18037B080")]
		public void Show([Optional] Action<DateTime> callback, [Optional] ParameterDatePicker param)
		{
		}

		// Token: 0x06001372 RID: 4978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001372")]
		[Address(RVA = "0x3799F0", Offset = "0x378BF0", VA = "0x1803799F0")]
		private void GetDay([Optional] Action<DateTime> callback)
		{
		}

		// Token: 0x06001373 RID: 4979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001373")]
		[Address(RVA = "0x37A3E0", Offset = "0x3795E0", VA = "0x18037A3E0")]
		private void GetMonth([Optional] Action<DateTime> callback)
		{
		}

		// Token: 0x06001374 RID: 4980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001374")]
		[Address(RVA = "0x37AA10", Offset = "0x379C10", VA = "0x18037AA10")]
		private void GetYear([Optional] Action<DateTime> callback)
		{
		}

		// Token: 0x06001375 RID: 4981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001375")]
		[Address(RVA = "0x37AFA0", Offset = "0x37A1A0", VA = "0x18037AFA0")]
		public void Hide()
		{
		}

		// Token: 0x06001376 RID: 4982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001376")]
		[Address(RVA = "0x37B330", Offset = "0x37A530", VA = "0x18037B330")]
		public CalendarDatePicker()
		{
		}

		// Token: 0x04000FC4 RID: 4036
		[Token(Token = "0x4000FC4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Color enableColor;

		// Token: 0x04000FC5 RID: 4037
		[Token(Token = "0x4000FC5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color disableColor;

		// Token: 0x04000FC6 RID: 4038
		[Token(Token = "0x4000FC6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject objectCalendarDatePicker;

		// Token: 0x04000FC7 RID: 4039
		[Token(Token = "0x4000FC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Button titleButton;

		// Token: 0x04000FC8 RID: 4040
		[Token(Token = "0x4000FC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TMP_Text titleText;

		// Token: 0x04000FC9 RID: 4041
		[Token(Token = "0x4000FC9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Button prevButton;

		// Token: 0x04000FCA RID: 4042
		[Token(Token = "0x4000FCA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Button nextButton;

		// Token: 0x04000FCB RID: 4043
		[Token(Token = "0x4000FCB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject dayHolderObject;

		// Token: 0x04000FCC RID: 4044
		[Token(Token = "0x4000FCC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject dayObjectPrefab;

		// Token: 0x04000FCD RID: 4045
		[Token(Token = "0x4000FCD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Transform parentListDayPicker;

		// Token: 0x04000FCE RID: 4046
		[Token(Token = "0x4000FCE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private List<GameObject> listDayObject;

		// Token: 0x04000FCF RID: 4047
		[Token(Token = "0x4000FCF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject monthHolderObject;

		// Token: 0x04000FD0 RID: 4048
		[Token(Token = "0x4000FD0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject yearHolderObject;

		// Token: 0x04000FD1 RID: 4049
		[Token(Token = "0x4000FD1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject monthYearObjectPrefab;

		// Token: 0x04000FD2 RID: 4050
		[Token(Token = "0x4000FD2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private List<GameObject> listMonthYearObject;

		// Token: 0x04000FD3 RID: 4051
		[Token(Token = "0x4000FD3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public ParameterDatePicker param;

		// Token: 0x04000FD4 RID: 4052
		[Token(Token = "0x4000FD4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Color EnableColor;

		// Token: 0x04000FD5 RID: 4053
		[Token(Token = "0x4000FD5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Color DisableColor;

		// Token: 0x04000FD6 RID: 4054
		[Token(Token = "0x4000FD6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private bool isDoneInitialize;
	}
}
