using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AnimateInternal;
using Il2CppDummyDll;
using Ronin.Api.Model.Character;
using Ronin.Model.Definitions;
using Ronin.Model.Enums;
using Ronin.Model.Structs;
using TMPro;
using UnityEngine;

// Token: 0x020000F2 RID: 242
[Token(Token = "0x20000F2")]
public class StatsDisplay : MonoBehaviour
{
	// Token: 0x06000427 RID: 1063 RVA: 0x00003348 File Offset: 0x00001548
	[Token(Token = "0x6000427")]
	[Address(RVA = "0x3C8F30", Offset = "0x3C8130", VA = "0x1803C8F30")]
	public int GetStat(StatType statType)
	{
		return 0;
	}

	// Token: 0x06000428 RID: 1064 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000428")]
	[Address(RVA = "0x3C9A70", Offset = "0x3C8C70", VA = "0x1803C9A70")]
	public void SetEquips(ItemValue[] equips)
	{
	}

	// Token: 0x06000429 RID: 1065 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000429")]
	[Address(RVA = "0x3C9B20", Offset = "0x3C8D20", VA = "0x1803C9B20")]
	public void SetLevel(int level, ushort birthBlessing)
	{
	}

	// Token: 0x0600042A RID: 1066 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600042A")]
	[Address(RVA = "0x3C9440", Offset = "0x3C8640", VA = "0x1803C9440")]
	public void SetCharacter(GetCharacterResponse character)
	{
	}

	// Token: 0x0600042B RID: 1067 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600042B")]
	[Address(RVA = "0x3C97E0", Offset = "0x3C89E0", VA = "0x1803C97E0")]
	public void SetClass(ObjectDefinition definition, int level, int ordinal = 1, ushort threadType = 40960)
	{
	}

	// Token: 0x0600042C RID: 1068 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600042C")]
	[Address(RVA = "0x3CA250", Offset = "0x3C9450", VA = "0x1803CA250")]
	public void SetTarget(Transform target)
	{
	}

	// Token: 0x0600042D RID: 1069 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600042D")]
	[Address(RVA = "0x3C8E40", Offset = "0x3C8040", VA = "0x1803C8E40")]
	private AnimateTask AnimateLabel(TextMeshProUGUI label, int from, int to)
	{
		return null;
	}

	// Token: 0x0600042E RID: 1070 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600042E")]
	[Address(RVA = "0x3C90F0", Offset = "0x3C82F0", VA = "0x1803C90F0")]
	private void LateUpdate()
	{
	}

	// Token: 0x0600042F RID: 1071 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600042F")]
	[Address(RVA = "0x3C93F0", Offset = "0x3C85F0", VA = "0x1803C93F0")]
	private void OnEnable()
	{
	}

	// Token: 0x06000430 RID: 1072 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000430")]
	[Address(RVA = "0x3C9C80", Offset = "0x3C8E80", VA = "0x1803C9C80")]
	private void SetStatValues(ObjectDefinition definition, int level, IEnumerable<ushort> itemTypes)
	{
	}

	// Token: 0x06000431 RID: 1073 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000431")]
	[Address(RVA = "0x3C9FF0", Offset = "0x3C91F0", VA = "0x1803C9FF0")]
	private void SetStatValues(Stats stats, Stats increases)
	{
	}

	// Token: 0x06000432 RID: 1074 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000432")]
	[Address(RVA = "0x3CA330", Offset = "0x3C9530", VA = "0x1803CA330")]
	private void SetTitle(ushort characterType, int level, bool showLevel)
	{
	}

	// Token: 0x06000433 RID: 1075 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000433")]
	[Address(RVA = "0x3CA760", Offset = "0x3C9960", VA = "0x1803CA760")]
	public StatsDisplay()
	{
	}

	// Token: 0x06000434 RID: 1076 RVA: 0x00003360 File Offset: 0x00001560
	[Token(Token = "0x6000434")]
	[Address(RVA = "0x3CA4E0", Offset = "0x3C96E0", VA = "0x1803CA4E0")]
	[CompilerGenerated]
	internal static ItemValue <SetCharacter>g__getSlot|31_0(int index, ref StatsDisplay.<>c__DisplayClass31_0 A_1)
	{
		return default(ItemValue);
	}

	// Token: 0x06000435 RID: 1077 RVA: 0x00003378 File Offset: 0x00001578
	[Token(Token = "0x6000435")]
	[Address(RVA = "0x3CA670", Offset = "0x3C9870", VA = "0x1803CA670")]
	[CompilerGenerated]
	internal static ItemValue <SetClass>g__getSlot|32_0(int index, ref StatsDisplay.<>c__DisplayClass32_0 A_1)
	{
		return default(ItemValue);
	}

	// Token: 0x04000435 RID: 1077
	[Token(Token = "0x4000435")]
	[FieldOffset(Offset = "0x20")]
	public RectTransform Content;

	// Token: 0x04000436 RID: 1078
	[Token(Token = "0x4000436")]
	[FieldOffset(Offset = "0x28")]
	public Slot[] Slots;

	// Token: 0x04000437 RID: 1079
	[Token(Token = "0x4000437")]
	[FieldOffset(Offset = "0x30")]
	public TextMeshProUGUI TitleLabel;

	// Token: 0x04000438 RID: 1080
	[Token(Token = "0x4000438")]
	[FieldOffset(Offset = "0x38")]
	public TextMeshProUGUI LevelLabel;

	// Token: 0x04000439 RID: 1081
	[Token(Token = "0x4000439")]
	[FieldOffset(Offset = "0x40")]
	public TextMeshProUGUI DefenseLabel;

	// Token: 0x0400043A RID: 1082
	[Token(Token = "0x400043A")]
	[FieldOffset(Offset = "0x48")]
	public TextMeshProUGUI DexterityLabel;

	// Token: 0x0400043B RID: 1083
	[Token(Token = "0x400043B")]
	[FieldOffset(Offset = "0x50")]
	public TextMeshProUGUI MaxHealthLabel;

	// Token: 0x0400043C RID: 1084
	[Token(Token = "0x400043C")]
	[FieldOffset(Offset = "0x58")]
	public TextMeshProUGUI SpeedLabel;

	// Token: 0x0400043D RID: 1085
	[Token(Token = "0x400043D")]
	[FieldOffset(Offset = "0x60")]
	public TextMeshProUGUI StrengthLabel;

	// Token: 0x0400043E RID: 1086
	[Token(Token = "0x400043E")]
	[FieldOffset(Offset = "0x68")]
	public TextMeshProUGUI VigorLabel;

	// Token: 0x0400043F RID: 1087
	[Token(Token = "0x400043F")]
	[FieldOffset(Offset = "0x70")]
	public WorldUIStat Defense;

	// Token: 0x04000440 RID: 1088
	[Token(Token = "0x4000440")]
	[FieldOffset(Offset = "0x78")]
	public WorldUIStat Dexterity;

	// Token: 0x04000441 RID: 1089
	[Token(Token = "0x4000441")]
	[FieldOffset(Offset = "0x80")]
	public WorldUIStat MaxHealth;

	// Token: 0x04000442 RID: 1090
	[Token(Token = "0x4000442")]
	[FieldOffset(Offset = "0x88")]
	public WorldUIStat Speed;

	// Token: 0x04000443 RID: 1091
	[Token(Token = "0x4000443")]
	[FieldOffset(Offset = "0x90")]
	public WorldUIStat Strength;

	// Token: 0x04000444 RID: 1092
	[Token(Token = "0x4000444")]
	[FieldOffset(Offset = "0x98")]
	public WorldUIStat Vigor;

	// Token: 0x04000445 RID: 1093
	[Token(Token = "0x4000445")]
	[FieldOffset(Offset = "0xA0")]
	public bool Float;

	// Token: 0x04000446 RID: 1094
	[Token(Token = "0x4000446")]
	[FieldOffset(Offset = "0xA8")]
	private Transform _target;

	// Token: 0x04000447 RID: 1095
	[Token(Token = "0x4000447")]
	[FieldOffset(Offset = "0xB0")]
	private Vector2 _offset;

	// Token: 0x04000448 RID: 1096
	[Token(Token = "0x4000448")]
	[FieldOffset(Offset = "0xB8")]
	private int _defense;

	// Token: 0x04000449 RID: 1097
	[Token(Token = "0x4000449")]
	[FieldOffset(Offset = "0xBC")]
	private int _dexterity;

	// Token: 0x0400044A RID: 1098
	[Token(Token = "0x400044A")]
	[FieldOffset(Offset = "0xC0")]
	private int _maxHealth;

	// Token: 0x0400044B RID: 1099
	[Token(Token = "0x400044B")]
	[FieldOffset(Offset = "0xC4")]
	private int _speed;

	// Token: 0x0400044C RID: 1100
	[Token(Token = "0x400044C")]
	[FieldOffset(Offset = "0xC8")]
	private int _strength;

	// Token: 0x0400044D RID: 1101
	[Token(Token = "0x400044D")]
	[FieldOffset(Offset = "0xCC")]
	private int _vigor;

	// Token: 0x0400044E RID: 1102
	[Token(Token = "0x400044E")]
	[FieldOffset(Offset = "0xD0")]
	private Vector2 _position;

	// Token: 0x0400044F RID: 1103
	[Token(Token = "0x400044F")]
	[FieldOffset(Offset = "0xD8")]
	private Vector2 _targetPosition;
}
