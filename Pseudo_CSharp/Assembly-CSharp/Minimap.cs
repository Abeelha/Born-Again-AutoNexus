using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x020002CD RID: 717
[Token(Token = "0x20002CD")]
public class Minimap : MonoBehaviour, IDragHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler
{
	// Token: 0x170001B8 RID: 440
	// (get) Token: 0x06000F67 RID: 3943 RVA: 0x000061B0 File Offset: 0x000043B0
	[Token(Token = "0x170001B8")]
	protected float ContainerScale
	{
		[Token(Token = "0x6000F67")]
		[Address(RVA = "0x4720F0", Offset = "0x4712F0", VA = "0x1804720F0")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x170001B9 RID: 441
	// (get) Token: 0x06000F68 RID: 3944 RVA: 0x000061C8 File Offset: 0x000043C8
	[Token(Token = "0x170001B9")]
	protected float ElementScale
	{
		[Token(Token = "0x6000F68")]
		[Address(RVA = "0x472120", Offset = "0x471320", VA = "0x180472120")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x170001BA RID: 442
	// (get) Token: 0x06000F69 RID: 3945 RVA: 0x000061E0 File Offset: 0x000043E0
	[Token(Token = "0x170001BA")]
	protected Vector2 Focus
	{
		[Token(Token = "0x6000F69")]
		[Address(RVA = "0x472160", Offset = "0x471360", VA = "0x180472160")]
		get
		{
			return default(Vector2);
		}
	}

	// Token: 0x170001BB RID: 443
	// (get) Token: 0x06000F6A RID: 3946 RVA: 0x000061F8 File Offset: 0x000043F8
	[Token(Token = "0x170001BB")]
	protected float Size
	{
		[Token(Token = "0x6000F6A")]
		[Address(RVA = "0x3423C0", Offset = "0x3415C0", VA = "0x1803423C0")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x06000F6B RID: 3947 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F6B")]
	[Address(RVA = "0x470BB0", Offset = "0x46FDB0", VA = "0x180470BB0")]
	public void NewWorld()
	{
	}

	// Token: 0x06000F6C RID: 3948 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F6C")]
	[Address(RVA = "0x470C90", Offset = "0x46FE90", VA = "0x180470C90", Slot = "5")]
	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	// Token: 0x06000F6D RID: 3949 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F6D")]
	[Address(RVA = "0x470E10", Offset = "0x470010", VA = "0x180470E10", Slot = "4")]
	public void OnDrag(PointerEventData eventData)
	{
	}

	// Token: 0x06000F6E RID: 3950 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F6E")]
	[Address(RVA = "0x471080", Offset = "0x470280", VA = "0x180471080", Slot = "6")]
	public void OnEndDrag(PointerEventData eventData)
	{
	}

	// Token: 0x06000F6F RID: 3951 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F6F")]
	[Address(RVA = "0x4710E0", Offset = "0x4702E0", VA = "0x1804710E0")]
	public void SetFocus(Vector2 focus)
	{
	}

	// Token: 0x06000F70 RID: 3952 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F70")]
	[Address(RVA = "0x471F70", Offset = "0x471170", VA = "0x180471F70")]
	public void ZoomIn()
	{
	}

	// Token: 0x06000F71 RID: 3953 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F71")]
	[Address(RVA = "0x471FA0", Offset = "0x4711A0", VA = "0x180471FA0")]
	public void ZoomOut()
	{
	}

	// Token: 0x06000F72 RID: 3954 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F72")]
	[Address(RVA = "0x4703F0", Offset = "0x46F5F0", VA = "0x1804703F0", Slot = "7")]
	protected virtual void Awake()
	{
	}

	// Token: 0x06000F73 RID: 3955 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F73")]
	[Address(RVA = "0x470AA0", Offset = "0x46FCA0", VA = "0x180470AA0", Slot = "8")]
	protected virtual void LateUpdate()
	{
	}

	// Token: 0x06000F74 RID: 3956 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F74")]
	[Address(RVA = "0x470D40", Offset = "0x46FF40", VA = "0x180470D40", Slot = "9")]
	protected virtual void OnDisable()
	{
	}

	// Token: 0x06000F75 RID: 3957 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F75")]
	[Address(RVA = "0x471120", Offset = "0x470320", VA = "0x180471120")]
	protected void SetUV(Vector2 focus, float size)
	{
	}

	// Token: 0x06000F76 RID: 3958 RVA: 0x00006210 File Offset: 0x00004410
	[Token(Token = "0x6000F76")]
	[Address(RVA = "0x4704A0", Offset = "0x46F6A0", VA = "0x1804704A0")]
	private bool CanScrollMinimap()
	{
		return default(bool);
	}

	// Token: 0x06000F77 RID: 3959 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F77")]
	[Address(RVA = "0x470790", Offset = "0x46F990", VA = "0x180470790")]
	private void CheckScroll()
	{
	}

	// Token: 0x06000F78 RID: 3960 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F78")]
	[Address(RVA = "0x4708C0", Offset = "0x46FAC0", VA = "0x1804708C0")]
	private void CheckZoomKeys()
	{
	}

	// Token: 0x06000F79 RID: 3961 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F79")]
	[Address(RVA = "0x4707F0", Offset = "0x46F9F0", VA = "0x1804707F0")]
	private void CheckZoomKeysHeld()
	{
	}

	// Token: 0x06000F7A RID: 3962 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F7A")]
	[Address(RVA = "0x470980", Offset = "0x46FB80", VA = "0x180470980")]
	private void FixedUpdate()
	{
	}

	// Token: 0x06000F7B RID: 3963 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F7B")]
	[Address(RVA = "0x471840", Offset = "0x470A40", VA = "0x180471840")]
	private void UpdateContainer()
	{
	}

	// Token: 0x06000F7C RID: 3964 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F7C")]
	[Address(RVA = "0x4719F0", Offset = "0x470BF0", VA = "0x1804719F0")]
	private void UpdateLabels()
	{
	}

	// Token: 0x06000F7D RID: 3965 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F7D")]
	[Address(RVA = "0x471F10", Offset = "0x471110", VA = "0x180471F10")]
	private void UpdateScroll()
	{
	}

	// Token: 0x06000F7E RID: 3966 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F7E")]
	[Address(RVA = "0x471FD0", Offset = "0x4711D0", VA = "0x180471FD0")]
	public Minimap()
	{
	}

	// Token: 0x06000F7F RID: 3967 RVA: 0x00006228 File Offset: 0x00004428
	[Token(Token = "0x6000F7F")]
	[Address(RVA = "0x4716A0", Offset = "0x4708A0", VA = "0x1804716A0")]
	[CompilerGenerated]
	private Vector2 <OnDrag>g__getMidPoint|30_0()
	{
		return default(Vector2);
	}

	// Token: 0x06000F80 RID: 3968 RVA: 0x00006240 File Offset: 0x00004440
	[Token(Token = "0x6000F80")]
	[Address(RVA = "0x4715D0", Offset = "0x4707D0", VA = "0x1804715D0")]
	[CompilerGenerated]
	private Vector2 <OnDrag>g__getDragVector|30_1()
	{
		return default(Vector2);
	}

	// Token: 0x04000CBD RID: 3261
	[Token(Token = "0x4000CBD")]
	[FieldOffset(Offset = "0x20")]
	public World World;

	// Token: 0x04000CBE RID: 3262
	[Token(Token = "0x4000CBE")]
	[FieldOffset(Offset = "0x28")]
	public RawImage TextureImage;

	// Token: 0x04000CBF RID: 3263
	[Token(Token = "0x4000CBF")]
	[FieldOffset(Offset = "0x30")]
	public MinimapTexture MapTexture;

	// Token: 0x04000CC0 RID: 3264
	[Token(Token = "0x4000CC0")]
	[FieldOffset(Offset = "0x38")]
	public GraphicRaycaster Raycaster;

	// Token: 0x04000CC1 RID: 3265
	[Token(Token = "0x4000CC1")]
	[FieldOffset(Offset = "0x40")]
	public int DefaultMapSize;

	// Token: 0x04000CC2 RID: 3266
	[Token(Token = "0x4000CC2")]
	[FieldOffset(Offset = "0x44")]
	public float ZoomScalar;

	// Token: 0x04000CC3 RID: 3267
	[Token(Token = "0x4000CC3")]
	[FieldOffset(Offset = "0x48")]
	public float MinSize;

	// Token: 0x04000CC4 RID: 3268
	[Token(Token = "0x4000CC4")]
	[FieldOffset(Offset = "0x50")]
	public RectTransform MapElementContainer;

	// Token: 0x04000CC5 RID: 3269
	[Token(Token = "0x4000CC5")]
	[FieldOffset(Offset = "0x58")]
	public TextMeshProUGUI LabelPrefab;

	// Token: 0x04000CC6 RID: 3270
	[Token(Token = "0x4000CC6")]
	[FieldOffset(Offset = "0x60")]
	private readonly List<TextMeshProUGUI> _labels;

	// Token: 0x04000CC7 RID: 3271
	[Token(Token = "0x4000CC7")]
	[FieldOffset(Offset = "0x68")]
	private readonly List<RaycastResult> _raycastResults;

	// Token: 0x04000CC8 RID: 3272
	[Token(Token = "0x4000CC8")]
	[FieldOffset(Offset = "0x70")]
	private float _size;

	// Token: 0x04000CC9 RID: 3273
	[Token(Token = "0x4000CC9")]
	[FieldOffset(Offset = "0x74")]
	private Vector2 _focus;

	// Token: 0x04000CCA RID: 3274
	[Token(Token = "0x4000CCA")]
	[FieldOffset(Offset = "0x7C")]
	private float _scroll;

	// Token: 0x04000CCB RID: 3275
	[Token(Token = "0x4000CCB")]
	[FieldOffset(Offset = "0x80")]
	private Option _zoomIn;

	// Token: 0x04000CCC RID: 3276
	[Token(Token = "0x4000CCC")]
	[FieldOffset(Offset = "0x88")]
	private Option _zoomOut;

	// Token: 0x04000CCD RID: 3277
	[Token(Token = "0x4000CCD")]
	[FieldOffset(Offset = "0x90")]
	private float _zoomInStartedAt;

	// Token: 0x04000CCE RID: 3278
	[Token(Token = "0x4000CCE")]
	[FieldOffset(Offset = "0x94")]
	private float _zoomOutStartedAt;

	// Token: 0x04000CCF RID: 3279
	[Token(Token = "0x4000CCF")]
	[FieldOffset(Offset = "0x98")]
	private Vector2 _offset;

	// Token: 0x04000CD0 RID: 3280
	[Token(Token = "0x4000CD0")]
	[FieldOffset(Offset = "0xA0")]
	private readonly Dictionary<int, Vector2> _pointers;
}
