using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000342 RID: 834
[Token(Token = "0x2000342")]
public class WorldCameraLerper : MonoBehaviour
{
	// Token: 0x0600126B RID: 4715 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600126B")]
	[Address(RVA = "0x3855D0", Offset = "0x3847D0", VA = "0x1803855D0")]
	public void SetLerp(Vector2 from, Vector2 to)
	{
	}

	// Token: 0x0600126C RID: 4716 RVA: 0x00006990 File Offset: 0x00004B90
	[Token(Token = "0x600126C")]
	[Address(RVA = "0x385530", Offset = "0x384730", VA = "0x180385530")]
	private static Vector2 GetCameraPosition(Vector2 from, Vector2 to, float time)
	{
		return default(Vector2);
	}

	// Token: 0x0600126D RID: 4717 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600126D")]
	[Address(RVA = "0x3855C0", Offset = "0x3847C0", VA = "0x1803855C0")]
	private void LateUpdate()
	{
	}

	// Token: 0x0600126E RID: 4718 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600126E")]
	[Address(RVA = "0x3855E0", Offset = "0x3847E0", VA = "0x1803855E0")]
	private void UpdatePosition()
	{
	}

	// Token: 0x0600126F RID: 4719 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600126F")]
	[Address(RVA = "0x385710", Offset = "0x384910", VA = "0x180385710")]
	public WorldCameraLerper()
	{
	}

	// Token: 0x04000F1A RID: 3866
	[Token(Token = "0x4000F1A")]
	[FieldOffset(Offset = "0x20")]
	private Vector2 _from;

	// Token: 0x04000F1B RID: 3867
	[Token(Token = "0x4000F1B")]
	[FieldOffset(Offset = "0x28")]
	private Vector2 _to;

	// Token: 0x04000F1C RID: 3868
	[Token(Token = "0x4000F1C")]
	[FieldOffset(Offset = "0x30")]
	public World World;

	// Token: 0x04000F1D RID: 3869
	[Token(Token = "0x4000F1D")]
	[FieldOffset(Offset = "0x38")]
	public float Speed;
}
