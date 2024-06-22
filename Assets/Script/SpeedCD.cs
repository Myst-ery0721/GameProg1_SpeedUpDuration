using System.Collections;
using UnityEngine;

public class SpeedCD : MonoBehaviour
{
    public void ApplySpeedBoost(Test1 playerScript, float duration)
    {
        StartCoroutine(SpeedBoostCoroutine(playerScript, duration));
    }

    private IEnumerator SpeedBoostCoroutine(Test1 playerScript, float duration)
    {
        playerScript.moveSpeed *= 1.2f;
        playerScript.rotSpeed *= 1.2f;

        yield return new WaitForSeconds(duration);

        playerScript.moveSpeed /= 1.2f;
        playerScript.rotSpeed /= 1.2f;
    }
}
