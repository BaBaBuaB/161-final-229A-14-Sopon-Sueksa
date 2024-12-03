using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class Circle : Shape
{
    private float radius;

    public void Awake()
    {
        Init("Circle");
        radius = 2f;
    }

    public void Start()
    {
        Draw();
        Resize();
        Debug.Log($"{shapeName} side : {radius}");
        Debug.Log($"{shapeName} area : {CalculateArea()}");
    }

    public override float CalculateArea()
    {
        float area;

        area = 3.14f * radius * radius;

        return area;
    }

    public override void Resize()
    {
        base.Resize();
        Debug.Log($"{shapeName} is resized.");
    }
}
