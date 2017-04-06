using UnityEngine;
using System.Collections;

public class JumBlock : Block {

	[TextArea(2,3)]
	public string instruction;

	protected Connection connectionTop;
	protected Connection connectionNext;
	// Use this for initialization
	void Start () {
	base.Start ();

		this.connectionTop  = new Connection (this, 
		                                      Connection.SocketType.SocketTypeFemale, 
		                                      Connection.ConnectionType.ConnectionTypeRegular, 
		                                      new Vector2 (35.0f, 0.0f),
		                                      true,
		                                      false);

		this.connectionNext = new Connection (this, 
		                                      Connection.SocketType.SocketTypeMale, 
		                                      Connection.ConnectionType.ConnectionTypeRegular, 
		                                      new Vector2 (35.0f, 1.0f),
		                                      true,
		                                      false);

		this.connections.Add(connectionTop);
		this.connections.Add(connectionNext);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public override string GetCode () {
		string toReturn = string.Copy (this.instruction);
		toReturn=toReturn+ "  ssss";
		Mover.actions.Add(2);
		//ABCText.actions.Add(1);


		if (this.connectionNext.GetAttachedBlock () != null) {
			toReturn += "\n" + this.connectionNext.GetAttachedBlock().GetCode();
		}

		return toReturn;
	}
}
