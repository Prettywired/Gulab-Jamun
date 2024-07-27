using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestinationTrigger : MonoBehaviour
{
    bool isSuccess = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (this.CompareTag("Pot"))
        {
            if (other.CompareTag("Healthy"))
            {
                Debug.Log("Success");
                isSuccess = true;
            }
            else
            {

                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
        else if (this.CompareTag("Trash"))
        {
            if (other.CompareTag("Rotten"))
            {
                isSuccess = true;
                Debug.Log("Success!");
            }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }

    public bool GetSuccess()
    {

        return isSuccess;

    }

}
