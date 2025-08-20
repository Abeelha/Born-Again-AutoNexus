using System;
using Il2CppDummyDll;
using Ronin.Model.Files.Animation;
using UnityEngine;

// Token: 0x02000019 RID: 25
[Token(Token = "0x2000019")]
public interface IAnimatedObject
{
	// Token: 0x0600008D RID: 141
	[Token(Token = "0x600008D")]
	void SetColor(Color color);

	// Token: 0x0600008E RID: 142
	[Token(Token = "0x600008E")]
	void SetLayer(int layer);

	// Token: 0x0600008F RID: 143
	[Token(Token = "0x600008F")]
	void SetSprite(AnimationFrame frame);

	// Token: 0x06000090 RID: 144
	[Token(Token = "0x6000090")]
	void SetFlipped(bool value);
}
