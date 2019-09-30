using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameControlX : MonoBehaviour {
    int bronzeScore, bronzeSupply;
    int silverScore, silverSupply;
    float mineNow;
    float mineSpeed;


    // Start is called before the first frame update
    void Start() {
        bronzeScore = 0;
        silverScore = 0;
        bronzeSupply = 3;
        silverSupply = 2;
        mineSpeed = 3;
        mineNow = mineSpeed;
    }

    // Update is called once per frame
    void Update() {
        if (Time.time > mineNow) {
            mineNow += mineSpeed;

            if (bronzeSupply > 0) {
                bronzeSupply--;
                bronzeScore++;
            }
            else if (silverSupply > 0) {
                silverSupply--;
                silverScore++;
            }
            print("Running gameControlX. Bronze: " + bronzeScore + " ... Silver: " + silverScore);
        }
    }
}