using System;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200010B RID: 267
[Token(Token = "0x200010B")]
public abstract class GalleryMenu : Menu
{
	// Token: 0x06000482 RID: 1154 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000482")]
	[Address(RVA = "0x316090", Offset = "0x315290", VA = "0x180316090", Slot = "9")]
	public virtual void Back()
	{
	}

	// Token: 0x06000483 RID: 1155 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000483")]
	[Address(RVA = "0x316090", Offset = "0x315290", VA = "0x180316090", Slot = "10")]
	public virtual void Select()
	{
	}

	// Token: 0x06000484 RID: 1156 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000484")]
	protected T CreateGalleryItem<T>(T behaviour) where T : MonoBehaviour
	{
		return null;
	}

	// Token: 0x06000485 RID: 1157
	[Token(Token = "0x6000485")]
	protected abstract void LoadItems();

	// Token: 0x06000486 RID: 1158 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000486")]
	[Address(RVA = "0x3D4AE0", Offset = "0x3D3CE0", VA = "0x1803D4AE0", Slot = "5")]
	protected override void OnEnter()
	{
	}

	// Token: 0x06000487 RID: 1159 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000487")]
	[Address(RVA = "0x3D4B00", Offset = "0x3D3D00", VA = "0x1803D4B00", Slot = "7")]
	protected override void Start()
	{
	}

	// Token: 0x06000488 RID: 1160 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000488")]
	[Address(RVA = "0x3D4B70", Offset = "0x3D3D70", VA = "0x1803D4B70")]
	protected void Sync()
	{
	}

	// Token: 0x06000489 RID: 1161 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000489")]
	[Address(RVA = "0x3D4F40", Offset = "0x3D4140", VA = "0x1803D4F40", Slot = "8")]
	protected override void Update()
	{
	}

	// Token: 0x0600048A RID: 1162 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600048A")]
	[Address(RVA = "0x3D4CD0", Offset = "0x3D3ED0", VA = "0x1803D4CD0")]
	private void UpdateControllerInput()
	{
	}

	// Token: 0x0600048B RID: 1163 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600048B")]
	[Address(RVA = "0x3D4DE0", Offset = "0x3D3FE0", VA = "0x1803D4DE0")]
	private void UpdateKeyboardInput()
	{
	}

	// Token: 0x0600048C RID: 1164 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600048C")]
	[Address(RVA = "0x3BC980", Offset = "0x3BBB80", VA = "0x1803BC980")]
	protected GalleryMenu()
	{
	}

	// Token: 0x040004D6 RID: 1238
	[Token(Token = "0x40004D6")]
	[FieldOffset(Offset = "0x90")]
	public GameObjectGallery Gallery;

	// Token: 0x040004D7 RID: 1239
	[Token(Token = "0x40004D7")]
	[FieldOffset(Offset = "0x98")]
	public RectTransform GalleryContent;

	// Token: 0x040004D8 RID: 1240
	[Token(Token = "0x40004D8")]
	[FieldOffset(Offset = "0xA0")]
	protected Task LoadTask;

	// Token: 0x040004D9 RID: 1241
	[Token(Token = "0x40004D9")]
	[FieldOffset(Offset = "0xA8")]
	private ControllerNavigation _controllerNavigation;

	// Token: 0x040004DA RID: 1242
	[Token(Token = "0x40004DA")]
	[FieldOffset(Offset = "0xC0")]
	private Option _interact;
}
