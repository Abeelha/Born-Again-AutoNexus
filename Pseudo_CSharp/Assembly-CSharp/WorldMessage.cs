using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x020001F4 RID: 500
[Token(Token = "0x20001F4")]
public class WorldMessage : MonoBehaviour
{
	// Token: 0x170000F9 RID: 249
	// (get) Token: 0x06000A4A RID: 2634 RVA: 0x00004A40 File Offset: 0x00002C40
	[Token(Token = "0x170000F9")]
	public float Time
	{
		[Token(Token = "0x6000A4A")]
		[Address(RVA = "0x31B6A0", Offset = "0x31A8A0", VA = "0x18031B6A0")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x06000A4B RID: 2635 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A4B")]
	[Address(RVA = "0x433930", Offset = "0x432B30", VA = "0x180433930")]
	public void Setup(Transform target, WorldMessageDescription description)
	{
	}

	// Token: 0x06000A4C RID: 2636 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A4C")]
	[Address(RVA = "0x4336E0", Offset = "0x4328E0", VA = "0x1804336E0")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000A4D RID: 2637 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A4D")]
	[Address(RVA = "0x433AE0", Offset = "0x432CE0", VA = "0x180433AE0")]
	private void Update()
	{
	}

	// Token: 0x06000A4E RID: 2638 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A4E")]
	[Address(RVA = "0x433AE0", Offset = "0x432CE0", VA = "0x180433AE0")]
	private void UpdateOffset()
	{
	}

	// Token: 0x06000A4F RID: 2639 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A4F")]
	[Address(RVA = "0x433B30", Offset = "0x432D30", VA = "0x180433B30")]
	private void UpdateScale()
	{
	}

	// Token: 0x06000A50 RID: 2640 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A50")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public WorldMessage()
	{
	}

	// Token: 0x0400098A RID: 2442
	[Token(Token = "0x400098A")]
	[FieldOffset(Offset = "0x20")]
	private float _time;

	// Token: 0x0400098B RID: 2443
	[Token(Token = "0x400098B")]
	[FieldOffset(Offset = "0x24")]
	private Vector3 _offset;

	// Token: 0x0400098C RID: 2444
	[Token(Token = "0x400098C")]
	[FieldOffset(Offset = "0x30")]
	private float _scaleSize;

	// Token: 0x0400098D RID: 2445
	[Token(Token = "0x400098D")]
	[FieldOffset(Offset = "0x34")]
	private bool _showInFront;

	// Token: 0x0400098E RID: 2446
	[Token(Token = "0x400098E")]
	[FieldOffset(Offset = "0x38")]
	public TextMeshPro Label;

	// Token: 0x0400098F RID: 2447
	[Token(Token = "0x400098F")]
	[FieldOffset(Offset = "0x40")]
	public Follow Follow;
}
