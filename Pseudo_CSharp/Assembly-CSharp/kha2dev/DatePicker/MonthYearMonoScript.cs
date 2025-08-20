using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace kha2dev.DatePicker
{
	// Token: 0x02000363 RID: 867
	[Token(Token = "0x2000363")]
	public class MonthYearMonoScript : MonoBehaviour
	{
		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06001396 RID: 5014 RVA: 0x00006EB8 File Offset: 0x000050B8
		// (set) Token: 0x06001397 RID: 5015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000205")]
		private bool isEnable
		{
			[Token(Token = "0x6001396")]
			[Address(RVA = "0x3929A0", Offset = "0x391BA0", VA = "0x1803929A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001397")]
			[Address(RVA = "0x3A1770", Offset = "0x3A0970", VA = "0x1803A1770")]
			set
			{
			}
		}

		// Token: 0x06001398 RID: 5016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001398")]
		[Address(RVA = "0x3A1400", Offset = "0x3A0600", VA = "0x1803A1400")]
		public void CreateMonth([Optional] DateTime dateTime, bool isEnable = false, [Optional] Action<DateTime> callback)
		{
		}

		// Token: 0x06001399 RID: 5017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001399")]
		[Address(RVA = "0x3A15F0", Offset = "0x3A07F0", VA = "0x1803A15F0")]
		public void CreateYear([Optional] DateTime dateTime, [Optional] Action<DateTime> callback)
		{
		}

		// Token: 0x0600139A RID: 5018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600139A")]
		[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
		public MonthYearMonoScript()
		{
		}

		// Token: 0x04000FFC RID: 4092
		[Token(Token = "0x4000FFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Button buttonMonthYear;

		// Token: 0x04000FFD RID: 4093
		[Token(Token = "0x4000FFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TMP_Text textMonthYear;

		// Token: 0x04000FFE RID: 4094
		[Token(Token = "0x4000FFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public DateTime dateTime;
	}
}
