using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002EB RID: 747
[Token(Token = "0x20002EB")]
public class IgnoreTab : MonoBehaviour
{
	// Token: 0x06001082 RID: 4226 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001082")]
	[Address(RVA = "0x34EA90", Offset = "0x34DC90", VA = "0x18034EA90")]
	public void Next()
	{
	}

	// Token: 0x06001083 RID: 4227 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001083")]
	[Address(RVA = "0x34EAC0", Offset = "0x34DCC0", VA = "0x18034EAC0")]
	public void Previous()
	{
	}

	// Token: 0x06001084 RID: 4228 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001084")]
	[Address(RVA = "0x34E850", Offset = "0x34DA50", VA = "0x18034E850")]
	private void Clear(int startIndex, int count)
	{
	}

	// Token: 0x06001085 RID: 4229 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001085")]
	[Address(RVA = "0x34FEB0", Offset = "0x34F0B0", VA = "0x18034FEB0")]
	private void LateUpdate()
	{
	}

	// Token: 0x06001086 RID: 4230 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001086")]
	[Address(RVA = "0x34FEC0", Offset = "0x34F0C0", VA = "0x18034FEC0")]
	private void UpdateList()
	{
	}

	// Token: 0x06001087 RID: 4231 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001087")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public IgnoreTab()
	{
	}

	// Token: 0x04000DCC RID: 3532
	[Token(Token = "0x4000DCC")]
	[FieldOffset(Offset = "0x20")]
	public PlayerListing[] PlayerListings;

	// Token: 0x04000DCD RID: 3533
	[Token(Token = "0x4000DCD")]
	[FieldOffset(Offset = "0x28")]
	public GameObject EmptyLabel;

	// Token: 0x04000DCE RID: 3534
	[Token(Token = "0x4000DCE")]
	[FieldOffset(Offset = "0x30")]
	public GameObject PreviousButton;

	// Token: 0x04000DCF RID: 3535
	[Token(Token = "0x4000DCF")]
	[FieldOffset(Offset = "0x38")]
	public GameObject NextButton;

	// Token: 0x04000DD0 RID: 3536
	[Token(Token = "0x4000DD0")]
	[FieldOffset(Offset = "0x40")]
	public World World;

	// Token: 0x04000DD1 RID: 3537
	[Token(Token = "0x4000DD1")]
	[FieldOffset(Offset = "0x48")]
	public int Offset;
}
