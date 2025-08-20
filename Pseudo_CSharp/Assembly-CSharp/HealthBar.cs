using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020001E8 RID: 488
[Token(Token = "0x20001E8")]
public class HealthBar : MonoBehaviour
{
	// Token: 0x170000F4 RID: 244
	// (get) Token: 0x06000A03 RID: 2563 RVA: 0x00004968 File Offset: 0x00002B68
	[Token(Token = "0x170000F4")]
	public bool IsAlly
	{
		[Token(Token = "0x6000A03")]
		[Address(RVA = "0x427F50", Offset = "0x427150", VA = "0x180427F50")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170000F5 RID: 245
	// (get) Token: 0x06000A04 RID: 2564 RVA: 0x00004980 File Offset: 0x00002B80
	[Token(Token = "0x170000F5")]
	public bool IsControlled
	{
		[Token(Token = "0x6000A04")]
		[Address(RVA = "0x427F70", Offset = "0x427170", VA = "0x180427F70")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170000F6 RID: 246
	// (get) Token: 0x06000A05 RID: 2565 RVA: 0x00004998 File Offset: 0x00002B98
	[Token(Token = "0x170000F6")]
	public bool IsBoss
	{
		[Token(Token = "0x6000A05")]
		[Address(RVA = "0x427F60", Offset = "0x427160", VA = "0x180427F60")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170000F7 RID: 247
	// (get) Token: 0x06000A06 RID: 2566 RVA: 0x000049B0 File Offset: 0x00002BB0
	[Token(Token = "0x170000F7")]
	public bool IsLarge
	{
		[Token(Token = "0x6000A06")]
		[Address(RVA = "0x427F80", Offset = "0x427180", VA = "0x180427F80")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000A07 RID: 2567 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A07")]
	[Address(RVA = "0x4273C0", Offset = "0x4265C0", VA = "0x1804273C0")]
	public void SetHealth(int health, int maxHealth)
	{
	}

	// Token: 0x06000A08 RID: 2568 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A08")]
	[Address(RVA = "0x427660", Offset = "0x426860", VA = "0x180427660")]
	public void SetHeight(float height)
	{
	}

	// Token: 0x06000A09 RID: 2569 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A09")]
	[Address(RVA = "0x427770", Offset = "0x426970", VA = "0x180427770")]
	public void SetOpacity(float opacity)
	{
	}

	// Token: 0x06000A0A RID: 2570 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A0A")]
	[Address(RVA = "0x427670", Offset = "0x426870", VA = "0x180427670")]
	public void SetMask(EntityMasks entityMask)
	{
	}

	// Token: 0x06000A0B RID: 2571 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A0B")]
	[Address(RVA = "0x4278C0", Offset = "0x426AC0", VA = "0x1804278C0")]
	public void Setup(Transform target, float height, EntityMasks entityMask)
	{
	}

	// Token: 0x06000A0C RID: 2572 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A0C")]
	[Address(RVA = "0x427A60", Offset = "0x426C60", VA = "0x180427A60")]
	public void Shake()
	{
	}

	// Token: 0x06000A0D RID: 2573 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A0D")]
	[Address(RVA = "0x4272F0", Offset = "0x4264F0", VA = "0x1804272F0")]
	private void Awake()
	{
	}

	// Token: 0x06000A0E RID: 2574 RVA: 0x000049C8 File Offset: 0x00002BC8
	[Token(Token = "0x6000A0E")]
	[Address(RVA = "0x427350", Offset = "0x426550", VA = "0x180427350")]
	private Color GetContainerColor()
	{
		return default(Color);
	}

	// Token: 0x06000A0F RID: 2575 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A0F")]
	[Address(RVA = "0x4273A0", Offset = "0x4265A0", VA = "0x1804273A0")]
	private void OnDisable()
	{
	}

	// Token: 0x06000A10 RID: 2576 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A10")]
	[Address(RVA = "0x355050", Offset = "0x354250", VA = "0x180355050")]
	private void SetBarRatio(Transform bar, float ratio)
	{
	}

	// Token: 0x06000A11 RID: 2577 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A11")]
	[Address(RVA = "0x427E40", Offset = "0x427040", VA = "0x180427E40")]
	private void Update()
	{
	}

	// Token: 0x06000A12 RID: 2578 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A12")]
	[Address(RVA = "0x427AA0", Offset = "0x426CA0", VA = "0x180427AA0")]
	private void UpdateContextBar()
	{
	}

	// Token: 0x06000A13 RID: 2579 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A13")]
	[Address(RVA = "0x427D40", Offset = "0x426F40", VA = "0x180427D40")]
	private void UpdateHeight()
	{
	}

	// Token: 0x06000A14 RID: 2580 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A14")]
	[Address(RVA = "0x427DE0", Offset = "0x426FE0", VA = "0x180427DE0")]
	private void UpdateShake()
	{
	}

	// Token: 0x06000A15 RID: 2581 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A15")]
	[Address(RVA = "0x427F30", Offset = "0x427130", VA = "0x180427F30")]
	public HealthBar()
	{
	}

	// Token: 0x04000949 RID: 2377
	[Token(Token = "0x4000949")]
	[FieldOffset(Offset = "0x20")]
	public Follow Follow;

	// Token: 0x0400094A RID: 2378
	[Token(Token = "0x400094A")]
	[FieldOffset(Offset = "0x28")]
	public Transform ContextBar;

	// Token: 0x0400094B RID: 2379
	[Token(Token = "0x400094B")]
	[FieldOffset(Offset = "0x30")]
	public Transform Bar;

	// Token: 0x0400094C RID: 2380
	[Token(Token = "0x400094C")]
	[FieldOffset(Offset = "0x38")]
	public SpriteRenderer ContainerSpriteRenderer;

	// Token: 0x0400094D RID: 2381
	[Token(Token = "0x400094D")]
	[FieldOffset(Offset = "0x40")]
	public SpriteRenderer BarSpriteRenderer;

	// Token: 0x0400094E RID: 2382
	[Token(Token = "0x400094E")]
	[FieldOffset(Offset = "0x48")]
	public SpriteRenderer ContextBarSpriteRenderer;

	// Token: 0x0400094F RID: 2383
	[Token(Token = "0x400094F")]
	[FieldOffset(Offset = "0x50")]
	public SortingGroup SortingGroup;

	// Token: 0x04000950 RID: 2384
	[Token(Token = "0x4000950")]
	[FieldOffset(Offset = "0x58")]
	public Color DefaultColor;

	// Token: 0x04000951 RID: 2385
	[Token(Token = "0x4000951")]
	[FieldOffset(Offset = "0x68")]
	public Color AllyColor;

	// Token: 0x04000952 RID: 2386
	[Token(Token = "0x4000952")]
	[FieldOffset(Offset = "0x78")]
	public Color PlayerColor;

	// Token: 0x04000953 RID: 2387
	[Token(Token = "0x4000953")]
	[FieldOffset(Offset = "0x88")]
	public Color BossColor;

	// Token: 0x04000954 RID: 2388
	[Token(Token = "0x4000954")]
	[FieldOffset(Offset = "0x98")]
	public float SelfScale;

	// Token: 0x04000955 RID: 2389
	[Token(Token = "0x4000955")]
	[FieldOffset(Offset = "0x9C")]
	public float Scale;

	// Token: 0x04000956 RID: 2390
	[Token(Token = "0x4000956")]
	[FieldOffset(Offset = "0xA0")]
	private float _height;

	// Token: 0x04000957 RID: 2391
	[Token(Token = "0x4000957")]
	[FieldOffset(Offset = "0xA4")]
	private float _shakeTime;

	// Token: 0x04000958 RID: 2392
	[Token(Token = "0x4000958")]
	[FieldOffset(Offset = "0xA8")]
	private bool _shaking;

	// Token: 0x04000959 RID: 2393
	[Token(Token = "0x4000959")]
	[FieldOffset(Offset = "0xAC")]
	private int _shakeIndex;

	// Token: 0x0400095A RID: 2394
	[Token(Token = "0x400095A")]
	[FieldOffset(Offset = "0xB0")]
	private EntityMasks _entityMask;

	// Token: 0x0400095B RID: 2395
	[Token(Token = "0x400095B")]
	[FieldOffset(Offset = "0xB8")]
	private Option _lerpOption;

	// Token: 0x0400095C RID: 2396
	[Token(Token = "0x400095C")]
	[FieldOffset(Offset = "0xC0")]
	private float _ratio;

	// Token: 0x0400095D RID: 2397
	[Token(Token = "0x400095D")]
	[FieldOffset(Offset = "0xC4")]
	private float? _delayedRatio;

	// Token: 0x0400095E RID: 2398
	[Token(Token = "0x400095E")]
	[FieldOffset(Offset = "0xCC")]
	private float? _lerpToTime;
}
