using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Ronin.Model.Data;
using Ronin.Model.Definitions;
using UnityEngine;
using UnityEngine.InputSystem.Controls;
using Zero.Game.Shared;

// Token: 0x02000268 RID: 616
[Token(Token = "0x2000268")]
public class UseManager : Manager
{
	// Token: 0x1700011C RID: 284
	// (get) Token: 0x06000BCB RID: 3019 RVA: 0x00004F20 File Offset: 0x00003120
	[Token(Token = "0x1700011C")]
	public int StartedCount
	{
		[Token(Token = "0x6000BCB")]
		[Address(RVA = "0x4498E0", Offset = "0x448AE0", VA = "0x1804498E0")]
		get
		{
			return 0;
		}
	}

	// Token: 0x06000BCC RID: 3020 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BCC")]
	[Address(RVA = "0x447F90", Offset = "0x447190", VA = "0x180447F90")]
	public void CancelUse()
	{
	}

	// Token: 0x06000BCD RID: 3021 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BCD")]
	[Address(RVA = "0x448D40", Offset = "0x447F40", VA = "0x180448D40", Slot = "4")]
	public override void NetworkInputUpdate()
	{
	}

	// Token: 0x06000BCE RID: 3022 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BCE")]
	[Address(RVA = "0x4492F0", Offset = "0x4484F0", VA = "0x1804492F0")]
	private void PlayAbilityGesture(byte index, Vector2 target)
	{
	}

	// Token: 0x06000BCF RID: 3023 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BCF")]
	[Address(RVA = "0x449170", Offset = "0x448370", VA = "0x180449170", Slot = "6")]
	public override void NewWorld(ref MapInfoData mapInfoData)
	{
	}

	// Token: 0x06000BD0 RID: 3024 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BD0")]
	[Address(RVA = "0x4493C0", Offset = "0x4485C0", VA = "0x1804493C0")]
	public void StartUse(byte index, GameObject sender, InputType inputType, [Optional] int? pointerId)
	{
	}

	// Token: 0x06000BD1 RID: 3025 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BD1")]
	[Address(RVA = "0x449760", Offset = "0x448960", VA = "0x180449760")]
	public void Use(byte index, Vec2 target)
	{
	}

	// Token: 0x06000BD2 RID: 3026 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BD2")]
	[Address(RVA = "0x447C10", Offset = "0x446E10", VA = "0x180447C10")]
	private void Awake()
	{
	}

	// Token: 0x06000BD3 RID: 3027 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BD3")]
	[Address(RVA = "0x448060", Offset = "0x447260", VA = "0x180448060")]
	private void CheckForEquipUseKeys()
	{
	}

	// Token: 0x06000BD4 RID: 3028 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BD4")]
	[Address(RVA = "0x448590", Offset = "0x447790", VA = "0x180448590")]
	private void CheckForJoystickUse()
	{
	}

	// Token: 0x06000BD5 RID: 3029 RVA: 0x00004F38 File Offset: 0x00003138
	[Token(Token = "0x6000BD5")]
	[Address(RVA = "0x447E00", Offset = "0x447000", VA = "0x180447E00")]
	private bool CanUse(int index)
	{
		return default(bool);
	}

	// Token: 0x06000BD6 RID: 3030 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000BD6")]
	[Address(RVA = "0x4486B0", Offset = "0x4478B0", VA = "0x1804486B0")]
	private Aimer GetBestAimer(InputType inputType)
	{
		return null;
	}

	// Token: 0x06000BD7 RID: 3031 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BD7")]
	[Address(RVA = "0x4487E0", Offset = "0x4479E0", VA = "0x1804487E0")]
	private void HideGizmos()
	{
	}

	// Token: 0x06000BD8 RID: 3032 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BD8")]
	[Address(RVA = "0x448840", Offset = "0x447A40", VA = "0x180448840")]
	private void HideGizmos(int slotIndex)
	{
	}

	// Token: 0x06000BD9 RID: 3033 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BD9")]
	[Address(RVA = "0x4488B0", Offset = "0x447AB0", VA = "0x1804488B0")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000BDA RID: 3034 RVA: 0x00004F50 File Offset: 0x00003150
	[Token(Token = "0x6000BDA")]
	[Address(RVA = "0x448C30", Offset = "0x447E30", VA = "0x180448C30")]
	private bool NeedsAimer(int index)
	{
		return default(bool);
	}

	// Token: 0x06000BDB RID: 3035 RVA: 0x00004F68 File Offset: 0x00003168
	[Token(Token = "0x6000BDB")]
	[Address(RVA = "0x4489E0", Offset = "0x447BE0", VA = "0x1804489E0")]
	private bool NeedsAimer(ItemDefinition definition)
	{
		return default(bool);
	}

	// Token: 0x06000BDC RID: 3036 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BDC")]
	[Address(RVA = "0x449290", Offset = "0x448490", VA = "0x180449290")]
	private void OnApplicationFocus(bool focus)
	{
	}

	// Token: 0x06000BDD RID: 3037 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BDD")]
	[Address(RVA = "0x4497D0", Offset = "0x4489D0", VA = "0x1804497D0")]
	public UseManager()
	{
	}

	// Token: 0x06000BDE RID: 3038 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BDE")]
	[Address(RVA = "0x4495F0", Offset = "0x4487F0", VA = "0x1804495F0")]
	[CompilerGenerated]
	private void <CheckForJoystickUse>g__abilityUse|23_0(Aimer aimer, byte i, ButtonControl button, ref bool state)
	{
	}

	// Token: 0x04000A82 RID: 2690
	[Token(Token = "0x4000A82")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public World World;

	// Token: 0x04000A83 RID: 2691
	[Token(Token = "0x4000A83")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Aimer[] Aimers;

	// Token: 0x04000A84 RID: 2692
	[Token(Token = "0x4000A84")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject KeybindSetter;

	// Token: 0x04000A85 RID: 2693
	[Token(Token = "0x4000A85")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Option _cancelUse;

	// Token: 0x04000A86 RID: 2694
	[Token(Token = "0x4000A86")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly Option[] _quickUseOptions;

	// Token: 0x04000A87 RID: 2695
	[Token(Token = "0x4000A87")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly Option[] _consumeOptions;

	// Token: 0x04000A88 RID: 2696
	[Token(Token = "0x4000A88")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private readonly Dictionary<byte, Vec2> _used;

	// Token: 0x04000A89 RID: 2697
	[Token(Token = "0x4000A89")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private readonly HashSet<byte> _started;

	// Token: 0x04000A8A RID: 2698
	[Token(Token = "0x4000A8A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private bool _ability0State;

	// Token: 0x04000A8B RID: 2699
	[Token(Token = "0x4000A8B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
	private bool _ability1State;

	// Token: 0x04000A8C RID: 2700
	[Token(Token = "0x4000A8C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
	private bool _ability2State;

	// Token: 0x04000A8D RID: 2701
	[Token(Token = "0x4000A8D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6B")]
	private bool _consumableState;

	// Token: 0x04000A8E RID: 2702
	[Token(Token = "0x4000A8E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private bool _useState;
}
