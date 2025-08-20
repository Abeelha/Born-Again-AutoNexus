using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x020002AB RID: 683
[Token(Token = "0x20002AB")]
public class Coordinates : MonoBehaviour
{
	// Token: 0x06000EA9 RID: 3753 RVA: 0x00005F70 File Offset: 0x00004170
	[Token(Token = "0x6000EA9")]
	[Address(RVA = "0x468BC0", Offset = "0x467DC0", VA = "0x180468BC0")]
	private Vector2Int? GetCoordinates()
	{
		return null;
	}

	// Token: 0x06000EAA RID: 3754 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EAA")]
	[Address(RVA = "0x468D80", Offset = "0x467F80", VA = "0x180468D80")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000EAB RID: 3755 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EAB")]
	[Address(RVA = "0x468D90", Offset = "0x467F90", VA = "0x180468D90")]
	private void UpdateCoordinates()
	{
	}

	// Token: 0x06000EAC RID: 3756 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EAC")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public Coordinates()
	{
	}

	// Token: 0x04000BEE RID: 3054
	[Token(Token = "0x4000BEE")]
	[FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI Label;

	// Token: 0x04000BEF RID: 3055
	[Token(Token = "0x4000BEF")]
	[FieldOffset(Offset = "0x28")]
	public World World;

	// Token: 0x04000BF0 RID: 3056
	[Token(Token = "0x4000BF0")]
	[FieldOffset(Offset = "0x30")]
	private Vector2Int? _coordinates;
}
