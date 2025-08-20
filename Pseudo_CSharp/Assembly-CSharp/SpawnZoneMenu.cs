using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using MapEditor;
using Ronin.Model.Structs;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020000C7 RID: 199
[Token(Token = "0x20000C7")]
public class SpawnZoneMenu : MonoBehaviour
{
	// Token: 0x1700004C RID: 76
	// (get) Token: 0x06000370 RID: 880 RVA: 0x000031F8 File Offset: 0x000013F8
	// (set) Token: 0x06000371 RID: 881 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700004C")]
	public SpawnZone DefaultSpawnZone
	{
		[Token(Token = "0x6000370")]
		[Address(RVA = "0x3C8520", Offset = "0x3C7720", VA = "0x1803C8520")]
		[CompilerGenerated]
		get
		{
			return default(SpawnZone);
		}
		[Token(Token = "0x6000371")]
		[Address(RVA = "0x3C8550", Offset = "0x3C7750", VA = "0x1803C8550")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x06000372 RID: 882 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000372")]
	[Address(RVA = "0x3C6CA0", Offset = "0x3C5EA0", VA = "0x1803C6CA0")]
	public void ApplyAll()
	{
	}

	// Token: 0x06000373 RID: 883 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000373")]
	[Address(RVA = "0x3C7470", Offset = "0x3C6670", VA = "0x1803C7470")]
	public void Edit()
	{
	}

	// Token: 0x06000374 RID: 884 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000374")]
	[Address(RVA = "0x3C7720", Offset = "0x3C6920", VA = "0x1803C7720")]
	public void Okay()
	{
	}

	// Token: 0x06000375 RID: 885 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000375")]
	[Address(RVA = "0x3C78C0", Offset = "0x3C6AC0", VA = "0x1803C78C0")]
	public void Remove()
	{
	}

	// Token: 0x06000376 RID: 886 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000376")]
	[Address(RVA = "0x3C7EB0", Offset = "0x3C70B0", VA = "0x1803C7EB0")]
	public void Show(Vector2Int coordinates, SpawnZone? currentSpawnZone)
	{
	}

	// Token: 0x06000377 RID: 887 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000377")]
	[Address(RVA = "0x3C7E40", Offset = "0x3C7040", VA = "0x1803C7E40")]
	public void ShowDefault()
	{
	}

	// Token: 0x06000378 RID: 888 RVA: 0x00003210 File Offset: 0x00001410
	[Token(Token = "0x6000378")]
	[Address(RVA = "0x3C76E0", Offset = "0x3C68E0", VA = "0x1803C76E0")]
	private static int IntValue(TMP_InputField inputField)
	{
		return 0;
	}

	// Token: 0x06000379 RID: 889 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000379")]
	[Address(RVA = "0x3C7470", Offset = "0x3C6670", VA = "0x1803C7470")]
	private Task EditAsync()
	{
		return null;
	}

	// Token: 0x0600037A RID: 890 RVA: 0x00003228 File Offset: 0x00001428
	[Token(Token = "0x600037A")]
	[Address(RVA = "0x3C7330", Offset = "0x3C6530", VA = "0x1803C7330")]
	private SpawnZone CreateNewSpawnZone()
	{
		return default(SpawnZone);
	}

	// Token: 0x0600037B RID: 891 RVA: 0x00003240 File Offset: 0x00001440
	[Token(Token = "0x600037B")]
	[Address(RVA = "0x3C7540", Offset = "0x3C6740", VA = "0x1803C7540")]
	private SpawnZone GetSpawnZone()
	{
		return default(SpawnZone);
	}

	// Token: 0x0600037C RID: 892 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600037C")]
	[Address(RVA = "0x3C7960", Offset = "0x3C6B60", VA = "0x1803C7960")]
	private void SetTitle(Vector2Int coordinates)
	{
	}

	// Token: 0x0600037D RID: 893 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600037D")]
	[Address(RVA = "0x3C7B30", Offset = "0x3C6D30", VA = "0x1803C7B30")]
	private void Setup(bool exists)
	{
	}

	// Token: 0x0600037E RID: 894 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600037E")]
	[Address(RVA = "0x3C8130", Offset = "0x3C7330", VA = "0x1803C8130")]
	private void UpdateTypesLabel()
	{
	}

	// Token: 0x0600037F RID: 895 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600037F")]
	[Address(RVA = "0x3C82D0", Offset = "0x3C74D0", VA = "0x1803C82D0")]
	private void UpdateValues()
	{
	}

	// Token: 0x06000380 RID: 896 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000380")]
	[Address(RVA = "0x3C83C0", Offset = "0x3C75C0", VA = "0x1803C83C0")]
	public SpawnZoneMenu()
	{
	}

	// Token: 0x06000381 RID: 897 RVA: 0x00003258 File Offset: 0x00001458
	[Token(Token = "0x6000381")]
	[Address(RVA = "0x3C8090", Offset = "0x3C7290", VA = "0x1803C8090")]
	[CompilerGenerated]
	internal static bool <ApplyAll>g__equalsEnough|20_0(SpawnZone a, SpawnZone b)
	{
		return default(bool);
	}

	// Token: 0x04000357 RID: 855
	[Token(Token = "0x4000357")]
	private const string NoTypesLabel = "None";

	// Token: 0x04000358 RID: 856
	[Token(Token = "0x4000358")]
	[FieldOffset(Offset = "0x20")]
	public TMP_InputField MinInput;

	// Token: 0x04000359 RID: 857
	[Token(Token = "0x4000359")]
	[FieldOffset(Offset = "0x28")]
	public TMP_InputField MaxInput;

	// Token: 0x0400035A RID: 858
	[Token(Token = "0x400035A")]
	[FieldOffset(Offset = "0x30")]
	public TMP_InputField CountInput;

	// Token: 0x0400035B RID: 859
	[Token(Token = "0x400035B")]
	[FieldOffset(Offset = "0x38")]
	public Toggle SafeRespawnToggle;

	// Token: 0x0400035C RID: 860
	[Token(Token = "0x400035C")]
	[FieldOffset(Offset = "0x40")]
	public TextMeshProUGUI TypesLabel;

	// Token: 0x0400035D RID: 861
	[Token(Token = "0x400035D")]
	[FieldOffset(Offset = "0x48")]
	public Menu Menu;

	// Token: 0x0400035E RID: 862
	[Token(Token = "0x400035E")]
	[FieldOffset(Offset = "0x50")]
	public MapEditorContext Context;

	// Token: 0x0400035F RID: 863
	[Token(Token = "0x400035F")]
	[FieldOffset(Offset = "0x58")]
	public GameObject RemoveButton;

	// Token: 0x04000360 RID: 864
	[Token(Token = "0x4000360")]
	[FieldOffset(Offset = "0x60")]
	public GameObject ApplyAllButton;

	// Token: 0x04000361 RID: 865
	[Token(Token = "0x4000361")]
	[FieldOffset(Offset = "0x68")]
	public TextMeshProUGUI Title;

	// Token: 0x04000362 RID: 866
	[Token(Token = "0x4000362")]
	[FieldOffset(Offset = "0x70")]
	public DefinitionSelectionMenu DefinitionSelectionMenu;

	// Token: 0x04000363 RID: 867
	[Token(Token = "0x4000363")]
	[FieldOffset(Offset = "0x78")]
	private Vector2Int _coordinates;

	// Token: 0x04000364 RID: 868
	[Token(Token = "0x4000364")]
	[FieldOffset(Offset = "0x80")]
	private SpawnZone _currentSpawnZone;

	// Token: 0x04000365 RID: 869
	[Token(Token = "0x4000365")]
	[FieldOffset(Offset = "0xA8")]
	private bool _editingDefault;

	// Token: 0x04000366 RID: 870
	[Token(Token = "0x4000366")]
	[FieldOffset(Offset = "0xB0")]
	private ushort[] _types;
}
