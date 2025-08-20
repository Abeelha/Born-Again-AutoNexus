using System;
using System.Collections.Generic;
using System.Threading;
using Il2CppDummyDll;
using Ronin.Model.Definitions;
using Ronin.Model.Enums;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000261 RID: 609
[Token(Token = "0x2000261")]
public class TutorialNotificationManager : MonoBehaviour
{
	// Token: 0x17000118 RID: 280
	// (get) Token: 0x06000B7E RID: 2942 RVA: 0x00004E60 File Offset: 0x00003060
	[Token(Token = "0x17000118")]
	public bool Active
	{
		[Token(Token = "0x6000B7E")]
		[Address(RVA = "0x351160", Offset = "0x350360", VA = "0x180351160")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000119 RID: 281
	// (get) Token: 0x06000B7F RID: 2943 RVA: 0x00004E78 File Offset: 0x00003078
	[Token(Token = "0x17000119")]
	public bool TutorialShown
	{
		[Token(Token = "0x6000B7F")]
		[Address(RVA = "0x441EE0", Offset = "0x4410E0", VA = "0x180441EE0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700011A RID: 282
	// (get) Token: 0x06000B80 RID: 2944 RVA: 0x00004E90 File Offset: 0x00003090
	[Token(Token = "0x1700011A")]
	public bool StopPlayer
	{
		[Token(Token = "0x6000B80")]
		[Address(RVA = "0x441DC0", Offset = "0x440FC0", VA = "0x180441DC0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700011B RID: 283
	// (get) Token: 0x06000B81 RID: 2945 RVA: 0x00004EA8 File Offset: 0x000030A8
	[Token(Token = "0x1700011B")]
	public bool HideUI
	{
		[Token(Token = "0x6000B81")]
		[Address(RVA = "0x441CE0", Offset = "0x440EE0", VA = "0x180441CE0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000B82 RID: 2946 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B82")]
	[Address(RVA = "0x440590", Offset = "0x43F790", VA = "0x180440590")]
	public void Continue()
	{
	}

	// Token: 0x06000B83 RID: 2947 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B83")]
	[Address(RVA = "0x440C00", Offset = "0x43FE00", VA = "0x180440C00")]
	public void LanguageChanged()
	{
	}

	// Token: 0x06000B84 RID: 2948 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B84")]
	[Address(RVA = "0x441430", Offset = "0x440630", VA = "0x180441430")]
	public void NewWorld(MapFlags flags)
	{
	}

	// Token: 0x06000B85 RID: 2949 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000B85")]
	[Address(RVA = "0x440EE0", Offset = "0x4400E0", VA = "0x180440EE0")]
	private static string LocalizeMessage(string key)
	{
		return null;
	}

	// Token: 0x06000B86 RID: 2950 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000B86")]
	[Address(RVA = "0x440990", Offset = "0x43FB90", VA = "0x180440990")]
	private static string GetHighlighted(string value)
	{
		return null;
	}

	// Token: 0x06000B87 RID: 2951 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B87")]
	[Address(RVA = "0x4403F0", Offset = "0x43F5F0", VA = "0x1804403F0")]
	private void Awake()
	{
	}

	// Token: 0x06000B88 RID: 2952 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000B88")]
	[Address(RVA = "0x440680", Offset = "0x43F880", VA = "0x180440680")]
	private TutorialDefinition GetClosestTutorial()
	{
		return null;
	}

	// Token: 0x06000B89 RID: 2953 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B89")]
	[Address(RVA = "0x4409E0", Offset = "0x43FBE0", VA = "0x1804409E0")]
	private void HideTutorial()
	{
	}

	// Token: 0x06000B8A RID: 2954 RVA: 0x00004EC0 File Offset: 0x000030C0
	[Token(Token = "0x6000B8A")]
	[Address(RVA = "0x440B80", Offset = "0x43FD80", VA = "0x180440B80")]
	private bool IsDead()
	{
		return default(bool);
	}

	// Token: 0x06000B8B RID: 2955 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B8B")]
	[Address(RVA = "0x440C10", Offset = "0x43FE10", VA = "0x180440C10")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000B8C RID: 2956 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B8C")]
	[Address(RVA = "0x4414C0", Offset = "0x4406C0", VA = "0x1804414C0")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000B8D RID: 2957 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B8D")]
	[Address(RVA = "0x441500", Offset = "0x440700", VA = "0x180441500")]
	private void OnDisable()
	{
	}

	// Token: 0x06000B8E RID: 2958 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B8E")]
	[Address(RVA = "0x441590", Offset = "0x440790", VA = "0x180441590")]
	private void SetTutorial(ushort type)
	{
	}

	// Token: 0x06000B8F RID: 2959 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B8F")]
	[Address(RVA = "0x441600", Offset = "0x440800", VA = "0x180441600")]
	private void SetTutorial(TutorialDefinition tutorial)
	{
	}

	// Token: 0x06000B90 RID: 2960 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B90")]
	[Address(RVA = "0x441B10", Offset = "0x440D10", VA = "0x180441B10")]
	private void Update()
	{
	}

	// Token: 0x06000B91 RID: 2961 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B91")]
	[Address(RVA = "0x4419E0", Offset = "0x440BE0", VA = "0x1804419E0")]
	private void UpdateText()
	{
	}

	// Token: 0x06000B92 RID: 2962 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B92")]
	[Address(RVA = "0x441C60", Offset = "0x440E60", VA = "0x180441C60")]
	public TutorialNotificationManager()
	{
	}

	// Token: 0x04000A2C RID: 2604
	[Token(Token = "0x4000A2C")]
	private const float FadeDuration = 0.4f;

	// Token: 0x04000A2D RID: 2605
	[Token(Token = "0x4000A2D")]
	[FieldOffset(Offset = "0x20")]
	public Image Icon;

	// Token: 0x04000A2E RID: 2606
	[Token(Token = "0x4000A2E")]
	[FieldOffset(Offset = "0x28")]
	public TMP_Text Title;

	// Token: 0x04000A2F RID: 2607
	[Token(Token = "0x4000A2F")]
	[FieldOffset(Offset = "0x30")]
	public TMP_Text Message;

	// Token: 0x04000A30 RID: 2608
	[Token(Token = "0x4000A30")]
	[FieldOffset(Offset = "0x38")]
	public Image Gradient;

	// Token: 0x04000A31 RID: 2609
	[Token(Token = "0x4000A31")]
	[FieldOffset(Offset = "0x40")]
	public World World;

	// Token: 0x04000A32 RID: 2610
	[Token(Token = "0x4000A32")]
	[FieldOffset(Offset = "0x48")]
	public RectTransform Button;

	// Token: 0x04000A33 RID: 2611
	[Token(Token = "0x4000A33")]
	[FieldOffset(Offset = "0x50")]
	public TutorialUIStepper TutorialUIStepper;

	// Token: 0x04000A34 RID: 2612
	[Token(Token = "0x4000A34")]
	[FieldOffset(Offset = "0x58")]
	public PickupSlotContainer PickupSlotContainer;

	// Token: 0x04000A35 RID: 2613
	[Token(Token = "0x4000A35")]
	[FieldOffset(Offset = "0x60")]
	private TutorialDefinition _closedTutorial;

	// Token: 0x04000A36 RID: 2614
	[Token(Token = "0x4000A36")]
	[FieldOffset(Offset = "0x68")]
	private TutorialDefinition _syncedTutorialDefinition;

	// Token: 0x04000A37 RID: 2615
	[Token(Token = "0x4000A37")]
	[FieldOffset(Offset = "0x70")]
	private Graphic[] _graphics;

	// Token: 0x04000A38 RID: 2616
	[Token(Token = "0x4000A38")]
	[FieldOffset(Offset = "0x78")]
	private float _gradientAlpha;

	// Token: 0x04000A39 RID: 2617
	[Token(Token = "0x4000A39")]
	[FieldOffset(Offset = "0x7C")]
	private bool _last;

	// Token: 0x04000A3A RID: 2618
	[Token(Token = "0x4000A3A")]
	[FieldOffset(Offset = "0x7D")]
	private bool _closing;

	// Token: 0x04000A3B RID: 2619
	[Token(Token = "0x4000A3B")]
	[FieldOffset(Offset = "0x80")]
	private readonly HashSet<ushort> _completed;

	// Token: 0x04000A3C RID: 2620
	[Token(Token = "0x4000A3C")]
	[FieldOffset(Offset = "0x88")]
	private Option _interactOption;

	// Token: 0x04000A3D RID: 2621
	[Token(Token = "0x4000A3D")]
	[FieldOffset(Offset = "0x90")]
	private CancellationTokenSource _currentFadeSource;
}
