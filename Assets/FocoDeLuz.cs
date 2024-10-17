using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class FocoDeLuz : Interactuable
{
    public MeshRenderer miMesh;
    public Light miLuz;

    public bool onOff = true;
    public override void interactuar()
    {
        if (onOff){Apagar();}
        else {Prender();}        
    }

    void Start()
    {
        miMesh = GetComponent<MeshRenderer>();
        miLuz = GetComponent<Light>();
    }

    void Apagar(){
        onOff = false;
        miLuz.enabled = false;
        miMesh.enabled = false;
    }
    void Prender(){
        onOff = true;
        miLuz.enabled = true;
        miMesh.enabled = true;
    }
}
