using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000002 RID: 2
[Token(Token = "0x2000002")]
[RequireComponent(typeof(FlexibleColorPicker))]
public class FCP_Persistence : MonoBehaviour
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x321460", Offset = "0x320660", VA = "0x180321460")]
	private void Awake()
	{
	}

	// Token: 0x06000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000002")]
	[Address(RVA = "0x321550", Offset = "0x320750", VA = "0x180321550")]
	private void InitStatic()
	{
	}

	// Token: 0x06000003 RID: 3 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000003")]
	[Address(RVA = "0x321AA0", Offset = "0x320CA0", VA = "0x180321AA0")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000004 RID: 4 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000004")]
	[Address(RVA = "0x321B60", Offset = "0x320D60", VA = "0x180321B60")]
	private void OnEnable()
	{
	}

	// Token: 0x06000005 RID: 5 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000005")]
	[Address(RVA = "0x321B10", Offset = "0x320D10", VA = "0x180321B10")]
	private void OnDisable()
	{
	}

	// Token: 0x06000006 RID: 6 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000006")]
	[Address(RVA = "0x321950", Offset = "0x320B50", VA = "0x180321950")]
	private void LoadDataFile()
	{
	}

	// Token: 0x06000007 RID: 7 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000007")]
	[Address(RVA = "0x321F40", Offset = "0x321140", VA = "0x180321F40")]
	private void SaveDataFile()
	{
	}

	// Token: 0x06000008 RID: 8 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000008")]
	[Address(RVA = "0x321CE0", Offset = "0x320EE0", VA = "0x180321CE0")]
	public void SaveColor(Color c)
	{
	}

	// Token: 0x06000009 RID: 9 RVA: 0x00002054 File Offset: 0x00000254
	[Token(Token = "0x6000009")]
	[Address(RVA = "0x321810", Offset = "0x320A10", VA = "0x180321810")]
	public bool LoadColor(out Color c)
	{
		return default(bool);
	}

	// Token: 0x0600000A RID: 10 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600000A")]
	[Address(RVA = "0x3214C0", Offset = "0x3206C0", VA = "0x1803214C0")]
	private static string GenerateID()
	{
		return null;
	}

	// Token: 0x0600000B RID: 11 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000B")]
	[Address(RVA = "0x3221C0", Offset = "0x3213C0", VA = "0x1803221C0")]
	public FCP_Persistence()
	{
	}

	// Token: 0x04000001 RID: 1
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x20")]
	public string saveName;

	// Token: 0x04000002 RID: 2
	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x28")]
	public FCP_Persistence.SaveStrategy saveStrategy;

	// Token: 0x04000003 RID: 3
	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x30")]
	private FlexibleColorPicker fcp;

	// Token: 0x04000004 RID: 4
	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<string, Color> savedColors;

	// Token: 0x04000005 RID: 5
	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x8")]
	private static string saveFilePath;

	// Token: 0x04000006 RID: 6
	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x10")]
	private static bool saveFileLoaded;

	// Token: 0x04000007 RID: 7
	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x11")]
	private static bool saveFileOutdated;

	// Token: 0x02000003 RID: 3
	[Token(Token = "0x2000003")]
	public enum SaveStrategy
	{
		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		SessionOnly,
		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		File,
		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		PlayerPrefs
	}
}
