using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000147 RID: 327
[Token(Token = "0x2000147")]
public class GameObjectPool
{
	// Token: 0x060005CD RID: 1485 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005CD")]
	[Address(RVA = "0x3EF930", Offset = "0x3EEB30", VA = "0x1803EF930")]
	public GameObjectPool(GameObject prefab, PoolConfiguration configuration, [Optional] Type poolType)
	{
	}

	// Token: 0x17000073 RID: 115
	// (get) Token: 0x060005CE RID: 1486 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x17000073")]
	public Type PoolType
	{
		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x3A3060", Offset = "0x3A2260", VA = "0x1803A3060")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	// Token: 0x17000074 RID: 116
	// (get) Token: 0x060005CF RID: 1487 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x17000074")]
	public PoolConfiguration Configuration
	{
		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x3944E0", Offset = "0x3936E0", VA = "0x1803944E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	// Token: 0x17000075 RID: 117
	// (get) Token: 0x060005D0 RID: 1488 RVA: 0x0000206A File Offset: 0x0000026A
	// (set) Token: 0x060005D1 RID: 1489 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000075")]
	public PoolConfiguration ConfigurationOverride
	{
		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x34FD40", Offset = "0x34EF40", VA = "0x18034FD40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x3EFA90", Offset = "0x3EEC90", VA = "0x1803EFA90")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x17000076 RID: 118
	// (get) Token: 0x060005D2 RID: 1490 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x17000076")]
	private PoolConfiguration ConfigurationToUse
	{
		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x3EFA40", Offset = "0x3EEC40", VA = "0x1803EFA40")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000077 RID: 119
	// (get) Token: 0x060005D3 RID: 1491 RVA: 0x000037E0 File Offset: 0x000019E0
	[Token(Token = "0x17000077")]
	private int MinCount
	{
		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x3EFA70", Offset = "0x3EEC70", VA = "0x1803EFA70")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000078 RID: 120
	// (get) Token: 0x060005D4 RID: 1492 RVA: 0x000037F8 File Offset: 0x000019F8
	[Token(Token = "0x17000078")]
	private int MaxRented
	{
		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x3EFA50", Offset = "0x3EEC50", VA = "0x1803EFA50")]
		get
		{
			return 0;
		}
	}

	// Token: 0x060005D5 RID: 1493 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005D5")]
	[Address(RVA = "0x3EEFB0", Offset = "0x3EE1B0", VA = "0x1803EEFB0")]
	public void Clear()
	{
	}

	// Token: 0x060005D6 RID: 1494 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005D6")]
	[Address(RVA = "0x3EF100", Offset = "0x3EE300", VA = "0x1803EF100")]
	public void CreateMinObjects()
	{
	}

	// Token: 0x060005D7 RID: 1495 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60005D7")]
	[Address(RVA = "0x3EF360", Offset = "0x3EE560", VA = "0x1803EF360")]
	public GameObject Get()
	{
		return null;
	}

	// Token: 0x060005D8 RID: 1496 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005D8")]
	[Address(RVA = "0x3EF430", Offset = "0x3EE630", VA = "0x1803EF430")]
	public void Return(GameObject gameObject)
	{
	}

	// Token: 0x060005D9 RID: 1497 RVA: 0x00003810 File Offset: 0x00001A10
	[Token(Token = "0x60005D9")]
	[Address(RVA = "0x3EF560", Offset = "0x3EE760", VA = "0x1803EF560")]
	public int Trim(float maxTimeDif, int maxRemove)
	{
		return 0;
	}

	// Token: 0x060005DA RID: 1498 RVA: 0x00003828 File Offset: 0x00001A28
	[Token(Token = "0x60005DA")]
	[Address(RVA = "0x3EF770", Offset = "0x3EE970", VA = "0x1803EF770")]
	public bool TryGet(out GameObject gameObject, bool ignoreMax = false)
	{
		return default(bool);
	}

	// Token: 0x060005DB RID: 1499 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60005DB")]
	[Address(RVA = "0x3EF300", Offset = "0x3EE500", VA = "0x1803EF300")]
	private GameObject Create()
	{
		return null;
	}

	// Token: 0x060005DC RID: 1500 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005DC")]
	[Address(RVA = "0x3EF6F0", Offset = "0x3EE8F0", VA = "0x1803EF6F0")]
	private void TryDownsize()
	{
	}

	// Token: 0x0400067E RID: 1662
	[Token(Token = "0x400067E")]
	private const int MinCapacity = 32;

	// Token: 0x0400067F RID: 1663
	[Token(Token = "0x400067F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private GameObjectPool.StoredObject[] _objects;

	// Token: 0x04000680 RID: 1664
	[Token(Token = "0x4000680")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private int _count;

	// Token: 0x04000681 RID: 1665
	[Token(Token = "0x4000681")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly GameObject _prefab;

	// Token: 0x04000682 RID: 1666
	[Token(Token = "0x4000682")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private HashSet<GameObject> _rented;

	// Token: 0x02000148 RID: 328
	[Token(Token = "0x2000148")]
	private struct StoredObject
	{
		// Token: 0x04000686 RID: 1670
		[Token(Token = "0x4000686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public GameObject GameObject;

		// Token: 0x04000687 RID: 1671
		[Token(Token = "0x4000687")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float Time;
	}
}
