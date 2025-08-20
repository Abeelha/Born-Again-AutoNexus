using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000AB RID: 171
[Token(Token = "0x20000AB")]
public class MaterialLibrary : ScriptableObject, ILoadable
{
	// Token: 0x060002F4 RID: 756 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002F4")]
	[Address(RVA = "0x3401C0", Offset = "0x33F3C0", VA = "0x1803401C0", Slot = "4")]
	public void Load()
	{
	}

	// Token: 0x060002F5 RID: 757 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002F5")]
	[Address(RVA = "0x333FD0", Offset = "0x3331D0", VA = "0x180333FD0")]
	public MaterialLibrary()
	{
	}

	// Token: 0x040002D3 RID: 723
	[Token(Token = "0x40002D3")]
	[FieldOffset(Offset = "0x18")]
	public Material BlendMaterial;

	// Token: 0x040002D4 RID: 724
	[Token(Token = "0x40002D4")]
	[FieldOffset(Offset = "0x20")]
	public Material CeilingMaterial;

	// Token: 0x040002D5 RID: 725
	[Token(Token = "0x40002D5")]
	[FieldOffset(Offset = "0x28")]
	public Material DarknessMaterial;

	// Token: 0x040002D6 RID: 726
	[Token(Token = "0x40002D6")]
	[FieldOffset(Offset = "0x30")]
	public Material GroundMaterial;

	// Token: 0x040002D7 RID: 727
	[Token(Token = "0x40002D7")]
	[FieldOffset(Offset = "0x38")]
	public Material Map3dMaterial;

	// Token: 0x040002D8 RID: 728
	[Token(Token = "0x40002D8")]
	[FieldOffset(Offset = "0x40")]
	public Material Map3dGroundMaterial;

	// Token: 0x040002D9 RID: 729
	[Token(Token = "0x40002D9")]
	[FieldOffset(Offset = "0x48")]
	public Material LightMaterial;

	// Token: 0x040002DA RID: 730
	[Token(Token = "0x40002DA")]
	[FieldOffset(Offset = "0x50")]
	public Material LightScreenMaterial;

	// Token: 0x040002DB RID: 731
	[Token(Token = "0x40002DB")]
	[FieldOffset(Offset = "0x58")]
	public RenderTexture DefaultLightTexture;

	// Token: 0x040002DC RID: 732
	[Token(Token = "0x40002DC")]
	[FieldOffset(Offset = "0x60")]
	public Material BackgroundMaterial;

	// Token: 0x040002DD RID: 733
	[Token(Token = "0x40002DD")]
	[FieldOffset(Offset = "0x68")]
	public Material BackgroundDetailsMaterial;

	// Token: 0x040002DE RID: 734
	[Token(Token = "0x40002DE")]
	[FieldOffset(Offset = "0x70")]
	public Material DiscoveryMaterial;

	// Token: 0x040002DF RID: 735
	[Token(Token = "0x40002DF")]
	[FieldOffset(Offset = "0x78")]
	public Material ObjectMaterial;

	// Token: 0x040002E0 RID: 736
	[Token(Token = "0x40002E0")]
	[FieldOffset(Offset = "0x80")]
	public Material ObjectFlatMaterial;

	// Token: 0x040002E1 RID: 737
	[Token(Token = "0x40002E1")]
	[FieldOffset(Offset = "0x88")]
	public Material SilhouetteUIMaterial;

	// Token: 0x040002E2 RID: 738
	[Token(Token = "0x40002E2")]
	[FieldOffset(Offset = "0x90")]
	public Material ObjectUIMaterial;

	// Token: 0x040002E3 RID: 739
	[Token(Token = "0x40002E3")]
	[FieldOffset(Offset = "0x98")]
	public Texture ClearDiscoveryTexture;

	// Token: 0x040002E4 RID: 740
	[Token(Token = "0x40002E4")]
	[FieldOffset(Offset = "0xA0")]
	public bool HdrEnabled;
}
