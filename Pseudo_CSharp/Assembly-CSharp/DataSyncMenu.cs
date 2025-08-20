using System;
using System.Threading.Tasks;
using Il2CppDummyDll;
using Ronin.Api.Model.Hello;
using UnityEngine;
using UnnamedStudios.Common.Model;

// Token: 0x02000102 RID: 258
[Token(Token = "0x2000102")]
public class DataSyncMenu : Menu
{
	// Token: 0x06000466 RID: 1126 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000466")]
	[Address(RVA = "0x3D3C80", Offset = "0x3D2E80", VA = "0x1803D3C80", Slot = "5")]
	protected override void OnEnter()
	{
	}

	// Token: 0x06000467 RID: 1127 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000467")]
	[Address(RVA = "0x3D3A80", Offset = "0x3D2C80", VA = "0x1803D3A80")]
	private void MoveToNextMenu()
	{
	}

	// Token: 0x06000468 RID: 1128 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000468")]
	[Address(RVA = "0x3D3EB0", Offset = "0x3D30B0", VA = "0x1803D3EB0")]
	private void Setup()
	{
	}

	// Token: 0x06000469 RID: 1129 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000469")]
	[Address(RVA = "0x3D3CA0", Offset = "0x3D2EA0", VA = "0x1803D3CA0")]
	private Task SetupAsync()
	{
		return null;
	}

	// Token: 0x0600046A RID: 1130 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600046A")]
	[Address(RVA = "0x3D3D90", Offset = "0x3D2F90", VA = "0x1803D3D90")]
	private Task<ServiceResponse> SetupDataAsync(HelloResponse helloResponse)
	{
		return null;
	}

	// Token: 0x0600046B RID: 1131 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600046B")]
	[Address(RVA = "0x3BC980", Offset = "0x3BBB80", VA = "0x1803BC980")]
	public DataSyncMenu()
	{
	}

	// Token: 0x040004A8 RID: 1192
	[Token(Token = "0x40004A8")]
	[FieldOffset(Offset = "0x90")]
	public Menu NextMenu;

	// Token: 0x040004A9 RID: 1193
	[Token(Token = "0x40004A9")]
	[FieldOffset(Offset = "0x98")]
	public World World;

	// Token: 0x040004AA RID: 1194
	[Token(Token = "0x40004AA")]
	[FieldOffset(Offset = "0xA0")]
	public WorldCameraLerper WorldCameraLerper;

	// Token: 0x040004AB RID: 1195
	[Token(Token = "0x40004AB")]
	[FieldOffset(Offset = "0xA8")]
	public Transform GameCamera;

	// Token: 0x040004AC RID: 1196
	[Token(Token = "0x40004AC")]
	[FieldOffset(Offset = "0xB0")]
	private string _initiateServices;

	// Token: 0x040004AD RID: 1197
	[Token(Token = "0x40004AD")]
	[FieldOffset(Offset = "0xB8")]
	private string _maintenance;

	// Token: 0x040004AE RID: 1198
	[Token(Token = "0x40004AE")]
	[FieldOffset(Offset = "0xC0")]
	private string _maintenanceLonger;

	// Token: 0x040004AF RID: 1199
	[Token(Token = "0x40004AF")]
	[FieldOffset(Offset = "0xC8")]
	private string _updateVersion;

	// Token: 0x040004B0 RID: 1200
	[Token(Token = "0x40004B0")]
	[FieldOffset(Offset = "0xD0")]
	private string _loadingData;
}
