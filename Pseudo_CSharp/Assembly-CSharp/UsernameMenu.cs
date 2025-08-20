using System;
using System.Threading.Tasks;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnnamedStudios.Common.Model;

// Token: 0x02000133 RID: 307
[Token(Token = "0x2000133")]
public class UsernameMenu : Menu
{
	// Token: 0x17000061 RID: 97
	// (get) Token: 0x06000557 RID: 1367 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x17000061")]
	public string Username
	{
		[Token(Token = "0x6000557")]
		[Address(RVA = "0x3EAA20", Offset = "0x3E9C20", VA = "0x1803EAA20")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000558 RID: 1368 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000558")]
	[Address(RVA = "0x3BD8B0", Offset = "0x3BCAB0", VA = "0x1803BD8B0")]
	public void Back()
	{
	}

	// Token: 0x06000559 RID: 1369 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000559")]
	[Address(RVA = "0x3EA170", Offset = "0x3E9370", VA = "0x1803EA170")]
	public void Submit()
	{
	}

	// Token: 0x0600055A RID: 1370 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600055A")]
	[Address(RVA = "0x3E9EE0", Offset = "0x3E90E0", VA = "0x1803E9EE0", Slot = "5")]
	protected override void OnEnter()
	{
	}

	// Token: 0x0600055B RID: 1371 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600055B")]
	[Address(RVA = "0x3EA660", Offset = "0x3E9860", VA = "0x1803EA660", Slot = "8")]
	protected override void Update()
	{
	}

	// Token: 0x0600055C RID: 1372 RVA: 0x00003558 File Offset: 0x00001758
	[Token(Token = "0x600055C")]
	[Address(RVA = "0x3E9840", Offset = "0x3E8A40", VA = "0x1803E9840")]
	private bool CanCheckUsername(string username)
	{
		return default(bool);
	}

	// Token: 0x0600055D RID: 1373 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600055D")]
	[Address(RVA = "0x3E98C0", Offset = "0x3E8AC0", VA = "0x1803E98C0")]
	private Task CheckUsernameAsync(string username)
	{
		return null;
	}

	// Token: 0x0600055E RID: 1374 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600055E")]
	[Address(RVA = "0x3E99B0", Offset = "0x3E8BB0", VA = "0x1803E99B0")]
	private void CheckUsernameCompleted(ServiceResponse response)
	{
	}

	// Token: 0x0600055F RID: 1375 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600055F")]
	[Address(RVA = "0x3E9B10", Offset = "0x3E8D10", VA = "0x1803E9B10")]
	private Task CreateUsernameAsync(string username)
	{
		return null;
	}

	// Token: 0x06000560 RID: 1376 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000560")]
	[Address(RVA = "0x3E9F80", Offset = "0x3E9180", VA = "0x1803E9F80")]
	private void SetAvailabilityText(string textKey, Color color)
	{
	}

	// Token: 0x06000561 RID: 1377 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000561")]
	[Address(RVA = "0x3EA2E0", Offset = "0x3E94E0", VA = "0x1803EA2E0")]
	private void UpdateCheckUsername()
	{
	}

	// Token: 0x06000562 RID: 1378 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000562")]
	[Address(RVA = "0x3EA490", Offset = "0x3E9690", VA = "0x1803EA490")]
	private void UpdateEditedUsername()
	{
	}

	// Token: 0x06000563 RID: 1379 RVA: 0x00003570 File Offset: 0x00001770
	[Token(Token = "0x6000563")]
	[Address(RVA = "0x3E9C00", Offset = "0x3E8E00", VA = "0x1803E9C00")]
	private bool IsValidUsername(string username)
	{
		return default(bool);
	}

	// Token: 0x06000564 RID: 1380 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000564")]
	[Address(RVA = "0x3EA970", Offset = "0x3E9B70", VA = "0x1803EA970")]
	public UsernameMenu()
	{
	}

	// Token: 0x040005C3 RID: 1475
	[Token(Token = "0x40005C3")]
	private const float UsernameCheckInterval = 2f;

	// Token: 0x040005C4 RID: 1476
	[Token(Token = "0x40005C4")]
	[FieldOffset(Offset = "0x90")]
	public TMP_InputField UsernameInput;

	// Token: 0x040005C5 RID: 1477
	[Token(Token = "0x40005C5")]
	[FieldOffset(Offset = "0x98")]
	public TextMeshProUGUI AvailabilityLabel;

	// Token: 0x040005C6 RID: 1478
	[Token(Token = "0x40005C6")]
	[FieldOffset(Offset = "0xA0")]
	public Color AvailableColor;

	// Token: 0x040005C7 RID: 1479
	[Token(Token = "0x40005C7")]
	[FieldOffset(Offset = "0xB0")]
	public Color UnavailableColor;

	// Token: 0x040005C8 RID: 1480
	[Token(Token = "0x40005C8")]
	[FieldOffset(Offset = "0xC0")]
	public Color SearchingColor;

	// Token: 0x040005C9 RID: 1481
	[Token(Token = "0x40005C9")]
	[FieldOffset(Offset = "0xD0")]
	private float _lastCheckTime;

	// Token: 0x040005CA RID: 1482
	[Token(Token = "0x40005CA")]
	[FieldOffset(Offset = "0xD8")]
	private string _lastCheckedUsername;

	// Token: 0x040005CB RID: 1483
	[Token(Token = "0x40005CB")]
	[FieldOffset(Offset = "0xE0")]
	private ServiceResponse _lastCheckedResponse;

	// Token: 0x040005CC RID: 1484
	[Token(Token = "0x40005CC")]
	[FieldOffset(Offset = "0xE8")]
	private float _lastEditedTime;

	// Token: 0x040005CD RID: 1485
	[Token(Token = "0x40005CD")]
	[FieldOffset(Offset = "0xF0")]
	private string _usernameToCheck;

	// Token: 0x040005CE RID: 1486
	[Token(Token = "0x40005CE")]
	[FieldOffset(Offset = "0xF8")]
	private Task _checkUsernameTask;
}
