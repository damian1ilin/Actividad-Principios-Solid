using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class FocoDeLuz : MonoBehaviour, IInteractuable
{
    public Material miMaterial;
    public Light miLuz;

    public bool onOff = true;
    public void interactuar()
    {
        if (onOff){
            Apagar();
            onOff = false;
        }
        else {Prender(); onOff = true;}        
    }

    void Start()
    {
        miMaterial = GetComponent<MeshRenderer>().material;
        miLuz = GetComponent<Light>();
    }

    void Apagar(){
        miLuz.enabled = false;
    }
    void Prender(){
        miLuz.enabled = true;
    }
}
