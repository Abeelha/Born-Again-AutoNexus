using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000034 RID: 52
[Token(Token = "0x2000034")]
public class MeshMetaData
{
	// Token: 0x06000120 RID: 288 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000120")]
	[Address(RVA = "0x3288B0", Offset = "0x327AB0", VA = "0x1803288B0")]
	public MeshMetaData(Mesh mesh)
	{
	}

	// Token: 0x17000011 RID: 17
	// (get) Token: 0x06000121 RID: 289 RVA: 0x00002568 File Offset: 0x00000768
	[Token(Token = "0x17000011")]
	public Vector3 Min
	{
		[Token(Token = "0x6000121")]
		[Address(RVA = "0x328AD0", Offset = "0x327CD0", VA = "0x180328AD0")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	// Token: 0x06000122 RID: 290 RVA: 0x00002580 File Offset: 0x00000780
	[Token(Token = "0x6000122")]
	[Address(RVA = "0x3286B0", Offset = "0x3278B0", VA = "0x1803286B0")]
	private ValueTuple<Vector3, Vector3> GetMinMax(Mesh mesh)
	{
		return default(ValueTuple<Vector3, Vector3>);
	}
}
