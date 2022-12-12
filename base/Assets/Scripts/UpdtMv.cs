using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdtMv : MonoBehaviour
{
    public Transform toFollow;
    
    private Vector3 offset;
    private Vector3 rotatedStartPosFollow;
    private Vector3 rotatedStartRotFollow;
    private Vector3 startPosdis;
    private Vector3 startRotdis;
    private Vector3 rotateToFollowPosition;
    private Vector3 rotateToFollowRotation;
    private Vector3 toquatRotDif;
    // Start is called before the first frame update
    void Start()
    {
        offset = new Vector3(0, 90, 0);
        //offset = toFollow.position - transform.position;
        //startRotFollow = toFollow.rotation;
        rotatedStartPosFollow = new Vector3(toFollow.position.z, toFollow.position.y, toFollow.position.x);
        startPosdis = transform.position;
        rotatedStartRotFollow = new Vector3(toFollow.rotation.z, toFollow.rotation.y, toFollow.rotation.x);
        startRotdis = new Vector3(transform.rotation.x, transform.rotation.y, transform.rotation.z);
        //startRotdis = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = toFollow.position - offset;
        //transform.rotation = toFollow.rotation;
        //toFollow.position = new Vector3(startPosdis.z, startPosdis.y, startPosdis.x);
        rotateToFollowPosition = new Vector3(toFollow.position.z, toFollow.position.y, toFollow.position.x);
        transform.position = (rotateToFollowPosition- rotatedStartPosFollow) + startPosdis;

        rotateToFollowRotation = new Vector3(toFollow.rotation.z, toFollow.rotation.y, toFollow.rotation.x);
        toquatRotDif = (rotateToFollowRotation - rotatedStartRotFollow) + startRotdis;
        //transform.rotation = toFollow.rotation//Quaternion.Euler(toquatRotDif.x, toquatRotDif.y + 90, toquatRotDif.z);
        transform.rotation = Quaternion.Euler(offset) * toFollow.transform.localRotation;
    }
}
