using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLayer : MonoBehaviour
{

    public SpriteRenderer mapDark;
    public SpriteRenderer seeDark;

    public float waitDark;

    // Start is called before the first frame update
    void Start()
    {

        seeDark.sortingOrder = 10;
        seeDark.sortingLayerName = "Player";
        StartCoroutine(MapOff());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
           // StartCoroutine(MapOn());
            

        }
    }

   public IEnumerator MapOff()
    {

        yield return new WaitForSecondsRealtime(waitDark);
        mapDark.sortingOrder = 10;
        seeDark.sortingOrder = 0;
        seeDark.sortingLayerName = "Default";
    }

    public IEnumerator MapOn()
    {
        mapDark.sortingOrder = 0;
        yield return new WaitForSecondsRealtime(waitDark);
        mapDark.sortingOrder = 10;

    }

}
