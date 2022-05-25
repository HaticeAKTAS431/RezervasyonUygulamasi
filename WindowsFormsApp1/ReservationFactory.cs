using System;

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
        return Antalya();
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

public class CreateATIzA: ReservationFactory
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
    return Aeroplane();
    return Bus();
}

public interface IAccomodation
{
    return Hotel();
    return Tent();
}

public interface IDeparture
{
    return Istanbul();
    return Antalya();
    return Izmir();
}

public interface IArrival
{
    return Istanbul();
    return Antalya();
    return Izmir();
}




public class Aeroplane : ITransportation
{
    return 300;
}

public class Bus : ITransportation
{
    return 150;
}





public class Hotel : IAccomodation
{
    return 250;
}

public class Tent : IAccomodation
{
    return 100;
}





public class Istanbul : IDeparture
{
    return ist;
}

public class Antalya : IDeparture
{
    return ant;
}

public class Izmir : IDeparture
{
     return iz;
}





public class Istanbul : IArrival
{
    return ist;
}

public class Antalya : IArrival
{
    return ant;
}

public class Izmir : IArrival
{
    return iz;
}

