using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MuteManager : MonoBehaviour
{

    private bool isMuted;
    public Text MutedOnOff;

    // Start is called before the first frame update
    void Start()
    {
        isMuted = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isMuted)
        {

            MutedOnOff.text = "Sound: Off";
        }
        else
        {
            MutedOnOff.text = "Sound: On";
        }
    }

    public void MutePressed()
    {
        isMuted = !isMuted;
        AudioListener.pause = isMuted;
        
    }

}
