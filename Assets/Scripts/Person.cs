using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person : Items
{
    public bool IsHuman;
    public GameObject Human;
    int i;
    private void OnMouseEnter()
    {
        Arrowed.SetActive(true);
        Debug.Log("This is " + name + ", a person that you have to fight (With your teeth). He goes down in " + uses + " chomps. Left click on the item to purchase it.");
    }

    private void OnMouseExit()
    {
        Arrowed.SetActive(false);
    }

    public override string UseText()
    {
        if (IsHuman && i == 0)
        {
            onUse = onUse + " appears to be human.";
        }
        else if (i == 0)
        {
            onUse = onUse + " doesn't appear to be human.";
        }
        i++;
        if (uses <= 0)
        {
            GameObject.Destroy(gameObject);
        }
        return base.UseText();
    }
}
