using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Kobold : Choice {
	public Sprite sprite;

	public override Sprite GetSprite() {
		return sprite;
	}

	public override void Clicked() {
		SetLeft (driver.mine);
		SetRight (driver.mine);
	}
}
