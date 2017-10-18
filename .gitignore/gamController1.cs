using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamController1 : MonoBehaviour {
	int bronzeOre;
	int silverOre;
	int timeToMine;
	int miningSpeed;
	int bronzeSupply;
	int silverSupply;


	// Use this for initialization
	void Start () {
		bronzeOre= 0;
		silverOre= 0;
		bronzeSupply = 3;
		silverSupply= 2;
		miningSpeed= 3;

		timeToMine= miningSpeed;

	}

	// Update is called once per frame
	void Update () {
		//Mine for Bronze
		if (Time.time > timeToMine) {
			if (bronzeSupply >= 1) {
				bronzeSupply -= 1;
				bronzeOre += 1;

			}
			//Mine for silver after bronze is gone
			else if (bronzeSupply == 0 && silverSupply >= 1) {
				silverSupply -= 1;
				silverOre += 1;
			}

			timeToMine += miningSpeed;

			print("Bronze: " + bronzeOre);
			print("Silver: " + silverOre);
		}
	}
}
