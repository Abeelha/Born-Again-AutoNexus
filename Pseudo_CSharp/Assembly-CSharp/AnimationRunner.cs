using System;
using Il2CppDummyDll;
using Ronin.Model.Files.Animation;
using UnityEngine;

// Token: 0x0200001A RID: 26
[Token(Token = "0x200001A")]
public class AnimationRunner : MonoBehaviour
{
	// Token: 0x1700000A RID: 10
	// (get) Token: 0x06000091 RID: 145 RVA: 0x00002358 File Offset: 0x00000558
	[Token(Token = "0x1700000A")]
	public bool Flipped
	{
		[Token(Token = "0x6000091")]
		[Address(RVA = "0x31A180", Offset = "0x319380", VA = "0x18031A180")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700000B RID: 11
	// (get) Token: 0x06000092 RID: 146 RVA: 0x00002370 File Offset: 0x00000570
	[Token(Token = "0x1700000B")]
	public bool CurrentNoHands
	{
		[Token(Token = "0x6000092")]
		[Address(RVA = "0x31A160", Offset = "0x319360", VA = "0x18031A160")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700000C RID: 12
	// (get) Token: 0x06000093 RID: 147 RVA: 0x00002388 File Offset: 0x00000588
	[Token(Token = "0x1700000C")]
	public bool InGesture
	{
		[Token(Token = "0x6000093")]
		[Address(RVA = "0x31A190", Offset = "0x319390", VA = "0x18031A190")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000094 RID: 148 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000094")]
	[Address(RVA = "0x3184C0", Offset = "0x3176C0", VA = "0x1803184C0")]
	public void Clear()
	{
	}

	// Token: 0x06000095 RID: 149 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000095")]
	[Address(RVA = "0x3184F0", Offset = "0x3176F0", VA = "0x1803184F0")]
	public void ForceUpdateSprite()
	{
	}

	// Token: 0x06000096 RID: 150 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000096")]
	[Address(RVA = "0x3187E0", Offset = "0x3179E0", VA = "0x1803187E0")]
	public Sprite GetCurrentSprite()
	{
		return null;
	}

	// Token: 0x06000097 RID: 151 RVA: 0x000023A0 File Offset: 0x000005A0
	[Token(Token = "0x6000097")]
	[Address(RVA = "0x3188F0", Offset = "0x317AF0", VA = "0x1803188F0")]
	public float GetSpriteHeightCurrent()
	{
		return 0f;
	}

	// Token: 0x06000098 RID: 152 RVA: 0x000023B8 File Offset: 0x000005B8
	[Token(Token = "0x6000098")]
	[Address(RVA = "0x318C00", Offset = "0x317E00", VA = "0x180318C00")]
	public float GetSpriteWidthCurrent()
	{
		return 0f;
	}

	// Token: 0x06000099 RID: 153 RVA: 0x000023D0 File Offset: 0x000005D0
	[Token(Token = "0x6000099")]
	[Address(RVA = "0x3189D0", Offset = "0x317BD0", VA = "0x1803189D0")]
	public float GetSpriteHeightFirst()
	{
		return 0f;
	}

	// Token: 0x0600009A RID: 154 RVA: 0x000023E8 File Offset: 0x000005E8
	[Token(Token = "0x600009A")]
	[Address(RVA = "0x318AF0", Offset = "0x317CF0", VA = "0x180318AF0")]
	public float GetSpriteHeightStill()
	{
		return 0f;
	}

	// Token: 0x0600009B RID: 155 RVA: 0x00002400 File Offset: 0x00000600
	[Token(Token = "0x600009B")]
	[Address(RVA = "0x318CC0", Offset = "0x317EC0", VA = "0x180318CC0")]
	public float GetSpriteWidthStill()
	{
		return 0f;
	}

	// Token: 0x0600009C RID: 156 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600009C")]
	[Address(RVA = "0x319160", Offset = "0x318360", VA = "0x180319160")]
	public void Randomize()
	{
	}

	// Token: 0x0600009D RID: 157 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600009D")]
	[Address(RVA = "0x319130", Offset = "0x318330", VA = "0x180319130")]
	public void PlayGesture(AnimationLoop loop)
	{
	}

	// Token: 0x0600009E RID: 158 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600009E")]
	[Address(RVA = "0x3191D0", Offset = "0x3183D0", VA = "0x1803191D0")]
	public void SetAttackIndex(int index, float angle, float attackSpeed)
	{
	}

	// Token: 0x0600009F RID: 159 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600009F")]
	[Address(RVA = "0x3193D0", Offset = "0x3185D0", VA = "0x1803193D0")]
	public void SetColor(Color flashColor, float flashIntensity, float alpha, Color outlineColor)
	{
	}

	// Token: 0x060000A0 RID: 160 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x3192A0", Offset = "0x3184A0", VA = "0x1803192A0")]
	public void SetColor(Color color)
	{
	}

	// Token: 0x060000A1 RID: 161 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x319470", Offset = "0x318670", VA = "0x180319470")]
	public void SetColors(Color flashColor, float flashIntensity, Color outlineColor)
	{
	}

	// Token: 0x060000A2 RID: 162 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x3194F0", Offset = "0x3186F0", VA = "0x1803194F0")]
	public void SetDead(bool dying, bool dead)
	{
	}

	// Token: 0x060000A3 RID: 163 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x319500", Offset = "0x318700", VA = "0x180319500")]
	public void SetDead(bool dying)
	{
	}

	// Token: 0x060000A4 RID: 164 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x319510", Offset = "0x318710", VA = "0x180319510")]
	public void SetFlipped(bool flipped)
	{
	}

	// Token: 0x060000A5 RID: 165 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x319520", Offset = "0x318720", VA = "0x180319520")]
	public void SetLayer(int layer)
	{
	}

	// Token: 0x060000A6 RID: 166 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x319640", Offset = "0x318840", VA = "0x180319640")]
	public void SetOtherIndex(int index)
	{
	}

	// Token: 0x060000A7 RID: 167 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x3196C0", Offset = "0x3188C0", VA = "0x1803196C0")]
	public void SetSwitch(AnimationSwitch @switch)
	{
	}

	// Token: 0x060000A8 RID: 168 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x3197D0", Offset = "0x3189D0", VA = "0x1803197D0")]
	private void UpdateAnimation()
	{
	}

	// Token: 0x060000A9 RID: 169 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x318440", Offset = "0x317640", VA = "0x180318440")]
	private void Awake()
	{
	}

	// Token: 0x060000AA RID: 170 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x318F70", Offset = "0x318170", VA = "0x180318F70")]
	private void LateUpdate()
	{
	}

	// Token: 0x060000AB RID: 171 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x318500", Offset = "0x317700", VA = "0x180318500")]
	private AnimationFrame GetCurrentFrame()
	{
		return null;
	}

	// Token: 0x060000AC RID: 172 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x318550", Offset = "0x317750", VA = "0x180318550")]
	private AnimationLoop GetCurrentLoop()
	{
		return null;
	}

	// Token: 0x060000AD RID: 173 RVA: 0x00002418 File Offset: 0x00000618
	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x318860", Offset = "0x317A60", VA = "0x180318860")]
	private float GetFrameDuration()
	{
		return 0f;
	}

	// Token: 0x060000AE RID: 174 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x318DB0", Offset = "0x317FB0", VA = "0x180318DB0")]
	private IAnimatedObject GetTarget()
	{
		return null;
	}

	// Token: 0x060000AF RID: 175 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x318E10", Offset = "0x318010", VA = "0x180318E10")]
	private void IncrementFrame()
	{
	}

	// Token: 0x060000B0 RID: 176 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x319110", Offset = "0x318310", VA = "0x180319110")]
	private void OnEnable()
	{
	}

	// Token: 0x060000B1 RID: 177 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x319970", Offset = "0x318B70", VA = "0x180319970")]
	private void UpdatePosition()
	{
	}

	// Token: 0x060000B2 RID: 178 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x319B00", Offset = "0x318D00", VA = "0x180319B00")]
	private void UpdateSprite()
	{
	}

	// Token: 0x060000B3 RID: 179 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x319D40", Offset = "0x318F40", VA = "0x180319D40")]
	private void UpdateState()
	{
	}

	// Token: 0x060000B4 RID: 180 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x31A140", Offset = "0x319340", VA = "0x18031A140")]
	public AnimationRunner()
	{
	}

	// Token: 0x04000070 RID: 112
	[Token(Token = "0x4000070")]
	[FieldOffset(Offset = "0x20")]
	public AnimationSwitch Switch;

	// Token: 0x04000071 RID: 113
	[Token(Token = "0x4000071")]
	[FieldOffset(Offset = "0x28")]
	public bool StateEnabled;

	// Token: 0x04000072 RID: 114
	[Token(Token = "0x4000072")]
	[FieldOffset(Offset = "0x29")]
	public bool SpeedEnabled;

	// Token: 0x04000073 RID: 115
	[Token(Token = "0x4000073")]
	[FieldOffset(Offset = "0x30")]
	public Component DefaultTarget;

	// Token: 0x04000074 RID: 116
	[Token(Token = "0x4000074")]
	[FieldOffset(Offset = "0x38")]
	public bool AutoFlip;

	// Token: 0x04000075 RID: 117
	[Token(Token = "0x4000075")]
	[FieldOffset(Offset = "0x39")]
	public bool AttackAutoFlip;

	// Token: 0x04000076 RID: 118
	[Token(Token = "0x4000076")]
	[FieldOffset(Offset = "0x3A")]
	public bool Equipped;

	// Token: 0x04000077 RID: 119
	[Token(Token = "0x4000077")]
	[FieldOffset(Offset = "0x3B")]
	public bool NoHands;

	// Token: 0x04000078 RID: 120
	[Token(Token = "0x4000078")]
	[FieldOffset(Offset = "0x40")]
	private IAnimatedObject _target;

	// Token: 0x04000079 RID: 121
	[Token(Token = "0x4000079")]
	[FieldOffset(Offset = "0x48")]
	private bool _dead;

	// Token: 0x0400007A RID: 122
	[Token(Token = "0x400007A")]
	[FieldOffset(Offset = "0x49")]
	private bool _gotoLast;

	// Token: 0x0400007B RID: 123
	[Token(Token = "0x400007B")]
	[FieldOffset(Offset = "0x4A")]
	private bool _running;

	// Token: 0x0400007C RID: 124
	[Token(Token = "0x400007C")]
	[FieldOffset(Offset = "0x4B")]
	private bool _flipped;

	// Token: 0x0400007D RID: 125
	[Token(Token = "0x400007D")]
	[FieldOffset(Offset = "0x4C")]
	private bool _setFlipped;

	// Token: 0x0400007E RID: 126
	[Token(Token = "0x400007E")]
	[FieldOffset(Offset = "0x50")]
	private float _attackAngle;

	// Token: 0x0400007F RID: 127
	[Token(Token = "0x400007F")]
	[FieldOffset(Offset = "0x54")]
	private float _attackSpeed;

	// Token: 0x04000080 RID: 128
	[Token(Token = "0x4000080")]
	[FieldOffset(Offset = "0x58")]
	private int _loopCount;

	// Token: 0x04000081 RID: 129
	[Token(Token = "0x4000081")]
	[FieldOffset(Offset = "0x5C")]
	private bool _gestureFlipped;

	// Token: 0x04000082 RID: 130
	[Token(Token = "0x4000082")]
	[FieldOffset(Offset = "0x60")]
	private int _attackIndex;

	// Token: 0x04000083 RID: 131
	[Token(Token = "0x4000083")]
	[FieldOffset(Offset = "0x64")]
	private int _otherIndex;

	// Token: 0x04000084 RID: 132
	[Token(Token = "0x4000084")]
	[FieldOffset(Offset = "0x68")]
	private float _frameTime;

	// Token: 0x04000085 RID: 133
	[Token(Token = "0x4000085")]
	[FieldOffset(Offset = "0x6C")]
	private int _frameIndex;

	// Token: 0x04000086 RID: 134
	[Token(Token = "0x4000086")]
	[FieldOffset(Offset = "0x70")]
	private float _movementSpeed;

	// Token: 0x04000087 RID: 135
	[Token(Token = "0x4000087")]
	[FieldOffset(Offset = "0x74")]
	private Vector2 _movementDelta;

	// Token: 0x04000088 RID: 136
	[Token(Token = "0x4000088")]
	[FieldOffset(Offset = "0x7C")]
	private Vector2 _lastPosition;

	// Token: 0x04000089 RID: 137
	[Token(Token = "0x4000089")]
	[FieldOffset(Offset = "0x88")]
	private AnimationLoop _currentLoop;

	// Token: 0x0400008A RID: 138
	[Token(Token = "0x400008A")]
	[FieldOffset(Offset = "0x90")]
	private int _currentGestureId;

	// Token: 0x0400008B RID: 139
	[Token(Token = "0x400008B")]
	[FieldOffset(Offset = "0x98")]
	private AnimationLoop _gestureLoop;

	// Token: 0x0400008C RID: 140
	[Token(Token = "0x400008C")]
	[FieldOffset(Offset = "0xA0")]
	private int _gestureId;

	// Token: 0x0400008D RID: 141
	[Token(Token = "0x400008D")]
	[FieldOffset(Offset = "0xA8")]
	private AnimationFrame _currentFrame;

	// Token: 0x0400008E RID: 142
	[Token(Token = "0x400008E")]
	[FieldOffset(Offset = "0xB0")]
	private AnimationFrame _setFrame;
}
