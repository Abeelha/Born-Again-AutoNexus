using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Ronin.Model.Files.Animation;
using UnityEngine;

// Token: 0x020001ED RID: 493
[Token(Token = "0x20001ED")]
public class Shadow : MonoBehaviour
{
	// Token: 0x06000A28 RID: 2600 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A28")]
	[Address(RVA = "0x42ED10", Offset = "0x42DF10", VA = "0x18042ED10")]
	public void Setup(Transform target, [Optional] Vector2? size, [Optional] WorldObject worldObject)
	{
	}

	// Token: 0x06000A29 RID: 2601 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A29")]
	[Address(RVA = "0x42EC00", Offset = "0x42DE00", VA = "0x18042EC00")]
	public void SetFlipped(bool flipped)
	{
	}

	// Token: 0x06000A2A RID: 2602 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A2A")]
	[Address(RVA = "0x42EC10", Offset = "0x42DE10", VA = "0x18042EC10")]
	public void SetFrame(AnimationFrame frame)
	{
	}

	// Token: 0x06000A2B RID: 2603 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A2B")]
	[Address(RVA = "0x42EC40", Offset = "0x42DE40", VA = "0x18042EC40")]
	public void SetScale(float scale)
	{
	}

	// Token: 0x06000A2C RID: 2604 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A2C")]
	[Address(RVA = "0x42ECA0", Offset = "0x42DEA0", VA = "0x18042ECA0")]
	public void SetSpritePivotOffset(AnimationFrame frame, bool flipped)
	{
	}

	// Token: 0x06000A2D RID: 2605 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A2D")]
	[Address(RVA = "0x42EA80", Offset = "0x42DC80", VA = "0x18042EA80")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000A2E RID: 2606 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A2E")]
	[Address(RVA = "0x42EBD0", Offset = "0x42DDD0", VA = "0x18042EBD0")]
	private void OnDisable()
	{
	}

	// Token: 0x06000A2F RID: 2607 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A2F")]
	[Address(RVA = "0x42EE90", Offset = "0x42E090", VA = "0x18042EE90")]
	private void UpdateFrameShadow()
	{
	}

	// Token: 0x06000A30 RID: 2608 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A30")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public Shadow()
	{
	}

	// Token: 0x0400096C RID: 2412
	[Token(Token = "0x400096C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Follow Follow;

	// Token: 0x0400096D RID: 2413
	[Token(Token = "0x400096D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public SpriteRenderer SpriteRenderer;

	// Token: 0x0400096E RID: 2414
	[Token(Token = "0x400096E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Vector2? _size;

	// Token: 0x0400096F RID: 2415
	[Token(Token = "0x400096F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private WorldObject _worldObject;

	// Token: 0x04000970 RID: 2416
	[Token(Token = "0x4000970")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private AnimationFrame _frame;

	// Token: 0x04000971 RID: 2417
	[Token(Token = "0x4000971")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool _flipped;
}
