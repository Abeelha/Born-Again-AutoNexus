using System;
using Il2CppDummyDll;

// Token: 0x02000089 RID: 137
[Token(Token = "0x2000089")]
public interface IControlInput
{
	// Token: 0x1700002B RID: 43
	// (get) Token: 0x06000265 RID: 613 RVA: 0x00002E08 File Offset: 0x00001008
	[Token(Token = "0x1700002B")]
	bool FullActive
	{
		[Token(Token = "0x6000265")]
		[Address(RVA = "0x33BA10", Offset = "0x33AC10", VA = "0x18033BA10", Slot = "0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700002C RID: 44
	// (get) Token: 0x06000266 RID: 614
	[Token(Token = "0x1700002C")]
	bool Active { [Token(Token = "0x6000266")] get; }

	// Token: 0x1700002D RID: 45
	// (get) Token: 0x06000267 RID: 615
	[Token(Token = "0x1700002D")]
	bool ActiveInHeirarchy { [Token(Token = "0x6000267")] get; }

	// Token: 0x1700002E RID: 46
	// (get) Token: 0x06000268 RID: 616
	[Token(Token = "0x1700002E")]
	bool Aiming { [Token(Token = "0x6000268")] get; }

	// Token: 0x1700002F RID: 47
	// (get) Token: 0x06000269 RID: 617
	[Token(Token = "0x1700002F")]
	float Angle { [Token(Token = "0x6000269")] get; }

	// Token: 0x17000030 RID: 48
	// (get) Token: 0x0600026A RID: 618
	[Token(Token = "0x17000030")]
	float Magnitude { [Token(Token = "0x600026A")] get; }
}
