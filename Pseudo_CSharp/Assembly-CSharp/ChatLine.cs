using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using Ronin.Model.Data;
using Ronin.Model.Enums;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000182 RID: 386
[Token(Token = "0x2000182")]
public class ChatLine : MonoBehaviour
{
	// Token: 0x170000B3 RID: 179
	// (get) Token: 0x0600078E RID: 1934 RVA: 0x00003E70 File Offset: 0x00002070
	// (set) Token: 0x0600078F RID: 1935 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000B3")]
	public float Time
	{
		[Token(Token = "0x600078E")]
		[Address(RVA = "0x40CFE0", Offset = "0x40C1E0", VA = "0x18040CFE0")]
		[CompilerGenerated]
		get
		{
			return 0f;
		}
		[Token(Token = "0x600078F")]
		[Address(RVA = "0x40D010", Offset = "0x40C210", VA = "0x18040D010")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x170000B4 RID: 180
	// (get) Token: 0x06000790 RID: 1936 RVA: 0x00003E88 File Offset: 0x00002088
	// (set) Token: 0x06000791 RID: 1937 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000B4")]
	public int? ChatId
	{
		[Token(Token = "0x6000790")]
		[Address(RVA = "0x40CFC0", Offset = "0x40C1C0", VA = "0x18040CFC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000791")]
		[Address(RVA = "0x40CFF0", Offset = "0x40C1F0", VA = "0x18040CFF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x170000B5 RID: 181
	// (get) Token: 0x06000792 RID: 1938 RVA: 0x00003EA0 File Offset: 0x000020A0
	// (set) Token: 0x06000793 RID: 1939 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000B5")]
	public float Height
	{
		[Token(Token = "0x6000792")]
		[Address(RVA = "0x40CFD0", Offset = "0x40C1D0", VA = "0x18040CFD0")]
		[CompilerGenerated]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000793")]
		[Address(RVA = "0x40D000", Offset = "0x40C200", VA = "0x18040D000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x06000794 RID: 1940 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000794")]
	[Address(RVA = "0x40BDC0", Offset = "0x40AFC0", VA = "0x18040BDC0")]
	public static Task ReportAreYouSureAsync(string ownerName, long reportId, bool id)
	{
		return null;
	}

	// Token: 0x06000795 RID: 1941 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000795")]
	[Address(RVA = "0x40BEC0", Offset = "0x40B0C0", VA = "0x18040BEC0")]
	public void Report()
	{
	}

	// Token: 0x06000796 RID: 1942 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000796")]
	[Address(RVA = "0x40C000", Offset = "0x40B200", VA = "0x18040C000")]
	public void SetAlpha(float alpha)
	{
	}

	// Token: 0x06000797 RID: 1943 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000797")]
	[Address(RVA = "0x40C090", Offset = "0x40B290", VA = "0x18040C090")]
	public void SetChat(Chat chat)
	{
	}

	// Token: 0x06000798 RID: 1944 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000798")]
	[Address(RVA = "0x40CDD0", Offset = "0x40BFD0", VA = "0x18040CDD0")]
	public void SetParent(Transform parent)
	{
	}

	// Token: 0x06000799 RID: 1945 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000799")]
	[Address(RVA = "0x40CF10", Offset = "0x40C110", VA = "0x18040CF10")]
	public void SetPosition(float position)
	{
	}

	// Token: 0x0600079A RID: 1946 RVA: 0x00003EB8 File Offset: 0x000020B8
	[Token(Token = "0x600079A")]
	[Address(RVA = "0x40B9B0", Offset = "0x40ABB0", VA = "0x18040B9B0")]
	private Color GetColor(ChatType type)
	{
		return default(Color);
	}

	// Token: 0x0600079B RID: 1947 RVA: 0x00003ED0 File Offset: 0x000020D0
	[Token(Token = "0x600079B")]
	[Address(RVA = "0x40B8C0", Offset = "0x40AAC0", VA = "0x18040B8C0")]
	private float GetChatIconOffset()
	{
		return 0f;
	}

	// Token: 0x0600079C RID: 1948 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600079C")]
	[Address(RVA = "0x40BC10", Offset = "0x40AE10", VA = "0x18040BC10")]
	private string GetNameColor(ChatType type, RankType rank)
	{
		return null;
	}

	// Token: 0x0600079D RID: 1949 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600079D")]
	[Address(RVA = "0x40CC90", Offset = "0x40BE90", VA = "0x18040CC90")]
	private void SetImage(Chat chat)
	{
	}

	// Token: 0x0600079E RID: 1950 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600079E")]
	[Address(RVA = "0x40CFB0", Offset = "0x40C1B0", VA = "0x18040CFB0")]
	public ChatLine()
	{
	}

	// Token: 0x04000797 RID: 1943
	[Token(Token = "0x4000797")]
	[FieldOffset(Offset = "0x20")]
	public Image ReportButton;

	// Token: 0x04000798 RID: 1944
	[Token(Token = "0x4000798")]
	[FieldOffset(Offset = "0x28")]
	public Image Image;

	// Token: 0x04000799 RID: 1945
	[Token(Token = "0x4000799")]
	[FieldOffset(Offset = "0x30")]
	public TextMeshProUGUI Label;

	// Token: 0x0400079A RID: 1946
	[Token(Token = "0x400079A")]
	[FieldOffset(Offset = "0x38")]
	public ContextActions ContextActions;

	// Token: 0x0400079B RID: 1947
	[Token(Token = "0x400079B")]
	[FieldOffset(Offset = "0x40")]
	public bool SoftMask;

	// Token: 0x0400079F RID: 1951
	[Token(Token = "0x400079F")]
	[FieldOffset(Offset = "0x54")]
	private float _alpha;

	// Token: 0x040007A0 RID: 1952
	[Token(Token = "0x40007A0")]
	[FieldOffset(Offset = "0x58")]
	private long? _reportId;

	// Token: 0x040007A1 RID: 1953
	[Token(Token = "0x40007A1")]
	[FieldOffset(Offset = "0x68")]
	private NameData _ownerName;
}
