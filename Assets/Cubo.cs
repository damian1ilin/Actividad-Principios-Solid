using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo : Interactuable
{
    public Transform mitransform;

    void Start() {
        mitransform = GetComponent<Transform>();
    }

    public override void interactuar()
    {
        mitransform.rotation = Random.rotation;
        
    }   
}
