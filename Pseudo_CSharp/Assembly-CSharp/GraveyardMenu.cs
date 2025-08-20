using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using Ronin.Api.Model.Character;
using Ronin.Api.Model.Graveyard;
using UnityEngine;

// Token: 0x0200010C RID: 268
[Token(Token = "0x200010C")]
public class GraveyardMenu : GalleryMenu
{
	// Token: 0x17000055 RID: 85
	// (get) Token: 0x0600048D RID: 1165 RVA: 0x000033D8 File Offset: 0x000015D8
	[Token(Token = "0x17000055")]
	private long NextPageId
	{
		[Token(Token = "0x600048D")]
		[Address(RVA = "0x3D6460", Offset = "0x3D5660", VA = "0x1803D6460")]
		get
		{
			return 0L;
		}
	}

	// Token: 0x0600048E RID: 1166 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600048E")]
	[Address(RVA = "0x3BD8B0", Offset = "0x3BCAB0", VA = "0x1803BD8B0", Slot = "9")]
	public override void Back()
	{
	}

	// Token: 0x0600048F RID: 1167 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600048F")]
	[Address(RVA = "0x3D51A0", Offset = "0x3D43A0", VA = "0x1803D51A0")]
	public void LanguageChanged()
	{
	}

	// Token: 0x06000490 RID: 1168 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000490")]
	[Address(RVA = "0x3D5730", Offset = "0x3D4930", VA = "0x1803D5730", Slot = "11")]
	protected override void LoadItems()
	{
	}

	// Token: 0x06000491 RID: 1169 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000491")]
	[Address(RVA = "0x3D5AD0", Offset = "0x3D4CD0", VA = "0x1803D5AD0", Slot = "5")]
	protected override void OnEnter()
	{
	}

	// Token: 0x06000492 RID: 1170 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000492")]
	[Address(RVA = "0x3D5240", Offset = "0x3D4440", VA = "0x1803D5240")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000493 RID: 1171 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000493")]
	[Address(RVA = "0x3D5550", Offset = "0x3D4750", VA = "0x1803D5550")]
	private void LoadGraveyard([Optional] long? pageId)
	{
	}

	// Token: 0x06000494 RID: 1172 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000494")]
	[Address(RVA = "0x3D5460", Offset = "0x3D4660", VA = "0x1803D5460")]
	private Task LoadGraveyardAsync(long nextPageId)
	{
		return null;
	}

	// Token: 0x06000495 RID: 1173 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000495")]
	[Address(RVA = "0x3D5B30", Offset = "0x3D4D30", VA = "0x1803D5B30")]
	private void PageNext()
	{
	}

	// Token: 0x06000496 RID: 1174 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000496")]
	[Address(RVA = "0x3D5B50", Offset = "0x3D4D50", VA = "0x1803D5B50")]
	private void PagePrevious()
	{
	}

	// Token: 0x06000497 RID: 1175 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000497")]
	[Address(RVA = "0x3D5C70", Offset = "0x3D4E70", VA = "0x1803D5C70")]
	private void SetupGraveyard(GetGraveyardResponse graveyard, [Optional] int? selectIndex)
	{
	}

	// Token: 0x06000498 RID: 1176 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000498")]
	[Address(RVA = "0x3D5DA0", Offset = "0x3D4FA0", VA = "0x1803D5DA0")]
	private void StoreGraveyard(long nextPageId, GetGraveyardResponse graveyard)
	{
	}

	// Token: 0x06000499 RID: 1177 RVA: 0x000033F0 File Offset: 0x000015F0
	[Token(Token = "0x6000499")]
	[Address(RVA = "0x3D6120", Offset = "0x3D5320", VA = "0x1803D6120")]
	private bool TryGetCachedGraveyard(long pageId, out GetGraveyardResponse graveyard)
	{
		return default(bool);
	}

	// Token: 0x0600049A RID: 1178 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600049A")]
	[Address(RVA = "0x3D6340", Offset = "0x3D5540", VA = "0x1803D6340")]
	public GraveyardMenu()
	{
	}

	// Token: 0x040004DB RID: 1243
	[Token(Token = "0x40004DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private readonly Dictionary<long, GetCharacterResponse> s_deathCache;

	// Token: 0x040004DC RID: 1244
	[Token(Token = "0x40004DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private readonly Dictionary<long, long?> s_deathChain;

	// Token: 0x040004DD RID: 1245
	[Token(Token = "0x40004DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private readonly Dictionary<long, long> s_deathChainBack;

	// Token: 0x040004DE RID: 1246
	[Token(Token = "0x40004DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public DeathDisplay DeathDisplayPrefab;

	// Token: 0x040004DF RID: 1247
	[Token(Token = "0x40004DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public GameObject NoDataLabel;

	// Token: 0x040004E0 RID: 1248
	[Token(Token = "0x40004E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public DeathNavigationDisplay PreviousDisplay;

	// Token: 0x040004E1 RID: 1249
	[Token(Token = "0x40004E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public DeathNavigationDisplay NextDisplay;

	// Token: 0x040004E2 RID: 1250
	[Token(Token = "0x40004E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private long s_firstPageId;

	// Token: 0x040004E3 RID: 1251
	[Token(Token = "0x40004E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private GetGraveyardResponse _graveyard;

	// Token: 0x040004E4 RID: 1252
	[Token(Token = "0x40004E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private Task _loadTask;

	// Token: 0x040004E5 RID: 1253
	[Token(Token = "0x40004E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private bool _wasPrevious;
}
