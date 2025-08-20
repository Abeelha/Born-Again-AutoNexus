using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace AnimateInternal
{
	// Token: 0x02000445 RID: 1093
	[Token(Token = "0x2000445")]
	public class AnimateInstance : MonoBehaviour
	{
		// Token: 0x060016CF RID: 5839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016CF")]
		[Address(RVA = "0x3AEB40", Offset = "0x3ADD40", VA = "0x1803AEB40")]
		public void AddTask(AnimateTask task)
		{
		}

		// Token: 0x060016D0 RID: 5840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016D0")]
		[Address(RVA = "0x3AEBF0", Offset = "0x3ADDF0", VA = "0x1803AEBF0")]
		private void Awake()
		{
		}

		// Token: 0x060016D1 RID: 5841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016D1")]
		[Address(RVA = "0x3AEE80", Offset = "0x3AE080", VA = "0x1803AEE80")]
		private void Update()
		{
		}

		// Token: 0x060016D2 RID: 5842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016D2")]
		[Address(RVA = "0x3AF020", Offset = "0x3AE220", VA = "0x1803AF020")]
		public AnimateInstance()
		{
		}

		// Token: 0x0400128D RID: 4749
		[Token(Token = "0x400128D")]
		[FieldOffset(Offset = "0x20")]
		private List<AnimateTask> _tasks;

		// Token: 0x0400128E RID: 4750
		[Token(Token = "0x400128E")]
		[FieldOffset(Offset = "0x28")]
		private List<AnimateTask> _tasksNext;
	}
}
