using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SphereMove : MonoBehaviour
{
    private float speed = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float moveZ = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        transform.position = new Vector3(
            transform.position.x + moveX,
            transform.position.y,
            transform.position.z + moveZ
            );
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "SceneChange")
        {
            SceneManager.LoadScene("Scene02");
        }
    }
}
