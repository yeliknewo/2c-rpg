using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Rock : Choice {
	public Sprite sprite;

	public override Sprite GetSprite() {
		return sprite;
	}

	public override void Clicked() {
		SetLeft (driver.mine);
		SetRight (driver.mine);
	}
}
