using System;
using System.Threading.Tasks;
using Il2CppDummyDll;
using Ronin.Model.Files.Map;
using SFB;
using TMPro;
using UnityEngine;

namespace MapEditor
{
	// Token: 0x02000367 RID: 871
	[Token(Token = "0x2000367")]
	public class MapEditorFileControls : MonoBehaviour
	{
		// Token: 0x060013A5 RID: 5029 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60013A5")]
		[Address(RVA = "0x399680", Offset = "0x398880", VA = "0x180399680")]
		public static ExtensionFilter[] GetExtensions()
		{
			return null;
		}

		// Token: 0x060013A6 RID: 5030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013A6")]
		[Address(RVA = "0x3994E0", Offset = "0x3986E0", VA = "0x1803994E0")]
		public void Export()
		{
		}

		// Token: 0x060013A7 RID: 5031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013A7")]
		[Address(RVA = "0x3999A0", Offset = "0x398BA0", VA = "0x1803999A0")]
		public void Menu()
		{
		}

		// Token: 0x060013A8 RID: 5032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013A8")]
		[Address(RVA = "0x399AB0", Offset = "0x398CB0", VA = "0x180399AB0")]
		public void Open()
		{
		}

		// Token: 0x060013A9 RID: 5033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013A9")]
		[Address(RVA = "0x399D90", Offset = "0x398F90", VA = "0x180399D90")]
		public void Reload()
		{
		}

		// Token: 0x060013AA RID: 5034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013AA")]
		[Address(RVA = "0x399F90", Offset = "0x399190", VA = "0x180399F90")]
		public void Save()
		{
		}

		// Token: 0x060013AB RID: 5035 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60013AB")]
		[Address(RVA = "0x39A320", Offset = "0x399520", VA = "0x18039A320")]
		private static Task WriteToPath(string path, MapFile file)
		{
			return null;
		}

		// Token: 0x060013AC RID: 5036 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60013AC")]
		[Address(RVA = "0x399CC0", Offset = "0x398EC0", VA = "0x180399CC0")]
		private Task ReloadAsync()
		{
			return null;
		}

		// Token: 0x060013AD RID: 5037 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60013AD")]
		[Address(RVA = "0x3993D0", Offset = "0x3985D0", VA = "0x1803993D0")]
		private Task ExportAsync(string path, RectInt rect)
		{
			return null;
		}

		// Token: 0x060013AE RID: 5038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013AE")]
		[Address(RVA = "0x399370", Offset = "0x398570", VA = "0x180399370")]
		private void CheckForSave()
		{
		}

		// Token: 0x060013AF RID: 5039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013AF")]
		[Address(RVA = "0x3997F0", Offset = "0x3989F0", VA = "0x1803997F0")]
		private void LateUpdate()
		{
		}

		// Token: 0x060013B0 RID: 5040 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60013B0")]
		[Address(RVA = "0x3999B0", Offset = "0x398BB0", VA = "0x1803999B0")]
		private Task OpenAsync(string path)
		{
			return null;
		}

		// Token: 0x060013B1 RID: 5041 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60013B1")]
		[Address(RVA = "0x399EA0", Offset = "0x3990A0", VA = "0x180399EA0")]
		private Task SaveAsync(string path)
		{
			return null;
		}

		// Token: 0x060013B2 RID: 5042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013B2")]
		[Address(RVA = "0x39A1C0", Offset = "0x3993C0", VA = "0x18039A1C0")]
		private void SyncPath()
		{
		}

		// Token: 0x060013B3 RID: 5043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013B3")]
		[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
		public MapEditorFileControls()
		{
		}

		// Token: 0x04001006 RID: 4102
		[Token(Token = "0x4001006")]
		[FieldOffset(Offset = "0x20")]
		public MapEditorContext Context;

		// Token: 0x04001007 RID: 4103
		[Token(Token = "0x4001007")]
		[FieldOffset(Offset = "0x28")]
		public TextMeshProUGUI PathLabel;

		// Token: 0x04001008 RID: 4104
		[Token(Token = "0x4001008")]
		[FieldOffset(Offset = "0x30")]
		public ObjectGallery[] Galleries;

		// Token: 0x04001009 RID: 4105
		[Token(Token = "0x4001009")]
		[FieldOffset(Offset = "0x38")]
		private string _syncedPath;

		// Token: 0x0400100A RID: 4106
		[Token(Token = "0x400100A")]
		[FieldOffset(Offset = "0x40")]
		private bool _syncedEdited;
	}
}
