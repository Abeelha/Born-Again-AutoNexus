using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001CC RID: 460
[Token(Token = "0x20001CC")]
public class DeviceOnly : MonoBehaviour
{
	// Token: 0x06000948 RID: 2376 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000948")]
	[Address(RVA = "0x424820", Offset = "0x423A20", VA = "0x180424820")]
	private void Awake()
	{
	}

	// Token: 0x06000949 RID: 2377 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000949")]
	[Address(RVA = "0x424820", Offset = "0x423A20", VA = "0x180424820")]
	private void UpdateActive()
	{
	}

	// Token: 0x0600094A RID: 2378 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600094A")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public DeviceOnly()
	{
	}

	// Token: 0x040008CD RID: 2253
	[Token(Token = "0x40008CD")]
	[FieldOffset(Offset = "0x20")]
	public DeviceType TargetDeviceType;

	// Token: 0x040008CE RID: 2254
	[Token(Token = "0x40008CE")]
	[FieldOffset(Offset = "0x28")]
	public GameObject[] GameObjects;

	// Token: 0x040008CF RID: 2255
	[Token(Token = "0x40008CF")]
	[FieldOffset(Offset = "0x30")]
	private DeviceType? _syncedSessionDeviceType;

	// Token: 0x040008D0 RID: 2256
	[Token(Token = "0x40008D0")]
	[FieldOffset(Offset = "0x38")]
	private DeviceType? _syncedTargetDeviceType;
}
