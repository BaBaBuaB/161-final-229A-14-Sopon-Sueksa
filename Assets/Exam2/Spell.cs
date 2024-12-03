using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : MonoBehaviour
{
    public void Start()
    {
        FireSpell fireSpell = GetComponent<FireSpell>();
        IceSpell iceSpell = GetComponent<IceSpell>();
        NewSpell newSpell = GetComponent<NewSpell>();

        fireSpell.Start();
        iceSpell.Start();
        newSpell.Start();
    }

    public virtual void Cast() 
    {
        Debug.Log("Spell is pocessing to cast!");
    }

    public void Cast(string spellName)
    {
        Debug.Log($"{spellName} is canelling, wait a minites");
    }

    public void Cast(string spellName, int damagesSpell)
    {
        Debug.Log($"{spellName} is hitting enemy!");
        Debug.Log($"{spellName} is dealing {damagesSpell}");
    }
}
