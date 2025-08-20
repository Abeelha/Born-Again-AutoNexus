using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200007C RID: 124
[Token(Token = "0x200007C")]
public static class MaterialFactory
{
	// Token: 0x06000208 RID: 520 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000208")]
	[Address(RVA = "0x33FA00", Offset = "0x33EC00", VA = "0x18033FA00")]
	public static void ResetLightingTexture()
	{
	}

	// Token: 0x06000209 RID: 521 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000209")]
	[Address(RVA = "0x33FAD0", Offset = "0x33ECD0", VA = "0x18033FAD0")]
	public static void Set3dMaterial(Texture2D texture2d)
	{
	}

	// Token: 0x0600020A RID: 522 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600020A")]
	[Address(RVA = "0x33FBD0", Offset = "0x33EDD0", VA = "0x18033FBD0")]
	public static void SetBackground(string key)
	{
	}

	// Token: 0x0600020B RID: 523 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600020B")]
	[Address(RVA = "0x33FFC0", Offset = "0x33F1C0", VA = "0x18033FFC0")]
	public static void SetLightingTexture(RenderTexture renderTexture)
	{
	}

	// Token: 0x0600020C RID: 524 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600020C")]
	[Address(RVA = "0x33FEF0", Offset = "0x33F0F0", VA = "0x18033FEF0")]
	public static void SetDarknessTexture(Texture texture)
	{
	}

	// Token: 0x0600020D RID: 525 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600020D")]
	[Address(RVA = "0x33FE30", Offset = "0x33F030", VA = "0x18033FE30")]
	public static void SetDarknessRect(Rect rect)
	{
	}

	// Token: 0x0600020E RID: 526 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600020E")]
	[Address(RVA = "0x33FD90", Offset = "0x33EF90", VA = "0x18033FD90")]
	public static void SetCameraOffset(Vector2 vector)
	{
	}

	// Token: 0x0600020F RID: 527 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600020F")]
	[Address(RVA = "0x33FF50", Offset = "0x33F150", VA = "0x18033FF50")]
	public static void SetGlobalLight(Color color)
	{
	}

	// Token: 0x06000210 RID: 528 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000210")]
	[Address(RVA = "0x340020", Offset = "0x33F220", VA = "0x180340020")]
	public static void SetResolutionScale(float scale)
	{
	}

	// Token: 0x040001FF RID: 511
	[Token(Token = "0x40001FF")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int s_lightTexNameId;

	// Token: 0x04000200 RID: 512
	[Token(Token = "0x4000200")]
	[FieldOffset(Offset = "0x4")]
	private static readonly int s_darknessTexNameId;

	// Token: 0x04000201 RID: 513
	[Token(Token = "0x4000201")]
	[FieldOffset(Offset = "0x8")]
	private static readonly int s_darknessRectNameId;

	// Token: 0x04000202 RID: 514
	[Token(Token = "0x4000202")]
	[FieldOffset(Offset = "0xC")]
	private static readonly int s_globalLightNameId;

	// Token: 0x04000203 RID: 515
	[Token(Token = "0x4000203")]
	[FieldOffset(Offset = "0x10")]
	private static readonly int s_cameraOffsetNameId;

	// Token: 0x04000204 RID: 516
	[Token(Token = "0x4000204")]
	[FieldOffset(Offset = "0x14")]
	private static readonly int s_resolutionScaleId;
}
