using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryAndUnitWork
{
    public interface IRepository<T>
    {
        IList<T> GetAll();
        T FindByID();
        void Add (T item);
        void Remove (T item);

    }
    public interface IArticleRepository:IRepository<Article>
    {

        IList<Article> GetPreMiumArticle();
    }

    public class Article
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
    public interface IInvoiceRepository
    {
        IList<Invoice> GetAll();
        Invoice FindByID(int id);
        void Add(Invoice item);
        void Remove(Invoice remove);
    }
    public class Invoice
    {
        public int ID { get; set; }
        public string CustomerName { get; set; }
        public List<InvoiceItem> Items { get; set; }
    }
    public class InvoiceItem
    {
        public int ID { get; set; }
        public Article Article { get; set; }
        public int Quantity { get; set; }
    }
}
