using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    [SerializeField]
    private float speedCar = 100f;
    [SerializeField]
    private float forceTurnCar = 100f;

    [SerializeField]
    private float forceStop = 70f;

    [SerializeField]
    private GameObject effectStop;

    private float turnCar;
    private float checkCar;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        checkCar = Input.GetAxis("Vertical");
        turnCar = Input.GetAxis("Horizontal");
        moveCar();
        turningCar();
        if (checkCar > 0 && Input.GetKey(KeyCode.LeftShift))
            StopCar();
    }

    public void moveCar()
    {
        rb.AddRelativeForce(Vector3.forward * checkCar * speedCar);
        effectStop.SetActive(false);
    }

    public void turningCar()
    {
        Quaternion re = Quaternion.Euler(Vector3.up * turnCar * forceTurnCar * Time.deltaTime);
        rb.MoveRotation(rb.rotation * re);

    }

    public void StopCar()
    {
        if (rb.velocity.z != 0){

            rb.AddRelativeForce(-Vector3.forward * forceStop);
            effectStop.SetActive(true);
        }
    }
}
