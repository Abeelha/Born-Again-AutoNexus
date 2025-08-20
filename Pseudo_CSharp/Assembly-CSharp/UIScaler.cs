using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020001CF RID: 463
[Token(Token = "0x20001CF")]
[ExecuteInEditMode]
public class UIScaler : MonoBehaviour
{
	// Token: 0x06000953 RID: 2387 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000953")]
	[Address(RVA = "0x431880", Offset = "0x430A80", VA = "0x180431880")]
	private void Awake()
	{
	}

	// Token: 0x06000954 RID: 2388 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000954")]
	[Address(RVA = "0x431D10", Offset = "0x430F10", VA = "0x180431D10")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000955 RID: 2389 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000955")]
	[Address(RVA = "0x431DF0", Offset = "0x430FF0", VA = "0x180431DF0")]
	private void OnResolutionScaleChange(Option obj)
	{
	}

	// Token: 0x06000956 RID: 2390 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000956")]
	[Address(RVA = "0x431EA0", Offset = "0x4310A0", VA = "0x180431EA0")]
	private void OnWindowStyleChange(Option option)
	{
	}

	// Token: 0x06000957 RID: 2391 RVA: 0x00004560 File Offset: 0x00002760
	[Token(Token = "0x6000957")]
	[Address(RVA = "0x431C40", Offset = "0x430E40", VA = "0x180431C40")]
	private Vector2 GetCurrentScreenSize()
	{
		return default(Vector2);
	}

	// Token: 0x06000958 RID: 2392 RVA: 0x00004578 File Offset: 0x00002778
	[Token(Token = "0x6000958")]
	[Address(RVA = "0x431B30", Offset = "0x430D30", VA = "0x180431B30")]
	private ValueTuple<int, int> GetCurrentScaleFactor(Vector2 screenSize)
	{
		return default(ValueTuple<int, int>);
	}

	// Token: 0x06000959 RID: 2393 RVA: 0x00004590 File Offset: 0x00002790
	[Token(Token = "0x6000959")]
	[Address(RVA = "0x316110", Offset = "0x315310", VA = "0x180316110")]
	private bool IsTablet(DeviceType deviceType, Vector2 screenSize)
	{
		return default(bool);
	}

	// Token: 0x0600095A RID: 2394 RVA: 0x000045A8 File Offset: 0x000027A8
	[Token(Token = "0x600095A")]
	[Address(RVA = "0x431CA0", Offset = "0x430EA0", VA = "0x180431CA0")]
	private float GetOptionScale()
	{
		return 0f;
	}

	// Token: 0x0600095B RID: 2395 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600095B")]
	[Address(RVA = "0x431D00", Offset = "0x430F00", VA = "0x180431D00")]
	private void LateUpdate()
	{
	}

	// Token: 0x0600095C RID: 2396 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600095C")]
	[Address(RVA = "0x431F90", Offset = "0x431190", VA = "0x180431F90")]
	private void UpdateScale()
	{
	}

	// Token: 0x0600095D RID: 2397 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600095D")]
	[Address(RVA = "0x4321D0", Offset = "0x4313D0", VA = "0x1804321D0")]
	public UIScaler()
	{
	}

	// Token: 0x040008D5 RID: 2261
	[Token(Token = "0x40008D5")]
	[FieldOffset(Offset = "0x20")]
	public UIScaler.DeviceScale[] DeviceScaling;

	// Token: 0x040008D6 RID: 2262
	[Token(Token = "0x40008D6")]
	[FieldOffset(Offset = "0x28")]
	public int DefaultScaleFactor;

	// Token: 0x040008D7 RID: 2263
	[Token(Token = "0x40008D7")]
	[FieldOffset(Offset = "0x2C")]
	public int DefaultMaxScale;

	// Token: 0x040008D8 RID: 2264
	[Token(Token = "0x40008D8")]
	[FieldOffset(Offset = "0x30")]
	public int ScaleStep;

	// Token: 0x040008D9 RID: 2265
	[Token(Token = "0x40008D9")]
	[FieldOffset(Offset = "0x34")]
	public bool ApplyUIScaleOption;

	// Token: 0x040008DA RID: 2266
	[Token(Token = "0x40008DA")]
	[FieldOffset(Offset = "0x38")]
	public CanvasScaler CanvasScaler;

	// Token: 0x040008DB RID: 2267
	[Token(Token = "0x40008DB")]
	[FieldOffset(Offset = "0x40")]
	private float _scale;

	// Token: 0x040008DC RID: 2268
	[Token(Token = "0x40008DC")]
	[FieldOffset(Offset = "0x48")]
	private Option _uiScale;

	// Token: 0x040008DD RID: 2269
	[Token(Token = "0x40008DD")]
	[FieldOffset(Offset = "0x50")]
	private Option _windowStyleOption;

	// Token: 0x040008DE RID: 2270
	[Token(Token = "0x40008DE")]
	[FieldOffset(Offset = "0x58")]
	private Option _resolutionScale;

	// Token: 0x020001D0 RID: 464
	[Token(Token = "0x20001D0")]
	[Serializable]
	public struct DeviceScale
	{
		// Token: 0x040008DF RID: 2271
		[Token(Token = "0x40008DF")]
		[FieldOffset(Offset = "0x0")]
		public DeviceType DeviceType;

		// Token: 0x040008E0 RID: 2272
		[Token(Token = "0x40008E0")]
		[FieldOffset(Offset = "0x4")]
		public bool IsTablet;

		// Token: 0x040008E1 RID: 2273
		[Token(Token = "0x40008E1")]
		[FieldOffset(Offset = "0x8")]
		public int ScaleFactor;

		// Token: 0x040008E2 RID: 2274
		[Token(Token = "0x40008E2")]
		[FieldOffset(Offset = "0xC")]
		public int MaxScale;
	}
}
