using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000C1 RID: 193
[Token(Token = "0x20000C1")]
public class ColorPickerMenu : MonoBehaviour
{
	// Token: 0x06000350 RID: 848 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000350")]
	[Address(RVA = "0x3C28F0", Offset = "0x3C1AF0", VA = "0x1803C28F0")]
	public Task<Color?> GetColorAsync([Optional] Color? startColor, [Optional] Action<Color> colorCallback)
	{
		return null;
	}

	// Token: 0x06000351 RID: 849 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000351")]
	[Address(RVA = "0x3C2A70", Offset = "0x3C1C70", VA = "0x1803C2A70")]
	public void Okay()
	{
	}

	// Token: 0x06000352 RID: 850 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000352")]
	[Address(RVA = "0x3C2880", Offset = "0x3C1A80", VA = "0x1803C2880")]
	public void Cancel()
	{
	}

	// Token: 0x06000353 RID: 851 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000353")]
	[Address(RVA = "0x3C2A20", Offset = "0x3C1C20", VA = "0x1803C2A20")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000354 RID: 852 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000354")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public ColorPickerMenu()
	{
	}

	// Token: 0x04000338 RID: 824
	[Token(Token = "0x4000338")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Menu Menu;

	// Token: 0x04000339 RID: 825
	[Token(Token = "0x4000339")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public FlexibleColorPicker FlexibleColorPicker;

	// Token: 0x0400033A RID: 826
	[Token(Token = "0x400033A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private TaskCompletionSource<Color?> _colorResponse;

	// Token: 0x0400033B RID: 827
	[Token(Token = "0x400033B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Action<Color> _colorCallback;
}
