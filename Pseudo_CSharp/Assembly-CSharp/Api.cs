using System;
using System.Threading.Tasks;
using Il2CppDummyDll;
using Ronin.Api.Model;
using Ronin.Api.Model.Hello;
using UnnamedStudios.Common.Model;

// Token: 0x0200001B RID: 27
[Token(Token = "0x200001B")]
public class Api
{
	// Token: 0x1700000D RID: 13
	// (get) Token: 0x060000B5 RID: 181 RVA: 0x0000206A File Offset: 0x0000026A
	// (set) Token: 0x060000B6 RID: 182 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700000D")]
	public static string Url
	{
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x31A990", Offset = "0x319B90", VA = "0x18031A990")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x31A9D0", Offset = "0x319BD0", VA = "0x18031A9D0")]
		set
		{
		}
	}

	// Token: 0x060000B7 RID: 183 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x31A3A0", Offset = "0x3195A0", VA = "0x18031A3A0")]
	public static void ClearClient()
	{
	}

	// Token: 0x060000B8 RID: 184 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x31A530", Offset = "0x319730", VA = "0x18031A530")]
	public static RoninApiClient GetClient()
	{
		return null;
	}

	// Token: 0x060000B9 RID: 185 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x31A4D0", Offset = "0x3196D0", VA = "0x18031A4D0")]
	public static Task Delay()
	{
		return null;
	}

	// Token: 0x060000BA RID: 186 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x31A6D0", Offset = "0x3198D0", VA = "0x18031A6D0")]
	public static Task<ServiceResponse<HelloResponse>> HelloAsync()
	{
		return null;
	}

	// Token: 0x060000BB RID: 187 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x31A8B0", Offset = "0x319AB0", VA = "0x18031A8B0")]
	public static Task<ServiceResponse> UpdateDataIfOldAsync()
	{
		return null;
	}

	// Token: 0x060000BC RID: 188 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x31A7B0", Offset = "0x3199B0", VA = "0x18031A7B0")]
	public static Task<ServiceResponse> UpdateDataAsync()
	{
		return null;
	}

	// Token: 0x060000BD RID: 189 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x31A420", Offset = "0x319620", VA = "0x18031A420")]
	private static RoninApiClient CreateClient()
	{
		return null;
	}

	// Token: 0x0400008F RID: 143
	[Token(Token = "0x400008F")]
	[FieldOffset(Offset = "0x0")]
	private static string _url;

	// Token: 0x04000090 RID: 144
	[Token(Token = "0x4000090")]
	[FieldOffset(Offset = "0x8")]
	private static RoninApiClient _client;
}
