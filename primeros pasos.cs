using UnityEngine;

public class primerospasos : MonoBehaviour
{



    List<int> numerosEnteros = new List<int>();
    List<float> numerosDecimales = new List<float>();
    List<string> nombres = new List<string>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        numerosEnteros.Add(1);
        numerosEnteros.Add(2);
        numerosEnteros.Add(3);

        debug.Log(numerosEnteros.Count);
    }


    // Update is called once per frame
    void Update()
    {

    }
}
