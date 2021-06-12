using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{

    public float moveSpeed = 1.5f;
    public Transform movePoint;
    public bool start = false;
   
    public Animator ani;

    // Start is called before the first frame update
    void Start()
    {
        movePoint.parent = null;
        ani.SetFloat("Horizontal", 0);
        ani.SetFloat("Vertical", 1);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (start)
        {


            transform.position = Vector3.MoveTowards(transform.position, movePoint.position, moveSpeed * Time.deltaTime);

            if (Vector3.Distance(transform.position, movePoint.position) == 0f)
            {
                if (Mathf.Abs(Input.GetAxisRaw("Horizontal")) == 1f)
                {
                    movePoint.position += new Vector3(Input.GetAxisRaw("Horizontal") * 1.6f, 0f, 0f);

                }
            }

            if (Vector3.Distance(transform.position, movePoint.position) == 0f)
            {
                if (Mathf.Abs(Input.GetAxisRaw("Vertical")) == 1f)
                {
                    movePoint.position += new Vector3(0f, Input.GetAxisRaw("Vertical") * 1.6f, 0f);
                }
            }

            if (Input.GetAxisRaw("Horizontal") == 1)
            {
                ani.SetFloat("Horizontal", 1);
                ani.SetFloat("Vertical", 0);
            }
            if (Input.GetAxisRaw("Horizontal") == -1)
            {
                ani.SetFloat("Horizontal", -1);
                ani.SetFloat("Vertical", 0);
            }
            if (Input.GetAxisRaw("Vertical") == 1)
            {
                ani.SetFloat("Horizontal", 0);
                ani.SetFloat("Vertical", 1);
            }
            if (Input.GetAxisRaw("Vertical") == -1)
            {
                ani.SetFloat("Horizontal", 0);
                ani.SetFloat("Vertical", -1);
            }
        }
        

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Destroy")
        {
            ani.Play("death");
            
        }

        if (collision.gameObject.tag == "Finish")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }

    }

    public void Restart()
    {
        string szene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(szene);
    }

   public void Run()
    {
        start = true;
    }
}
