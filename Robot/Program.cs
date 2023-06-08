using Robot;

InvadingRobot InvaderRobot = new InvadingRobot();

InvaderRobot.initialize();

Infantry Infantry = new Infantry();

InvaderRobot.AddTarget(Infantry);

InvaderRobot.Turn();