using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000190 RID: 400
[Token(Token = "0x2000190")]
public class HideUI : MonoBehaviour
{
	// Token: 0x0600081C RID: 2076 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600081C")]
	[Address(RVA = "0x413AD0", Offset = "0x412CD0", VA = "0x180413AD0")]
	private void Awake()
	{
	}

	// Token: 0x0600081D RID: 2077 RVA: 0x00004098 File Offset: 0x00002298
	[Token(Token = "0x600081D")]
	[Address(RVA = "0x413B50", Offset = "0x412D50", VA = "0x180413B50")]
	private bool GetIsHidden()
	{
		return default(bool);
	}

	// Token: 0x0600081E RID: 2078 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600081E")]
	[Address(RVA = "0x413C30", Offset = "0x412E30", VA = "0x180413C30")]
	private void LateUpdate()
	{
	}

	// Token: 0x0600081F RID: 2079 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600081F")]
	[Address(RVA = "0x413D60", Offset = "0x412F60", VA = "0x180413D60")]
	private void SetHidden(bool hidden)
	{
	}

	// Token: 0x06000820 RID: 2080 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000820")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public HideUI()
	{
	}

	// Token: 0x040007EC RID: 2028
	[Token(Token = "0x40007EC")]
	[FieldOffset(Offset = "0x20")]
	public TutorialNotificationManager TutorialNotificationManager;

	// Token: 0x040007ED RID: 2029
	[Token(Token = "0x40007ED")]
	[FieldOffset(Offset = "0x28")]
	public GameObject[] UI;

	// Token: 0x040007EE RID: 2030
	[Token(Token = "0x40007EE")]
	[FieldOffset(Offset = "0x30")]
	private Option _hideOption;

	// Token: 0x040007EF RID: 2031
	[Token(Token = "0x40007EF")]
	[FieldOffset(Offset = "0x38")]
	private Option _cinematicModeOption;

	// Token: 0x040007F0 RID: 2032
	[Token(Token = "0x40007F0")]
	[FieldOffset(Offset = "0x40")]
	private bool _hidden;
}
