using CompositePattern.DA;
using System;
using System.Collections.Generic;
using static CompositePattern.Common.Helper;

namespace CompositePattern
{
    class Program
    {

        public static void Main(string[] args)
        {
            Corporation corporation = new Corporation("Corporation", "Corporation TEst");
            corporation.AddBusinessEntity(corporation);

            var company1 = new Company("Company1", "Company1");
            var company2 = new Company("Company2", "Company2");
            var company3 = new Company("Company3", "Company3");

            corporation.AddBusinessEntity(company1);
            corporation.AddBusinessEntity(company2);
            corporation.AddBusinessEntity(company3);

            var facilityA = new Facility("A", "A");
            var facilityB = new Facility("B", "B");
            var facilityC = new Facility("C", "C");
            var facilityD = new Facility("D", "D");
            var facilityE = new Facility("E", "E");
            var facilityF = new Facility("F", "F");
            var facilityJ = new Facility("J", "J");
            var facilityH = new Facility("H", "H");

            company1.AddBusinessEntity(facilityA);
            company1.AddBusinessEntity(facilityC);
            company1.AddBusinessEntity(facilityB);

            company2.AddBusinessEntity(facilityD);
            company2.AddBusinessEntity(facilityE);

            company3.AddBusinessEntity(facilityF);
            company3.AddBusinessEntity(facilityH);
            company3.AddBusinessEntity(facilityJ);

            var storage1 = new Storage("1", "1");
            var storage2 = new Storage("2", "2");
            var storage3 = new Storage("3", "3");
            var storage4 = new Storage("4", "4");
            var storage5 = new Storage("5", "5");
            var storage6 = new Storage("6", "6");
            var storage7 = new Storage("7", "7");
            var storage8 = new Storage("8", "8");
            var storage9 = new Storage("9", "9");

            facilityA.AddBusinessEntity(storage1);
            facilityB.AddBusinessEntity(storage2);
            facilityC.AddBusinessEntity(storage3);
            facilityC.AddBusinessEntity(storage4);
            facilityD.AddBusinessEntity(storage5);
            facilityE.AddBusinessEntity(storage6);
            facilityF.AddBusinessEntity(storage7);
            facilityH.AddBusinessEntity(storage8);
            facilityJ.AddBusinessEntity(storage9);

            foreach (var item in company1.GetChildren())
                Console.WriteLine((BusinessEntityType)item.Type + " " + item.Title + " " + item.Number);
        }
    }
}
