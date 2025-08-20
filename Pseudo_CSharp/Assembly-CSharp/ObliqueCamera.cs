using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000026 RID: 38
[Token(Token = "0x2000026")]
[RequireComponent(typeof(Camera))]
[ExecuteInEditMode]
public class ObliqueCamera : MonoBehaviour
{
	// Token: 0x060000DD RID: 221 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x328DB0", Offset = "0x327FB0", VA = "0x180328DB0")]
	private void Awake()
	{
	}

	// Token: 0x060000DE RID: 222 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x328F40", Offset = "0x328140", VA = "0x180328F40")]
	private void OnEnable()
	{
	}

	// Token: 0x060000DF RID: 223 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x328E70", Offset = "0x328070", VA = "0x180328E70")]
	private void LateUpdate()
	{
	}

	// Token: 0x060000E0 RID: 224 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x328AF0", Offset = "0x327CF0", VA = "0x180328AF0")]
	private void ApplyOblique()
	{
	}

	// Token: 0x060000E1 RID: 225 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x328F60", Offset = "0x328160", VA = "0x180328F60")]
	public ObliqueCamera()
	{
	}

	// Token: 0x040000BB RID: 187
	[Token(Token = "0x40000BB")]
	[FieldOffset(Offset = "0x20")]
	public Vector2 ScreenOffset;

	// Token: 0x040000BC RID: 188
	[Token(Token = "0x40000BC")]
	[FieldOffset(Offset = "0x28")]
	public float Angle;

	// Token: 0x040000BD RID: 189
	[Token(Token = "0x40000BD")]
	[FieldOffset(Offset = "0x2C")]
	public float ZScale;

	// Token: 0x040000BE RID: 190
	[Token(Token = "0x40000BE")]
	[FieldOffset(Offset = "0x30")]
	public float ZOffset;

	// Token: 0x040000BF RID: 191
	[Token(Token = "0x40000BF")]
	[FieldOffset(Offset = "0x38")]
	private Camera _mainCamera;

	// Token: 0x040000C0 RID: 192
	[Token(Token = "0x40000C0")]
	[FieldOffset(Offset = "0x40")]
	private int _applied;

	// Token: 0x040000C1 RID: 193
	[Token(Token = "0x40000C1")]
	[FieldOffset(Offset = "0x44")]
	private Vector2 _syncedScreenSize;

	// Token: 0x040000C2 RID: 194
	[Token(Token = "0x40000C2")]
	[FieldOffset(Offset = "0x4C")]
	private float _syncedOrtho;
}
