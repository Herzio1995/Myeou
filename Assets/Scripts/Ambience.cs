using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ambience : MonoBehaviour
{
    public float scrollFactor = -1;
    public Vector3 gameVelocity;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = gameVelocity * scrollFactor;
    }

    private void OnTriggerExit(Collider gameArea)
    {
        transform.position += Vector3.right * (gameArea.bounds.size.x + GetComponent<BoxCollider>().size.x);
    }
    /*
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("Player")) SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    */
    public void SetGameVelocity(Vector3 difficult)
    {
        gameVelocity = difficult;
    }
}
