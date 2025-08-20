using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200033D RID: 829
[Token(Token = "0x200033D")]
public class TutorialUIStepper : MonoBehaviour
{
	// Token: 0x06001252 RID: 4690 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001252")]
	[Address(RVA = "0x37CF50", Offset = "0x37C150", VA = "0x18037CF50")]
	public void Advance(string step, float dueTime)
	{
	}

	// Token: 0x06001253 RID: 4691 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001253")]
	[Address(RVA = "0x37CF80", Offset = "0x37C180", VA = "0x18037CF80")]
	private void DoAdvance()
	{
	}

	// Token: 0x06001254 RID: 4692 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001254")]
	[Address(RVA = "0x37D2C0", Offset = "0x37C4C0", VA = "0x18037D2C0")]
	private void LateUpdate()
	{
	}

	// Token: 0x06001255 RID: 4693 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001255")]
	[Address(RVA = "0x37D320", Offset = "0x37C520", VA = "0x18037D320")]
	public void OnDisable()
	{
	}

	// Token: 0x06001256 RID: 4694 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001256")]
	[Address(RVA = "0x37D3F0", Offset = "0x37C5F0", VA = "0x18037D3F0")]
	public void OnEnable()
	{
	}

	// Token: 0x06001257 RID: 4695 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001257")]
	[Address(RVA = "0x37D4A0", Offset = "0x37C6A0", VA = "0x18037D4A0")]
	public TutorialUIStepper()
	{
	}

	// Token: 0x04000EFC RID: 3836
	[Token(Token = "0x4000EFC")]
	[FieldOffset(Offset = "0x20")]
	public float PopInScale;

	// Token: 0x04000EFD RID: 3837
	[Token(Token = "0x4000EFD")]
	[FieldOffset(Offset = "0x24")]
	public float PopInDuration;

	// Token: 0x04000EFE RID: 3838
	[Token(Token = "0x4000EFE")]
	[FieldOffset(Offset = "0x28")]
	public TutorialUIStepper.TutorialStep[] Steps;

	// Token: 0x04000EFF RID: 3839
	[Token(Token = "0x4000EFF")]
	[FieldOffset(Offset = "0x30")]
	private string _nextStep;

	// Token: 0x04000F00 RID: 3840
	[Token(Token = "0x4000F00")]
	[FieldOffset(Offset = "0x38")]
	private float _timeRemaining;

	// Token: 0x0200033E RID: 830
	[Token(Token = "0x200033E")]
	[Serializable]
	public struct TutorialStep
	{
		// Token: 0x04000F01 RID: 3841
		[Token(Token = "0x4000F01")]
		[FieldOffset(Offset = "0x0")]
		public string Step;

		// Token: 0x04000F02 RID: 3842
		[Token(Token = "0x4000F02")]
		[FieldOffset(Offset = "0x8")]
		public RectTransform[] Objects;
	}
}
