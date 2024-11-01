using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontdestroy : MonoBehaviour
{

    private AudioReverbFilter filter;

    private AudioDistortionFilter distortionFilter;

    // Start is called before the first frame update
    void Start()
    {

        distortionFilter = GetComponent<AudioDistortionFilter>();

        filter = GetComponent<AudioReverbFilter>();

        GameObject[] music = GameObject.FindGameObjectsWithTag("Long");
        
        //distortionFilter.distortionLevel = Random.Range(0.0f,1.0f);
        
        if (music.Length == 1)
        {
            DontDestroyOnLoad(gameObject);
            
        }
        else if (music.Length > 1)
        {
            Destroy(gameObject);
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
