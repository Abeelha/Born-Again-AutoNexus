using System;
using System.Threading.Tasks;
using Il2CppDummyDll;
using Ronin.Model.Data;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x020002D8 RID: 728
[Token(Token = "0x20002D8")]
public class PartyMember : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
{
	// Token: 0x06000FCD RID: 4045 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FCD")]
	[Address(RVA = "0x3537A0", Offset = "0x3529A0", VA = "0x1803537A0", Slot = "4")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	// Token: 0x06000FCE RID: 4046 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FCE")]
	[Address(RVA = "0x3538D0", Offset = "0x352AD0", VA = "0x1803538D0")]
	public void Setup(ref PartyData data, int index, bool canKick)
	{
	}

	// Token: 0x06000FCF RID: 4047 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000FCF")]
	[Address(RVA = "0x3536C0", Offset = "0x3528C0", VA = "0x1803536C0")]
	private Task DoOptionsAsync()
	{
		return null;
	}

	// Token: 0x06000FD0 RID: 4048 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FD0")]
	[Address(RVA = "0x353790", Offset = "0x352990", VA = "0x180353790")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000FD1 RID: 4049 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FD1")]
	[Address(RVA = "0x353CD0", Offset = "0x352ED0", VA = "0x180353CD0")]
	private void UpdateCharacter()
	{
	}

	// Token: 0x06000FD2 RID: 4050 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FD2")]
	[Address(RVA = "0x353960", Offset = "0x352B60", VA = "0x180353960")]
	private void SyncToCharacter()
	{
	}

	// Token: 0x06000FD3 RID: 4051 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FD3")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public PartyMember()
	{
	}

	// Token: 0x04000D1B RID: 3355
	[Token(Token = "0x4000D1B")]
	[FieldOffset(Offset = "0x20")]
	public Image Portrait;

	// Token: 0x04000D1C RID: 3356
	[Token(Token = "0x4000D1C")]
	[FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI Name;

	// Token: 0x04000D1D RID: 3357
	[Token(Token = "0x4000D1D")]
	[FieldOffset(Offset = "0x30")]
	public CharacterTooltipSource CharacterTooltipSource;

	// Token: 0x04000D1E RID: 3358
	[Token(Token = "0x4000D1E")]
	[FieldOffset(Offset = "0x38")]
	public ContextActions Options;

	// Token: 0x04000D1F RID: 3359
	[Token(Token = "0x4000D1F")]
	[FieldOffset(Offset = "0x40")]
	public World World;

	// Token: 0x04000D20 RID: 3360
	[Token(Token = "0x4000D20")]
	[FieldOffset(Offset = "0x48")]
	public RectTransform HealthFill;

	// Token: 0x04000D21 RID: 3361
	[Token(Token = "0x4000D21")]
	[FieldOffset(Offset = "0x50")]
	private Character _character;

	// Token: 0x04000D22 RID: 3362
	[Token(Token = "0x4000D22")]
	[FieldOffset(Offset = "0x58")]
	private uint _entityId;

	// Token: 0x04000D23 RID: 3363
	[Token(Token = "0x4000D23")]
	[FieldOffset(Offset = "0x5C")]
	private bool _canKick;

	// Token: 0x04000D24 RID: 3364
	[Token(Token = "0x4000D24")]
	[FieldOffset(Offset = "0x60")]
	private int _memberIndex;
}
