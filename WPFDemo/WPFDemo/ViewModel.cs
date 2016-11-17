using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using PropertyChanged;

namespace WPFDemo
{
    [ImplementPropertyChanged]
    public class ViewModel
    {
        private string _filterText;
        public string FilterText
        {
            get { return _filterText; }
            set
            {
                _filterText = value;
                Something();
            }
        }

        public ICollectionView DataCollection { get; set; } = CollectionViewSource.GetDefaultView(Model.GetAllPeople());


        public void Something()
        {
            DataCollection.Filter = x =>
            {
                var person = x as Person;
                var filterText = FilterText.ToLower();
                return person.FirstName.ToLower().Contains(filterText) || person.LastName.ToLower().Contains(filterText);
            };
        }
    }
}
