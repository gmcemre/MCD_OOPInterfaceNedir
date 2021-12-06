using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_OOPInterfaceNedir
{
    public interface Imusteri
    {
        //public Imusteri()
        //{
        //      interface içerisinde ctor kullanılmaz...
        //}

        //field da kullanılamaz..

        //Properties
        int Id { get; set; }
        string isim { get; set; }
        string soyisim { get; set; }

        //metot
        int yeniKayit(string isim, string soyisim);
        int kayitDuzenle(int id,string isim, string soyisim);
        int kayitSil(int id);

    }
}
