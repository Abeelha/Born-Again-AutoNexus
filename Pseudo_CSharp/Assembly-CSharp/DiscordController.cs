using System;
using Discord;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200003E RID: 62
[Token(Token = "0x200003E")]
public class DiscordController : MonoBehaviour
{
	// Token: 0x0600013F RID: 319 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600013F")]
	[Address(RVA = "0x31E280", Offset = "0x31D480", VA = "0x18031E280")]
	public static void ClearActivity()
	{
	}

	// Token: 0x06000140 RID: 320 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000140")]
	[Address(RVA = "0x31EA30", Offset = "0x31DC30", VA = "0x18031EA30")]
	public static void SetMapEditor()
	{
	}

	// Token: 0x06000141 RID: 321 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000141")]
	[Address(RVA = "0x31E8E0", Offset = "0x31DAE0", VA = "0x18031E8E0")]
	public static void SetMainMenu()
	{
	}

	// Token: 0x06000142 RID: 322 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000142")]
	[Address(RVA = "0x31EB80", Offset = "0x31DD80", VA = "0x18031EB80")]
	public static void SetWorld(string worldName, string characterName, int level)
	{
	}

	// Token: 0x06000143 RID: 323 RVA: 0x00002610 File Offset: 0x00000810
	[Token(Token = "0x6000143")]
	[Address(RVA = "0x31E400", Offset = "0x31D600", VA = "0x18031E400")]
	private static Activity CreateBaseActivity()
	{
		return default(Activity);
	}

	// Token: 0x06000144 RID: 324 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000144")]
	[Address(RVA = "0x31EE10", Offset = "0x31E010", VA = "0x18031EE10")]
	private static void UpdateActivity(ref Activity activity)
	{
	}

	// Token: 0x06000145 RID: 325 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000145")]
	[Address(RVA = "0x31E710", Offset = "0x31D910", VA = "0x18031E710")]
	private void OnApplicationQuit()
	{
	}

	// Token: 0x06000146 RID: 326 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000146")]
	[Address(RVA = "0x31DFB0", Offset = "0x31D1B0", VA = "0x18031DFB0")]
	private void Awake()
	{
	}

	// Token: 0x06000147 RID: 327 RVA: 0x00002628 File Offset: 0x00000828
	[Token(Token = "0x6000147")]
	[Address(RVA = "0x31E570", Offset = "0x31D770", VA = "0x18031E570")]
	private bool DiscordExists()
	{
		return default(bool);
	}

	// Token: 0x06000148 RID: 328 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000148")]
	[Address(RVA = "0x31E650", Offset = "0x31D850", VA = "0x18031E650")]
	private void Dispose()
	{
	}

	// Token: 0x06000149 RID: 329 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000149")]
	[Address(RVA = "0x31F180", Offset = "0x31E380", VA = "0x18031F180")]
	private void Update()
	{
	}

	// Token: 0x0600014A RID: 330 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600014A")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public DiscordController()
	{
	}

	// Token: 0x0400011D RID: 285
	[Token(Token = "0x400011D")]
	public const long AppId = 1031909497154846790L;

	// Token: 0x0400011E RID: 286
	[Token(Token = "0x400011E")]
	[FieldOffset(Offset = "0x0")]
	public static DiscordController Instance;

	// Token: 0x0400011F RID: 287
	[Token(Token = "0x400011F")]
	[FieldOffset(Offset = "0x20")]
	public uint SteamId;

	// Token: 0x04000120 RID: 288
	[Token(Token = "0x4000120")]
	[FieldOffset(Offset = "0x8")]
	private static long _start;

	// Token: 0x04000121 RID: 289
	[Token(Token = "0x4000121")]
	[FieldOffset(Offset = "0x10")]
	private static Activity _currentActivity;

	// Token: 0x04000122 RID: 290
	[Token(Token = "0x4000122")]
	[FieldOffset(Offset = "0x98")]
	private static Discord _discord;
}
