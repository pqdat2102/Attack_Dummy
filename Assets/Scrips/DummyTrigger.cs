using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyTrigger : MonoBehaviour
{
    [SerializeField] private GameObject[] targerDummies;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            foreach(GameObject dummies in targerDummies)
            {
                dummies.GetComponent<TargetDummy>().ActivateDummy();
            }
        }
    }
}
