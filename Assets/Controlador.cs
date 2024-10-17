using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Controlador : MonoBehaviour
{
    //Clase para que todos los controladores hereden, simplemente contiene una lista que define con que accionadores va a interactuar cuando el controlador lo decida, según su tipo (Jugador/IA)
    public List<Accionador> accionadores = new();
}
