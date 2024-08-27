using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KütüphaneOtomasyon.Model
{
    public class Kitap
    {
        public int kitapId { get; set; }
        public string kitapIsim { get; set; }
        public string kitapYazar { get; set; }
        public string kitapDili { get; set; }
        public string yayinEvi { get; set; }
        public string tur { get; set; }
        public int sayfaSayisi { get; set; }
        public int adet { get; set; }
        public int basimYil { get; set; }
        public Kitap()
        {

        }
        public Kitap(int kitapId, string kitapisim, string kitapYazar, string kitapDili, string yayinEvi, string tur, int adet, int sayfaSayisi, int basimYil)
        {
            this.kitapId = kitapId;
            this.kitapIsim = kitapisim;
            this.kitapYazar = kitapYazar;
            this.kitapDili = kitapDili;
            this.yayinEvi = yayinEvi;
            this.tur = tur;
            this.sayfaSayisi = sayfaSayisi;
            this.adet = adet;
            this.basimYil = basimYil;


        }
        public int getKitapId()
        {
            return this.kitapId;
        }
        public string getKitapİsim()

        {
            return this.kitapIsim;
        }
        public string getkitapYazar()
        {
            return this.kitapYazar;
        }
        public string getkitapDili()
        {
            return this.kitapDili;
        }
        public string getYayinEvi()
        { 
            return this.yayinEvi;
        }
        public string getTur()
        { 
            return this.tur;
        }
        public  int getSayfaSayisi()
        {

            return this.sayfaSayisi;

        }
        public int getadet()
        {
            return this.adet;
        }
        public  int getBasimYil()
        {
            return this.basimYil;
        }



    }
}
