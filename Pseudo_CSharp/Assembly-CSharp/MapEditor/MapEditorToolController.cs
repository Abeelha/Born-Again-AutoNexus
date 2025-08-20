using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace MapEditor
{
	// Token: 0x0200037F RID: 895
	[Token(Token = "0x200037F")]
	public class MapEditorToolController : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		// Token: 0x0600144D RID: 5197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600144D")]
		[Address(RVA = "0x39B820", Offset = "0x39AA20", VA = "0x18039B820", Slot = "4")]
		public void OnPointerDown(PointerEventData eventData)
		{
		}

		// Token: 0x0600144E RID: 5198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600144E")]
		[Address(RVA = "0x39B8D0", Offset = "0x39AAD0", VA = "0x18039B8D0", Slot = "5")]
		public void OnPointerUp(PointerEventData eventData)
		{
		}

		// Token: 0x0600144F RID: 5199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600144F")]
		[Address(RVA = "0x39B950", Offset = "0x39AB50", VA = "0x18039B950")]
		public void SetAltTool(MapEditorToolType type)
		{
		}

		// Token: 0x06001450 RID: 5200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001450")]
		[Address(RVA = "0x39BB20", Offset = "0x39AD20", VA = "0x18039BB20")]
		public void SetTool(MapEditorToolType type)
		{
		}

		// Token: 0x06001451 RID: 5201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001451")]
		[Address(RVA = "0x39B220", Offset = "0x39A420", VA = "0x18039B220")]
		private void Awake()
		{
		}

		// Token: 0x06001452 RID: 5202 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001452")]
		[Address(RVA = "0x39B800", Offset = "0x39AA00", VA = "0x18039B800")]
		private MapEditorToolController.ToolHandler GetTool(int pointerId)
		{
			return null;
		}

		// Token: 0x06001453 RID: 5203 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001453")]
		[Address(RVA = "0x39B360", Offset = "0x39A560", VA = "0x18039B360")]
		private MapEditorTool GetToolFromType(MapEditorToolType type)
		{
			return null;
		}

		// Token: 0x06001454 RID: 5204 RVA: 0x000071D0 File Offset: 0x000053D0
		[Token(Token = "0x6001454")]
		[Address(RVA = "0x39B700", Offset = "0x39A900", VA = "0x18039B700")]
		private Vector2 GetToolPosition()
		{
			return default(Vector2);
		}

		// Token: 0x06001455 RID: 5205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001455")]
		[Address(RVA = "0x39BCF0", Offset = "0x39AEF0", VA = "0x18039BCF0")]
		private void Start()
		{
		}

		// Token: 0x06001456 RID: 5206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001456")]
		[Address(RVA = "0x39C010", Offset = "0x39B210", VA = "0x18039C010")]
		private void Update()
		{
		}

		// Token: 0x06001457 RID: 5207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001457")]
		[Address(RVA = "0x39BD20", Offset = "0x39AF20", VA = "0x18039BD20")]
		private void UpdateTools()
		{
		}

		// Token: 0x06001458 RID: 5208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001458")]
		[Address(RVA = "0x39C020", Offset = "0x39B220", VA = "0x18039C020")]
		public MapEditorToolController()
		{
		}

		// Token: 0x0400105E RID: 4190
		[Token(Token = "0x400105E")]
		[FieldOffset(Offset = "0x20")]
		public MapEditorContext Context;

		// Token: 0x0400105F RID: 4191
		[Token(Token = "0x400105F")]
		[FieldOffset(Offset = "0x28")]
		public MapEditorToolBar ToolBar;

		// Token: 0x04001060 RID: 4192
		[Token(Token = "0x4001060")]
		[FieldOffset(Offset = "0x30")]
		private readonly MapEditorToolController.ToolHandler _currentTool;

		// Token: 0x04001061 RID: 4193
		[Token(Token = "0x4001061")]
		[FieldOffset(Offset = "0x38")]
		private readonly MapEditorToolController.ToolHandler _currentAltTool;

		// Token: 0x04001062 RID: 4194
		[Token(Token = "0x4001062")]
		[FieldOffset(Offset = "0x40")]
		private readonly MapEditorToolController.ToolHandler _translateTool;

		// Token: 0x04001063 RID: 4195
		[Token(Token = "0x4001063")]
		[FieldOffset(Offset = "0x48")]
		private readonly MapEditorToolController.HoldableButton[] _increases;

		// Token: 0x04001064 RID: 4196
		[Token(Token = "0x4001064")]
		[FieldOffset(Offset = "0x50")]
		private readonly MapEditorToolController.HoldableButton[] _decreases;

		// Token: 0x04001065 RID: 4197
		[Token(Token = "0x4001065")]
		[FieldOffset(Offset = "0x58")]
		private readonly Dictionary<MapEditorToolType, MapEditorTool> _tools;

		// Token: 0x02000380 RID: 896
		[Token(Token = "0x2000380")]
		private struct HoldableButton
		{
			// Token: 0x06001459 RID: 5209 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001459")]
			[Address(RVA = "0x394110", Offset = "0x393310", VA = "0x180394110")]
			public HoldableButton(KeyCode keyCode)
			{
			}

			// Token: 0x0600145A RID: 5210 RVA: 0x000071E8 File Offset: 0x000053E8
			[Token(Token = "0x600145A")]
			[Address(RVA = "0x3940A0", Offset = "0x3932A0", VA = "0x1803940A0")]
			public bool Activated()
			{
				return default(bool);
			}

			// Token: 0x04001066 RID: 4198
			[Token(Token = "0x4001066")]
			[FieldOffset(Offset = "0x0")]
			public readonly KeyCode KeyCode;

			// Token: 0x04001067 RID: 4199
			[Token(Token = "0x4001067")]
			[FieldOffset(Offset = "0x4")]
			private float _lastTime;
		}

		// Token: 0x02000381 RID: 897
		[Token(Token = "0x2000381")]
		private class ToolHandler
		{
			// Token: 0x17000217 RID: 535
			// (get) Token: 0x0600145B RID: 5211 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x17000217")]
			public string IndicatorText
			{
				[Token(Token = "0x600145B")]
				[Address(RVA = "0x3A9310", Offset = "0x3A8510", VA = "0x1803A9310")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600145C RID: 5212 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600145C")]
			[Address(RVA = "0x3A9040", Offset = "0x3A8240", VA = "0x1803A9040")]
			public void BeginTool(Vector2 position, MapEditorContext context)
			{
			}

			// Token: 0x0600145D RID: 5213 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600145D")]
			[Address(RVA = "0x3A90C0", Offset = "0x3A82C0", VA = "0x1803A90C0")]
			public void CancelTool(MapEditorContext context)
			{
			}

			// Token: 0x0600145E RID: 5214 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600145E")]
			[Address(RVA = "0x3A9120", Offset = "0x3A8320", VA = "0x1803A9120")]
			public void Decrease(int index)
			{
			}

			// Token: 0x0600145F RID: 5215 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600145F")]
			[Address(RVA = "0x3A9150", Offset = "0x3A8350", VA = "0x1803A9150")]
			public void EndTool(Vector2 position, MapEditorContext context)
			{
			}

			// Token: 0x06001460 RID: 5216 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001460")]
			[Address(RVA = "0x3A9190", Offset = "0x3A8390", VA = "0x1803A9190")]
			public void Increase(int index)
			{
			}

			// Token: 0x06001461 RID: 5217 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001461")]
			[Address(RVA = "0x3A91C0", Offset = "0x3A83C0", VA = "0x1803A91C0")]
			public void SetTool(MapEditorTool tool, MapEditorContext context)
			{
			}

			// Token: 0x06001462 RID: 5218 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001462")]
			[Address(RVA = "0x3A92C0", Offset = "0x3A84C0", VA = "0x1803A92C0")]
			public void UpdateTool(Vector2 position, MapEditorContext context)
			{
			}

			// Token: 0x06001463 RID: 5219 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001463")]
			[Address(RVA = "0x316100", Offset = "0x315300", VA = "0x180316100")]
			public ToolHandler()
			{
			}

			// Token: 0x04001068 RID: 4200
			[Token(Token = "0x4001068")]
			[FieldOffset(Offset = "0x10")]
			private MapEditorTool _tool;

			// Token: 0x04001069 RID: 4201
			[Token(Token = "0x4001069")]
			[FieldOffset(Offset = "0x18")]
			private bool _toolBegan;
		}
	}
}
