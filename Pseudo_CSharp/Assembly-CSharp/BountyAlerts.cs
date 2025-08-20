using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x0200029B RID: 667
[Token(Token = "0x200029B")]
public class BountyAlerts : MonoBehaviour
{
	// Token: 0x06000E4F RID: 3663 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E4F")]
	[Address(RVA = "0x44FCF0", Offset = "0x44EEF0", VA = "0x18044FCF0")]
	public void Alert(int amount)
	{
	}

	// Token: 0x06000E50 RID: 3664 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000E50")]
	[Address(RVA = "0x44FCF0", Offset = "0x44EEF0", VA = "0x18044FCF0")]
	private Task AlertAsync(int amount)
	{
		return null;
	}

	// Token: 0x06000E51 RID: 3665 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E51")]
	[Address(RVA = "0x44FDE0", Offset = "0x44EFE0", VA = "0x18044FDE0")]
	private void Awake()
	{
	}

	// Token: 0x06000E52 RID: 3666 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000E52")]
	[Address(RVA = "0x44FE10", Offset = "0x44F010", VA = "0x18044FE10")]
	private TextMeshProUGUI GetAlert()
	{
		return null;
	}

	// Token: 0x06000E53 RID: 3667 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E53")]
	[Address(RVA = "0x44FFE0", Offset = "0x44F1E0", VA = "0x18044FFE0")]
	private void ReturnAlert(TextMeshProUGUI alert)
	{
	}

	// Token: 0x06000E54 RID: 3668 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E54")]
	[Address(RVA = "0x4500C0", Offset = "0x44F2C0", VA = "0x1804500C0")]
	public BountyAlerts()
	{
	}

	// Token: 0x04000B99 RID: 2969
	[Token(Token = "0x4000B99")]
	[FieldOffset(Offset = "0x20")]
	private readonly List<TextMeshProUGUI> _alerts;

	// Token: 0x04000B9A RID: 2970
	[Token(Token = "0x4000B9A")]
	[FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI AlertPrefab;
}
