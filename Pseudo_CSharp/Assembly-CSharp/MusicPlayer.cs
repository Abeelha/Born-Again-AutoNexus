using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200013B RID: 315
[Token(Token = "0x200013B")]
public class MusicPlayer : MonoBehaviour
{
	// Token: 0x17000064 RID: 100
	// (get) Token: 0x06000583 RID: 1411 RVA: 0x0000206A File Offset: 0x0000026A
	// (set) Token: 0x06000584 RID: 1412 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000064")]
	public MusicSet Set
	{
		[Token(Token = "0x6000583")]
		[Address(RVA = "0x3C3070", Offset = "0x3C2270", VA = "0x1803C3070")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000584")]
		[Address(RVA = "0x3C3080", Offset = "0x3C2280", VA = "0x1803C3080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x17000065 RID: 101
	// (get) Token: 0x06000585 RID: 1413 RVA: 0x000035D0 File Offset: 0x000017D0
	// (set) Token: 0x06000586 RID: 1414 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000065")]
	public MusicStage Stage
	{
		[Token(Token = "0x6000585")]
		[Address(RVA = "0x3F1BC0", Offset = "0x3F0DC0", VA = "0x1803F1BC0")]
		[CompilerGenerated]
		get
		{
			return MusicStage.Intro;
		}
		[Token(Token = "0x6000586")]
		[Address(RVA = "0x3F1C60", Offset = "0x3F0E60", VA = "0x1803F1C60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x17000066 RID: 102
	// (get) Token: 0x06000587 RID: 1415 RVA: 0x000035E8 File Offset: 0x000017E8
	[Token(Token = "0x17000066")]
	public float Volume
	{
		[Token(Token = "0x6000587")]
		[Address(RVA = "0x3F1BD0", Offset = "0x3F0DD0", VA = "0x1803F1BD0")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000067 RID: 103
	// (get) Token: 0x06000588 RID: 1416 RVA: 0x00003600 File Offset: 0x00001800
	[Token(Token = "0x17000067")]
	private float FadeScalar
	{
		[Token(Token = "0x6000588")]
		[Address(RVA = "0x3F1B50", Offset = "0x3F0D50", VA = "0x1803F1B50")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000068 RID: 104
	// (get) Token: 0x06000589 RID: 1417 RVA: 0x00003618 File Offset: 0x00001818
	[Token(Token = "0x17000068")]
	private float CrossFadeScalar
	{
		[Token(Token = "0x6000589")]
		[Address(RVA = "0x3F1B30", Offset = "0x3F0D30", VA = "0x1803F1B30")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000069 RID: 105
	// (get) Token: 0x0600058A RID: 1418 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x17000069")]
	private AudioSource MainSource
	{
		[Token(Token = "0x600058A")]
		[Address(RVA = "0x3F1B90", Offset = "0x3F0D90", VA = "0x1803F1B90")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600058B RID: 1419 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600058B")]
	[Address(RVA = "0x3F0EC0", Offset = "0x3F00C0", VA = "0x1803F0EC0")]
	public void FadeOut()
	{
	}

	// Token: 0x0600058C RID: 1420 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600058C")]
	[Address(RVA = "0x3F0F50", Offset = "0x3F0150", VA = "0x1803F0F50")]
	public void Play(MusicSet set, bool fadeIn)
	{
	}

	// Token: 0x0600058D RID: 1421 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600058D")]
	[Address(RVA = "0x3F1500", Offset = "0x3F0700", VA = "0x1803F1500")]
	public void Stop()
	{
	}

	// Token: 0x0600058E RID: 1422 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600058E")]
	[Address(RVA = "0x3F0E40", Offset = "0x3F0040", VA = "0x1803F0E40")]
	private void Awake()
	{
	}

	// Token: 0x0600058F RID: 1423 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600058F")]
	[Address(RVA = "0x3F0ED0", Offset = "0x3F00D0", VA = "0x1803F0ED0")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000590 RID: 1424 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000590")]
	[Address(RVA = "0x3F10E0", Offset = "0x3F02E0", VA = "0x1803F10E0")]
	private void SetIntro()
	{
	}

	// Token: 0x06000591 RID: 1425 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000591")]
	[Address(RVA = "0x3F1210", Offset = "0x3F0410", VA = "0x1803F1210")]
	private void SetLooping()
	{
	}

	// Token: 0x06000592 RID: 1426 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000592")]
	[Address(RVA = "0x3F13D0", Offset = "0x3F05D0", VA = "0x1803F13D0")]
	private void SetStopped()
	{
	}

	// Token: 0x06000593 RID: 1427 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000593")]
	[Address(RVA = "0x3F1520", Offset = "0x3F0720", VA = "0x1803F1520")]
	private void UpdateFade()
	{
	}

	// Token: 0x06000594 RID: 1428 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000594")]
	[Address(RVA = "0x3F1580", Offset = "0x3F0780", VA = "0x1803F1580")]
	private void UpdateLoopLayers()
	{
	}

	// Token: 0x06000595 RID: 1429 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000595")]
	[Address(RVA = "0x3F1980", Offset = "0x3F0B80", VA = "0x1803F1980")]
	private void UpdateStage()
	{
	}

	// Token: 0x06000596 RID: 1430 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000596")]
	[Address(RVA = "0x3F1B10", Offset = "0x3F0D10", VA = "0x1803F1B10")]
	public MusicPlayer()
	{
	}

	// Token: 0x040005FC RID: 1532
	[Token(Token = "0x40005FC")]
	[FieldOffset(Offset = "0x20")]
	public AudioSource[] AudioSources;

	// Token: 0x040005FD RID: 1533
	[Token(Token = "0x40005FD")]
	[FieldOffset(Offset = "0x28")]
	public int LoopLayer;

	// Token: 0x040005FE RID: 1534
	[Token(Token = "0x40005FE")]
	[FieldOffset(Offset = "0x2C")]
	public float FadeDuration;

	// Token: 0x040005FF RID: 1535
	[Token(Token = "0x40005FF")]
	[FieldOffset(Offset = "0x30")]
	public float CrossFadeDuration;

	// Token: 0x04000600 RID: 1536
	[Token(Token = "0x4000600")]
	[FieldOffset(Offset = "0x34")]
	private int _currentLoopLayer;

	// Token: 0x04000601 RID: 1537
	[Token(Token = "0x4000601")]
	[FieldOffset(Offset = "0x38")]
	private float _fadeTime;

	// Token: 0x04000602 RID: 1538
	[Token(Token = "0x4000602")]
	[FieldOffset(Offset = "0x3C")]
	private FadeDirection _fadeDirection;

	// Token: 0x04000603 RID: 1539
	[Token(Token = "0x4000603")]
	[FieldOffset(Offset = "0x40")]
	private float _crossFadeTime;

	// Token: 0x04000604 RID: 1540
	[Token(Token = "0x4000604")]
	[FieldOffset(Offset = "0x48")]
	private Option _musicVolume;

	// Token: 0x04000605 RID: 1541
	[Token(Token = "0x4000605")]
	[FieldOffset(Offset = "0x50")]
	private Option _masterVolume;
}
