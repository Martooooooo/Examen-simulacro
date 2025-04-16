using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExamenSimulacro : MonoBehaviour
{
    public int juveniles;
    public int infantiles;

    // Start is called before the first frame update
    void Start()
    {

        if (juveniles > 100 || infantiles > 100)
        {
            Debug.Log("No se puede ingresar esa cantidad de inscripciones");
            return;
        }
        if (juveniles < 0 || infantiles < 0)
        {
            Debug.Log("No se puede ingresar esa cantidad de inscripciones");
            return;

        }
        int profesoresJuveniles = (juveniles / 20);
        int profesoresInfantiles = (infantiles / 10);
        int profes = profesoresInfantiles + profesoresJuveniles;
        int Coordinadores;
        int listaDeEspera;
        Debug.Log("Se necesitan" + profesoresJuveniles + "profesores para los inscriptos juveniles");
        Debug.Log("Se necesitan" + profesoresInfantiles + "profesores para los inscriptos infantiles");
        Debug.Log("Se necesitan" + Coordinadores + "coordinadores");
        Debug.Log("En lista de espera" + listaDeEspera);

        // Update is called once per frame
    }
}
