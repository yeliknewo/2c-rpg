using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Forest : Choice {
	public Sprite sprite;

	public override Sprite GetSprite() {
		return sprite;
	}

	public override void Clicked() {
		SetLeft (driver.elf);
		SetRight (driver.ent);
	}
}
