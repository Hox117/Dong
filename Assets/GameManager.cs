using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Photon.Pun;

public class GameManager : MonoBehaviour
{

    private void Start()
    {
        if (PhotonNetwork.IsMasterClient)
            PhotonNetwork.Instantiate("Player1", new Vector3(-8, 0, 0), Quaternion.identity);
             
        else

            PhotonNetwork.Instantiate("Player2", new Vector3(8, 0, 0), Quaternion.identity);

    }
}
