using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightOffOn : MonoBehaviour
{
   

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LightOff());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator LightOff()
    {
        yield return new WaitForSecondsRealtime(5f);
        GetComponent<Light>().enabled = false;

    }
}
