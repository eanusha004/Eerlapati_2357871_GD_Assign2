using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyTrigger : MonoBehaviour
{

    [SerializeField] private GameObject[] targetDummies;


    private void Start()
    {
        foreach (GameObject dummies in targetDummies)
        {
            dummies.GetComponent<TargetDummy>().DeactivateDummy();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            foreach (GameObject dummies in targetDummies)
            {
                dummies.GetComponent<TargetDummy>().ActivateDummy();
            }
        }
    }
}
