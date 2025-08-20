using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using AnimateInternal;
using Il2CppDummyDll;
using Ronin.Api.Model.CharacterSlot;
using Ronin.Model.Data;
using Ronin.Model.Simulation;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnnamedStudios;

// Token: 0x020002AC RID: 684
[Token(Token = "0x20002AC")]
public class DeathScreen : MonoBehaviour
{
	// Token: 0x06000EAD RID: 3757 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EAD")]
	[Address(RVA = "0x469710", Offset = "0x468910", VA = "0x180469710")]
	public void Continue()
	{
	}

	// Token: 0x06000EAE RID: 3758 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EAE")]
	[Address(RVA = "0x3999A0", Offset = "0x398BA0", VA = "0x1803999A0")]
	public void Menu()
	{
	}

	// Token: 0x06000EAF RID: 3759 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EAF")]
	[Address(RVA = "0x46A430", Offset = "0x469630", VA = "0x18046A430")]
	public void NewCharacter()
	{
	}

	// Token: 0x06000EB0 RID: 3760 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EB0")]
	[Address(RVA = "0x46A740", Offset = "0x469940", VA = "0x18046A740")]
	public void Show(ref DeathData deathData, Simulation simulation)
	{
	}

	// Token: 0x06000EB1 RID: 3761 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000EB1")]
	[Address(RVA = "0x46A010", Offset = "0x469210", VA = "0x18046A010")]
	private static string GetRandomNote()
	{
		return null;
	}

	// Token: 0x06000EB2 RID: 3762 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EB2")]
	[Address(RVA = "0x4694C0", Offset = "0x4686C0", VA = "0x1804694C0")]
	private void Awake()
	{
	}

	// Token: 0x06000EB3 RID: 3763 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000EB3")]
	[Address(RVA = "0x469610", Offset = "0x468810", VA = "0x180469610")]
	private Task ContinueLineageAsync(GetCharacterSlotResponse characterSlot)
	{
		return null;
	}

	// Token: 0x06000EB4 RID: 3764 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000EB4")]
	[Address(RVA = "0x469A80", Offset = "0x468C80", VA = "0x180469A80")]
	private DurationTask ExpandScrollTo(RectTransform rectTransform, int spacing = 0)
	{
		return null;
	}

	// Token: 0x06000EB5 RID: 3765 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000EB5")]
	[Address(RVA = "0x469950", Offset = "0x468B50", VA = "0x180469950")]
	private Task ExpandScrollToAsync(RectTransform rectTransform, CancellationToken cancellationToken, int spacing = 0)
	{
		return null;
	}

	// Token: 0x06000EB6 RID: 3766 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000EB6")]
	[Address(RVA = "0x469BC0", Offset = "0x468DC0", VA = "0x180469BC0")]
	private CharacterImage GetCharacterImage()
	{
		return null;
	}

	// Token: 0x06000EB7 RID: 3767 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000EB7")]
	[Address(RVA = "0x469C70", Offset = "0x468E70", VA = "0x180469C70")]
	private TextMeshProUGUI GetLabel(string text, float fontSize = 7f, [Optional] FontLibrary.FontPair fontPair, [Optional] Color? color, bool autoSize = false)
	{
		return null;
	}

	// Token: 0x06000EB8 RID: 3768 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000EB8")]
	[Address(RVA = "0x469EF0", Offset = "0x4690F0", VA = "0x180469EF0")]
	private Image GetObject(Sprite sprite)
	{
		return null;
	}

	// Token: 0x06000EB9 RID: 3769 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000EB9")]
	[Address(RVA = "0x46A090", Offset = "0x469290", VA = "0x18046A090")]
	private Image GetSeparator()
	{
		return null;
	}

	// Token: 0x06000EBA RID: 3770 RVA: 0x00005F88 File Offset: 0x00004188
	[Token(Token = "0x6000EBA")]
	[Address(RVA = "0x46A140", Offset = "0x469340", VA = "0x18046A140")]
	private ValueTuple<RectTransform, Slot[]> GetSlots()
	{
		return default(ValueTuple<RectTransform, Slot[]>);
	}

	// Token: 0x06000EBB RID: 3771 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EBB")]
	[Address(RVA = "0x46A270", Offset = "0x469470", VA = "0x18046A270")]
	private void InsertAndPlace(RectTransform rectTransform, float spacing = 0f)
	{
	}

	// Token: 0x06000EBC RID: 3772 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EBC")]
	[Address(RVA = "0x46A340", Offset = "0x469540", VA = "0x18046A340")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000EBD RID: 3773 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EBD")]
	[Address(RVA = "0x46A4E0", Offset = "0x4696E0", VA = "0x18046A4E0")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000EBE RID: 3774 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EBE")]
	[Address(RVA = "0x46A520", Offset = "0x469720", VA = "0x18046A520")]
	private void PlayAfter(DurationTask task, float delay, CancellationToken cancellationToken)
	{
	}

	// Token: 0x06000EBF RID: 3775 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000EBF")]
	[Address(RVA = "0x46A600", Offset = "0x469800", VA = "0x18046A600")]
	private Task PlayScrollAnimationAsync(DeathData deathData, Simulation simulation, CancellationToken cancellationToken)
	{
		return null;
	}

	// Token: 0x06000EC0 RID: 3776 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000EC0")]
	[Address(RVA = "0x46AC20", Offset = "0x469E20", VA = "0x18046AC20")]
	private Task StopCaptureAsync()
	{
		return null;
	}

	// Token: 0x06000EC1 RID: 3777 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EC1")]
	[Address(RVA = "0x46AE40", Offset = "0x46A040", VA = "0x18046AE40")]
	public DeathScreen()
	{
	}

	// Token: 0x04000BF1 RID: 3057
	[Token(Token = "0x4000BF1")]
	private const float GradientDelay = 1f;

	// Token: 0x04000BF2 RID: 3058
	[Token(Token = "0x4000BF2")]
	private const float BreakingDelay = 2.5f;

	// Token: 0x04000BF3 RID: 3059
	[Token(Token = "0x4000BF3")]
	private const float AnimationDuration = 2f;

	// Token: 0x04000BF4 RID: 3060
	[Token(Token = "0x4000BF4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly string[] s_notes;

	// Token: 0x04000BF5 RID: 3061
	[Token(Token = "0x4000BF5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public World World;

	// Token: 0x04000BF6 RID: 3062
	[Token(Token = "0x4000BF6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Image DeathGradient;

	// Token: 0x04000BF7 RID: 3063
	[Token(Token = "0x4000BF7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public DeathNoteMenu DeathNoteMenu;

	// Token: 0x04000BF8 RID: 3064
	[Token(Token = "0x4000BF8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public BlessingStrand BlessingStrand;

	// Token: 0x04000BF9 RID: 3065
	[Token(Token = "0x4000BF9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public RectTransform BlessingStrandMoveTo;

	// Token: 0x04000BFA RID: 3066
	[Token(Token = "0x4000BFA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Image Scroll;

	// Token: 0x04000BFB RID: 3067
	[Token(Token = "0x4000BFB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public RectTransform ScrollContentContainer;

	// Token: 0x04000BFC RID: 3068
	[Token(Token = "0x4000BFC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public RectTransform ScrollView;

	// Token: 0x04000BFD RID: 3069
	[Token(Token = "0x4000BFD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public CapturePreview CapturePreview;

	// Token: 0x04000BFE RID: 3070
	[Token(Token = "0x4000BFE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public CameraCapture Capture;

	// Token: 0x04000BFF RID: 3071
	[Token(Token = "0x4000BFF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public TextMeshProUGUI LabelPrefab;

	// Token: 0x04000C00 RID: 3072
	[Token(Token = "0x4000C00")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public GameObject SlotsPrefab;

	// Token: 0x04000C01 RID: 3073
	[Token(Token = "0x4000C01")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Image ObjectPrefab;

	// Token: 0x04000C02 RID: 3074
	[Token(Token = "0x4000C02")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public CharacterImage CharacterImagePrefab;

	// Token: 0x04000C03 RID: 3075
	[Token(Token = "0x4000C03")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Image SeparatorPrefab;

	// Token: 0x04000C04 RID: 3076
	[Token(Token = "0x4000C04")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public GameObject ContinueButton;

	// Token: 0x04000C05 RID: 3077
	[Token(Token = "0x4000C05")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public GameObject NewCharacterButton;

	// Token: 0x04000C06 RID: 3078
	[Token(Token = "0x4000C06")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public RoninGameService GameService;

	// Token: 0x04000C07 RID: 3079
	[Token(Token = "0x4000C07")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private float _scrollContentHeight;

	// Token: 0x04000C08 RID: 3080
	[Token(Token = "0x4000C08")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	private bool _shown;

	// Token: 0x04000C09 RID: 3081
	[Token(Token = "0x4000C09")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private Task _animationTask;

	// Token: 0x04000C0A RID: 3082
	[Token(Token = "0x4000C0A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private Option _captureEnabled;

	// Token: 0x04000C0B RID: 3083
	[Token(Token = "0x4000C0B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private readonly CancellationTokenSource _cancellationTokenSource;
}
