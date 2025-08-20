using System;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000021 RID: 33
[Token(Token = "0x2000021")]
public class Loader : MonoBehaviour
{
	// Token: 0x060000CC RID: 204 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x327E20", Offset = "0x327020", VA = "0x180327E20")]
	private void Awake()
	{
	}

	// Token: 0x060000CD RID: 205 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x328050", Offset = "0x327250", VA = "0x180328050")]
	private Task InitUnityGamingServicesAsync()
	{
		return null;
	}

	// Token: 0x060000CE RID: 206 RVA: 0x00002460 File Offset: 0x00000660
	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x3285D0", Offset = "0x3277D0", VA = "0x1803285D0")]
	private bool LoaderExists()
	{
		return default(bool);
	}

	// Token: 0x060000CF RID: 207 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x328100", Offset = "0x327300", VA = "0x180328100")]
	public void Load()
	{
	}

	// Token: 0x060000D0 RID: 208 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public Loader()
	{
	}

	// Token: 0x040000A7 RID: 167
	[Token(Token = "0x40000A7")]
	[FieldOffset(Offset = "0x20")]
	public string LocalApiUrl;

	// Token: 0x040000A8 RID: 168
	[Token(Token = "0x40000A8")]
	[FieldOffset(Offset = "0x28")]
	public string DevelopmentApiUrl;

	// Token: 0x040000A9 RID: 169
	[Token(Token = "0x40000A9")]
	[FieldOffset(Offset = "0x30")]
	public string TestApiUrl;

	// Token: 0x040000AA RID: 170
	[Token(Token = "0x40000AA")]
	[FieldOffset(Offset = "0x38")]
	public string ProductionApiUrl;

	// Token: 0x040000AB RID: 171
	[Token(Token = "0x40000AB")]
	[FieldOffset(Offset = "0x40")]
	public bool ForceLocal;

	// Token: 0x040000AC RID: 172
	[Token(Token = "0x40000AC")]
	[FieldOffset(Offset = "0x41")]
	public bool ForceDev;

	// Token: 0x040000AD RID: 173
	[Token(Token = "0x40000AD")]
	[FieldOffset(Offset = "0x42")]
	public bool ForceTest;

	// Token: 0x040000AE RID: 174
	[Token(Token = "0x40000AE")]
	[FieldOffset(Offset = "0x43")]
	public bool ForceProduction;
}
