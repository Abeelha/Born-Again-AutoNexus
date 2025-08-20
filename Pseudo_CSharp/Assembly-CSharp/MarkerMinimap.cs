using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020002CC RID: 716
[Token(Token = "0x20002CC")]
public abstract class MarkerMinimap : Minimap
{
	// Token: 0x170001B7 RID: 439
	// (get) Token: 0x06000F60 RID: 3936 RVA: 0x00006180 File Offset: 0x00004380
	[Token(Token = "0x170001B7")]
	protected virtual float MarkerScale
	{
		[Token(Token = "0x6000F60")]
		[Address(RVA = "0x46EA20", Offset = "0x46DC20", VA = "0x18046EA20", Slot = "10")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x06000F61 RID: 3937 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F61")]
	[Address(RVA = "0x46D810", Offset = "0x46CA10", VA = "0x18046D810", Slot = "7")]
	protected override void Awake()
	{
	}

	// Token: 0x06000F62 RID: 3938
	[Token(Token = "0x6000F62")]
	protected abstract IEnumerable<ValueTuple<Entity, Sprite, Vector2, bool, int>> GetMarkers();

	// Token: 0x06000F63 RID: 3939 RVA: 0x00006198 File Offset: 0x00004398
	[Token(Token = "0x6000F63")]
	[Address(RVA = "0x46DA90", Offset = "0x46CC90", VA = "0x18046DA90")]
	protected ValueTuple<Image, Entity> GetNearestMarker(Vector2 screenPosition, int? prefabIndex)
	{
		return default(ValueTuple<Image, Entity>);
	}

	// Token: 0x06000F64 RID: 3940 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F64")]
	[Address(RVA = "0x46DF50", Offset = "0x46D150", VA = "0x18046DF50", Slot = "8")]
	protected override void LateUpdate()
	{
	}

	// Token: 0x06000F65 RID: 3941 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F65")]
	[Address(RVA = "0x46E070", Offset = "0x46D270", VA = "0x18046E070")]
	private void UpdateMarkers()
	{
	}

	// Token: 0x06000F66 RID: 3942 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F66")]
	[Address(RVA = "0x46E8A0", Offset = "0x46DAA0", VA = "0x18046E8A0")]
	protected MarkerMinimap()
	{
	}

	// Token: 0x04000CB9 RID: 3257
	[Token(Token = "0x4000CB9")]
	[FieldOffset(Offset = "0xA8")]
	public Image[] MarkerPrefabs;

	// Token: 0x04000CBA RID: 3258
	[Token(Token = "0x4000CBA")]
	[FieldOffset(Offset = "0xB0")]
	private int[] _markerIndices;

	// Token: 0x04000CBB RID: 3259
	[Token(Token = "0x4000CBB")]
	[FieldOffset(Offset = "0xB8")]
	private List<Image>[] _markerCaches;

	// Token: 0x04000CBC RID: 3260
	[Token(Token = "0x4000CBC")]
	[FieldOffset(Offset = "0xC0")]
	private readonly List<ValueTuple<Image, Entity, int>> _markers;
}
