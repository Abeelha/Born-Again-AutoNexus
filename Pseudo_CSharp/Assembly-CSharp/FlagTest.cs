using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000039 RID: 57
[Token(Token = "0x2000039")]
[ExecuteInEditMode]
public class FlagTest : MonoBehaviour
{
	// Token: 0x0600012F RID: 303 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600012F")]
	[Address(RVA = "0x322A20", Offset = "0x321C20", VA = "0x180322A20")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000130 RID: 304 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000130")]
	[Address(RVA = "0x322C10", Offset = "0x321E10", VA = "0x180322C10")]
	private void OnEnable()
	{
	}

	// Token: 0x06000131 RID: 305 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000131")]
	[Address(RVA = "0x322DA0", Offset = "0x321FA0", VA = "0x180322DA0")]
	private void UpdateComponent(Transform component, int index, int count)
	{
	}

	// Token: 0x06000132 RID: 306 RVA: 0x000025F8 File Offset: 0x000007F8
	[Token(Token = "0x6000132")]
	[Address(RVA = "0x322D50", Offset = "0x321F50", VA = "0x180322D50")]
	private float Sin(float x)
	{
		return 0f;
	}

	// Token: 0x06000133 RID: 307 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000133")]
	[Address(RVA = "0x322F30", Offset = "0x322130", VA = "0x180322F30")]
	public FlagTest()
	{
	}

	// Token: 0x04000109 RID: 265
	[Token(Token = "0x4000109")]
	[FieldOffset(Offset = "0x20")]
	public Transform[] FlagComponents;

	// Token: 0x0400010A RID: 266
	[Token(Token = "0x400010A")]
	[FieldOffset(Offset = "0x28")]
	public float Speed;

	// Token: 0x0400010B RID: 267
	[Token(Token = "0x400010B")]
	[FieldOffset(Offset = "0x2C")]
	public float Scale;

	// Token: 0x0400010C RID: 268
	[Token(Token = "0x400010C")]
	[FieldOffset(Offset = "0x30")]
	public float Spacing;

	// Token: 0x0400010D RID: 269
	[Token(Token = "0x400010D")]
	[FieldOffset(Offset = "0x34")]
	public float MaxDampening;

	// Token: 0x0400010E RID: 270
	[Token(Token = "0x400010E")]
	[FieldOffset(Offset = "0x38")]
	public float Sin2F;

	// Token: 0x0400010F RID: 271
	[Token(Token = "0x400010F")]
	[FieldOffset(Offset = "0x3C")]
	public float Sin2A;

	// Token: 0x04000110 RID: 272
	[Token(Token = "0x4000110")]
	[FieldOffset(Offset = "0x40")]
	public float XSep;
}
