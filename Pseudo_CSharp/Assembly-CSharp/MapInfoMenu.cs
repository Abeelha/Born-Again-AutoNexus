using System;
using System.Threading.Tasks;
using Il2CppDummyDll;
using MapEditor;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020000C5 RID: 197
[Token(Token = "0x20000C5")]
public class MapInfoMenu : MonoBehaviour
{
	// Token: 0x06000368 RID: 872 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000368")]
	[Address(RVA = "0x3C6910", Offset = "0x3C5B10", VA = "0x1803C6910")]
	public void Close()
	{
	}

	// Token: 0x06000369 RID: 873 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000369")]
	[Address(RVA = "0x3C6A50", Offset = "0x3C5C50", VA = "0x1803C6A50")]
	public void PickGlobalColor()
	{
	}

	// Token: 0x0600036A RID: 874 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600036A")]
	[Address(RVA = "0x3C69C0", Offset = "0x3C5BC0", VA = "0x1803C69C0")]
	private void OnEnable()
	{
	}

	// Token: 0x0600036B RID: 875 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600036B")]
	[Address(RVA = "0x3C6A50", Offset = "0x3C5C50", VA = "0x1803C6A50")]
	private Task PickGlobalColorAsync()
	{
		return null;
	}

	// Token: 0x0600036C RID: 876 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600036C")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public MapInfoMenu()
	{
	}

	// Token: 0x0400034D RID: 845
	[Token(Token = "0x400034D")]
	[FieldOffset(Offset = "0x20")]
	public Menu Menu;

	// Token: 0x0400034E RID: 846
	[Token(Token = "0x400034E")]
	[FieldOffset(Offset = "0x28")]
	public MapEditorContext Context;

	// Token: 0x0400034F RID: 847
	[Token(Token = "0x400034F")]
	[FieldOffset(Offset = "0x30")]
	public ColorPickerMenu ColorPicker;

	// Token: 0x04000350 RID: 848
	[Token(Token = "0x4000350")]
	[FieldOffset(Offset = "0x38")]
	public TMP_InputField BackgroundInput;

	// Token: 0x04000351 RID: 849
	[Token(Token = "0x4000351")]
	[FieldOffset(Offset = "0x40")]
	public Image GlobalLightColor;
}
