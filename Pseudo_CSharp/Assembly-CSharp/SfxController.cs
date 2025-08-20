using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200016D RID: 365
[Token(Token = "0x200016D")]
public class SfxController : MonoBehaviour
{
	// Token: 0x170000A1 RID: 161
	// (get) Token: 0x0600072E RID: 1838 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x170000A1")]
	public static SfxController Instance
	{
		[Token(Token = "0x600072E")]
		[Address(RVA = "0x3FB9A0", Offset = "0x3FABA0", VA = "0x1803FB9A0")]
		get
		{
			return null;
		}
	}

	// Token: 0x170000A2 RID: 162
	// (get) Token: 0x0600072F RID: 1839 RVA: 0x00003BD0 File Offset: 0x00001DD0
	[Token(Token = "0x170000A2")]
	public float OptionsVolume
	{
		[Token(Token = "0x600072F")]
		[Address(RVA = "0x3FBA30", Offset = "0x3FAC30", VA = "0x1803FBA30")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x06000730 RID: 1840 RVA: 0x00003BE8 File Offset: 0x00001DE8
	[Token(Token = "0x6000730")]
	[Address(RVA = "0x3FB0A0", Offset = "0x3FA2A0", VA = "0x1803FB0A0")]
	public SfxController.SfxPlayId Play(string sfxClipName, Vector2 origin, float volumeScalar = 1f)
	{
		return default(SfxController.SfxPlayId);
	}

	// Token: 0x06000731 RID: 1841 RVA: 0x00003C00 File Offset: 0x00001E00
	[Token(Token = "0x6000731")]
	[Address(RVA = "0x3FABC0", Offset = "0x3F9DC0", VA = "0x1803FABC0")]
	public SfxController.SfxPlayId Play(SfxClip sfxClip, Vector2 origin, float volumeScalar = 1f)
	{
		return default(SfxController.SfxPlayId);
	}

	// Token: 0x06000732 RID: 1842 RVA: 0x00003C18 File Offset: 0x00001E18
	[Token(Token = "0x6000732")]
	[Address(RVA = "0x3FB180", Offset = "0x3FA380", VA = "0x1803FB180")]
	public bool Stop(SfxController.SfxPlayId playId)
	{
		return default(bool);
	}

	// Token: 0x06000733 RID: 1843 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000733")]
	[Address(RVA = "0x3FA690", Offset = "0x3F9890", VA = "0x1803FA690")]
	private void Awake()
	{
	}

	// Token: 0x06000734 RID: 1844 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000734")]
	[Address(RVA = "0x3FA8A0", Offset = "0x3F9AA0", VA = "0x1803FA8A0")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000735 RID: 1845 RVA: 0x00003C30 File Offset: 0x00001E30
	[Token(Token = "0x6000735")]
	[Address(RVA = "0x3FA9B0", Offset = "0x3F9BB0", VA = "0x1803FA9B0")]
	private SfxController.SfxPlayId Play(int playerIndex, SfxClip sfxClip, Vector2 origin, float volumeScalar)
	{
		return default(SfxController.SfxPlayId);
	}

	// Token: 0x06000736 RID: 1846 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000736")]
	[Address(RVA = "0x3FB230", Offset = "0x3FA430", VA = "0x1803FB230")]
	private void Stop(int playerIndex, ref SfxController.SfxPlayer player)
	{
	}

	// Token: 0x06000737 RID: 1847 RVA: 0x00003C48 File Offset: 0x00001E48
	[Token(Token = "0x6000737")]
	[Address(RVA = "0x3FB3D0", Offset = "0x3FA5D0", VA = "0x1803FB3D0")]
	private SfxController.SfxPlayId TryReplaceLooping(Vector2 origin, List<int> currentPlayingList)
	{
		return default(SfxController.SfxPlayId);
	}

	// Token: 0x06000738 RID: 1848 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000738")]
	[Address(RVA = "0x3FB590", Offset = "0x3FA790", VA = "0x1803FB590")]
	private void Update()
	{
	}

	// Token: 0x06000739 RID: 1849 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000739")]
	[Address(RVA = "0x3FB590", Offset = "0x3FA790", VA = "0x1803FB590")]
	private void UpdatePlaying()
	{
	}

	// Token: 0x0600073A RID: 1850 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600073A")]
	[Address(RVA = "0x3FA8A0", Offset = "0x3F9AA0", VA = "0x1803FA8A0")]
	private void UpdateVolume()
	{
	}

	// Token: 0x0600073B RID: 1851 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600073B")]
	[Address(RVA = "0x3FB690", Offset = "0x3FA890", VA = "0x1803FB690")]
	private void UpdateVolume(ref SfxController.SfxPlayer player)
	{
	}

	// Token: 0x0600073C RID: 1852 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600073C")]
	[Address(RVA = "0x3FB880", Offset = "0x3FAA80", VA = "0x1803FB880")]
	public SfxController()
	{
	}

	// Token: 0x0400072D RID: 1837
	[Token(Token = "0x400072D")]
	[FieldOffset(Offset = "0x20")]
	public Transform Listener;

	// Token: 0x0400072E RID: 1838
	[Token(Token = "0x400072E")]
	[FieldOffset(Offset = "0x28")]
	public int SourceCount;

	// Token: 0x0400072F RID: 1839
	[Token(Token = "0x400072F")]
	[FieldOffset(Offset = "0x2C")]
	public float UnitsPerFalloff;

	// Token: 0x04000730 RID: 1840
	[Token(Token = "0x4000730")]
	[FieldOffset(Offset = "0x0")]
	private static SfxController s_instance;

	// Token: 0x04000731 RID: 1841
	[Token(Token = "0x4000731")]
	[FieldOffset(Offset = "0x30")]
	private SfxController.SfxPlayer[] _players;

	// Token: 0x04000732 RID: 1842
	[Token(Token = "0x4000732")]
	[FieldOffset(Offset = "0x38")]
	private readonly Stack<int> _availableSources;

	// Token: 0x04000733 RID: 1843
	[Token(Token = "0x4000733")]
	[FieldOffset(Offset = "0x40")]
	private readonly Dictionary<SfxClip, List<int>> _sfxMap;

	// Token: 0x04000734 RID: 1844
	[Token(Token = "0x4000734")]
	[FieldOffset(Offset = "0x48")]
	private readonly Stack<List<int>> _listCache;

	// Token: 0x04000735 RID: 1845
	[Token(Token = "0x4000735")]
	[FieldOffset(Offset = "0x50")]
	private Option _masterVolume;

	// Token: 0x04000736 RID: 1846
	[Token(Token = "0x4000736")]
	[FieldOffset(Offset = "0x58")]
	private Option _sfxVolume;

	// Token: 0x0200016E RID: 366
	[Token(Token = "0x200016E")]
	public struct SfxPlayId
	{
		// Token: 0x0600073D RID: 1853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600073D")]
		[Address(RVA = "0x3FBAF0", Offset = "0x3FACF0", VA = "0x1803FBAF0")]
		public SfxPlayId(int sourceIndex, int playId)
		{
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x0600073E RID: 1854 RVA: 0x00003C60 File Offset: 0x00001E60
		[Token(Token = "0x170000A3")]
		public bool Playing
		{
			[Token(Token = "0x600073E")]
			[Address(RVA = "0x3FBB00", Offset = "0x3FAD00", VA = "0x1803FBB00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x04000737 RID: 1847
		[Token(Token = "0x4000737")]
		[FieldOffset(Offset = "0x0")]
		public int PlayerIndex;

		// Token: 0x04000738 RID: 1848
		[Token(Token = "0x4000738")]
		[FieldOffset(Offset = "0x4")]
		public int PlayId;

		// Token: 0x04000739 RID: 1849
		[Token(Token = "0x4000739")]
		[FieldOffset(Offset = "0x0")]
		public static readonly SfxController.SfxPlayId Failed;
	}

	// Token: 0x0200016F RID: 367
	[Token(Token = "0x200016F")]
	private struct SfxPlayer
	{
		// Token: 0x0400073A RID: 1850
		[Token(Token = "0x400073A")]
		[FieldOffset(Offset = "0x0")]
		public AudioSource AudioSource;

		// Token: 0x0400073B RID: 1851
		[Token(Token = "0x400073B")]
		[FieldOffset(Offset = "0x8")]
		public SfxClip SfxClip;

		// Token: 0x0400073C RID: 1852
		[Token(Token = "0x400073C")]
		[FieldOffset(Offset = "0x10")]
		public Vector2 Origin;

		// Token: 0x0400073D RID: 1853
		[Token(Token = "0x400073D")]
		[FieldOffset(Offset = "0x18")]
		public int PlayId;

		// Token: 0x0400073E RID: 1854
		[Token(Token = "0x400073E")]
		[FieldOffset(Offset = "0x1C")]
		public float VolumeScalar;
	}
}
