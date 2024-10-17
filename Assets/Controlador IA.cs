using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorIA : Controlador
{

    // Controlador que ejemplifica como puede tenerse la misma funcionalidad pero con una "IA", en este caso solo se toca aleatoriamente, pero podría ser siguiendo un comportamiento específico en caso de un juego.
    // Lo importante es ver que todo ese comportamiento se llevaría acabo en este script, mientras que al heredar de Controlador ya nos permite la conexion a los elementos a interactuar.

    void Start() {
        StartCoroutine(TocarRoutine());
    }

    private void Tocar(){
        foreach (Accionador miAccionador in accionadores)
            {
                miAccionador.Accionar();
            }
    }


    public IEnumerator TocarRoutine(){
        float tiempo = UnityEngine.Random.Range(0.5f,1.5f);
        Tocar();

        yield return new WaitForSeconds(tiempo);
        StartCoroutine(TocarRoutine());
    }
}
