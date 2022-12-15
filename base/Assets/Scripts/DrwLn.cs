using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrwLn : MonoBehaviour
{
    public LineRenderer line;
    public Transform Pos1;
    public Transform Pos2;

    //public Transform toAttach;
    //private LineRenderer lr;
    //private Vector3 toAttachPos;
    // Start is called before the first frame update
    void Start()
    {
        line.positionCount = 2;
        //lr = GetComponent<LineRenderer>();
        //lr.SetPosition(0, transform.position);
        //lr.SetPosition(1, toAttach.position);
        //toAttachPos = toAttach.position;
    }

    // Update is called once per frame
    private void Update()
    {

        line.SetPosition(0, Pos1.position);
        line.SetPosition(1, Pos2.position);
    }
    
}
