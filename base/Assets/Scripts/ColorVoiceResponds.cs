using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorVoiceResponds : MonoBehaviour
{
    public List<GameObject> shapes;
    public void SetColor(string[] response)
    {
        foreach(var item in response)
        {
            Debug.Log(item); //print Form und Farbe
        }
        string color = response[0];
        string shape = response[1];

        GameObject targetShape = shapes.Find(x => x.name == response[1]);
        //hat Probleme die anderen beiden Objekte über die Namen zu finden
        switch(color)
        {
            case "red":
                targetShape.GetComponent<Renderer>().material.color = Color.red;
                break;
            case "black":
                shapes[1].GetComponent<Renderer>().material.color = Color.black;
                break;
            case "blue":
                shapes[2].GetComponent<Renderer>().material.color = Color.blue;
                break;
            
        }
    }
}
