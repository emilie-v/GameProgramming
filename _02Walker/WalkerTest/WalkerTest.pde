WalkerInterface walker;
PVector walkerPos;

void setup() 
{
  size(640, 480);

  walker = new emivog();

  walkerPos = walker.getStartPosition(width, height);
}

void draw() 
{
  point(walkerPos.x, walkerPos.y);
  walkerPos.add(walker.update());
  if (walkerPos.x > width || walkerPos.x < 0 || walkerPos.y > height || walkerPos.y < 0) 
  {
    println("dead af");
    exit();
  }
}
