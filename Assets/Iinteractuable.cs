using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactuable : MonoBehaviour
{
    // Clase abstracta que define una funcion en común para todos los objetos con posible interacción. Cada objeto se ocupa de su comportamiento en específico.
    public abstract void interactuar();
}
