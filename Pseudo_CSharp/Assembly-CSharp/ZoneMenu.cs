using System;
using Il2CppDummyDll;
using MapEditor;
using TMPro;
using UnityEngine;

// Token: 0x020000CA RID: 202
[Token(Token = "0x20000CA")]
public class ZoneMenu : MonoBehaviour
{
	// Token: 0x06000389 RID: 905 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000389")]
	[Address(RVA = "0x3D3470", Offset = "0x3D2670", VA = "0x1803D3470")]
	public void Okay()
	{
	}

	// Token: 0x0600038A RID: 906 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600038A")]
	[Address(RVA = "0x3D3470", Offset = "0x3D2670", VA = "0x1803D3470")]
	public void Remove()
	{
	}

	// Token: 0x0600038B RID: 907 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600038B")]
	[Address(RVA = "0x3D3490", Offset = "0x3D2690", VA = "0x1803D3490")]
	private void SetTitle(Vector2Int coordinates)
	{
	}

	// Token: 0x0600038C RID: 908 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600038C")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public ZoneMenu()
	{
	}

	// Token: 0x04000370 RID: 880
	[Token(Token = "0x4000370")]
	[FieldOffset(Offset = "0x20")]
	public TMP_InputField LabelInput;

	// Token: 0x04000371 RID: 881
	[Token(Token = "0x4000371")]
	[FieldOffset(Offset = "0x28")]
	public Menu Menu;

	// Token: 0x04000372 RID: 882
	[Token(Token = "0x4000372")]
	[FieldOffset(Offset = "0x30")]
	public MapEditorContext Context;

	// Token: 0x04000373 RID: 883
	[Token(Token = "0x4000373")]
	[FieldOffset(Offset = "0x38")]
	public GameObject RemoveButton;

	// Token: 0x04000374 RID: 884
	[Token(Token = "0x4000374")]
	[FieldOffset(Offset = "0x40")]
	public TextMeshProUGUI Title;

	// Token: 0x04000375 RID: 885
	[Token(Token = "0x4000375")]
	[FieldOffset(Offset = "0x48")]
	private Vector2Int _coordinates;
}
