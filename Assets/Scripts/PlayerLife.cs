using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    bool dead = false;
    [SerializeField] AudioSource deathSound;
    private void Update()
    {
        if(transform.position.y < -1f && !dead)
        {
            Die();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("EnemyBody"))
        {
            Die();
        }
    }

    void Die()
    {
        Invoke(nameof(ReloadLevel), 1f);
        dead = true;
        deathSound.Play();    
    }

    void ReloadLevel()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    

}
