using System;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000100 RID: 256
[Token(Token = "0x2000100")]
public class CreditsMenu : Menu
{
	// Token: 0x06000460 RID: 1120 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000460")]
	[Address(RVA = "0x3D3A90", Offset = "0x3D2C90", VA = "0x1803D3A90", Slot = "5")]
	protected override void OnEnter()
	{
	}

	// Token: 0x06000461 RID: 1121 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000461")]
	[Address(RVA = "0x3D3A80", Offset = "0x3D2C80", VA = "0x1803D3A80")]
	private void MoveToNextMenu()
	{
	}

	// Token: 0x06000462 RID: 1122 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000462")]
	[Address(RVA = "0x3D3B70", Offset = "0x3D2D70", VA = "0x1803D3B70")]
	private Task RunCreditsAsync()
	{
		return null;
	}

	// Token: 0x06000463 RID: 1123 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000463")]
	[Address(RVA = "0x3D3C50", Offset = "0x3D2E50", VA = "0x1803D3C50")]
	public CreditsMenu()
	{
	}

	// Token: 0x04000499 RID: 1177
	[Token(Token = "0x4000499")]
	[FieldOffset(Offset = "0x90")]
	public Menu NextMenu;

	// Token: 0x0400049A RID: 1178
	[Token(Token = "0x400049A")]
	[FieldOffset(Offset = "0x98")]
	public Image WorldShade;

	// Token: 0x0400049B RID: 1179
	[Token(Token = "0x400049B")]
	[FieldOffset(Offset = "0xA0")]
	public GameObject[] Graphics;

	// Token: 0x0400049C RID: 1180
	[Token(Token = "0x400049C")]
	[FieldOffset(Offset = "0xA8")]
	public float FadeDuration;

	// Token: 0x0400049D RID: 1181
	[Token(Token = "0x400049D")]
	[FieldOffset(Offset = "0xAC")]
	public float BetweenDuration;

	// Token: 0x0400049E RID: 1182
	[Token(Token = "0x400049E")]
	[FieldOffset(Offset = "0xB0")]
	public float HoldDuration;

	// Token: 0x0400049F RID: 1183
	[Token(Token = "0x400049F")]
	[FieldOffset(Offset = "0xB4")]
	public float WorldShadeAlpha;
}
