using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TwoIngCond : MonoBehaviour
{
    public static int stars = 3;
    public GameObject obj;
    [SerializeField] DestinationTrigger dest;
    [SerializeField] DestinationTrigger dest2;

    void Update()
    {
        // Debug.Log("condition" + dest.GetSuccess());
        if (dest.GetSuccess() && dest2.GetSuccess())
        {

            obj.SetActive(true);
        }


    }

    public void DecreaseStars()
    {
        stars--;
    }

}
