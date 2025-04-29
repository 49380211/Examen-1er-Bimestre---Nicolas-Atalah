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
            return;
        }

        if (modelo < 1900 || modelo > 2025)
        {
            Debug.Log("Ponga un año de fabricación válido");
            return;
        }

        if (kilometros < 0)
        {
            Debug.Log("Ponga una cantidad de kilómetros válida");
            return;
        }

        if (VTV > 2025 || VTV < modelo)
        {
            Debug.Log("Porfavor ingrese un vencimiento válido");
            return;
        }
        if (HC < 5)
        {
            Debug.Log("Porfavor ingrese un HC válido");
            return;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
