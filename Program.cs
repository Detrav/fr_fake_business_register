using FastReport;
using System;
using System.Collections.Generic;

namespace fr_fake_business_register
{
    class Program
    {
        static void Main(string[] args)
        {

            // step 1 prepare fake frx
            SomeClass[] fakeList = new SomeClass[0];
            Report r = new Report();
            r.Dictionary.RegisterData(fakeList, "SomeTable", true);
            r.Save("report.frx");

            // step 2 on web

            // REST via service xD
            List<SomeClass> realDB = new List<SomeClass>();
            for(int i =0; i< 100; i++)
            {
                realDB.Add(new SomeClass());
            }
            // end REST

            Report report = new Report();
            report.Load("report.frx");  
            report.RegisterData(realDB, "SomeTable");

            // show to console, but now only save prepared report
            report.Prepare();
            report.SavePrepared("report.fpx");
        }
    }
}
