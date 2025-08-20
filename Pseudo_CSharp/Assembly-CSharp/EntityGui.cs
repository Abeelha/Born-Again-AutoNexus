using System;
using Il2CppDummyDll;
using Ronin.Model.Data;
using Ronin.Model.Enums;
using Ronin.Model.Simulation.Components;
using Ronin.Model.Structs;

// Token: 0x020001E7 RID: 487
[Token(Token = "0x20001E7")]
public struct EntityGui
{
	// Token: 0x060009F4 RID: 2548 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009F4")]
	[Address(RVA = "0x425660", Offset = "0x424860", VA = "0x180425660")]
	public void OnDamage()
	{
	}

	// Token: 0x060009F5 RID: 2549 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009F5")]
	[Address(RVA = "0x4256B0", Offset = "0x4248B0", VA = "0x1804256B0")]
	public void Return()
	{
	}

	// Token: 0x060009F6 RID: 2550 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009F6")]
	[Address(RVA = "0x425780", Offset = "0x424980", VA = "0x180425780")]
	public void SetDeathNote(ref DeathNoteData data)
	{
	}

	// Token: 0x060009F7 RID: 2551 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009F7")]
	[Address(RVA = "0x4257A0", Offset = "0x4249A0", VA = "0x1804257A0")]
	public void SetDisabled(bool disabled)
	{
	}

	// Token: 0x060009F8 RID: 2552 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009F8")]
	[Address(RVA = "0x4257E0", Offset = "0x4249E0", VA = "0x1804257E0")]
	public void SetLevel(int level)
	{
	}

	// Token: 0x060009F9 RID: 2553 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009F9")]
	[Address(RVA = "0x426150", Offset = "0x425350", VA = "0x180426150")]
	public void Update(ref EntityState state)
	{
	}

	// Token: 0x060009FA RID: 2554 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009FA")]
	[Address(RVA = "0x4257F0", Offset = "0x4249F0", VA = "0x1804257F0")]
	public void SetName(string name)
	{
	}

	// Token: 0x060009FB RID: 2555 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009FB")]
	[Address(RVA = "0x425820", Offset = "0x424A20", VA = "0x180425820")]
	public void SetStatusEffects(StatusEffects statusEffects)
	{
	}

	// Token: 0x060009FC RID: 2556 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009FC")]
	[Address(RVA = "0x425850", Offset = "0x424A50", VA = "0x180425850")]
	public void Setup(Entity entity)
	{
	}

	// Token: 0x060009FD RID: 2557 RVA: 0x00004920 File Offset: 0x00002B20
	[Token(Token = "0x60009FD")]
	[Address(RVA = "0x425610", Offset = "0x424810", VA = "0x180425610")]
	private float GetHealthBarHeight()
	{
		return 0f;
	}

	// Token: 0x060009FE RID: 2558 RVA: 0x00004938 File Offset: 0x00002B38
	[Token(Token = "0x60009FE")]
	[Address(RVA = "0x425610", Offset = "0x424810", VA = "0x180425610")]
	private float GetNameHeight()
	{
		return 0f;
	}

	// Token: 0x060009FF RID: 2559 RVA: 0x00004950 File Offset: 0x00002B50
	[Token(Token = "0x60009FF")]
	[Address(RVA = "0x425620", Offset = "0x424820", VA = "0x180425620")]
	private float GetStatusEffectHeight()
	{
		return 0f;
	}

	// Token: 0x06000A00 RID: 2560 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A00")]
	[Address(RVA = "0x425870", Offset = "0x424A70", VA = "0x180425870")]
	private void UpdateHealth(ref EntityState state)
	{
	}

	// Token: 0x06000A01 RID: 2561 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A01")]
	[Address(RVA = "0x425D20", Offset = "0x424F20", VA = "0x180425D20")]
	public void UpdateName()
	{
	}

	// Token: 0x06000A02 RID: 2562 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A02")]
	[Address(RVA = "0x425FA0", Offset = "0x4251A0", VA = "0x180425FA0")]
	private void UpdateStatusEfects()
	{
	}

	// Token: 0x0400093E RID: 2366
	[Token(Token = "0x400093E")]
	[FieldOffset(Offset = "0x0")]
	private Entity _entity;

	// Token: 0x0400093F RID: 2367
	[Token(Token = "0x400093F")]
	[FieldOffset(Offset = "0x8")]
	private Name _name;

	// Token: 0x04000940 RID: 2368
	[Token(Token = "0x4000940")]
	[FieldOffset(Offset = "0x10")]
	private HealthBar _healthBar;

	// Token: 0x04000941 RID: 2369
	[Token(Token = "0x4000941")]
	[FieldOffset(Offset = "0x18")]
	private StatusEffectsGui _statusEffectsGui;

	// Token: 0x04000942 RID: 2370
	[Token(Token = "0x4000942")]
	[FieldOffset(Offset = "0x20")]
	private int _levelValue;

	// Token: 0x04000943 RID: 2371
	[Token(Token = "0x4000943")]
	[FieldOffset(Offset = "0x24")]
	private int _prestigeValue;

	// Token: 0x04000944 RID: 2372
	[Token(Token = "0x4000944")]
	[FieldOffset(Offset = "0x28")]
	private String16 _deathNoteMessage;

	// Token: 0x04000945 RID: 2373
	[Token(Token = "0x4000945")]
	[FieldOffset(Offset = "0x48")]
	private string _entityName;

	// Token: 0x04000946 RID: 2374
	[Token(Token = "0x4000946")]
	[FieldOffset(Offset = "0x50")]
	private StatusEffects _statusEffects;

	// Token: 0x04000947 RID: 2375
	[Token(Token = "0x4000947")]
	[FieldOffset(Offset = "0x58")]
	private ushort _birthBlessing;

	// Token: 0x04000948 RID: 2376
	[Token(Token = "0x4000948")]
	[FieldOffset(Offset = "0x5A")]
	private bool _disabled;
}
