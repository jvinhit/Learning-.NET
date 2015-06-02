using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DelegateCommandExample
{
    // DelegateCommnad implement ICommand 
    // ICommand gom co 2 phuong thuc va 1 event : 
    //+ Canexcute(): xac dinh visual state cua control khi command is set. Chang han doi voi button : 
    // Khi Canexcute duoc set False thi button se bi disable. Va Button se dang ky su kien CanExcuteChanged, ney 
    // CanexcuteChanged duoc goi thi visual state se thay doi va ta goi lai Canexcute va set tru -> button enable
    // Con phuong thuc Excute(): se duoc goi truc tiep khi command duoc thuc thi. Chang han nhu Khi ta press button. 

    //DelegateCommand se duoc initialized voi delegate va point to a method will be excute when Excute is called.
    // o day se co 2 constrcutr that can be used to also pass a delegate to a method that will be called when CanExcute is call in command

    public class DelegateCommand : ICommand
    {
        Func<object, bool> canExecute;
        Action<object> executeAction;

        public DelegateCommand(Action<object> executeAction)
            : this(executeAction, null)
        {
        }

        public DelegateCommand(Action<object> executeAction, Func<object, bool> canExecute)
        {
            if (executeAction == null)
            {
                throw new ArgumentNullException("executeAction");
            }
            this.executeAction = executeAction;
            this.canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            bool result = true;
            Func<object, bool> canExecuteHandler = this.canExecute;
            if (canExecuteHandler != null)
            {
                result = canExecuteHandler(parameter);
            }

            return result;
        }

        public event EventHandler CanExecuteChanged;

        public void RaiseCanExecuteChanged()
        {
            EventHandler handler = this.CanExecuteChanged;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
        }

        public void Execute(object parameter)
        {
            this.executeAction(parameter);
        }
    }
}