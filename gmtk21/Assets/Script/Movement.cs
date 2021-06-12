using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float moveSpeed = 1.5f;
    public Transform movePoint;

   
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

        transform.position = Vector3.MoveTowards(transform.position, movePoint.position, moveSpeed * Time.deltaTime);

        if (Vector3.Distance(transform.position, movePoint.position) == 0f)
        {
            if(Mathf.Abs(Input.GetAxisRaw("Horizontal")) == 1f)
            {
                movePoint.position += new Vector3(Input.GetAxisRaw("Horizontal")*0.08f, 0f, 0f);
              
            }
        }

        if (Vector3.Distance(transform.position, movePoint.position) == 0f)
        {
            if (Mathf.Abs(Input.GetAxisRaw("Vertical")) == 1f)
            {
                movePoint.position += new Vector3(0f, Input.GetAxisRaw("Vertical")*0.1f, 0f);
            }
        }

        if(Input.GetAxisRaw("Horizontal") == 1)
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
