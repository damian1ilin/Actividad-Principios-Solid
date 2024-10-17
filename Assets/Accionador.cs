using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Accionador : MonoBehaviour
{
    
    //Clase que sirve como "botón", contiene una clase de elementos interactuables y llama para que se interactuen todos cuando esta es accinoada. Se le pueden agregar y quitar elementos en cualquier momento a la lista. (Hacer desde el editor) 
    [SerializeField] private List<Interactuable> lista;


    public void Accionar(){
        foreach (Interactuable interactuable in lista){
            interactuable.interactuar();
        }
    }
}
