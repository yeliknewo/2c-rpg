using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Crow : Choice {
	public Sprite sprite;

	public override Sprite GetSprite() {
		return sprite;
	}

	public override void Clicked() {
		SetLeft (driver.farm);
		SetRight (driver.farm);
	}
}
