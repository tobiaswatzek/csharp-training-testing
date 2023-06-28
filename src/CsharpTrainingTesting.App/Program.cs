// See https://aka.ms/new-console-template for more information

using CsharpTrainingTesting.App;

Router ro = new Router();

ro.DoIt(new Location[] { new Location { Name = "Vienna", La = 48.208176, Lo = 16.373819 }, new Location() { Name = "Wieselburg", La = 48.130619, Lo = 15.138620 } });
