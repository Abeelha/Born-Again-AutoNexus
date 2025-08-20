using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020002D3 RID: 723
[Token(Token = "0x20002D3")]
public class MobileBattery : MonoBehaviour
{
	// Token: 0x06000F9F RID: 3999 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F9F")]
	[Address(RVA = "0x3518E0", Offset = "0x350AE0", VA = "0x1803518E0")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000FA0 RID: 4000 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FA0")]
	[Address(RVA = "0x3518F0", Offset = "0x350AF0", VA = "0x1803518F0")]
	private void UpdateBattery()
	{
	}

	// Token: 0x06000FA1 RID: 4001 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FA1")]
	[Address(RVA = "0x351B20", Offset = "0x350D20", VA = "0x180351B20")]
	public MobileBattery()
	{
	}

	// Token: 0x04000CE8 RID: 3304
	[Token(Token = "0x4000CE8")]
	[FieldOffset(Offset = "0x20")]
	public Sprite[] Sprites;

	// Token: 0x04000CE9 RID: 3305
	[Token(Token = "0x4000CE9")]
	[FieldOffset(Offset = "0x28")]
	public Image BatteryImage;

	// Token: 0x04000CEA RID: 3306
	[Token(Token = "0x4000CEA")]
	[FieldOffset(Offset = "0x30")]
	public Image ChargingImage;

	// Token: 0x04000CEB RID: 3307
	[Token(Token = "0x4000CEB")]
	[FieldOffset(Offset = "0x38")]
	public TextMeshProUGUI PercentageLabel;

	// Token: 0x04000CEC RID: 3308
	[Token(Token = "0x4000CEC")]
	[FieldOffset(Offset = "0x40")]
	private float _batteryLevel;
}
