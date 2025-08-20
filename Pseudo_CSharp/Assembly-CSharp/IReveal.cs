using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200026E RID: 622
[Token(Token = "0x200026E")]
public interface IReveal
{
	// Token: 0x1700011D RID: 285
	// (get) Token: 0x06000BFE RID: 3070
	[Token(Token = "0x1700011D")]
	bool CanAdd { [Token(Token = "0x6000BFE")] get; }

	// Token: 0x1700011E RID: 286
	// (get) Token: 0x06000BFF RID: 3071
	[Token(Token = "0x1700011E")]
	ushort Type { [Token(Token = "0x6000BFF")] get; }

	// Token: 0x1700011F RID: 287
	// (get) Token: 0x06000C00 RID: 3072
	// (set) Token: 0x06000C01 RID: 3073
	[Token(Token = "0x1700011F")]
	float Time { [Token(Token = "0x6000C00")] get; [Token(Token = "0x6000C01")] set; }

	// Token: 0x17000120 RID: 288
	// (get) Token: 0x06000C02 RID: 3074
	// (set) Token: 0x06000C03 RID: 3075
	[Token(Token = "0x17000120")]
	bool Cleared { [Token(Token = "0x6000C02")] get; [Token(Token = "0x6000C03")] set; }

	// Token: 0x06000C04 RID: 3076
	[Token(Token = "0x6000C04")]
	void Add(Vector2Int point);

	// Token: 0x06000C05 RID: 3077
	[Token(Token = "0x6000C05")]
	float GetAlpha(Vector2 referencePoint);

	// Token: 0x06000C06 RID: 3078
	[Token(Token = "0x6000C06")]
	IEnumerable<Vector2Int> GetPoints();

	// Token: 0x06000C07 RID: 3079
	[Token(Token = "0x6000C07")]
	void Remove(Vector2Int point);
}
