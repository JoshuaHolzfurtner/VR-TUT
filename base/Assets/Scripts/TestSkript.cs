using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSkript : MonoBehaviour
{
    public LineRenderer line;
    public Transform posOne;
    public Transform posTwo;
    // Start is called before the first frame update
    void Start()
    {
        line.positionCount = 2;
    }

    // Update is called once per frame
    void Update()
    {
        line.SetPosition(0, posOne.position);
        line.SetPosition(1, posTwo.position);


    }
}
