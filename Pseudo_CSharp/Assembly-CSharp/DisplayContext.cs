using System;
using Il2CppDummyDll;
using Ronin.Model.Definitions;
using TMPro;
using UnityEngine;

// Token: 0x020000ED RID: 237
[Token(Token = "0x20000ED")]
public class DisplayContext : MonoBehaviour
{
	// Token: 0x0600041B RID: 1051 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600041B")]
	[Address(RVA = "0x3C4280", Offset = "0x3C3480", VA = "0x1803C4280")]
	public void OnLanguageChanged()
	{
	}

	// Token: 0x0600041C RID: 1052 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600041C")]
	[Address(RVA = "0x3C41D0", Offset = "0x3C33D0", VA = "0x1803C41D0")]
	private void OnDisable()
	{
	}

	// Token: 0x0600041D RID: 1053 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600041D")]
	[Address(RVA = "0x3C4140", Offset = "0x3C3340", VA = "0x1803C4140")]
	private void LateUpdate()
	{
	}

	// Token: 0x0600041E RID: 1054 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600041E")]
	[Address(RVA = "0x3C4140", Offset = "0x3C3340", VA = "0x1803C4140")]
	private void UpdateContext()
	{
	}

	// Token: 0x0600041F RID: 1055 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600041F")]
	[Address(RVA = "0x3C4330", Offset = "0x3C3530", VA = "0x1803C4330")]
	private void SyncItem(GameObject item)
	{
	}

	// Token: 0x06000420 RID: 1056 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000420")]
	[Address(RVA = "0x3C5260", Offset = "0x3C4460", VA = "0x1803C5260")]
	private void UpdateLerpScalar()
	{
	}

	// Token: 0x06000421 RID: 1057 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000421")]
	[Address(RVA = "0x3C5570", Offset = "0x3C4770", VA = "0x1803C5570")]
	public DisplayContext()
	{
	}

	// Token: 0x04000425 RID: 1061
	[Token(Token = "0x4000425")]
	[FieldOffset(Offset = "0x20")]
	public GameObjectGallery Gallery;

	// Token: 0x04000426 RID: 1062
	[Token(Token = "0x4000426")]
	[FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI ButtonText;

	// Token: 0x04000427 RID: 1063
	[Token(Token = "0x4000427")]
	[FieldOffset(Offset = "0x30")]
	public RectTransform ButtonTextTransform;

	// Token: 0x04000428 RID: 1064
	[Token(Token = "0x4000428")]
	[FieldOffset(Offset = "0x38")]
	public BlessingStrand Thread;

	// Token: 0x04000429 RID: 1065
	[Token(Token = "0x4000429")]
	[FieldOffset(Offset = "0x40")]
	public ExperienceOrbs ExperienceOrbs;

	// Token: 0x0400042A RID: 1066
	[Token(Token = "0x400042A")]
	[FieldOffset(Offset = "0x48")]
	public TooltipBuilder TooltipBuilder;

	// Token: 0x0400042B RID: 1067
	[Token(Token = "0x400042B")]
	[FieldOffset(Offset = "0x50")]
	public StatsDisplay Stats;

	// Token: 0x0400042C RID: 1068
	[Token(Token = "0x400042C")]
	[FieldOffset(Offset = "0x58")]
	public TextMeshProUGUI AltButtonText;

	// Token: 0x0400042D RID: 1069
	[Token(Token = "0x400042D")]
	[FieldOffset(Offset = "0x60")]
	public RectTransform AltButtonTextTransform;

	// Token: 0x0400042E RID: 1070
	[Token(Token = "0x400042E")]
	[FieldOffset(Offset = "0x68")]
	public TextMeshProUGUI Ordinal;

	// Token: 0x0400042F RID: 1071
	[Token(Token = "0x400042F")]
	[FieldOffset(Offset = "0x70")]
	public PurchaseOptions PurchaseOptions;

	// Token: 0x04000430 RID: 1072
	[Token(Token = "0x4000430")]
	[FieldOffset(Offset = "0x78")]
	public bool Tooltip;

	// Token: 0x04000431 RID: 1073
	[Token(Token = "0x4000431")]
	[FieldOffset(Offset = "0x80")]
	private GameObject _syncedItem;

	// Token: 0x04000432 RID: 1074
	[Token(Token = "0x4000432")]
	[FieldOffset(Offset = "0x88")]
	private ObjectDefinition _tooltipDefinition;

	// Token: 0x04000433 RID: 1075
	[Token(Token = "0x4000433")]
	[FieldOffset(Offset = "0x90")]
	private Tooltip _tooltip;
}
