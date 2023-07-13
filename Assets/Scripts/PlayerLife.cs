using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLifr : MonoBehaviour
{
    private Animator anim;
    [SerializeField] private AudioSource deathSound;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collison)
    {
        if (collison.gameObject.CompareTag("traps"))
        {
            Die();
        }
    }

    private void Die()
    {
        anim.SetTrigger("death");
        deathSound.Play();
    }

    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
