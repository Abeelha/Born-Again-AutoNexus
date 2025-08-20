using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x020002C9 RID: 713
[Token(Token = "0x20002C9")]
public class MapMinimap : MarkerMinimap, IPointerClickHandler, IEventSystemHandler
{
	// Token: 0x170001B6 RID: 438
	// (get) Token: 0x06000F4D RID: 3917 RVA: 0x00006108 File Offset: 0x00004308
	[Token(Token = "0x170001B6")]
	protected override float MarkerScale
	{
		[Token(Token = "0x6000F4D")]
		[Address(RVA = "0x46D7A0", Offset = "0x46C9A0", VA = "0x18046D7A0", Slot = "10")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x06000F4E RID: 3918 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F4E")]
	[Address(RVA = "0x46D130", Offset = "0x46C330", VA = "0x18046D130", Slot = "12")]
	public void OnPointerClick(PointerEventData eventData)
	{
	}

	// Token: 0x06000F4F RID: 3919 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F4F")]
	[Address(RVA = "0x46D1C0", Offset = "0x46C3C0", VA = "0x18046D1C0")]
	public void Select(RectTransform transform)
	{
	}

	// Token: 0x06000F50 RID: 3920 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000F50")]
	[Address(RVA = "0x46CA90", Offset = "0x46BC90", VA = "0x18046CA90", Slot = "11")]
	protected override IEnumerable<ValueTuple<Entity, Sprite, Vector2, bool, int>> GetMarkers()
	{
		return null;
	}

	// Token: 0x06000F51 RID: 3921 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F51")]
	[Address(RVA = "0x46CEA0", Offset = "0x46C0A0", VA = "0x18046CEA0", Slot = "8")]
	protected override void LateUpdate()
	{
	}

	// Token: 0x06000F52 RID: 3922 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F52")]
	[Address(RVA = "0x46D050", Offset = "0x46C250", VA = "0x18046D050", Slot = "9")]
	protected override void OnDisable()
	{
	}

	// Token: 0x06000F53 RID: 3923 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F53")]
	[Address(RVA = "0x46C890", Offset = "0x46BA90", VA = "0x18046C890")]
	private void ClearTooltip()
	{
	}

	// Token: 0x06000F54 RID: 3924 RVA: 0x00006120 File Offset: 0x00004320
	[Token(Token = "0x6000F54")]
	[Address(RVA = "0x46C740", Offset = "0x46B940", VA = "0x18046C740")]
	private bool CanShowMarker(Entity entity)
	{
		return default(bool);
	}

	// Token: 0x06000F55 RID: 3925 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000F55")]
	[Address(RVA = "0x46C940", Offset = "0x46BB40", VA = "0x18046C940")]
	private IEnumerable<ValueTuple<ushort, Vector2Int>> GetAvailableTravelLocations()
	{
		return null;
	}

	// Token: 0x06000F56 RID: 3926 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000F56")]
	[Address(RVA = "0x46CD40", Offset = "0x46BF40", VA = "0x18046CD40")]
	private Sprite GetSprite(Entity entity)
	{
		return null;
	}

	// Token: 0x06000F57 RID: 3927 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000F57")]
	[Address(RVA = "0x3D2C50", Offset = "0x3D1E50", VA = "0x1803D2C50")]
	private Sprite GetSprite(ushort type)
	{
		return null;
	}

	// Token: 0x06000F58 RID: 3928 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F58")]
	[Address(RVA = "0x46D540", Offset = "0x46C740", VA = "0x18046D540")]
	private void UpdateTooltip(Vector2 screenPosition)
	{
	}

	// Token: 0x06000F59 RID: 3929 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F59")]
	[Address(RVA = "0x46D790", Offset = "0x46C990", VA = "0x18046D790")]
	public MapMinimap()
	{
	}

	// Token: 0x04000CAF RID: 3247
	[Token(Token = "0x4000CAF")]
	[FieldOffset(Offset = "0xC8")]
	public Menu Menu;

	// Token: 0x04000CB0 RID: 3248
	[Token(Token = "0x4000CB0")]
	[FieldOffset(Offset = "0xD0")]
	public Sprite AllySprite;

	// Token: 0x04000CB1 RID: 3249
	[Token(Token = "0x4000CB1")]
	[FieldOffset(Offset = "0xD8")]
	public Sprite MeSprite;

	// Token: 0x04000CB2 RID: 3250
	[Token(Token = "0x4000CB2")]
	[FieldOffset(Offset = "0xE0")]
	public PartyController Party;

	// Token: 0x04000CB3 RID: 3251
	[Token(Token = "0x4000CB3")]
	[FieldOffset(Offset = "0xE8")]
	public Compass Compass;

	// Token: 0x04000CB4 RID: 3252
	[Token(Token = "0x4000CB4")]
	[FieldOffset(Offset = "0xF0")]
	private Tooltip _playerTooltip;

	// Token: 0x04000CB5 RID: 3253
	[Token(Token = "0x4000CB5")]
	[FieldOffset(Offset = "0xF8")]
	private float _tooltipTime;

	// Token: 0x04000CB6 RID: 3254
	[Token(Token = "0x4000CB6")]
	[FieldOffset(Offset = "0xFC")]
	private uint _tooltipEntityId;
}
