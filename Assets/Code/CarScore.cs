using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarScore : MonoBehaviour
{
    public FinishMenu finishMenu;
    public int score;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Trap")
        {
            Destroy(other.gameObject);
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
            if(score < 20)
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
