using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Il2CppDummyDll;

// Token: 0x020002BD RID: 701
[Token(Token = "0x20002BD")]
public class MedallionShopMenu : Menu
{
	// Token: 0x170001AC RID: 428
	// (get) Token: 0x06000F00 RID: 3840 RVA: 0x00006018 File Offset: 0x00004218
	// (set) Token: 0x06000F01 RID: 3841 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001AC")]
	public bool InPurchase
	{
		[Token(Token = "0x6000F00")]
		[Address(RVA = "0x46F4B0", Offset = "0x46E6B0", VA = "0x18046F4B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000F01")]
		[Address(RVA = "0x46F4C0", Offset = "0x46E6C0", VA = "0x18046F4C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x06000F02 RID: 3842 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F02")]
	[Address(RVA = "0x316090", Offset = "0x315290", VA = "0x180316090")]
	public static void InitIapManager()
	{
	}

	// Token: 0x06000F03 RID: 3843 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F03")]
	[Address(RVA = "0x46EE20", Offset = "0x46E020", VA = "0x18046EE20")]
	public void StartPurchase(MedallionShop medallionShop)
	{
	}

	// Token: 0x06000F04 RID: 3844 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000F04")]
	[Address(RVA = "0x46EB70", Offset = "0x46DD70", VA = "0x18046EB70")]
	private Task DoPurchaseAsync(string productId)
	{
		return null;
	}

	// Token: 0x06000F05 RID: 3845 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F05")]
	[Address(RVA = "0x46EA30", Offset = "0x46DC30", VA = "0x18046EA30")]
	private void Awake()
	{
	}

	// Token: 0x06000F06 RID: 3846 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F06")]
	[Address(RVA = "0x46ED00", Offset = "0x46DF00", VA = "0x18046ED00")]
	private void OnEnable()
	{
	}

	// Token: 0x06000F07 RID: 3847 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F07")]
	[Address(RVA = "0x46F160", Offset = "0x46E360", VA = "0x18046F160")]
	private void UpdatePending()
	{
	}

	// Token: 0x06000F08 RID: 3848 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000F08")]
	[Address(RVA = "0x46EC60", Offset = "0x46DE60", VA = "0x18046EC60")]
	private IEnumerable<string> GetPendingProducts()
	{
		return null;
	}

	// Token: 0x06000F09 RID: 3849 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000F09")]
	[Address(RVA = "0x46ED10", Offset = "0x46DF10", VA = "0x18046ED10")]
	private Task PurchaseAsync(string productId)
	{
		return null;
	}

	// Token: 0x06000F0A RID: 3850 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F0A")]
	[Address(RVA = "0x3BC980", Offset = "0x3BBB80", VA = "0x1803BC980")]
	public MedallionShopMenu()
	{
	}

	// Token: 0x04000C63 RID: 3171
	[Token(Token = "0x4000C63")]
	[FieldOffset(Offset = "0x90")]
	public MedallionShop[] Shops;

	// Token: 0x04000C64 RID: 3172
	[Token(Token = "0x4000C64")]
	[FieldOffset(Offset = "0x98")]
	private Dictionary<string, MedallionShop> _productShopMap;
}
