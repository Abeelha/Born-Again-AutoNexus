using System;
using Il2CppDummyDll;
using Ronin.Model.Files.Animation;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000061 RID: 97
[Token(Token = "0x2000061")]
public static class ComponentAnimationDataExtensions
{
	// Token: 0x06000189 RID: 393 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000189")]
	[Address(RVA = "0x3332B0", Offset = "0x3324B0", VA = "0x1803332B0")]
	public static void PositionComponentFromData(this AnimationRunner runner, AnimationComponentData data, bool bodyFlipped, int layerOrder = 1)
	{
	}

	// Token: 0x0600018A RID: 394 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600018A")]
	[Address(RVA = "0x3334F0", Offset = "0x3326F0", VA = "0x1803334F0")]
	public static void PositionComponentFromData(this SpriteRenderer spriteRenderer, AnimationComponentData data, bool bodyFlipped, int layerOrder = 1)
	{
	}

	// Token: 0x0600018B RID: 395 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600018B")]
	[Address(RVA = "0x333740", Offset = "0x332940", VA = "0x180333740")]
	public static void PositionComponentFromData(this Image image, AnimationComponentData data, bool bodyFlipped, AnimationFrame frame)
	{
	}

	// Token: 0x0600018C RID: 396 RVA: 0x000026B8 File Offset: 0x000008B8
	[Token(Token = "0x600018C")]
	[Address(RVA = "0x333240", Offset = "0x332440", VA = "0x180333240")]
	private static int GetWeaponRotation(int dataRotation, bool weaponFlipped, bool bodyFlipped)
	{
		return 0;
	}

	// Token: 0x0600018D RID: 397 RVA: 0x000026D0 File Offset: 0x000008D0
	[Token(Token = "0x600018D")]
	[Address(RVA = "0x3331F0", Offset = "0x3323F0", VA = "0x1803331F0")]
	private static Vector2Int GetWeaponOffset(int rotation, bool componentFlipped, bool bodyFlipped)
	{
		return default(Vector2Int);
	}
}
