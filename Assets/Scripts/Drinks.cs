using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drinks : Items
{
    public bool IsLiquid;
    int i;
    private string LiquidStatus;
    private void OnMouseEnter()
    {
        Arrowed.SetActive(true);
        Debug.Log("This is " + name + ", a drinkable item that goes down in " + uses + " sips. Is it liquid? Who knows? Left click on the item to purchase it.");
    }

    private void OnMouseExit()
    {
        Arrowed.SetActive(false);
    }

    public override string UseText()
    {
        if (IsLiquid && i == 0)
        {
            onUse = onUse + " it appears to be a liquid!.";
        }
        else if (i == 0)
        {
            onUse = onUse + " and-- what?! It's not liquid? Ehhh whatever, terminal illnesses are fun.";
        }
        i++;
        return base.UseText();
    }

}
