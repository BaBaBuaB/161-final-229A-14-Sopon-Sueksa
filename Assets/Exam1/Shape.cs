using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    protected string shapeName;

    public void Start()
    {
        Square square = GetComponent<Square>();
        Circle circle = GetComponent<Circle>();

        square.Start();
        circle.Start();
    }

    public void Init(string name)
    {
        shapeName = name;
    }

    public abstract float CalculateArea();
    
    public virtual void Resize()
    {
        Debug.Log("REsizing Shape...");
    }

    public void Draw()
    {
        Debug.Log($"Drawing {shapeName}.");
    }
}
