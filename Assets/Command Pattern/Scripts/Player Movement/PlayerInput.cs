using UnityEngine;
using System.Collections;

    public class PlayerInput : MonoBehaviour
    {
        public MoveObject moveObject;
		public ToggleWall wall;
		private Command moveForward;
		private Command moveLeft;		
		private Command moveDown;
		private Command moveRight;
		private Command undo;
		private Command wallToggle;

		//Note that this is missing a stack of commands - you will need to implement that

		// Use this for initialization
		void Start()
        {
			moveForward = new MoveForward(moveObject);
			moveLeft = new MoveLeft(moveObject);
			moveDown = new MoveDown(moveObject);
			moveRight = new MoveRight(moveObject);
			undo = new Undo(moveObject);
			wallToggle = new Wall(wall);
		}

        // Update is called once per frame
        void Update()
        {
			if (Input.GetKey(KeyCode.W))
			{
				moveForward.Execute();
			}
			if (Input.GetKey(KeyCode.A))
            {
                moveLeft.Execute();
            }
			if (Input.GetKey(KeyCode.S))
			{
				moveDown.Execute();
			}
			if (Input.GetKey(KeyCode.D))
			{
				moveRight.Execute();
			}
			if (Input.GetKey(KeyCode.Q))
            {
                undo.Execute();
            }
			if (Input.GetKeyDown(KeyCode.E))
			{
				wall.Wall();
			}

        }



    }