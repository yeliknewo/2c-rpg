using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Farm : Choice {
	public Sprite sprite;

	public override Sprite GetSprite() {
		return sprite;
	}

	public override void Clicked() {
		SetLeft (driver.farmer);
		SetRight (driver.crow);
	}
}
