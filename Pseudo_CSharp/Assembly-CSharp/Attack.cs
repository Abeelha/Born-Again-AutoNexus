using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Ronin.Model.Enums;
using Ronin.Model.Simulation.Components;
using UnityEngine;

// Token: 0x02000176 RID: 374
[Token(Token = "0x2000176")]
public struct Attack : IDisposable
{
	// Token: 0x06000756 RID: 1878 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000756")]
	[Address(RVA = "0x3EC9C0", Offset = "0x3EBBC0", VA = "0x1803EC9C0")]
	public Attack(EntityMasks targetMask, LiveAttack liveAttack, AttackRepresentation representation, AttackFlags flags)
	{
	}

	// Token: 0x170000A5 RID: 165
	// (get) Token: 0x06000757 RID: 1879 RVA: 0x00003CD8 File Offset: 0x00001ED8
	[Token(Token = "0x170000A5")]
	public int ArmorDamage
	{
		[Token(Token = "0x6000757")]
		[Address(RVA = "0x3ECAA0", Offset = "0x3EBCA0", VA = "0x1803ECAA0")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170000A6 RID: 166
	// (get) Token: 0x06000758 RID: 1880 RVA: 0x00003CF0 File Offset: 0x00001EF0
	// (set) Token: 0x06000759 RID: 1881 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000A6")]
	public bool Live
	{
		[Token(Token = "0x6000758")]
		[Address(RVA = "0x3ECB70", Offset = "0x3EBD70", VA = "0x1803ECB70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000759")]
		[Address(RVA = "0x3ECBA0", Offset = "0x3EBDA0", VA = "0x1803ECBA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x170000A7 RID: 167
	// (get) Token: 0x0600075A RID: 1882 RVA: 0x00003D08 File Offset: 0x00001F08
	[Token(Token = "0x170000A7")]
	public EntityMasks TargetMask
	{
		[Token(Token = "0x600075A")]
		[Address(RVA = "0x3ECB90", Offset = "0x3EBD90", VA = "0x1803ECB90")]
		[CompilerGenerated]
		get
		{
			return EntityMasks.None;
		}
	}

	// Token: 0x170000A8 RID: 168
	// (get) Token: 0x0600075B RID: 1883 RVA: 0x00003D20 File Offset: 0x00001F20
	[Token(Token = "0x170000A8")]
	public AttackFlags Flags
	{
		[Token(Token = "0x600075B")]
		[Address(RVA = "0x3ECAB0", Offset = "0x3EBCB0", VA = "0x1803ECAB0")]
		[CompilerGenerated]
		get
		{
			return AttackFlags.None;
		}
	}

	// Token: 0x170000A9 RID: 169
	// (get) Token: 0x0600075C RID: 1884 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x170000A9")]
	public AttackRepresentation Representation
	{
		[Token(Token = "0x600075C")]
		[Address(RVA = "0x3ECB80", Offset = "0x3EBD80", VA = "0x1803ECB80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	// Token: 0x170000AA RID: 170
	// (get) Token: 0x0600075D RID: 1885 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x170000AA")]
	public HashSet<WorldObject> HitsEnvironment
	{
		[Token(Token = "0x600075D")]
		[Address(RVA = "0x3ECAC0", Offset = "0x3EBCC0", VA = "0x1803ECAC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	// Token: 0x170000AB RID: 171
	// (get) Token: 0x0600075E RID: 1886 RVA: 0x00003D38 File Offset: 0x00001F38
	[Token(Token = "0x170000AB")]
	public bool IsBenefitial
	{
		[Token(Token = "0x600075E")]
		[Address(RVA = "0x3ECAE0", Offset = "0x3EBCE0", VA = "0x1803ECAE0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170000AC RID: 172
	// (get) Token: 0x0600075F RID: 1887 RVA: 0x00003D50 File Offset: 0x00001F50
	[Token(Token = "0x170000AC")]
	public bool HurtsPlayer
	{
		[Token(Token = "0x600075F")]
		[Address(RVA = "0x3ECAD0", Offset = "0x3EBCD0", VA = "0x1803ECAD0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000760 RID: 1888 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000760")]
	[Address(RVA = "0x3EC420", Offset = "0x3EB620", VA = "0x1803EC420", Slot = "4")]
	public void Dispose()
	{
	}

	// Token: 0x06000761 RID: 1889 RVA: 0x00003D68 File Offset: 0x00001F68
	[Token(Token = "0x6000761")]
	[Address(RVA = "0x3EC980", Offset = "0x3EBB80", VA = "0x1803EC980")]
	public bool ShowIndicator(bool isPlayer, World world)
	{
		return default(bool);
	}

	// Token: 0x06000762 RID: 1890 RVA: 0x00003D80 File Offset: 0x00001F80
	[Token(Token = "0x6000762")]
	[Address(RVA = "0x3EC630", Offset = "0x3EB830", VA = "0x1803EC630")]
	public Color GetColor(bool isPlayer)
	{
		return default(Color);
	}

	// Token: 0x06000763 RID: 1891 RVA: 0x00003D98 File Offset: 0x00001F98
	[Token(Token = "0x6000763")]
	[Address(RVA = "0x3EC4D0", Offset = "0x3EB6D0", VA = "0x1803EC4D0")]
	private int GetArmorDamage()
	{
		return 0;
	}

	// Token: 0x0400075B RID: 1883
	[Token(Token = "0x400075B")]
	[FieldOffset(Offset = "0x10")]
	public LiveAttack LiveAttack;
}
