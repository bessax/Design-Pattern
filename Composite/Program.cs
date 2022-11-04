using Composite;

SceneGroup group1 = new SceneGroup();

Triangle triangle1 = new Triangle();
SceneGroup group2 = new SceneGroup();

group1.Add(triangle1);
group1.Add(group2);

Triangle triangle2 = new Triangle();
Rectangle rectangle1 = new Rectangle();

group2.Add(triangle2);
group2.Add(rectangle1);

SceneGroup group3 = new SceneGroup();

Rectangle rectangle2 = new Rectangle();
Rectangle rectangle3 = new Rectangle(); 
group3.Add(rectangle2);
group3.Add(rectangle3);

group2.Add(group3);

group1.draw();
