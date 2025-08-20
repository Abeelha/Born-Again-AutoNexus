using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Ronin.Model.Data;
using TMPro;
using UnityEngine;

// Token: 0x020002D7 RID: 727
[Token(Token = "0x20002D7")]
public class PartyController : MonoBehaviour
{
	// Token: 0x170001C6 RID: 454
	// (get) Token: 0x06000FC1 RID: 4033 RVA: 0x000063A8 File Offset: 0x000045A8
	[Token(Token = "0x170001C6")]
	public bool IsLeader
	{
		[Token(Token = "0x6000FC1")]
		[Address(RVA = "0x353650", Offset = "0x352850", VA = "0x180353650")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170001C7 RID: 455
	// (get) Token: 0x06000FC2 RID: 4034 RVA: 0x000063C0 File Offset: 0x000045C0
	[Token(Token = "0x170001C7")]
	public bool InParty
	{
		[Token(Token = "0x6000FC2")]
		[Address(RVA = "0x3536B0", Offset = "0x3528B0", VA = "0x1803536B0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170001C8 RID: 456
	// (get) Token: 0x06000FC3 RID: 4035 RVA: 0x000063D8 File Offset: 0x000045D8
	[Token(Token = "0x170001C8")]
	public bool CanCreate
	{
		[Token(Token = "0x6000FC3")]
		[Address(RVA = "0x353640", Offset = "0x352840", VA = "0x180353640")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170001C9 RID: 457
	// (get) Token: 0x06000FC4 RID: 4036 RVA: 0x000063F0 File Offset: 0x000045F0
	[Token(Token = "0x170001C9")]
	public bool CanInvite
	{
		[Token(Token = "0x6000FC4")]
		[Address(RVA = "0x353650", Offset = "0x352850", VA = "0x180353650")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170001CA RID: 458
	// (get) Token: 0x06000FC5 RID: 4037 RVA: 0x00006408 File Offset: 0x00004608
	[Token(Token = "0x170001CA")]
	public bool CanKick
	{
		[Token(Token = "0x6000FC5")]
		[Address(RVA = "0x353650", Offset = "0x352850", VA = "0x180353650")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000FC6 RID: 4038 RVA: 0x00006420 File Offset: 0x00004620
	[Token(Token = "0x6000FC6")]
	[Address(RVA = "0x3531A0", Offset = "0x3523A0", VA = "0x1803531A0")]
	public bool EntityInParty(uint entityId)
	{
		return default(bool);
	}

	// Token: 0x06000FC7 RID: 4039 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FC7")]
	[Address(RVA = "0x353200", Offset = "0x352400", VA = "0x180353200")]
	public void HandleData(uint partyEntityId, ref PartyData data)
	{
	}

	// Token: 0x06000FC8 RID: 4040 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FC8")]
	[Address(RVA = "0x353130", Offset = "0x352330", VA = "0x180353130")]
	public void Hide()
	{
	}

	// Token: 0x06000FC9 RID: 4041 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FC9")]
	[Address(RVA = "0x353270", Offset = "0x352470", VA = "0x180353270")]
	public void Leave()
	{
	}

	// Token: 0x06000FCA RID: 4042 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FCA")]
	[Address(RVA = "0x3532C0", Offset = "0x3524C0", VA = "0x1803532C0")]
	public void LoadData()
	{
	}

	// Token: 0x06000FCB RID: 4043 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FCB")]
	[Address(RVA = "0x353130", Offset = "0x352330", VA = "0x180353130")]
	private void Awake()
	{
	}

	// Token: 0x06000FCC RID: 4044 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FCC")]
	[Address(RVA = "0x3535C0", Offset = "0x3527C0", VA = "0x1803535C0")]
	public PartyController()
	{
	}

	// Token: 0x04000D13 RID: 3347
	[Token(Token = "0x4000D13")]
	[FieldOffset(Offset = "0x20")]
	public uint EntityId;

	// Token: 0x04000D14 RID: 3348
	[Token(Token = "0x4000D14")]
	[FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI PartyLabel;

	// Token: 0x04000D15 RID: 3349
	[Token(Token = "0x4000D15")]
	[FieldOffset(Offset = "0x30")]
	public PartyMember[] PartyMembers;

	// Token: 0x04000D16 RID: 3350
	[Token(Token = "0x4000D16")]
	[FieldOffset(Offset = "0x38")]
	public World World;

	// Token: 0x04000D17 RID: 3351
	[Token(Token = "0x4000D17")]
	[FieldOffset(Offset = "0x40")]
	public GameObject SelfLeader;

	// Token: 0x04000D18 RID: 3352
	[Token(Token = "0x4000D18")]
	[FieldOffset(Offset = "0x48")]
	public GameObject OtherLeader;

	// Token: 0x04000D19 RID: 3353
	[Token(Token = "0x4000D19")]
	[FieldOffset(Offset = "0x50")]
	private PartyData _data;

	// Token: 0x04000D1A RID: 3354
	[Token(Token = "0x4000D1A")]
	[FieldOffset(Offset = "0xB8")]
	private readonly HashSet<uint> _partyMembers;
}
