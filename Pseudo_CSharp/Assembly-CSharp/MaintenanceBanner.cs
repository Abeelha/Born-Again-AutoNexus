using System;
using Il2CppDummyDll;
using Ronin.Model.Data;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020002B7 RID: 695
[Token(Token = "0x20002B7")]
public class MaintenanceBanner : MonoBehaviour
{
	// Token: 0x06000EE7 RID: 3815 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EE7")]
	[Address(RVA = "0x46C030", Offset = "0x46B230", VA = "0x18046C030")]
	public void Clear()
	{
	}

	// Token: 0x06000EE8 RID: 3816 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EE8")]
	[Address(RVA = "0x46C0F0", Offset = "0x46B2F0", VA = "0x18046C0F0")]
	public void HandleData(ref MaintenanceData data)
	{
	}

	// Token: 0x06000EE9 RID: 3817 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EE9")]
	[Address(RVA = "0x46C160", Offset = "0x46B360", VA = "0x18046C160")]
	public void LanguageChanged()
	{
	}

	// Token: 0x06000EEA RID: 3818 RVA: 0x00006000 File Offset: 0x00004200
	[Token(Token = "0x6000EEA")]
	[Address(RVA = "0x46C060", Offset = "0x46B260", VA = "0x18046C060")]
	private static TimeSpan GetRemainingTime(long epochUtc)
	{
		return default(TimeSpan);
	}

	// Token: 0x06000EEB RID: 3819 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EEB")]
	[Address(RVA = "0x46C170", Offset = "0x46B370", VA = "0x18046C170")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000EEC RID: 3820 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EEC")]
	[Address(RVA = "0x46C180", Offset = "0x46B380", VA = "0x18046C180")]
	private void UpdateLabel(bool force = false)
	{
	}

	// Token: 0x06000EED RID: 3821 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EED")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public MaintenanceBanner()
	{
	}

	// Token: 0x04000C47 RID: 3143
	[Token(Token = "0x4000C47")]
	[FieldOffset(Offset = "0x20")]
	public Image Banner;

	// Token: 0x04000C48 RID: 3144
	[Token(Token = "0x4000C48")]
	[FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI Label;

	// Token: 0x04000C49 RID: 3145
	[Token(Token = "0x4000C49")]
	[FieldOffset(Offset = "0x30")]
	public Color BannerColorWarning;

	// Token: 0x04000C4A RID: 3146
	[Token(Token = "0x4000C4A")]
	[FieldOffset(Offset = "0x40")]
	public Color LabelColorWarning;

	// Token: 0x04000C4B RID: 3147
	[Token(Token = "0x4000C4B")]
	[FieldOffset(Offset = "0x50")]
	public Color BannerColorNow;

	// Token: 0x04000C4C RID: 3148
	[Token(Token = "0x4000C4C")]
	[FieldOffset(Offset = "0x60")]
	public Color LabelColorNow;

	// Token: 0x04000C4D RID: 3149
	[Token(Token = "0x4000C4D")]
	[FieldOffset(Offset = "0x70")]
	private MaintenanceData? _data;

	// Token: 0x04000C4E RID: 3150
	[Token(Token = "0x4000C4E")]
	[FieldOffset(Offset = "0x80")]
	private TimeSpan _remainingTime;
}
