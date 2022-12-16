using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson7_SingletonDesignPattern
{
    sealed class Bank
    {
        double totalSum;
        //1. private c-tor
        //לא מאפשר הקצאת אובייקטים מחוץ למחלקה
        //private Bank(){} 
        Bank() { }

        //2. משתנה סטטי פרטי, המכיל מופע של המחלקה
        //static Bank instance;// = new Bank(); //כדי לא ליצור מופע אם לא צריך

        //3. פונקציה סטטית, ציבורית, היוצרת את המופע היחיד- בפעם הראשונה
        //ותמיד מחזירה את המופע היחיד שקיים
        //public static Bank GetInstance()
        //{
        //    //if (instance == null)
        //    //    instance = new Bank();
        //    instance ??= new Bank();
        //    return instance;
        //}

        //private static Bank instance;

        static Bank()
        {
            Instance = new Bank();
        }

        public static Bank Instance { get; }
       

        public void Hafkada(double sum)
        {
            totalSum += sum;
        }

        //Singletonתוספת ל
        //כדי לאפשר הקצאת מספר מסויים של מופעים
        //שלב 1 יישאר
        //ובמקום משתנה בודד מסוג המחלקה תהיה רשימה
        //והטיפול ישתנה בהתאם
    }
}
