int frame = 0;
float multiplier = 0.302;
int numberOfPoints = 100;
int distance = 30;

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
		point (distance + i, 240 + sin ((frame + i) * -0.01) * 100);	
	}

	stroke (127, 69, 249);
	for (int i = 0; i < width; i += distance)
	{
	point (distance + i, 246 + sin ((frame + i) * 0.01) * 130);
	}

frame++;

}
