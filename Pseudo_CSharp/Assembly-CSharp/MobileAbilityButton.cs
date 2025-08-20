using System;
using System.Collections.Generic;
using AnimateInternal;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x020002D2 RID: 722
[Token(Token = "0x20002D2")]
public class MobileAbilityButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
{
	// Token: 0x06000F98 RID: 3992 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F98")]
	[Address(RVA = "0x351590", Offset = "0x350790", VA = "0x180351590", Slot = "4")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	// Token: 0x06000F99 RID: 3993 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F99")]
	[Address(RVA = "0x351660", Offset = "0x350860", VA = "0x180351660")]
	public void SetFill(float progress, int charges, int maxCharge)
	{
	}

	// Token: 0x06000F9A RID: 3994 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F9A")]
	[Address(RVA = "0x351190", Offset = "0x350390", VA = "0x180351190")]
	private void BounceAnimation()
	{
	}

	// Token: 0x06000F9B RID: 3995 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F9B")]
	[Address(RVA = "0x3513E0", Offset = "0x3505E0", VA = "0x1803513E0")]
	private void CancelTask()
	{
	}

	// Token: 0x06000F9C RID: 3996 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F9C")]
	[Address(RVA = "0x351490", Offset = "0x350690", VA = "0x180351490")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000F9D RID: 3997 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F9D")]
	[Address(RVA = "0x351490", Offset = "0x350690", VA = "0x180351490")]
	private void UpdateIcon()
	{
	}

	// Token: 0x06000F9E RID: 3998 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F9E")]
	[Address(RVA = "0x351860", Offset = "0x350A60", VA = "0x180351860")]
	public MobileAbilityButton()
	{
	}

	// Token: 0x04000CDB RID: 3291
	[Token(Token = "0x4000CDB")]
	[FieldOffset(Offset = "0x20")]
	public Slot Slot;

	// Token: 0x04000CDC RID: 3292
	[Token(Token = "0x4000CDC")]
	[FieldOffset(Offset = "0x28")]
	public UseManager UseManager;

	// Token: 0x04000CDD RID: 3293
	[Token(Token = "0x4000CDD")]
	[FieldOffset(Offset = "0x30")]
	public RectTransform MobileJoystick;

	// Token: 0x04000CDE RID: 3294
	[Token(Token = "0x4000CDE")]
	[FieldOffset(Offset = "0x38")]
	public Image Base;

	// Token: 0x04000CDF RID: 3295
	[Token(Token = "0x4000CDF")]
	[FieldOffset(Offset = "0x40")]
	public Image Fill;

	// Token: 0x04000CE0 RID: 3296
	[Token(Token = "0x4000CE0")]
	[FieldOffset(Offset = "0x48")]
	public Image Icon;

	// Token: 0x04000CE1 RID: 3297
	[Token(Token = "0x4000CE1")]
	[FieldOffset(Offset = "0x50")]
	public Sprite BaseSprite;

	// Token: 0x04000CE2 RID: 3298
	[Token(Token = "0x4000CE2")]
	[FieldOffset(Offset = "0x58")]
	public Sprite ReadySprite;

	// Token: 0x04000CE3 RID: 3299
	[Token(Token = "0x4000CE3")]
	[FieldOffset(Offset = "0x60")]
	public Sprite ChargingSprite;

	// Token: 0x04000CE4 RID: 3300
	[Token(Token = "0x4000CE4")]
	[FieldOffset(Offset = "0x68")]
	public TextMeshProUGUI ChargesLabel;

	// Token: 0x04000CE5 RID: 3301
	[Token(Token = "0x4000CE5")]
	[FieldOffset(Offset = "0x70")]
	private int _charges;

	// Token: 0x04000CE6 RID: 3302
	[Token(Token = "0x4000CE6")]
	[FieldOffset(Offset = "0x78")]
	private AnimateTask _task;

	// Token: 0x04000CE7 RID: 3303
	[Token(Token = "0x4000CE7")]
	[FieldOffset(Offset = "0x80")]
	private readonly Dictionary<int, string> _chargeLabels;
}
