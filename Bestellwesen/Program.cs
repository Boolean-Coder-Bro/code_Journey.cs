using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*Namensort wird erstellt nach Name des Main Skriptes hier:
 * Grupiert  unser gesamtes Projekt, dem wir jetzt die Klasse Bestellwesen erstellt haben, 
 * Beinhaltet die Class  Category, Artikel Warenkorb , Programm Main */

namespace Bestellwesen {
    // Aufzählung bekannter Werte innerhalb der Klasse Bestellwesen
    enum Categorys {
        Food, nonfood
    }
    //class== Bauplan für Objekte, indem sie Eigenschaften und Methoden definiert
    class Program
    {
        //static void == eine Methode, die statisch aufrufbar ist und keinen Rückgabewert liefert.
        static void Main(string[] args) // args == Positional Arguments, die Parameter (zum Beispiel Kommandozeilenargumente), die an die Methode übergeben werden.
        {

        }
    }
    class Artikel
    {
        
        Categorys category;
        public string Name  // öffentliche Eigentschaft des Objektes "Artikel"
        {
            get { return Name; }//Erlaubt es Werte der Eigenschaft zu  lesen
            set { Name = value; }// Erlaubt es Werte der Eigentschaft zu ändern
        }
        
        public double Price
        {
            get { return Price; }
            set { Price = value; }
        }
        internal Categorys Category;
    }
}
