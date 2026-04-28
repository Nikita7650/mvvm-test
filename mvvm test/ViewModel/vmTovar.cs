using mvvm_test.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Windows.Controls;
using System.Windows.Documents;

namespace mvvm_test.ViewModel
{
    public class vmTovar
    {
        private КалиевПрактикаEntities
            db = new КалиевПрактикаEntities();

        private IList<Товары> _listТовары;

        public IList<Товары> ListТовары =>
            _listТовары ?? (_listТовары
            = new ObservableCollection<Товары>());

        private Пользователи _selectedUser;

        public Пользователи SelectedUser
        {
            get => _selectedUser ?? (_selectedUser = new Пользователи());
            set => _selectedUser = value;
        }
        public vmTovar(Пользователи user)
        {
            SelectedUser = user;
            ListТовары.Clear();

            foreach (var item in db.Товары.ToList())
            {
                ListТовары.Add(item);
            }
        }

        public bool IsEnabledClient
        {
            get
            {
                if (SelectedUser.НомерРоли == 3)
                {
                    return false;
                }    
                else return true;
            }
        }

        public string VisibilityClient
        {
            get
            {
                if (SelectedUser.НомерРоли == 3 || (SelectedUser.НомерРоли == 2))
                    return "Hidden";
                else return null;
            }
        }

        public string Visibility2
        {
            get
            {
                if (SelectedUser.НомерРоли == 3)
                    return "Hidden";
                else return null;
            }
            
        }



    }
}
