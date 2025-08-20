using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002D6 RID: 726
[Token(Token = "0x20002D6")]
public class OrbSoul : MonoBehaviour
{
	// Token: 0x06000FBC RID: 4028 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FBC")]
	[Address(RVA = "0x353100", Offset = "0x352300", VA = "0x180353100")]
	public void SetCallback(Action action)
	{
	}

	// Token: 0x06000FBD RID: 4029 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FBD")]
	[Address(RVA = "0x352FE0", Offset = "0x3521E0", VA = "0x180352FE0")]
	private void OnEnable()
	{
	}

	// Token: 0x06000FBE RID: 4030 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FBE")]
	[Address(RVA = "0x352E60", Offset = "0x352060", VA = "0x180352E60")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000FBF RID: 4031 RVA: 0x00006390 File Offset: 0x00004590
	[Token(Token = "0x6000FBF")]
	[Address(RVA = "0x352D50", Offset = "0x351F50", VA = "0x180352D50")]
	private Vector2 GetPosition()
	{
		return default(Vector2);
	}

	// Token: 0x06000FC0 RID: 4032 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FC0")]
	[Address(RVA = "0x353110", Offset = "0x352310", VA = "0x180353110")]
	public OrbSoul()
	{
	}

	// Token: 0x04000D0B RID: 3339
	[Token(Token = "0x4000D0B")]
	[FieldOffset(Offset = "0x20")]
	public Vector2 TargetPosition;

	// Token: 0x04000D0C RID: 3340
	[Token(Token = "0x4000D0C")]
	[FieldOffset(Offset = "0x28")]
	public float Duration;

	// Token: 0x04000D0D RID: 3341
	[Token(Token = "0x4000D0D")]
	[FieldOffset(Offset = "0x2C")]
	public float Magnitude;

	// Token: 0x04000D0E RID: 3342
	[Token(Token = "0x4000D0E")]
	[FieldOffset(Offset = "0x30")]
	private float _scale;

	// Token: 0x04000D0F RID: 3343
	[Token(Token = "0x4000D0F")]
	[FieldOffset(Offset = "0x34")]
	private float _t;

	// Token: 0x04000D10 RID: 3344
	[Token(Token = "0x4000D10")]
	[FieldOffset(Offset = "0x38")]
	private Vector2 _startPosition;

	// Token: 0x04000D11 RID: 3345
	[Token(Token = "0x4000D11")]
	[FieldOffset(Offset = "0x40")]
	private Vector2 _startHandle;

	// Token: 0x04000D12 RID: 3346
	[Token(Token = "0x4000D12")]
	[FieldOffset(Offset = "0x48")]
	private Action _callback;
}
