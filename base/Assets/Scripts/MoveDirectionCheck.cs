using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDirectionCheck : MonoBehaviour
{
    private bool direction; //direction 0-> Drawing backwards & 1-> if forwards
    private float lastPoint;
    private float startTimeThisStroke;
    private float[] strokeDurations;
    public Material[] materialList; //List of all used Materials
    private Renderer rend; /* Stores the renderer of Object which has this 
                            * script attached*/

    // Start is called before the first frame update
    void Start()
    {
        lastPoint = transform.position.z;

        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = materialList[0]; //Starting Material


    }

    // Update is called once per frame
    void Update()
    {
        if ((direction && (lastPoint > transform.position.z)) || ((!direction) && ((lastPoint < transform.position.z))))
        {
            direction = !direction;
            if (!direction)
            {
                rend.sharedMaterial = materialList[0];

            }
            else
            {
                rend.sharedMaterial = materialList[1];

            }
            lastPoint = transform.position.z;
        }

        /*Has the direction changed for Update
         *than our direction as a whole will be recognized to have reversed
         *by changing the color of the Handle.*/

    }
}