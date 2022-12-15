using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDirectionCheck : MonoBehaviour
{
    private bool direction; //direction 0-> Drawing backwards & 1-> if forwards
    private int[] pointsZ = { 0, 0, 0, 0 };
    private int counter;
    private bool allSmaller; 
    private bool allBigger;
    public Material[] materialList; //List of all used Materials
    private Renderer rend; /* Stores the renderer of Object which has this 
                            * script attached*/

    // Start is called before the first frame update
    void Start()
    {

        counter = 0;
        allSmaller = false;
        allBigger = false;
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = materialList[0]; //Starting Material


    }

    // Update is called once per frame
    void Update()
    {
        counter++;
        if(counter == pointsZ.Length)
        {
            counter = 0;
        }
        allSmaller = true; //Two Variables Check if the complete List is 
        allBigger = true;  //made up of all smaller or all bigger values
                           //than the current z position of Transform

        for (int i = 0; i < pointsZ.Length; i++)
        {
            allSmaller = allSmaller && (pointsZ[i] < transform.position.z);
            allBigger = allBigger && (pointsZ[i] > transform.position.z);
            /* if all are bigger were moving backwards, and if all are bigger
             * were moving forward. Only one can be True at one Moment.*/
        }
        if((direction && allSmaller) || ((!direction) && allBigger ))
        {
            direction = !direction;
            if(direction)
            {
                rend.sharedMaterial = materialList[0];
            }
            else
            {
                rend.sharedMaterial = materialList[1];

            }
        }

        /*Has the direction changed for longer than (pointZ.Length) Updates
         *than our direction as a whole will be recognized to have reversed
         *by changing the color of the Handle./
        allSmaller = false;
        allBigger = false;*/
        
    }
}
