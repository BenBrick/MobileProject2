using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DollyCam : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    private CinemachineVirtualCamera[] DollyCams;

    IEnumerator Start()
    {
        for (int i = 1; i < DollyCams.Length; i++) {
            DollyCams[i].gameObject.SetActive(false);
        }

        for (int i = 1; i < DollyCams.Length; ++i) {
            DollyCams[i].gameObject.SetActive(true);
            yield return new WaitForSeconds(5.0f);
        }

        /*if (SceneManager.GetActiveScene().name == "Fight Scene 2") {
            SceneManager.LoadScene("Fight Scene 3");
        }

        else if (SceneManager.GetActiveScene().name == "Fight Scene 3"){
            SceneManager.LoadScene("Fight Scene 1");
        }
        else if (SceneManager.GetActiveScene().name == "Fight Scene 1")
        {
            SceneManager.LoadScene("Fight Scene 2");
        }*/
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
