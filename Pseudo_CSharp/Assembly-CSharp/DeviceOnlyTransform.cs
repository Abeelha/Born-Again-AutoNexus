using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001A0 RID: 416
[Token(Token = "0x20001A0")]
public class DeviceOnlyTransform : MonoBehaviour
{
	// Token: 0x0600086D RID: 2157 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600086D")]
	[Address(RVA = "0x410510", Offset = "0x40F710", VA = "0x180410510")]
	private void Awake()
	{
	}

	// Token: 0x0600086E RID: 2158 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600086E")]
	[Address(RVA = "0x410590", Offset = "0x40F790", VA = "0x180410590")]
	private void LateUpdate()
	{
	}

	// Token: 0x0600086F RID: 2159 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600086F")]
	[Address(RVA = "0x410600", Offset = "0x40F800", VA = "0x180410600")]
	private void SetValues(DeviceOnlyTransform.TransformValues values)
	{
	}

	// Token: 0x06000870 RID: 2160 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000870")]
	[Address(RVA = "0x4107B0", Offset = "0x40F9B0", VA = "0x1804107B0")]
	public DeviceOnlyTransform()
	{
	}

	// Token: 0x04000830 RID: 2096
	[Token(Token = "0x4000830")]
	[FieldOffset(Offset = "0x20")]
	public DeviceType DeviceType;

	// Token: 0x04000831 RID: 2097
	[Token(Token = "0x4000831")]
	[FieldOffset(Offset = "0x24")]
	public bool Position;

	// Token: 0x04000832 RID: 2098
	[Token(Token = "0x4000832")]
	[FieldOffset(Offset = "0x25")]
	public bool Scale;

	// Token: 0x04000833 RID: 2099
	[Token(Token = "0x4000833")]
	[FieldOffset(Offset = "0x28")]
	public DeviceOnlyTransform.TransformValues DeviceValues;

	// Token: 0x04000834 RID: 2100
	[Token(Token = "0x4000834")]
	[FieldOffset(Offset = "0x30")]
	public DeviceOnlyTransform.TransformValues Default;

	// Token: 0x04000835 RID: 2101
	[Token(Token = "0x4000835")]
	[FieldOffset(Offset = "0x38")]
	private RectTransform _rectTransform;

	// Token: 0x020001A1 RID: 417
	[Token(Token = "0x20001A1")]
	[Serializable]
	public class TransformValues
	{
		// Token: 0x06000871 RID: 2161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000871")]
		[Address(RVA = "0x41BA00", Offset = "0x41AC00", VA = "0x18041BA00")]
		public TransformValues()
		{
		}

		// Token: 0x04000836 RID: 2102
		[Token(Token = "0x4000836")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 Scale;

		// Token: 0x04000837 RID: 2103
		[Token(Token = "0x4000837")]
		[FieldOffset(Offset = "0x1C")]
		public Vector2 AnchoredPosition;
	}
}
