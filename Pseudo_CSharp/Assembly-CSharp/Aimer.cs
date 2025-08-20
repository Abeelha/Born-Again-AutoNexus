using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Ronin.Model.Definitions;
using Ronin.Model.GameActions;
using UnityEngine;

// Token: 0x020001D9 RID: 473
[Token(Token = "0x20001D9")]
public abstract class Aimer : MonoBehaviour
{
	// Token: 0x170000E6 RID: 230
	// (get) Token: 0x06000980 RID: 2432
	[Token(Token = "0x170000E6")]
	public abstract InputType InputType { [Token(Token = "0x6000980")] get; }

	// Token: 0x170000E7 RID: 231
	// (get) Token: 0x06000981 RID: 2433 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x170000E7")]
	protected Camera Camera
	{
		[Token(Token = "0x6000981")]
		[Address(RVA = "0x41D770", Offset = "0x41C970", VA = "0x18041D770")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000982 RID: 2434
	[Token(Token = "0x6000982")]
	public abstract Vector2 GetUseTarget(int index);

	// Token: 0x06000983 RID: 2435 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000983")]
	[Address(RVA = "0x41DA90", Offset = "0x41CC90", VA = "0x18041DA90")]
	public void HideGizmos()
	{
	}

	// Token: 0x06000984 RID: 2436 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000984")]
	[Address(RVA = "0x41D9F0", Offset = "0x41CBF0", VA = "0x18041D9F0")]
	public void HideGizmos(int index)
	{
	}

	// Token: 0x06000985 RID: 2437 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000985")]
	[Address(RVA = "0x41E130", Offset = "0x41D330", VA = "0x18041E130")]
	public void ShowGizmo(int index, GameObject sender, [Optional] int? pointerId)
	{
	}

	// Token: 0x06000986 RID: 2438 RVA: 0x00004620 File Offset: 0x00002820
	[Token(Token = "0x6000986")]
	[Address(RVA = "0x41D820", Offset = "0x41CA20", VA = "0x18041D820")]
	protected static ValueTuple<float, float> GetRange(ItemDefinition itemDefinition)
	{
		return default(ValueTuple<float, float>);
	}

	// Token: 0x06000987 RID: 2439 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000987")]
	[Address(RVA = "0x41DBF0", Offset = "0x41CDF0", VA = "0x18041DBF0", Slot = "6")]
	protected virtual void LateUpdate()
	{
	}

	// Token: 0x06000988 RID: 2440 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000988")]
	[Address(RVA = "0x316090", Offset = "0x315290", VA = "0x180316090", Slot = "7")]
	protected virtual void OnShowGizmo(int index, ItemDefinition itemDefinition, GameObject sender, [Optional] int? pointerId)
	{
	}

	// Token: 0x06000989 RID: 2441 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000989")]
	[Address(RVA = "0x41D770", Offset = "0x41C970", VA = "0x18041D770")]
	private Camera GetCamera()
	{
		return null;
	}

	// Token: 0x0600098A RID: 2442 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600098A")]
	[Address(RVA = "0x41DFC0", Offset = "0x41D1C0", VA = "0x18041DFC0")]
	private void Return(List<Gizmo> gizmoList)
	{
	}

	// Token: 0x0600098B RID: 2443 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600098B")]
	[Address(RVA = "0x41E600", Offset = "0x41D800", VA = "0x18041E600")]
	protected Aimer()
	{
	}

	// Token: 0x0600098C RID: 2444 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600098C")]
	[Address(RVA = "0x41E4B0", Offset = "0x41D6B0", VA = "0x18041E4B0")]
	[CompilerGenerated]
	internal static void <GetRange>g__getRange|11_0(GameAction[] actions, ref bool set, ref float minRange, ref float maxRange)
	{
	}

	// Token: 0x040008EC RID: 2284
	[Token(Token = "0x40008EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public World World;

	// Token: 0x040008ED RID: 2285
	[Token(Token = "0x40008ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Camera _camera;

	// Token: 0x040008EE RID: 2286
	[Token(Token = "0x40008EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Dictionary<int, List<Gizmo>> _gizmos;
}
