using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Ronin.Model.GameActions;

// Token: 0x0200024B RID: 587
[Token(Token = "0x200024B")]
public struct GizmoDefinition
{
	// Token: 0x06000B03 RID: 2819 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B03")]
	[Address(RVA = "0x4384F0", Offset = "0x4376F0", VA = "0x1804384F0")]
	public GizmoDefinition(GizmoType type, uint duration, float size, uint time)
	{
	}

	// Token: 0x06000B04 RID: 2820 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B04")]
	[Address(RVA = "0x4384A0", Offset = "0x4376A0", VA = "0x1804384A0")]
	public GizmoDefinition(GizmoType type, uint duration, float size, float range, int count, float gap, uint time, float angleOffset)
	{
	}

	// Token: 0x06000B05 RID: 2821 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B05")]
	[Address(RVA = "0x438420", Offset = "0x437620", VA = "0x180438420")]
	public GizmoDefinition(GizmoType type, uint duration, float size, RangedGameAction rangedGameAction, int count, float gap, float spread = 0f, float angleOffset = 0f, uint time = 0U, uint moveDuration = 0U, bool collides = true)
	{
	}

	// Token: 0x17000109 RID: 265
	// (get) Token: 0x06000B06 RID: 2822 RVA: 0x00004C08 File Offset: 0x00002E08
	[Token(Token = "0x17000109")]
	public static GizmoDefinition None
	{
		[Token(Token = "0x6000B06")]
		[Address(RVA = "0x438540", Offset = "0x437740", VA = "0x180438540")]
		get
		{
			return default(GizmoDefinition);
		}
	}

	// Token: 0x1700010A RID: 266
	// (get) Token: 0x06000B07 RID: 2823 RVA: 0x00004C20 File Offset: 0x00002E20
	[Token(Token = "0x1700010A")]
	public GizmoType Type
	{
		[Token(Token = "0x6000B07")]
		[Address(RVA = "0x4054F0", Offset = "0x4046F0", VA = "0x1804054F0")]
		[CompilerGenerated]
		get
		{
			return GizmoType.None;
		}
	}

	// Token: 0x1700010B RID: 267
	// (get) Token: 0x06000B08 RID: 2824 RVA: 0x00004C38 File Offset: 0x00002E38
	[Token(Token = "0x1700010B")]
	public uint Duration
	{
		[Token(Token = "0x6000B08")]
		[Address(RVA = "0x3ECB90", Offset = "0x3EBD90", VA = "0x1803ECB90")]
		[CompilerGenerated]
		get
		{
			return 0U;
		}
	}

	// Token: 0x1700010C RID: 268
	// (get) Token: 0x06000B09 RID: 2825 RVA: 0x00004C50 File Offset: 0x00002E50
	[Token(Token = "0x1700010C")]
	public float Size
	{
		[Token(Token = "0x6000B09")]
		[Address(RVA = "0x438570", Offset = "0x437770", VA = "0x180438570")]
		[CompilerGenerated]
		get
		{
			return 0f;
		}
	}

	// Token: 0x1700010D RID: 269
	// (get) Token: 0x06000B0A RID: 2826 RVA: 0x00004C68 File Offset: 0x00002E68
	[Token(Token = "0x1700010D")]
	public float Spread
	{
		[Token(Token = "0x6000B0A")]
		[Address(RVA = "0x438580", Offset = "0x437780", VA = "0x180438580")]
		[CompilerGenerated]
		get
		{
			return 0f;
		}
	}

	// Token: 0x1700010E RID: 270
	// (get) Token: 0x06000B0B RID: 2827 RVA: 0x00004C80 File Offset: 0x00002E80
	[Token(Token = "0x1700010E")]
	public float MinRange
	{
		[Token(Token = "0x6000B0B")]
		[Address(RVA = "0x31B6B0", Offset = "0x31A8B0", VA = "0x18031B6B0")]
		[CompilerGenerated]
		get
		{
			return 0f;
		}
	}

	// Token: 0x1700010F RID: 271
	// (get) Token: 0x06000B0C RID: 2828 RVA: 0x00004C98 File Offset: 0x00002E98
	[Token(Token = "0x1700010F")]
	public float MaxRange
	{
		[Token(Token = "0x6000B0C")]
		[Address(RVA = "0x31B690", Offset = "0x31A890", VA = "0x18031B690")]
		[CompilerGenerated]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000110 RID: 272
	// (get) Token: 0x06000B0D RID: 2829 RVA: 0x00004CB0 File Offset: 0x00002EB0
	[Token(Token = "0x17000110")]
	public int Count
	{
		[Token(Token = "0x6000B0D")]
		[Address(RVA = "0x438530", Offset = "0x437730", VA = "0x180438530")]
		[CompilerGenerated]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000111 RID: 273
	// (get) Token: 0x06000B0E RID: 2830 RVA: 0x00004CC8 File Offset: 0x00002EC8
	[Token(Token = "0x17000111")]
	public float Gap
	{
		[Token(Token = "0x6000B0E")]
		[Address(RVA = "0x31B670", Offset = "0x31A870", VA = "0x18031B670")]
		[CompilerGenerated]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000112 RID: 274
	// (get) Token: 0x06000B0F RID: 2831 RVA: 0x00004CE0 File Offset: 0x00002EE0
	// (set) Token: 0x06000B10 RID: 2832 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000112")]
	public float AngleOffset
	{
		[Token(Token = "0x6000B0F")]
		[Address(RVA = "0x31B6A0", Offset = "0x31A8A0", VA = "0x18031B6A0")]
		[CompilerGenerated]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000B10")]
		[Address(RVA = "0x438590", Offset = "0x437790", VA = "0x180438590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x17000113 RID: 275
	// (get) Token: 0x06000B11 RID: 2833 RVA: 0x00004CF8 File Offset: 0x00002EF8
	[Token(Token = "0x17000113")]
	public bool Collides
	{
		[Token(Token = "0x6000B11")]
		[Address(RVA = "0x438520", Offset = "0x437720", VA = "0x180438520")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000B12 RID: 2834 RVA: 0x00004D10 File Offset: 0x00002F10
	[Token(Token = "0x6000B12")]
	[Address(RVA = "0x4383E0", Offset = "0x4375E0", VA = "0x1804383E0")]
	public GizmoDefinition WithAddedAngle(float angle)
	{
		return default(GizmoDefinition);
	}
}
