using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Reflection.Emit;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.AI;
 
 
public class CarAI : MonoBehaviour
{
    
    public float ForcaDoMotor, ControleDeCurva, ForçaDoFreio;
    public WheelCollider DianteiraDireita, DianteiraEsquerda, TraseiraDireita, TraseiraEsquerda;
    public GameObject player;
 
    float MaxAnguloDaRoda = 45;
    
    public Vector3 centerOfMass = new Vector3(0, -0.3f, 0);
    // Update is called once per frame
    public void Start()
    {
        GetComponent<Rigidbody>().centerOfMass = centerOfMass;
        player = FindObjectOfType<PlayerController>().gameObject;

    }
 
    public void Update()
    {
        Vector3 ViaturaVector = transform.InverseTransformPoint(player.transform.position);
        float angulo = (ViaturaVector.x / ViaturaVector.magnitude) * MaxAnguloDaRoda;
        TraseiraDireita.motorTorque = ForcaDoMotor;
        TraseiraEsquerda.motorTorque = ForcaDoMotor;
 
 
        DianteiraDireita.steerAngle = angulo;
        DianteiraEsquerda.steerAngle = angulo;
 
 
    }
 
}