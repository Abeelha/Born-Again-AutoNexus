using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020002DC RID: 732
[Token(Token = "0x20002DC")]
public class PlayerHealthBar : MonoBehaviour
{
	// Token: 0x06000FE5 RID: 4069 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FE5")]
	[Address(RVA = "0x355050", Offset = "0x354250", VA = "0x180355050")]
	private void SetBarRatio(Transform bar, float ratio)
	{
	}

	// Token: 0x06000FE6 RID: 4070 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FE6")]
	[Address(RVA = "0x3555B0", Offset = "0x3547B0", VA = "0x1803555B0")]
	private void Update()
	{
	}

	// Token: 0x06000FE7 RID: 4071 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FE7")]
	[Address(RVA = "0x3550B0", Offset = "0x3542B0", VA = "0x1803550B0")]
	private void UpdateContextBar()
	{
	}

	// Token: 0x06000FE8 RID: 4072 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FE8")]
	[Address(RVA = "0x355340", Offset = "0x354540", VA = "0x180355340")]
	private void UpdateHealth()
	{
	}

	// Token: 0x06000FE9 RID: 4073 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FE9")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public PlayerHealthBar()
	{
	}

	// Token: 0x04000D35 RID: 3381
	[Token(Token = "0x4000D35")]
	[FieldOffset(Offset = "0x20")]
	public World World;

	// Token: 0x04000D36 RID: 3382
	[Token(Token = "0x4000D36")]
	[FieldOffset(Offset = "0x28")]
	public Image Fill;

	// Token: 0x04000D37 RID: 3383
	[Token(Token = "0x4000D37")]
	[FieldOffset(Offset = "0x30")]
	public Image FillContext;

	// Token: 0x04000D38 RID: 3384
	[Token(Token = "0x4000D38")]
	[FieldOffset(Offset = "0x38")]
	public TextMeshProUGUI HealthText;

	// Token: 0x04000D39 RID: 3385
	[Token(Token = "0x4000D39")]
	[FieldOffset(Offset = "0x40")]
	private float _ratio;

	// Token: 0x04000D3A RID: 3386
	[Token(Token = "0x4000D3A")]
	[FieldOffset(Offset = "0x44")]
	private float? _delayedRatio;

	// Token: 0x04000D3B RID: 3387
	[Token(Token = "0x4000D3B")]
	[FieldOffset(Offset = "0x4C")]
	private float? _lerpToTime;

	// Token: 0x04000D3C RID: 3388
	[Token(Token = "0x4000D3C")]
	[FieldOffset(Offset = "0x54")]
	private int _health;
}
