using UnityEngine;
using System.Collections;

public class spawnTrash : MonoBehaviour {

    public GameObject trashItems;
	public GameObject complexTrashItems;
	public GameObject double_1;
	public GameObject double_2;

    System.Random trashType = new System.Random();
    System.Random offset = new System.Random();
    private float xOffset;
	int caseSwitch = 0;

    public void spawn()
    {
        Vector3 spot = GameObject.Find("spawn spot").transform.position;
		xOffset = 0f; // + (float)offset.NextDouble() * 4;
        Vector3 spawnSpot = spot + new Vector3(xOffset, 2, 0);



		if (difficultySettings.endlessScore < 5) {
			caseSwitch = trashType.Next (1, complexTrashItems.transform.childCount);
			Instantiate (complexTrashItems.transform.GetChild (caseSwitch), spawnSpot, transform.rotation);
		} else {
			if (difficultySettings.doubleTap == true) {
				double_2.transform.localScale = new Vector3 (.09f, .09f, .09f);
				Instantiate (double_1.transform, spawnSpot, transform.rotation);
				Instantiate (double_2.transform, spot, transform.rotation);
				difficultySettings.doubleTap = false;
			} else {
				caseSwitch = trashType.Next (1, complexTrashItems.transform.childCount);
				Instantiate (complexTrashItems.transform.GetChild (caseSwitch), spawnSpot, transform.rotation);
			}
		}
    }

    
	void Update(){
		/*
		print ("game start:    gainRate: " + difficultySettings.barGainRate +
		"    dropRate" + difficultySettings.barDropRate +
		"    speed: " + difficultySettings.moveSpeed +
		"    gap: " + difficultySettings.spawnGap +
			"	isstarted: " + difficultySettings.isStarted + "" +
			"	iscompleted: " + difficultySettings.isCompleted);
			*/
	}
}
