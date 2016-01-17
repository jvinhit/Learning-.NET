using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public interface IGoAlgo
    {
        void go(); // phuong thuc nay ( hay thuat toan go) nay duoc su dung  onhieu doi tuong khac nhau.

    }
    // strategy nó sẽ tách biệt phần cần chỉnh sửa nhiều nơi ra 1 đối tượng. Khi chỉnh sửa thì ta chỉnh sửa trên đối tượng đó.
    //  Thuật toán hay thay đổi 
    public class GoDrivingAlgo : IGoAlgo
    {
        public void go()
        {
            Console.WriteLine("Bay gio, toi dang di");
        }
    }

    public class GoFlyAlgo : IGoAlgo
    {
        public void go()
        {
            Console.WriteLine("Bay gio, toi dang bay");
        }
    }

    public class GoFlyFastAlgo : IGoAlgo
    {
        public void go()
        {
            Console.WriteLine("Bay gio, toi dang bay rat nhanh");
        }
    }

    public  class Vehicle
    {
        // Algo variable : Bien nay se quyet dinh cac lop con se thuc hien chuc nang
        private IGoAlgo _igoAlgo;

        public Vehicle()
        {

        }
        // Day la cho quyet dinh thuat toan nao duoc thuc hien 
        public void setAlgo(IGoAlgo igo)
        {
            _igoAlgo = igo;
        }

        public void go()
        {
            _igoAlgo.go();
        }

    }
    public class StreetRacer : Vehicle
    {
        public StreetRacer()
        {
            this.setAlgo(new GoDrivingAlgo());
        }

    }

    public class FormulaOne : Vehicle
    {
        public FormulaOne()
        {
            this.setAlgo(new GoDrivingAlgo());
        }
    }

    public class Helicopter : Vehicle
    {
        public Helicopter()
        {
            this.setAlgo(new GoFlyAlgo());
            
        }
    }
    public class Jet : Vehicle
    {
        public Jet()
        {
            this.setAlgo(new GoFlyFastAlgo());
        }
    }
    

    class Program
    {
        static void Main(string[] args)
        {
            StreetRacer streetRacer = new StreetRacer();
            FormulaOne formulaOne = new FormulaOne();
            Helicopter helicopter = new Helicopter();
            Jet jet = new Jet();
            streetRacer.go();
            formulaOne.go();
            helicopter.go();
            jet.go();

            jet.setAlgo(new GoDrivingAlgo());
            jet.go();

            jet.setAlgo(new GoFlyAlgo());
            jet.go();
            
            jet.setAlgo(new GoFlyFastAlgo());
            jet.go();



        }
    }
}
