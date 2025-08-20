using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x02000149 RID: 329
[Token(Token = "0x2000149")]
public class GameObjectPoolingManager : MonoBehaviour
{
	// Token: 0x060005DD RID: 1501 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60005DD")]
	[Address(RVA = "0x3EFB30", Offset = "0x3EED30", VA = "0x1803EFB30")]
	public static GameObjectPool CreatePool(GameObject gameObject, [Optional] Type configType)
	{
		return null;
	}

	// Token: 0x060005DE RID: 1502 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005DE")]
	[Address(RVA = "0x3F0100", Offset = "0x3EF300", VA = "0x1803F0100")]
	public static void SetConfigurationOverride(string key)
	{
	}

	// Token: 0x060005DF RID: 1503 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005DF")]
	[Address(RVA = "0x3F03C0", Offset = "0x3EF5C0", VA = "0x1803F03C0")]
	public static void Trim()
	{
	}

	// Token: 0x060005E0 RID: 1504 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005E0")]
	[Address(RVA = "0x3EFE30", Offset = "0x3EF030", VA = "0x1803EFE30")]
	private static void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
	}

	// Token: 0x060005E1 RID: 1505 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005E1")]
	[Address(RVA = "0x3EFE70", Offset = "0x3EF070", VA = "0x1803EFE70")]
	private static void ResetPools()
	{
	}

	// Token: 0x060005E2 RID: 1506 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005E2")]
	[Address(RVA = "0x3EFAA0", Offset = "0x3EECA0", VA = "0x1803EFAA0")]
	private void Awake()
	{
	}

	// Token: 0x060005E3 RID: 1507 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005E3")]
	[Address(RVA = "0x3EFDF0", Offset = "0x3EEFF0", VA = "0x1803EFDF0")]
	private void LateUpdate()
	{
	}

	// Token: 0x060005E4 RID: 1508 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005E4")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public GameObjectPoolingManager()
	{
	}

	// Token: 0x04000688 RID: 1672
	[Token(Token = "0x4000688")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly List<GameObjectPool> s_pools;
}
