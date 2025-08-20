using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001DF RID: 479
[Token(Token = "0x20001DF")]
public abstract class AttackRepresentation : MonoBehaviour
{
	// Token: 0x170000EC RID: 236
	// (get) Token: 0x060009A9 RID: 2473 RVA: 0x00004758 File Offset: 0x00002958
	// (set) Token: 0x060009AA RID: 2474 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000EC")]
	public Attack Attack
	{
		[Token(Token = "0x60009A9")]
		[Address(RVA = "0x41FAC0", Offset = "0x41ECC0", VA = "0x18041FAC0")]
		[CompilerGenerated]
		get
		{
			return default(Attack);
		}
		[Token(Token = "0x60009AA")]
		[Address(RVA = "0x41FB90", Offset = "0x41ED90", VA = "0x18041FB90")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x170000ED RID: 237
	// (get) Token: 0x060009AB RID: 2475 RVA: 0x0000206A File Offset: 0x0000026A
	// (set) Token: 0x060009AC RID: 2476 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000ED")]
	private protected World World
	{
		[Token(Token = "0x60009AB")]
		[Address(RVA = "0x3DCFA0", Offset = "0x3DC1A0", VA = "0x1803DCFA0")]
		[CompilerGenerated]
		protected get
		{
			return null;
		}
		[Token(Token = "0x60009AC")]
		[Address(RVA = "0x3DCFD0", Offset = "0x3DC1D0", VA = "0x1803DCFD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x170000EE RID: 238
	// (get) Token: 0x060009AD RID: 2477 RVA: 0x00004770 File Offset: 0x00002970
	[Token(Token = "0x170000EE")]
	protected bool IsPlayer
	{
		[Token(Token = "0x60009AD")]
		[Address(RVA = "0x41FB30", Offset = "0x41ED30", VA = "0x18041FB30")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170000EF RID: 239
	// (get) Token: 0x060009AE RID: 2478 RVA: 0x00004788 File Offset: 0x00002988
	// (set) Token: 0x060009AF RID: 2479 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000EF")]
	private protected bool IsLive
	{
		[Token(Token = "0x60009AE")]
		[Address(RVA = "0x41FB20", Offset = "0x41ED20", VA = "0x18041FB20")]
		[CompilerGenerated]
		protected get
		{
			return default(bool);
		}
		[Token(Token = "0x60009AF")]
		[Address(RVA = "0x41FBF0", Offset = "0x41EDF0", VA = "0x18041FBF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x170000F0 RID: 240
	// (get) Token: 0x060009B0 RID: 2480 RVA: 0x000047A0 File Offset: 0x000029A0
	// (set) Token: 0x060009B1 RID: 2481 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000F0")]
	private protected bool Sfx
	{
		[Token(Token = "0x60009B0")]
		[Address(RVA = "0x41FB80", Offset = "0x41ED80", VA = "0x18041FB80")]
		[CompilerGenerated]
		protected get
		{
			return default(bool);
		}
		[Token(Token = "0x60009B1")]
		[Address(RVA = "0x41FC10", Offset = "0x41EE10", VA = "0x18041FC10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x170000F1 RID: 241
	// (get) Token: 0x060009B2 RID: 2482 RVA: 0x000047B8 File Offset: 0x000029B8
	// (set) Token: 0x060009B3 RID: 2483 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000F1")]
	private protected bool IsEnemy
	{
		[Token(Token = "0x60009B2")]
		[Address(RVA = "0x41FB10", Offset = "0x41ED10", VA = "0x18041FB10")]
		[CompilerGenerated]
		protected get
		{
			return default(bool);
		}
		[Token(Token = "0x60009B3")]
		[Address(RVA = "0x41FBE0", Offset = "0x41EDE0", VA = "0x18041FBE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x170000F2 RID: 242
	// (get) Token: 0x060009B4 RID: 2484 RVA: 0x000047D0 File Offset: 0x000029D0
	// (set) Token: 0x060009B5 RID: 2485 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000F2")]
	private protected float Opacity
	{
		[Token(Token = "0x60009B4")]
		[Address(RVA = "0x41FB70", Offset = "0x41ED70", VA = "0x18041FB70")]
		[CompilerGenerated]
		protected get
		{
			return 0f;
		}
		[Token(Token = "0x60009B5")]
		[Address(RVA = "0x41FC00", Offset = "0x41EE00", VA = "0x18041FC00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x060009B6 RID: 2486 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009B6")]
	[Address(RVA = "0x41F540", Offset = "0x41E740", VA = "0x18041F540")]
	public void Expire()
	{
	}

	// Token: 0x060009B7 RID: 2487 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009B7")]
	[Address(RVA = "0x41F580", Offset = "0x41E780", VA = "0x18041F580")]
	public void Setup(Attack attack, World world, bool sfx, float opacity, bool isEnemy)
	{
	}

	// Token: 0x060009B8 RID: 2488 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009B8")]
	[Address(RVA = "0x41F570", Offset = "0x41E770", VA = "0x18041F570", Slot = "4")]
	protected virtual void LateUpdate()
	{
	}

	// Token: 0x060009B9 RID: 2489 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009B9")]
	[Address(RVA = "0x316090", Offset = "0x315290", VA = "0x180316090", Slot = "5")]
	protected virtual void Live()
	{
	}

	// Token: 0x060009BA RID: 2490 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009BA")]
	[Address(RVA = "0x316090", Offset = "0x315290", VA = "0x180316090", Slot = "6")]
	protected virtual void Return()
	{
	}

	// Token: 0x060009BB RID: 2491 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009BB")]
	[Address(RVA = "0x316090", Offset = "0x315290", VA = "0x180316090", Slot = "7")]
	protected virtual void Setup()
	{
	}

	// Token: 0x060009BC RID: 2492 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009BC")]
	[Address(RVA = "0x41F820", Offset = "0x41EA20", VA = "0x18041F820")]
	private void UpdateLive()
	{
	}

	// Token: 0x060009BD RID: 2493 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009BD")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	protected AttackRepresentation()
	{
	}
}
