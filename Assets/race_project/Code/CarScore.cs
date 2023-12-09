using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarScore : MonoBehaviour
{
    public FinishMenu finishMenu;
    public GameObject boomFX;
    public int score;
    public int maxScore;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Trap")
        {
            Destroy(other.gameObject);
            GameObject fx = Instantiate(boomFX, other.transform.position, Quaternion.identity);
            Destroy(fx, 2);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "TrapZone")
        {
            if (other.GetComponent<Trap>().trapObject != null)
            {
                score++;
            }

            other.enabled = false;
        }

        if(other.tag == "Finish")
        {
            if(score < maxScore)
            {
                finishMenu.scoreText.text = score.ToString();
            }
            else
            {
                finishMenu.otherScore.SetActive(false);
                finishMenu.bestScore.SetActive(true);
            }

            finishMenu.gameObject.SetActive(true);
        }
    }
}
