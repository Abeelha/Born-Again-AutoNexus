using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using Ronin.Model.Classes;
using Ronin.Model.Data;
using Ronin.Model.Definitions;
using Ronin.Model.Enums;
using Ronin.Model.Files.Map;
using Ronin.Model.Files.Map.Chunks;
using Ronin.Model.Merchant;
using Ronin.Model.Simulation;
using Ronin.Model.Simulation.Interfaces;
using Ronin.Model.Structs;
using UnityEngine;
using Zero.Game.Shared;

// Token: 0x02000344 RID: 836
[Token(Token = "0x2000344")]
public class World : MonoBehaviour, ISimulationBridge
{
	// Token: 0x170001EE RID: 494
	// (get) Token: 0x06001279 RID: 4729 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x170001EE")]
	public IEnumerable<Character> Characters
	{
		[Token(Token = "0x6001279")]
		[Address(RVA = "0x392000", Offset = "0x391200", VA = "0x180392000")]
		get
		{
			return null;
		}
	}

	// Token: 0x170001EF RID: 495
	// (get) Token: 0x0600127A RID: 4730 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x170001EF")]
	public IEnumerable<Tutorial> Tutorials
	{
		[Token(Token = "0x600127A")]
		[Address(RVA = "0x3922F0", Offset = "0x3914F0", VA = "0x1803922F0")]
		get
		{
			return null;
		}
	}

	// Token: 0x170001F0 RID: 496
	// (get) Token: 0x0600127B RID: 4731 RVA: 0x00006A08 File Offset: 0x00004C08
	[Token(Token = "0x170001F0")]
	public uint Delta
	{
		[Token(Token = "0x600127B")]
		[Address(RVA = "0x392220", Offset = "0x391420", VA = "0x180392220")]
		get
		{
			return 0U;
		}
	}

	// Token: 0x170001F1 RID: 497
	// (get) Token: 0x0600127C RID: 4732 RVA: 0x00006A20 File Offset: 0x00004C20
	// (set) Token: 0x0600127D RID: 4733 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001F1")]
	public bool Disconnecting
	{
		[Token(Token = "0x600127C")]
		[Address(RVA = "0x392250", Offset = "0x391450", VA = "0x180392250")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600127D")]
		[Address(RVA = "0x392360", Offset = "0x391560", VA = "0x180392360")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x170001F2 RID: 498
	// (get) Token: 0x0600127E RID: 4734 RVA: 0x00006A38 File Offset: 0x00004C38
	// (set) Token: 0x0600127F RID: 4735 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001F2")]
	public float DisconnectTime
	{
		[Token(Token = "0x600127E")]
		[Address(RVA = "0x392240", Offset = "0x391440", VA = "0x180392240")]
		[CompilerGenerated]
		get
		{
			return 0f;
		}
		[Token(Token = "0x600127F")]
		[Address(RVA = "0x392350", Offset = "0x391550", VA = "0x180392350")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x170001F3 RID: 499
	// (get) Token: 0x06001280 RID: 4736 RVA: 0x00006A50 File Offset: 0x00004C50
	// (set) Token: 0x06001281 RID: 4737 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001F3")]
	public bool Loading
	{
		[Token(Token = "0x6001280")]
		[Address(RVA = "0x392270", Offset = "0x391470", VA = "0x180392270")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001281")]
		[Address(RVA = "0x392380", Offset = "0x391580", VA = "0x180392380")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x170001F4 RID: 500
	// (get) Token: 0x06001282 RID: 4738 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x170001F4")]
	public Simulation Simulation
	{
		[Token(Token = "0x6001282")]
		[Address(RVA = "0x3922D0", Offset = "0x3914D0", VA = "0x1803922D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	// Token: 0x170001F5 RID: 501
	// (get) Token: 0x06001283 RID: 4739 RVA: 0x00006A68 File Offset: 0x00004C68
	// (set) Token: 0x06001284 RID: 4740 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001F5")]
	public bool InteruptDisconnect
	{
		[Token(Token = "0x6001283")]
		[Address(RVA = "0x392260", Offset = "0x391460", VA = "0x180392260")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001284")]
		[Address(RVA = "0x392370", Offset = "0x391570", VA = "0x180392370")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x170001F6 RID: 502
	// (get) Token: 0x06001285 RID: 4741 RVA: 0x00006A80 File Offset: 0x00004C80
	[Token(Token = "0x170001F6")]
	public uint Time
	{
		[Token(Token = "0x6001285")]
		[Address(RVA = "0x3922E0", Offset = "0x3914E0", VA = "0x1803922E0")]
		get
		{
			return 0U;
		}
	}

	// Token: 0x170001F7 RID: 503
	// (get) Token: 0x06001286 RID: 4742 RVA: 0x00006A98 File Offset: 0x00004C98
	[Token(Token = "0x170001F7")]
	public uint UpdateTime
	{
		[Token(Token = "0x6001286")]
		[Address(RVA = "0x392300", Offset = "0x391500", VA = "0x180392300")]
		get
		{
			return 0U;
		}
	}

	// Token: 0x170001F8 RID: 504
	// (get) Token: 0x06001287 RID: 4743 RVA: 0x0000206A File Offset: 0x0000026A
	// (set) Token: 0x06001288 RID: 4744 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001F8")]
	public string WorldName
	{
		[Token(Token = "0x6001287")]
		[Address(RVA = "0x392340", Offset = "0x391540", VA = "0x180392340")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6001288")]
		[Address(RVA = "0x3923E0", Offset = "0x3915E0", VA = "0x1803923E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x170001F9 RID: 505
	// (get) Token: 0x06001289 RID: 4745 RVA: 0x00006AB0 File Offset: 0x00004CB0
	// (set) Token: 0x0600128A RID: 4746 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001F9")]
	public ColorValue MapGlobalLight
	{
		[Token(Token = "0x6001289")]
		[Address(RVA = "0x392280", Offset = "0x391480", VA = "0x180392280")]
		[CompilerGenerated]
		get
		{
			return default(ColorValue);
		}
		[Token(Token = "0x600128A")]
		[Address(RVA = "0x392390", Offset = "0x391590", VA = "0x180392390")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x170001FA RID: 506
	// (get) Token: 0x0600128B RID: 4747 RVA: 0x00006AC8 File Offset: 0x00004CC8
	// (set) Token: 0x0600128C RID: 4748 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001FA")]
	public bool Parties
	{
		[Token(Token = "0x600128B")]
		[Address(RVA = "0x392290", Offset = "0x391490", VA = "0x180392290")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600128C")]
		[Address(RVA = "0x3923A0", Offset = "0x3915A0", VA = "0x1803923A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x170001FB RID: 507
	// (get) Token: 0x0600128D RID: 4749 RVA: 0x00006AE0 File Offset: 0x00004CE0
	// (set) Token: 0x0600128E RID: 4750 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001FB")]
	public QuestProgressData QuestProgress
	{
		[Token(Token = "0x600128D")]
		[Address(RVA = "0x3922A0", Offset = "0x3914A0", VA = "0x1803922A0")]
		[CompilerGenerated]
		get
		{
			return default(QuestProgressData);
		}
		[Token(Token = "0x600128E")]
		[Address(RVA = "0x3923B0", Offset = "0x3915B0", VA = "0x1803923B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x0600128F RID: 4751 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600128F")]
	[Address(RVA = "0x386130", Offset = "0x385330", VA = "0x180386130")]
	public void AcceptOffer(uint entityId, byte offerIndex, MerchantOffer offer)
	{
	}

	// Token: 0x06001290 RID: 4752 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6001290")]
	[Address(RVA = "0x3863C0", Offset = "0x3855C0", VA = "0x1803863C0")]
	public Task AcceptThreadChangeAsync(uint entityId, byte offerIndex)
	{
		return null;
	}

	// Token: 0x06001291 RID: 4753 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6001291")]
	[Address(RVA = "0x3864B0", Offset = "0x3856B0", VA = "0x1803864B0")]
	public Task AcceptThreadEndAsync(uint entityId, byte offerIndex)
	{
		return null;
	}

	// Token: 0x06001292 RID: 4754 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001292")]
	[Address(RVA = "0x3865A0", Offset = "0x3857A0", VA = "0x1803865A0")]
	public void AddAreaZone(Vector2Int contentOffset, AreaZoneChunk areaZoneChunk)
	{
	}

	// Token: 0x06001293 RID: 4755 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001293")]
	[Address(RVA = "0x3865D0", Offset = "0x3857D0", VA = "0x1803865D0")]
	public void AddCameraZonePoint(string label, Vector2Int point)
	{
	}

	// Token: 0x06001294 RID: 4756 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001294")]
	[Address(RVA = "0x3866C0", Offset = "0x3858C0", VA = "0x1803866C0")]
	public void AddNoCameraPoint(Vector2Int point)
	{
	}

	// Token: 0x06001295 RID: 4757 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001295")]
	[Address(RVA = "0x386600", Offset = "0x385800", VA = "0x180386600")]
	public void AddHittable(WorldObject worldObject)
	{
	}

	// Token: 0x06001296 RID: 4758 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001296")]
	[Address(RVA = "0x386660", Offset = "0x385860", VA = "0x180386660")]
	public void AddInteractable(WorldObject worldObject)
	{
	}

	// Token: 0x06001297 RID: 4759 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001297")]
	[Address(RVA = "0x3866F0", Offset = "0x3858F0", VA = "0x1803866F0")]
	public void AddTracked(MonoBehaviour obj)
	{
	}

	// Token: 0x06001298 RID: 4760 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001298")]
	[Address(RVA = "0x386750", Offset = "0x385950", VA = "0x180386750")]
	public void AddTutorial(Tutorial tutorial)
	{
	}

	// Token: 0x06001299 RID: 4761 RVA: 0x00006AF8 File Offset: 0x00004CF8
	[Token(Token = "0x6001299")]
	[Address(RVA = "0x386D60", Offset = "0x385F60", VA = "0x180386D60")]
	public bool BlockAttack(Int2 from, Int2 to)
	{
		return default(bool);
	}

	// Token: 0x0600129A RID: 4762 RVA: 0x00006B10 File Offset: 0x00004D10
	[Token(Token = "0x600129A")]
	[Address(RVA = "0x386D30", Offset = "0x385F30", VA = "0x180386D30")]
	public bool BlockAttack(Int2 point)
	{
		return default(bool);
	}

	// Token: 0x0600129B RID: 4763 RVA: 0x00006B28 File Offset: 0x00004D28
	[Token(Token = "0x600129B")]
	[Address(RVA = "0x386C20", Offset = "0x385E20", VA = "0x180386C20")]
	public bool BlockAttack(Vector2 point)
	{
		return default(bool);
	}

	// Token: 0x0600129C RID: 4764 RVA: 0x00006B40 File Offset: 0x00004D40
	[Token(Token = "0x600129C")]
	[Address(RVA = "0x386FB0", Offset = "0x3861B0", VA = "0x180386FB0")]
	public bool BlockAttack(Vector2Int point)
	{
		return default(bool);
	}

	// Token: 0x0600129D RID: 4765 RVA: 0x00006B58 File Offset: 0x00004D58
	[Token(Token = "0x600129D")]
	[Address(RVA = "0x386D00", Offset = "0x385F00", VA = "0x180386D00")]
	public bool BlockAttack(int x, int y)
	{
		return default(bool);
	}

	// Token: 0x0600129E RID: 4766 RVA: 0x00006B70 File Offset: 0x00004D70
	[Token(Token = "0x600129E")]
	[Address(RVA = "0x387120", Offset = "0x386320", VA = "0x180387120")]
	public bool CanWalk(Int2 from, Int2 to)
	{
		return default(bool);
	}

	// Token: 0x0600129F RID: 4767 RVA: 0x00006B88 File Offset: 0x00004D88
	[Token(Token = "0x600129F")]
	[Address(RVA = "0x387370", Offset = "0x386570", VA = "0x180387370")]
	public bool CanWalk(Int2 point)
	{
		return default(bool);
	}

	// Token: 0x060012A0 RID: 4768 RVA: 0x00006BA0 File Offset: 0x00004DA0
	[Token(Token = "0x60012A0")]
	[Address(RVA = "0x3870C0", Offset = "0x3862C0", VA = "0x1803870C0")]
	public bool CanWalk(Vec2 point)
	{
		return default(bool);
	}

	// Token: 0x060012A1 RID: 4769 RVA: 0x00006BB8 File Offset: 0x00004DB8
	[Token(Token = "0x60012A1")]
	[Address(RVA = "0x386FE0", Offset = "0x3861E0", VA = "0x180386FE0")]
	public bool CanWalk(Vector2 point)
	{
		return default(bool);
	}

	// Token: 0x060012A2 RID: 4770 RVA: 0x00006BD0 File Offset: 0x00004DD0
	[Token(Token = "0x60012A2")]
	[Address(RVA = "0x3873A0", Offset = "0x3865A0", VA = "0x1803873A0")]
	public bool CanWalk(Vector2Int point)
	{
		return default(bool);
	}

	// Token: 0x060012A3 RID: 4771 RVA: 0x00006BE8 File Offset: 0x00004DE8
	[Token(Token = "0x60012A3")]
	[Address(RVA = "0x3873D0", Offset = "0x3865D0", VA = "0x1803873D0")]
	public bool CanWalk(int x, int y)
	{
		return default(bool);
	}

	// Token: 0x060012A4 RID: 4772 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60012A4")]
	[Address(RVA = "0x3877E0", Offset = "0x3869E0", VA = "0x1803877E0")]
	public string ChatFilter(ref String8 value)
	{
		return null;
	}

	// Token: 0x060012A5 RID: 4773 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60012A5")]
	[Address(RVA = "0x387740", Offset = "0x386940", VA = "0x180387740")]
	public string ChatFilter(ref String16 value)
	{
		return null;
	}

	// Token: 0x060012A6 RID: 4774 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60012A6")]
	[Address(RVA = "0x387600", Offset = "0x386800", VA = "0x180387600")]
	public string ChatFilter(ref String32 value)
	{
		return null;
	}

	// Token: 0x060012A7 RID: 4775 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60012A7")]
	[Address(RVA = "0x387880", Offset = "0x386A80", VA = "0x180387880")]
	public string ChatFilter(ref String64 value)
	{
		return null;
	}

	// Token: 0x060012A8 RID: 4776 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60012A8")]
	[Address(RVA = "0x387560", Offset = "0x386760", VA = "0x180387560")]
	public string ChatFilter(ref String128 value)
	{
		return null;
	}

	// Token: 0x060012A9 RID: 4777 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60012A9")]
	[Address(RVA = "0x3876A0", Offset = "0x3868A0", VA = "0x1803876A0")]
	public string ChatFilter(ref String256 value)
	{
		return null;
	}

	// Token: 0x060012AA RID: 4778 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60012AA")]
	[Address(RVA = "0x387920", Offset = "0x386B20", VA = "0x180387920")]
	public string ChatFilter(ref String512 value)
	{
		return null;
	}

	// Token: 0x060012AB RID: 4779 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60012AB")]
	[Address(RVA = "0x387400", Offset = "0x386600", VA = "0x180387400")]
	public string ChatFilter(Span<char> span)
	{
		return null;
	}

	// Token: 0x060012AC RID: 4780 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012AC")]
	[Address(RVA = "0x387A60", Offset = "0x386C60", VA = "0x180387A60")]
	public void ClearWorld()
	{
	}

	// Token: 0x060012AD RID: 4781 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012AD")]
	[Address(RVA = "0x387DF0", Offset = "0x386FF0", VA = "0x180387DF0")]
	public void CreateAttack(EntityMasks targetMask, uint attackId, uint ownerId, ObjectDefinition sender, AttackDescriptor attackDescriptor, Vec2 coordinates, Vec2 target, Vec2 entityCoordinates, ushort rawDamage, float height, AttackFlags flags)
	{
	}

	// Token: 0x060012AE RID: 4782 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012AE")]
	[Address(RVA = "0x387DA0", Offset = "0x386FA0", VA = "0x180387DA0")]
	public void Connecting()
	{
	}

	// Token: 0x060012AF RID: 4783 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012AF")]
	[Address(RVA = "0x388890", Offset = "0x387A90", VA = "0x180388890")]
	public void Disconnect()
	{
	}

	// Token: 0x060012B0 RID: 4784 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012B0")]
	[Address(RVA = "0x3888D0", Offset = "0x387AD0", VA = "0x1803888D0")]
	public void Discovered(CoordOverride @override)
	{
	}

	// Token: 0x060012B1 RID: 4785 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012B1")]
	[Address(RVA = "0x388A40", Offset = "0x387C40", VA = "0x180388A40")]
	public void Discovered(CoordOverride[] overrides)
	{
	}

	// Token: 0x060012B2 RID: 4786 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012B2")]
	[Address(RVA = "0x3889D0", Offset = "0x387BD0", VA = "0x1803889D0")]
	public void Discovered(CoordTile tile)
	{
	}

	// Token: 0x060012B3 RID: 4787 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012B3")]
	[Address(RVA = "0x388910", Offset = "0x387B10", VA = "0x180388910")]
	public void Discovered(CoordTile[] tiles)
	{
	}

	// Token: 0x060012B4 RID: 4788 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60012B4")]
	[Address(RVA = "0x388C80", Offset = "0x387E80", VA = "0x180388C80")]
	public IEnumerable<Entity> GetBosses()
	{
		return null;
	}

	// Token: 0x060012B5 RID: 4789 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60012B5")]
	[Address(RVA = "0x388F80", Offset = "0x388180", VA = "0x180388F80")]
	public WorldObject GetClosestInteractable()
	{
		return null;
	}

	// Token: 0x060012B6 RID: 4790 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60012B6")]
	[Address(RVA = "0x388F90", Offset = "0x388190", VA = "0x180388F90")]
	public Entity GetControlledEntity()
	{
		return null;
	}

	// Token: 0x060012B7 RID: 4791 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60012B7")]
	[Address(RVA = "0x389040", Offset = "0x388240", VA = "0x180389040", Slot = "5")]
	public ObjectDefinition GetDefinition(ushort type)
	{
		return null;
	}

	// Token: 0x060012B8 RID: 4792 RVA: 0x00006C00 File Offset: 0x00004E00
	[Token(Token = "0x60012B8")]
	[Address(RVA = "0x388FA0", Offset = "0x3881A0", VA = "0x180388FA0")]
	public int GetControlledStat(StatType statType)
	{
		return 0;
	}

	// Token: 0x060012B9 RID: 4793 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60012B9")]
	[Address(RVA = "0x3891A0", Offset = "0x3883A0", VA = "0x1803891A0")]
	public Entity GetEntity(uint id)
	{
		return null;
	}

	// Token: 0x060012BA RID: 4794 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60012BA")]
	[Address(RVA = "0x3890D0", Offset = "0x3882D0", VA = "0x1803890D0")]
	public IEnumerable<Enemy> GetEnemies()
	{
		return null;
	}

	// Token: 0x060012BB RID: 4795 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60012BB")]
	[Address(RVA = "0x389150", Offset = "0x388350", VA = "0x180389150")]
	public IEnumerable<Entity> GetEntities()
	{
		return null;
	}

	// Token: 0x060012BC RID: 4796 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60012BC")]
	[Address(RVA = "0x389220", Offset = "0x388420", VA = "0x180389220")]
	public GroundDefinition GetGround(Int2 coordinates)
	{
		return null;
	}

	// Token: 0x060012BD RID: 4797 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60012BD")]
	[Address(RVA = "0x3892D0", Offset = "0x3884D0", VA = "0x1803892D0")]
	public IEnumerable<WorldObject> GetHittables(EntityMasks targetMask)
	{
		return null;
	}

	// Token: 0x060012BE RID: 4798 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60012BE")]
	[Address(RVA = "0x389400", Offset = "0x388600", VA = "0x180389400")]
	public IEnumerable<ValueTuple<ushort, string, Vector2Int>> GetLabels()
	{
		return null;
	}

	// Token: 0x060012BF RID: 4799 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60012BF")]
	[Address(RVA = "0x389880", Offset = "0x388A80", VA = "0x180389880")]
	public IEnumerable<ValueTuple<ushort, Vector2Int>> GetTravelLocations()
	{
		return null;
	}

	// Token: 0x060012C0 RID: 4800 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60012C0")]
	[Address(RVA = "0x389050", Offset = "0x388250", VA = "0x180389050")]
	public IEnumerable<ValueTuple<ushort, Vector2Int>> GetDiscoveredTravelLocations()
	{
		return null;
	}

	// Token: 0x060012C1 RID: 4801 RVA: 0x00006C18 File Offset: 0x00004E18
	[Token(Token = "0x60012C1")]
	[Address(RVA = "0x389430", Offset = "0x388630", VA = "0x180389430")]
	public bool GetOpacity(Vector2 coordinates, out Entity closestBoss, out float distance)
	{
		return default(bool);
	}

	// Token: 0x060012C2 RID: 4802 RVA: 0x00006C30 File Offset: 0x00004E30
	[Token(Token = "0x60012C2")]
	[Address(RVA = "0x389710", Offset = "0x388910", VA = "0x180389710")]
	public byte GetRewardShare(uint bossEntityId)
	{
		return 0;
	}

	// Token: 0x060012C3 RID: 4803 RVA: 0x00006C48 File Offset: 0x00004E48
	[Token(Token = "0x60012C3")]
	[Address(RVA = "0x389780", Offset = "0x388980", VA = "0x180389780", Slot = "4")]
	public Tile GetTile(Int2 coordinates)
	{
		return default(Tile);
	}

	// Token: 0x060012C4 RID: 4804 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60012C4")]
	[Address(RVA = "0x388AD0", Offset = "0x387CD0", VA = "0x180388AD0")]
	private IEnumerable<WorldObject> GenerateHittables(EntityMasks targetMask)
	{
		return null;
	}

	// Token: 0x060012C5 RID: 4805 RVA: 0x00006C60 File Offset: 0x00004E60
	[Token(Token = "0x60012C5")]
	[Address(RVA = "0x389820", Offset = "0x388A20", VA = "0x180389820")]
	public Tile? GetTile(float x, float y)
	{
		return null;
	}

	// Token: 0x060012C6 RID: 4806 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012C6")]
	[Address(RVA = "0x38C210", Offset = "0x38B410", VA = "0x18038C210")]
	public void HandleData(uint attackId, ref AttackOutputData data)
	{
	}

	// Token: 0x060012C7 RID: 4807 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012C7")]
	[Address(RVA = "0x38AA70", Offset = "0x389C70", VA = "0x18038AA70")]
	public void HandleData(ref ChatIdData data)
	{
	}

	// Token: 0x060012C8 RID: 4808 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012C8")]
	[Address(RVA = "0x38BC40", Offset = "0x38AE40", VA = "0x18038BC40")]
	public void HandleData(ref ChatOwnerData data)
	{
	}

	// Token: 0x060012C9 RID: 4809 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012C9")]
	[Address(RVA = "0x38B030", Offset = "0x38A230", VA = "0x18038B030")]
	public void HandleData(ref ChatTokenNameData data)
	{
	}

	// Token: 0x060012CA RID: 4810 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012CA")]
	[Address(RVA = "0x38B710", Offset = "0x38A910", VA = "0x18038B710")]
	public void HandleData(ref ChatTokenString16Data data)
	{
	}

	// Token: 0x060012CB RID: 4811 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012CB")]
	[Address(RVA = "0x38A080", Offset = "0x389280", VA = "0x18038A080")]
	public void HandleData(ref ChatTokenString32Data data)
	{
	}

	// Token: 0x060012CC RID: 4812 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012CC")]
	[Address(RVA = "0x38BF80", Offset = "0x38B180", VA = "0x18038BF80")]
	public void HandleData(ref ChatTokenString64Data data)
	{
	}

	// Token: 0x060012CD RID: 4813 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012CD")]
	[Address(RVA = "0x38A170", Offset = "0x389370", VA = "0x18038A170")]
	public void HandleData(ref ChatTokenString128Data data)
	{
	}

	// Token: 0x060012CE RID: 4814 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012CE")]
	[Address(RVA = "0x3898B0", Offset = "0x388AB0", VA = "0x1803898B0")]
	public void HandleData(ref ChatTokenString256Data data)
	{
	}

	// Token: 0x060012CF RID: 4815 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012CF")]
	[Address(RVA = "0x38B2A0", Offset = "0x38A4A0", VA = "0x18038B2A0")]
	public void HandleData(ref ChatTokenString512Data data)
	{
	}

	// Token: 0x060012D0 RID: 4816 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012D0")]
	[Address(RVA = "0x38AD30", Offset = "0x389F30", VA = "0x18038AD30")]
	public void HandleData(ref ChatTokenTimeData data)
	{
	}

	// Token: 0x060012D1 RID: 4817 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012D1")]
	[Address(RVA = "0x389B60", Offset = "0x388D60", VA = "0x180389B60")]
	public void HandleData(ref ChatTokenTypeData data)
	{
	}

	// Token: 0x060012D2 RID: 4818 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012D2")]
	[Address(RVA = "0x38C0B0", Offset = "0x38B2B0", VA = "0x18038C0B0")]
	public void HandleData(ref Chat8Data data)
	{
	}

	// Token: 0x060012D3 RID: 4819 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012D3")]
	[Address(RVA = "0x38ABD0", Offset = "0x389DD0", VA = "0x18038ABD0")]
	public void HandleData(ref Chat16Data data)
	{
	}

	// Token: 0x060012D4 RID: 4820 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012D4")]
	[Address(RVA = "0x3899F0", Offset = "0x388BF0", VA = "0x1803899F0")]
	public void HandleData(ref Chat32Data data)
	{
	}

	// Token: 0x060012D5 RID: 4821 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012D5")]
	[Address(RVA = "0x38C160", Offset = "0x38B360", VA = "0x18038C160")]
	public void HandleData(ref Chat64Data data)
	{
	}

	// Token: 0x060012D6 RID: 4822 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012D6")]
	[Address(RVA = "0x38AC80", Offset = "0x389E80", VA = "0x18038AC80")]
	public void HandleData(ref Chat128Data data)
	{
	}

	// Token: 0x060012D7 RID: 4823 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012D7")]
	[Address(RVA = "0x389FD0", Offset = "0x3891D0", VA = "0x180389FD0")]
	public void HandleData(ref Chat256Data data)
	{
	}

	// Token: 0x060012D8 RID: 4824 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012D8")]
	[Address(RVA = "0x38A2B0", Offset = "0x3894B0", VA = "0x18038A2B0")]
	public void HandleData(ref Chat512Data data)
	{
	}

	// Token: 0x060012D9 RID: 4825 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012D9")]
	[Address(RVA = "0x38B6E0", Offset = "0x38A8E0", VA = "0x18038B6E0")]
	public void HandleData(ref CompassData data)
	{
	}

	// Token: 0x060012DA RID: 4826 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012DA")]
	[Address(RVA = "0x389AA0", Offset = "0x388CA0", VA = "0x180389AA0")]
	public void HandleData(ref ConsumedData data)
	{
	}

	// Token: 0x060012DB RID: 4827 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012DB")]
	[Address(RVA = "0x38B970", Offset = "0x38AB70", VA = "0x18038B970")]
	public void HandleData(ref DeathData data)
	{
	}

	// Token: 0x060012DC RID: 4828 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012DC")]
	[Address(RVA = "0x38BA70", Offset = "0x38AC70", VA = "0x18038BA70")]
	public void HandleData(ref EffectTargetedData data)
	{
	}

	// Token: 0x060012DD RID: 4829 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012DD")]
	[Address(RVA = "0x38B7F0", Offset = "0x38A9F0", VA = "0x18038B7F0")]
	public void HandleData(ref ExpSourceData data)
	{
	}

	// Token: 0x060012DE RID: 4830 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012DE")]
	[Address(RVA = "0x38AFC0", Offset = "0x38A1C0", VA = "0x18038AFC0")]
	public void HandleData(ref GlobalLightData data)
	{
	}

	// Token: 0x060012DF RID: 4831 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012DF")]
	[Address(RVA = "0x38A6A0", Offset = "0x3898A0", VA = "0x18038A6A0")]
	public void HandleData(ref MapInfoData data)
	{
	}

	// Token: 0x060012E0 RID: 4832 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012E0")]
	[Address(RVA = "0x38A360", Offset = "0x389560", VA = "0x18038A360")]
	public void HandleData(ref ObjectTypeData data)
	{
	}

	// Token: 0x060012E1 RID: 4833 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012E1")]
	[Address(RVA = "0x38BEA0", Offset = "0x38B0A0", VA = "0x18038BEA0")]
	public void HandleData(ref PlayerIdData data)
	{
	}

	// Token: 0x060012E2 RID: 4834 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012E2")]
	[Address(RVA = "0x38BCE0", Offset = "0x38AEE0", VA = "0x18038BCE0")]
	public void HandleData(ref QuestProgressData data)
	{
	}

	// Token: 0x060012E3 RID: 4835 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012E3")]
	[Address(RVA = "0x38B3E0", Offset = "0x38A5E0", VA = "0x18038B3E0")]
	public void HandleData(ref ReloadData data)
	{
	}

	// Token: 0x060012E4 RID: 4836 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012E4")]
	[Address(RVA = "0x38C2C0", Offset = "0x38B4C0", VA = "0x18038C2C0")]
	public void HandleData(ref RewardShareData data)
	{
	}

	// Token: 0x060012E5 RID: 4837 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012E5")]
	[Address(RVA = "0x38B110", Offset = "0x38A310", VA = "0x18038B110")]
	public void HandleData(ref SfxData data)
	{
	}

	// Token: 0x060012E6 RID: 4838 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012E6")]
	[Address(RVA = "0x38AAD0", Offset = "0x389CD0", VA = "0x18038AAD0")]
	public void HandleData(ref TileData data)
	{
	}

	// Token: 0x060012E7 RID: 4839 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012E7")]
	[Address(RVA = "0x389F80", Offset = "0x389180", VA = "0x180389F80")]
	public void HandleData(ref WeatherData data)
	{
	}

	// Token: 0x060012E8 RID: 4840 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012E8")]
	[Address(RVA = "0x38C320", Offset = "0x38B520", VA = "0x18038C320")]
	public void HandleEntity(uint entityId)
	{
	}

	// Token: 0x060012E9 RID: 4841 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012E9")]
	public void HandleEntityData<T>(ref T data) where T : struct
	{
	}

	// Token: 0x060012EA RID: 4842 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012EA")]
	[Address(RVA = "0x38C3A0", Offset = "0x38B5A0", VA = "0x18038C3A0")]
	public void HandleRemove(uint entityId)
	{
	}

	// Token: 0x060012EB RID: 4843 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012EB")]
	[Address(RVA = "0x38D050", Offset = "0x38C250", VA = "0x18038D050")]
	public void HomeCancel()
	{
	}

	// Token: 0x060012EC RID: 4844 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012EC")]
	[Address(RVA = "0x38D090", Offset = "0x38C290", VA = "0x18038D090")]
	public void HomeStart()
	{
	}

	// Token: 0x060012ED RID: 4845 RVA: 0x00006C78 File Offset: 0x00004E78
	[Token(Token = "0x60012ED")]
	[Address(RVA = "0x38D620", Offset = "0x38C820", VA = "0x18038D620")]
	public bool IsOnScreen(Vector2 position)
	{
		return default(bool);
	}

	// Token: 0x060012EE RID: 4846 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012EE")]
	[Address(RVA = "0x38D0D0", Offset = "0x38C2D0", VA = "0x18038D0D0")]
	public void Information(string message)
	{
	}

	// Token: 0x060012EF RID: 4847 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012EF")]
	[Address(RVA = "0x38D1C0", Offset = "0x38C3C0", VA = "0x18038D1C0")]
	public void Interact(WorldObject interactable)
	{
	}

	// Token: 0x060012F0 RID: 4848 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012F0")]
	[Address(RVA = "0x38D1B0", Offset = "0x38C3B0", VA = "0x18038D1B0")]
	public void InteractClosest()
	{
	}

	// Token: 0x060012F1 RID: 4849 RVA: 0x00006C90 File Offset: 0x00004E90
	[Token(Token = "0x60012F1")]
	[Address(RVA = "0x38D600", Offset = "0x38C800", VA = "0x18038D600")]
	public bool IsCurrentQuest(QuestData data)
	{
		return default(bool);
	}

	// Token: 0x060012F2 RID: 4850 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012F2")]
	[Address(RVA = "0x38DA10", Offset = "0x38CC10", VA = "0x18038DA10", Slot = "6")]
	public void Log(string message)
	{
	}

	// Token: 0x060012F3 RID: 4851 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60012F3")]
	[Address(RVA = "0x38DCE0", Offset = "0x38CEE0", VA = "0x18038DCE0")]
	public Task<MapFile> NewWorldAsync(MapInfoData mapInfoData)
	{
		return null;
	}

	// Token: 0x060012F4 RID: 4852 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012F4")]
	[Address(RVA = "0x38DAD0", Offset = "0x38CCD0", VA = "0x18038DAD0")]
	public void NetworkLateUpdate()
	{
	}

	// Token: 0x060012F5 RID: 4853 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012F5")]
	[Address(RVA = "0x38DC70", Offset = "0x38CE70", VA = "0x18038DC70")]
	public void NetworkUpdate()
	{
	}

	// Token: 0x060012F6 RID: 4854 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012F6")]
	[Address(RVA = "0x38DC40", Offset = "0x38CE40", VA = "0x18038DC40")]
	public void NetworkTimeUpdate()
	{
	}

	// Token: 0x060012F7 RID: 4855 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012F7")]
	public void Push<T>(T data) where T : struct
	{
	}

	// Token: 0x060012F8 RID: 4856 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012F8")]
	[Address(RVA = "0x38DEA0", Offset = "0x38D0A0", VA = "0x18038DEA0")]
	public void PushChat(string text)
	{
	}

	// Token: 0x060012F9 RID: 4857 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012F9")]
	[Address(RVA = "0x38DE60", Offset = "0x38D060", VA = "0x18038DE60")]
	public void PostHandle()
	{
	}

	// Token: 0x060012FA RID: 4858 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012FA")]
	[Address(RVA = "0x38DF30", Offset = "0x38D130", VA = "0x18038DF30")]
	public void ReceivedChat(ChatType chatType, string message)
	{
	}

	// Token: 0x060012FB RID: 4859 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012FB")]
	[Address(RVA = "0x38EC20", Offset = "0x38DE20", VA = "0x18038EC20")]
	public void RemoveHittable(WorldObject worldObject)
	{
	}

	// Token: 0x060012FC RID: 4860 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012FC")]
	[Address(RVA = "0x38ECE0", Offset = "0x38DEE0", VA = "0x18038ECE0")]
	public void RemoveInteractable(WorldObject worldObject)
	{
	}

	// Token: 0x060012FD RID: 4861 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012FD")]
	[Address(RVA = "0x38ED40", Offset = "0x38DF40", VA = "0x18038ED40")]
	public void RemoveTracked(MonoBehaviour obj)
	{
	}

	// Token: 0x060012FE RID: 4862 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012FE")]
	[Address(RVA = "0x38EDA0", Offset = "0x38DFA0", VA = "0x18038EDA0")]
	public void RemoveTutorial(Tutorial tutorial)
	{
	}

	// Token: 0x060012FF RID: 4863 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012FF")]
	[Address(RVA = "0x38F320", Offset = "0x38E520", VA = "0x18038F320")]
	public void RevealMap(ref RevealMapData data)
	{
	}

	// Token: 0x06001300 RID: 4864 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001300")]
	[Address(RVA = "0x38FB00", Offset = "0x38ED00", VA = "0x18038FB00")]
	public void SetCameraPosition(Vector2 controlledPosition, Vector2 controlledFacing)
	{
	}

	// Token: 0x06001301 RID: 4865 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001301")]
	[Address(RVA = "0x390900", Offset = "0x38FB00", VA = "0x180390900")]
	public void SetTargeted(WorldObject worldObject)
	{
	}

	// Token: 0x06001302 RID: 4866 RVA: 0x00006CA8 File Offset: 0x00004EA8
	[Token(Token = "0x6001302")]
	[Address(RVA = "0x390AA0", Offset = "0x38FCA0", VA = "0x180390AA0")]
	public bool TradeEnabled()
	{
		return default(bool);
	}

	// Token: 0x06001303 RID: 4867 RVA: 0x00006CC0 File Offset: 0x00004EC0
	[Token(Token = "0x6001303")]
	[Address(RVA = "0x390B50", Offset = "0x38FD50", VA = "0x180390B50")]
	public bool TryGetCharacter(long playerId, out Character character)
	{
		return default(bool);
	}

	// Token: 0x06001304 RID: 4868 RVA: 0x00006CD8 File Offset: 0x00004ED8
	[Token(Token = "0x6001304")]
	[Address(RVA = "0x390BC0", Offset = "0x38FDC0", VA = "0x180390BC0")]
	public bool TryGetEntity(uint id, out Entity entity)
	{
		return default(bool);
	}

	// Token: 0x06001305 RID: 4869 RVA: 0x00006CF0 File Offset: 0x00004EF0
	[Token(Token = "0x6001305")]
	[Address(RVA = "0x3879C0", Offset = "0x386BC0", VA = "0x1803879C0")]
	private Vector2 ClampFit(Vector2 value, Vector2 minMax)
	{
		return default(Vector2);
	}

	// Token: 0x06001306 RID: 4870 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001306")]
	[Address(RVA = "0x3909F0", Offset = "0x38FBF0", VA = "0x1803909F0")]
	public void StartDisconnect()
	{
	}

	// Token: 0x06001307 RID: 4871 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001307")]
	[Address(RVA = "0x390A50", Offset = "0x38FC50", VA = "0x180390A50")]
	public void StopDisconnect()
	{
	}

	// Token: 0x06001308 RID: 4872 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001308")]
	[Address(RVA = "0x3867B0", Offset = "0x3859B0", VA = "0x1803867B0")]
	private void Awake()
	{
	}

	// Token: 0x06001309 RID: 4873 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001309")]
	[Address(RVA = "0x3885A0", Offset = "0x3877A0", VA = "0x1803885A0")]
	private void CreateControlledAttacks()
	{
	}

	// Token: 0x0600130A RID: 4874 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600130A")]
	[Address(RVA = "0x3887F0", Offset = "0x3879F0", VA = "0x1803887F0")]
	private Entity CreateEntity(uint entityId)
	{
		return null;
	}

	// Token: 0x0600130B RID: 4875 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600130B")]
	[Address(RVA = "0x388B50", Offset = "0x387D50", VA = "0x180388B50")]
	private AttackRepresentation GetAttackRepresentation(AttackDescriptor attackDescriptor)
	{
		return null;
	}

	// Token: 0x0600130C RID: 4876 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600130C")]
	[Address(RVA = "0x388CD0", Offset = "0x387ED0", VA = "0x180388CD0")]
	private WorldObject GetChatOwner(out ChatOwnerData? ownerData, out ChatIdData? idData)
	{
		return null;
	}

	// Token: 0x0600130D RID: 4877 RVA: 0x00006D08 File Offset: 0x00004F08
	[Token(Token = "0x600130D")]
	[Address(RVA = "0x38C620", Offset = "0x38B820", VA = "0x18038C620")]
	private bool HitCast(ref Attack attack, Vec2 lastCoordinates)
	{
		return default(bool);
	}

	// Token: 0x0600130E RID: 4878 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600130E")]
	[Address(RVA = "0x38D720", Offset = "0x38C920", VA = "0x18038D720")]
	private void LateUpdate()
	{
	}

	// Token: 0x0600130F RID: 4879 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600130F")]
	[Address(RVA = "0x38DA60", Offset = "0x38CC60", VA = "0x18038DA60")]
	private void NetworkInputUpdate()
	{
	}

	// Token: 0x06001310 RID: 4880 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001310")]
	[Address(RVA = "0x38DE40", Offset = "0x38D040", VA = "0x18038DE40")]
	private void OnDestroy()
	{
	}

	// Token: 0x06001311 RID: 4881 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6001311")]
	[Address(RVA = "0x38E720", Offset = "0x38D920", VA = "0x18038E720")]
	private Task ReloadDataAsync()
	{
		return null;
	}

	// Token: 0x06001312 RID: 4882 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6001312")]
	[Address(RVA = "0x38E7F0", Offset = "0x38D9F0", VA = "0x18038E7F0")]
	private Task ReloadMapAsync()
	{
		return null;
	}

	// Token: 0x06001313 RID: 4883 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001313")]
	[Address(RVA = "0x38E8D0", Offset = "0x38DAD0", VA = "0x18038E8D0")]
	private void ReloadObjects()
	{
	}

	// Token: 0x06001314 RID: 4884 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6001314")]
	[Address(RVA = "0x38EB50", Offset = "0x38DD50", VA = "0x18038EB50")]
	private Task ReloadTextureAsync()
	{
		return null;
	}

	// Token: 0x06001315 RID: 4885 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001315")]
	[Address(RVA = "0x38EE00", Offset = "0x38E000", VA = "0x18038EE00")]
	private void ReturnAllEntities()
	{
	}

	// Token: 0x06001316 RID: 4886 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001316")]
	[Address(RVA = "0x38F0D0", Offset = "0x38E2D0", VA = "0x18038F0D0")]
	private void ReturnAllTracked()
	{
	}

	// Token: 0x06001317 RID: 4887 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001317")]
	[Address(RVA = "0x38F250", Offset = "0x38E450", VA = "0x18038F250")]
	private void ReturnEntity(Entity entity)
	{
	}

	// Token: 0x06001318 RID: 4888 RVA: 0x00006D20 File Offset: 0x00004F20
	[Token(Token = "0x6001318")]
	[Address(RVA = "0x38F7A0", Offset = "0x38E9A0", VA = "0x18038F7A0")]
	private bool RunAttack(ref Attack attack, bool realStep)
	{
		return default(bool);
	}

	// Token: 0x06001319 RID: 4889 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001319")]
	[Address(RVA = "0x390B20", Offset = "0x38FD20", VA = "0x180390B20")]
	private void TryDisconnect()
	{
	}

	// Token: 0x0600131A RID: 4890 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600131A")]
	[Address(RVA = "0x390EF0", Offset = "0x3900F0", VA = "0x180390EF0")]
	private void UpdateAttacks(bool hitCast)
	{
	}

	// Token: 0x0600131B RID: 4891 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600131B")]
	[Address(RVA = "0x391190", Offset = "0x390390", VA = "0x180391190")]
	private void UpdateBoss()
	{
	}

	// Token: 0x0600131C RID: 4892 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600131C")]
	[Address(RVA = "0x3913F0", Offset = "0x3905F0", VA = "0x1803913F0")]
	private void UpdateControlledEntity()
	{
	}

	// Token: 0x0600131D RID: 4893 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600131D")]
	[Address(RVA = "0x3916F0", Offset = "0x3908F0", VA = "0x1803916F0")]
	private void UpdateInteractables()
	{
	}

	// Token: 0x0600131E RID: 4894 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600131E")]
	[Address(RVA = "0x391910", Offset = "0x390B10", VA = "0x180391910")]
	private void UpdatePickupItems()
	{
	}

	// Token: 0x0600131F RID: 4895 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600131F")]
	[Address(RVA = "0x391C10", Offset = "0x390E10", VA = "0x180391C10")]
	public World()
	{
	}

	// Token: 0x06001321 RID: 4897 RVA: 0x00006D38 File Offset: 0x00004F38
	[Token(Token = "0x6001321")]
	[Address(RVA = "0x390C30", Offset = "0x38FE30", VA = "0x180390C30")]
	[CompilerGenerated]
	internal static bool <CreateAttack>g__playSfx|139_0(uint delay, Span<uint> delays, int count)
	{
		return default(bool);
	}

	// Token: 0x06001322 RID: 4898 RVA: 0x00006D50 File Offset: 0x00004F50
	[Token(Token = "0x6001322")]
	[Address(RVA = "0x390E30", Offset = "0x390030", VA = "0x180390E30")]
	[CompilerGenerated]
	internal static float <HandleData>g__lightenColor|175_0(float color, float amount)
	{
		return 0f;
	}

	// Token: 0x04000F25 RID: 3877
	[Token(Token = "0x4000F25")]
	[FieldOffset(Offset = "0x0")]
	public static World Instance;

	// Token: 0x04000F26 RID: 3878
	[Token(Token = "0x4000F26")]
	[FieldOffset(Offset = "0x20")]
	public Camera Camera;

	// Token: 0x04000F27 RID: 3879
	[Token(Token = "0x4000F27")]
	[FieldOffset(Offset = "0x28")]
	public Vector2 CameraOffset;

	// Token: 0x04000F28 RID: 3880
	[Token(Token = "0x4000F28")]
	[FieldOffset(Offset = "0x30")]
	public WorldCamera WorldCamera;

	// Token: 0x04000F29 RID: 3881
	[Token(Token = "0x4000F29")]
	[FieldOffset(Offset = "0x38")]
	public LightCamera LightCamera;

	// Token: 0x04000F2A RID: 3882
	[Token(Token = "0x4000F2A")]
	[FieldOffset(Offset = "0x40")]
	public ControlManager ControlManager;

	// Token: 0x04000F2B RID: 3883
	[Token(Token = "0x4000F2B")]
	[FieldOffset(Offset = "0x48")]
	public RoninGameService GameService;

	// Token: 0x04000F2C RID: 3884
	[Token(Token = "0x4000F2C")]
	[FieldOffset(Offset = "0x50")]
	public PlayerMovementManager MovementManager;

	// Token: 0x04000F2D RID: 3885
	[Token(Token = "0x4000F2D")]
	[FieldOffset(Offset = "0x58")]
	public PlayerAttackManager AttackManager;

	// Token: 0x04000F2E RID: 3886
	[Token(Token = "0x4000F2E")]
	[FieldOffset(Offset = "0x60")]
	public UIManager UI;

	// Token: 0x04000F2F RID: 3887
	[Token(Token = "0x4000F2F")]
	[FieldOffset(Offset = "0x68")]
	public NotificationManager Notifications;

	// Token: 0x04000F30 RID: 3888
	[Token(Token = "0x4000F30")]
	[FieldOffset(Offset = "0x70")]
	public MovementAngleIndicator MovementAngleIndicator;

	// Token: 0x04000F31 RID: 3889
	[Token(Token = "0x4000F31")]
	[FieldOffset(Offset = "0x78")]
	public MusicController Music;

	// Token: 0x04000F32 RID: 3890
	[Token(Token = "0x4000F32")]
	[FieldOffset(Offset = "0x80")]
	public SfxController Sfx;

	// Token: 0x04000F33 RID: 3891
	[Token(Token = "0x4000F33")]
	[FieldOffset(Offset = "0x88")]
	public GameObject KeybindSetter;

	// Token: 0x04000F34 RID: 3892
	[Token(Token = "0x4000F34")]
	[FieldOffset(Offset = "0x90")]
	public bool IsMenu;

	// Token: 0x04000F35 RID: 3893
	[Token(Token = "0x4000F35")]
	[FieldOffset(Offset = "0x94")]
	public float CameraLerpSpeed;

	// Token: 0x04000F36 RID: 3894
	[Token(Token = "0x4000F36")]
	[FieldOffset(Offset = "0x98")]
	public float CameraFacingDistance;

	// Token: 0x04000F37 RID: 3895
	[Token(Token = "0x4000F37")]
	[FieldOffset(Offset = "0xA0")]
	public MedallionShopMenu MedallionShopMenu;

	// Token: 0x04000F38 RID: 3896
	[Token(Token = "0x4000F38")]
	[FieldOffset(Offset = "0x8")]
	private static readonly Dictionary<int, string> s_tokenKeys;

	// Token: 0x04000F39 RID: 3897
	[Token(Token = "0x4000F39")]
	[FieldOffset(Offset = "0xA8")]
	private readonly Dictionary<uint, byte> _rewardShare;

	// Token: 0x04000F3A RID: 3898
	[Token(Token = "0x4000F3A")]
	[FieldOffset(Offset = "0xB0")]
	private readonly Dictionary<uint, Entity> _entities;

	// Token: 0x04000F3B RID: 3899
	[Token(Token = "0x4000F3B")]
	[FieldOffset(Offset = "0xB8")]
	private readonly Dictionary<uint, Entity> _bosses;

	// Token: 0x04000F3C RID: 3900
	[Token(Token = "0x4000F3C")]
	[FieldOffset(Offset = "0xC0")]
	private readonly HashSet<WorldObject> _interactables;

	// Token: 0x04000F3D RID: 3901
	[Token(Token = "0x4000F3D")]
	[FieldOffset(Offset = "0xC8")]
	private readonly Dictionary<uint, IPickupContainer> _pickupContainers;

	// Token: 0x04000F3E RID: 3902
	[Token(Token = "0x4000F3E")]
	[FieldOffset(Offset = "0xD0")]
	private readonly HashSet<WorldObject> _environmentHittables;

	// Token: 0x04000F3F RID: 3903
	[Token(Token = "0x4000F3F")]
	[FieldOffset(Offset = "0xD8")]
	private readonly HashSet<Tutorial> _tutorials;

	// Token: 0x04000F40 RID: 3904
	[Token(Token = "0x4000F40")]
	[FieldOffset(Offset = "0xE0")]
	private readonly HashSet<MonoBehaviour> _trackedObjects;

	// Token: 0x04000F41 RID: 3905
	[Token(Token = "0x4000F41")]
	[FieldOffset(Offset = "0xE8")]
	private readonly Dictionary<EntityMasks, WorldObject[]> _hittableCache;

	// Token: 0x04000F42 RID: 3906
	[Token(Token = "0x4000F42")]
	[FieldOffset(Offset = "0xF0")]
	private readonly Dictionary<long, Character> _characters;

	// Token: 0x04000F43 RID: 3907
	[Token(Token = "0x4000F43")]
	[FieldOffset(Offset = "0xF8")]
	private Attack[] _attacks;

	// Token: 0x04000F44 RID: 3908
	[Token(Token = "0x4000F44")]
	[FieldOffset(Offset = "0x100")]
	private int _attackCount;

	// Token: 0x04000F45 RID: 3909
	[Token(Token = "0x4000F45")]
	[FieldOffset(Offset = "0x108")]
	private Map _map;

	// Token: 0x04000F46 RID: 3910
	[Token(Token = "0x4000F46")]
	[FieldOffset(Offset = "0x110")]
	private Entity _controlledEntity;

	// Token: 0x04000F47 RID: 3911
	[Token(Token = "0x4000F47")]
	[FieldOffset(Offset = "0x118")]
	private Manager[] _managers;

	// Token: 0x04000F48 RID: 3912
	[Token(Token = "0x4000F48")]
	[FieldOffset(Offset = "0x120")]
	private Option _mainMenuOption;

	// Token: 0x04000F49 RID: 3913
	[Token(Token = "0x4000F49")]
	[FieldOffset(Offset = "0x128")]
	private Option _interactOption;

	// Token: 0x04000F4A RID: 3914
	[Token(Token = "0x4000F4A")]
	[FieldOffset(Offset = "0x130")]
	private bool _interactState;

	// Token: 0x04000F4B RID: 3915
	[Token(Token = "0x4000F4B")]
	[FieldOffset(Offset = "0x134")]
	private float _lastNetworkTime;

	// Token: 0x04000F4C RID: 3916
	[Token(Token = "0x4000F4C")]
	[FieldOffset(Offset = "0x138")]
	private ChatIdData? _lastChatId;

	// Token: 0x04000F4D RID: 3917
	[Token(Token = "0x4000F4D")]
	[FieldOffset(Offset = "0x148")]
	private ChatOwnerData? _lastChatOwner;

	// Token: 0x04000F4E RID: 3918
	[Token(Token = "0x4000F4E")]
	[FieldOffset(Offset = "0x168")]
	private readonly List<string> _chatTokens;

	// Token: 0x04000F4F RID: 3919
	[Token(Token = "0x4000F4F")]
	[FieldOffset(Offset = "0x170")]
	private uint _handlingEntityId;

	// Token: 0x04000F50 RID: 3920
	[Token(Token = "0x4000F50")]
	[FieldOffset(Offset = "0x178")]
	private Entity _handlingEntity;

	// Token: 0x04000F51 RID: 3921
	[Token(Token = "0x4000F51")]
	[FieldOffset(Offset = "0x180")]
	private GlobalLightData? _globalLightData;

	// Token: 0x04000F52 RID: 3922
	[Token(Token = "0x4000F52")]
	[FieldOffset(Offset = "0x188")]
	private WeatherState _weather;

	// Token: 0x04000F53 RID: 3923
	[Token(Token = "0x4000F53")]
	[FieldOffset(Offset = "0x1B0")]
	private Entity _boss;

	// Token: 0x04000F54 RID: 3924
	[Token(Token = "0x4000F54")]
	[FieldOffset(Offset = "0x1B8")]
	private WorldObject _closestInteractable;

	// Token: 0x04000F55 RID: 3925
	[Token(Token = "0x4000F55")]
	[FieldOffset(Offset = "0x1C0")]
	private DiscoveryTexture _discoveryTexture;

	// Token: 0x04000F56 RID: 3926
	[Token(Token = "0x4000F56")]
	[FieldOffset(Offset = "0x1C8")]
	private bool _didLoad;

	// Token: 0x04000F57 RID: 3927
	[Token(Token = "0x4000F57")]
	[FieldOffset(Offset = "0x1C9")]
	private bool _didWaitAfterLoad;

	// Token: 0x04000F58 RID: 3928
	[Token(Token = "0x4000F58")]
	[FieldOffset(Offset = "0x1D0")]
	private ChatFilter _chatFilter;

	// Token: 0x04000F59 RID: 3929
	[Token(Token = "0x4000F59")]
	[FieldOffset(Offset = "0x1D8")]
	private Option _chatFilterOption;

	// Token: 0x04000F5A RID: 3930
	[Token(Token = "0x4000F5A")]
	[FieldOffset(Offset = "0x1E0")]
	private Option _playerChatBubblesOption;

	// Token: 0x04000F5B RID: 3931
	[Token(Token = "0x4000F5B")]
	[FieldOffset(Offset = "0x1E8")]
	private Option _npcChatBubblesOption;

	// Token: 0x04000F5C RID: 3932
	[Token(Token = "0x4000F5C")]
	[FieldOffset(Offset = "0x1F0")]
	private Option _enemyChatBubblesOption;

	// Token: 0x04000F5D RID: 3933
	[Token(Token = "0x4000F5D")]
	[FieldOffset(Offset = "0x1F8")]
	private Option _cameraFollowStyleOption;

	// Token: 0x04000F5E RID: 3934
	[Token(Token = "0x4000F5E")]
	[FieldOffset(Offset = "0x200")]
	private uint? _lastDropId;

	// Token: 0x04000F5F RID: 3935
	[Token(Token = "0x4000F5F")]
	[FieldOffset(Offset = "0x208")]
	private bool _disconnected;

	// Token: 0x04000F60 RID: 3936
	[Token(Token = "0x4000F60")]
	[FieldOffset(Offset = "0x210")]
	private WorldObject _targeted;

	// Token: 0x04000F61 RID: 3937
	[Token(Token = "0x4000F61")]
	[FieldOffset(Offset = "0x218")]
	private bool _setCamera;

	// Token: 0x04000F62 RID: 3938
	[Token(Token = "0x4000F62")]
	[FieldOffset(Offset = "0x21C")]
	private int _firstControlCeiling;

	// Token: 0x04000F63 RID: 3939
	[Token(Token = "0x4000F63")]
	[FieldOffset(Offset = "0x220")]
	private MapInfoData _mapInfo;

	// Token: 0x04000F64 RID: 3940
	[Token(Token = "0x4000F64")]
	[FieldOffset(Offset = "0x27C")]
	private uint _time;
}
