using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TimedAttack : MonoBehaviour
{
    public GameObject timeCircle;
    public float scaleDecraese;
    
    // Start is called before the first frame update
    void Start()
    {
        timeCircle.transform.localScale = new Vector3(4f, 4f, 4f);
        Input.gyro.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeCircle != null)
        {
            Vector3 Scale = timeCircle.transform.localScale;

            if (Scale.x > 0.1f)
            {
                Scale -= new Vector3(scaleDecraese * Time.deltaTime, scaleDecraese * Time.deltaTime, scaleDecraese * Time.deltaTime);
                timeCircle.transform.localScale = Scale;
            }
            else
            {
                Scale = new Vector3(4f, 4f, 4f);
                timeCircle.transform.localScale = Scale;
            }
        }

        if (Input.acceleration.y > 0.4f)
        {
            OnButtonClick();
        }
    }

    public void OnButtonClick()
    {
        print("Power Activated");
    }
}
