using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x020002B5 RID: 693
[Token(Token = "0x20002B5")]
public class KeybindLabelController : MonoBehaviour
{
	// Token: 0x06000EDC RID: 3804 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EDC")]
	[Address(RVA = "0x46B5B0", Offset = "0x46A7B0", VA = "0x18046B5B0")]
	private void Awake()
	{
	}

	// Token: 0x06000EDD RID: 3805 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EDD")]
	[Address(RVA = "0x46B8B0", Offset = "0x46AAB0", VA = "0x18046B8B0")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000EDE RID: 3806 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EDE")]
	[Address(RVA = "0x46BA20", Offset = "0x46AC20", VA = "0x18046BA20")]
	private void OnUseConsumableOptionChange(Option option)
	{
	}

	// Token: 0x06000EDF RID: 3807 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EDF")]
	[Address(RVA = "0x46BAD0", Offset = "0x46ACD0", VA = "0x18046BAD0")]
	private void OnUseEquipOptionChange(Option option)
	{
	}

	// Token: 0x06000EE0 RID: 3808 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EE0")]
	[Address(RVA = "0x46BB80", Offset = "0x46AD80", VA = "0x18046BB80")]
	private void SetConsumableKeybind(int index, Option option)
	{
	}

	// Token: 0x06000EE1 RID: 3809 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EE1")]
	[Address(RVA = "0x46BBF0", Offset = "0x46ADF0", VA = "0x18046BBF0")]
	private void SetEquipKeybind(int index, Option option)
	{
	}

	// Token: 0x06000EE2 RID: 3810 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EE2")]
	[Address(RVA = "0x46BC60", Offset = "0x46AE60", VA = "0x18046BC60")]
	public KeybindLabelController()
	{
	}

	// Token: 0x04000C3E RID: 3134
	[Token(Token = "0x4000C3E")]
	[FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI[] EquipKeybindLabels;

	// Token: 0x04000C3F RID: 3135
	[Token(Token = "0x4000C3F")]
	[FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI[] ConsumableKeybindLabels;

	// Token: 0x04000C40 RID: 3136
	[Token(Token = "0x4000C40")]
	[FieldOffset(Offset = "0x30")]
	private readonly Option[] _useEquipOptions;

	// Token: 0x04000C41 RID: 3137
	[Token(Token = "0x4000C41")]
	[FieldOffset(Offset = "0x38")]
	private readonly Option[] _useConsumableOptions;
}
