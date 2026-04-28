using mvvm_test.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

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
    }
}
