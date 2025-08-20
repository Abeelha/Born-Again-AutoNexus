using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Ronin.Model.Data;
using UnityEngine;

// Token: 0x02000343 RID: 835
[Token(Token = "0x2000343")]
public struct WeatherState
{
	// Token: 0x170001EB RID: 491
	// (get) Token: 0x06001270 RID: 4720 RVA: 0x000069A8 File Offset: 0x00004BA8
	// (set) Token: 0x06001271 RID: 4721 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001EB")]
	public float LightIntensity
	{
		[Token(Token = "0x6001270")]
		[Address(RVA = "0x31B6C0", Offset = "0x31A8C0", VA = "0x18031B6C0")]
		[CompilerGenerated]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6001271")]
		[Address(RVA = "0x3854F0", Offset = "0x3846F0", VA = "0x1803854F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x170001EC RID: 492
	// (get) Token: 0x06001272 RID: 4722 RVA: 0x000069C0 File Offset: 0x00004BC0
	[Token(Token = "0x170001EC")]
	private float TargetIntensity
	{
		[Token(Token = "0x6001272")]
		[Address(RVA = "0x385440", Offset = "0x384640", VA = "0x180385440")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x170001ED RID: 493
	// (get) Token: 0x06001273 RID: 4723 RVA: 0x000069D8 File Offset: 0x00004BD8
	[Token(Token = "0x170001ED")]
	private float TargetLightIntensity
	{
		[Token(Token = "0x6001273")]
		[Address(RVA = "0x385450", Offset = "0x384650", VA = "0x180385450")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x06001274 RID: 4724 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001274")]
	[Address(RVA = "0x384F60", Offset = "0x384160", VA = "0x180384F60")]
	public void HandleData(ref WeatherData data, Transform cameraTransform)
	{
	}

	// Token: 0x06001275 RID: 4725 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001275")]
	[Address(RVA = "0x3851B0", Offset = "0x3843B0", VA = "0x1803851B0")]
	public void Reset(World world)
	{
	}

	// Token: 0x06001276 RID: 4726 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001276")]
	[Address(RVA = "0x3852C0", Offset = "0x3844C0", VA = "0x1803852C0")]
	public void Update()
	{
	}

	// Token: 0x06001277 RID: 4727 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001277")]
	[Address(RVA = "0x385250", Offset = "0x384450", VA = "0x180385250")]
	private void ReturnWeather()
	{
	}

	// Token: 0x06001278 RID: 4728 RVA: 0x000069F0 File Offset: 0x00004BF0
	[Token(Token = "0x6001278")]
	[Address(RVA = "0x384F20", Offset = "0x384120", VA = "0x180384F20")]
	private float FixedLerp(float a, float b, float val)
	{
		return 0f;
	}

	// Token: 0x04000F1E RID: 3870
	[Token(Token = "0x4000F1E")]
	[FieldOffset(Offset = "0x0")]
	public World World;

	// Token: 0x04000F1F RID: 3871
	[Token(Token = "0x4000F1F")]
	[FieldOffset(Offset = "0x8")]
	private float _intensity;

	// Token: 0x04000F20 RID: 3872
	[Token(Token = "0x4000F20")]
	[FieldOffset(Offset = "0x10")]
	private WeatherEffect _weatherEffect;

	// Token: 0x04000F21 RID: 3873
	[Token(Token = "0x4000F21")]
	[FieldOffset(Offset = "0x18")]
	private WeatherData _weatherData;

	// Token: 0x04000F22 RID: 3874
	[Token(Token = "0x4000F22")]
	[FieldOffset(Offset = "0x1C")]
	private float _intensityStep;

	// Token: 0x04000F23 RID: 3875
	[Token(Token = "0x4000F23")]
	[FieldOffset(Offset = "0x20")]
	private float _lightIntensityStep;
}
