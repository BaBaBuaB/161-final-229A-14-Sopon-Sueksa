using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceSpell : Spell
{
    private string name;
    private int damages;

    public void Awake()
    {
        name = "Ice spell";
        damages = 5;
    }

    public void Start()
    {
        Cast();
    }

    public override void Cast()
    {
        base.Cast();
        Debug.Log($" cast {name}, it can frezz enemy!");

        Cast(name);
        Cast(name, damages);
    }
}
