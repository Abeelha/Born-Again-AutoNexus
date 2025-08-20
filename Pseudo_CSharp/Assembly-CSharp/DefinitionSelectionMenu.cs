using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using Ronin.Model.Definitions;
using TMPro;
using UnityEngine;

// Token: 0x020000C3 RID: 195
[Token(Token = "0x20000C3")]
public class DefinitionSelectionMenu : MonoBehaviour
{
	// Token: 0x0600035A RID: 858 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600035A")]
	[Address(RVA = "0x3C30A0", Offset = "0x3C22A0", VA = "0x1803C30A0")]
	public void Cancel()
	{
	}

	// Token: 0x0600035B RID: 859 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600035B")]
	[Address(RVA = "0x3C31E0", Offset = "0x3C23E0", VA = "0x1803C31E0")]
	public void Okay()
	{
	}

	// Token: 0x0600035C RID: 860 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600035C")]
	[Address(RVA = "0x3C32B0", Offset = "0x3C24B0", VA = "0x1803C32B0")]
	public void Search(string text)
	{
	}

	// Token: 0x0600035D RID: 861 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600035D")]
	[Address(RVA = "0x3C3500", Offset = "0x3C2700", VA = "0x1803C3500")]
	public void Select(DefinitionPreview preview)
	{
	}

	// Token: 0x0600035E RID: 862 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600035E")]
	[Address(RVA = "0x3C3C10", Offset = "0x3C2E10", VA = "0x1803C3C10")]
	public Task<ValueTuple<bool, IEnumerable<ObjectDefinition>>> ShowAsync(IEnumerable<ObjectDefinition> current, [Optional] Func<ObjectDefinition, bool> filter)
	{
		return null;
	}

	// Token: 0x0600035F RID: 863 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600035F")]
	[Address(RVA = "0x3C3090", Offset = "0x3C2290", VA = "0x1803C3090")]
	private void Awake()
	{
	}

	// Token: 0x06000360 RID: 864 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000360")]
	[Address(RVA = "0x3C3160", Offset = "0x3C2360", VA = "0x1803C3160")]
	private void Init()
	{
	}

	// Token: 0x06000361 RID: 865 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000361")]
	[Address(RVA = "0x3C35E0", Offset = "0x3C27E0", VA = "0x1803C35E0")]
	private void SetResults(IEnumerable<ObjectDefinition> results)
	{
	}

	// Token: 0x06000362 RID: 866 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000362")]
	[Address(RVA = "0x3C40A0", Offset = "0x3C32A0", VA = "0x1803C40A0")]
	public DefinitionSelectionMenu()
	{
	}

	// Token: 0x04000342 RID: 834
	[Token(Token = "0x4000342")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform ResultsParent;

	// Token: 0x04000343 RID: 835
	[Token(Token = "0x4000343")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Menu Menu;

	// Token: 0x04000344 RID: 836
	[Token(Token = "0x4000344")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public TMP_InputField SearchInput;

	// Token: 0x04000345 RID: 837
	[Token(Token = "0x4000345")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private DefinitionPreview[] _previews;

	// Token: 0x04000346 RID: 838
	[Token(Token = "0x4000346")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Func<ObjectDefinition, bool> _filter;

	// Token: 0x04000347 RID: 839
	[Token(Token = "0x4000347")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private TaskCompletionSource<ValueTuple<bool, IEnumerable<ObjectDefinition>>> _resultTask;

	// Token: 0x04000348 RID: 840
	[Token(Token = "0x4000348")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly Dictionary<ushort, ObjectDefinition> _selections;

	// Token: 0x04000349 RID: 841
	[Token(Token = "0x4000349")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private IEnumerable<ObjectDefinition> _results;
}
