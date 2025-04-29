using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatosDelUsuario : MonoBehaviour
{
    public string patente;
    public int modelo;
    public int kilometros;
    public int VTV;
    public int HC;
    // Start is called before the first frame update
    void Start()
    {
        if (patente == "")
        {
            Debug.Log("Porfavor ingrese su patente");
            Debug.Log("VTV no aprobada");

            return;
        }

        if (modelo < 1900 || modelo > 2025)
        {
            Debug.Log("Ponga un año de fabricación válido");
            Debug.Log("VTV no aprobada");

            return;
        }

        if (kilometros < 0)
        {
            Debug.Log("Ponga una cantidad de kilómetros válida");
            Debug.Log("VTV no aprobada");
            return;
        }

        if (VTV > 2025 || VTV < modelo)
        {
            Debug.Log("Porfavor ingrese un vencimiento válido");
            Debug.Log("VTV no aprobada");

            return;
        }
        if (HC < 5)
        {
            Debug.Log("Porfavor ingrese un HC válido");
            Debug.Log("VTV no aprobada");
            return;
        }

        if (HC > 100)
        {
            Debug.Log("HC mayores a 100, VTV no aprobada");
            return;
        }

        if (kilometros / (2025 - modelo) < 10000)
        {
            Debug.Log("VTV otorgada por 2 años");
        }
        if (kilometros / (2025 - modelo) > 10000)
        {
            Debug.Log("VTV otorgada por 1 año");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
