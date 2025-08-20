using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020002F7 RID: 759
[Token(Token = "0x20002F7")]
public class TooltipBuilder : MonoBehaviour
{
	// Token: 0x170001D8 RID: 472
	// (get) Token: 0x060010D6 RID: 4310 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x170001D8")]
	public Tooltip CurrentTooltip
	{
		[Token(Token = "0x60010D6")]
		[Address(RVA = "0x3615B0", Offset = "0x3607B0", VA = "0x1803615B0")]
		get
		{
			return null;
		}
	}

	// Token: 0x170001D9 RID: 473
	// (get) Token: 0x060010D7 RID: 4311 RVA: 0x00006738 File Offset: 0x00004938
	[Token(Token = "0x170001D9")]
	public float CurrentWidth
	{
		[Token(Token = "0x60010D7")]
		[Address(RVA = "0x3615C0", Offset = "0x3607C0", VA = "0x1803615C0")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x060010D8 RID: 4312 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60010D8")]
	[Address(RVA = "0x35F290", Offset = "0x35E490", VA = "0x18035F290")]
	public Tooltip Build(Vector2 eventScreenPosition, Action<TooltipBuilder> buildAction, TooltipFlags flags = TooltipFlags.None)
	{
		return null;
	}

	// Token: 0x060010D9 RID: 4313 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60010D9")]
	[Address(RVA = "0x35F240", Offset = "0x35E440", VA = "0x18035F240")]
	public TooltipBuilder Background(SpriteLibrary.ScrollBackground background)
	{
		return null;
	}

	// Token: 0x060010DA RID: 4314 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60010DA")]
	[Address(RVA = "0x35F460", Offset = "0x35E660", VA = "0x18035F460")]
	public TooltipBuilder Button(Action<ButtonBuilder> buildAction)
	{
		return null;
	}

	// Token: 0x060010DB RID: 4315 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60010DB")]
	[Address(RVA = "0x35F8F0", Offset = "0x35EAF0", VA = "0x18035F8F0")]
	public TooltipBuilder Column(float widthScalar = 0.5f)
	{
		return null;
	}

	// Token: 0x060010DC RID: 4316 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60010DC")]
	[Address(RVA = "0x35FD00", Offset = "0x35EF00", VA = "0x18035FD00")]
	public TooltipBuilder FitWidth()
	{
		return null;
	}

	// Token: 0x060010DD RID: 4317 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60010DD")]
	[Address(RVA = "0x3603B0", Offset = "0x35F5B0", VA = "0x1803603B0")]
	public TooltipBuilder Indent(float indent)
	{
		return null;
	}

	// Token: 0x060010DE RID: 4318 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60010DE")]
	[Address(RVA = "0x3603C0", Offset = "0x35F5C0", VA = "0x1803603C0")]
	public TooltipBuilder Label(Action<LabelBuilder> buildAction)
	{
		return null;
	}

	// Token: 0x060010DF RID: 4319 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60010DF")]
	[Address(RVA = "0x360550", Offset = "0x35F750", VA = "0x180360550")]
	public TooltipBuilder MoveY(float amount)
	{
		return null;
	}

	// Token: 0x060010E0 RID: 4320 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60010E0")]
	[Address(RVA = "0x360510", Offset = "0x35F710", VA = "0x180360510")]
	public TooltipBuilder MoveMax(Vector2 amount)
	{
		return null;
	}

	// Token: 0x060010E1 RID: 4321 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60010E1")]
	[Address(RVA = "0x360570", Offset = "0x35F770", VA = "0x180360570")]
	public TooltipBuilder NewLine(float spacingScale = 1f)
	{
		return null;
	}

	// Token: 0x060010E2 RID: 4322 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010E2")]
	[Address(RVA = "0x3605C0", Offset = "0x35F7C0", VA = "0x1803605C0")]
	public void Return(Tooltip tooltip)
	{
	}

	// Token: 0x060010E3 RID: 4323 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60010E3")]
	[Address(RVA = "0x360830", Offset = "0x35FA30", VA = "0x180360830")]
	public TooltipBuilder Slot(Action<SlotBuilder> buildAction)
	{
		return null;
	}

	// Token: 0x060010E4 RID: 4324 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60010E4")]
	[Address(RVA = "0x360980", Offset = "0x35FB80", VA = "0x180360980")]
	public TooltipBuilder Space(Vector2 size)
	{
		return null;
	}

	// Token: 0x060010E5 RID: 4325 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60010E5")]
	[Address(RVA = "0x360A00", Offset = "0x35FC00", VA = "0x180360A00")]
	public TooltipBuilder Sprite(Action<SpriteBuilder> buildAction)
	{
		return null;
	}

	// Token: 0x060010E6 RID: 4326 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60010E6")]
	[Address(RVA = "0x360F70", Offset = "0x360170", VA = "0x180360F70")]
	public TooltipBuilder Texture(Action<TextureBuilder> buildAction)
	{
		return null;
	}

	// Token: 0x060010E7 RID: 4327 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60010E7")]
	[Address(RVA = "0x361170", Offset = "0x360370", VA = "0x180361170")]
	public TooltipBuilder Thread(Action<ThreadBuilder> buildAction)
	{
		return null;
	}

	// Token: 0x060010E8 RID: 4328 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60010E8")]
	[Address(RVA = "0x3614C0", Offset = "0x3606C0", VA = "0x1803614C0")]
	public TooltipBuilder Width(float width)
	{
		return null;
	}

	// Token: 0x060010E9 RID: 4329 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010E9")]
	[Address(RVA = "0x35EEF0", Offset = "0x35E0F0", VA = "0x18035EEF0")]
	private void AddElement(ElementBuilder builder)
	{
	}

	// Token: 0x060010EA RID: 4330 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010EA")]
	[Address(RVA = "0x35EFD0", Offset = "0x35E1D0", VA = "0x18035EFD0")]
	private void AdvanceCurrent(Rect rect)
	{
	}

	// Token: 0x060010EB RID: 4331 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010EB")]
	[Address(RVA = "0x35F030", Offset = "0x35E230", VA = "0x18035F030")]
	private void Awake()
	{
	}

	// Token: 0x060010EC RID: 4332 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010EC")]
	[Address(RVA = "0x35F610", Offset = "0x35E810", VA = "0x18035F610")]
	private void Clear(Tooltip tooltip)
	{
	}

	// Token: 0x060010ED RID: 4333 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010ED")]
	[Address(RVA = "0x35F920", Offset = "0x35EB20", VA = "0x18035F920")]
	private void FinishTooltip()
	{
	}

	// Token: 0x060010EE RID: 4334 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60010EE")]
	[Address(RVA = "0x35FD40", Offset = "0x35EF40", VA = "0x18035FD40")]
	private GameObject GetButton()
	{
		return null;
	}

	// Token: 0x060010EF RID: 4335 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60010EF")]
	[Address(RVA = "0x35FE20", Offset = "0x35F020", VA = "0x18035FE20")]
	private GameObject GetLabel()
	{
		return null;
	}

	// Token: 0x060010F0 RID: 4336 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60010F0")]
	[Address(RVA = "0x35FF00", Offset = "0x35F100", VA = "0x18035FF00")]
	private GameObject GetSlot()
	{
		return null;
	}

	// Token: 0x060010F1 RID: 4337 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60010F1")]
	[Address(RVA = "0x35FFE0", Offset = "0x35F1E0", VA = "0x18035FFE0")]
	private GameObject GetSprite()
	{
		return null;
	}

	// Token: 0x060010F2 RID: 4338 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60010F2")]
	[Address(RVA = "0x3600C0", Offset = "0x35F2C0", VA = "0x1803600C0")]
	private GameObject GetTexture()
	{
		return null;
	}

	// Token: 0x060010F3 RID: 4339 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60010F3")]
	[Address(RVA = "0x3601A0", Offset = "0x35F3A0", VA = "0x1803601A0")]
	private GameObject GetThread()
	{
		return null;
	}

	// Token: 0x060010F4 RID: 4340 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60010F4")]
	[Address(RVA = "0x360280", Offset = "0x35F480", VA = "0x180360280")]
	private Tooltip GetTooltip()
	{
		return null;
	}

	// Token: 0x060010F5 RID: 4341 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010F5")]
	[Address(RVA = "0x360620", Offset = "0x35F820", VA = "0x180360620")]
	private void Return(TooltipBuilder.ElementContainer elements)
	{
	}

	// Token: 0x060010F6 RID: 4342 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010F6")]
	[Address(RVA = "0x3606D0", Offset = "0x35F8D0", VA = "0x1803606D0")]
	private void Return(List<GameObject> list, GameObjectPool pool)
	{
	}

	// Token: 0x060010F7 RID: 4343 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010F7")]
	[Address(RVA = "0x360C60", Offset = "0x35FE60", VA = "0x180360C60")]
	private void StartTooltip(Tooltip tooltip)
	{
	}

	// Token: 0x060010F8 RID: 4344 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010F8")]
	[Address(RVA = "0x3613F0", Offset = "0x3605F0", VA = "0x1803613F0")]
	private void UpdateWidth()
	{
	}

	// Token: 0x060010F9 RID: 4345 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010F9")]
	[Address(RVA = "0x3614F0", Offset = "0x3606F0", VA = "0x1803614F0")]
	public TooltipBuilder()
	{
	}

	// Token: 0x04000DEA RID: 3562
	[Token(Token = "0x4000DEA")]
	[FieldOffset(Offset = "0x20")]
	public RectTransform Anchor;

	// Token: 0x04000DEB RID: 3563
	[Token(Token = "0x4000DEB")]
	[FieldOffset(Offset = "0x28")]
	public RectTransform ClampBounds;

	// Token: 0x04000DEC RID: 3564
	[Token(Token = "0x4000DEC")]
	[FieldOffset(Offset = "0x30")]
	public bool Shared;

	// Token: 0x04000DED RID: 3565
	[Token(Token = "0x4000DED")]
	[FieldOffset(Offset = "0x31")]
	public bool ScaleTooltips;

	// Token: 0x04000DEE RID: 3566
	[Token(Token = "0x4000DEE")]
	[FieldOffset(Offset = "0x34")]
	public float TooltipScale;

	// Token: 0x04000DEF RID: 3567
	[Token(Token = "0x4000DEF")]
	[FieldOffset(Offset = "0x38")]
	public float TooltipScaleDelay;

	// Token: 0x04000DF0 RID: 3568
	[Token(Token = "0x4000DF0")]
	[FieldOffset(Offset = "0x40")]
	public GraphicRaycaster Raycaster;

	// Token: 0x04000DF1 RID: 3569
	[Token(Token = "0x4000DF1")]
	[FieldOffset(Offset = "0x48")]
	public GameObject TooltipPrefab;

	// Token: 0x04000DF2 RID: 3570
	[Token(Token = "0x4000DF2")]
	[FieldOffset(Offset = "0x50")]
	public GameObject LabelPrefab;

	// Token: 0x04000DF3 RID: 3571
	[Token(Token = "0x4000DF3")]
	[FieldOffset(Offset = "0x58")]
	public GameObject SlotPrefab;

	// Token: 0x04000DF4 RID: 3572
	[Token(Token = "0x4000DF4")]
	[FieldOffset(Offset = "0x60")]
	public GameObject SpritePrefab;

	// Token: 0x04000DF5 RID: 3573
	[Token(Token = "0x4000DF5")]
	[FieldOffset(Offset = "0x68")]
	public GameObject TexturePrefab;

	// Token: 0x04000DF6 RID: 3574
	[Token(Token = "0x4000DF6")]
	[FieldOffset(Offset = "0x70")]
	public GameObject ThreadPrefab;

	// Token: 0x04000DF7 RID: 3575
	[Token(Token = "0x4000DF7")]
	[FieldOffset(Offset = "0x78")]
	public GameObject ButtonPrefab;

	// Token: 0x04000DF8 RID: 3576
	[Token(Token = "0x4000DF8")]
	[FieldOffset(Offset = "0x80")]
	public Color GreenColor;

	// Token: 0x04000DF9 RID: 3577
	[Token(Token = "0x4000DF9")]
	[FieldOffset(Offset = "0x90")]
	public Color RedColor;

	// Token: 0x04000DFA RID: 3578
	[Token(Token = "0x4000DFA")]
	[FieldOffset(Offset = "0xA0")]
	public World World;

	// Token: 0x04000DFB RID: 3579
	[Token(Token = "0x4000DFB")]
	[FieldOffset(Offset = "0xA8")]
	public float LineSpacing;

	// Token: 0x04000DFC RID: 3580
	[Token(Token = "0x4000DFC")]
	[FieldOffset(Offset = "0xAC")]
	public float ElementSpacing;

	// Token: 0x04000DFD RID: 3581
	[Token(Token = "0x4000DFD")]
	[FieldOffset(Offset = "0xB0")]
	public TooltipFlags Flags;

	// Token: 0x04000DFE RID: 3582
	[Token(Token = "0x4000DFE")]
	[FieldOffset(Offset = "0xB8")]
	private GameObjectPool _tooltipPool;

	// Token: 0x04000DFF RID: 3583
	[Token(Token = "0x4000DFF")]
	[FieldOffset(Offset = "0xC0")]
	private GameObjectPool _labelPool;

	// Token: 0x04000E00 RID: 3584
	[Token(Token = "0x4000E00")]
	[FieldOffset(Offset = "0xC8")]
	private GameObjectPool _slotPool;

	// Token: 0x04000E01 RID: 3585
	[Token(Token = "0x4000E01")]
	[FieldOffset(Offset = "0xD0")]
	private GameObjectPool _spritePool;

	// Token: 0x04000E02 RID: 3586
	[Token(Token = "0x4000E02")]
	[FieldOffset(Offset = "0xD8")]
	private GameObjectPool _texturePool;

	// Token: 0x04000E03 RID: 3587
	[Token(Token = "0x4000E03")]
	[FieldOffset(Offset = "0xE0")]
	private GameObjectPool _threadPool;

	// Token: 0x04000E04 RID: 3588
	[Token(Token = "0x4000E04")]
	[FieldOffset(Offset = "0xE8")]
	private GameObjectPool _buttonPool;

	// Token: 0x04000E05 RID: 3589
	[Token(Token = "0x4000E05")]
	[FieldOffset(Offset = "0xF0")]
	private Tooltip _currentTooltip;

	// Token: 0x04000E06 RID: 3590
	[Token(Token = "0x4000E06")]
	[FieldOffset(Offset = "0xF8")]
	private TooltipBuilder.ElementContainer _currentContainer;

	// Token: 0x04000E07 RID: 3591
	[Token(Token = "0x4000E07")]
	[FieldOffset(Offset = "0x100")]
	private Vector2 _currentPosition;

	// Token: 0x04000E08 RID: 3592
	[Token(Token = "0x4000E08")]
	[FieldOffset(Offset = "0x108")]
	private Vector2 _currentMaxPosition;

	// Token: 0x04000E09 RID: 3593
	[Token(Token = "0x4000E09")]
	[FieldOffset(Offset = "0x110")]
	private float _currentWidth;

	// Token: 0x04000E0A RID: 3594
	[Token(Token = "0x4000E0A")]
	[FieldOffset(Offset = "0x114")]
	private float _currentIndent;

	// Token: 0x04000E0B RID: 3595
	[Token(Token = "0x4000E0B")]
	[FieldOffset(Offset = "0x118")]
	private Vector2 _eventScreenPosition;

	// Token: 0x04000E0C RID: 3596
	[Token(Token = "0x4000E0C")]
	[FieldOffset(Offset = "0x120")]
	private readonly Dictionary<Tooltip, TooltipBuilder.ElementContainer> _elementsInUse;

	// Token: 0x020002F8 RID: 760
	[Token(Token = "0x20002F8")]
	private class ElementContainer
	{
		// Token: 0x060010FA RID: 4346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010FA")]
		[Address(RVA = "0x34E590", Offset = "0x34D790", VA = "0x18034E590")]
		public ElementContainer()
		{
		}

		// Token: 0x04000E0D RID: 3597
		[Token(Token = "0x4000E0D")]
		[FieldOffset(Offset = "0x10")]
		public readonly List<GameObject> Labels;

		// Token: 0x04000E0E RID: 3598
		[Token(Token = "0x4000E0E")]
		[FieldOffset(Offset = "0x18")]
		public readonly List<GameObject> Slots;

		// Token: 0x04000E0F RID: 3599
		[Token(Token = "0x4000E0F")]
		[FieldOffset(Offset = "0x20")]
		public readonly List<GameObject> Sprites;

		// Token: 0x04000E10 RID: 3600
		[Token(Token = "0x4000E10")]
		[FieldOffset(Offset = "0x28")]
		public readonly List<GameObject> Textures;

		// Token: 0x04000E11 RID: 3601
		[Token(Token = "0x4000E11")]
		[FieldOffset(Offset = "0x30")]
		public readonly List<GameObject> Thread;

		// Token: 0x04000E12 RID: 3602
		[Token(Token = "0x4000E12")]
		[FieldOffset(Offset = "0x38")]
		public readonly List<GameObject> Buttons;
	}
}
