using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    private float t;
    // Start is called before the first frame update
    void Start()
    {
        t = 0;
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        gameObject.transform.position += new Vector3(0.02f*Mathf.Cos(0.8f* t),0, 0.02f * Mathf.Sin(0.8f * t));
    }
}
