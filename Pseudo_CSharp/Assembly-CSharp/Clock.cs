using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Ronin.Model.Data;
using UnityEngine;
using Zero.Game.Shared;

// Token: 0x02000184 RID: 388
[Token(Token = "0x2000184")]
public class Clock : MonoBehaviour, IDataHandler<TimeData>
{
	// Token: 0x170000B6 RID: 182
	// (get) Token: 0x060007A1 RID: 1953 RVA: 0x00003EE8 File Offset: 0x000020E8
	// (set) Token: 0x060007A2 RID: 1954 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000B6")]
	public float Progress
	{
		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x40D2E0", Offset = "0x40C4E0", VA = "0x18040D2E0")]
		[CompilerGenerated]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x40D320", Offset = "0x40C520", VA = "0x18040D320")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x060007A3 RID: 1955 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007A3")]
	[Address(RVA = "0x40D0C0", Offset = "0x40C2C0", VA = "0x18040D0C0")]
	public void Clear()
	{
	}

	// Token: 0x060007A4 RID: 1956 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007A4")]
	[Address(RVA = "0x40D120", Offset = "0x40C320", VA = "0x18040D120", Slot = "4")]
	public void HandleData(ref TimeData data)
	{
	}

	// Token: 0x060007A5 RID: 1957 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007A5")]
	[Address(RVA = "0x40D170", Offset = "0x40C370", VA = "0x18040D170")]
	private void LateUpdate()
	{
	}

	// Token: 0x060007A6 RID: 1958 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007A6")]
	[Address(RVA = "0x40D1A0", Offset = "0x40C3A0", VA = "0x18040D1A0")]
	private void UpdateClock(float delta)
	{
	}

	// Token: 0x060007A7 RID: 1959 RVA: 0x00003F00 File Offset: 0x00002100
	[Token(Token = "0x60007A7")]
	[Address(RVA = "0x40D2F0", Offset = "0x40C4F0", VA = "0x18040D2F0")]
	private float mod(float x, float m)
	{
		return 0f;
	}

	// Token: 0x060007A8 RID: 1960 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007A8")]
	[Address(RVA = "0x40D2D0", Offset = "0x40C4D0", VA = "0x18040D2D0")]
	public Clock()
	{
	}

	// Token: 0x040007A8 RID: 1960
	[Token(Token = "0x40007A8")]
	[FieldOffset(Offset = "0x20")]
	public RectTransform Dial;

	// Token: 0x040007A9 RID: 1961
	[Token(Token = "0x40007A9")]
	[FieldOffset(Offset = "0x28")]
	private bool _first;
}
