using mvvm_test.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public vmTovar()
        {
            ListТовары.Clear();

            foreach (var item in db.Товары.ToList())
            {
                ListТовары.Add(item);
            }
        }
    }
}
