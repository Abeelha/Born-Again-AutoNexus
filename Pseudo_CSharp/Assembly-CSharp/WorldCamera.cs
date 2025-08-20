using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000027 RID: 39
[Token(Token = "0x2000027")]
[RequireComponent(typeof(Camera))]
[ExecuteInEditMode]
public class WorldCamera : MonoBehaviour
{
	// Token: 0x060000E2 RID: 226 RVA: 0x00002490 File Offset: 0x00000690
	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x330840", Offset = "0x32FA40", VA = "0x180330840")]
	public Vector2 GetWorldPositionOfMouse()
	{
		return default(Vector2);
	}

	// Token: 0x060000E3 RID: 227 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x330640", Offset = "0x32F840", VA = "0x180330640")]
	private void Awake()
	{
	}

	// Token: 0x060000E4 RID: 228 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x330990", Offset = "0x32FB90", VA = "0x180330990")]
	private void LateUpdate()
	{
	}

	// Token: 0x060000E5 RID: 229 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x330A70", Offset = "0x32FC70", VA = "0x180330A70")]
	private void Snap()
	{
	}

	// Token: 0x060000E6 RID: 230 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x330000", Offset = "0x32F200", VA = "0x180330000")]
	private void ApplyMatrix()
	{
	}

	// Token: 0x060000E7 RID: 231 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x3306D0", Offset = "0x32F8D0", VA = "0x1803306D0")]
	private static void GenerateShearMatrix(out Matrix4x4 matrix, float left, float right, float bottom, float top, float near, float far, float cameraZ)
	{
	}

	// Token: 0x060000E8 RID: 232 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000E8")]
	[Address(RVA = "0x330B50", Offset = "0x32FD50", VA = "0x180330B50")]
	public WorldCamera()
	{
	}

	// Token: 0x040000C3 RID: 195
	[Token(Token = "0x40000C3")]
	[FieldOffset(Offset = "0x20")]
	public bool SnapPosition;

	// Token: 0x040000C4 RID: 196
	[Token(Token = "0x40000C4")]
	[FieldOffset(Offset = "0x24")]
	public float PixelsPerUnit;

	// Token: 0x040000C5 RID: 197
	[Token(Token = "0x40000C5")]
	[FieldOffset(Offset = "0x28")]
	public Vector2 ReferenceResolution;

	// Token: 0x040000C6 RID: 198
	[Token(Token = "0x40000C6")]
	[FieldOffset(Offset = "0x30")]
	public Vector2 WorldPosition;

	// Token: 0x040000C7 RID: 199
	[Token(Token = "0x40000C7")]
	[FieldOffset(Offset = "0x38")]
	private Camera _camera;

	// Token: 0x040000C8 RID: 200
	[Token(Token = "0x40000C8")]
	[FieldOffset(Offset = "0x40")]
	private Option _worldScaleOption;
}
