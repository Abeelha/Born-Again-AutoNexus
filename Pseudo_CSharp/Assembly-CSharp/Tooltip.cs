using System;
using System.Runtime.CompilerServices;
using AnimateInternal;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x02000303 RID: 771
[Token(Token = "0x2000303")]
public class Tooltip : MonoBehaviour
{
	// Token: 0x170001E4 RID: 484
	// (get) Token: 0x0600111C RID: 4380 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x170001E4")]
	public static TooltipBuilder Builder
	{
		[Token(Token = "0x600111C")]
		[Address(RVA = "0x361940", Offset = "0x360B40", VA = "0x180361940")]
		get
		{
			return null;
		}
	}

	// Token: 0x170001E5 RID: 485
	// (get) Token: 0x0600111D RID: 4381 RVA: 0x00006828 File Offset: 0x00004A28
	[Token(Token = "0x170001E5")]
	public bool IsRolled
	{
		[Token(Token = "0x600111D")]
		[Address(RVA = "0x363340", Offset = "0x362540", VA = "0x180363340")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170001E6 RID: 486
	// (get) Token: 0x0600111E RID: 4382 RVA: 0x00006840 File Offset: 0x00004A40
	[Token(Token = "0x170001E6")]
	public Vector2 PreferredSize
	{
		[Token(Token = "0x600111E")]
		[Address(RVA = "0x363390", Offset = "0x362590", VA = "0x180363390")]
		get
		{
			return default(Vector2);
		}
	}

	// Token: 0x170001E7 RID: 487
	// (get) Token: 0x0600111F RID: 4383 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x170001E7")]
	public RectTransform RectTransform
	{
		[Token(Token = "0x600111F")]
		[Address(RVA = "0x363430", Offset = "0x362630", VA = "0x180363430")]
		get
		{
			return null;
		}
	}

	// Token: 0x170001E8 RID: 488
	// (get) Token: 0x06001120 RID: 4384 RVA: 0x00006858 File Offset: 0x00004A58
	// (set) Token: 0x06001121 RID: 4385 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001E8")]
	public bool Floating
	{
		[Token(Token = "0x6001120")]
		[Address(RVA = "0x363330", Offset = "0x362530", VA = "0x180363330")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001121")]
		[Address(RVA = "0x3634F0", Offset = "0x3626F0", VA = "0x1803634F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x06001122 RID: 4386 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001122")]
	[Address(RVA = "0x361E00", Offset = "0x361000", VA = "0x180361E00")]
	public void OnClick(UnityAction action)
	{
	}

	// Token: 0x06001123 RID: 4387 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001123")]
	[Address(RVA = "0x361670", Offset = "0x360870", VA = "0x180361670")]
	public void Clear()
	{
	}

	// Token: 0x06001124 RID: 4388 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001124")]
	[Address(RVA = "0x3615D0", Offset = "0x3607D0", VA = "0x1803615D0")]
	public void ClearScaleAnimation()
	{
	}

	// Token: 0x06001125 RID: 4389 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001125")]
	[Address(RVA = "0x361F90", Offset = "0x361190", VA = "0x180361F90")]
	public void RollTo(float height, bool instant = false)
	{
	}

	// Token: 0x06001126 RID: 4390 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001126")]
	[Address(RVA = "0x361EA0", Offset = "0x3610A0", VA = "0x180361EA0")]
	public void RollToContentSize()
	{
	}

	// Token: 0x06001127 RID: 4391 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001127")]
	[Address(RVA = "0x3620B0", Offset = "0x3612B0", VA = "0x1803620B0")]
	public void Scale(float scale, float delay)
	{
	}

	// Token: 0x06001128 RID: 4392 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001128")]
	[Address(RVA = "0x3621B0", Offset = "0x3613B0", VA = "0x1803621B0")]
	public void SetBackground(SpriteLibrary.ScrollBackground background)
	{
	}

	// Token: 0x06001129 RID: 4393 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001129")]
	[Address(RVA = "0x362370", Offset = "0x361570", VA = "0x180362370")]
	public void SetContentSize(Vector2 size)
	{
	}

	// Token: 0x0600112A RID: 4394 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600112A")]
	[Address(RVA = "0x3623D0", Offset = "0x3615D0", VA = "0x1803623D0")]
	public void SetFloating(TooltipBuilder builder)
	{
	}

	// Token: 0x0600112B RID: 4395 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600112B")]
	[Address(RVA = "0x3628E0", Offset = "0x361AE0", VA = "0x1803628E0")]
	public void TrackToAnchor()
	{
	}

	// Token: 0x0600112C RID: 4396 RVA: 0x00006870 File Offset: 0x00004A70
	[Token(Token = "0x600112C")]
	[Address(RVA = "0x361750", Offset = "0x360950", VA = "0x180361750")]
	private bool DidPress(out Vector2 position)
	{
		return default(bool);
	}

	// Token: 0x0600112D RID: 4397 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600112D")]
	[Address(RVA = "0x361940", Offset = "0x360B40", VA = "0x180361940")]
	private static TooltipBuilder GetBuilder()
	{
		return null;
	}

	// Token: 0x0600112E RID: 4398 RVA: 0x00006888 File Offset: 0x00004A88
	[Token(Token = "0x600112E")]
	[Address(RVA = "0x361860", Offset = "0x360A60", VA = "0x180361860")]
	private Vector2 GetAnchorPosition()
	{
		return default(Vector2);
	}

	// Token: 0x0600112F RID: 4399 RVA: 0x000068A0 File Offset: 0x00004AA0
	[Token(Token = "0x600112F")]
	[Address(RVA = "0x361A50", Offset = "0x360C50", VA = "0x180361A50")]
	private Vector2 GetOffset()
	{
		return default(Vector2);
	}

	// Token: 0x06001130 RID: 4400 RVA: 0x000068B8 File Offset: 0x00004AB8
	[Token(Token = "0x6001130")]
	[Address(RVA = "0x361B10", Offset = "0x360D10", VA = "0x180361B10")]
	private Vector2 GetQuadrantScalar(Vector2 screenPosition)
	{
		return default(Vector2);
	}

	// Token: 0x06001131 RID: 4401 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001131")]
	[Address(RVA = "0x361E60", Offset = "0x361060", VA = "0x180361E60")]
	private void OnDestroy()
	{
	}

	// Token: 0x06001132 RID: 4402 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001132")]
	[Address(RVA = "0x361C70", Offset = "0x360E70", VA = "0x180361C70")]
	private void LateUpdate()
	{
	}

	// Token: 0x06001133 RID: 4403 RVA: 0x000068D0 File Offset: 0x00004AD0
	[Token(Token = "0x6001133")]
	[Address(RVA = "0x3623F0", Offset = "0x3615F0", VA = "0x1803623F0")]
	private bool ShouldClose()
	{
		return default(bool);
	}

	// Token: 0x06001134 RID: 4404 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001134")]
	[Address(RVA = "0x363120", Offset = "0x362320", VA = "0x180363120")]
	private void UpdateScale()
	{
	}

	// Token: 0x06001135 RID: 4405 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001135")]
	[Address(RVA = "0x363240", Offset = "0x362440", VA = "0x180363240")]
	private void UpdateStatus()
	{
	}

	// Token: 0x06001136 RID: 4406 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001136")]
	[Address(RVA = "0x3632C0", Offset = "0x3624C0", VA = "0x1803632C0")]
	public Tooltip()
	{
	}

	// Token: 0x04000E23 RID: 3619
	[Token(Token = "0x4000E23")]
	[FieldOffset(Offset = "0x0")]
	private static TooltipBuilder s_builder;

	// Token: 0x04000E24 RID: 3620
	[Token(Token = "0x4000E24")]
	[FieldOffset(Offset = "0x20")]
	public float Offset;

	// Token: 0x04000E25 RID: 3621
	[Token(Token = "0x4000E25")]
	[FieldOffset(Offset = "0x28")]
	public Image Background;

	// Token: 0x04000E26 RID: 3622
	[Token(Token = "0x4000E26")]
	[FieldOffset(Offset = "0x30")]
	public Button Button;

	// Token: 0x04000E27 RID: 3623
	[Token(Token = "0x4000E27")]
	[FieldOffset(Offset = "0x38")]
	public RectTransform Content;

	// Token: 0x04000E28 RID: 3624
	[Token(Token = "0x4000E28")]
	[FieldOffset(Offset = "0x40")]
	public RectTransform Anchor;

	// Token: 0x04000E29 RID: 3625
	[Token(Token = "0x4000E29")]
	[FieldOffset(Offset = "0x48")]
	public RectTransform ClampBounds;

	// Token: 0x04000E2A RID: 3626
	[Token(Token = "0x4000E2A")]
	[FieldOffset(Offset = "0x50")]
	public Vector2? ScreenAnchor;

	// Token: 0x04000E2B RID: 3627
	[Token(Token = "0x4000E2B")]
	[FieldOffset(Offset = "0x5C")]
	public Vector2? PivotOverride;

	// Token: 0x04000E2C RID: 3628
	[Token(Token = "0x4000E2C")]
	[FieldOffset(Offset = "0x68")]
	private RectTransform _rectTransform;

	// Token: 0x04000E2D RID: 3629
	[Token(Token = "0x4000E2D")]
	[FieldOffset(Offset = "0x70")]
	private float _scaleTo;

	// Token: 0x04000E2E RID: 3630
	[Token(Token = "0x4000E2E")]
	[FieldOffset(Offset = "0x78")]
	private AnimateTask _scaleTask;

	// Token: 0x04000E2F RID: 3631
	[Token(Token = "0x4000E2F")]
	[FieldOffset(Offset = "0x80")]
	private AnimateTask _rollTask;

	// Token: 0x04000E30 RID: 3632
	[Token(Token = "0x4000E30")]
	[FieldOffset(Offset = "0x88")]
	private float? _scaleDelay;

	// Token: 0x04000E31 RID: 3633
	[Token(Token = "0x4000E31")]
	[FieldOffset(Offset = "0x90")]
	private Vector2 _contentSize;

	// Token: 0x04000E32 RID: 3634
	[Token(Token = "0x4000E32")]
	[FieldOffset(Offset = "0x98")]
	private TooltipBuilder _sourceBuilder;

	// Token: 0x04000E33 RID: 3635
	[Token(Token = "0x4000E33")]
	[FieldOffset(Offset = "0xA0")]
	private bool _upClear;
}
