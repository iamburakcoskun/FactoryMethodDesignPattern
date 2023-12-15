using DemoWork.Abstract;
using DemoWork.Concrete;
using DemoWork.Enums;

namespace DemoWork
{
    public class Creator
    {
        public Screen ScreenFactory(ScreenModel screenModel)
        {
            Screen screen = null;

            switch (screenModel)
            {
                case ScreenModel.Windows:
                    screen = new WinScreen();
                    break;
                case ScreenModel.Web:
                    screen = new WebScreen();
                    break;
                case ScreenModel.Mobile:
                    screen = new MobileScreen();
                    break;
            }

            return screen;
        }
    }
}
