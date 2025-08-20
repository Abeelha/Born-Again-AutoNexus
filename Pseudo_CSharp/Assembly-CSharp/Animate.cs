using System;
using AnimateInternal;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200000E RID: 14
[Token(Token = "0x200000E")]
public static class Animate
{
	// Token: 0x06000061 RID: 97 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000061")]
	[Address(RVA = "0x316E40", Offset = "0x316040", VA = "0x180316E40")]
	public static DurationTask Alpha(Graphic graphic, float duration, float targetAlpha)
	{
		return null;
	}

	// Token: 0x06000062 RID: 98 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000062")]
	[Address(RVA = "0x317150", Offset = "0x316350", VA = "0x180317150")]
	public static DurationTask FadeIn(Graphic graphic, float alpha = 1f, float duration = 0.4f)
	{
		return null;
	}

	// Token: 0x06000063 RID: 99 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000063")]
	[Address(RVA = "0x317210", Offset = "0x316410", VA = "0x180317210")]
	public static DurationTask FadeOut(Graphic graphic, float alpha = 0f, float duration = 0.4f)
	{
		return null;
	}

	// Token: 0x06000064 RID: 100 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000064")]
	[Address(RVA = "0x317230", Offset = "0x316430", VA = "0x180317230")]
	public static DurationTask Float(float from, float to, float duration, Action<float> valueAction)
	{
		return null;
	}

	// Token: 0x06000065 RID: 101 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000065")]
	[Address(RVA = "0x317370", Offset = "0x316570", VA = "0x180317370")]
	public static AnimateTaskCollection Group()
	{
		return null;
	}

	// Token: 0x06000066 RID: 102 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000066")]
	[Address(RVA = "0x3173C0", Offset = "0x3165C0", VA = "0x1803173C0")]
	public static AnimateTaskCollection Group(params AnimateTask[] tasks)
	{
		return null;
	}

	// Token: 0x06000067 RID: 103 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000067")]
	[Address(RVA = "0x317580", Offset = "0x316780", VA = "0x180317580")]
	public static DurationTask Int(int from, int to, float duration, Action<int> valueAction)
	{
		return null;
	}

	// Token: 0x06000068 RID: 104 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000068")]
	[Address(RVA = "0x3176C0", Offset = "0x3168C0", VA = "0x1803176C0")]
	public static DurationTask MoveBy(RectTransform rectTransform, Vector2 vector, float duration = 0.4f)
	{
		return null;
	}

	// Token: 0x06000069 RID: 105 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000069")]
	[Address(RVA = "0x317810", Offset = "0x316A10", VA = "0x180317810")]
	public static DurationTask MoveTo(RectTransform rectTransform, Vector2 anchoredPosition, float duration = 0.4f)
	{
		return null;
	}

	// Token: 0x0600006A RID: 106 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600006A")]
	[Address(RVA = "0x317920", Offset = "0x316B20", VA = "0x180317920")]
	public static DurationTask MoveTo(Transform transform, Vector3 position, float duration = 0.4f)
	{
		return null;
	}

	// Token: 0x0600006B RID: 107 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600006B")]
	[Address(RVA = "0x317A30", Offset = "0x316C30", VA = "0x180317A30")]
	public static void Play(AnimateTask task)
	{
	}

	// Token: 0x0600006C RID: 108 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600006C")]
	[Address(RVA = "0x317F20", Offset = "0x317120", VA = "0x180317F20")]
	public static AnimateTaskCollection Sequence()
	{
		return null;
	}

	// Token: 0x0600006D RID: 109 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600006D")]
	[Address(RVA = "0x317F70", Offset = "0x317170", VA = "0x180317F70")]
	public static AnimateTaskCollection Sequence(params AnimateTask[] tasks)
	{
		return null;
	}

	// Token: 0x0600006E RID: 110 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600006E")]
	[Address(RVA = "0x317E00", Offset = "0x317000", VA = "0x180317E00")]
	public static DurationTask Scale(Transform transform, float xyz, float duration = 0.4f)
	{
		return null;
	}

	// Token: 0x0600006F RID: 111 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600006F")]
	[Address(RVA = "0x317CF0", Offset = "0x316EF0", VA = "0x180317CF0")]
	public static DurationTask Scale(Transform transform, Vector3 scale, float duration = 0.4f)
	{
		return null;
	}

	// Token: 0x06000070 RID: 112 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000070")]
	[Address(RVA = "0x317BE0", Offset = "0x316DE0", VA = "0x180317BE0")]
	public static DurationTask Scale(Transform transform, float fromXyz, float toXyz, float duration = 0.4f)
	{
		return null;
	}

	// Token: 0x06000071 RID: 113 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000071")]
	[Address(RVA = "0x317AD0", Offset = "0x316CD0", VA = "0x180317AD0")]
	public static DurationTask Scale(Transform transform, Vector3 fromScale, Vector3 toScale, float duration = 0.4f)
	{
		return null;
	}

	// Token: 0x06000072 RID: 114 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000072")]
	[Address(RVA = "0x318010", Offset = "0x317210", VA = "0x180318010")]
	public static DurationTask Shake(RectTransform rectTransform, float scale = 1f, float duration = 0.4f)
	{
		return null;
	}

	// Token: 0x06000073 RID: 115 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000073")]
	[Address(RVA = "0x3181C0", Offset = "0x3173C0", VA = "0x1803181C0")]
	public static DurationTask Size(RectTransform rectTransform, Vector2 size, float duration = 0.4f)
	{
		return null;
	}

	// Token: 0x06000074 RID: 116 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000074")]
	[Address(RVA = "0x3182D0", Offset = "0x3174D0", VA = "0x1803182D0")]
	public static DurationTask Wait(float duration)
	{
		return null;
	}

	// Token: 0x06000075 RID: 117 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000075")]
	[Address(RVA = "0x317060", Offset = "0x316260", VA = "0x180317060")]
	public static AnimateTaskCollection Collection(AnimateTaskCollection collection, AnimateTask[] tasks)
	{
		return null;
	}

	// Token: 0x06000076 RID: 118 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000076")]
	[Address(RVA = "0x3170D0", Offset = "0x3162D0", VA = "0x1803170D0")]
	private static DurationTask Duration(float duration, Action<float> stepAction)
	{
		return null;
	}

	// Token: 0x06000077 RID: 119 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000077")]
	[Address(RVA = "0x317460", Offset = "0x316660", VA = "0x180317460")]
	private static void Init()
	{
	}

	// Token: 0x06000078 RID: 120 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000078")]
	[Address(RVA = "0x316F50", Offset = "0x316150", VA = "0x180316F50")]
	private static DurationTask AnchoredPosition(RectTransform rectTransform, float duration, Func<float, Vector2, Vector2> stepAction)
	{
		return null;
	}

	// Token: 0x04000053 RID: 83
	[Token(Token = "0x4000053")]
	[FieldOffset(Offset = "0x0")]
	private static AnimateInstance _instance;
}
