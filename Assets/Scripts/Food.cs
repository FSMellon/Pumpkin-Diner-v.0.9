using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : Items
{
    public bool TasteGood;
    int i; 
    private void OnMouseEnter()
    {
        Arrowed.SetActive(true);
        Debug.Log("This is " + name + ", a food item that goes down in " + uses + " bites. Left click on the item to purchase it.");
    }
    private void OnMouseExit()
    {
        Arrowed.SetActive(false);
    }

    public override string UseText()
    {
        if (TasteGood && i == 0)
        {
            onUse = onUse + " and it tastes pretty good.";
        }
        else if (i == 0)
        {
            onUse = onUse + " and it kind of tastes like crap honestly.";
        }
        i++;
        return base.UseText();
    }
}

