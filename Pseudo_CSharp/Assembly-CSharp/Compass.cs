using System;
using System.Threading.Tasks;
using AnimateInternal;
using Il2CppDummyDll;
using Ronin.Model.Definitions;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020002A1 RID: 673
[Token(Token = "0x20002A1")]
public class Compass : MonoBehaviour
{
	// Token: 0x06000E6D RID: 3693 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E6D")]
	[Address(RVA = "0x4640C0", Offset = "0x4632C0", VA = "0x1804640C0")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000E6E RID: 3694 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E6E")]
	[Address(RVA = "0x4648D0", Offset = "0x463AD0", VA = "0x1804648D0")]
	private void UpdateEntity()
	{
	}

	// Token: 0x06000E6F RID: 3695 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E6F")]
	[Address(RVA = "0x4641F0", Offset = "0x4633F0", VA = "0x1804641F0")]
	private void Scale(bool fromZero)
	{
	}

	// Token: 0x06000E70 RID: 3696 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000E70")]
	[Address(RVA = "0x464120", Offset = "0x463320", VA = "0x180464120")]
	private Task ScaleRemindAsync()
	{
		return null;
	}

	// Token: 0x06000E71 RID: 3697 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E71")]
	[Address(RVA = "0x4643E0", Offset = "0x4635E0", VA = "0x1804643E0")]
	private void UpdateCompass()
	{
	}

	// Token: 0x06000E72 RID: 3698 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E72")]
	[Address(RVA = "0x464AE0", Offset = "0x463CE0", VA = "0x180464AE0")]
	public Compass()
	{
	}

	// Token: 0x04000BB1 RID: 2993
	[Token(Token = "0x4000BB1")]
	[FieldOffset(Offset = "0x20")]
	public Image PortraitImage;

	// Token: 0x04000BB2 RID: 2994
	[Token(Token = "0x4000BB2")]
	[FieldOffset(Offset = "0x28")]
	public Image PortraitBorder;

	// Token: 0x04000BB3 RID: 2995
	[Token(Token = "0x4000BB3")]
	[FieldOffset(Offset = "0x30")]
	public RectTransform CompassMain;

	// Token: 0x04000BB4 RID: 2996
	[Token(Token = "0x4000BB4")]
	[FieldOffset(Offset = "0x38")]
	public RectTransform CompassNeedle;

	// Token: 0x04000BB5 RID: 2997
	[Token(Token = "0x4000BB5")]
	[FieldOffset(Offset = "0x40")]
	public World World;

	// Token: 0x04000BB6 RID: 2998
	[Token(Token = "0x4000BB6")]
	[FieldOffset(Offset = "0x48")]
	public float CompassDistance;

	// Token: 0x04000BB7 RID: 2999
	[Token(Token = "0x4000BB7")]
	[FieldOffset(Offset = "0x4C")]
	public float RemindCooldown;

	// Token: 0x04000BB8 RID: 3000
	[Token(Token = "0x4000BB8")]
	[FieldOffset(Offset = "0x50")]
	public uint EntityId;

	// Token: 0x04000BB9 RID: 3001
	[Token(Token = "0x4000BB9")]
	[FieldOffset(Offset = "0x58")]
	public Sprite BossBorder;

	// Token: 0x04000BBA RID: 3002
	[Token(Token = "0x4000BBA")]
	[FieldOffset(Offset = "0x60")]
	public Sprite NormalBorder;

	// Token: 0x04000BBB RID: 3003
	[Token(Token = "0x4000BBB")]
	[FieldOffset(Offset = "0x68")]
	private Entity _entity;

	// Token: 0x04000BBC RID: 3004
	[Token(Token = "0x4000BBC")]
	[FieldOffset(Offset = "0x70")]
	private ObjectDefinition _definition;

	// Token: 0x04000BBD RID: 3005
	[Token(Token = "0x4000BBD")]
	[FieldOffset(Offset = "0x78")]
	private uint _entityId;

	// Token: 0x04000BBE RID: 3006
	[Token(Token = "0x4000BBE")]
	[FieldOffset(Offset = "0x80")]
	private AnimateTask _scaleTask;

	// Token: 0x04000BBF RID: 3007
	[Token(Token = "0x4000BBF")]
	[FieldOffset(Offset = "0x88")]
	private float _scaleCooldown;
}
