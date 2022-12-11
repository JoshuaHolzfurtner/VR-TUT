using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdtMv : MonoBehaviour
{
    public Transform toFollow;
    
    private Vector3 offset;
    private Vector3 rotatedStartPosFollow;
    private Vector3 startRotFollow;
    private Vector3 startPosdis;
    private Vector3 startRotdis;
    private Vector3 rotateToFollowPosition;
    // Start is called before the first frame update
    void Start()
    {

        //offset = toFollow.position - transform.position;
        rotatedStartPosFollow = new Vector3(toFollow.position.z, toFollow.position.y, toFollow.position.x);
        //startRotFollow = toFollow.rotation;
        startPosdis = transform.position;
        //startRotdis = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = toFollow.position - offset;
        //transform.rotation = toFollow.rotation;
        rotateToFollowPosition = new Vector3(toFollow.position.z, toFollow.position.y, toFollow.position.x);
        //toFollow.position = new Vector3(startPosdis.z, startPosdis.y, startPosdis.x);
        transform.position = (rotateToFollowPosition- rotatedStartPosFollow) + startPosdis;

    }
}
