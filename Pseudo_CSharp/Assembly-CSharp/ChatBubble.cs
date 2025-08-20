using System;
using System.Threading.Tasks;
using AnimateInternal;
using Il2CppDummyDll;
using Ronin.Model.Enums;
using TMPro;
using UnityEngine;

// Token: 0x020001E4 RID: 484
[Token(Token = "0x20001E4")]
public class ChatBubble : MonoBehaviour
{
	// Token: 0x170000F3 RID: 243
	// (get) Token: 0x060009DE RID: 2526 RVA: 0x00004878 File Offset: 0x00002A78
	[Token(Token = "0x170000F3")]
	public float StartTime
	{
		[Token(Token = "0x60009DE")]
		[Address(RVA = "0x4239A0", Offset = "0x422BA0", VA = "0x1804239A0")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x060009DF RID: 2527 RVA: 0x00004890 File Offset: 0x00002A90
	[Token(Token = "0x60009DF")]
	[Address(RVA = "0x422A10", Offset = "0x421C10", VA = "0x180422A10")]
	public static float GetScaledMessageLifetime(string message)
	{
		return 0f;
	}

	// Token: 0x060009E0 RID: 2528 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009E0")]
	[Address(RVA = "0x422740", Offset = "0x421940", VA = "0x180422740")]
	public void Close()
	{
	}

	// Token: 0x060009E1 RID: 2529 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60009E1")]
	[Address(RVA = "0x422740", Offset = "0x421940", VA = "0x180422740")]
	public Task CloseAsync()
	{
		return null;
	}

	// Token: 0x060009E2 RID: 2530 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009E2")]
	[Address(RVA = "0x422D80", Offset = "0x421F80", VA = "0x180422D80")]
	public void SetOpacity(float opacity)
	{
	}

	// Token: 0x060009E3 RID: 2531 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009E3")]
	[Address(RVA = "0x4231D0", Offset = "0x4223D0", VA = "0x1804231D0")]
	public void Setup(WorldObject worldObject, string message, EntityMasks entityMasks, float lifetime, ChatType? chatType, InteractType interactType)
	{
	}

	// Token: 0x060009E4 RID: 2532 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009E4")]
	[Address(RVA = "0x422E90", Offset = "0x422090", VA = "0x180422E90")]
	private void SetupButton(InteractType interactType)
	{
	}

	// Token: 0x060009E5 RID: 2533 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009E5")]
	[Address(RVA = "0x423820", Offset = "0x422A20", VA = "0x180423820")]
	private void UpdateOffset()
	{
	}

	// Token: 0x060009E6 RID: 2534 RVA: 0x000048A8 File Offset: 0x00002AA8
	[Token(Token = "0x60009E6")]
	[Address(RVA = "0x422AF0", Offset = "0x421CF0", VA = "0x180422AF0")]
	public bool IsExpired()
	{
		return default(bool);
	}

	// Token: 0x060009E7 RID: 2535 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009E7")]
	[Address(RVA = "0x422550", Offset = "0x421750", VA = "0x180422550")]
	private void Awake()
	{
	}

	// Token: 0x060009E8 RID: 2536 RVA: 0x000048C0 File Offset: 0x00002AC0
	[Token(Token = "0x60009E8")]
	[Address(RVA = "0x422810", Offset = "0x421A10", VA = "0x180422810")]
	private ChatBubble.BubbleConfig GetBubbleConfig(EntityMasks entityMasks)
	{
		return default(ChatBubble.BubbleConfig);
	}

	// Token: 0x060009E9 RID: 2537 RVA: 0x000048D8 File Offset: 0x00002AD8
	[Token(Token = "0x60009E9")]
	[Address(RVA = "0x4229C0", Offset = "0x421BC0", VA = "0x1804229C0")]
	private Vector3 GetObjectOffset(WorldObject worldObject)
	{
		return default(Vector3);
	}

	// Token: 0x060009EA RID: 2538 RVA: 0x000048F0 File Offset: 0x00002AF0
	[Token(Token = "0x60009EA")]
	[Address(RVA = "0x422900", Offset = "0x421B00", VA = "0x180422900")]
	private float GetBubbleScale()
	{
		return 0f;
	}

	// Token: 0x060009EB RID: 2539 RVA: 0x00004908 File Offset: 0x00002B08
	[Token(Token = "0x60009EB")]
	[Address(RVA = "0x422A60", Offset = "0x421C60", VA = "0x180422A60")]
	private bool IsActive()
	{
		return default(bool);
	}

	// Token: 0x060009EC RID: 2540 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009EC")]
	[Address(RVA = "0x422B20", Offset = "0x421D20", VA = "0x180422B20")]
	private void LateUpdate()
	{
	}

	// Token: 0x060009ED RID: 2541 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009ED")]
	[Address(RVA = "0x422B30", Offset = "0x421D30", VA = "0x180422B30")]
	private void OnChatBubbleScaleChanged(Option option)
	{
	}

	// Token: 0x060009EE RID: 2542 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009EE")]
	[Address(RVA = "0x422BC0", Offset = "0x421DC0", VA = "0x180422BC0")]
	private void OnDestroy()
	{
	}

	// Token: 0x060009EF RID: 2543 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009EF")]
	[Address(RVA = "0x422D40", Offset = "0x421F40", VA = "0x180422D40")]
	private void OnDisable()
	{
	}

	// Token: 0x060009F0 RID: 2544 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009F0")]
	[Address(RVA = "0x4235E0", Offset = "0x4227E0", VA = "0x1804235E0")]
	private void SizeBubble()
	{
	}

	// Token: 0x060009F1 RID: 2545 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009F1")]
	[Address(RVA = "0x423970", Offset = "0x422B70", VA = "0x180423970")]
	public ChatBubble()
	{
	}

	// Token: 0x0400091E RID: 2334
	[Token(Token = "0x400091E")]
	public const int MedianMessageLength = 26;

	// Token: 0x0400091F RID: 2335
	[Token(Token = "0x400091F")]
	public const float DefaultLifetime = 10f;

	// Token: 0x04000920 RID: 2336
	[Token(Token = "0x4000920")]
	public const float ForeverLifetime = 1E+10f;

	// Token: 0x04000921 RID: 2337
	[Token(Token = "0x4000921")]
	public const float QuickLifetime = 2f;

	// Token: 0x04000922 RID: 2338
	[Token(Token = "0x4000922")]
	[FieldOffset(Offset = "0x20")]
	public Follow Follow;

	// Token: 0x04000923 RID: 2339
	[Token(Token = "0x4000923")]
	[FieldOffset(Offset = "0x28")]
	public TextMeshPro MessageLabel;

	// Token: 0x04000924 RID: 2340
	[Token(Token = "0x4000924")]
	[FieldOffset(Offset = "0x30")]
	public SpriteRenderer SpriteRenderer;

	// Token: 0x04000925 RID: 2341
	[Token(Token = "0x4000925")]
	[FieldOffset(Offset = "0x38")]
	public float Lifetime;

	// Token: 0x04000926 RID: 2342
	[Token(Token = "0x4000926")]
	[FieldOffset(Offset = "0x40")]
	public WorldButton Button;

	// Token: 0x04000927 RID: 2343
	[Token(Token = "0x4000927")]
	[FieldOffset(Offset = "0x48")]
	public Vector3 Offset;

	// Token: 0x04000928 RID: 2344
	[Token(Token = "0x4000928")]
	[FieldOffset(Offset = "0x58")]
	public ChatBubble.BubbleConfig[] Configs;

	// Token: 0x04000929 RID: 2345
	[Token(Token = "0x4000929")]
	[FieldOffset(Offset = "0x60")]
	private float _time;

	// Token: 0x0400092A RID: 2346
	[Token(Token = "0x400092A")]
	[FieldOffset(Offset = "0x68")]
	private AnimateTask _scaleTask;

	// Token: 0x0400092B RID: 2347
	[Token(Token = "0x400092B")]
	[FieldOffset(Offset = "0x70")]
	private bool _destroyed;

	// Token: 0x0400092C RID: 2348
	[Token(Token = "0x400092C")]
	[FieldOffset(Offset = "0x71")]
	private ChatType? _chatType;

	// Token: 0x0400092D RID: 2349
	[Token(Token = "0x400092D")]
	[FieldOffset(Offset = "0x78")]
	private ChatBubble.BubbleConfig _config;

	// Token: 0x0400092E RID: 2350
	[Token(Token = "0x400092E")]
	[FieldOffset(Offset = "0xB0")]
	private WorldObject _worldObject;

	// Token: 0x0400092F RID: 2351
	[Token(Token = "0x400092F")]
	[FieldOffset(Offset = "0xB8")]
	private InteractType _interactType;

	// Token: 0x04000930 RID: 2352
	[Token(Token = "0x4000930")]
	[FieldOffset(Offset = "0xBC")]
	private bool _alwaysFront;

	// Token: 0x04000931 RID: 2353
	[Token(Token = "0x4000931")]
	[FieldOffset(Offset = "0xC0")]
	private Option _chatBubbleScaleOption;

	// Token: 0x04000932 RID: 2354
	[Token(Token = "0x4000932")]
	[FieldOffset(Offset = "0xC8")]
	private Option _playerChatBubblesOption;

	// Token: 0x04000933 RID: 2355
	[Token(Token = "0x4000933")]
	[FieldOffset(Offset = "0xD0")]
	private Option _npcChatBubblesOption;

	// Token: 0x04000934 RID: 2356
	[Token(Token = "0x4000934")]
	[FieldOffset(Offset = "0xD8")]
	private Option _enemyChatBubblesOption;

	// Token: 0x020001E5 RID: 485
	[Token(Token = "0x20001E5")]
	[Serializable]
	public struct BubbleConfig
	{
		// Token: 0x04000935 RID: 2357
		[Token(Token = "0x4000935")]
		[FieldOffset(Offset = "0x0")]
		public EntityMasks HitMask;

		// Token: 0x04000936 RID: 2358
		[Token(Token = "0x4000936")]
		[FieldOffset(Offset = "0x8")]
		public Sprite Sprite;

		// Token: 0x04000937 RID: 2359
		[Token(Token = "0x4000937")]
		[FieldOffset(Offset = "0x10")]
		public Color TextColor;

		// Token: 0x04000938 RID: 2360
		[Token(Token = "0x4000938")]
		[FieldOffset(Offset = "0x20")]
		public Color ContainerColor;

		// Token: 0x04000939 RID: 2361
		[Token(Token = "0x4000939")]
		[FieldOffset(Offset = "0x30")]
		public bool RichText;
	}
}
