using System;
using Il2CppDummyDll;
using MapEditor;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020000CB RID: 203
[Token(Token = "0x20000CB")]
public class ZonePointMenu : MonoBehaviour
{
	// Token: 0x0600038D RID: 909 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600038D")]
	[Address(RVA = "0x3D36A0", Offset = "0x3D28A0", VA = "0x1803D36A0")]
	public void Okay()
	{
	}

	// Token: 0x0600038E RID: 910 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600038E")]
	[Address(RVA = "0x3D3790", Offset = "0x3D2990", VA = "0x1803D3790")]
	public void Show(ZonePointGroup currentZone)
	{
	}

	// Token: 0x0600038F RID: 911 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600038F")]
	[Address(RVA = "0x3D38C0", Offset = "0x3D2AC0", VA = "0x1803D38C0")]
	private void UpdateValues()
	{
	}

	// Token: 0x06000390 RID: 912 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000390")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public ZonePointMenu()
	{
	}

	// Token: 0x04000376 RID: 886
	[Token(Token = "0x4000376")]
	[FieldOffset(Offset = "0x20")]
	public TMP_InputField LabelInput;

	// Token: 0x04000377 RID: 887
	[Token(Token = "0x4000377")]
	[FieldOffset(Offset = "0x28")]
	public TMP_InputField MusicInput;

	// Token: 0x04000378 RID: 888
	[Token(Token = "0x4000378")]
	[FieldOffset(Offset = "0x30")]
	public TMP_InputField LocationIdInput;

	// Token: 0x04000379 RID: 889
	[Token(Token = "0x4000379")]
	[FieldOffset(Offset = "0x38")]
	public Toggle SafeToggle;

	// Token: 0x0400037A RID: 890
	[Token(Token = "0x400037A")]
	[FieldOffset(Offset = "0x40")]
	public Menu Menu;

	// Token: 0x0400037B RID: 891
	[Token(Token = "0x400037B")]
	[FieldOffset(Offset = "0x48")]
	public MapEditorContext Context;

	// Token: 0x0400037C RID: 892
	[Token(Token = "0x400037C")]
	[FieldOffset(Offset = "0x50")]
	private ZonePointGroup _currentZone;
}
