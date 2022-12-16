using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleFromMicrophone : MonoBehaviour
{
    public AudioSource source;
    public Vector3 minScale;
    public Vector3 maxScale;
    public AudioLoudnessDetection detector;
    public float loudnessSensibility = 100;
    public float threshhold = 0.1f; //f markiert Float nicht vergessen
     

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float loudness = detector.GetLoudnessFromMicrophone() * loudnessSensibility;
        if (loudness < threshhold)
        {
            loudness = 0;
        }
        else
        //lerp value from minscale to maxscale
        transform.localScale = Vector3.Lerp(minScale, maxScale, loudness);
    }
}