using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightOffOn : MonoBehaviour
{

    public GameObject Licht;
    public GameObject LichtPlayer;
    public float waitTime;

    public Movement movement;
   
    // Start is called before the first frame update
    void Start()
    {
        LichtPlayer.SetActive(false);
        StartCoroutine(LightOff());
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator LightOff()
    {
        yield return new WaitForSecondsRealtime(waitTime);
        //GetComponent<Light>().enabled = false;
        Licht.SetActive(false);
        LightOn();
    }


    public void LightOn()
    {
        LichtPlayer.SetActive(true);
        movement.Run();
       
    }
}
