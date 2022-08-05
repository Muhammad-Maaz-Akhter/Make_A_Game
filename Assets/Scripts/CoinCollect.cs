using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    public Transform coineffect;
    Transform effect;
    int CoinValue = 1;

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag=="Player")
        {
            GameScore.CurrentScore += CoinValue;
            effect = Instantiate(coineffect, transform.position, transform.rotation);
            Destroy(effect.gameObject, 2);
            Destroy(gameObject);
        }
    }

}
