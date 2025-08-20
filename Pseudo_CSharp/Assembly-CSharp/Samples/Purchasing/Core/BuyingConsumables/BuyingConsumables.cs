using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Purchasing;
using UnityEngine.Purchasing.Extension;
using UnityEngine.UI;

namespace Samples.Purchasing.Core.BuyingConsumables
{
	// Token: 0x0200044B RID: 1099
	[Token(Token = "0x200044B")]
	public class BuyingConsumables : MonoBehaviour, IDetailedStoreListener, IStoreListener
	{
		// Token: 0x060016F8 RID: 5880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016F8")]
		[Address(RVA = "0x3AFD20", Offset = "0x3AEF20", VA = "0x1803AFD20")]
		private void Start()
		{
		}

		// Token: 0x060016F9 RID: 5881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016F9")]
		[Address(RVA = "0x3AF700", Offset = "0x3AE900", VA = "0x1803AF700")]
		private void InitializePurchasing()
		{
		}

		// Token: 0x060016FA RID: 5882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016FA")]
		[Address(RVA = "0x3AF6B0", Offset = "0x3AE8B0", VA = "0x1803AF6B0")]
		public void BuyGold()
		{
		}

		// Token: 0x060016FB RID: 5883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016FB")]
		[Address(RVA = "0x3AF660", Offset = "0x3AE860", VA = "0x1803AF660")]
		public void BuyDiamond()
		{
		}

		// Token: 0x060016FC RID: 5884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016FC")]
		[Address(RVA = "0x3AF920", Offset = "0x3AEB20", VA = "0x1803AF920", Slot = "8")]
		public void OnInitialized(IStoreController controller, IExtensionProvider extensions)
		{
		}

		// Token: 0x060016FD RID: 5885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016FD")]
		[Address(RVA = "0x3AF7C0", Offset = "0x3AE9C0", VA = "0x1803AF7C0", Slot = "9")]
		public void OnInitializeFailed(InitializationFailureReason error)
		{
		}

		// Token: 0x060016FE RID: 5886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016FE")]
		[Address(RVA = "0x3AF860", Offset = "0x3AEA60", VA = "0x1803AF860", Slot = "5")]
		public void OnInitializeFailed(InitializationFailureReason error, string message)
		{
		}

		// Token: 0x060016FF RID: 5887 RVA: 0x00007AE8 File Offset: 0x00005CE8
		[Token(Token = "0x60016FF")]
		[Address(RVA = "0x3AFC30", Offset = "0x3AEE30", VA = "0x1803AFC30", Slot = "6")]
		public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs args)
		{
			return PurchaseProcessingResult.Complete;
		}

		// Token: 0x06001700 RID: 5888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001700")]
		[Address(RVA = "0x3AFB70", Offset = "0x3AED70", VA = "0x1803AFB70", Slot = "7")]
		public void OnPurchaseFailed(Product product, PurchaseFailureReason failureReason)
		{
		}

		// Token: 0x06001701 RID: 5889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001701")]
		[Address(RVA = "0x3AF9A0", Offset = "0x3AEBA0", VA = "0x1803AF9A0", Slot = "4")]
		public void OnPurchaseFailed(Product product, PurchaseFailureDescription failureDescription)
		{
		}

		// Token: 0x06001702 RID: 5890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001702")]
		[Address(RVA = "0x3AF650", Offset = "0x3AE850", VA = "0x1803AF650")]
		private void AddGold()
		{
		}

		// Token: 0x06001703 RID: 5891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001703")]
		[Address(RVA = "0x3AF640", Offset = "0x3AE840", VA = "0x1803AF640")]
		private void AddDiamond()
		{
		}

		// Token: 0x06001704 RID: 5892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001704")]
		[Address(RVA = "0x3AFDF0", Offset = "0x3AEFF0", VA = "0x1803AFDF0")]
		private void UpdateUI()
		{
		}

		// Token: 0x06001705 RID: 5893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001705")]
		[Address(RVA = "0x3AFEE0", Offset = "0x3AF0E0", VA = "0x1803AFEE0")]
		public BuyingConsumables()
		{
		}

		// Token: 0x0400129B RID: 4763
		[Token(Token = "0x400129B")]
		[FieldOffset(Offset = "0x20")]
		private IStoreController m_StoreController;

		// Token: 0x0400129C RID: 4764
		[Token(Token = "0x400129C")]
		[FieldOffset(Offset = "0x28")]
		public string goldProductId;

		// Token: 0x0400129D RID: 4765
		[Token(Token = "0x400129D")]
		[FieldOffset(Offset = "0x30")]
		public string diamondProductId;

		// Token: 0x0400129E RID: 4766
		[Token(Token = "0x400129E")]
		[FieldOffset(Offset = "0x38")]
		public Text GoldCountText;

		// Token: 0x0400129F RID: 4767
		[Token(Token = "0x400129F")]
		[FieldOffset(Offset = "0x40")]
		public Text DiamondCountText;

		// Token: 0x040012A0 RID: 4768
		[Token(Token = "0x40012A0")]
		[FieldOffset(Offset = "0x48")]
		private int m_GoldCount;

		// Token: 0x040012A1 RID: 4769
		[Token(Token = "0x40012A1")]
		[FieldOffset(Offset = "0x4C")]
		private int m_DiamondCount;
	}
}
