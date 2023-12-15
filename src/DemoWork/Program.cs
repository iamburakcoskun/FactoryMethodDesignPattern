// See https://aka.ms/new-console-template for more information
using DemoWork;
using DemoWork.Abstract;

Console.WriteLine("Hello, World!");

Creator creator = new Creator();

Screen screenWindows = creator.ScreenFactory(DemoWork.Enums.ScreenModel.Windows);
Screen screenWeb = creator.ScreenFactory(DemoWork.Enums.ScreenModel.Web);
Screen screenMobile = creator.ScreenFactory(DemoWork.Enums.ScreenModel.Mobile);

screenWindows.Draw();

Console.ReadKey();