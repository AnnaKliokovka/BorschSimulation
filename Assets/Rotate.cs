using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float Speed = 6;
    // Update is called once per frame
    void Update()
    {
        if (transform.rotation.eulerAngles.x < 330)
        {
            transform.Rotate(new Vector3(Speed * Time.deltaTime, 0, 0));
        }
        else
        {
            if (transform.position.x > -5)
            {
                transform.position += new Vector3(-2 * Time.deltaTime, 0, 0);
                Camera.main.transform.Rotate(new Vector3(Speed * Time.deltaTime, 0, 0));
            }
        }
    }
}
