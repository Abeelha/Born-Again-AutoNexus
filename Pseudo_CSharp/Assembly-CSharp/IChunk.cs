using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000275 RID: 629
[Token(Token = "0x2000275")]
public interface IChunk
{
	// Token: 0x17000131 RID: 305
	// (get) Token: 0x06000C49 RID: 3145
	// (set) Token: 0x06000C4A RID: 3146
	[Token(Token = "0x17000131")]
	Vector2Int Index { [Token(Token = "0x6000C49")] get; [Token(Token = "0x6000C4A")] set; }

	// Token: 0x17000132 RID: 306
	// (set) Token: 0x06000C4B RID: 3147
	[Token(Token = "0x17000132")]
	Vector2Int Position { [Token(Token = "0x6000C4B")] set; }

	// Token: 0x17000133 RID: 307
	// (get) Token: 0x06000C4C RID: 3148
	// (set) Token: 0x06000C4D RID: 3149
	[Token(Token = "0x17000133")]
	Vector2Int Zone { [Token(Token = "0x6000C4C")] get; [Token(Token = "0x6000C4D")] set; }

	// Token: 0x06000C4E RID: 3150
	[Token(Token = "0x6000C4E")]
	void Create(Vector2Int size);

	// Token: 0x06000C4F RID: 3151
	[Token(Token = "0x6000C4F")]
	void SetActive(bool active);
}
