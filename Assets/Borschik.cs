using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Borschik : MonoBehaviour
{
    public float coeff;
    private void OnTriggerEnter(Collider other)
    {
        Arhimed(other);
    }

    private void OnTriggerStay(Collider other)
    {
        Arhimed(other);
    }

    private void Arhimed(Collider other)
    {
        Rigidbody rbOther = other.gameObject.GetComponent<Rigidbody>();
        BoxCollider col = GetComponent<BoxCollider>();
        float Vwhole = other.bounds.size.x * other.bounds.size.y * other.bounds.size.z;
        float Vpart = Vwhole;

        if (col.bounds.max.y - other.bounds.min.y < other.bounds.size.y)
        {
            Vpart *= (col.bounds.max.y - other.bounds.min.y) / other.bounds.size.y;
        }
        //Сила сопротивления воды
        Vector3 R = -500 * coeff * rbOther.velocity.magnitude * rbOther.velocity;
        rbOther.AddForce(new Vector3(0, 1100 * 9.81f * Vpart, 0) + R, ForceMode.Force);

        double AF = 1100 * 9.81f * Vpart+R.y;
        print(AF);
    }
}
