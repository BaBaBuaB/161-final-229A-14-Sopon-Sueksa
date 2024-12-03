using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : Shape
{
    private int side;

    public void Awake()
    {
        Init("Square");
        side = 2;
    }

    public void Start()
    {
        Draw();
        Resize();
        Debug.Log($"{shapeName} side : {side}");
        Debug.Log($"{shapeName} area : {CalculateArea()}");
    }

    public override float CalculateArea()
    {
        float area;

        area = side * side;

        return area;
    }

    public override void Resize()
    {
        base.Resize();
        Debug.Log($"Resizing {shapeName} are processing.");
    }
}
