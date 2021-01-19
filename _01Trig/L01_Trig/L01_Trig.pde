int frame = 0;
float speed = 0.01f;
int numberOfPoints = 100;
int distance = 30;
int curvePos = 240;
int curveHeight = 120;

void setup()
{
	size (640, 480);
	strokeWeight(6);
	
	numberOfPoints = 0;
	frame++;
}

void draw()
{
	background(0);
	stroke(255, 110, 199);

	for (int i = 0; i < width; i += distance)
	{
		point (distance + i, curvePos + sin ((frame + i) * speed) * curveHeight);	
	}

	stroke (127, 69, 249);
	for (int i = 0; i < width; i += distance)
	{
	point (distance + i, curvePos + cos ((frame + i) * speed + PI / 2) * curveHeight);
	}

frame++;
}