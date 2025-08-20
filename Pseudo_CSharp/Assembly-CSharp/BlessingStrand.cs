using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AnimateInternal;
using Il2CppDummyDll;
using Ronin.Api.Model.Character;
using Ronin.Model.Data;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x02000297 RID: 663
[Token(Token = "0x2000297")]
public class BlessingStrand : MonoBehaviour
{
	// Token: 0x06000E2F RID: 3631 RVA: 0x00005DF0 File Offset: 0x00003FF0
	[Token(Token = "0x6000E2F")]
	[Address(RVA = "0x44C8D0", Offset = "0x44BAD0", VA = "0x18044C8D0")]
	public bool BeginDrag(BlessingIcon blessingIcon)
	{
		return default(bool);
	}

	// Token: 0x06000E30 RID: 3632 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E30")]
	[Address(RVA = "0x44D230", Offset = "0x44C430", VA = "0x18044D230")]
	public void Drag(BlessingIcon blessingIcon, PointerEventData eventData)
	{
	}

	// Token: 0x06000E31 RID: 3633 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E31")]
	[Address(RVA = "0x44D430", Offset = "0x44C630", VA = "0x18044D430")]
	public void EndDrag(BlessingIcon blessingIcon, bool cancel)
	{
	}

	// Token: 0x06000E32 RID: 3634 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E32")]
	[Address(RVA = "0x44DEA0", Offset = "0x44D0A0", VA = "0x18044DEA0")]
	public void Reload()
	{
	}

	// Token: 0x06000E33 RID: 3635 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E33")]
	[Address(RVA = "0x44E1C0", Offset = "0x44D3C0", VA = "0x18044E1C0")]
	public void SetBaseVisibility(bool visibility)
	{
	}

	// Token: 0x06000E34 RID: 3636 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E34")]
	[Address(RVA = "0x44E720", Offset = "0x44D920", VA = "0x18044E720")]
	public void SetBlessings(GetCharacterResponse character)
	{
	}

	// Token: 0x06000E35 RID: 3637 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E35")]
	[Address(RVA = "0x44E260", Offset = "0x44D460", VA = "0x18044E260")]
	public void SetBlessings(BlessingsData data, bool popOnChange = false)
	{
	}

	// Token: 0x06000E36 RID: 3638 RVA: 0x00005E08 File Offset: 0x00004008
	[Token(Token = "0x6000E36")]
	[Address(RVA = "0x44D030", Offset = "0x44C230", VA = "0x18044D030")]
	private static bool DidChange(BlessingsData previous, BlessingsData next)
	{
		return default(bool);
	}

	// Token: 0x06000E37 RID: 3639 RVA: 0x00005E20 File Offset: 0x00004020
	[Token(Token = "0x6000E37")]
	[Address(RVA = "0x44DBB0", Offset = "0x44CDB0", VA = "0x18044DBB0")]
	private static SpriteLibrary.BlessingTheme GetTheme(ushort blessingType)
	{
		return default(SpriteLibrary.BlessingTheme);
	}

	// Token: 0x06000E38 RID: 3640 RVA: 0x00005E38 File Offset: 0x00004038
	[Token(Token = "0x6000E38")]
	[Address(RVA = "0x44BF30", Offset = "0x44B130", VA = "0x18044BF30")]
	private bool AddBlessing(ushort blessingType, int count, int index)
	{
		return default(bool);
	}

	// Token: 0x06000E39 RID: 3641 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000E39")]
	[Address(RVA = "0x44C560", Offset = "0x44B760", VA = "0x18044C560")]
	private Image AddStrand(int index)
	{
		return null;
	}

	// Token: 0x06000E3A RID: 3642 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E3A")]
	[Address(RVA = "0x44C9A0", Offset = "0x44BBA0", VA = "0x18044C9A0")]
	private void CalculateSize()
	{
	}

	// Token: 0x06000E3B RID: 3643 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E3B")]
	[Address(RVA = "0x44CDD0", Offset = "0x44BFD0", VA = "0x18044CDD0")]
	private void ClearStrand()
	{
	}

	// Token: 0x06000E3C RID: 3644 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E3C")]
	[Address(RVA = "0x44D610", Offset = "0x44C810", VA = "0x18044D610")]
	private void EndStrand(int lastIndex)
	{
	}

	// Token: 0x06000E3D RID: 3645 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000E3D")]
	[Address(RVA = "0x44D970", Offset = "0x44CB70", VA = "0x18044D970")]
	private BlessingIcon GetBlessing()
	{
		return null;
	}

	// Token: 0x06000E3E RID: 3646 RVA: 0x00005E50 File Offset: 0x00004050
	[Token(Token = "0x6000E3E")]
	[Address(RVA = "0x44DA30", Offset = "0x44CC30", VA = "0x18044DA30")]
	private int GetTargetIndex(PointerEventData eventData)
	{
		return 0;
	}

	// Token: 0x06000E3F RID: 3647 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000E3F")]
	[Address(RVA = "0x44D9D0", Offset = "0x44CBD0", VA = "0x18044D9D0")]
	private Image GetStrand()
	{
		return null;
	}

	// Token: 0x06000E40 RID: 3648 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000E40")]
	private T GetStored<T>(List<T> store, ref int inUse, GameObject prefab) where T : MonoBehaviour
	{
		return null;
	}

	// Token: 0x06000E41 RID: 3649 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E41")]
	[Address(RVA = "0x44DF30", Offset = "0x44D130", VA = "0x18044DF30")]
	private void Reorder()
	{
	}

	// Token: 0x06000E42 RID: 3650 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E42")]
	[Address(RVA = "0x44E850", Offset = "0x44DA50", VA = "0x18044E850")]
	private void StartStrand(ushort blessingType, ushort keystoneType)
	{
	}

	// Token: 0x06000E43 RID: 3651 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E43")]
	[Address(RVA = "0x44EEC0", Offset = "0x44E0C0", VA = "0x18044EEC0")]
	public BlessingStrand()
	{
	}

	// Token: 0x06000E45 RID: 3653 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E45")]
	[Address(RVA = "0x44ECC0", Offset = "0x44DEC0", VA = "0x18044ECC0")]
	[CompilerGenerated]
	internal static void <CalculateSize>g__updateMax|28_0(RectTransform rectTransform, ref Vector2 max)
	{
	}

	// Token: 0x04000B76 RID: 2934
	[Token(Token = "0x4000B76")]
	[FieldOffset(Offset = "0x0")]
	private static readonly List<ushort> s_emptyTypesList;

	// Token: 0x04000B77 RID: 2935
	[Token(Token = "0x4000B77")]
	[FieldOffset(Offset = "0x8")]
	private static readonly List<byte> s_emptyCountsList;

	// Token: 0x04000B78 RID: 2936
	[Token(Token = "0x4000B78")]
	[FieldOffset(Offset = "0x20")]
	public RectTransform Content;

	// Token: 0x04000B79 RID: 2937
	[Token(Token = "0x4000B79")]
	[FieldOffset(Offset = "0x28")]
	public BlessingIcon Start;

	// Token: 0x04000B7A RID: 2938
	[Token(Token = "0x4000B7A")]
	[FieldOffset(Offset = "0x30")]
	public Image End;

	// Token: 0x04000B7B RID: 2939
	[Token(Token = "0x4000B7B")]
	[FieldOffset(Offset = "0x38")]
	public GameObject StrandPrefab;

	// Token: 0x04000B7C RID: 2940
	[Token(Token = "0x4000B7C")]
	[FieldOffset(Offset = "0x40")]
	public GameObject BlessingPrefab;

	// Token: 0x04000B7D RID: 2941
	[Token(Token = "0x4000B7D")]
	[FieldOffset(Offset = "0x48")]
	private SpriteLibrary.BlessingTheme _theme;

	// Token: 0x04000B7E RID: 2942
	[Token(Token = "0x4000B7E")]
	[FieldOffset(Offset = "0x80")]
	private int _strandsInUse;

	// Token: 0x04000B7F RID: 2943
	[Token(Token = "0x4000B7F")]
	[FieldOffset(Offset = "0x84")]
	private int _blessingsInUse;

	// Token: 0x04000B80 RID: 2944
	[Token(Token = "0x4000B80")]
	[FieldOffset(Offset = "0x88")]
	private readonly List<Image> _strands;

	// Token: 0x04000B81 RID: 2945
	[Token(Token = "0x4000B81")]
	[FieldOffset(Offset = "0x90")]
	private readonly List<BlessingIcon> _blessings;

	// Token: 0x04000B82 RID: 2946
	[Token(Token = "0x4000B82")]
	[FieldOffset(Offset = "0x98")]
	private readonly List<Vector2> _positions;

	// Token: 0x04000B83 RID: 2947
	[Token(Token = "0x4000B83")]
	[FieldOffset(Offset = "0xA0")]
	private BlessingsData? _currentData;

	// Token: 0x04000B84 RID: 2948
	[Token(Token = "0x4000B84")]
	[FieldOffset(Offset = "0xB8")]
	private AnimateTask _popAnimation;

	// Token: 0x04000B85 RID: 2949
	[Token(Token = "0x4000B85")]
	[FieldOffset(Offset = "0xC0")]
	private BlessingIcon _draggingIcon;

	// Token: 0x04000B86 RID: 2950
	[Token(Token = "0x4000B86")]
	[FieldOffset(Offset = "0xC8")]
	private int _dragTargetIndex;
}
