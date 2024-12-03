using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSpell : Spell
{
    private string name;
    private int damages;

    public void Awake()
    {
        name = "Fire spell";
        damages = 20;
    }

    public void Start()
    {
        Cast();
    }

    public override void Cast()
    {
        base.Cast();
        Debug.Log($" cast {name}, enemy will get burn if hit this!");

        Cast(name);
        Cast(name, damages);
    }
}
