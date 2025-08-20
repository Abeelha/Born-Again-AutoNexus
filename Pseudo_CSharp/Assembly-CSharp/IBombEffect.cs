using System;
using Il2CppDummyDll;
using Ronin.Model.Classes;
using Zero.Game.Shared;

// Token: 0x02000254 RID: 596
[Token(Token = "0x2000254")]
internal interface IBombEffect
{
	// Token: 0x06000B38 RID: 2872
	[Token(Token = "0x6000B38")]
	void Setup(World world, AttackDescriptor attackDescriptor, Vec2 finalCoordinates);
}
