using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Il2CppDummyDll;
using Ronin.Model.Data;
using Ronin.Model.Definitions;
using Ronin.Model.Enums;
using Ronin.Model.Simulation;
using Ronin.Model.Structs;
using UnityEngine;
using UnityEngine.UI;
using UnnamedStudios;

// Token: 0x02000262 RID: 610
[Token(Token = "0x2000262")]
public class UIManager : Manager
{
	// Token: 0x06000B93 RID: 2963 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B93")]
	[Address(RVA = "0x443930", Offset = "0x442B30", VA = "0x180443930")]
	public void AddChat(Chat chat)
	{
	}

	// Token: 0x06000B94 RID: 2964 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B94")]
	[Address(RVA = "0x444080", Offset = "0x443280", VA = "0x180444080")]
	public void ClearSlots()
	{
	}

	// Token: 0x06000B95 RID: 2965 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B95")]
	[Address(RVA = "0x316090", Offset = "0x315290", VA = "0x180316090")]
	public void CloseTutorial()
	{
	}

	// Token: 0x06000B96 RID: 2966 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B96")]
	[Address(RVA = "0x444380", Offset = "0x443580", VA = "0x180444380")]
	public void LanguageChanged()
	{
	}

	// Token: 0x06000B97 RID: 2967 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B97")]
	[Address(RVA = "0x4449E0", Offset = "0x443BE0", VA = "0x1804449E0")]
	public void NewMap(Vector2Int mapSize)
	{
	}

	// Token: 0x06000B98 RID: 2968 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B98")]
	[Address(RVA = "0x444AF0", Offset = "0x443CF0", VA = "0x180444AF0", Slot = "6")]
	public override void NewWorld(ref MapInfoData mapInfoData)
	{
	}

	// Token: 0x06000B99 RID: 2969 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B99")]
	[Address(RVA = "0x445060", Offset = "0x444260", VA = "0x180445060")]
	public void OnControlEntity(uint entityId, WorldObject entity)
	{
	}

	// Token: 0x06000B9A RID: 2970 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B9A")]
	[Address(RVA = "0x4453A0", Offset = "0x4445A0", VA = "0x1804453A0")]
	public void OnDeath(ref DeathData deathData, Simulation simulation)
	{
	}

	// Token: 0x06000B9B RID: 2971 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B9B")]
	[Address(RVA = "0x4455A0", Offset = "0x4447A0", VA = "0x1804455A0")]
	public void ReloadTextures()
	{
	}

	// Token: 0x06000B9C RID: 2972 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B9C")]
	[Address(RVA = "0x445730", Offset = "0x444930", VA = "0x180445730")]
	public void SaveClip()
	{
	}

	// Token: 0x06000B9D RID: 2973 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000B9D")]
	[Address(RVA = "0x445660", Offset = "0x444860", VA = "0x180445660")]
	public Task SaveClipAsync()
	{
		return null;
	}

	// Token: 0x06000B9E RID: 2974 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B9E")]
	[Address(RVA = "0x445740", Offset = "0x444940", VA = "0x180445740")]
	public void SetConnecting(bool connecting)
	{
	}

	// Token: 0x06000B9F RID: 2975 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B9F")]
	[Address(RVA = "0x445870", Offset = "0x444A70", VA = "0x180445870")]
	public void SetEquippedArmor(ushort type)
	{
	}

	// Token: 0x06000BA0 RID: 2976 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BA0")]
	[Address(RVA = "0x445910", Offset = "0x444B10", VA = "0x180445910")]
	public void SetEquippedWeapon(ushort type)
	{
	}

	// Token: 0x06000BA1 RID: 2977 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BA1")]
	[Address(RVA = "0x4459B0", Offset = "0x444BB0", VA = "0x1804459B0")]
	public void SetExperience(ulong experience, int level, ulong honor, BlessingsData blessings)
	{
	}

	// Token: 0x06000BA2 RID: 2978 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BA2")]
	[Address(RVA = "0x445AE0", Offset = "0x444CE0", VA = "0x180445AE0")]
	public void SetFocus(Vector2 focus)
	{
	}

	// Token: 0x06000BA3 RID: 2979 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BA3")]
	[Address(RVA = "0x445BC0", Offset = "0x444DC0", VA = "0x180445BC0")]
	public void SetPickupItems(IEnumerable<IPickupContainer> containers)
	{
	}

	// Token: 0x06000BA4 RID: 2980 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BA4")]
	[Address(RVA = "0x445D10", Offset = "0x444F10", VA = "0x180445D10")]
	public void SetTile(CoordTile tile)
	{
	}

	// Token: 0x06000BA5 RID: 2981 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BA5")]
	[Address(RVA = "0x445DB0", Offset = "0x444FB0", VA = "0x180445DB0")]
	public void ShareFile(string filePath)
	{
	}

	// Token: 0x06000BA6 RID: 2982 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BA6")]
	[Address(RVA = "0x446130", Offset = "0x445330", VA = "0x180446130")]
	public void ToggleMap()
	{
	}

	// Token: 0x06000BA7 RID: 2983 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BA7")]
	[Address(RVA = "0x446200", Offset = "0x445400", VA = "0x180446200")]
	public void ToggleOptions()
	{
	}

	// Token: 0x06000BA8 RID: 2984 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BA8")]
	[Address(RVA = "0x446000", Offset = "0x445200", VA = "0x180446000")]
	public void ShowTravelMenu(uint entityId)
	{
	}

	// Token: 0x06000BA9 RID: 2985 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BA9")]
	[Address(RVA = "0x4460A0", Offset = "0x4452A0", VA = "0x1804460A0")]
	public void ShowTutorialMenu()
	{
	}

	// Token: 0x06000BAA RID: 2986 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BAA")]
	[Address(RVA = "0x443A20", Offset = "0x442C20", VA = "0x180443A20")]
	private void Awake()
	{
	}

	// Token: 0x06000BAB RID: 2987 RVA: 0x00004ED8 File Offset: 0x000030D8
	[Token(Token = "0x6000BAB")]
	[Address(RVA = "0x4441B0", Offset = "0x4433B0", VA = "0x1804441B0")]
	private ValueTuple<bool, string> GetChatButtonActions()
	{
		return default(ValueTuple<bool, string>);
	}

	// Token: 0x06000BAC RID: 2988 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000BAC")]
	[Address(RVA = "0x4442B0", Offset = "0x4434B0", VA = "0x1804442B0")]
	private Slot GetFirstEquipSlot(ushort type)
	{
		return null;
	}

	// Token: 0x06000BAD RID: 2989 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BAD")]
	[Address(RVA = "0x4443B0", Offset = "0x4435B0", VA = "0x1804443B0")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000BAE RID: 2990 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BAE")]
	[Address(RVA = "0x444E20", Offset = "0x444020", VA = "0x180444E20")]
	private void OnCaptureEnabledChange(Option option)
	{
	}

	// Token: 0x06000BAF RID: 2991 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BAF")]
	[Address(RVA = "0x444F20", Offset = "0x444120", VA = "0x180444F20")]
	private void OnCaptureOptionChange(Option option)
	{
	}

	// Token: 0x06000BB0 RID: 2992 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BB0")]
	[Address(RVA = "0x445410", Offset = "0x444610", VA = "0x180445410")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000BB1 RID: 2993 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BB1")]
	[Address(RVA = "0x4462D0", Offset = "0x4454D0", VA = "0x1804462D0")]
	private void ToggleQuest()
	{
	}

	// Token: 0x06000BB2 RID: 2994 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BB2")]
	[Address(RVA = "0x4463C0", Offset = "0x4455C0", VA = "0x1804463C0")]
	private void UpdateBadConnection()
	{
	}

	// Token: 0x06000BB3 RID: 2995 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BB3")]
	[Address(RVA = "0x446470", Offset = "0x445670", VA = "0x180446470")]
	private void UpdateBlessings()
	{
	}

	// Token: 0x06000BB4 RID: 2996 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BB4")]
	[Address(RVA = "0x4465D0", Offset = "0x4457D0", VA = "0x1804465D0")]
	private void UpdateBoss()
	{
	}

	// Token: 0x06000BB5 RID: 2997 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BB5")]
	[Address(RVA = "0x446770", Offset = "0x445970", VA = "0x180446770")]
	private void UpdateChatInput()
	{
	}

	// Token: 0x06000BB6 RID: 2998 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BB6")]
	[Address(RVA = "0x446910", Offset = "0x445B10", VA = "0x180446910")]
	private void UpdateCloseOnDamage()
	{
	}

	// Token: 0x06000BB7 RID: 2999 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BB7")]
	[Address(RVA = "0x446BA0", Offset = "0x445DA0", VA = "0x180446BA0")]
	private void UpdateCooldowns()
	{
	}

	// Token: 0x06000BB8 RID: 3000 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BB8")]
	[Address(RVA = "0x446A10", Offset = "0x445C10", VA = "0x180446A10")]
	private void UpdateCooldown(int index, int energyValue, int max, ItemDefinition itemDefinition)
	{
	}

	// Token: 0x06000BB9 RID: 3001 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BB9")]
	[Address(RVA = "0x446DD0", Offset = "0x445FD0", VA = "0x180446DD0")]
	private void UpdateExperience()
	{
	}

	// Token: 0x06000BBA RID: 3002 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BBA")]
	[Address(RVA = "0x446F20", Offset = "0x446120", VA = "0x180446F20")]
	private void UpdateInventory()
	{
	}

	// Token: 0x06000BBB RID: 3003 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BBB")]
	[Address(RVA = "0x4471A0", Offset = "0x4463A0", VA = "0x1804471A0")]
	private void UpdateQuest()
	{
	}

	// Token: 0x06000BBC RID: 3004 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BBC")]
	[Address(RVA = "0x447A50", Offset = "0x446C50", VA = "0x180447A50")]
	private void UpdateStat(StatType statType)
	{
	}

	// Token: 0x06000BBD RID: 3005 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BBD")]
	[Address(RVA = "0x4478F0", Offset = "0x446AF0", VA = "0x1804478F0")]
	private void UpdateStat(StatType statType, int value)
	{
	}

	// Token: 0x06000BBE RID: 3006 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BBE")]
	[Address(RVA = "0x447BA0", Offset = "0x446DA0", VA = "0x180447BA0")]
	private void UpdateStats()
	{
	}

	// Token: 0x06000BBF RID: 3007 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BBF")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public UIManager()
	{
	}

	// Token: 0x04000A3E RID: 2622
	[Token(Token = "0x4000A3E")]
	[FieldOffset(Offset = "0x28")]
	public World World;

	// Token: 0x04000A3F RID: 2623
	[Token(Token = "0x4000A3F")]
	[FieldOffset(Offset = "0x30")]
	public ChatInput ChatInput;

	// Token: 0x04000A40 RID: 2624
	[Token(Token = "0x4000A40")]
	[FieldOffset(Offset = "0x38")]
	public ChatContainer[] ChatContainers;

	// Token: 0x04000A41 RID: 2625
	[Token(Token = "0x4000A41")]
	[FieldOffset(Offset = "0x40")]
	public ConnectingScreen Connecting;

	// Token: 0x04000A42 RID: 2626
	[Token(Token = "0x4000A42")]
	[FieldOffset(Offset = "0x48")]
	public Image PortraitImage;

	// Token: 0x04000A43 RID: 2627
	[Token(Token = "0x4000A43")]
	[FieldOffset(Offset = "0x50")]
	public PickupSlotContainer PickupSlotContainer;

	// Token: 0x04000A44 RID: 2628
	[Token(Token = "0x4000A44")]
	[FieldOffset(Offset = "0x58")]
	public SlotController SlotController;

	// Token: 0x04000A45 RID: 2629
	[Token(Token = "0x4000A45")]
	[FieldOffset(Offset = "0x60")]
	public GameObject InventoryCluster;

	// Token: 0x04000A46 RID: 2630
	[Token(Token = "0x4000A46")]
	[FieldOffset(Offset = "0x68")]
	public DeathScreen DeathScreen;

	// Token: 0x04000A47 RID: 2631
	[Token(Token = "0x4000A47")]
	[FieldOffset(Offset = "0x70")]
	public BlessingStrand BlessingStrand;

	// Token: 0x04000A48 RID: 2632
	[Token(Token = "0x4000A48")]
	[FieldOffset(Offset = "0x78")]
	public ExperienceContainer ExperienceContainer;

	// Token: 0x04000A49 RID: 2633
	[Token(Token = "0x4000A49")]
	[FieldOffset(Offset = "0x80")]
	public ExperienceOrbs ExperienceOrbs;

	// Token: 0x04000A4A RID: 2634
	[Token(Token = "0x4000A4A")]
	[FieldOffset(Offset = "0x88")]
	public MinimapTexture MinimapTexture;

	// Token: 0x04000A4B RID: 2635
	[Token(Token = "0x4000A4B")]
	[FieldOffset(Offset = "0x90")]
	public Minimap MapMinimap;

	// Token: 0x04000A4C RID: 2636
	[Token(Token = "0x4000A4C")]
	[FieldOffset(Offset = "0x98")]
	public TravelMinimap TravelMinimap;

	// Token: 0x04000A4D RID: 2637
	[Token(Token = "0x4000A4D")]
	[FieldOffset(Offset = "0xA0")]
	public TradeMenu TradeMenu;

	// Token: 0x04000A4E RID: 2638
	[Token(Token = "0x4000A4E")]
	[FieldOffset(Offset = "0xA8")]
	public RequestContainer Requests;

	// Token: 0x04000A4F RID: 2639
	[Token(Token = "0x4000A4F")]
	[FieldOffset(Offset = "0xB0")]
	public BossUI BossUI;

	// Token: 0x04000A50 RID: 2640
	[Token(Token = "0x4000A50")]
	[FieldOffset(Offset = "0xB8")]
	public Compass Compass;

	// Token: 0x04000A51 RID: 2641
	[Token(Token = "0x4000A51")]
	[FieldOffset(Offset = "0xC0")]
	public MerchantMenu MerchantMenu;

	// Token: 0x04000A52 RID: 2642
	[Token(Token = "0x4000A52")]
	[FieldOffset(Offset = "0xC8")]
	public Menu TutorialMenu;

	// Token: 0x04000A53 RID: 2643
	[Token(Token = "0x4000A53")]
	[FieldOffset(Offset = "0xD0")]
	public Menu TravelMenu;

	// Token: 0x04000A54 RID: 2644
	[Token(Token = "0x4000A54")]
	[FieldOffset(Offset = "0xD8")]
	public Menu OptionsMenu;

	// Token: 0x04000A55 RID: 2645
	[Token(Token = "0x4000A55")]
	[FieldOffset(Offset = "0xE0")]
	public Menu MapMenu;

	// Token: 0x04000A56 RID: 2646
	[Token(Token = "0x4000A56")]
	[FieldOffset(Offset = "0xE8")]
	public Menu MenuController;

	// Token: 0x04000A57 RID: 2647
	[Token(Token = "0x4000A57")]
	[FieldOffset(Offset = "0xF0")]
	public GameObject BadConnection;

	// Token: 0x04000A58 RID: 2648
	[Token(Token = "0x4000A58")]
	[FieldOffset(Offset = "0xF8")]
	public PartyController Party;

	// Token: 0x04000A59 RID: 2649
	[Token(Token = "0x4000A59")]
	[FieldOffset(Offset = "0x100")]
	public CameraCapture Capture;

	// Token: 0x04000A5A RID: 2650
	[Token(Token = "0x4000A5A")]
	[FieldOffset(Offset = "0x108")]
	public GraphicRaycaster Raycaster;

	// Token: 0x04000A5B RID: 2651
	[Token(Token = "0x4000A5B")]
	[FieldOffset(Offset = "0x110")]
	public TooltipBuilder WorldTooltips;

	// Token: 0x04000A5C RID: 2652
	[Token(Token = "0x4000A5C")]
	[FieldOffset(Offset = "0x118")]
	public BankMenu BankMenu;

	// Token: 0x04000A5D RID: 2653
	[Token(Token = "0x4000A5D")]
	[FieldOffset(Offset = "0x120")]
	public WardrobeMenu WardrobeMenu;

	// Token: 0x04000A5E RID: 2654
	[Token(Token = "0x4000A5E")]
	[FieldOffset(Offset = "0x128")]
	public MaintenanceBanner Maintenance;

	// Token: 0x04000A5F RID: 2655
	[Token(Token = "0x4000A5F")]
	[FieldOffset(Offset = "0x130")]
	public TutorialNotificationManager TutorialNotificationManager;

	// Token: 0x04000A60 RID: 2656
	[Token(Token = "0x4000A60")]
	[FieldOffset(Offset = "0x138")]
	public MobileAbilityButton[] MobileAbilityButtons;

	// Token: 0x04000A61 RID: 2657
	[Token(Token = "0x4000A61")]
	[FieldOffset(Offset = "0x140")]
	public RectTransform QuestAnchor;

	// Token: 0x04000A62 RID: 2658
	[Token(Token = "0x4000A62")]
	[FieldOffset(Offset = "0x148")]
	public Clock Clock;

	// Token: 0x04000A63 RID: 2659
	[Token(Token = "0x4000A63")]
	[FieldOffset(Offset = "0x150")]
	public UIManager.StatPair[] Stats;

	// Token: 0x04000A64 RID: 2660
	[Token(Token = "0x4000A64")]
	[FieldOffset(Offset = "0x158")]
	public Slot[] Slots;

	// Token: 0x04000A65 RID: 2661
	[Token(Token = "0x4000A65")]
	[FieldOffset(Offset = "0x160")]
	private Dictionary<StatType, WorldUIStat> _stats;

	// Token: 0x04000A66 RID: 2662
	[Token(Token = "0x4000A66")]
	[FieldOffset(Offset = "0x168")]
	private Option _chat;

	// Token: 0x04000A67 RID: 2663
	[Token(Token = "0x4000A67")]
	[FieldOffset(Offset = "0x170")]
	private Option _command;

	// Token: 0x04000A68 RID: 2664
	[Token(Token = "0x4000A68")]
	[FieldOffset(Offset = "0x178")]
	private Option _closeMenusOnDamage;

	// Token: 0x04000A69 RID: 2665
	[Token(Token = "0x4000A69")]
	[FieldOffset(Offset = "0x180")]
	private Option _captureFrameRate;

	// Token: 0x04000A6A RID: 2666
	[Token(Token = "0x4000A6A")]
	[FieldOffset(Offset = "0x188")]
	private Option _captureQuality;

	// Token: 0x04000A6B RID: 2667
	[Token(Token = "0x4000A6B")]
	[FieldOffset(Offset = "0x190")]
	private Option _saveClip;

	// Token: 0x04000A6C RID: 2668
	[Token(Token = "0x4000A6C")]
	[FieldOffset(Offset = "0x198")]
	private Option _captureEnabled;

	// Token: 0x04000A6D RID: 2669
	[Token(Token = "0x4000A6D")]
	[FieldOffset(Offset = "0x1A0")]
	private Option _showWorldChat;

	// Token: 0x04000A6E RID: 2670
	[Token(Token = "0x4000A6E")]
	[FieldOffset(Offset = "0x1A8")]
	private Option _toggleQuest;

	// Token: 0x04000A6F RID: 2671
	[Token(Token = "0x4000A6F")]
	[FieldOffset(Offset = "0x1B0")]
	private Option _questRolled;

	// Token: 0x04000A70 RID: 2672
	[Token(Token = "0x4000A70")]
	[FieldOffset(Offset = "0x1B8")]
	private int _syncedHonor;

	// Token: 0x04000A71 RID: 2673
	[Token(Token = "0x4000A71")]
	[FieldOffset(Offset = "0x1C0")]
	private Tooltip _questTooltip;

	// Token: 0x04000A72 RID: 2674
	[Token(Token = "0x4000A72")]
	[FieldOffset(Offset = "0x1C8")]
	private QuestProgressData _syncedProgress;

	// Token: 0x04000A73 RID: 2675
	[Token(Token = "0x4000A73")]
	[FieldOffset(Offset = "0x1DF")]
	private Inventory _syncedEquips;

	// Token: 0x02000263 RID: 611
	[Token(Token = "0x2000263")]
	[Serializable]
	public struct StatPair
	{
		// Token: 0x04000A74 RID: 2676
		[Token(Token = "0x4000A74")]
		[FieldOffset(Offset = "0x0")]
		public StatType StatType;

		// Token: 0x04000A75 RID: 2677
		[Token(Token = "0x4000A75")]
		[FieldOffset(Offset = "0x8")]
		public WorldUIStat WorldUIStat;
	}
}
