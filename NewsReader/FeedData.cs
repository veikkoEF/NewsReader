using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsReader
{
    public class FeedData
    {
        public ObservableCollection<FeedItem> Items { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Uri ImageUri { get; set; }
        public FeedData()
        {
            Items = new ObservableCollection<FeedItem>();
        }
    }
}
