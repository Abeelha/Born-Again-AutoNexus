using System;
using Il2CppDummyDll;
using UnityEngine;

namespace MapEditor
{
	// Token: 0x0200037E RID: 894
	[Token(Token = "0x200037E")]
	public abstract class MapEditorTool
	{
		// Token: 0x06001444 RID: 5188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001444")]
		[Address(RVA = "0x316090", Offset = "0x315290", VA = "0x180316090", Slot = "4")]
		public virtual void Begin(Vector2 coordinates, MapEditorContext context)
		{
		}

		// Token: 0x06001445 RID: 5189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001445")]
		[Address(RVA = "0x316090", Offset = "0x315290", VA = "0x180316090", Slot = "5")]
		public virtual void Cancel(MapEditorContext context)
		{
		}

		// Token: 0x06001446 RID: 5190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001446")]
		[Address(RVA = "0x316090", Offset = "0x315290", VA = "0x180316090", Slot = "6")]
		public virtual void CancelInactive(MapEditorContext context)
		{
		}

		// Token: 0x06001447 RID: 5191 RVA: 0x000071A0 File Offset: 0x000053A0
		[Token(Token = "0x6001447")]
		[Address(RVA = "0x316110", Offset = "0x315310", VA = "0x180316110", Slot = "7")]
		public virtual bool Decrease(int index)
		{
			return default(bool);
		}

		// Token: 0x06001448 RID: 5192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001448")]
		[Address(RVA = "0x316090", Offset = "0x315290", VA = "0x180316090", Slot = "8")]
		public virtual void End(Vector2 coordinates, MapEditorContext context)
		{
		}

		// Token: 0x06001449 RID: 5193 RVA: 0x000071B8 File Offset: 0x000053B8
		[Token(Token = "0x6001449")]
		[Address(RVA = "0x316110", Offset = "0x315310", VA = "0x180316110", Slot = "9")]
		public virtual bool Increase(int index)
		{
			return default(bool);
		}

		// Token: 0x0600144A RID: 5194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600144A")]
		[Address(RVA = "0x316090", Offset = "0x315290", VA = "0x180316090", Slot = "10")]
		public virtual void Update(Vector2 coordinates, MapEditorContext context)
		{
		}

		// Token: 0x0600144B RID: 5195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600144B")]
		[Address(RVA = "0x316090", Offset = "0x315290", VA = "0x180316090", Slot = "11")]
		public virtual void UpdateInactive(Vector2 coordinates, MapEditorContext context)
		{
		}

		// Token: 0x0600144C RID: 5196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600144C")]
		[Address(RVA = "0x39C680", Offset = "0x39B880", VA = "0x18039C680")]
		protected MapEditorTool()
		{
		}

		// Token: 0x0400105D RID: 4189
		[Token(Token = "0x400105D")]
		[FieldOffset(Offset = "0x10")]
		public string IndicatorText;
	}
}
