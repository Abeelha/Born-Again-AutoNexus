using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace MapEditor
{
	// Token: 0x0200036F RID: 879
	[Token(Token = "0x200036F")]
	public class MapEditorZoomControls : MonoBehaviour
	{
		// Token: 0x060013C9 RID: 5065 RVA: 0x00006F30 File Offset: 0x00005130
		[Token(Token = "0x60013C9")]
		[Address(RVA = "0x39F7E0", Offset = "0x39E9E0", VA = "0x18039F7E0")]
		private bool IsSelected()
		{
			return default(bool);
		}

		// Token: 0x060013CA RID: 5066 RVA: 0x00006F48 File Offset: 0x00005148
		[Token(Token = "0x60013CA")]
		[Address(RVA = "0x39F880", Offset = "0x39EA80", VA = "0x18039F880")]
		private bool MouseOverControls()
		{
			return default(bool);
		}

		// Token: 0x060013CB RID: 5067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013CB")]
		[Address(RVA = "0x39FD80", Offset = "0x39EF80", VA = "0x18039FD80")]
		private void Update()
		{
		}

		// Token: 0x060013CC RID: 5068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013CC")]
		[Address(RVA = "0x39FA00", Offset = "0x39EC00", VA = "0x18039FA00")]
		private void UpdateZoom()
		{
		}

		// Token: 0x060013CD RID: 5069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013CD")]
		[Address(RVA = "0x39FD90", Offset = "0x39EF90", VA = "0x18039FD90")]
		private void Zoom(float delta, [Optional] Vector2? screenAnchor)
		{
		}

		// Token: 0x060013CE RID: 5070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013CE")]
		[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
		public MapEditorZoomControls()
		{
		}

		// Token: 0x0400102B RID: 4139
		[Token(Token = "0x400102B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MapEditorView View;

		// Token: 0x0400102C RID: 4140
		[Token(Token = "0x400102C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GraphicRaycaster Raycaster;

		// Token: 0x0400102D RID: 4141
		[Token(Token = "0x400102D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public EventSystem EventSystem;
	}
}
