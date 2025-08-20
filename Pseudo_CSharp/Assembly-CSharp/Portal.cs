using System;
using Il2CppDummyDll;
using Ronin.Model.Data;
using Zero.Game.Shared;

// Token: 0x02000290 RID: 656
[Token(Token = "0x2000290")]
public class Portal : Entity, IDataHandler<PortalData>
{
	// Token: 0x17000183 RID: 387
	// (get) Token: 0x06000DC1 RID: 3521 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x17000183")]
	public override string EntityName
	{
		[Token(Token = "0x6000DC1")]
		[Address(RVA = "0x45AC10", Offset = "0x459E10", VA = "0x18045AC10", Slot = "57")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000184 RID: 388
	// (get) Token: 0x06000DC2 RID: 3522 RVA: 0x00005B20 File Offset: 0x00003D20
	[Token(Token = "0x17000184")]
	public override WorldObjectType Type
	{
		[Token(Token = "0x6000DC2")]
		[Address(RVA = "0x45AC80", Offset = "0x459E80", VA = "0x18045AC80", Slot = "13")]
		get
		{
			return (WorldObjectType)0;
		}
	}

	// Token: 0x06000DC3 RID: 3523 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DC3")]
	[Address(RVA = "0x45A820", Offset = "0x459A20", VA = "0x18045A820", Slot = "65")]
	public void HandleData(ref PortalData data)
	{
	}

	// Token: 0x06000DC4 RID: 3524 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DC4")]
	[Address(RVA = "0x45AA20", Offset = "0x459C20", VA = "0x18045AA20", Slot = "32")]
	protected override void OnEnable()
	{
	}

	// Token: 0x06000DC5 RID: 3525 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DC5")]
	[Address(RVA = "0x45AA60", Offset = "0x459C60", VA = "0x18045AA60")]
	private void UpdateEntityName()
	{
	}

	// Token: 0x06000DC6 RID: 3526 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DC6")]
	[Address(RVA = "0x44F050", Offset = "0x44E250", VA = "0x18044F050")]
	public Portal()
	{
	}

	// Token: 0x04000B45 RID: 2885
	[Token(Token = "0x4000B45")]
	[FieldOffset(Offset = "0x200")]
	private PortalData? _data;

	// Token: 0x04000B46 RID: 2886
	[Token(Token = "0x4000B46")]
	[FieldOffset(Offset = "0x210")]
	private string _name;
}
