using System.Collections;
using UnityEngine;

public class Collectibles : MonoBehaviour
{
    public bool isCoins, isSpeedUp;
    public float speedDuration; 
    private SpeedCD gameManager;

    private void Start()
    {
        // Find and reference the GameManager in the scene
        gameManager = FindObjectOfType<SpeedCD>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Test1 playerScript = other.GetComponent<Test1>();

            if (isCoins)
            {
                playerScript.score++;
                Destroy(gameObject);
            }

            if (isSpeedUp && gameManager != null)
            {
                gameManager.ApplySpeedBoost(playerScript, speedDuration);
                Destroy(gameObject);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
