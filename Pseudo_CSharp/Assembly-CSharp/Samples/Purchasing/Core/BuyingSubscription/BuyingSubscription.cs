using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Purchasing;
using UnityEngine.Purchasing.Extension;
using UnityEngine.UI;

namespace Samples.Purchasing.Core.BuyingSubscription
{
	// Token: 0x0200044A RID: 1098
	[Token(Token = "0x200044A")]
	public class BuyingSubscription : MonoBehaviour, IDetailedStoreListener, IStoreListener
	{
		// Token: 0x060016EC RID: 5868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016EC")]
		[Address(RVA = "0x3AFFB0", Offset = "0x3AF1B0", VA = "0x1803AFFB0")]
		private void Start()
		{
		}

		// Token: 0x060016ED RID: 5869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016ED")]
		[Address(RVA = "0x3AFFB0", Offset = "0x3AF1B0", VA = "0x1803AFFB0")]
		private void InitializePurchasing()
		{
		}

		// Token: 0x060016EE RID: 5870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016EE")]
		[Address(RVA = "0x3AFF60", Offset = "0x3AF160", VA = "0x1803AFF60")]
		public void BuySubscription()
		{
		}

		// Token: 0x060016EF RID: 5871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016EF")]
		[Address(RVA = "0x3B0250", Offset = "0x3AF450", VA = "0x1803B0250", Slot = "8")]
		public void OnInitialized(IStoreController controller, IExtensionProvider extensions)
		{
		}

		// Token: 0x060016F0 RID: 5872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016F0")]
		[Address(RVA = "0x3B01B0", Offset = "0x3AF3B0", VA = "0x1803B01B0", Slot = "9")]
		public void OnInitializeFailed(InitializationFailureReason error)
		{
		}

		// Token: 0x060016F1 RID: 5873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016F1")]
		[Address(RVA = "0x3B00F0", Offset = "0x3AF2F0", VA = "0x1803B00F0", Slot = "5")]
		public void OnInitializeFailed(InitializationFailureReason error, string message)
		{
		}

		// Token: 0x060016F2 RID: 5874 RVA: 0x00007AB8 File Offset: 0x00005CB8
		[Token(Token = "0x60016F2")]
		[Address(RVA = "0x3B0560", Offset = "0x3AF760", VA = "0x1803B0560", Slot = "6")]
		public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs args)
		{
			return PurchaseProcessingResult.Complete;
		}

		// Token: 0x060016F3 RID: 5875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016F3")]
		[Address(RVA = "0x3B04A0", Offset = "0x3AF6A0", VA = "0x1803B04A0", Slot = "7")]
		public void OnPurchaseFailed(Product product, PurchaseFailureReason failureReason)
		{
		}

		// Token: 0x060016F4 RID: 5876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016F4")]
		[Address(RVA = "0x3B02D0", Offset = "0x3AF4D0", VA = "0x1803B02D0", Slot = "4")]
		public void OnPurchaseFailed(Product product, PurchaseFailureDescription failureDescription)
		{
		}

		// Token: 0x060016F5 RID: 5877 RVA: 0x00007AD0 File Offset: 0x00005CD0
		[Token(Token = "0x60016F5")]
		[Address(RVA = "0x3B0060", Offset = "0x3AF260", VA = "0x1803B0060")]
		private bool IsSubscribedTo(Product subscription)
		{
			return default(bool);
		}

		// Token: 0x060016F6 RID: 5878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016F6")]
		[Address(RVA = "0x3B0610", Offset = "0x3AF810", VA = "0x1803B0610")]
		private void UpdateUI()
		{
		}

		// Token: 0x060016F7 RID: 5879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016F7")]
		[Address(RVA = "0x3B0920", Offset = "0x3AFB20", VA = "0x1803B0920")]
		public BuyingSubscription()
		{
		}

		// Token: 0x04001298 RID: 4760
		[Token(Token = "0x4001298")]
		[FieldOffset(Offset = "0x20")]
		private IStoreController m_StoreController;

		// Token: 0x04001299 RID: 4761
		[Token(Token = "0x4001299")]
		[FieldOffset(Offset = "0x28")]
		public string subscriptionProductId;

		// Token: 0x0400129A RID: 4762
		[Token(Token = "0x400129A")]
		[FieldOffset(Offset = "0x30")]
		public Text isSubscribedText;
	}
}
