using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace kha2dev.DatePicker
{
	// Token: 0x02000362 RID: 866
	[Token(Token = "0x2000362")]
	public class DayLabelTMP : MonoBehaviour
	{
		// Token: 0x06001394 RID: 5012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001394")]
		[Address(RVA = "0x392A60", Offset = "0x391C60", VA = "0x180392A60")]
		private void Start()
		{
		}

		// Token: 0x06001395 RID: 5013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001395")]
		[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
		public DayLabelTMP()
		{
		}

		// Token: 0x04000FFA RID: 4090
		[Token(Token = "0x4000FFA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private DayOfWeek day;

		// Token: 0x04000FFB RID: 4091
		[Token(Token = "0x4000FFB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TMP_Text textLabel;
	}
}
