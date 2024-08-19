using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class Player : MonoBehaviour
{
    public int velocidade = 10;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start.");
        TryGetComponent(out rb);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update.");
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

       Vector3 direcao = new Vector3(x, 0, y);
        rb.AddForce(direcao * velocidade * Time.deltaTime, ForceMode.Impulse);
    }
}
