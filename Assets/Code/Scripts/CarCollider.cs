using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCollider : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "CheckPoint")
        {
            GameManager.Instance.CheckPoint();
        }
        if(other.gameObject.tag == "WinPoint")
        {
            GameManager.Instance.WinPoint();
        }
    }
}
