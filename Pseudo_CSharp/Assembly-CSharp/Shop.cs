using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Ronin.Model.Data;
using Ronin.Model.Definitions;
using Zero.Game.Shared;

// Token: 0x02000291 RID: 657
[Token(Token = "0x2000291")]
public class Shop : Entity, IDataHandler<ShopData>
{
	// Token: 0x17000185 RID: 389
	// (get) Token: 0x06000DC7 RID: 3527 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x17000185")]
	public override string EntityName
	{
		[Token(Token = "0x6000DC7")]
		[Address(RVA = "0x45AE60", Offset = "0x45A060", VA = "0x18045AE60", Slot = "57")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000186 RID: 390
	// (get) Token: 0x06000DC8 RID: 3528 RVA: 0x00005B38 File Offset: 0x00003D38
	[Token(Token = "0x17000186")]
	public override WorldObjectType Type
	{
		[Token(Token = "0x6000DC8")]
		[Address(RVA = "0x45AE80", Offset = "0x45A080", VA = "0x18045AE80", Slot = "13")]
		get
		{
			return (WorldObjectType)0;
		}
	}

	// Token: 0x17000187 RID: 391
	// (get) Token: 0x06000DC9 RID: 3529 RVA: 0x00005B50 File Offset: 0x00003D50
	// (set) Token: 0x06000DCA RID: 3530 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000187")]
	public ShopData Data
	{
		[Token(Token = "0x6000DC9")]
		[Address(RVA = "0x45AE30", Offset = "0x45A030", VA = "0x18045AE30")]
		[CompilerGenerated]
		get
		{
			return default(ShopData);
		}
		[Token(Token = "0x6000DCA")]
		[Address(RVA = "0x45AE90", Offset = "0x45A090", VA = "0x18045AE90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x06000DCB RID: 3531 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DCB")]
	[Address(RVA = "0x45AC90", Offset = "0x459E90", VA = "0x18045AC90", Slot = "65")]
	public void HandleData(ref ShopData data)
	{
	}

	// Token: 0x06000DCC RID: 3532 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DCC")]
	[Address(RVA = "0x45AD20", Offset = "0x459F20", VA = "0x18045AD20", Slot = "32")]
	protected override void OnEnable()
	{
	}

	// Token: 0x06000DCD RID: 3533 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DCD")]
	[Address(RVA = "0x45ADB0", Offset = "0x459FB0", VA = "0x18045ADB0")]
	private void SetData(ShopData data)
	{
	}

	// Token: 0x06000DCE RID: 3534 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DCE")]
	[Address(RVA = "0x44F050", Offset = "0x44E250", VA = "0x18044F050")]
	public Shop()
	{
	}

	// Token: 0x04000B47 RID: 2887
	[Token(Token = "0x4000B47")]
	[FieldOffset(Offset = "0x200")]
	private ObjectDefinition _item;
}
