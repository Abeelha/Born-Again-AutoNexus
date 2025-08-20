using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

// Token: 0x02000198 RID: 408
[Token(Token = "0x2000198")]
public class DownUpButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
{
	// Token: 0x06000848 RID: 2120 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000848")]
	[Address(RVA = "0x4107C0", Offset = "0x40F9C0", VA = "0x1804107C0", Slot = "4")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	// Token: 0x06000849 RID: 2121 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000849")]
	[Address(RVA = "0x4107E0", Offset = "0x40F9E0", VA = "0x1804107E0", Slot = "5")]
	public void OnPointerUp(PointerEventData eventData)
	{
	}

	// Token: 0x0600084A RID: 2122 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600084A")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public DownUpButton()
	{
	}

	// Token: 0x04000810 RID: 2064
	[Token(Token = "0x4000810")]
	[FieldOffset(Offset = "0x20")]
	public DownUpButton.ButtonDownEvent OnDown;

	// Token: 0x04000811 RID: 2065
	[Token(Token = "0x4000811")]
	[FieldOffset(Offset = "0x28")]
	public DownUpButton.ButtonUpEvent OnUp;

	// Token: 0x02000199 RID: 409
	[Token(Token = "0x2000199")]
	[Serializable]
	public class ButtonDownEvent : UnityEvent
	{
		// Token: 0x0600084B RID: 2123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600084B")]
		[Address(RVA = "0x407B40", Offset = "0x406D40", VA = "0x180407B40")]
		public ButtonDownEvent()
		{
		}
	}

	// Token: 0x0200019A RID: 410
	[Token(Token = "0x200019A")]
	[Serializable]
	public class ButtonUpEvent : UnityEvent
	{
		// Token: 0x0600084C RID: 2124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600084C")]
		[Address(RVA = "0x407B40", Offset = "0x406D40", VA = "0x180407B40")]
		public ButtonUpEvent()
		{
		}
	}
}
