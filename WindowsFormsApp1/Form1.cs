using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

      
       

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime gidisTarihi = dateTimePicker1.Value;
            DateTime donusTarihi = dateTimePicker2.Value;
            int sayi = Convert.ToInt32(textBox1.Text);
            donusTarihi = gidisTarihi.AddDays(sayi);
            dateTimePicker2.Text = donusTarihi.ToString();
        } 
        
     
    }

    public class PanelGnerator 
    {
        private ReservationFactory _reservationFactory;
        private int Transportation = _transportation;
        private int Accomodation = _accomodation;
        private string Departure = _departure;
        private string Arrival = _arrival;

        public PanelGnerator(ReservationFactory reservationFactory)
        {
            _reservationFactory = reservationFactory;
            _transportation = _reservationFactory.CreateTransportation();
            _accomodation = _reservationFactory.CreateAccomodation();
            _departure = _reservationFactory.CreateDeparture();
            _arrival = _reservationFactory.CreateArrival();
        }



  
   // using System;
   // using System.Collections.Generic;
  //  using System.ComponentModel;
  //  using System.Data;
  //  using System.Drawing;
  //  using System.Linq;
  //  using System.Text;
  //  using System.Threading.Tasks;
  //  using System.Windows.Forms;


//namespace WindowsFormsApp1
//{
    public abstract class ReservationFactory 
    {
        public abstract ITransportation CreateTransportation();
        public abstract IAccomodation CreateAccomodation();
        public abstract IDeparture CreateDeparture();
        public abstract IArrival CreateArrival();
    }


    public class CreateAHIsA : ReservationFactory
    {
        public override ITransportation CreateTransportation()
        {
            return new Aeroplane();
        }

        public override IAccomodation CreateAccomodation()
        {
            return new Hotel();
        }

        public override IDeparture CreateDeparture()
        {
            return new Istanbul();
        }

        public override IArrival CreateArrival()
        {
            return new Antalya();
        }
    }

    public class CreateAHIsIz : ReservationFactory
    {
        public override ITransportation CreateTransportation()
        {
            return Aeroplane();
        }

        public override IAccomodation CreateAccomodation()
        {
            return Hotel();
        }

        public override IDeparture CreateDeparture()
        {
            return Istanbul();
        }

        public override IArrival CreateArrival()
        {
            return Izmir();
        }
    }

    public class CreateAHAIs : ReservationFactory
    {
        public override ITransportation CreateTransportation()
        {
            return Aeroplane();
        }

        public override IAccomodation CreateAccomodation()
        {
            return Hotel();
        }

        public override IDeparture CreateDeparture()
        {
            return Antalya();
        }

        public override IArrival CreateArrival()
        {
            return Istanbul();
        }
    }

    public class CreateAHAIz : ReservationFactory
    {
        public override ITransportation CreateTransportation()
        {
            return Aeroplane();
        }

        public override IAccomodation CreateAccomodation()
        {
            return Hotel();
        }

        public override IDeparture CreateDeparture()
        {
            return Antalya();
        }

        public override IArrival CreateArrival()
        {
            return Izmir();
        }
    }

    public class CreateAHIzIs : ReservationFactory
    {
        public override ITransportation CreateTransportation()
        {
            return Aeroplane();
        }

        public override IAccomodation CreateAccomodation()
        {
            return Hotel();
        }

        public override IDeparture CreateDeparture()
        {
            return Izmir();
        }

        public override IArrival CreateArrival()
        {
            return Istanbul();
        }
    }

    public class CreateAHIzA : ReservationFactory
    {
        public override ITransportation CreateTransportation()
        {
            return Aeroplane();
        }

        public override IAccomodation CreateAccomodation()
        {
            return Hotel();
        }

        public override IDeparture CreateDeparture()
        {
            return Izmir();
        }

        public override IArrival CreateArrival()
        {
            return Antalya();
        }
    }


    public class CreateBHIsA : ReservationFactory
    {
        public override ITransportation CreateTransportation()
        {
            return Bus();
        }

        public override IAccomodation CreateAccomodation()
        {
            return Hotel();
        }

        public override IDeparture CreateDeparture()
        {
            return Istanbul();
        }

        public override IArrival CreateArrival()
        {
            return Antalya();
        }
    }

    public class CreateBHIsIz : ReservationFactory
    {
        public override ITransportation CreateTransportation()
        {
            return Bus();
        }

        public override IAccomodation CreateAccomodation()
        {
            return Hotel();
        }

        public override IDeparture CreateDeparture()
        {
            return Istanbul();
        }

        public override IArrival CreateArrival()
        {
            return Izmir();
        }
    }

    public class CreateBHAIs : ReservationFactory
    {
        public override ITransportation CreateTransportation()
        {
            return Bus();
        }

        public override IAccomodation CreateAccomodation()
        {
            return Hotel();
        }

        public override IDeparture CreateDeparture()
        {
            return Antalya();
        }

        public override IArrival CreateArrival()
        {
            return Istanbul();
        }
    }

    public class CreateBHAIz : ReservationFactory
    {
        public override ITransportation CreateTransportation()
        {
            return Bus();
        }

        public override IAccomodation CreateAccomodation()
        {
            return Hotel();
        }

        public override IDeparture CreateDeparture()
        {
            return Antalya();
        }

        public override IArrival CreateArrival()
        {
            return Izmir();
        }
    }

    public class CreateBHIzIs : ReservationFactory
    {
        public override ITransportation CreateTransportation()
        {
            return Bus();
        }

        public override IAccomodation CreateAccomodation()
        {
            return Hotel();
        }

        public override IDeparture CreateDeparture()
        {
            return Izmir();
        }

        public override IArrival CreateArrival()
        {
            return Istanbul();
        }
    }

    public class CreateBHIzA : ReservationFactory
    {
        public override ITransportation CreateTransportation()
        {
            return Bus();
        }

        public override IAccomodation CreateAccomodation()
        {
            return Hotel();
        }

        public override IDeparture CreateDeparture()
        {
            return Izmir();
        }

        public override IArrival CreateArrival()
        {
            return Antalya();
        }
    }


    public class CreateATIsA : ReservationFactory
    {
        public override ITransportation CreateTransportation()
        {
            return Aeroplane();
        }

        public override IAccomodation CreateAccomodation()
        {
            return Tent();
        }

        public override IDeparture CreateDeparture()
        {
            return Istanbul();
        }

        public override IArrival CreateArrival()
        {
            return Antalya();
        }
    }

    public class CreateATIsIz : ReservationFactory
    {
        public override ITransportation CreateTransportation()
        {
            return Aeroplane();
        }

        public override IAccomodation CreateAccomodation()
        {
            return Tent();
        }

        public override IDeparture CreateDeparture()
        {
            return Istanbul();
        }

        public override IArrival CreateArrival()
        {
            return Izmir();
        }
    }

    public class CreateATAIs : ReservationFactory
    {
        public override ITransportation CreateTransportation()
        {
            return Aeroplane();
        }

        public override IAccomodation CreateAccomodation()
        {
            return Tent();
        }

        public override IDeparture CreateDeparture()
        {
            return Antalya();
        }

        public override IArrival CreateArrival()
        {
            return Istanbul();
        }
    }

    public class CreateATAIz : ReservationFactory
    {
        public override ITransportation CreateTransportation()
        {
            return Aeroplane();
        }

        public override IAccomodation CreateAccomodation()
        {
            return Tent();
        }

        public override IDeparture CreateDeparture()
        {
            return Antalya();
        }

        public override IArrival CreateArrival()
        {
            return Izmir();
        }
    }

    public class CreateATIzIs : ReservationFactory
    {
        public override ITransportation CreateTransportation()
        {
            return Aeroplane();
        }

        public override IAccomodation CreateAccomodation()
        {
            return Tent();
        }

        public override IDeparture CreateDeparture()
        {
            return Izmir();
        }

        public override IArrival CreateArrival()
        {
            return Istanbul();
        }
    }

    public class CreateATIzA : ReservationFactory
    {
        public override ITransportation CreateTransportation()
        {
            return Aeroplane();
        }

        public override IAccomodation CreateAccomodation()
        {
            return Tent();
        }

        public override IDeparture CreateDeparture()
        {
            return Izmir();
        }

        public override IArrival CreateArrival()
        {
            return Antalya();
        }
    }


    public class CreateBTIsA : ReservationFactory
    {
        public override ITransportation CreateTransportation()
        {
            return Bus();
        }

        public override IAccomodation CreateAccomodation()
        {
            return Tent();
        }

        public override IDeparture CreateDeparture()
        {
            return Istanbul();
        }

        public override IArrival CreateArrival()
        {
            return Antalya();
        }
    }

    public class CreateBTIsIz : ReservationFactory
    {
        public override ITransportation CreateTransportation()
        {
            return Bus();
        }

        public override IAccomodation CreateAccomodation()
        {
            return Tent();
        }

        public override IDeparture CreateDeparture()
        {
            return Istanbul();
        }

        public override IArrival CreateArrival()
        {
            return Izmir();
        }
    }

    public class CreateBTAIs : ReservationFactory
    {
        public override ITransportation CreateTransportation()
        {
            return Bus();
        }

        public override IAccomodation CreateAccomodation()
        {
            return Tent();
        }

        public override IDeparture CreateDeparture()
        {
            return Antalya();
        }

        public override IArrival CreateArrival()
        {
            return Istanbul();
        }
    }

    public class CreateBTAIz : ReservationFactory
    {
        public override ITransportation CreateTransportation()
        {
            return Bus();
        }

        public override IAccomodation CreateAccomodation()
        {
            return Tent();
        }

        public override IDeparture CreateDeparture()
        {
            return Antalya();
        }

        public override IArrival CreateArrival()
        {
            return Izmir();
        }
    }

    public class CreateBTIzIs : ReservationFactory
    {
        public override ITransportation CreateTransportation()
        {
            return Bus();
        }

        public override IAccomodation CreateAccomodation()
        {
            return Tent();
        }

        public override IDeparture CreateDeparture()
        {
            return Izmir();
        }

        public override IArrival CreateArrival()
        {
            return Istanbul();
        }
    }

    public class CreateBTIzA : ReservationFactory
    {
        public override ITransportation CreateTransportation()
        {
            return Bus();
        }

        public override IAccomodation CreateAccomodation()
        {
            return Tent();
        }

        public override IDeparture CreateDeparture()
        {
            return Izmir();
        }

        public override IArrival CreateArrival()
        {
            return Antalya();
        }
    }




    public interface ITransportation
    {
        public string Tra()
        {   
                return Aeroplane();
        }
 
        public string Tran()
        {   
                return Bus();
        }
    }

    public interface IAccomodation
    {
        public string Acc()
        {   
                return Hotel();
        }

        public string Acco()
        {   
                return Tent();
        }
    }

    public interface IDeparture
    {
        public string Dep()
        {   
                return Istanbul();
        }
        
        public string Depa()
        {   
                return Antalya();
        }
                
        public string Depar()
        {   
                return Izmir();
        }
    }

    public interface IArrival
    {
        public string Arr()
        {   
                return Istanbul();
        }
        
        public string Arri()
        {   
                return Antalya();
        }
                
        public string Arriv()
        {   
                return Izmir();
        }
    }



    public class Aeroplane : ITransportation
    {
            public int transpordation()
            {
                    return 300;
            }

    }

    public class Bus : ITransportation
    {
             public int transpordation()
            {
                    return 150;
            }
    }





    public class Hotel : IAccomodation
    {
            public int accomodation()
            {
            return 250;
            }
    }

    public class Tent : IAccomodation
    {
            public int accomodation()
            {
                    return 100;
            }
    }




    public class Istanbul : IDeparture
    {
            public string departure()
            {
                    return ist;
            }

    }

    public class Antalya : IDeparture
    {
            public string departure()
            {
                    return ant;
            }
    }

    public class Izmir : IDeparture
    {
            public string departure()
            {
                    return iz;
            }
    }




    public class IstanbulA : IArrival
    {
            public string arrival()
            {
                    return ist;
            }
    }

    public class AntalyaA : IArrival
    {
            public string arrival()
            {
                    return ant;
            }
    }

    public class IzmirA : IArrival
    {
            public string arrival()
            {
                    return iz;
            }
    }

}

           private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            Form2 form2 = new Form2();
            
            form2.ShowDialog();
           
        }

   // }
}
