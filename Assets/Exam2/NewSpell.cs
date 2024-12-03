using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewSpell : Spell
{
    private string name;
    private int damages;

    public void Awake()
    {
        name = "Multiply spell";
        damages = 10;
    }

    public void Start()
    {
        Cast();
    }

    public override void Cast()
    {
        base.Cast();
        Debug.Log($" cast {name}, multiply that damages is dealing!");

        Cast(name);
        Cast(name, damages);
        Debug.Log($"But damages so very effective dealing : {NewTypeOfCast()}");
    }

    public int NewTypeOfCast()
    {
        int multiply = 5;
        int outPut;

        outPut = damages * multiply;


        return outPut;
    }
}
