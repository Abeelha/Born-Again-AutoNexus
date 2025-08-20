using System;
using Il2CppDummyDll;

// Token: 0x020001F5 RID: 501
[Token(Token = "0x20001F5")]
public class AmbientEffect : EffectBase
{
	// Token: 0x06000A51 RID: 2641 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A51")]
	[Address(RVA = "0x41E820", Offset = "0x41DA20", VA = "0x18041E820")]
	private void OnDisable()
	{
	}

	// Token: 0x06000A52 RID: 2642 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A52")]
	[Address(RVA = "0x41E940", Offset = "0x41DB40", VA = "0x18041E940", Slot = "7")]
	protected override void OnEnable()
	{
	}

	// Token: 0x06000A53 RID: 2643 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A53")]
	[Address(RVA = "0x41E690", Offset = "0x41D890", VA = "0x18041E690", Slot = "8")]
	protected virtual void LateUpdate()
	{
	}

	// Token: 0x06000A54 RID: 2644 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A54")]
	[Address(RVA = "0x41E690", Offset = "0x41D890", VA = "0x18041E690")]
	private void UpdateSfx()
	{
	}

	// Token: 0x06000A55 RID: 2645 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A55")]
	[Address(RVA = "0x41EA00", Offset = "0x41DC00", VA = "0x18041EA00")]
	public AmbientEffect()
	{
	}

	// Token: 0x04000990 RID: 2448
	[Token(Token = "0x4000990")]
	[FieldOffset(Offset = "0x50")]
	public string Sfx;

	// Token: 0x04000991 RID: 2449
	[Token(Token = "0x4000991")]
	[FieldOffset(Offset = "0x58")]
	private SfxController.SfxPlayId _playId;

	// Token: 0x04000992 RID: 2450
	[Token(Token = "0x4000992")]
	[FieldOffset(Offset = "0x60")]
	private SfxClip _sfxClip;
}
