using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Ronin.Model.Data;
using Ronin.Model.Definitions;
using Ronin.Model.Enums;
using Ronin.Model.Files.Animation;
using Ronin.Model.Interfaces;
using UnityEngine;
using Zero.Game.Shared;

// Token: 0x02000293 RID: 659
[Token(Token = "0x2000293")]
public abstract class WorldObject : MonoBehaviour, IAnimatedObject, IDataHandler<SpawnFromData>
{
	// Token: 0x17000189 RID: 393
	// (get) Token: 0x06000DD3 RID: 3539 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x17000189")]
	public string DescriptionOverride
	{
		[Token(Token = "0x6000DD3")]
		[Address(RVA = "0x4633B0", Offset = "0x4625B0", VA = "0x1804633B0")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700018A RID: 394
	// (get) Token: 0x06000DD4 RID: 3540 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x1700018A")]
	public string CurrentTexture
	{
		[Token(Token = "0x6000DD4")]
		[Address(RVA = "0x463330", Offset = "0x462530", VA = "0x180463330")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700018B RID: 395
	// (get) Token: 0x06000DD5 RID: 3541 RVA: 0x0000206A File Offset: 0x0000026A
	// (set) Token: 0x06000DD6 RID: 3542 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700018B")]
	public ObjectDefinition Definition
	{
		[Token(Token = "0x6000DD5")]
		[Address(RVA = "0x4633A0", Offset = "0x4625A0", VA = "0x1804633A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000DD6")]
		[Address(RVA = "0x463570", Offset = "0x462770", VA = "0x180463570")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x1700018C RID: 396
	// (get) Token: 0x06000DD7 RID: 3543 RVA: 0x00005B80 File Offset: 0x00003D80
	[Token(Token = "0x1700018C")]
	public virtual Vec2 HitPosition
	{
		[Token(Token = "0x6000DD7")]
		[Address(RVA = "0x463430", Offset = "0x462630", VA = "0x180463430", Slot = "9")]
		get
		{
			return default(Vec2);
		}
	}

	// Token: 0x1700018D RID: 397
	// (get) Token: 0x06000DD8 RID: 3544 RVA: 0x00005B98 File Offset: 0x00003D98
	// (set) Token: 0x06000DD9 RID: 3545 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700018D")]
	public EntityMasks IdentityMask
	{
		[Token(Token = "0x6000DD8")]
		[Address(RVA = "0x463450", Offset = "0x462650", VA = "0x180463450")]
		[CompilerGenerated]
		get
		{
			return EntityMasks.None;
		}
		[Token(Token = "0x6000DD9")]
		[Address(RVA = "0x463590", Offset = "0x462790", VA = "0x180463590")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	// Token: 0x1700018E RID: 398
	// (get) Token: 0x06000DDA RID: 3546 RVA: 0x00005BB0 File Offset: 0x00003DB0
	[Token(Token = "0x1700018E")]
	public InteractType InteractType
	{
		[Token(Token = "0x6000DDA")]
		[Address(RVA = "0x463460", Offset = "0x462660", VA = "0x180463460")]
		get
		{
			return InteractType.None;
		}
	}

	// Token: 0x1700018F RID: 399
	// (get) Token: 0x06000DDB RID: 3547 RVA: 0x00005BC8 File Offset: 0x00003DC8
	[Token(Token = "0x1700018F")]
	public Vector2 Position
	{
		[Token(Token = "0x6000DDB")]
		[Address(RVA = "0x4634E0", Offset = "0x4626E0", VA = "0x1804634E0", Slot = "10")]
		get
		{
			return default(Vector2);
		}
	}

	// Token: 0x17000190 RID: 400
	// (get) Token: 0x06000DDC RID: 3548 RVA: 0x00005BE0 File Offset: 0x00003DE0
	[Token(Token = "0x17000190")]
	public virtual int Level
	{
		[Token(Token = "0x6000DDC")]
		[Address(RVA = "0x42ADE0", Offset = "0x429FE0", VA = "0x18042ADE0", Slot = "11")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000191 RID: 401
	// (get) Token: 0x06000DDD RID: 3549 RVA: 0x00005BF8 File Offset: 0x00003DF8
	[Token(Token = "0x17000191")]
	public virtual StatusEffects StatusEffects
	{
		[Token(Token = "0x6000DDD")]
		[Address(RVA = "0x3B1FF0", Offset = "0x3B11F0", VA = "0x1803B1FF0", Slot = "12")]
		get
		{
			return StatusEffects.None;
		}
	}

	// Token: 0x17000192 RID: 402
	// (get) Token: 0x06000DDE RID: 3550 RVA: 0x00005C10 File Offset: 0x00003E10
	// (set) Token: 0x06000DDF RID: 3551 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000192")]
	public int TextureIndex
	{
		[Token(Token = "0x6000DDE")]
		[Address(RVA = "0x463550", Offset = "0x462750", VA = "0x180463550")]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000DDF")]
		[Address(RVA = "0x4635E0", Offset = "0x4627E0", VA = "0x1804635E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x17000193 RID: 403
	// (get) Token: 0x06000DE0 RID: 3552
	[Token(Token = "0x17000193")]
	public abstract WorldObjectType Type { [Token(Token = "0x6000DE0")] get; }

	// Token: 0x17000194 RID: 404
	// (get) Token: 0x06000DE1 RID: 3553 RVA: 0x0000206A File Offset: 0x0000026A
	// (set) Token: 0x06000DE2 RID: 3554 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000194")]
	public World World
	{
		[Token(Token = "0x6000DE1")]
		[Address(RVA = "0x35B070", Offset = "0x35A270", VA = "0x18035B070")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000DE2")]
		[Address(RVA = "0x45FC80", Offset = "0x45EE80", VA = "0x18045FC80")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x17000195 RID: 405
	// (get) Token: 0x06000DE3 RID: 3555 RVA: 0x00005C28 File Offset: 0x00003E28
	[Token(Token = "0x17000195")]
	public float SignRadiusSqr
	{
		[Token(Token = "0x6000DE3")]
		[Address(RVA = "0x463520", Offset = "0x462720", VA = "0x180463520")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000196 RID: 406
	// (get) Token: 0x06000DE4 RID: 3556 RVA: 0x00005C40 File Offset: 0x00003E40
	// (set) Token: 0x06000DE5 RID: 3557 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000196")]
	public Vector3 Offset
	{
		[Token(Token = "0x6000DE4")]
		[Address(RVA = "0x4634B0", Offset = "0x4626B0", VA = "0x1804634B0")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000DE5")]
		[Address(RVA = "0x4635A0", Offset = "0x4627A0", VA = "0x1804635A0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	// Token: 0x17000197 RID: 407
	// (get) Token: 0x06000DE6 RID: 3558 RVA: 0x00005C58 File Offset: 0x00003E58
	[Token(Token = "0x17000197")]
	public virtual QuestData Quest
	{
		[Token(Token = "0x6000DE6")]
		[Address(RVA = "0x463500", Offset = "0x462700", VA = "0x180463500", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return default(QuestData);
		}
	}

	// Token: 0x17000198 RID: 408
	// (get) Token: 0x06000DE7 RID: 3559 RVA: 0x0000206A File Offset: 0x0000026A
	// (set) Token: 0x06000DE8 RID: 3560 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000198")]
	private protected IOverride Override
	{
		[Token(Token = "0x6000DE7")]
		[Address(RVA = "0x4634D0", Offset = "0x4626D0", VA = "0x1804634D0")]
		[CompilerGenerated]
		protected get
		{
			return null;
		}
		[Token(Token = "0x6000DE8")]
		[Address(RVA = "0x460C00", Offset = "0x45FE00", VA = "0x180460C00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x17000199 RID: 409
	// (get) Token: 0x06000DE9 RID: 3561 RVA: 0x00005C70 File Offset: 0x00003E70
	[Token(Token = "0x17000199")]
	protected Color TrueDamageColor
	{
		[Token(Token = "0x6000DE9")]
		[Address(RVA = "0x463560", Offset = "0x462760", VA = "0x180463560")]
		get
		{
			return default(Color);
		}
	}

	// Token: 0x1700019A RID: 410
	// (get) Token: 0x06000DEA RID: 3562 RVA: 0x0000206A File Offset: 0x0000026A
	// (set) Token: 0x06000DEB RID: 3563 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700019A")]
	private protected Shadow Shadow
	{
		[Token(Token = "0x6000DEA")]
		[Address(RVA = "0x463510", Offset = "0x462710", VA = "0x180463510")]
		[CompilerGenerated]
		protected get
		{
			return null;
		}
		[Token(Token = "0x6000DEB")]
		[Address(RVA = "0x4635C0", Offset = "0x4627C0", VA = "0x1804635C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x1700019B RID: 411
	// (get) Token: 0x06000DEC RID: 3564 RVA: 0x00005C88 File Offset: 0x00003E88
	[Token(Token = "0x1700019B")]
	private bool IsSign
	{
		[Token(Token = "0x6000DEC")]
		[Address(RVA = "0x463490", Offset = "0x462690", VA = "0x180463490")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000DED RID: 3565 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DED")]
	[Address(RVA = "0x45FC80", Offset = "0x45EE80", VA = "0x18045FC80", Slot = "15")]
	public virtual void AddToWorld(World world)
	{
	}

	// Token: 0x06000DEE RID: 3566 RVA: 0x00005CA0 File Offset: 0x00003EA0
	[Token(Token = "0x6000DEE")]
	[Address(RVA = "0x460070", Offset = "0x45F270", VA = "0x180460070")]
	public float GetRadius()
	{
		return 0f;
	}

	// Token: 0x06000DEF RID: 3567 RVA: 0x00005CB8 File Offset: 0x00003EB8
	[Token(Token = "0x6000DEF")]
	[Address(RVA = "0x4600A0", Offset = "0x45F2A0", VA = "0x1804600A0")]
	public float GetSize()
	{
		return 0f;
	}

	// Token: 0x06000DF0 RID: 3568 RVA: 0x00005CD0 File Offset: 0x00003ED0
	[Token(Token = "0x6000DF0")]
	[Address(RVA = "0x4603A0", Offset = "0x45F5A0", VA = "0x1804603A0", Slot = "16")]
	public virtual int GetStatBase(StatType statType)
	{
		return 0;
	}

	// Token: 0x06000DF1 RID: 3569 RVA: 0x00005CE8 File Offset: 0x00003EE8
	[Token(Token = "0x6000DF1")]
	[Address(RVA = "0x4603E0", Offset = "0x45F5E0", VA = "0x1804603E0", Slot = "17")]
	public virtual int GetStatFunctional(StatType statType)
	{
		return 0;
	}

	// Token: 0x06000DF2 RID: 3570 RVA: 0x00005D00 File Offset: 0x00003F00
	[Token(Token = "0x6000DF2")]
	[Address(RVA = "0x4604B0", Offset = "0x45F6B0", VA = "0x1804604B0")]
	public bool HasFlag(ObjectFlags flags)
	{
		return default(bool);
	}

	// Token: 0x06000DF3 RID: 3571 RVA: 0x00005D18 File Offset: 0x00003F18
	[Token(Token = "0x6000DF3")]
	[Address(RVA = "0x4604D0", Offset = "0x45F6D0", VA = "0x1804604D0", Slot = "18")]
	public virtual int HitBy(Attack attack, Vec2 attackCoordinates, bool fromPlayer)
	{
		return 0;
	}

	// Token: 0x06000DF4 RID: 3572 RVA: 0x00005D30 File Offset: 0x00003F30
	[Token(Token = "0x6000DF4")]
	[Address(RVA = "0x425610", Offset = "0x424810", VA = "0x180425610", Slot = "19")]
	public virtual float GetHeight()
	{
		return 0f;
	}

	// Token: 0x06000DF5 RID: 3573 RVA: 0x00005D48 File Offset: 0x00003F48
	[Token(Token = "0x6000DF5")]
	[Address(RVA = "0x4600D0", Offset = "0x45F2D0", VA = "0x1804600D0", Slot = "20")]
	public virtual float GetSpriteHeightCurrent()
	{
		return 0f;
	}

	// Token: 0x06000DF6 RID: 3574 RVA: 0x00005D60 File Offset: 0x00003F60
	[Token(Token = "0x6000DF6")]
	[Address(RVA = "0x460160", Offset = "0x45F360", VA = "0x180460160", Slot = "21")]
	public virtual float GetSpriteHeightFirst()
	{
		return 0f;
	}

	// Token: 0x06000DF7 RID: 3575 RVA: 0x00005D78 File Offset: 0x00003F78
	[Token(Token = "0x6000DF7")]
	[Address(RVA = "0x4601F0", Offset = "0x45F3F0", VA = "0x1804601F0", Slot = "22")]
	public virtual float GetSpriteHeightStill()
	{
		return 0f;
	}

	// Token: 0x06000DF8 RID: 3576 RVA: 0x00005D90 File Offset: 0x00003F90
	[Token(Token = "0x6000DF8")]
	[Address(RVA = "0x460280", Offset = "0x45F480", VA = "0x180460280", Slot = "23")]
	public virtual float GetSpriteWidthCurrent()
	{
		return 0f;
	}

	// Token: 0x06000DF9 RID: 3577 RVA: 0x00005DA8 File Offset: 0x00003FA8
	[Token(Token = "0x6000DF9")]
	[Address(RVA = "0x460310", Offset = "0x45F510", VA = "0x180460310", Slot = "24")]
	public virtual float GetSpriteWidthStill()
	{
		return 0f;
	}

	// Token: 0x06000DFA RID: 3578 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DFA")]
	[Address(RVA = "0x460400", Offset = "0x45F600", VA = "0x180460400", Slot = "8")]
	public void HandleData(ref SpawnFromData data)
	{
	}

	// Token: 0x06000DFB RID: 3579 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DFB")]
	[Address(RVA = "0x460C20", Offset = "0x45FE20", VA = "0x180460C20", Slot = "25")]
	public virtual void Load(ObjectDefinition definition)
	{
	}

	// Token: 0x06000DFC RID: 3580 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DFC")]
	[Address(RVA = "0x460C00", Offset = "0x45FE00", VA = "0x180460C00")]
	public void LoadOverride(IOverride @override)
	{
	}

	// Token: 0x06000DFD RID: 3581 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DFD")]
	[Address(RVA = "0x461130", Offset = "0x460330", VA = "0x180461130", Slot = "26")]
	public virtual void RemoveFromWorld()
	{
	}

	// Token: 0x06000DFE RID: 3582 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DFE")]
	[Address(RVA = "0x4612A0", Offset = "0x4604A0", VA = "0x1804612A0")]
	public void SetPosition(Vector2 value)
	{
	}

	// Token: 0x06000DFF RID: 3583 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DFF")]
	[Address(RVA = "0x4614D0", Offset = "0x4606D0", VA = "0x1804614D0")]
	public void SetTextureIndex(int index)
	{
	}

	// Token: 0x06000E00 RID: 3584 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E00")]
	[Address(RVA = "0x4616C0", Offset = "0x4608C0", VA = "0x1804616C0", Slot = "27")]
	public virtual void ShowChatBubble(string message, float lifetime, ChatType? chatType)
	{
	}

	// Token: 0x06000E01 RID: 3585 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E01")]
	[Address(RVA = "0x461920", Offset = "0x460B20", VA = "0x180461920", Slot = "28")]
	public virtual void Unload()
	{
	}

	// Token: 0x06000E02 RID: 3586 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E02")]
	[Address(RVA = "0x4631A0", Offset = "0x4623A0", VA = "0x1804631A0")]
	public void WorldMessage(string message, Color color, [Optional] SfxClip sfx, [Optional] Vector3 offset, bool important = true)
	{
	}

	// Token: 0x06000E03 RID: 3587 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E03")]
	[Address(RVA = "0x463160", Offset = "0x462360", VA = "0x180463160")]
	public void WorldMessage(WorldMessageDescription description)
	{
	}

	// Token: 0x06000E04 RID: 3588 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E04")]
	[Address(RVA = "0x4629F0", Offset = "0x461BF0", VA = "0x1804629F0")]
	public void WorldMessageArmorDamage(int damage, bool fromPlayer, bool isPlayer)
	{
	}

	// Token: 0x06000E05 RID: 3589 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E05")]
	[Address(RVA = "0x462C60", Offset = "0x461E60", VA = "0x180462C60", Slot = "29")]
	public virtual void WorldMessageDamage(int damage, bool fromPlayer, bool isPlayer, bool trueDamage, bool criticalStrike)
	{
	}

	// Token: 0x06000E06 RID: 3590 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E06")]
	[Address(RVA = "0x463010", Offset = "0x462210", VA = "0x180463010")]
	public void WorldMessageQueued(string message, Color color, [Optional] SfxClip sfx, [Optional] Vector3 offset, bool important = true)
	{
	}

	// Token: 0x06000E07 RID: 3591 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E07")]
	[Address(RVA = "0x462F70", Offset = "0x462170", VA = "0x180462F70")]
	public void WorldMessageQueued(WorldMessageDescription description)
	{
	}

	// Token: 0x06000E08 RID: 3592 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E08")]
	[Address(RVA = "0x45FCA0", Offset = "0x45EEA0", VA = "0x18045FCA0", Slot = "30")]
	protected virtual void Awake()
	{
	}

	// Token: 0x06000E09 RID: 3593 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000E09")]
	[Address(RVA = "0x45FF30", Offset = "0x45F130", VA = "0x18045FF30", Slot = "31")]
	protected virtual AnimationSwitch GetAnimationForIndex(int index)
	{
		return null;
	}

	// Token: 0x06000E0A RID: 3594 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E0A")]
	[Address(RVA = "0x4610A0", Offset = "0x4602A0", VA = "0x1804610A0", Slot = "32")]
	protected virtual void OnEnable()
	{
	}

	// Token: 0x06000E0B RID: 3595 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E0B")]
	[Address(RVA = "0x4610C0", Offset = "0x4602C0", VA = "0x1804610C0")]
	protected void PlayHitSfx(bool isPlayer)
	{
	}

	// Token: 0x06000E0C RID: 3596 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E0C")]
	[Address(RVA = "0x461270", Offset = "0x460470", VA = "0x180461270")]
	protected void ReturnLight()
	{
	}

	// Token: 0x06000E0D RID: 3597 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E0D")]
	[Address(RVA = "0x353100", Offset = "0x352300", VA = "0x180353100", Slot = "33")]
	protected virtual void SetCurrentGround(GroundDefinition groundDefinition)
	{
	}

	// Token: 0x06000E0E RID: 3598 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E0E")]
	[Address(RVA = "0x461580", Offset = "0x460780", VA = "0x180461580", Slot = "34")]
	protected virtual void SetTransformPosition(Vector3 position)
	{
	}

	// Token: 0x06000E0F RID: 3599 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E0F")]
	[Address(RVA = "0x462730", Offset = "0x461930", VA = "0x180462730", Slot = "35")]
	protected virtual void Update()
	{
	}

	// Token: 0x06000E10 RID: 3600 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E10")]
	[Address(RVA = "0x462600", Offset = "0x461800", VA = "0x180462600")]
	protected void UpdateTexture()
	{
	}

	// Token: 0x06000E11 RID: 3601 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000E11")]
	[Address(RVA = "0x45FD00", Offset = "0x45EF00", VA = "0x18045FD00")]
	private WorldMessage CreateWorldMessage(WorldMessageDescription description, [Optional] WorldMessage reuse)
	{
		return null;
	}

	// Token: 0x06000E12 RID: 3602 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E12")]
	[Address(RVA = "0x461A10", Offset = "0x460C10", VA = "0x180461A10")]
	private void UpdateCurrentGround(Vector2 position)
	{
	}

	// Token: 0x06000E13 RID: 3603 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E13")]
	[Address(RVA = "0x461BA0", Offset = "0x460DA0", VA = "0x180461BA0")]
	private void UpdateMessages()
	{
	}

	// Token: 0x06000E14 RID: 3604 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E14")]
	[Address(RVA = "0x461D30", Offset = "0x460F30", VA = "0x180461D30")]
	private void UpdateOnNearby()
	{
	}

	// Token: 0x06000E15 RID: 3605 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E15")]
	[Address(RVA = "0x462560", Offset = "0x461760", VA = "0x180462560")]
	private void UpdateSpawnFrom()
	{
	}

	// Token: 0x06000E16 RID: 3606 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E16")]
	[Address(RVA = "0x4626A0", Offset = "0x4618A0", VA = "0x1804626A0")]
	private void UpdateTransformPosition()
	{
	}

	// Token: 0x06000E17 RID: 3607 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E17")]
	[Address(RVA = "0x460640", Offset = "0x45F840", VA = "0x180460640", Slot = "4")]
	private void SetColor(Color color)
	{
	}

	// Token: 0x06000E18 RID: 3608 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E18")]
	[Address(RVA = "0x4608B0", Offset = "0x45FAB0", VA = "0x1804608B0", Slot = "5")]
	private void SetLayer(int layer)
	{
	}

	// Token: 0x06000E19 RID: 3609 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E19")]
	[Address(RVA = "0x4609C0", Offset = "0x45FBC0", VA = "0x1804609C0", Slot = "6")]
	private void SetSprite(AnimationFrame frame)
	{
	}

	// Token: 0x06000E1A RID: 3610 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E1A")]
	[Address(RVA = "0x460750", Offset = "0x45F950", VA = "0x180460750", Slot = "7")]
	private void SetFlipped(bool value)
	{
	}

	// Token: 0x06000E1B RID: 3611 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E1B")]
	[Address(RVA = "0x463290", Offset = "0x462490", VA = "0x180463290")]
	protected WorldObject()
	{
	}

	// Token: 0x06000E1C RID: 3612 RVA: 0x00005DC0 File Offset: 0x00003FC0
	[Token(Token = "0x6000E1C")]
	[Address(RVA = "0x461810", Offset = "0x460A10", VA = "0x180461810")]
	[CompilerGenerated]
	internal static bool <UpdateMessages>g__messageUsedBy|113_0(WorldMessage message, Transform transform)
	{
		return default(bool);
	}

	// Token: 0x04000B49 RID: 2889
	[Token(Token = "0x4000B49")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public AnimationRunner Animation;

	// Token: 0x04000B4A RID: 2890
	[Token(Token = "0x4000B4A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool Targeted;

	// Token: 0x04000B4B RID: 2891
	[Token(Token = "0x4000B4B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Component AnimationTarget;

	// Token: 0x04000B4C RID: 2892
	[Token(Token = "0x4000B4C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected ChatBubble ChatBubble;

	// Token: 0x04000B4D RID: 2893
	[Token(Token = "0x4000B4D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Vector2 _position;

	// Token: 0x04000B4E RID: 2894
	[Token(Token = "0x4000B4E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private GroundDefinition _currentGround;

	// Token: 0x04000B4F RID: 2895
	[Token(Token = "0x4000B4F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Tooltip _tooltip;

	// Token: 0x04000B50 RID: 2896
	[Token(Token = "0x4000B50")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private QuestData _tooltipQuest;

	// Token: 0x04000B51 RID: 2897
	[Token(Token = "0x4000B51")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Option _damageTotalOption;

	// Token: 0x04000B52 RID: 2898
	[Token(Token = "0x4000B52")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private WorldMessage _damageMessage;

	// Token: 0x04000B53 RID: 2899
	[Token(Token = "0x4000B53")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private int _playerDamageFrame;

	// Token: 0x04000B54 RID: 2900
	[Token(Token = "0x4000B54")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private int _playerDamageTotal;

	// Token: 0x04000B55 RID: 2901
	[Token(Token = "0x4000B55")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private global::Light _light;

	// Token: 0x04000B56 RID: 2902
	[Token(Token = "0x4000B56")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private SfxClip _sfx;

	// Token: 0x04000B57 RID: 2903
	[Token(Token = "0x4000B57")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Queue<WorldMessageDescription> _messageQueue;

	// Token: 0x04000B58 RID: 2904
	[Token(Token = "0x4000B58")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private WorldMessage _queueMessage;

	// Token: 0x04000B59 RID: 2905
	[Token(Token = "0x4000B59")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private float _lastAllyDamageNumberArmor;

	// Token: 0x04000B5A RID: 2906
	[Token(Token = "0x4000B5A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private float _lastAllyDamageNumber;

	// Token: 0x04000B5B RID: 2907
	[Token(Token = "0x4000B5B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public IAnimatedObject _animationTarget;

	// Token: 0x04000B5C RID: 2908
	[Token(Token = "0x4000B5C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private float _spawnFrom;

	// Token: 0x04000B5D RID: 2909
	[Token(Token = "0x4000B5D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	private float _spawnFromLerp;

	// Token: 0x04000B5E RID: 2910
	[Token(Token = "0x4000B5E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	protected bool ApplySink;
}
