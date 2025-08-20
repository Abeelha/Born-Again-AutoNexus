using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020002A5 RID: 677
[Token(Token = "0x20002A5")]
public class ContextActions : MonoBehaviour
{
	// Token: 0x170001A2 RID: 418
	// (get) Token: 0x06000E81 RID: 3713 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x170001A2")]
	public RectTransform RectTransform
	{
		[Token(Token = "0x6000E81")]
		[Address(RVA = "0x4669F0", Offset = "0x465BF0", VA = "0x1804669F0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000E82 RID: 3714 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000E82")]
	[Address(RVA = "0x465740", Offset = "0x464940", VA = "0x180465740")]
	public Task<int> GetOptionAsync(Vector2 position, string name, IEnumerable<string> options)
	{
		return null;
	}

	// Token: 0x06000E83 RID: 3715 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000E83")]
	[Address(RVA = "0x4655F0", Offset = "0x4647F0", VA = "0x1804655F0")]
	public Task<int> GetOptionAsync(Vector2 position, string name, IEnumerable<ContextActions.ContextActionsOptionState> options)
	{
		return null;
	}

	// Token: 0x06000E84 RID: 3716 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E84")]
	[Address(RVA = "0x465BC0", Offset = "0x464DC0", VA = "0x180465BC0")]
	public void SelectOption(ContextActionsOption selectedOption)
	{
	}

	// Token: 0x06000E85 RID: 3717 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E85")]
	[Address(RVA = "0x44FDE0", Offset = "0x44EFE0", VA = "0x18044FDE0")]
	private void Awake()
	{
	}

	// Token: 0x06000E86 RID: 3718 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E86")]
	[Address(RVA = "0x465570", Offset = "0x464770", VA = "0x180465570")]
	private void Close()
	{
	}

	// Token: 0x06000E87 RID: 3719 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000E87")]
	[Address(RVA = "0x465990", Offset = "0x464B90", VA = "0x180465990")]
	private ContextActionsOption GetOption()
	{
		return null;
	}

	// Token: 0x06000E88 RID: 3720 RVA: 0x00005EE0 File Offset: 0x000040E0
	[Token(Token = "0x6000E88")]
	[Address(RVA = "0x465B00", Offset = "0x464D00", VA = "0x180465B00")]
	private Vector2 GetQuadrantScalar(Vector2 screenPosition)
	{
		return default(Vector2);
	}

	// Token: 0x06000E89 RID: 3721 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E89")]
	[Address(RVA = "0x465BB0", Offset = "0x464DB0", VA = "0x180465BB0")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000E8A RID: 3722 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E8A")]
	[Address(RVA = "0x466690", Offset = "0x465890", VA = "0x180466690")]
	private void UpdateCloseOuterClick()
	{
	}

	// Token: 0x06000E8B RID: 3723 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E8B")]
	[Address(RVA = "0x465D20", Offset = "0x464F20", VA = "0x180465D20")]
	public void SetContentSize(Vector2 size)
	{
	}

	// Token: 0x06000E8C RID: 3724 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E8C")]
	[Address(RVA = "0x465DD0", Offset = "0x464FD0", VA = "0x180465DD0")]
	private void SetOptions(IEnumerable<ContextActions.ContextActionsOptionState> options)
	{
	}

	// Token: 0x06000E8D RID: 3725 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E8D")]
	[Address(RVA = "0x466420", Offset = "0x465620", VA = "0x180466420")]
	private void SetPosition(Vector2 position)
	{
	}

	// Token: 0x06000E8E RID: 3726 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E8E")]
	[Address(RVA = "0x466970", Offset = "0x465B70", VA = "0x180466970")]
	public ContextActions()
	{
	}

	// Token: 0x04000BCC RID: 3020
	[Token(Token = "0x4000BCC")]
	[FieldOffset(Offset = "0x20")]
	public TMP_Text NameLabel;

	// Token: 0x04000BCD RID: 3021
	[Token(Token = "0x4000BCD")]
	[FieldOffset(Offset = "0x28")]
	public ContextActionsOption OptionPrefab;

	// Token: 0x04000BCE RID: 3022
	[Token(Token = "0x4000BCE")]
	[FieldOffset(Offset = "0x30")]
	public RectTransform Content;

	// Token: 0x04000BCF RID: 3023
	[Token(Token = "0x4000BCF")]
	[FieldOffset(Offset = "0x38")]
	public GraphicRaycaster Raycaster;

	// Token: 0x04000BD0 RID: 3024
	[Token(Token = "0x4000BD0")]
	[FieldOffset(Offset = "0x40")]
	public float Offset;

	// Token: 0x04000BD1 RID: 3025
	[Token(Token = "0x4000BD1")]
	[FieldOffset(Offset = "0x44")]
	private int _activeCount;

	// Token: 0x04000BD2 RID: 3026
	[Token(Token = "0x4000BD2")]
	[FieldOffset(Offset = "0x48")]
	private readonly List<ContextActionsOption> _options;

	// Token: 0x04000BD3 RID: 3027
	[Token(Token = "0x4000BD3")]
	[FieldOffset(Offset = "0x50")]
	private TaskCompletionSource<int> _currentSource;

	// Token: 0x04000BD4 RID: 3028
	[Token(Token = "0x4000BD4")]
	[FieldOffset(Offset = "0x58")]
	private RectTransform _rectTransform;

	// Token: 0x04000BD5 RID: 3029
	[Token(Token = "0x4000BD5")]
	[FieldOffset(Offset = "0x60")]
	private float _minCloseTime;

	// Token: 0x020002A6 RID: 678
	[Token(Token = "0x20002A6")]
	public struct ContextActionsOptionState
	{
		// Token: 0x06000E8F RID: 3727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E8F")]
		[Address(RVA = "0x465020", Offset = "0x464220", VA = "0x180465020")]
		public ContextActionsOptionState(string icon, string label)
		{
		}

		// Token: 0x06000E90 RID: 3728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E90")]
		[Address(RVA = "0x37B9C0", Offset = "0x37ABC0", VA = "0x18037B9C0")]
		public ContextActionsOptionState(Sprite icon, string label)
		{
		}

		// Token: 0x04000BD6 RID: 3030
		[Token(Token = "0x4000BD6")]
		[FieldOffset(Offset = "0x0")]
		public Sprite Icon;

		// Token: 0x04000BD7 RID: 3031
		[Token(Token = "0x4000BD7")]
		[FieldOffset(Offset = "0x8")]
		public string Label;
	}
}
