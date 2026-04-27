using mvvm_test.Class;
using mvvm_test.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace mvvm_test.View
{
    public class VMStud
    {
        private IList<Stud> _listStud;

        public IList<Stud> ListStud
        {
            get
            {
                return _listStud ?? (_listStud = new ObservableCollection<Stud>());
            }
        }

        private ICommand _commandShowMess;
        public ICommand CommandShowMess
        {
            get
            {
                return _commandShowMess ?? (new CommandAction(ShowMess));
            }
        }
        
        public void ShowMess()
        {
            MessageBox.Show(_listStud.LastOrDefault().Name );
        }

        public VMStud()
        {
            ListStud.Add(new Stud { Name = "НИКИТАААААААА", Description = "dsfsdfsfsdf" });
        }


    }
}
