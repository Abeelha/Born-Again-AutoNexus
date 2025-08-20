using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace kha2dev.DatePicker
{
	// Token: 0x02000360 RID: 864
	[Token(Token = "0x2000360")]
	public class DayDateMonoScript : MonoBehaviour
	{
		// Token: 0x17000204 RID: 516
		// (get) Token: 0x0600138E RID: 5006 RVA: 0x00006EA0 File Offset: 0x000050A0
		// (set) Token: 0x0600138F RID: 5007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000204")]
		private bool isEnable
		{
			[Token(Token = "0x600138E")]
			[Address(RVA = "0x3929A0", Offset = "0x391BA0", VA = "0x1803929A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600138F")]
			[Address(RVA = "0x3929C0", Offset = "0x391BC0", VA = "0x1803929C0")]
			set
			{
			}
		}

		// Token: 0x06001390 RID: 5008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001390")]
		[Address(RVA = "0x392750", Offset = "0x391950", VA = "0x180392750")]
		public void CreateDayDate([Optional] DateTime dateTime, bool isEnable = false, [Optional] Action<DateTime> callback)
		{
		}

		// Token: 0x06001391 RID: 5009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001391")]
		[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
		public DayDateMonoScript()
		{
		}

		// Token: 0x04000FF5 RID: 4085
		[Token(Token = "0x4000FF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Button buttonDay;

		// Token: 0x04000FF6 RID: 4086
		[Token(Token = "0x4000FF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TMP_Text textDay;

		// Token: 0x04000FF7 RID: 4087
		[Token(Token = "0x4000FF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public DateTime dateTime;
	}
}
