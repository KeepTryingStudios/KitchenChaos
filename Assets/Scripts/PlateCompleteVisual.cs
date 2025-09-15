using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateCompleteVisual : MonoBehaviour
{
    [Serializable]
    public struct KitchenObjectSO_GameObject {
        public KitchenObjectSO kitchenObjectSO;
        public GameObject gameObject;
    }
    [SerializeField] private PlateKitchenObject plateKitchenObject;
    [SerializeField] private List<KitchenObjectSO_GameObject> KitchenObjectSOGameObjectList;


    // Start is called before the first frame update
    void Start()
    {
        plateKitchenObject.OnIngredientAdded += PlateKitchenObject_OnIngredientAdded;
        foreach(KitchenObjectSO_GameObject KitchenObjectSOGameObject in KitchenObjectSOGameObjectList)
        {
            KitchenObjectSOGameObject.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void PlateKitchenObject_OnIngredientAdded(object sender, PlateKitchenObject.OnIngredientAddedEventArgs e)
    {
        foreach(KitchenObjectSO_GameObject KitchenObjectSOGameObject in KitchenObjectSOGameObjectList)
        {
            if(KitchenObjectSOGameObject.kitchenObjectSO == e.kitchenObjectSO)
            {
                KitchenObjectSOGameObject.gameObject.SetActive(true );
            }
        }
    }
}
