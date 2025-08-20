using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Ronin.Api.Model.Character;
using Ronin.Model.Definitions;
using Ronin.Model.Files.Animation;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000185 RID: 389
[Token(Token = "0x2000185")]
public class CharacterImage : MonoBehaviour
{
	// Token: 0x170000B7 RID: 183
	// (get) Token: 0x060007A9 RID: 1961 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x170000B7")]
	public RectTransform RectTransform
	{
		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x409C80", Offset = "0x408E80", VA = "0x180409C80")]
		get
		{
			return null;
		}
	}

	// Token: 0x060007AA RID: 1962 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007AA")]
	[Address(RVA = "0x409BD0", Offset = "0x408DD0", VA = "0x180409BD0")]
	public void UpdateRigLayer()
	{
	}

	// Token: 0x060007AB RID: 1963 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007AB")]
	[Address(RVA = "0x408870", Offset = "0x407A70", VA = "0x180408870")]
	public void SetCharacter(GetCharacterResponse character)
	{
	}

	// Token: 0x060007AC RID: 1964 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007AC")]
	[Address(RVA = "0x408EC0", Offset = "0x4080C0", VA = "0x180408EC0")]
	public void SetCharacter(ushort type, ushort armorType, ushort bootType, ushort hatType, ushort weaponType)
	{
	}

	// Token: 0x060007AD RID: 1965 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007AD")]
	[Address(RVA = "0x4084B0", Offset = "0x4076B0", VA = "0x1804084B0")]
	public void SetCharacter(ObjectDefinition definition, ObjectDefinition armor, ObjectDefinition boots, ObjectDefinition hat, ObjectDefinition weapon)
	{
	}

	// Token: 0x060007AE RID: 1966 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007AE")]
	[Address(RVA = "0x4092B0", Offset = "0x4084B0", VA = "0x1804092B0")]
	public void SetColor(Color color)
	{
	}

	// Token: 0x060007AF RID: 1967 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007AF")]
	[Address(RVA = "0x409800", Offset = "0x408A00", VA = "0x180409800")]
	public void SetNpc(ushort type)
	{
	}

	// Token: 0x060007B0 RID: 1968 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007B0")]
	[Address(RVA = "0x409940", Offset = "0x408B40", VA = "0x180409940")]
	public void SetWeapon(ushort type)
	{
	}

	// Token: 0x060007B1 RID: 1969 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007B1")]
	[Address(RVA = "0x4099D0", Offset = "0x408BD0", VA = "0x1804099D0")]
	public void SetWeapon(ObjectDefinition definition)
	{
	}

	// Token: 0x060007B2 RID: 1970 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007B2")]
	[Address(RVA = "0x407B50", Offset = "0x406D50", VA = "0x180407B50")]
	private void PositionComponent(Image component, AnimationFrame componentFrame, AnimationComponentData data)
	{
	}

	// Token: 0x060007B3 RID: 1971 RVA: 0x00003F18 File Offset: 0x00002118
	[Token(Token = "0x60007B3")]
	[Address(RVA = "0x407B90", Offset = "0x406D90", VA = "0x180407B90")]
	private int PositionComponents(Image[] components, AnimationFrame componentFrame, IEnumerable<AnimationComponentData> datas)
	{
		return 0;
	}

	// Token: 0x060007B4 RID: 1972 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007B4")]
	[Address(RVA = "0x407DD0", Offset = "0x406FD0", VA = "0x180407DD0")]
	private void SetArmor(ObjectDefinition definition)
	{
	}

	// Token: 0x060007B5 RID: 1973 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007B5")]
	[Address(RVA = "0x408420", Offset = "0x407620", VA = "0x180408420")]
	private void SetBoots(ushort type)
	{
	}

	// Token: 0x060007B6 RID: 1974 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007B6")]
	[Address(RVA = "0x408280", Offset = "0x407480", VA = "0x180408280")]
	private void SetBoots(ObjectDefinition definition)
	{
	}

	// Token: 0x060007B7 RID: 1975 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007B7")]
	[Address(RVA = "0x407F90", Offset = "0x407190", VA = "0x180407F90")]
	private void SetBodySprite(Image image, AnimationFrame bodyFrame)
	{
	}

	// Token: 0x060007B8 RID: 1976 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007B8")]
	[Address(RVA = "0x408200", Offset = "0x407400", VA = "0x180408200")]
	private void SetBootsActive(bool active)
	{
	}

	// Token: 0x060007B9 RID: 1977 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007B9")]
	[Address(RVA = "0x4093F0", Offset = "0x4085F0", VA = "0x1804093F0")]
	private void SetFrame(AnimationFrame frame)
	{
	}

	// Token: 0x060007BA RID: 1978 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007BA")]
	[Address(RVA = "0x409640", Offset = "0x408840", VA = "0x180409640")]
	private void SetHat(ObjectDefinition definition)
	{
	}

	// Token: 0x060007BB RID: 1979 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007BB")]
	[Address(RVA = "0x4098C0", Offset = "0x408AC0", VA = "0x1804098C0")]
	private void SetWeaponActive(bool active)
	{
	}

	// Token: 0x060007BC RID: 1980 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007BC")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public CharacterImage()
	{
	}

	// Token: 0x040007AB RID: 1963
	[Token(Token = "0x40007AB")]
	[FieldOffset(Offset = "0x20")]
	private ObjectDefinition _characterDefinition;

	// Token: 0x040007AC RID: 1964
	[Token(Token = "0x40007AC")]
	[FieldOffset(Offset = "0x28")]
	private ObjectDefinition _weaponDefinition;

	// Token: 0x040007AD RID: 1965
	[Token(Token = "0x40007AD")]
	[FieldOffset(Offset = "0x30")]
	private AnimationSwitch _rig;

	// Token: 0x040007AE RID: 1966
	[Token(Token = "0x40007AE")]
	[FieldOffset(Offset = "0x38")]
	private AnimationFrame _frame;

	// Token: 0x040007AF RID: 1967
	[Token(Token = "0x40007AF")]
	[FieldOffset(Offset = "0x40")]
	public Image Body;

	// Token: 0x040007B0 RID: 1968
	[Token(Token = "0x40007B0")]
	[FieldOffset(Offset = "0x48")]
	public Image Armor;

	// Token: 0x040007B1 RID: 1969
	[Token(Token = "0x40007B1")]
	[FieldOffset(Offset = "0x50")]
	public Image[] Weapons;

	// Token: 0x040007B2 RID: 1970
	[Token(Token = "0x40007B2")]
	[FieldOffset(Offset = "0x58")]
	public Image[] Boots;

	// Token: 0x040007B3 RID: 1971
	[Token(Token = "0x40007B3")]
	[FieldOffset(Offset = "0x60")]
	public Image Rig;

	// Token: 0x040007B4 RID: 1972
	[Token(Token = "0x40007B4")]
	[FieldOffset(Offset = "0x68")]
	public Image Hat;

	// Token: 0x040007B5 RID: 1973
	[Token(Token = "0x40007B5")]
	[FieldOffset(Offset = "0x70")]
	public float Alpha;
}
