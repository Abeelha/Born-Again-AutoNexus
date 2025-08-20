using System;
using Il2CppDummyDll;
using UnityEngine.UI;

// Token: 0x0200019D RID: 413
[Token(Token = "0x200019D")]
public class NonDrawingGraphic : Graphic
{
	// Token: 0x06000862 RID: 2146 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000862")]
	[Address(RVA = "0x316090", Offset = "0x315290", VA = "0x180316090", Slot = "29")]
	public override void SetMaterialDirty()
	{
	}

	// Token: 0x06000863 RID: 2147 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000863")]
	[Address(RVA = "0x316090", Offset = "0x315290", VA = "0x180316090", Slot = "28")]
	public override void SetVerticesDirty()
	{
	}

	// Token: 0x06000864 RID: 2148 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000864")]
	[Address(RVA = "0x419060", Offset = "0x418260", VA = "0x180419060", Slot = "43")]
	protected override void OnPopulateMesh(VertexHelper vh)
	{
	}

	// Token: 0x06000865 RID: 2149 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000865")]
	[Address(RVA = "0x419080", Offset = "0x418280", VA = "0x180419080")]
	public NonDrawingGraphic()
	{
	}
}
