class emivog implements WalkerInterface 
{

	PVector currentPos = new PVector();
	PVector previousDir = new PVector();

	int boardWidth;
	int boardHeight;

  String getName()
  {
  	return "Emmie";
  }

  PVector getStartPosition(int playAreaWidth, int playAreaHeight)
  {
    //Select a starting position or use a random one.
    float x = (int) random(0, playAreaWidth);
    float y = (int) random(0, playAreaHeight);

    boardWidth = playAreaWidth;
    boardHeight = playAreaHeight;

    currentPos = new PVector(x, y);

    //a PVector holds floats but make sure its whole numbers that are returned!
    return new PVector(x, y);
  }

  PVector update()
  {

  	PVector direction = new PVector();
  	PVector newPos = new PVector();

  	do 
  	{
  		switch((int)random(0, 4)) 
  		{
  			case 0:
  			direction = new PVector(-1, 0);
  			break;

  			case 1:
  			direction = new PVector(1, 0);
  			break;

  			case 2:
  			direction = new PVector(0, 1);
  			break;

  			default:
  			direction = new PVector(0, -1);
  			break;
  		} 
  		newPos = new PVector (currentPos.x, currentPos.y);
  		newPos.add (direction);
  	}

  	while (newPos.x > boardWidth || newPos.x < 0 || newPos.y > boardHeight || newPos.y < 0
  		|| (previousDir.x == direction.x && previousDir.y == direction.y));

  		currentPos.add(direction);
  	previousDir = new PVector (-direction.x, -direction.y);

  	return new PVector(direction.x, direction.y);
  }
}