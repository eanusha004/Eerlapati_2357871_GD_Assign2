using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetDummy : MonoBehaviour
{
    [SerializeField] private Animator dummyAnimator;
    //public void OnTriggerEnter(Collision other)
    //{
    //    if (other.tag =="Weapon"))
    //    {
    //        dummyAnimator.Play("Dead");
    //        Debug.Log("i have been hit");
    //    }
    //}



    public void ActivateDummy()
    {
        dummyAnimator.Play("Idle");
    }

    public void DeactivateDummy()
    {
        dummyAnimator.Play("Dead");

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Weapon")
        {
            {
                dummyAnimator.Play("Dead");
                Debug.Log("i have been hit");
            }
        }
    }
}
