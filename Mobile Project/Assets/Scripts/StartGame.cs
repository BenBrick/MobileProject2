using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;

public class StartGame : MonoBehaviour

{

    public CinemachineVirtualCamera gameCam;
    public GameObject musicDead;
    public GameObject musicPlay;
    public GameObject UI;
    public GameObject UIGame;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGameCam()
    {
        gameCam.gameObject.SetActive(true);
        Destroy(musicDead);
        UI.gameObject.SetActive(false);
        UIGame.gameObject.SetActive(true);
        musicPlay.gameObject.SetActive(true);
        print("Started");
    }
}
