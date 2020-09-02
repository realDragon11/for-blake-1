using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attacker_script : MonoBehaviour
{

    Rigidbody obj;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        obj = this.gameObject.GetComponent<Rigidbody>();
        obj.AddForce(new Vector3(0,0,-1) * 10000);

    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.z < -10) {

            this.transform.position = new Vector3(player.transform.position.x+Random.Range(-3f,3f),this.transform.position.y,10);
        }
    }

    void FixedUpdate()
    {

        if (Mathf.Abs(obj.velocity.z) < 2) {
            obj.AddForce(new Vector3(0, 0, -1) * 100);
        }
    }
}
