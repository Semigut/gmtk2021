using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountLevel : MonoBehaviour
{

    public Text LevelCount;
    

    // Start is called before the first frame update
    void Start()
    {
        LevelCount.text = "Level " + SceneManager.GetActiveScene().buildIndex.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
