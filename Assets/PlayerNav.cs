using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; // imports unitys ai features


public class PlayerNav : MonoBehaviour
{
    [SerializeField] private Transform movePositionTransform; // serializes the components and recreated the script from that new components. transform is what lets us control the rotation postion and scale of an object
    // here we are using the move transform.

    private NavMeshAgent navMeshAgent; // this lets us call upon the navmeshagent features of unity. 


    private void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>(); // this is what sets us the previously set class to use the nav mesh agent components
    }

    private void Update()
    {
        navMeshAgent.destination = movePositionTransform.position; // this has the items with playernnav file attached move to a attached object with the origionals position moving to the set destination object.
    }
}
