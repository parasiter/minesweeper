using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour {
	public const int gridRows = 10;
	public const int gridCols = 10;
	public const float offset = 1.0f;

	[SerializeField] private Block originalBlock;
	[SerializeField] private Line originalLine;
	[SerializeField] private Sprite[] images;
	// Use this for initialization
	void Start () {
		Vector3 blockStartPos = originalBlock.transform.position;
		Vector3 lineStartPos = originalLine.transform.position;

		for (int i = 0; i < gridRows; ++i) {
			for (int j = 0; j < gridCols; ++j) {
				Block newBlock;
				if (i == 0 && j == 0)
					newBlock = originalBlock;
				else {
					newBlock = Instantiate (originalBlock) as Block;
					newBlock.SetImage (images [0]);
					newBlock.transform.position = new Vector3 (blockStartPos.x + offset * i, blockStartPos.y - offset * j, blockStartPos.z);
				}
			}
		}

		Line vertLine = Instantiate (originalLine)as Line;
		vertLine.transform.Rotate (new Vector3 (0.0f, 0.0f, 90.0f));
		for (int i = 0; i <= 5; ++i) {			
			Line newLine;
			newLine = Instantiate (originalLine) as Line;
			newLine.transform.position = new Vector3 (lineStartPos.x, lineStartPos.y + i, lineStartPos.z);
			newLine = Instantiate (originalLine) as Line;
			newLine.transform.position = new Vector3 (lineStartPos.x, lineStartPos.y - i, lineStartPos.z);

			newLine = Instantiate (vertLine) as Line;
			newLine.transform.position = new Vector3 (lineStartPos.x - i, lineStartPos.y, lineStartPos.z);
			newLine = Instantiate (vertLine) as Line;
			newLine.transform.position = new Vector3 (lineStartPos.x + i, lineStartPos.y, lineStartPos.z);
		}
	}
		
	
	// Update is called once per frame
	void Update () {
		
	}
}
