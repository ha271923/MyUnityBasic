using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCameraController : MonoBehaviour {

	public GameObject player;

	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;
	}

	// Update是在每次渲染新的一幀的時候才會調用，也就是說，這個函數的更新頻率和設備的性能有關以及被渲染的物體（可以認為是三角形的數量）。
	// 在性能好的機器上可能fps 30，差的可能小些。這會導致同一個遊戲在不同的機器上效果不一致，有的快有的慢。因為Update的執行間隔不一樣了。
	// 而FixedUpdate，是在固定的時間間隔執行，不受遊戲幀率的影響。有點像Tick。所以處理Rigidbody的時候最好用FixedUpdate。
	// PS：FixedUpdate的時間間隔可以在項目設置中更改，Edit->Project Setting->time 找到Fixed timestep。就可以修改了。
	// LateUpdate是在所有Update函數調用後被調用。這可用於調整腳本執行順序。例如:當物體在Update里移動時，跟隨物體的相機可以在LateUpdate里實現。
	void LateUpdate () {
		transform.position = player.transform.position + offset;
	}
}
