using System.Collections;
using System.Numerics;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ERC1155BalanceOf_Custom : MonoBehaviour
{
    [SerializeField] private GameObject _sphere;

    async void Start()
    {
        // the nft data
        string chain = "ethereum";
        string network = "rinkeby";
        string contract = "0x88B48F654c30e99bc2e4A1559b4Dcf1aD93FA656";
        string account = PlayerPrefs.GetString("Account");
        string tokenId = "92628123456672091589492008063969133978831107856369193819581823210854390169601";

        BigInteger balanceOf = await ERC1155.BalanceOf(chain, network, contract, account, tokenId);
        print(balanceOf);

        if(balanceOf > 0)
            _sphere.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
    }
}

