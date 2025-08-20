using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x020001B5 RID: 437
[Token(Token = "0x20001B5")]
public class AlertLinks : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
{
	// Token: 0x060008B9 RID: 2233 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008B9")]
	[Address(RVA = "0x406860", Offset = "0x405A60", VA = "0x180406860", Slot = "4")]
	public void OnPointerClick(PointerEventData eventData)
	{
	}

	// Token: 0x060008BA RID: 2234 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008BA")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public AlertLinks()
	{
	}

	// Token: 0x0400087B RID: 2171
	[Token(Token = "0x400087B")]
	[FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI Label;
}
