using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x020001B8 RID: 440
[Token(Token = "0x20001B8")]
public class Menu : MonoBehaviour
{
	// Token: 0x170000DA RID: 218
	// (get) Token: 0x060008C9 RID: 2249 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x170000DA")]
	public RectTransform RectTransform
	{
		[Token(Token = "0x60008C9")]
		[Address(RVA = "0x418FC0", Offset = "0x4181C0", VA = "0x180418FC0")]
		get
		{
			return null;
		}
	}

	// Token: 0x170000DB RID: 219
	// (get) Token: 0x060008CA RID: 2250 RVA: 0x00004368 File Offset: 0x00002568
	[Token(Token = "0x170000DB")]
	public int TaskCount
	{
		[Token(Token = "0x60008CA")]
		[Address(RVA = "0x419020", Offset = "0x418220", VA = "0x180419020")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170000DC RID: 220
	// (get) Token: 0x060008CB RID: 2251 RVA: 0x00004380 File Offset: 0x00002580
	[Token(Token = "0x170000DC")]
	public bool IsLoading
	{
		[Token(Token = "0x60008CB")]
		[Address(RVA = "0x418F70", Offset = "0x418170", VA = "0x180418F70")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060008CC RID: 2252 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008CC")]
	[Address(RVA = "0x418560", Offset = "0x417760", VA = "0x180418560")]
	public static void Start(Menu menu)
	{
	}

	// Token: 0x060008CD RID: 2253 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008CD")]
	[Address(RVA = "0x417450", Offset = "0x416650", VA = "0x180417450")]
	public void Error(string text, bool forceNoAlert = false)
	{
	}

	// Token: 0x060008CE RID: 2254 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008CE")]
	[Address(RVA = "0x417FE0", Offset = "0x4171E0", VA = "0x180417FE0")]
	public void Pop()
	{
	}

	// Token: 0x060008CF RID: 2255 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008CF")]
	[Address(RVA = "0x417F40", Offset = "0x417140", VA = "0x180417F40")]
	public void PopChild()
	{
	}

	// Token: 0x060008D0 RID: 2256 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008D0")]
	[Address(RVA = "0x4180F0", Offset = "0x4172F0", VA = "0x1804180F0")]
	public void Push(Menu menu)
	{
	}

	// Token: 0x060008D1 RID: 2257 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008D1")]
	[Address(RVA = "0x418430", Offset = "0x417630", VA = "0x180418430", Slot = "4")]
	public virtual void Show()
	{
	}

	// Token: 0x060008D2 RID: 2258 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008D2")]
	[Address(RVA = "0x418600", Offset = "0x417800", VA = "0x180418600")]
	public void Swap(Menu menu)
	{
	}

	// Token: 0x060008D3 RID: 2259 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008D3")]
	[Address(RVA = "0x418590", Offset = "0x417790", VA = "0x180418590")]
	public void SwapSub(Menu menu)
	{
	}

	// Token: 0x060008D4 RID: 2260 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008D4")]
	[Address(RVA = "0x418720", Offset = "0x417920", VA = "0x180418720")]
	public void Toggle()
	{
	}

	// Token: 0x060008D5 RID: 2261 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008D5")]
	[Address(RVA = "0x416D00", Offset = "0x415F00", VA = "0x180416D00")]
	protected void Alert(string title, string message)
	{
	}

	// Token: 0x060008D6 RID: 2262 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008D6")]
	[Address(RVA = "0x416E90", Offset = "0x416090", VA = "0x180416E90")]
	protected void AlertNotEnoughHonor()
	{
	}

	// Token: 0x060008D7 RID: 2263 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60008D7")]
	[Address(RVA = "0x417120", Offset = "0x416320", VA = "0x180417120")]
	protected Task AlertNotEnoughMedallionsAsync([Optional] string message)
	{
		return null;
	}

	// Token: 0x060008D8 RID: 2264 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60008D8")]
	[Address(RVA = "0x416D00", Offset = "0x415F00", VA = "0x180416D00")]
	protected Task AlertAsync(string title, string message)
	{
		return null;
	}

	// Token: 0x060008D9 RID: 2265 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60008D9")]
	[Address(RVA = "0x416D50", Offset = "0x415F50", VA = "0x180416D50")]
	protected Task<int> AlertAsync(string title, string message, params AlertButtonDescriptor[] buttons)
	{
		return null;
	}

	// Token: 0x060008DA RID: 2266 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008DA")]
	[Address(RVA = "0x417210", Offset = "0x416410", VA = "0x180417210")]
	protected void Enter()
	{
	}

	// Token: 0x060008DB RID: 2267 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008DB")]
	[Address(RVA = "0x4176F0", Offset = "0x4168F0", VA = "0x1804176F0")]
	protected void Exit()
	{
	}

	// Token: 0x060008DC RID: 2268 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008DC")]
	[Address(RVA = "0x316090", Offset = "0x315290", VA = "0x180316090", Slot = "5")]
	protected virtual void OnEnter()
	{
	}

	// Token: 0x060008DD RID: 2269 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008DD")]
	[Address(RVA = "0x316090", Offset = "0x315290", VA = "0x180316090", Slot = "6")]
	protected virtual void OnExit()
	{
	}

	// Token: 0x060008DE RID: 2270 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60008DE")]
	[Address(RVA = "0x418250", Offset = "0x417450", VA = "0x180418250")]
	protected LoadingFrame ShowLoading(Task task)
	{
		return null;
	}

	// Token: 0x060008DF RID: 2271 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60008DF")]
	[Address(RVA = "0x418300", Offset = "0x417500", VA = "0x180418300")]
	protected LoadingFrame ShowLoading(Task task, string text)
	{
		return null;
	}

	// Token: 0x060008E0 RID: 2272 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008E0")]
	[Address(RVA = "0x418580", Offset = "0x417780", VA = "0x180418580", Slot = "7")]
	protected virtual void Start()
	{
	}

	// Token: 0x060008E1 RID: 2273 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008E1")]
	[Address(RVA = "0x418770", Offset = "0x417970", VA = "0x180418770")]
	protected void TrackTask(Task task)
	{
	}

	// Token: 0x060008E2 RID: 2274 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008E2")]
	[Address(RVA = "0x418CB0", Offset = "0x417EB0", VA = "0x180418CB0", Slot = "8")]
	protected virtual void Update()
	{
	}

	// Token: 0x060008E3 RID: 2275 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60008E3")]
	[Address(RVA = "0x417780", Offset = "0x416980", VA = "0x180417780")]
	private static AlertButtonDescriptor[] GetDefaultButtons()
	{
		return null;
	}

	// Token: 0x060008E4 RID: 2276 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60008E4")]
	[Address(RVA = "0x417950", Offset = "0x416B50", VA = "0x180417950")]
	private static AlertButtonDescriptor[] GetNotEnoughMedallionsButtons()
	{
		return null;
	}

	// Token: 0x060008E5 RID: 2277 RVA: 0x00004398 File Offset: 0x00002598
	[Token(Token = "0x60008E5")]
	[Address(RVA = "0x417C10", Offset = "0x416E10", VA = "0x180417C10")]
	private int GetSelectedIndex()
	{
		return 0;
	}

	// Token: 0x060008E6 RID: 2278 RVA: 0x000043B0 File Offset: 0x000025B0
	[Token(Token = "0x60008E6")]
	[Address(RVA = "0x417D20", Offset = "0x416F20", VA = "0x180417D20")]
	private bool IsInside(Vector2 screenPosition)
	{
		return default(bool);
	}

	// Token: 0x060008E7 RID: 2279 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008E7")]
	[Address(RVA = "0x4181D0", Offset = "0x4173D0", VA = "0x1804181D0")]
	private void SelectGameObject(GameObject gameObject)
	{
	}

	// Token: 0x060008E8 RID: 2280 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008E8")]
	[Address(RVA = "0x418820", Offset = "0x417A20", VA = "0x180418820")]
	private void UpdateFieldTabbing()
	{
	}

	// Token: 0x060008E9 RID: 2281 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008E9")]
	[Address(RVA = "0x4188D0", Offset = "0x417AD0", VA = "0x1804188D0")]
	private void UpdateOnSubmit()
	{
	}

	// Token: 0x060008EA RID: 2282 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008EA")]
	[Address(RVA = "0x418940", Offset = "0x417B40", VA = "0x180418940")]
	private void UpdateShouldClose()
	{
	}

	// Token: 0x060008EB RID: 2283 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008EB")]
	[Address(RVA = "0x418B80", Offset = "0x417D80", VA = "0x180418B80")]
	private void UpdateTrackedTasks()
	{
	}

	// Token: 0x060008EC RID: 2284 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008EC")]
	[Address(RVA = "0x418EF0", Offset = "0x4180F0", VA = "0x180418EF0")]
	public Menu()
	{
	}

	// Token: 0x04000880 RID: 2176
	[Token(Token = "0x4000880")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI ErrorLabel;

	// Token: 0x04000881 RID: 2177
	[Token(Token = "0x4000881")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool EscapeToClose;

	// Token: 0x04000882 RID: 2178
	[Token(Token = "0x4000882")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	public bool CloseOnClickOutside;

	// Token: 0x04000883 RID: 2179
	[Token(Token = "0x4000883")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Menu[] SubMenus;

	// Token: 0x04000884 RID: 2180
	[Token(Token = "0x4000884")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool ShowOnStart;

	// Token: 0x04000885 RID: 2181
	[Token(Token = "0x4000885")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Selectable[] Fields;

	// Token: 0x04000886 RID: 2182
	[Token(Token = "0x4000886")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool LoopFields;

	// Token: 0x04000887 RID: 2183
	[Token(Token = "0x4000887")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	public bool SelectFirstFieldOnEnter;

	// Token: 0x04000888 RID: 2184
	[Token(Token = "0x4000888")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public UnityEvent OnSubmit;

	// Token: 0x04000889 RID: 2185
	[Token(Token = "0x4000889")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Menu ShowIn;

	// Token: 0x0400088A RID: 2186
	[Token(Token = "0x400088A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	protected Menu Parent;

	// Token: 0x0400088B RID: 2187
	[Token(Token = "0x400088B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	protected Menu Child;

	// Token: 0x0400088C RID: 2188
	[Token(Token = "0x400088C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private readonly List<Task> _trackedTasks;

	// Token: 0x0400088D RID: 2189
	[Token(Token = "0x400088D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Vector2 _preInputPosition;

	// Token: 0x0400088E RID: 2190
	[Token(Token = "0x400088E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private GameObject _syncedSelection;

	// Token: 0x0400088F RID: 2191
	[Token(Token = "0x400088F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private float _enableTime;

	// Token: 0x04000890 RID: 2192
	[Token(Token = "0x4000890")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private bool _wasDownInside;
}
