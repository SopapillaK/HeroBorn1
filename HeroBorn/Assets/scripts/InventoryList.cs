using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryList<Tornado> where Tornado : class
{
    private Tornado _item;
    public Tornado item
    {
        get { return _item; }
    }

    public InventoryList()
    {
        Debug.Log("Generic list initialized...");
    }

    public void SetItem(Tornado newItem)
    {
        _item = newItem;
        Debug.Log("New item added...");
    }

}