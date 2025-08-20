using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020001B1 RID: 433
[Token(Token = "0x20001B1")]
public class AlertFrame : MonoBehaviour
{
	// Token: 0x060008A5 RID: 2213 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60008A5")]
	[Address(RVA = "0x405530", Offset = "0x404730", VA = "0x180405530")]
	public Task<int> ButtonAsync()
	{
		return null;
	}

	// Token: 0x060008A6 RID: 2214 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60008A6")]
	[Address(RVA = "0x405810", Offset = "0x404A10", VA = "0x180405810")]
	public Task<ValueTuple<int, string>> InputAsync()
	{
		return null;
	}

	// Token: 0x060008A7 RID: 2215 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008A7")]
	[Address(RVA = "0x405A80", Offset = "0x404C80", VA = "0x180405A80")]
	public void Select(AlertButton button)
	{
	}

	// Token: 0x060008A8 RID: 2216 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008A8")]
	[Address(RVA = "0x405CD0", Offset = "0x404ED0", VA = "0x180405CD0")]
	public void Setup(string title, string message, AlertButtonDescriptor[] buttons, AlertInputDescriptor input, bool largeMessage)
	{
	}

	// Token: 0x060008A9 RID: 2217 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60008A9")]
	[Address(RVA = "0x405620", Offset = "0x404820", VA = "0x180405620")]
	private Task CloseAsync()
	{
		return null;
	}

	// Token: 0x060008AA RID: 2218 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60008AA")]
	[Address(RVA = "0x405720", Offset = "0x404920", VA = "0x180405720")]
	private AlertButton GetButton(AlertButtonType type)
	{
		return null;
	}

	// Token: 0x060008AB RID: 2219 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60008AB")]
	[Address(RVA = "0x4056F0", Offset = "0x4048F0", VA = "0x1804056F0")]
	private AlertButton GetButtonPrefab(AlertButtonType type)
	{
		return null;
	}

	// Token: 0x060008AC RID: 2220 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008AC")]
	[Address(RVA = "0x405850", Offset = "0x404A50", VA = "0x180405850")]
	private void OnEnable()
	{
	}

	// Token: 0x060008AD RID: 2221 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008AD")]
	[Address(RVA = "0x406570", Offset = "0x405770", VA = "0x180406570")]
	private void Update()
	{
	}

	// Token: 0x060008AE RID: 2222 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008AE")]
	[Address(RVA = "0x406690", Offset = "0x405890", VA = "0x180406690")]
	public AlertFrame()
	{
	}

	// Token: 0x04000861 RID: 2145
	[Token(Token = "0x4000861")]
	private const float Animation_Duration = 0.3f;

	// Token: 0x04000862 RID: 2146
	[Token(Token = "0x4000862")]
	[FieldOffset(Offset = "0x20")]
	public AlertButton ButtonPrefab;

	// Token: 0x04000863 RID: 2147
	[Token(Token = "0x4000863")]
	[FieldOffset(Offset = "0x28")]
	public AlertButton ButtonGreenPrefab;

	// Token: 0x04000864 RID: 2148
	[Token(Token = "0x4000864")]
	[FieldOffset(Offset = "0x30")]
	public AlertButton ButtonRedPrefab;

	// Token: 0x04000865 RID: 2149
	[Token(Token = "0x4000865")]
	[FieldOffset(Offset = "0x38")]
	public AlertButton ButtonOrangePrefab;

	// Token: 0x04000866 RID: 2150
	[Token(Token = "0x4000866")]
	[FieldOffset(Offset = "0x40")]
	public TextMeshProUGUI TitleLabel;

	// Token: 0x04000867 RID: 2151
	[Token(Token = "0x4000867")]
	[FieldOffset(Offset = "0x48")]
	public TextMeshProUGUI MessageLabel;

	// Token: 0x04000868 RID: 2152
	[Token(Token = "0x4000868")]
	[FieldOffset(Offset = "0x50")]
	public TMP_InputField InputField;

	// Token: 0x04000869 RID: 2153
	[Token(Token = "0x4000869")]
	[FieldOffset(Offset = "0x58")]
	public TextMeshProUGUI InputPlaceholderLabel;

	// Token: 0x0400086A RID: 2154
	[Token(Token = "0x400086A")]
	[FieldOffset(Offset = "0x60")]
	public RectTransform MenuRectTransform;

	// Token: 0x0400086B RID: 2155
	[Token(Token = "0x400086B")]
	[FieldOffset(Offset = "0x68")]
	public Image OverlayImage;

	// Token: 0x0400086C RID: 2156
	[Token(Token = "0x400086C")]
	[FieldOffset(Offset = "0x70")]
	private List<AlertButton> _buttons;

	// Token: 0x0400086D RID: 2157
	[Token(Token = "0x400086D")]
	[FieldOffset(Offset = "0x78")]
	private TaskCompletionSource<ValueTuple<int, string>> _resultSource;

	// Token: 0x0400086E RID: 2158
	[Token(Token = "0x400086E")]
	[FieldOffset(Offset = "0x80")]
	private bool _buttonSelected;

	// Token: 0x0400086F RID: 2159
	[Token(Token = "0x400086F")]
	[FieldOffset(Offset = "0x84")]
	private ControllerNavigation _controllerNavigation;
}
