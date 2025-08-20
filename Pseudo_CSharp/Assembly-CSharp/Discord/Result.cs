using System;
using Il2CppDummyDll;

namespace Discord
{
	// Token: 0x020003E1 RID: 993
	[Token(Token = "0x20003E1")]
	public enum Result
	{
		// Token: 0x04001183 RID: 4483
		[Token(Token = "0x4001183")]
		Ok,
		// Token: 0x04001184 RID: 4484
		[Token(Token = "0x4001184")]
		ServiceUnavailable,
		// Token: 0x04001185 RID: 4485
		[Token(Token = "0x4001185")]
		InvalidVersion,
		// Token: 0x04001186 RID: 4486
		[Token(Token = "0x4001186")]
		LockFailed,
		// Token: 0x04001187 RID: 4487
		[Token(Token = "0x4001187")]
		InternalError,
		// Token: 0x04001188 RID: 4488
		[Token(Token = "0x4001188")]
		InvalidPayload,
		// Token: 0x04001189 RID: 4489
		[Token(Token = "0x4001189")]
		InvalidCommand,
		// Token: 0x0400118A RID: 4490
		[Token(Token = "0x400118A")]
		InvalidPermissions,
		// Token: 0x0400118B RID: 4491
		[Token(Token = "0x400118B")]
		NotFetched,
		// Token: 0x0400118C RID: 4492
		[Token(Token = "0x400118C")]
		NotFound,
		// Token: 0x0400118D RID: 4493
		[Token(Token = "0x400118D")]
		Conflict,
		// Token: 0x0400118E RID: 4494
		[Token(Token = "0x400118E")]
		InvalidSecret,
		// Token: 0x0400118F RID: 4495
		[Token(Token = "0x400118F")]
		InvalidJoinSecret,
		// Token: 0x04001190 RID: 4496
		[Token(Token = "0x4001190")]
		NoEligibleActivity,
		// Token: 0x04001191 RID: 4497
		[Token(Token = "0x4001191")]
		InvalidInvite,
		// Token: 0x04001192 RID: 4498
		[Token(Token = "0x4001192")]
		NotAuthenticated,
		// Token: 0x04001193 RID: 4499
		[Token(Token = "0x4001193")]
		InvalidAccessToken,
		// Token: 0x04001194 RID: 4500
		[Token(Token = "0x4001194")]
		ApplicationMismatch,
		// Token: 0x04001195 RID: 4501
		[Token(Token = "0x4001195")]
		InvalidDataUrl,
		// Token: 0x04001196 RID: 4502
		[Token(Token = "0x4001196")]
		InvalidBase64,
		// Token: 0x04001197 RID: 4503
		[Token(Token = "0x4001197")]
		NotFiltered,
		// Token: 0x04001198 RID: 4504
		[Token(Token = "0x4001198")]
		LobbyFull,
		// Token: 0x04001199 RID: 4505
		[Token(Token = "0x4001199")]
		InvalidLobbySecret,
		// Token: 0x0400119A RID: 4506
		[Token(Token = "0x400119A")]
		InvalidFilename,
		// Token: 0x0400119B RID: 4507
		[Token(Token = "0x400119B")]
		InvalidFileSize,
		// Token: 0x0400119C RID: 4508
		[Token(Token = "0x400119C")]
		InvalidEntitlement,
		// Token: 0x0400119D RID: 4509
		[Token(Token = "0x400119D")]
		NotInstalled,
		// Token: 0x0400119E RID: 4510
		[Token(Token = "0x400119E")]
		NotRunning,
		// Token: 0x0400119F RID: 4511
		[Token(Token = "0x400119F")]
		InsufficientBuffer,
		// Token: 0x040011A0 RID: 4512
		[Token(Token = "0x40011A0")]
		PurchaseCanceled,
		// Token: 0x040011A1 RID: 4513
		[Token(Token = "0x40011A1")]
		InvalidGuild,
		// Token: 0x040011A2 RID: 4514
		[Token(Token = "0x40011A2")]
		InvalidEvent,
		// Token: 0x040011A3 RID: 4515
		[Token(Token = "0x40011A3")]
		InvalidChannel,
		// Token: 0x040011A4 RID: 4516
		[Token(Token = "0x40011A4")]
		InvalidOrigin,
		// Token: 0x040011A5 RID: 4517
		[Token(Token = "0x40011A5")]
		RateLimited,
		// Token: 0x040011A6 RID: 4518
		[Token(Token = "0x40011A6")]
		OAuth2Error,
		// Token: 0x040011A7 RID: 4519
		[Token(Token = "0x40011A7")]
		SelectChannelTimeout,
		// Token: 0x040011A8 RID: 4520
		[Token(Token = "0x40011A8")]
		GetGuildTimeout,
		// Token: 0x040011A9 RID: 4521
		[Token(Token = "0x40011A9")]
		SelectVoiceForceRequired,
		// Token: 0x040011AA RID: 4522
		[Token(Token = "0x40011AA")]
		CaptureShortcutAlreadyListening,
		// Token: 0x040011AB RID: 4523
		[Token(Token = "0x40011AB")]
		UnauthorizedForAchievement,
		// Token: 0x040011AC RID: 4524
		[Token(Token = "0x40011AC")]
		InvalidGiftCode,
		// Token: 0x040011AD RID: 4525
		[Token(Token = "0x40011AD")]
		PurchaseError,
		// Token: 0x040011AE RID: 4526
		[Token(Token = "0x40011AE")]
		TransactionAborted
	}
}
