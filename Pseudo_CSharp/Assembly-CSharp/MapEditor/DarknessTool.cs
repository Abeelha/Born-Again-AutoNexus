using System;
using Il2CppDummyDll;
using UnityEngine;

namespace MapEditor
{
	// Token: 0x0200039F RID: 927
	[Token(Token = "0x200039F")]
	public class DarknessTool : MapEditorTool
	{
		// Token: 0x0600154B RID: 5451 RVA: 0x000075D8 File Offset: 0x000057D8
		[Token(Token = "0x600154B")]
		[Address(RVA = "0x3B1230", Offset = "0x3B0430", VA = "0x1803B1230", Slot = "7")]
		public override bool Decrease(int index)
		{
			return default(bool);
		}

		// Token: 0x0600154C RID: 5452 RVA: 0x000075F0 File Offset: 0x000057F0
		[Token(Token = "0x600154C")]
		[Address(RVA = "0x3B1240", Offset = "0x3B0440", VA = "0x1803B1240", Slot = "9")]
		public override bool Increase(int index)
		{
			return default(bool);
		}

		// Token: 0x0600154D RID: 5453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600154D")]
		[Address(RVA = "0x3B1250", Offset = "0x3B0450", VA = "0x1803B1250", Slot = "10")]
		public override void Update(Vector2 coordinates, MapEditorContext context)
		{
		}

		// Token: 0x0600154E RID: 5454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600154E")]
		[Address(RVA = "0x3B1250", Offset = "0x3B0450", VA = "0x1803B1250", Slot = "11")]
		public override void UpdateInactive(Vector2 coordinates, MapEditorContext context)
		{
		}

		// Token: 0x0600154F RID: 5455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600154F")]
		[Address(RVA = "0x3B1260", Offset = "0x3B0460", VA = "0x1803B1260")]
		private void UpdateIndicatorText()
		{
		}

		// Token: 0x06001550 RID: 5456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001550")]
		[Address(RVA = "0x3B1300", Offset = "0x3B0500", VA = "0x1803B1300")]
		public DarknessTool()
		{
		}

		// Token: 0x0400110C RID: 4364
		[Token(Token = "0x400110C")]
		[FieldOffset(Offset = "0x18")]
		private byte _darkness;

		// Token: 0x0400110D RID: 4365
		[Token(Token = "0x400110D")]
		[FieldOffset(Offset = "0x19")]
		private byte _syncedDarkness;
	}
}
