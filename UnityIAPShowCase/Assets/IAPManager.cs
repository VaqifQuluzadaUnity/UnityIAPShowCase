using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Purchasing;
public class IAPManager : MonoBehaviour
{
    [SerializeField] private string coin500ConsumableId = "com.Telebe.UnityIAPShowCase.500Coins";
    [SerializeField] private string removeAdNonConsumableId = "com.Telebe.UnityIAPShowCase.NoAds";

    public void onPurchaseSuccessful(Product product)
    {
        if (product.definition.id == coin500ConsumableId)
        {
            //reward
            Debug.Log("500 coin added to inventory");
        }
        else if (product.definition.id == removeAdNonConsumableId)
        {
            //remove ads
            Debug.Log("All ads removed permanently");
        }
    }

    public void onPurchaseFailed(Product product,PurchaseFailureReason purchaseFailReason)
    {
        Debug.Log("Buying " + product.definition.id + " is failed: " + purchaseFailReason);
        
    }
}
