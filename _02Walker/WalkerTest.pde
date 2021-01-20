WalkerInterface walker;
PVector walkerPos;

void setup() {
  size(640, 480);

  //Create a walker from the class Example it has the type of WalkerInterface
  walker = new Example();

  walkerPos = walker.getStartPosition(width, height);
}

void draw() {
  point(walkerPos.x, walkerPos.y);
  walkerPos.add(walker.update());
}