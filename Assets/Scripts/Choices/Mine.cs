using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Mine : Choice {
	public Sprite sprite;

	public override Sprite GetSprite () {
		return sprite;
	}

	public override void Clicked() {
		SetLeft (driver.kobold);
		SetRight (driver.rock);
	}
}
