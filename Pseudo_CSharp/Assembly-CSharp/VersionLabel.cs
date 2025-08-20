using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x0200003D RID: 61
[Token(Token = "0x200003D")]
[ExecuteInEditMode]
public class VersionLabel : MonoBehaviour
{
	// Token: 0x0600013B RID: 315 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600013B")]
	[Address(RVA = "0x32FCE0", Offset = "0x32EEE0", VA = "0x18032FCE0")]
	private void Awake()
	{
	}

	// Token: 0x0600013C RID: 316 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600013C")]
	[Address(RVA = "0x32FE90", Offset = "0x32F090", VA = "0x18032FE90")]
	private string GetEnvironmentLabel()
	{
		return null;
	}

	// Token: 0x0600013D RID: 317 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600013D")]
	[Address(RVA = "0x32FEC0", Offset = "0x32F0C0", VA = "0x18032FEC0")]
	private void UpdateLabel()
	{
	}

	// Token: 0x0600013E RID: 318 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600013E")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public VersionLabel()
	{
	}

	// Token: 0x0400011C RID: 284
	[Token(Token = "0x400011C")]
	[FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI Label;
}
