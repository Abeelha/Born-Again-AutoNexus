using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002D0 RID: 720
[Token(Token = "0x20002D0")]
public class TravelMinimap : MarkerMinimap
{
	// Token: 0x170001BF RID: 447
	// (get) Token: 0x06000F8C RID: 3980 RVA: 0x000062B8 File Offset: 0x000044B8
	[Token(Token = "0x170001BF")]
	protected override float MarkerScale
	{
		[Token(Token = "0x6000F8C")]
		[Address(RVA = "0x475790", Offset = "0x474990", VA = "0x180475790", Slot = "10")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x06000F8D RID: 3981 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F8D")]
	[Address(RVA = "0x4755E0", Offset = "0x4747E0", VA = "0x1804755E0")]
	public void Select(RectTransform transform)
	{
	}

	// Token: 0x06000F8E RID: 3982 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F8E")]
	[Address(RVA = "0x4756D0", Offset = "0x4748D0", VA = "0x1804756D0")]
	public void Setup(uint entityId)
	{
	}

	// Token: 0x06000F8F RID: 3983 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000F8F")]
	[Address(RVA = "0x475390", Offset = "0x474590", VA = "0x180475390", Slot = "11")]
	protected override IEnumerable<ValueTuple<Entity, Sprite, Vector2, bool, int>> GetMarkers()
	{
		return null;
	}

	// Token: 0x06000F90 RID: 3984 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000F90")]
	[Address(RVA = "0x475240", Offset = "0x474440", VA = "0x180475240")]
	private IEnumerable<ValueTuple<ushort, Vector2Int>> GetAvailableTravelLocations()
	{
		return null;
	}

	// Token: 0x06000F91 RID: 3985 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000F91")]
	[Address(RVA = "0x3D2C50", Offset = "0x3D1E50", VA = "0x1803D2C50")]
	private Sprite GetSprite(ushort type)
	{
		return null;
	}

	// Token: 0x06000F92 RID: 3986 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F92")]
	[Address(RVA = "0x475540", Offset = "0x474740", VA = "0x180475540", Slot = "8")]
	protected override void LateUpdate()
	{
	}

	// Token: 0x06000F93 RID: 3987 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F93")]
	[Address(RVA = "0x4755B0", Offset = "0x4747B0", VA = "0x1804755B0")]
	private void OnEnable()
	{
	}

	// Token: 0x06000F94 RID: 3988 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F94")]
	[Address(RVA = "0x46D790", Offset = "0x46C990", VA = "0x18046D790")]
	public TravelMinimap()
	{
	}

	// Token: 0x04000CD8 RID: 3288
	[Token(Token = "0x4000CD8")]
	[FieldOffset(Offset = "0xC8")]
	public Menu Menu;

	// Token: 0x04000CD9 RID: 3289
	[Token(Token = "0x4000CD9")]
	[FieldOffset(Offset = "0xD0")]
	private uint _entityId;
}
