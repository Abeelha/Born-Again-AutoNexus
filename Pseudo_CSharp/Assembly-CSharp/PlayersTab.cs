using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x020002ED RID: 749
[Token(Token = "0x20002ED")]
public class PlayersTab : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	// Token: 0x06001089 RID: 4233 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001089")]
	[Address(RVA = "0x356530", Offset = "0x355730", VA = "0x180356530", Slot = "4")]
	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	// Token: 0x0600108A RID: 4234 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600108A")]
	[Address(RVA = "0x356520", Offset = "0x355720", VA = "0x180356520", Slot = "5")]
	public void OnPointerExit(PointerEventData eventData)
	{
	}

	// Token: 0x0600108B RID: 4235 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600108B")]
	[Address(RVA = "0x356450", Offset = "0x355650", VA = "0x180356450")]
	private void Clear(int startIndex)
	{
	}

	// Token: 0x0600108C RID: 4236 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600108C")]
	[Address(RVA = "0x356510", Offset = "0x355710", VA = "0x180356510")]
	private void LateUpdate()
	{
	}

	// Token: 0x0600108D RID: 4237 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600108D")]
	[Address(RVA = "0x356520", Offset = "0x355720", VA = "0x180356520")]
	private void OnDisable()
	{
	}

	// Token: 0x0600108E RID: 4238 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600108E")]
	[Address(RVA = "0x356540", Offset = "0x355740", VA = "0x180356540")]
	private void UpdateNearby()
	{
	}

	// Token: 0x0600108F RID: 4239 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600108F")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public PlayersTab()
	{
	}

	// Token: 0x04000DD3 RID: 3539
	[Token(Token = "0x4000DD3")]
	private const float NearbyPlayerRadius = 40f;

	// Token: 0x04000DD4 RID: 3540
	[Token(Token = "0x4000DD4")]
	private const float NearbyPlayerRadiusSqr = 1600f;

	// Token: 0x04000DD5 RID: 3541
	[Token(Token = "0x4000DD5")]
	[FieldOffset(Offset = "0x20")]
	public World World;

	// Token: 0x04000DD6 RID: 3542
	[Token(Token = "0x4000DD6")]
	[FieldOffset(Offset = "0x28")]
	public PlayerListing[] PlayerListings;

	// Token: 0x04000DD7 RID: 3543
	[Token(Token = "0x4000DD7")]
	[FieldOffset(Offset = "0x30")]
	public GameObject NoNearby;

	// Token: 0x04000DD8 RID: 3544
	[Token(Token = "0x4000DD8")]
	[FieldOffset(Offset = "0x38")]
	private bool _hovered;
}
