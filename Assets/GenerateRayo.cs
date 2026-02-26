using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateRayo : MonoBehaviour
{
    public GameObject[] bloques;
    public float distancia = 20f;
    public float paso = 1f;

    public int direccionInicial = 1;

    private List<GameObject> bloquesUsados = new List<GameObject>();

    void Start()
    {

    }

    public void GenerarRayo()
    {
        Vector3 posicionActual = transform.position;
        float distanciaGenerada = 0f;

        GameObject ultimoPrefab = null;

        while (distanciaGenerada < distancia)
        {

            List<GameObject> disponibles = new List<GameObject>();

            foreach (var bloque in bloques)
            {
                if (bloque != ultimoPrefab)
                    disponibles.Add(bloque);
            }

            if (disponibles.Count == 0) break;

            GameObject seleccionado = disponibles[Random.Range(0, disponibles.Count)];


            Vector3 direccion;

            int Dire = Random.Range(0, 3);

            if (Dire == 0)
                direccion = transform.up;

            else if (Dire == 1)
                direccion = -transform.up;

            else
                direccion = transform.right;

            GameObject objeto = Photon.Pun.PhotonNetwork.Instantiate(seleccionado.name, posicionActual, Quaternion.identity);
            

            objeto.transform.rotation = transform.rotation;

            posicionActual += direccion * paso * direccionInicial;

            distanciaGenerada += paso;

            ultimoPrefab = seleccionado;
        }
    }
}
