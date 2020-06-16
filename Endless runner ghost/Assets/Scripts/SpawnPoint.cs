using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour{
    public GameObject obstacle;

    // Start is called before the first frame update
    void Start(){
        Instantiate(obstacle, transform.position, Quaternion.Euler(0, 180, 0));
        Destroy(gameObject);
    }
}
