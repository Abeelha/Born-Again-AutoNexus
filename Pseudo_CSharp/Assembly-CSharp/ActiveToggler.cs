using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x02000295 RID: 661
[Token(Token = "0x2000295")]
public class ActiveToggler : MonoBehaviour
{
	// Token: 0x06000E20 RID: 3616 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E20")]
	[Address(RVA = "0x4107C0", Offset = "0x40F9C0", VA = "0x1804107C0")]
	public void Toggle()
	{
	}

	// Token: 0x06000E21 RID: 3617 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E21")]
	[Address(RVA = "0x44B5A0", Offset = "0x44A7A0", VA = "0x18044B5A0")]
	public void ToggleObject(Behaviour behaviour)
	{
	}

	// Token: 0x06000E22 RID: 3618 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E22")]
	[Address(RVA = "0x44B5E0", Offset = "0x44A7E0", VA = "0x18044B5E0")]
	public void ToggleObject(GameObject gameObject)
	{
	}

	// Token: 0x06000E23 RID: 3619 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E23")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public ActiveToggler()
	{
	}

	// Token: 0x04000B6A RID: 2922
	[Token(Token = "0x4000B6A")]
	[FieldOffset(Offset = "0x20")]
	public UnityEvent OnToggle;
}
