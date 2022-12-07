using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Coin : MonoBehaviour
{
    //private Rigidbody rb;
    public Sequence seq;
    //PlayerController _player;

    private float _randY;
    Coin[] lemons;

    void Start()
    {
        var lemons = GameObject.FindObjectsOfType<Coin>();
        foreach (var lemon in lemons)
        {
            _randY = Random.Range(-0.5f, 1.5f);
            transform.DOMoveY(transform.position.y + _randY, 1).SetLoops(-1, LoopType.Yoyo);
        }
    }

    public void MoveLemons()
    {
        //yield return new WaitForSeconds(0.1f);
        //Coin[] lemons = GameObject.FindObjectsOfType<Coin>();

        //foreach (var lemon in lemons)
        //{
        //    _randY = Random.Range(-0.5f, 1.5f);
        //    if (lemon.CompareTag("Collectable"))
        //    {
        //        seq = DOTween.Sequence();
        //        seq.Append(lemon.transform.DOMoveY(lemon.transform.position.y + _randY, 1).SetLoops(-1, LoopType.Yoyo));
        //    }

        //}

    }
}

