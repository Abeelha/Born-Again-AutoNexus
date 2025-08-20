using System;
using Il2CppDummyDll;
using Ronin.Api.Model.Character;
using UnityEngine;

// Token: 0x02000106 RID: 262
[Token(Token = "0x2000106")]
public class DeathDisplay : MonoBehaviour
{
	// Token: 0x06000473 RID: 1139 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000473")]
	[Address(RVA = "0x3D4480", Offset = "0x3D3680", VA = "0x1803D4480")]
	public void Setup(int index, string name, GetCharacterResponse character)
	{
	}

	// Token: 0x06000474 RID: 1140 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000474")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public DeathDisplay()
	{
	}

	// Token: 0x040004C4 RID: 1220
	[Token(Token = "0x40004C4")]
	[FieldOffset(Offset = "0x20")]
	public string Name;

	// Token: 0x040004C5 RID: 1221
	[Token(Token = "0x40004C5")]
	[FieldOffset(Offset = "0x28")]
	public GetCharacterResponse Character;

	// Token: 0x040004C6 RID: 1222
	[Token(Token = "0x40004C6")]
	[FieldOffset(Offset = "0x30")]
	public DeathScroll Scroll;
}
