using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndlessScroll : MonoBehaviour
{
    public float scrollFactor = -1;
    public Vector3 gameVelocity;
    private Rigidbody rb;
    private ParticleSystem explotion;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = gameVelocity * scrollFactor;
        explotion = GetComponent<ParticleSystem>();
    }

    private void OnTriggerEnter(Collider finish)
    {
        if (finish.CompareTag("Finish"))
        {
            rb.velocity = Vector3.zero;
            explotion.Play();
            Destroy(gameObject, 0.5f);
        }
        
        //transform.position += Vector3.right * (gameArea.bounds.size.x + GetComponent<BoxCollider>().size.x);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("Player")) SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void SetGameVelocity(Vector3 difficult)
    {
        gameVelocity = difficult;
    }
    public void SpawnExplotion() { 
        
    }
}
