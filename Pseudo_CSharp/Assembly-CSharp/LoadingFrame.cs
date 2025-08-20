using System;
using System.Threading;
using System.Threading.Tasks;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x020001B7 RID: 439
[Token(Token = "0x20001B7")]
public class LoadingFrame : MonoBehaviour
{
	// Token: 0x170000D9 RID: 217
	// (get) Token: 0x060008BD RID: 2237 RVA: 0x0000206A File Offset: 0x0000026A
	// (set) Token: 0x060008BE RID: 2238 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000D9")]
	public string LoadingText
	{
		[Token(Token = "0x60008BD")]
		[Address(RVA = "0x4167F0", Offset = "0x4159F0", VA = "0x1804167F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60008BE")]
		[Address(RVA = "0x416820", Offset = "0x415A20", VA = "0x180416820")]
		set
		{
		}
	}

	// Token: 0x060008BF RID: 2239 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008BF")]
	[Address(RVA = "0x416280", Offset = "0x415480", VA = "0x180416280")]
	public void Cancel()
	{
	}

	// Token: 0x060008C0 RID: 2240 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60008C0")]
	[Address(RVA = "0x416730", Offset = "0x415930", VA = "0x180416730")]
	public LoadingFrame SetCancel(CancellationTokenSource cts)
	{
		return null;
	}

	// Token: 0x060008C1 RID: 2241 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60008C1")]
	[Address(RVA = "0x416790", Offset = "0x415990", VA = "0x180416790")]
	public LoadingFrame SetTask(Task task)
	{
		return null;
	}

	// Token: 0x060008C2 RID: 2242 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60008C2")]
	[Address(RVA = "0x4167B0", Offset = "0x4159B0", VA = "0x1804167B0")]
	public LoadingFrame SetText(string text)
	{
		return null;
	}

	// Token: 0x060008C3 RID: 2243 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008C3")]
	[Address(RVA = "0x4162A0", Offset = "0x4154A0", VA = "0x1804162A0")]
	private void CheckTask()
	{
	}

	// Token: 0x060008C4 RID: 2244 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008C4")]
	[Address(RVA = "0x416500", Offset = "0x415700", VA = "0x180416500")]
	private void OnEnable()
	{
	}

	// Token: 0x060008C5 RID: 2245 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008C5")]
	[Address(RVA = "0x4164C0", Offset = "0x4156C0", VA = "0x1804164C0")]
	private void OnDisable()
	{
	}

	// Token: 0x060008C6 RID: 2246 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008C6")]
	[Address(RVA = "0x4163A0", Offset = "0x4155A0", VA = "0x1804163A0")]
	private void LateUpdate()
	{
	}

	// Token: 0x060008C7 RID: 2247 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008C7")]
	[Address(RVA = "0x4166D0", Offset = "0x4158D0", VA = "0x1804166D0")]
	private void Return()
	{
	}

	// Token: 0x060008C8 RID: 2248 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008C8")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public LoadingFrame()
	{
	}

	// Token: 0x0400087C RID: 2172
	[Token(Token = "0x400087C")]
	[FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI Label;

	// Token: 0x0400087D RID: 2173
	[Token(Token = "0x400087D")]
	[FieldOffset(Offset = "0x28")]
	public GameObject CancelButton;

	// Token: 0x0400087E RID: 2174
	[Token(Token = "0x400087E")]
	[FieldOffset(Offset = "0x30")]
	private Task _task;

	// Token: 0x0400087F RID: 2175
	[Token(Token = "0x400087F")]
	[FieldOffset(Offset = "0x38")]
	private CancellationTokenSource _cts;
}
