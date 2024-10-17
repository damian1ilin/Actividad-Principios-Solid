using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador1Jugador : Controlador
{
    // Script de ejemplo de un jugador. Al presionar 1 se accionan los objetos interactuables a cargo del Controlador que el Jugador maneja.

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)){
            foreach (Accionador miAccionador in accionadores)
            {
                miAccionador.Accionar();
            }

        }
    }
}
