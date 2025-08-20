using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200003A RID: 58
[Token(Token = "0x200003A")]
[ExecuteInEditMode]
public class SessionOverride : MonoBehaviour
{
	// Token: 0x06000134 RID: 308 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000134")]
	[Address(RVA = "0x328FA0", Offset = "0x3281A0", VA = "0x180328FA0")]
	private void Awake()
	{
	}

	// Token: 0x06000135 RID: 309 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000135")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public SessionOverride()
	{
	}

	// Token: 0x04000111 RID: 273
	[Token(Token = "0x4000111")]
	[FieldOffset(Offset = "0x20")]
	public bool OverrideDeviceType;

	// Token: 0x04000112 RID: 274
	[Token(Token = "0x4000112")]
	[FieldOffset(Offset = "0x24")]
	public DeviceType DeviceType;

	// Token: 0x04000113 RID: 275
	[Token(Token = "0x4000113")]
	[FieldOffset(Offset = "0x28")]
	public bool OverrideSafeArea;

	// Token: 0x04000114 RID: 276
	[Token(Token = "0x4000114")]
	[FieldOffset(Offset = "0x2C")]
	public Rect SafeArea;
}
