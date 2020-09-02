using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SomeFunnyScriptName : MonoBehaviour
{

    Rigidbody obj;
    // Start is called before the first frame update
    void Start()
    {
        obj = this.gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftArrow)) {
            obj.AddForce(Vector3.left * 20);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            obj.AddForce(Vector3.right * 20);
        }
        if (this.gameObject.transform.position.y < -20) {
            SceneManager.LoadScene(0);
        }
    }
}
