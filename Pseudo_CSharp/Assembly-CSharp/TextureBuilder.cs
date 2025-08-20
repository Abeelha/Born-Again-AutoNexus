using System;
using Il2CppDummyDll;
using Ronin.Model.Classes;
using Ronin.Model.Definitions;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020002F5 RID: 757
[Token(Token = "0x20002F5")]
public class TextureBuilder : ElementBuilder
{
	// Token: 0x060010C5 RID: 4293 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010C5")]
	[Address(RVA = "0x35E990", Offset = "0x35DB90", VA = "0x18035E990")]
	public TextureBuilder(GameObject gameObject)
	{
	}

	// Token: 0x060010C6 RID: 4294 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60010C6")]
	[Address(RVA = "0x35E6B0", Offset = "0x35D8B0", VA = "0x18035E6B0")]
	public TextureBuilder Dead(bool dead)
	{
		return null;
	}

	// Token: 0x060010C7 RID: 4295 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60010C7")]
	[Address(RVA = "0x3505F0", Offset = "0x34F7F0", VA = "0x1803505F0")]
	public TextureBuilder Offset(Vector2 offset)
	{
		return null;
	}

	// Token: 0x060010C8 RID: 4296 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60010C8")]
	[Address(RVA = "0x35E6E0", Offset = "0x35D8E0", VA = "0x18035E6E0")]
	public TextureBuilder OffsetByTextureSize(Vector2 scalar)
	{
		return null;
	}

	// Token: 0x060010C9 RID: 4297 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60010C9")]
	[Address(RVA = "0x35E760", Offset = "0x35D960", VA = "0x18035E760")]
	public TextureBuilder Pivot(Vector2 pivot)
	{
		return null;
	}

	// Token: 0x060010CA RID: 4298 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60010CA")]
	[Address(RVA = "0x357C80", Offset = "0x356E80", VA = "0x180357C80")]
	public TextureBuilder Scale(Vector2 scale)
	{
		return null;
	}

	// Token: 0x060010CB RID: 4299 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60010CB")]
	[Address(RVA = "0x35E8B0", Offset = "0x35DAB0", VA = "0x18035E8B0")]
	public TextureBuilder Texture(AttackDescriptor attackDescriptor)
	{
		return null;
	}

	// Token: 0x060010CC RID: 4300 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60010CC")]
	[Address(RVA = "0x35E920", Offset = "0x35DB20", VA = "0x18035E920")]
	public TextureBuilder Texture(ObjectDefinition definition)
	{
		return null;
	}

	// Token: 0x060010CD RID: 4301 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60010CD")]
	[Address(RVA = "0x35E850", Offset = "0x35DA50", VA = "0x18035E850")]
	public TextureBuilder Texture(string texture)
	{
		return null;
	}

	// Token: 0x060010CE RID: 4302 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010CE")]
	[Address(RVA = "0x35E7B0", Offset = "0x35D9B0", VA = "0x18035E7B0", Slot = "6")]
	protected override void SetPosition(Vector2 position)
	{
	}

	// Token: 0x04000DE6 RID: 3558
	[Token(Token = "0x4000DE6")]
	[FieldOffset(Offset = "0x28")]
	private readonly AnimationRunner _animationRunner;

	// Token: 0x04000DE7 RID: 3559
	[Token(Token = "0x4000DE7")]
	[FieldOffset(Offset = "0x30")]
	private readonly Image _image;
}
