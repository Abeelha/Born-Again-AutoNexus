using System;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002E7 RID: 743
[Token(Token = "0x20002E7")]
public class FriendsTab : MonoBehaviour
{
	// Token: 0x06001065 RID: 4197 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001065")]
	[Address(RVA = "0x34EA90", Offset = "0x34DC90", VA = "0x18034EA90")]
	public void Next()
	{
	}

	// Token: 0x06001066 RID: 4198 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001066")]
	[Address(RVA = "0x34EAC0", Offset = "0x34DCC0", VA = "0x18034EAC0")]
	public void Previous()
	{
	}

	// Token: 0x06001067 RID: 4199 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001067")]
	[Address(RVA = "0x34EBC0", Offset = "0x34DDC0", VA = "0x18034EBC0")]
	public void Refresh()
	{
	}

	// Token: 0x06001068 RID: 4200 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001068")]
	[Address(RVA = "0x34E850", Offset = "0x34DA50", VA = "0x18034E850")]
	private void Clear(int startIndex, int count)
	{
	}

	// Token: 0x06001069 RID: 4201 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001069")]
	[Address(RVA = "0x34E960", Offset = "0x34DB60", VA = "0x18034E960")]
	private void LateUpdate()
	{
	}

	// Token: 0x0600106A RID: 4202 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600106A")]
	[Address(RVA = "0x34EE00", Offset = "0x34E000", VA = "0x18034EE00")]
	private void UpdateList()
	{
	}

	// Token: 0x0600106B RID: 4203 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600106B")]
	[Address(RVA = "0x34F4A0", Offset = "0x34E6A0", VA = "0x18034F4A0")]
	private void UpdateStatuses()
	{
	}

	// Token: 0x0600106C RID: 4204 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600106C")]
	[Address(RVA = "0x34EAF0", Offset = "0x34DCF0", VA = "0x18034EAF0")]
	private Task RefreshStatusAsync()
	{
		return null;
	}

	// Token: 0x0600106D RID: 4205 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600106D")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public FriendsTab()
	{
	}

	// Token: 0x04000DB5 RID: 3509
	[Token(Token = "0x4000DB5")]
	[FieldOffset(Offset = "0x20")]
	public PlayerListing[] PlayerListings;

	// Token: 0x04000DB6 RID: 3510
	[Token(Token = "0x4000DB6")]
	[FieldOffset(Offset = "0x28")]
	public GameObject EmptyLabel;

	// Token: 0x04000DB7 RID: 3511
	[Token(Token = "0x4000DB7")]
	[FieldOffset(Offset = "0x30")]
	public GameObject PreviousButton;

	// Token: 0x04000DB8 RID: 3512
	[Token(Token = "0x4000DB8")]
	[FieldOffset(Offset = "0x38")]
	public GameObject NextButton;

	// Token: 0x04000DB9 RID: 3513
	[Token(Token = "0x4000DB9")]
	[FieldOffset(Offset = "0x40")]
	public World World;

	// Token: 0x04000DBA RID: 3514
	[Token(Token = "0x4000DBA")]
	[FieldOffset(Offset = "0x48")]
	public int Offset;

	// Token: 0x04000DBB RID: 3515
	[Token(Token = "0x4000DBB")]
	[FieldOffset(Offset = "0x4C")]
	private bool _updatingStatus;
}
