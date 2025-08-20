using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Ronin.Model.Structs;
using UnityEngine;

// Token: 0x02000255 RID: 597
[Token(Token = "0x2000255")]
public interface IPickupContainer
{
	// Token: 0x17000114 RID: 276
	// (get) Token: 0x06000B39 RID: 2873
	[Token(Token = "0x17000114")]
	uint EntityId { [Token(Token = "0x6000B39")] get; }

	// Token: 0x17000115 RID: 277
	// (get) Token: 0x06000B3A RID: 2874
	[Token(Token = "0x17000115")]
	Vector2 Position { [Token(Token = "0x6000B3A")] get; }

	// Token: 0x06000B3B RID: 2875
	[Token(Token = "0x6000B3B")]
	IEnumerable<ValueTuple<ItemValue, int>> GetItems();

	// Token: 0x06000B3C RID: 2876
	[Token(Token = "0x6000B3C")]
	void PlaySfx();
}
