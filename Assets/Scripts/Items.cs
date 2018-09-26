using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{
    public string name;
    public int uses;
    public string onUse;
    public GameObject Arrowed;

    private void Start()
    {
        Arrowed.SetActive(false);
    }


    private void OnMouseExit()
    {
        Arrowed.SetActive(false);
    }

    private void OnMouseUpAsButton()
    {
        UseText();
    }

    public virtual string UseText()
    {
        if (uses > 0)
        {
            uses = uses - 1;
            Debug.Log(onUse + " You can do this " + uses + " more times.");
        }
        else
        {
            Debug.Log("It's gone. It's all gone.");
        }
        return null;
    }


}

/* if (uses > 0)
        {
            Debug.Log("You " + consume + " part of the " + name + " item. It now has " + uses + " uses left");
        }
        else
        {
            Debug.Log(name + " has no uses left, and is now out of stock. We're going out of business soon.");
        }
        */